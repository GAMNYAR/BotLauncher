namespace BotLauncher.Models.Telegram;

public class TelegramProfile
{
    /// <summary>
    /// Версия формата профиля.
    /// </summary>
    public int FormatVersion { get; set; } = 1;

    /// <summary>
    /// Уникальный ID самого профиля BotLauncher.
    /// </summary>
    public Guid ProfileId { get; set; } =
        Guid.NewGuid();

    /// <summary>
    /// Отображаемое название профиля.
    /// </summary>
    public string Name { get; set; } =
        string.Empty;

    /// <summary>
    /// Дата создания профиля.
    /// Хранится в UTC.
    /// </summary>
    public DateTime CreatedAt { get; set; } =
        DateTime.UtcNow;

    /// <summary>
    /// Дата последнего изменения профиля.
    /// Хранится в UTC.
    /// </summary>
    public DateTime UpdatedAt { get; set; } =
        DateTime.UtcNow;

    /// <summary>
    /// Telegram-бот, привязанный к профилю.
    /// </summary>
    public TelegramProfileBot Bot { get; set; } =
        new TelegramProfileBot();
}