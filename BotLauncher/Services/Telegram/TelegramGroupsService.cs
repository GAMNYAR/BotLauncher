using BotLauncher.Models.Telegram;

namespace BotLauncher.Services.Telegram;

public class TelegramGroupsService
{
    private readonly TelegramStorageService storage;

    private readonly List<TelegramGroup> groups;

    /// <summary>
    /// ID текущего подключённого Telegram-бота.
    /// 0 означает, что бот не подключён.
    /// </summary>
    private long activeBotId;

    /// <summary>
    /// Событие добавления новой группы или канала.
    /// </summary>
    public event Action<TelegramGroup>? GroupAdded;

    /// <summary>
    /// Событие обновления существующей группы или канала.
    /// </summary>
    public event Action<TelegramGroup>? GroupUpdated;

    /// <summary>
    /// Событие удаления группы или канала.
    /// </summary>
    public event Action<long>? GroupRemoved;

    /// <summary>
    /// Событие миграции группы в супергруппу.
    /// </summary>
    public event Action<long, long>? GroupMigrated;

    /// <summary>
    /// Событие полной очистки отображаемого списка.
    /// </summary>
    public event Action? GroupsCleared;

    public TelegramGroupsService()
    {
        storage =
            new TelegramStorageService();

        groups =
            storage.LoadGroups();

        activeBotId =
            0;

        RemoveDuplicateGroups();
    }

    #region Активный бот

    /// <summary>
    /// Установить текущего активного Telegram-бота.
    /// </summary>
    public void SetActiveBot(
        long botId)
    {
        if (botId <= 0)
        {
            DeactivateBot();
            return;
        }

        bool changed =
            activeBotId != botId;

        activeBotId =
            botId;

        if (changed)
        {
            GroupsCleared?.Invoke();

            foreach (
                TelegramGroup group
                in GetGroups())
            {
                GroupAdded?.Invoke(group);
            }
        }
    }

    /// <summary>
    /// Отключить текущего бота.
    ///
    /// Данные из groups.json НЕ удаляются.
    /// Меняется только активный бот,
    /// поэтому интерфейс больше не видит карточки.
    /// </summary>
    public void DeactivateBot()
    {
        if (activeBotId == 0)
        {
            GroupsCleared?.Invoke();
            return;
        }

        activeBotId =
            0;

        GroupsCleared?.Invoke();
    }

    /// <summary>
    /// Получить ID текущего активного бота.
    /// </summary>
    public long ActiveBotId =>
        activeBotId;

    #endregion

    #region Получение данных

    /// <summary>
    /// Получить группы и каналы
    /// только текущего активного бота.
    /// </summary>
    public IReadOnlyList<TelegramGroup> GetGroups()
    {
        if (activeBotId <= 0)
        {
            return Array.Empty<TelegramGroup>();
        }

        return groups
            .Where(group =>
                group.BotId == activeBotId)
            .ToList()
            .AsReadOnly();
    }

    /// <summary>
    /// Получить группу или канал текущего бота
    /// по Chat ID.
    /// </summary>
    public TelegramGroup? GetGroup(
        long chatId)
    {
        if (activeBotId <= 0)
        {
            return null;
        }

        return groups.FirstOrDefault(
            group =>
                group.BotId == activeBotId &&
                group.ChatId == chatId);
    }

    #endregion

    #region Добавление и обновление

    /// <summary>
    /// Добавить новую группу или канал.
    /// </summary>
    public bool AddGroup(
        TelegramGroup group)
    {
        if (group == null)
            return false;

        if (activeBotId <= 0)
            return false;

        if (group.BotId <= 0)
        {
            group.BotId =
                activeBotId;
        }

        if (group.BotId != activeBotId)
        {
            return false;
        }

        TelegramGroup? existingGroup =
            GetGroup(group.ChatId);

        if (existingGroup != null)
            return false;

        groups.Add(group);

        Save();

        GroupAdded?.Invoke(group);

        return true;
    }

    /// <summary>
    /// Обновить существующую группу или канал.
    /// </summary>
    public bool UpdateGroup(
        TelegramGroup updatedGroup)
    {
        if (updatedGroup == null)
            return false;

        if (activeBotId <= 0)
            return false;

        TelegramGroup? existingGroup =
            GetGroup(updatedGroup.ChatId);

        if (existingGroup == null)
            return false;

        UpdateTelegramData(
            existingGroup,
            updatedGroup);

        Save();

        GroupUpdated?.Invoke(existingGroup);

        return true;
    }

    /// <summary>
    /// Добавить новую группу либо обновить существующую.
    /// </summary>
    public bool AddOrUpdateGroup(
        TelegramGroup group)
    {
        if (group == null)
            return false;

        if (activeBotId <= 0)
            return false;

        if (group.BotId <= 0)
        {
            group.BotId =
                activeBotId;
        }

        if (group.BotId != activeBotId)
        {
            return false;
        }

        TelegramGroup? existingGroup =
            GetGroup(group.ChatId);

        // =================================================
        // НОВАЯ ГРУППА
        // =================================================

        if (existingGroup == null)
        {
            groups.Add(group);

            Save();

            GroupAdded?.Invoke(group);

            return true;
        }

        // =================================================
        // СУЩЕСТВУЮЩАЯ ГРУППА
        // =================================================

        UpdateTelegramData(
            existingGroup,
            group);

        Save();

        GroupUpdated?.Invoke(existingGroup);

        return true;
    }

    /// <summary>
    /// Обновить только данные, полученные от Telegram.
    ///
    /// Пользовательские настройки Enabled
    /// и Selected не изменяются.
    /// </summary>
    private static void UpdateTelegramData(
        TelegramGroup existingGroup,
        TelegramGroup updatedGroup)
    {
        existingGroup.BotId =
            updatedGroup.BotId;

        existingGroup.Title =
            updatedGroup.Title;

        existingGroup.Username =
            updatedGroup.Username;

        existingGroup.Type =
            updatedGroup.Type;

        existingGroup.Members =
            updatedGroup.Members;

        existingGroup.BotRole =
            updatedGroup.BotRole;

        existingGroup.ChatStatus =
            updatedGroup.ChatStatus;

        existingGroup.InviteLink =
            updatedGroup.InviteLink;
    }

    #endregion

    #region Пользовательские настройки

    /// <summary>
    /// Изменить настройку Enabled.
    /// </summary>
    public bool SetEnabled(
        long chatId,
        bool enabled)
    {
        TelegramGroup? group =
            GetGroup(chatId);

        if (group == null)
            return false;

        if (group.Enabled == enabled)
            return true;

        group.Enabled =
            enabled;

        Save();

        GroupUpdated?.Invoke(group);

        return true;
    }

    /// <summary>
    /// Изменить настройку Selected.
    /// </summary>
    public bool SetSelected(
        long chatId,
        bool selected)
    {
        TelegramGroup? group =
            GetGroup(chatId);

        if (group == null)
            return false;

        if (group.Selected == selected)
            return true;

        group.Selected =
            selected;

        Save();

        GroupUpdated?.Invoke(group);

        return true;
    }

    /// <summary>
    /// Изменить сразу Enabled и Selected.
    /// </summary>
    public bool SetUserSettings(
        long chatId,
        bool enabled,
        bool selected)
    {
        TelegramGroup? group =
            GetGroup(chatId);

        if (group == null)
            return false;

        bool changed =
            group.Enabled != enabled ||
            group.Selected != selected;

        if (!changed)
            return true;

        group.Enabled =
            enabled;

        group.Selected =
            selected;

        Save();

        GroupUpdated?.Invoke(group);

        return true;
    }

    #endregion

    #region Миграция

    /// <summary>
    /// Перенести сохранённую группу
    /// со старого Chat ID на новый Chat ID.
    /// </summary>
    public bool MigrateGroup(
        long oldChatId,
        long newChatId)
    {
        if (activeBotId <= 0)
            return false;

        if (oldChatId == newChatId)
            return false;

        TelegramGroup? oldGroup =
            GetGroup(oldChatId);

        if (oldGroup == null)
        {
            Console.WriteLine(
                $"Миграция пропущена: " +
                $"старая группа {oldChatId} не найдена.");

            return false;
        }

        TelegramGroup? newGroup =
            GetGroup(newChatId);

        // =================================================
        // НОВЫЙ ID УЖЕ ЕСТЬ
        // =================================================

        if (newGroup != null)
        {
            newGroup.Enabled =
                oldGroup.Enabled;

            newGroup.Selected =
                oldGroup.Selected;

            if (string.IsNullOrWhiteSpace(
                    newGroup.InviteLink))
            {
                newGroup.InviteLink =
                    oldGroup.InviteLink;
            }

            newGroup.AddedDate =
                oldGroup.AddedDate;

            groups.Remove(oldGroup);

            Save();

            GroupRemoved?.Invoke(
                oldChatId);

            GroupUpdated?.Invoke(
                newGroup);

            GroupMigrated?.Invoke(
                oldChatId,
                newChatId);

            Console.WriteLine(
                $"Миграция объединена: " +
                $"{oldChatId} -> {newChatId}");

            return true;
        }

        // =================================================
        // ПЕРЕНОСИМ СТАРУЮ ЗАПИСЬ
        // =================================================

        oldGroup.ChatId =
            newChatId;

        oldGroup.Type =
            "Супергруппа";

        Save();

        GroupMigrated?.Invoke(
            oldChatId,
            newChatId);

        GroupUpdated?.Invoke(
            oldGroup);

        Console.WriteLine(
            $"Группа мигрирована: " +
            $"{oldChatId} -> {newChatId}");

        return true;
    }

    #endregion

    #region Удаление

    /// <summary>
    /// Удалить группу или канал
    /// текущего активного бота.
    /// </summary>
    public bool RemoveGroup(
        long chatId)
    {
        TelegramGroup? group =
            GetGroup(chatId);

        if (group == null)
            return false;

        groups.Remove(group);

        Save();

        GroupRemoved?.Invoke(
            chatId);

        return true;
    }

    /// <summary>
    /// Очистить все группы текущего активного бота.
    ///
    /// Остальные боты не затрагиваются.
    /// </summary>
    public void Clear()
    {
        if (activeBotId <= 0)
            return;

        List<TelegramGroup> groupsToRemove =
            groups
                .Where(group =>
                    group.BotId == activeBotId)
                .ToList();

        if (groupsToRemove.Count == 0)
            return;

        foreach (
            TelegramGroup group
            in groupsToRemove)
        {
            groups.Remove(group);
        }

        Save();

        GroupsCleared?.Invoke();
    }

    #endregion

    #region Хранилище

    /// <summary>
    /// Сохранить список групп и каналов.
    /// </summary>
    public void Save()
    {
        storage.SaveGroups(groups);
    }

    /// <summary>
    /// Перезагрузить список из хранилища.
    /// </summary>
    public void Reload()
    {
        List<TelegramGroup> loadedGroups =
            storage.LoadGroups();

        groups.Clear();

        groups.AddRange(
            loadedGroups);

        RemoveDuplicateGroups();

        GroupsCleared?.Invoke();

        foreach (
            TelegramGroup group
            in GetGroups())
        {
            GroupAdded?.Invoke(group);
        }
    }

    /// <summary>
    /// Удалить дубликаты.
    ///
    /// Теперь уникальность определяется
    /// одновременно BotId + ChatId.
    /// </summary>
    private void RemoveDuplicateGroups()
    {
        HashSet<string> knownGroups =
            new();

        bool changed =
            false;

        for (
            int i = groups.Count - 1;
            i >= 0;
            i--)
        {
            TelegramGroup group =
                groups[i];

            string key =
                $"{group.BotId}:{group.ChatId}";

            if (knownGroups.Contains(key))
            {
                groups.RemoveAt(i);

                changed =
                    true;

                continue;
            }

            knownGroups.Add(key);
        }

        if (changed)
        {
            Save();
        }
    }

    /// <summary>
    /// Количество групп текущего бота.
    /// </summary>
    public int Count =>
        GetGroups().Count;

    #endregion
}