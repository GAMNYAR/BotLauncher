namespace BotLauncher.Models.Telegram;

public class TelegramProfileSettings
{
    /// <summary>
    /// Основная информация о профиле.
    /// </summary>
    public TelegramProfile Profile { get; set; } =
        new TelegramProfile();

    /// <summary>
    /// Настройки Telegram-бота.
    /// </summary>
    public TelegramSettings Telegram { get; set; } =
        new TelegramSettings();

    /// <summary>
    /// Сохранённые группы и каналы.
    /// </summary>
    public List<TelegramGroup> Groups { get; set; } =
        new List<TelegramGroup>();

    /// <summary>
    /// Сохранённые шаблоны сообщений.
    /// </summary>
    public List<TelegramTemplate> Templates { get; set; } =
        new List<TelegramTemplate>();

    /// <summary>
    /// Сохранённые вложения.
    /// </summary>
    public List<TelegramAttachment> Attachments { get; set; } =
        new List<TelegramAttachment>();
}