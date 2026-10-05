namespace BotLauncher.Models.Profile;

public class ProfileCreationSession
{
    /// <summary>
    /// Название создаваемого профиля.
    /// </summary>
    public string ProfileName { get; set; } =
        string.Empty;

    /// <summary>
    /// Пароль создаваемого профиля.
    ///
    /// До завершения создания хранится только
    /// в оперативной памяти.
    /// </summary>
    public string Password { get; set; } =
        string.Empty;

    /// <summary>
    /// Нужно ли использовать автоматическое
    /// запоминание профиля на этом компьютере.
    /// </summary>
    public bool RememberMe { get; set; }

    /// <summary>
    /// Telegram Bot API Token.
    ///
    /// До завершения создания хранится только
    /// в памяти.
    /// После успешного создания помещается
    /// внутрь зашифрованного .blp.
    /// </summary>
    public string BotToken { get; set; } =
        string.Empty;

    /// <summary>
    /// Telegram ID подключённого бота.
    /// </summary>
    public long BotId { get; set; }

    /// <summary>
    /// Username подключённого бота.
    /// </summary>
    public string BotUsername { get; set; } =
        string.Empty;

    /// <summary>
    /// Имя подключённого бота.
    /// </summary>
    public string BotFirstName { get; set; } =
        string.Empty;

    /// <summary>
    /// ID выбранной Telegram-группы/канала.
    ///
    /// Пока оставляем для следующего этапа.
    /// </summary>
    public long ChatId { get; set; }

    /// <summary>
    /// Удалось ли подключить Telegram-бота.
    /// </summary>
    public bool BotConnected { get; set; }

    /// <summary>
    /// Удалось ли успешно создать
    /// и сохранить профиль.
    /// </summary>
    public bool ProfileCreated { get; set; }
}