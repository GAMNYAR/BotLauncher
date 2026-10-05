using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BotLauncher.Models.Telegram;
using Telegram.Bot.Types.Enums;

namespace BotLauncher.Services.Telegram
{
    public class SendProgress
    {
        public string Stage { get; set; } = "";
        public int CurrentDelay { get; set; }
        public int CurrentInterval { get; set; }
        public int CurrentRetries { get; set; }
        public int CurrentAutoDelete { get; set; }
        public int MessagesSent { get; set; }
        public string Message { get; set; } = "";
    }

    public class SendMessageResult
    {
        public bool Success { get; set; }
        public bool Cancelled { get; set; }
        public List<int> MessageIds { get; set; } = new();
        public string? ErrorMessage { get; set; }
    }

    public class TelegramManualSender
    {
        private readonly TelegramBotService _botService;
        private readonly TelegramTemplatesService _templatesService;

        private static void Log(string message)
        {
            try
            {
                string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_debug.log");
                File.AppendAllText(logPath, $"[{DateTime.Now:HH:mm:ss.fff}] [Sender] {message}{Environment.NewLine}");
            }
            catch { }
        }

        public TelegramManualSender(TelegramBotService botService, TelegramTemplatesService templatesService)
        {
            _botService = botService;
            _templatesService = templatesService;
        }

        public async Task<SendMessageResult> SendMessageAsync(
            long chatId,
            string? customText,
            string? templateName,
            int delaySeconds,
            int maxRetries,
            int retryInterval,
            int autoDeleteSeconds,
            bool sendTemplateFirst,
            bool silent,
            bool disablePreview,
            CancellationToken cancellationToken,
            Action<SendProgress>? onProgress = null)
        {
            var result = new SendMessageResult();
            var sentMessageIds = new List<int>();

            try
            {
                Log($"=== НАЧАЛО СЕССИИ === ChatId: {chatId}");
                Log($"Delay: {delaySeconds}, Retries: {maxRetries}, Interval: {retryInterval}, AutoDelete: {autoDeleteSeconds}");

                string? messageText = null;
                List<string>? attachments = null;
                bool hasCustomText = !string.IsNullOrWhiteSpace(customText);
                bool hasTemplate = !string.IsNullOrWhiteSpace(templateName);

                if (hasCustomText)
                {
                    messageText = customText!.Trim();
                    Log("✅ Пользовательский текст будет отправлен.");
                }

                if (hasTemplate)
                {
                    var template = _templatesService.GetAll().FirstOrDefault(t => t.Name == templateName);
                    if (template != null)
                    {
                        if (messageText == null) messageText = template.Message;
                        attachments = template.Attachments;
                        Log("✅ Шаблон найден.");
                    }
                    else
                    {
                        Log("❌ Шаблон не найден!");
                        hasTemplate = false;
                    }
                }

                if (string.IsNullOrWhiteSpace(messageText) && (attachments == null || !attachments.Any()))
                {
                    result.ErrorMessage = "Нет текста или файлов для отправки";
                    Log("❌ ОШИБКА: Нет текста или файлов для отправки!");
                    onProgress?.Invoke(new SendProgress { Stage = "error", Message = result.ErrorMessage });
                    return result;
                }

                // ЭТАП 1: ЗАДЕРЖКА
                if (delaySeconds > 0)
                {
                    Log($"⏱️ Этап 1: Задержка {delaySeconds} сек...");
                    onProgress?.Invoke(new SendProgress { Stage = "delay", CurrentDelay = delaySeconds, CurrentRetries = maxRetries, CurrentInterval = retryInterval, CurrentAutoDelete = autoDeleteSeconds });

                    for (int i = delaySeconds; i > 0; i--)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        await Task.Delay(1000, cancellationToken);
                        onProgress?.Invoke(new SendProgress { Stage = "delay", CurrentDelay = i - 1, CurrentRetries = maxRetries, CurrentInterval = retryInterval, CurrentAutoDelete = autoDeleteSeconds });
                    }
                }

                // ЭТАП 2: ОТПРАВКА ПЕРВОГО СООБЩЕНИЯ
                Log("📤 Отправка первого сообщения...");
                onProgress?.Invoke(new SendProgress { Stage = "sending", MessagesSent = 0, CurrentRetries = maxRetries, CurrentInterval = retryInterval, CurrentAutoDelete = autoDeleteSeconds });

                int? firstMsgId = await SendMessageCoreAsync(chatId, messageText, attachments, silent, disablePreview, cancellationToken);
                if (!firstMsgId.HasValue || firstMsgId.Value <= 0)
                {
                    result.ErrorMessage = "Не удалось отправить первое сообщение";
                    Log($"❌ ОШИБКА: {result.ErrorMessage}");
                    onProgress?.Invoke(new SendProgress { Stage = "error", Message = result.ErrorMessage });
                    return result;
                }

                sentMessageIds.Add(firstMsgId.Value);
                Log($"✅ Первое сообщение отправлено. ID: {firstMsgId.Value}");
                onProgress?.Invoke(new SendProgress { Stage = "sending", MessagesSent = 1, CurrentRetries = maxRetries, CurrentInterval = retryInterval, CurrentAutoDelete = autoDeleteSeconds });

                // ЭТАП 3: ЦИКЛ ПОВТОРЕНИЙ
                int remainingRetries = maxRetries;
                while (remainingRetries > 0)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    if (retryInterval > 0)
                    {
                        Log($"⏳ Интервал повтора: {retryInterval} сек...");
                        onProgress?.Invoke(new SendProgress { Stage = "interval", CurrentInterval = retryInterval, CurrentRetries = remainingRetries, MessagesSent = sentMessageIds.Count, CurrentAutoDelete = autoDeleteSeconds });

                        for (int i = retryInterval; i > 0; i--)
                        {
                            cancellationToken.ThrowIfCancellationRequested();
                            await Task.Delay(1000, cancellationToken);
                            onProgress?.Invoke(new SendProgress { Stage = "interval", CurrentInterval = i - 1, CurrentRetries = remainingRetries, MessagesSent = sentMessageIds.Count, CurrentAutoDelete = autoDeleteSeconds });
                        }
                    }

                    Log($"🔄 Повтор #{maxRetries - remainingRetries + 1} из {maxRetries}...");
                    onProgress?.Invoke(new SendProgress { Stage = "retries", CurrentRetries = remainingRetries, MessagesSent = sentMessageIds.Count, CurrentInterval = retryInterval, CurrentAutoDelete = autoDeleteSeconds });

                    int? repeatMsgId = await SendMessageCoreAsync(chatId, messageText, attachments, silent, disablePreview, cancellationToken);
                    if (!repeatMsgId.HasValue || repeatMsgId.Value <= 0)
                    {
                        result.ErrorMessage = $"Не удалось отправить повтор #{maxRetries - remainingRetries + 1}";
                        Log($"❌ ОШИБКА при повторе: {result.ErrorMessage}");
                        onProgress?.Invoke(new SendProgress { Stage = "error", Message = result.ErrorMessage });
                        return result;
                    }

                    sentMessageIds.Add(repeatMsgId.Value);
                    remainingRetries--;
                    Log($"✅ Повтор отправлен. ID: {repeatMsgId.Value}. Осталось повторов: {remainingRetries}");
                    onProgress?.Invoke(new SendProgress { Stage = "retries", CurrentRetries = remainingRetries, MessagesSent = sentMessageIds.Count, CurrentInterval = retryInterval, CurrentAutoDelete = autoDeleteSeconds });
                }

                Log($"✅ Все повторы завершены.");
                onProgress?.Invoke(new SendProgress
                {
                    Stage = "interval",
                    CurrentInterval = 0,
                    CurrentRetries = 0,
                    MessagesSent = sentMessageIds.Count,
                    CurrentAutoDelete = autoDeleteSeconds
                });

                // ЭТАП 4: АВТОУДАЛЕНИЕ
                if (autoDeleteSeconds > 0)
                {
                    Log($"🗑️ Этап 4: Автоудаление через {autoDeleteSeconds} сек...");
                    onProgress?.Invoke(new SendProgress { Stage = "autodelete", CurrentAutoDelete = autoDeleteSeconds, MessagesSent = sentMessageIds.Count });

                    for (int i = autoDeleteSeconds; i > 0; i--)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        await Task.Delay(1000, cancellationToken);
                        onProgress?.Invoke(new SendProgress { Stage = "autodelete", CurrentAutoDelete = i - 1, MessagesSent = sentMessageIds.Count });
                    }

                    Log($"🗑️ Удаление {sentMessageIds.Count} сообщений...");
                    onProgress?.Invoke(new SendProgress { Stage = "deleting", MessagesSent = sentMessageIds.Count });

                    foreach (var msgId in sentMessageIds)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        bool deleted = await _botService.DeleteMessageAsync(chatId, msgId);
                        Log($"🗑️ Сообщение {msgId}: {(deleted ? "удалено" : "ошибка")}");
                    }
                    Log("✅ Все сообщения удалены.");
                }

                result.Success = true;
                result.MessageIds = sentMessageIds;
                Log($"=== СЕССИЯ ЗАВЕРШЕНА УСПЕШНО. Всего сообщений: {sentMessageIds.Count} ===");
                onProgress?.Invoke(new SendProgress { Stage = "done", MessagesSent = sentMessageIds.Count });
                return result;
            }
            catch (OperationCanceledException)
            {
                result.Cancelled = true;
                Log("⚠️ Сессия отменена пользователем.");

                if (sentMessageIds.Any())
                {
                    Log($"🗑️ Удаление {sentMessageIds.Count} сообщений после отмены...");
                    foreach (var msgId in sentMessageIds)
                    {
                        await _botService.DeleteMessageAsync(chatId, msgId);
                    }
                }

                onProgress?.Invoke(new SendProgress { Stage = "cancelled", Message = "Сессия отменена пользователем" });
                return result;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                Log($"❌ КРИТИЧЕСКАЯ ОШИБКА: {ex.GetType().Name} - {ex.Message}");
                onProgress?.Invoke(new SendProgress { Stage = "error", Message = result.ErrorMessage });
                return result;
            }
        }

        private async Task<int?> SendMessageCoreAsync(
            long chatId,
            string? messageText,
            List<string>? attachments,
            bool silent,
            bool disablePreview,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (attachments != null && attachments.Any())
            {
                return await SendWithAttachmentsAsync(chatId, messageText ?? "", attachments, silent, disablePreview, cancellationToken);
            }
            else
            {
                return await _botService.SendMessageAsync(chatId, messageText ?? "", silent, disablePreview, false, false, null, ParseMode.Html);
            }
        }

        // ✅ УПРОЩЕНО: Теперь мы просто передаем пути к файлам в новый метод SendMediaAsync, 
        // который сам определит типы файлов и применит HTML-разметку.
        private async Task<int?> SendWithAttachmentsAsync(
            long chatId,
            string messageText,
            List<string> attachmentPaths,
            bool silent,
            bool disablePreview,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // Фильтруем существующие файлы и берем максимум 10 (лимит Telegram для медиагруппы)
            var validPaths = attachmentPaths
                .Where(System.IO.File.Exists)
                .Take(10)
                .ToList();

            if (!validPaths.Any())
            {
                Log("⚠️ Нет валидных файлов для отправки. Отправляем только текст.");
                return await _botService.SendMessageAsync(chatId, messageText, silent, disablePreview, false, false, null, ParseMode.Html);
            }

            Log($"🚀 Отправка медиагруппы ({validPaths.Count} файлов)...");

            // Используем новый метод SendMediaAsync
            return await _botService.SendMediaAsync(
                chatId,
                messageText,
                validPaths,
                silent,
                disablePreview,
                hasSpoiler: false,
                protectContent: false,
                replyToMessageId: null,
                parseMode: ParseMode.Html
            );
        }
    }
}