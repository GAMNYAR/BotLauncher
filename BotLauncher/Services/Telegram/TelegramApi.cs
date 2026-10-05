using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace BotLauncher.Services.Telegram;

public class TelegramApi
{
    private TelegramBotClient? client;

    public bool IsInitialized => client != null;

    public event Action<Update>? UpdateReceived;

    private readonly ConcurrentDictionary<long, int> _lastMessageIds = new();

    private static void Log(string message)
    {
        try
        {
            string logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_debug.log");
            System.IO.File.AppendAllText(logPath, $"[{DateTime.Now:HH:mm:ss.fff}] [API] {message}{Environment.NewLine}");
        }
        catch { }
    }

    #region Initialization

    public void Initialize(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            throw new ArgumentException("Telegram bot token пустой.", nameof(token));

        Log($"Инициализация бота с токеном: {token.Substring(0, 10)}...");
        client = new TelegramBotClient(token);
    }

    #endregion

    #region File operations

    public async Task<byte[]?> DownloadChatPhotoAsync(long chatId)
    {
        EnsureInitialized();
        try
        {
            var chat = await client!.GetChat(chatId);
            if (chat.Photo == null) return null;

            string fileId = chat.Photo.BigFileId;
            var fileInfo = await client!.GetFile(fileId);

            if (string.IsNullOrEmpty(fileInfo.FilePath)) return null;

            using var stream = new MemoryStream();
            await client!.DownloadFile(fileInfo.FilePath, stream);
            return stream.ToArray();
        }
        catch (Exception ex)
        {
            Log($"Ошибка загрузки аватарки: {ex.Message}");
            return null;
        }
    }

    #endregion

    #region Bot & Chat information

    public async Task<User> GetMeAsync()
    {
        EnsureInitialized();
        Log("Попытка вызова GetMe...");
        try
        {
            var user = await client!.GetMe();
            Log($"GetMe успешен! Бот: @{user.Username} (ID: {user.Id})");
            return user;
        }
        catch (Exception ex)
        {
            Log($"КРИТИЧЕСКАЯ ОШИБКА GetMe: {ex.GetType().Name} - {ex.Message}");
            throw;
        }
    }

    public async Task<Chat> GetChatAsync(string chatIdOrUsername)
    {
        EnsureInitialized();
        return await client!.GetChat(chatIdOrUsername);
    }

    public async Task<int> GetChatMemberCountAsync(long chatId)
    {
        EnsureInitialized();
        return await client!.GetChatMemberCount(chatId);
    }

    public async Task<ChatMember> GetChatMemberAsync(long chatId, long userId)
    {
        EnsureInitialized();
        return await client!.GetChatMember(chatId, userId);
    }

    #endregion

    #region Messages

    // ✅ ИСПРАВЛЕНО: Использование .GetValueOrDefault() для совместимости с любой версией библиотеки
    public async Task<int?> SendMessageAsync(long chatId, string text, bool silent = false,
        bool disablePreview = false, bool hasSpoiler = false, bool protectContent = false,
        int? replyToMessageId = null, ParseMode? parseMode = null)
    {
        EnsureInitialized();
        if (string.IsNullOrWhiteSpace(text)) return null;

        try
        {
            Log($"Попытка отправки текста в chatId: {chatId} (parseMode={parseMode})");

            var linkPreviewOptions = disablePreview
                ? new LinkPreviewOptions { IsDisabled = true }
                : null;

            IEnumerable<MessageEntity>? entities = null;
            if (hasSpoiler && parseMode == null)
            {
                entities = new[]
                {
                    new MessageEntity
                    {
                        Type = MessageEntityType.Spoiler,
                        Offset = 0,
                        Length = text.Length
                    }
                };
            }

            ReplyParameters? replyParameters = replyToMessageId.HasValue
                ? new ReplyParameters { MessageId = replyToMessageId.Value }
                : null;

            var message = await client!.SendMessage(
                chatId: chatId,
                text: text,
                parseMode: parseMode.GetValueOrDefault(), // ✅ Безопасное преобразование
                entities: entities,
                linkPreviewOptions: linkPreviewOptions,
                disableNotification: silent,
                protectContent: protectContent,
                replyParameters: replyParameters);

            Log($"Текст успешно отправлен! MessageId: {message.MessageId}");
            return message.MessageId;
        }
        catch (HttpRequestException httpEx)
        {
            Log($"СЕТЕВАЯ ОШИБКА: {httpEx.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Log($"Общая ошибка отправки: {ex.GetType().Name} - {ex.Message}");
            return null;
        }
    }

    // ✅ ИСПРАВЛЕНО: Правильное управление потоками файлов (FileStream)
    public async Task<int?> SendMediaAsync(long chatId, string caption, List<string> filePaths,
        bool silent = false, bool disablePreview = false, bool hasSpoiler = false,
        bool protectContent = false, int? replyToMessageId = null, ParseMode? parseMode = null)
    {
        EnsureInitialized();
        if (filePaths == null || filePaths.Count == 0) return null;

        var mediaGroup = new List<IAlbumInputMedia>();
        var streamsToDispose = new List<FileStream>(); // ✅ Список для хранения открытых потоков

        try
        {
            Log($"Попытка отправки {filePaths.Count} медиафайлов в chatId: {chatId}");

            for (int i = 0; i < filePaths.Count; i++)
            {
                var filePath = filePaths[i];
                Log($"📁 Обработка файла #{i + 1}: {filePath}");

                if (!System.IO.File.Exists(filePath))
                {
                    Log($"❌ Файл НЕ найден: {filePath}");
                    continue;
                }

                var extension = System.IO.Path.GetExtension(filePath).ToLower();
                bool isImage = extension == ".png" || extension == ".jpg" || extension == ".jpeg" ||
                              extension == ".gif" || extension == ".webp" || extension == ".bmp";
                bool isVideo = extension == ".mp4" || extension == ".avi" || extension == ".mov" ||
                              extension == ".mkv" || extension == ".webm";

                Log($"✅ Файл найден, размер: {new System.IO.FileInfo(filePath).Length} байт");
                Log($"📷 Тип файла: {(isImage ? "image" : isVideo ? "video" : "document")} ({extension})");

                // ✅ ОТКРЫВАЕМ поток и ДОБАВЛЯЕМ его в список для последующего закрытия
                var stream = System.IO.File.OpenRead(filePath);
                streamsToDispose.Add(stream);

                var fileName = System.IO.Path.GetFileName(filePath);
                var inputFile = new InputFileStream(stream, fileName);

                string? mediaCaption = (i == 0 && !string.IsNullOrWhiteSpace(caption)) ? caption : null;
                if (mediaCaption != null && mediaCaption.Length > 1024)
                {
                    mediaCaption = mediaCaption.Substring(0, 1021) + "...";
                    Log($"✂️ Caption обрезан до 1024 символов");
                }

                IAlbumInputMedia media;
                if (isImage)
                {
                    media = new InputMediaPhoto(inputFile)
                    {
                        Caption = mediaCaption,
                        ParseMode = parseMode.GetValueOrDefault(),
                        HasSpoiler = hasSpoiler
                    };
                }
                else if (isVideo)
                {
                    media = new InputMediaVideo(inputFile)
                    {
                        Caption = mediaCaption,
                        ParseMode = parseMode.GetValueOrDefault(),
                        HasSpoiler = hasSpoiler,
                        SupportsStreaming = true
                    };
                }
                else
                {
                    media = new InputMediaDocument(inputFile)
                    {
                        Caption = mediaCaption,
                        ParseMode = parseMode.GetValueOrDefault()
                    };
                }

                mediaGroup.Add(media);
                Log($"✅ Медиа добавлено в группу");
            }

            if (mediaGroup.Count == 0)
            {
                Log("❌ mediaGroup пустой! Ничего не отправлено.");
                return null;
            }

            Log($"🚀 Отправка медиагруппы ({mediaGroup.Count} файлов) в Telegram API...");

            ReplyParameters? replyParameters = replyToMessageId.HasValue
                ? new ReplyParameters { MessageId = replyToMessageId.Value }
                : null;

            var messages = await client!.SendMediaGroup(
                chatId: chatId,
                media: mediaGroup,
                disableNotification: silent,
                protectContent: protectContent,
                replyParameters: replyParameters);

            int? lastMessageId = null;
            if (messages != null && messages.Length > 0)
            {
                lastMessageId = messages[0].MessageId;
                Log($"✅ Медиагруппа УСПЕШНО отправлена! MessageId: {lastMessageId}");
            }

            // ✅ Если caption был обрезан или его не было — отправляем полный текст отдельным сообщением
            if (!string.IsNullOrWhiteSpace(caption) && caption.Length > 1024)
            {
                Log($"📝 Отправка полного текста отдельным сообщением ({caption.Length} символов)...");
                await Task.Delay(300); // Небольшая пауза для порядка в чате

                var fullTextMessage = await client!.SendMessage(
                    chatId: chatId,
                    text: caption,
                    parseMode: parseMode.GetValueOrDefault(),
                    disableNotification: silent,
                    linkPreviewOptions: disablePreview ? new LinkPreviewOptions { IsDisabled = true } : null,
                    protectContent: protectContent,
                    replyParameters: replyParameters);

                lastMessageId = fullTextMessage.MessageId;
                Log($"✅ Полный текст отправлен! MessageId: {lastMessageId}");
            }

            return lastMessageId;
        }
        catch (Exception ex)
        {
            Log($"❌ КРИТИЧЕСКАЯ ОШИБКА в SendMediaAsync:");
            Log($"   Тип: {ex.GetType().Name}");
            Log($"   Сообщение: {ex.Message}");
            return null;
        }
        finally
        {
            // ✅ ГАРАНТИРОВАННО закрываем все файлы после отправки (или при ошибке)
            foreach (var stream in streamsToDispose)
            {
                try
                {
                    stream.Dispose();
                }
                catch { }
            }
            Log("🔒 Потоки файлов закрыты.");
        }
    }

    public async Task<bool> DeleteMessageAsync(long chatId, int messageId)
    {
        EnsureInitialized();
        try
        {
            Log($"Удаление сообщения {messageId} в chatId: {chatId}");
            await client!.DeleteMessage(chatId, messageId);
            Log($"Сообщение {messageId} успешно удалено");
            return true;
        }
        catch (Exception ex)
        {
            Log($"Ошибка удаления сообщения {messageId}: {ex.Message}");
            return false;
        }
    }

    public async Task<int?> SendDiceAsync(long chatId, string emoji, CancellationToken cancellationToken = default)
    {
        EnsureInitialized();
        try
        {
            Log($"Попытка отправки Dice (emoji={emoji}) в chatId: {chatId}");
            var message = await client!.SendDice(chatId, emoji, cancellationToken: cancellationToken);
            Log($"Dice успешно отправлен! MessageId: {message.MessageId}");
            return message.MessageId;
        }
        catch (Exception ex)
        {
            Log($"Ошибка отправки Dice: {ex.GetType().Name} - {ex.Message}");
            return null;
        }
    }

    public async Task<bool> PinChatMessageAsync(long chatId, int messageId, CancellationToken cancellationToken = default)
    {
        EnsureInitialized();
        try
        {
            Log($"Попытка закрепить сообщение {messageId} в chatId: {chatId}");
            await client!.PinChatMessage(chatId, messageId, cancellationToken: cancellationToken);
            Log($"Сообщение {messageId} успешно закреплено");
            return true;
        }
        catch (Exception ex)
        {
            Log($"Ошибка закрепления сообщения {messageId}: {ex.Message}");
            return false;
        }
    }

    public async Task<bool> SetMessageReactionAsync(long chatId, int messageId, string emoji, CancellationToken cancellationToken = default)
    {
        EnsureInitialized();
        try
        {
            Log($"Попытка установить реакцию {emoji} на сообщение {messageId} в chatId: {chatId}");

            var reaction = new ReactionTypeEmoji { Emoji = emoji };

            await client!.SetMessageReaction(
                chatId: chatId,
                messageId: messageId,
                reaction: new ReactionType[] { reaction },
                isBig: true,
                cancellationToken: cancellationToken);

            Log($"Реакция {emoji} успешно установлена");
            return true;
        }
        catch (Exception ex)
        {
            Log($"Ошибка установки реакции: {ex.GetType().Name} - {ex.Message}");
            return false;
        }
    }

    public Task<int?> GetLastMessageIdAsync(long chatId, CancellationToken cancellationToken = default)
    {
        EnsureInitialized();
        try
        {
            if (_lastMessageIds.TryGetValue(chatId, out int lastId))
            {
                Log($"✅ Найдено последнее сообщение ID: {lastId} из кэша для чата {chatId}");
                return Task.FromResult<int?>(lastId);
            }

            Log($"⚠️ Последнее сообщение не найдено в кэше для чата {chatId}");
            return Task.FromResult<int?>(null);
        }
        catch (Exception ex)
        {
            Log($"❌ Ошибка получения последнего сообщения: {ex.GetType().Name} - {ex.Message}");
            return Task.FromResult<int?>(null);
        }
    }

    #endregion

    #region Receiving updates

    public void StartReceiving()
    {
        EnsureInitialized();
        Log("Запуск получения обновлений (StartReceiving)...");
        ReceiverOptions options = new() { AllowedUpdates = Array.Empty<UpdateType>() };
        client!.StartReceiving(HandleUpdateAsync, HandleErrorAsync, options);
    }

    public void StopReceiving()
    {
        if (client != null)
        {
            try
            {
                client = null;
                Log("Получение обновлений остановлено (клиент обнулен)");
            }
            catch (Exception ex)
            {
                Log($"Ошибка остановки получения обновлений: {ex.Message}");
            }
        }
    }

    private Task HandleUpdateAsync(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
    {
        try
        {
            UpdateReceived?.Invoke(update);

            long chatId = 0;
            int messageId = 0;
            bool hasMessage = false;

            if (update.Message != null)
            {
                chatId = update.Message.Chat.Id;
                messageId = update.Message.MessageId;
                hasMessage = true;
            }
            else if (update.ChannelPost != null)
            {
                chatId = update.ChannelPost.Chat.Id;
                messageId = update.ChannelPost.MessageId;
                hasMessage = true;
            }
            else if (update.EditedMessage != null)
            {
                chatId = update.EditedMessage.Chat.Id;
                messageId = update.EditedMessage.MessageId;
                hasMessage = true;
            }

            if (hasMessage && chatId != 0)
            {
                _lastMessageIds[chatId] = messageId;
            }
        }
        catch (Exception ex)
        {
            Log($"Ошибка обработки Update: {ex.Message}");
        }
        return Task.CompletedTask;
    }

    private Task HandleErrorAsync(ITelegramBotClient bot, Exception exception, CancellationToken cancellationToken)
    {
        Log($"Ошибка поллинга: {exception.Message}");
        return Task.CompletedTask;
    }

    #endregion

    #region Helpers

    private void EnsureInitialized()
    {
        if (client == null)
            throw new InvalidOperationException("Telegram Bot API не инициализирован.");
    }

    #endregion
}