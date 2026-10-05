using System.Text.Json;
using BotLauncher.Models.Telegram;

namespace BotLauncher.Services.Telegram;

public class TelegramStorageService
{
    private readonly string folder =
    Path.Combine(
    Application.StartupPath,
    "Data");

private readonly string groupsFile =
    Path.Combine(
        Application.StartupPath,
        "Data",
        "groups.json");

    private readonly string templatesFile =
        Path.Combine(
            Application.StartupPath,
            "Data",
            "templates.json");

    private readonly string attachmentsFile =
        Path.Combine(
            Application.StartupPath,
            "Data",
            "attachments.json");

    private readonly JsonSerializerOptions jsonOptions =
        new()
        {
            WriteIndented = true
        };

    public TelegramStorageService()
    {
        EnsureStorageFolder();
    }

    // =========================================================
    // Инициализация хранилища
    // =========================================================

    private void EnsureStorageFolder()
    {
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
    }

    // =========================================================
    // Группы и каналы
    // =========================================================

    /// <summary>
    /// Сохранить все группы и каналы.
    /// </summary>
    public void SaveGroups(
        List<TelegramGroup> groups)
    {
        if (groups == null)
        {
            groups =
                new List<TelegramGroup>();
        }

        EnsureStorageFolder();

        string json =
            JsonSerializer.Serialize(
                groups,
                jsonOptions);

        File.WriteAllText(
            groupsFile,
            json);
    }

    /// <summary>
    /// Загрузить все сохранённые группы и каналы.
    /// </summary>
    public List<TelegramGroup> LoadGroups()
    {
        try
        {
            if (!File.Exists(groupsFile))
            {
                return new List<TelegramGroup>();
            }

            string json =
                File.ReadAllText(
                    groupsFile);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<TelegramGroup>();
            }

            return JsonSerializer.Deserialize<
                       List<TelegramGroup>>(
                       json)
                   ?? new List<TelegramGroup>();
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Ошибка загрузки групп Telegram: " +
                $"{exception.Message}");

            return new List<TelegramGroup>();
        }
    }

    /// <summary>
    /// Загрузить только группы конкретного бота.
    /// </summary>
    public List<TelegramGroup> LoadGroups(
        long botId)
    {
        if (botId <= 0)
        {
            return new List<TelegramGroup>();
        }

        List<TelegramGroup> allGroups =
            LoadGroups();

        return allGroups
            .Where(group =>
                group.BotId == botId)
            .ToList();
    }

    /// <summary>
    /// Удалить все сохранённые группы конкретного бота.
    ///
    /// Используется только если действительно
    /// нужно удалить данные бота из хранилища.
    /// Обычное отключение бота этот метод НЕ вызывает.
    /// </summary>
    public void RemoveGroups(
        long botId)
    {
        if (botId <= 0)
        {
            return;
        }

        List<TelegramGroup> allGroups =
            LoadGroups();

        int originalCount =
            allGroups.Count;

        allGroups.RemoveAll(
            group =>
                group.BotId == botId);

        if (allGroups.Count ==
            originalCount)
        {
            return;
        }

        SaveGroups(allGroups);
    }

    // =========================================================
    // Шаблоны
    // =========================================================

    /// <summary>
    /// Сохранить шаблоны сообщений.
    /// </summary>
    public void SaveTemplates(
        List<TelegramTemplate> templates)
    {
        if (templates == null)
        {
            templates =
                new List<TelegramTemplate>();
        }

        EnsureStorageFolder();

        string json =
            JsonSerializer.Serialize(
                templates,
                jsonOptions);

        File.WriteAllText(
            templatesFile,
            json);
    }

    /// <summary>
    /// Загрузить шаблоны сообщений.
    /// </summary>
    public List<TelegramTemplate> LoadTemplates()
    {
        try
        {
            if (!File.Exists(templatesFile))
            {
                return new List<TelegramTemplate>();
            }

            string json =
                File.ReadAllText(
                    templatesFile);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<TelegramTemplate>();
            }

            return JsonSerializer.Deserialize<
                       List<TelegramTemplate>>(
                       json)
                   ?? new List<TelegramTemplate>();
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Ошибка загрузки шаблонов Telegram: " +
                $"{exception.Message}");

            return new List<TelegramTemplate>();
        }
    }

    // =========================================================
    // Вложения
    // =========================================================

    /// <summary>
    /// Сохранить вложения.
    /// </summary>
    public void SaveAttachments(
        List<TelegramAttachment> attachments)
    {
        if (attachments == null)
        {
            attachments =
                new List<TelegramAttachment>();
        }

        EnsureStorageFolder();

        string json =
            JsonSerializer.Serialize(
                attachments,
                jsonOptions);

        File.WriteAllText(
            attachmentsFile,
            json);
    }

    /// <summary>
    /// Загрузить вложения.
    /// </summary>
    public List<TelegramAttachment> LoadAttachments()
    {
        try
        {
            if (!File.Exists(attachmentsFile))
            {
                return new List<TelegramAttachment>();
            }

            string json =
                File.ReadAllText(
                    attachmentsFile);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<TelegramAttachment>();
            }

            return JsonSerializer.Deserialize<
                       List<TelegramAttachment>>(
                       json)
                   ?? new List<TelegramAttachment>();
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Ошибка загрузки вложений Telegram: " +
                $"{exception.Message}");

            return new List<TelegramAttachment>();
        }
    }

}
