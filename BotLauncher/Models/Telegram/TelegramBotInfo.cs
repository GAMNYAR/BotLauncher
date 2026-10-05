namespace BotLauncher.Models.Telegram
{
    /// <summary>
    /// Информация о Telegram-боте.
    /// </summary>
    public class TelegramBotInfo
    {
        /// <summary>
        /// Токен бота.
        /// </summary>
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// ID бота.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Username бота.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Имя бота.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Успешно ли подключение.
        /// </summary>
        public bool Connected { get; set; }

        /// <summary>
        /// Последняя успешная проверка.
        /// </summary>
        public DateTime? LastCheck { get; set; }

        /// <summary>
        /// Версия API (на будущее).
        /// </summary>
        public string ApiVersion { get; set; } = string.Empty;
    }
}