using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BotLauncher.Models.Telegram;

namespace BotLauncher.Services.Telegram
{
    /// <summary>
    /// Сервис автоматической отправки сообщений в группы
    /// </summary>
    public class TelegramAutoSender : IDisposable
    {
        private readonly TelegramBotService _botService;
        private readonly TelegramTemplatesService _templatesService;
        private readonly TelegramManualSender _manualSender;

        // Хранилище задач для каждой группы
        private readonly ConcurrentDictionary<long, AutoSendTask> _activeTasks = new();

        private static void Log(string message)
        {
            try
            {
                string logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_debug.log");
                System.IO.File.AppendAllText(logPath, $"[{DateTime.Now:HH:mm:ss.fff}] [AutoSender] {message}{Environment.NewLine}");
            }
            catch { }
        }

        // ✅ ВАРИАНТ 2: Принимаем готовый экземпляр manualSender извне
        public TelegramAutoSender(
            TelegramBotService botService,
            TelegramTemplatesService templatesService,
            TelegramManualSender manualSender)
        {
            _botService = botService;
            _templatesService = templatesService;
            _manualSender = manualSender;
        }

        /// <summary>
        /// Запустить автоматическую отправку для группы
        /// </summary>
        public Task<bool> StartAutoSendAsync(
            long chatId,
            string templateName,
            int intervalSeconds,
            int retryCount,
            int retryDelaySeconds,
            int maxMessagesPerSession)
        {
            if (_activeTasks.ContainsKey(chatId))
            {
                Log($"⚠️ Для группы {chatId} уже запущена автоотправка!");
                return Task.FromResult(false);
            }

            var task = new AutoSendTask
            {
                ChatId = chatId,
                TemplateName = templateName,
                IntervalSeconds = intervalSeconds,
                RetryCount = retryCount,
                RetryDelaySeconds = retryDelaySeconds,
                MaxMessagesPerSession = maxMessagesPerSession,
                CancellationTokenSource = new CancellationTokenSource()
            };

            _activeTasks[chatId] = task;
            Log($"🚀 Запуск автоотправки для группы {chatId} | Интервал: {intervalSeconds}с | Повторы: {retryCount} | Макс. сообщений: {(maxMessagesPerSession == 0 ? "без лимита" : maxMessagesPerSession.ToString())}");

            // Запускаем цикл в фоне, не блокируя основной поток
            _ = RunAutoSendLoopAsync(task);

            return Task.FromResult(true);
        }

        /// <summary>
        /// Остановить автоматическую отправку для группы
        /// </summary>
        public bool StopAutoSend(long chatId)
        {
            if (_activeTasks.TryRemove(chatId, out var task))
            {
                task.CancellationTokenSource.Cancel();
                task.CancellationTokenSource.Dispose();
                Log($"⏹️ Остановлена автоотправка для группы {chatId}");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Остановить все активные автоотправки
        /// </summary>
        public void StopAll()
        {
            foreach (var chatId in _activeTasks.Keys.ToList())
            {
                StopAutoSend(chatId);
            }
        }

        /// <summary>
        /// Проверить, запущена ли автоотправка для группы
        /// </summary>
        public bool IsRunning(long chatId) => _activeTasks.ContainsKey(chatId);

        /// <summary>
        /// Получить статистику по группе
        /// </summary>
        public AutoSendStats? GetStats(long chatId)
        {
            if (_activeTasks.TryGetValue(chatId, out var task))
            {
                return new AutoSendStats
                {
                    IsRunning = true,
                    MessagesSent = task.MessagesSent,
                    LastSendTime = task.LastSendTime,
                    LastError = task.LastError
                };
            }
            return null;
        }

        /// <summary>
        /// Основной цикл автоматической отправки
        /// </summary>
        private async Task RunAutoSendLoopAsync(AutoSendTask task)
        {
            var token = task.CancellationTokenSource.Token;
            int consecutiveErrors = 0;

            try
            {
                while (!token.IsCancellationRequested)
                {
                    // Проверка лимита сообщений
                    if (task.MaxMessagesPerSession > 0 && task.MessagesSent >= task.MaxMessagesPerSession)
                    {
                        Log($"✅ Достигнут лимит сообщений ({task.MaxMessagesPerSession}) для группы {task.ChatId}");
                        break;
                    }

                    try
                    {
                        Log($"📨 Отправка сообщения в группу {task.ChatId} (попытка {task.MessagesSent + 1})");

                        // ✅ Вызов обновленного метода с поддержкой CancellationToken
                        var result = await _manualSender.SendMessageAsync(
                            chatId: task.ChatId,
                            customText: null,
                            templateName: task.TemplateName,
                            delaySeconds: 0,
                            maxRetries: task.RetryCount,
                            retryInterval: task.RetryDelaySeconds,
                            autoDeleteSeconds: 0,
                            sendTemplateFirst: false,
                            silent: false,
                            disablePreview: false,
                            cancellationToken: token,
                            onProgress: null);

                        if (result.Success)
                        {
                            task.MessagesSent++;
                            task.LastSendTime = DateTime.Now;
                            consecutiveErrors = 0;
                            Log($"✅ Успешно отправлено. Всего: {task.MessagesSent}");
                        }
                        else if (result.Cancelled)
                        {
                            Log($"⚠️ Автоотправка для группы {task.ChatId} была отменена");
                            break;
                        }
                        else
                        {
                            consecutiveErrors++;
                            task.LastError = result.ErrorMessage ?? "Отправка вернула false";
                            Log($"❌ Ошибка отправки: {task.LastError}. Ошибок подряд: {consecutiveErrors}");

                            // Обработка повторных попыток
                            if (consecutiveErrors <= task.RetryCount && task.RetryCount > 0)
                            {
                                Log($"🔄 Повторная попытка через {task.RetryDelaySeconds} сек...");
                                await Task.Delay(task.RetryDelaySeconds * 1000, token);
                                continue;
                            }
                            else
                            {
                                Log($"⛔ Превышено максимальное количество ошибок ({task.RetryCount}). Остановка.");
                                break;
                            }
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        Log($"⚠️ Автоотправка для группы {task.ChatId} была отменена (OperationCanceled)");
                        break;
                    }
                    catch (Exception ex)
                    {
                        consecutiveErrors++;
                        task.LastError = ex.Message;
                        Log($"❌ Исключение при отправке: {ex.Message}");

                        if (consecutiveErrors > task.RetryCount && task.RetryCount > 0)
                        {
                            Log($"⛔ Превышено максимальное количество ошибок ({task.RetryCount}). Остановка.");
                            break;
                        }
                    }

                    // Ожидание до следующей отправки
                    if (!token.IsCancellationRequested && task.IntervalSeconds > 0)
                    {
                        Log($"⏳ Ожидание {task.IntervalSeconds} сек до следующей отправки...");
                        await Task.Delay(task.IntervalSeconds * 1000, token);
                    }
                }
            }
            finally
            {
                _activeTasks.TryRemove(task.ChatId, out _);
                Log($"🏁 Завершен цикл автоотправки для группы {task.ChatId}. Всего отправлено: {task.MessagesSent}");
            }
        }

        public void Dispose()
        {
            StopAll();
        }

        #region Вспомогательные классы

        private class AutoSendTask
        {
            public long ChatId { get; set; }
            public string TemplateName { get; set; } = "";
            public int IntervalSeconds { get; set; }
            public int RetryCount { get; set; }
            public int RetryDelaySeconds { get; set; }
            public int MaxMessagesPerSession { get; set; }
            public CancellationTokenSource CancellationTokenSource { get; set; } = new();
            public int MessagesSent { get; set; } = 0;
            public DateTime? LastSendTime { get; set; }
            public string? LastError { get; set; }
        }

        public class AutoSendStats
        {
            public bool IsRunning { get; set; }
            public int MessagesSent { get; set; }
            public DateTime? LastSendTime { get; set; }
            public string? LastError { get; set; }
        }

        #endregion
    }
}