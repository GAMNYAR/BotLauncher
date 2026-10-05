namespace BotLauncher.Models.Telegram;

public class TelegramProfileBot
{
    /// <summary>
    /// Уникальный Telegram ID бота.
    /// Получается непосредственно от Telegram API.
    /// </summary>
    public long BotId { get; set; }

    /// <summary>
    /// Username Telegram-бота без символа @.
    /// </summary>
    public string Username { get; set; } =
        string.Empty;

    /// <summary>
    /// Отображаемое имя Telegram-бота.
    /// </summary>
    public string FirstName { get; set; } =
        string.Empty;

    /// <summary>
    /// API Token Telegram-бота.
    ///
    /// Значение находится только внутри
    /// зашифрованного .blp-файла.
    /// </summary>
    public string Token { get; set; } =
        string.Empty;
}