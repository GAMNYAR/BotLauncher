namespace BotLauncher.Models.Telegram;

public class TelegramProfileHeader
{
    /// <summary>
    /// Версия формата (для совместимости)
    /// </summary>
    public int FormatVersion { get; set; }

    /// <summary>
    /// Имя профиля
    /// </summary>
    public string ProfileName { get; set; } = string.Empty;

    /// <summary>
    /// Username бота (без @)
    /// </summary>
    public string BotUsername { get; set; } = string.Empty;
}