using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BotLauncher.Models.Telegram;
using BotLauncher.Shared.Services;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramMessage = Telegram.Bot.Types.Message;

namespace BotLauncher.Services.Telegram;

public class TelegramBotService
{
    private readonly TelegramApi _api;
    private readonly TelegramGroupsService groupsService = AppServices.TelegramGroups;
    private readonly TelegramProfileManager profileManager = new TelegramProfileManager();

    private System.Threading.Timer? validationTimer;
    private int validationRunning;
    private static readonly TimeSpan ValidationInterval = TimeSpan.FromMinutes(5);

    public event Action<Update>? UpdateReceived;
    public event Action? BotConnected;
    public event Action? BotDisconnected;

    public TelegramBotInfo BotInfo { get; }
    public bool IsConnected { get; private set; }

    public TelegramBotService()
    {
        _api = new TelegramApi();
        BotInfo = new TelegramBotInfo();
        _api.UpdateReceived += OnTelegramUpdate;
    }

    #region Logging

    private static void Log(string message)
    {
        try
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_debug.log");
            System.IO.File.AppendAllText(logPath, $"[{DateTime.Now:HH:mm:ss.fff}] [Service] {message}{Environment.NewLine}");
        }
        catch { }
    }

    #endregion

    #region Chat operations

    public async Task<Chat?> GetChatAsync(long chatId)
    {
        if (!IsConnected) return null;
        try { return await _api.GetChatAsync(chatId.ToString()); }
        catch (Exception exception)
        {
            Log($"Не удалось получить информацию о чате {chatId}: {exception.Message}");
            return null;
        }
    }

    public async Task<Chat?> GetChatByUsernameAsync(string usernameOrId)
    {
        if (!IsConnected) return null;
        try
        {
            string cleanInput = usernameOrId.Trim();
            return await _api.GetChatAsync(cleanInput);
        }
        catch (Exception exception)
        {
            Log($"Не удалось получить информацию о чате {usernameOrId}: {exception.Message}");
            return null;
        }
    }

    public async Task<int> GetMembersCountAsync(long chatId)
    {
        if (!IsConnected) return 0;
        try { return await _api.GetChatMemberCountAsync(chatId); }
        catch (Exception exception)
        {
            Log($"Не удалось получить количество участников чата {chatId}: {exception.Message}");
            return 0;
        }
    }

    public async Task<byte[]?> GetChatPhotoAsync(long chatId)
    {
        if (!IsConnected) return null;
        try { return await _api.DownloadChatPhotoAsync(chatId); }
        catch (Exception exception)
        {
            Log($"Не удалось получить аватарку чата {chatId}: {exception.Message}");
            return null;
        }
    }

    #endregion

    #region Profile management

    private bool IsProfileCompatibleWithBot()
    {
        Log($"[Profile] IsProfileCompatibleWithBot вызван. IsProfileOpen={profileManager.IsProfileOpen}, BotInfo.Id={BotInfo.Id}");
        if (!profileManager.IsProfileOpen)
        {
            Log("[Profile] Профиль не открыт — совместимость = True");
            return true;
        }
        bool bound = profileManager.IsBoundToBot(BotInfo.Id);
        Log($"[Profile] Профиль открыт, IsBoundToBot={bound}");
        return bound;
    }

    private bool BindCurrentProfileToBot()
    {
        Log($"[Profile] BindCurrentProfileToBot вызван. IsProfileOpen={profileManager.IsProfileOpen}, BotInfo.Id={BotInfo.Id}");

        if (!profileManager.IsProfileOpen)
        {
            Log("[Profile] ✅ Профиль не открыт — привязка не требуется, возвращаем True");
            return true;
        }

        if (BotInfo.Id <= 0)
        {
            Log("[Profile] ❌ BotInfo.Id <= 0, возвращаем False");
            return false;
        }

        if (profileManager.IsBoundToBot(BotInfo.Id))
        {
            Log("[Profile] ✅ Бот уже привязан к профилю, возвращаем True");
            return true;
        }

        Log($"[Profile] Пытаемся привязать бота {BotInfo.Id} (@{BotInfo.Username}) к профилю...");
        bool result = profileManager.BindBot(BotInfo.Id, BotInfo.Username, BotInfo.FirstName, BotInfo.Token);
        Log($"[Profile] Результат BindBot: {result}");
        return result;
    }

    #endregion

    #region Update processing

    private async void OnTelegramUpdate(Update update)
    {
        try
        {
            UpdateReceived?.Invoke(update);
            if (update.MyChatMember != null)
            {
                await ProcessMyChatMemberUpdateAsync(update.MyChatMember);
                return;
            }
            if (update.Message != null)
            {
                if (await ProcessMigrationAsync(update.Message)) return;
                await ProcessMessageAsync(update.Message);
                return;
            }
            if (update.ChannelPost != null)
            {
                await ProcessChannelPostAsync(update.ChannelPost);
                return;
            }
        }
        catch (Exception exception)
        {
            Log($"Ошибка обработки Telegram Update: {exception.Message}");
        }
    }

    private async Task ProcessMyChatMemberUpdateAsync(ChatMemberUpdated update)
    {
        Chat chat = update.Chat;
        if (!IsSupportedChatType(chat.Type)) return;

        ChatMemberStatus oldStatus = update.OldChatMember.Status;
        ChatMemberStatus newStatus = update.NewChatMember.Status;

        Log($"Изменение статуса бота: {chat.Title} | {oldStatus} -> {newStatus}");

        if (IsBotRemoved(newStatus))
        {
            Log($"Бот больше не находится в чате: {chat.Title} | ID: {chat.Id}");
            return;
        }

        if (IsBotActive(newStatus))
        {
            await RefreshOrAddGroupAsync(chat);
        }
    }

    private static bool IsBotRemoved(ChatMemberStatus status) =>
        status == ChatMemberStatus.Left || status == ChatMemberStatus.Kicked;

    private static bool IsBotActive(ChatMemberStatus status) =>
        status == ChatMemberStatus.Member || status == ChatMemberStatus.Administrator ||
        status == ChatMemberStatus.Creator || status == ChatMemberStatus.Restricted;

    private async Task<bool> ProcessMigrationAsync(TelegramMessage message)
    {
        if (message.MigrateToChatId.HasValue)
        {
            long oldChatId = message.Chat.Id;
            long newChatId = message.MigrateToChatId.Value;
            Log($"Обнаружена миграция группы: {oldChatId} -> {newChatId}");
            bool migrated = groupsService.MigrateGroup(oldChatId, newChatId);
            await RefreshGroupAsync(newChatId);
            return true;
        }

        if (message.MigrateFromChatId.HasValue)
        {
            long newChatId = message.Chat.Id;
            long oldChatId = message.MigrateFromChatId.Value;
            Log($"Получена информация о миграции: {oldChatId} -> {newChatId}");
            bool migrated = groupsService.MigrateGroup(oldChatId, newChatId);
            await RefreshGroupAsync(newChatId);
            return true;
        }

        return false;
    }

    private async Task ProcessMessageAsync(TelegramMessage message)
    {
        if (!IsSupportedChatType(message.Chat.Type)) return;
        await RefreshOrAddGroupAsync(message.Chat);
    }

    private async Task ProcessChannelPostAsync(TelegramMessage message)
    {
        if (message.Chat.Type != ChatType.Channel) return;
        await RefreshOrAddGroupAsync(message.Chat);
    }

    private async Task RefreshOrAddGroupAsync(Chat chat)
    {
        if (!IsSupportedChatType(chat.Type) || !IsConnected || BotInfo.Id <= 0) return;

        TelegramGroup group = await CreateTelegramGroupAsync(chat);
        groupsService.AddOrUpdateGroup(group);

        Log($"Чат обновлён: {group.Title} | ID: {group.ChatId} | BotId: {group.BotId} | Тип: {group.Type}");
    }

    private async Task<TelegramGroup> CreateTelegramGroupAsync(Chat chat)
    {
        int members = await GetMembersCountAsync(chat.Id);
        string botRole = await GetBotRoleAsync(chat.Id);
        TelegramGroup? existingGroup = groupsService.GetGroup(chat.Id);

        return new TelegramGroup
        {
            BotId = BotInfo.Id,
            ChatId = chat.Id,
            Title = string.IsNullOrWhiteSpace(chat.Title) ? "Без названия" : chat.Title,
            Username = chat.Username ?? "",
            Type = GetRussianChatType(chat.Type),
            Members = members,
            BotRole = botRole,
            ChatStatus = "Подключено",
            InviteLink = existingGroup?.InviteLink ?? "",
            AddedDate = existingGroup?.AddedDate ?? DateTime.Now,
            Enabled = existingGroup?.Enabled ?? true,
            Selected = existingGroup?.Selected ?? false
        };
    }

    public async Task<string> GetBotRoleAsync(long chatId)
    {
        if (!IsConnected || BotInfo.Id <= 0) return "Неизвестно";

        try
        {
            var member = await _api.GetChatMemberAsync(chatId, BotInfo.Id);
            return member.Status switch
            {
                ChatMemberStatus.Creator => "Владелец",
                ChatMemberStatus.Administrator => "Администратор",
                ChatMemberStatus.Member => "Участник",
                ChatMemberStatus.Restricted => "Ограничен",
                _ => "Участник"
            };
        }
        catch
        {
            return "Участник";
        }
    }

    private static string GetRussianBotRole(ChatMemberStatus status) => status switch
    {
        ChatMemberStatus.Creator => "Владелец",
        ChatMemberStatus.Administrator => "Администратор",
        ChatMemberStatus.Member => "Участник",
        ChatMemberStatus.Restricted => "Ограничен",
        ChatMemberStatus.Left => "Вышел",
        ChatMemberStatus.Kicked => "Заблокирован",
        _ => "Неизвестно"
    };

    #endregion

    #region Group refresh

    public async Task<bool> RefreshGroupAsync(long chatId)
    {
        if (!IsConnected) return false;

        try
        {
            Chat chat = await _api.GetChatAsync(chatId.ToString());

            if (chat == null || !IsSupportedChatType(chat.Type))
            {
                groupsService.RemoveGroup(chatId);
                return false;
            }

            TelegramGroup? existingGroup = groupsService.GetGroup(chatId);
            int members = await GetMembersCountAsync(chatId);
            string botRole = await GetBotRoleAsync(chatId);

            TelegramGroup updatedGroup = new TelegramGroup
            {
                BotId = BotInfo.Id,
                ChatId = chat.Id,
                Title = string.IsNullOrWhiteSpace(chat.Title) ? "Без названия" : chat.Title,
                Username = chat.Username ?? "",
                Type = GetRussianChatType(chat.Type),
                Members = members,
                BotRole = botRole,
                ChatStatus = "Подключено",
                InviteLink = existingGroup?.InviteLink ?? "",
                AddedDate = existingGroup?.AddedDate ?? DateTime.Now,
                Enabled = existingGroup?.Enabled ?? true,
                Selected = existingGroup?.Selected ?? false
            };

            return groupsService.AddOrUpdateGroup(updatedGroup);
        }
        catch (ApiRequestException exception)
        {
            if (IsChatUnavailableError(exception))
            {
                groupsService.RemoveGroup(chatId);
                return false;
            }
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    private static bool IsChatUnavailableError(ApiRequestException exception)
    {
        if (exception.ErrorCode != 400) return false;
        string message = exception.Message.ToLowerInvariant();
        return message.Contains("chat not found") || message.Contains("chat is not found") ||
               message.Contains("group chat was upgraded") || message.Contains("supergroup not found");
    }

    public async Task RefreshAllGroupsAsync()
    {
        if (!IsConnected || BotInfo.Id <= 0) return;

        List<TelegramGroup> groups = groupsService.GetGroups().ToList();
        foreach (TelegramGroup group in groups)
        {
            if (!IsConnected || group.BotId != BotInfo.Id) continue;
            await RefreshGroupAsync(group.ChatId);
        }
    }

    private void StartValidationTimer()
    {
        StopValidationTimer();
        validationTimer = new System.Threading.Timer(ValidationTimerCallback, null, ValidationInterval, ValidationInterval);
    }

    private void StopValidationTimer()
    {
        if (validationTimer != null)
        {
            validationTimer.Dispose();
            validationTimer = null;
        }
    }

    private async void ValidationTimerCallback(object? state)
    {
        if (Interlocked.Exchange(ref validationRunning, 1) == 1) return;

        try
        {
            if (!IsConnected) return;
            await RefreshAllGroupsAsync();
        }
        catch (Exception exception)
        {
            Log($"Ошибка автоматической проверки: {exception.Message}");
        }
        finally
        {
            Interlocked.Exchange(ref validationRunning, 0);
        }
    }

    private static bool IsSupportedChatType(ChatType chatType) =>
        chatType == ChatType.Group || chatType == ChatType.Supergroup || chatType == ChatType.Channel;

    private static string GetRussianChatType(ChatType chatType) => chatType switch
    {
        ChatType.Group => "Группа",
        ChatType.Supergroup => "Супергруппа",
        ChatType.Channel => "Канал",
        _ => "Неизвестный тип"
    };

    #endregion

    #region Connection

    public async Task<bool> ConnectAsync(string token)
    {
        Log($"=== НАЧАЛО ConnectAsync ===");
        Log($"Токен получен: {!string.IsNullOrWhiteSpace(token)}");

        try
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                Log("❌ Токен пустой");
                return false;
            }

            if (IsConnected)
            {
                Log("Уже подключено, выполняю Disconnect...");
                Disconnect();
            }

            StopValidationTimer();
            Log("Вызываю _api.Initialize...");
            _api.Initialize(token);

            Log("Вызываю _api.GetMeAsync...");
            User me = await _api.GetMeAsync();

            if (me == null)
            {
                Log("❌ GetMe вернул null");
                return false;
            }

            Log($"✅ GetMe успешен! Бот: @{me.Username} (ID: {me.Id})");

            BotInfo.Token = token;
            BotInfo.Id = me.Id;
            BotInfo.Username = me.Username ?? "";
            BotInfo.FirstName = me.FirstName ?? "";

            Log($"BotInfo заполнен: Id={BotInfo.Id}, Username={BotInfo.Username}");

            Log("Проверяю совместимость профиля...");
            bool compatible = IsProfileCompatibleWithBot();
            Log($"IsProfileCompatibleWithBot = {compatible}");

            Log("Привязываю профиль к боту...");
            bool bound = BindCurrentProfileToBot();
            Log($"BindCurrentProfileToBot = {bound}");

            if (!compatible || !bound)
            {
                Log($"❌ ОШИБКА: Проблема с привязкой профиля. Compatible={compatible}, Bound={bound}");
                Log($"IsProfileOpen={profileManager.IsProfileOpen}");
                Log($"BotInfo.Id={BotInfo.Id}, Username={BotInfo.Username}");
                return false;
            }

            Log("✅ Привязка профиля успешна");

            BotInfo.Connected = true;
            IsConnected = true;

            groupsService.SetActiveBot(BotInfo.Id);
            Log("Запускаю StartReceiving...");
            _api.StartReceiving();

            Log("Вызываю RefreshAllGroupsAsync...");
            await RefreshAllGroupsAsync();

            BotConnected?.Invoke();
            StartValidationTimer();

            Log($"✅✅✅ БОТ УСПЕШНО ПОДКЛЮЧЁН: @{BotInfo.Username} | ID: {BotInfo.Id}");
            Console.WriteLine($"Бот подключён: @{BotInfo.Username} | ID: {BotInfo.Id}");
            return true;
        }
        catch (Exception exception)
        {
            Log($"❌❌ КРИТИЧЕСКАЯ ОШИБКА ПОДКЛЮЧЕНИЯ: {exception.GetType().Name}");
            Log($"Сообщение: {exception.Message}");
            Log($"StackTrace: {exception.StackTrace}");
            if (exception.InnerException != null)
            {
                Log($"InnerException: {exception.InnerException.Message}");
            }

            Console.WriteLine($"Ошибка подключения к Telegram: {exception.Message}");
            Disconnect();
            return false;
        }
    }

    public async Task<bool> CheckConnectionAsync()
    {
        if (!IsConnected) return false;
        try
        {
            User me = await _api.GetMeAsync();
            if (me == null) return false;

            if (me.Id != BotInfo.Id)
            {
                BotInfo.Id = me.Id;
                BotInfo.Username = me.Username ?? "";
                BotInfo.FirstName = me.FirstName ?? "";
                groupsService.SetActiveBot(BotInfo.Id);
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

    public void Disconnect()
    {
        bool wasConnected = IsConnected;
        StopValidationTimer();
        _api.StopReceiving();
        IsConnected = false;
        groupsService.DeactivateBot();

        BotInfo.Token = "";
        BotInfo.Id = 0;
        BotInfo.Username = "";
        BotInfo.FirstName = "";
        BotInfo.Connected = false;

        if (wasConnected) BotDisconnected?.Invoke();
    }

    #endregion

    #region Sending messages

    // ✅ ЕДИНСТВЕННЫЙ корректный метод отправки текста с поддержкой ParseMode (HTML/Markdown)
    public async Task<int?> SendMessageAsync(long chatId, string text, bool silent = false,
        bool disablePreview = false, bool hasSpoiler = false, bool protectContent = false,
        int? replyToMessageId = null, ParseMode? parseMode = null)
    {
        if (!IsConnected || string.IsNullOrWhiteSpace(text)) return null;
        try
        {
            return await _api.SendMessageAsync(chatId, text, silent, disablePreview, hasSpoiler,
                protectContent, replyToMessageId, parseMode);
        }
        catch (Exception exception)
        {
            Log($"Ошибка отправки сообщения: {exception.Message}");
            return null;
        }
    }

    // ✅ ЕДИНСТВЕННЫЙ корректный метод отправки медиафайлов
    public async Task<int?> SendMediaAsync(long chatId, string caption, List<string> filePaths,
        bool silent = false, bool disablePreview = false, bool hasSpoiler = false,
        bool protectContent = false, int? replyToMessageId = null, ParseMode? parseMode = null)
    {
        if (!IsConnected || filePaths == null || filePaths.Count == 0) return null;
        try
        {
            return await _api.SendMediaAsync(chatId, caption, filePaths, silent, disablePreview,
                hasSpoiler, protectContent, replyToMessageId, parseMode);
        }
        catch (Exception exception)
        {
            Log($"Ошибка отправки медиа: {exception.Message}");
            return null;
        }
    }

    public async Task<bool> DeleteMessageAsync(long chatId, int messageId)
    {
        if (!IsConnected) return false;
        try { return await _api.DeleteMessageAsync(chatId, messageId); }
        catch (Exception exception)
        {
            Log($"Ошибка удаления сообщения: {exception.Message}");
            return false;
        }
    }

    public async Task<int?> SendDiceAsync(long chatId, string emoji, CancellationToken cancellationToken = default)
    {
        if (!IsConnected) return null;
        try
        {
            return await _api.SendDiceAsync(chatId, emoji, cancellationToken);
        }
        catch (Exception exception)
        {
            Log($"Ошибка отправки Dice: {exception.Message}");
            return null;
        }
    }

    public async Task<bool> PinChatMessageAsync(long chatId, int messageId, CancellationToken cancellationToken = default)
    {
        if (!IsConnected) return false;
        try
        {
            return await _api.PinChatMessageAsync(chatId, messageId, cancellationToken);
        }
        catch (Exception exception)
        {
            Log($"Ошибка закрепления сообщения: {exception.Message}");
            return false;
        }
    }

    public async Task<bool> SetMessageReactionAsync(long chatId, int messageId, string emoji, CancellationToken cancellationToken = default)
    {
        if (!IsConnected) return false;
        try
        {
            return await _api.SetMessageReactionAsync(chatId, messageId, emoji, cancellationToken);
        }
        catch (Exception exception)
        {
            Log($"Ошибка установки реакции: {exception.Message}");
            return false;
        }
    }

    public async Task<int?> GetLastMessageIdAsync(long chatId, CancellationToken cancellationToken = default)
    {
        if (!IsConnected) return null;
        try
        {
            return await _api.GetLastMessageIdAsync(chatId, cancellationToken);
        }
        catch (Exception exception)
        {
            Log($"Ошибка получения последнего сообщения: {exception.Message}");
            return null;
        }
    }

    #endregion
}