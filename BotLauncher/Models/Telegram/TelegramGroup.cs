namespace BotLauncher.Models.Telegram;

public class TelegramGroup
{
    /// <summary>
    /// ID Telegram-бота, которому принадлежит эта запись.
    /// </summary>
    public long BotId { get; set; }

    /// <summary>
    /// ID группы или канала.
    /// </summary>
    public long ChatId { get; set; }

    /// <summary>
    /// Название группы или канала.
    /// </summary>
    public string Title { get; set; } = "";

    /// <summary>
    /// Username группы или канала.
    /// Например: @my_channel
    /// </summary>
    public string Username { get; set; } = "";

    /// <summary>
    /// Тип чата:
    /// Группа
    /// Супергруппа
    /// Канал
    /// </summary>
    public string Type { get; set; } = "";

    /// <summary>
    /// Количество участников или подписчиков.
    /// </summary>
    public int Members { get; set; }

    /// <summary>
    /// Роль бота в чате.
    /// Например:
    /// Администратор
    /// Участник
    /// Владелец
    /// </summary>
    public string BotRole { get; set; } = "";

    /// <summary>
    /// Текущий статус подключения бота к чату.
    /// </summary>
    public string ChatStatus { get; set; } = "Подключено";

    /// <summary>
    /// Ссылка-приглашение.
    /// </summary>
    public string InviteLink { get; set; } = "";

    /// <summary>
    /// Дата добавления.
    /// </summary>
    public DateTime AddedDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Получает ли чат уведомления.
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Выбрана ли группа.
    /// </summary>
    public bool Selected { get; set; }
}