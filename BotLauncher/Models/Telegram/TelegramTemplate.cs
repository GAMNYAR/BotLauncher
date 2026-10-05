namespace BotLauncher.Models.Telegram
{
    /// <summary>
    /// Модель шаблона сообщения для Telegram
    /// </summary>
    public class TelegramTemplate
    {
        /// <summary>
        /// Уникальный ID шаблона
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString("N")[..12];

        /// <summary>
        /// Название шаблона
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Текст сообщения (с переменными)
        /// </summary>
        public string Message { get; set; } = "";

        /// <summary>
        /// Список путей к файлам-вложениям
        /// </summary>
        public List<string> Attachments { get; set; } = new();

        /// <summary>
        /// Отключить предпросмотр ссылок
        /// </summary>
        public bool DisablePreview { get; set; }

        /// <summary>
        /// Отправить как тихое сообщение
        /// </summary>
        public bool Silent { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        /// <summary>
        /// Количество использований шаблона
        /// </summary>
        public int UsageCount { get; set; } = 0;

        /// <summary>
        /// Создатель шаблона (имя пользователя)
        /// </summary>
        public string CreatedBy { get; set; } = "";
    }
}