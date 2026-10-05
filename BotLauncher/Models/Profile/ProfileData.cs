namespace BotLauncher.Models.Profile;

public class ProfileData
{
    /// <summary>
    /// Версия структуры профиля.
    /// Нужна для будущих изменений формата.
    /// </summary>
    public int Version { get; set; } = 1;

    /// <summary>
    /// Уникальный идентификатор профиля.
    /// </summary>
    public Guid ProfileId { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Отображаемое имя профиля.
    /// Например: "Мой основной бот".
    /// </summary>
    public string ProfileName { get; set; } = string.Empty;

    /// <summary>
    /// Username Telegram-бота.
    /// Используется для удобства пользователя
    /// и определения, какому боту принадлежит профиль.
    /// </summary>
    public string BotUsername { get; set; } = string.Empty;

    /// <summary>
    /// Telegram ID бота.
    /// </summary>
    public long BotId { get; set; }

    /// <summary>
    /// Зашифрованные данные Telegram.
    /// На этом этапе оставляем строкой.
    /// Позже сюда перенесём существующие настройки.
    /// </summary>
    public string TelegramData { get; set; } = string.Empty;

    /// <summary>
    /// Дата создания профиля.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Дата последнего изменения профиля.
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}