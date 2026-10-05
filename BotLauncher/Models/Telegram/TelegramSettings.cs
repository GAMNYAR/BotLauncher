namespace BotLauncher.Models.Telegram
{
    /// <summary>
    /// Настройки Telegram-бота
    /// </summary>
    public class TelegramSettings
    {
        /// <summary>
        /// Токен Telegram-бота
        /// </summary>
        public string BotToken { get; set; } = string.Empty;

        /// <summary>
        /// ID группы или канала по умолчанию
        /// </summary>
        public string ChatId { get; set; } = string.Empty;

        /// <summary>
        /// Автоматически подключать бота при запуске программы
        /// </summary>
        public bool AutoConnect { get; set; } = true;

        /// <summary>
        /// Скрывать токен в интерфейсе
        /// </summary>
        public bool HideToken { get; set; } = true;
    }
}