using BotLauncher.Controls.Base;
using BotLauncher.Controls.Telegram.Attachments;
using BotLauncher.Controls.Telegram.Groups;
using BotLauncher.Controls.Telegram.Settings;
using BotLauncher.Shared.Navigation;
using BotLauncher.Controls.Telegram.Templates;
using System;
using System.Windows.Forms;

namespace BotLauncher
{
    public partial class TelegramSettingsPage : BaseControl
    {
        private readonly NavigationManager navigation;

        private readonly TelegramGroupsControl groupsPage;
        private readonly TelegramTemplatesControl templatesPage;
        private readonly TelegramAttachmentsControl attachmentsPage;
        private TelegramBotSettingsControl? botSettingsPage;

        public TelegramSettingsPage()
        {
            InitializeComponent();

            navigation = new NavigationManager(contentPanel);

            groupsPage = new TelegramGroupsControl();
            templatesPage = new TelegramTemplatesControl();
            attachmentsPage = new TelegramAttachmentsControl();

            // Подписываемся на кнопки
            btnGroups.Click += btnGroups_Click;
            btnTemplates.Click += btnTemplates_Click;
            btnAttachments.Click += btnAttachments_Click;
            btnBotSettings.Click += btnBotSettings_Click;

            // ИСПРАВЛЕНИЕ: Открываем страницу ГРУПП по умолчанию (не настройки бота)
            navigation.Open(groupsPage);
            UpdateHeader("Группы", "Управление подключенными группами и каналами");
        }

        /// <summary>
        /// Переключиться на вкладку настроек бота (для вызова из MainForm при отсутствии токена)
        /// </summary>
        public void SwitchToBotSettings()
        {
            OpenBotSettings();
        }

        /// <summary>
        /// Переключиться на вкладку настроек бота (альтернативный метод)
        /// </summary>
        public void ShowBotSettings()
        {
            OpenBotSettings();
        }

        /// <summary>
        /// Открыть настройки бота (создаёт новый экземпляр каждый раз)
        /// </summary>
        private void OpenBotSettings()
        {
            botSettingsPage = new TelegramBotSettingsControl();
            navigation.Open(botSettingsPage);
            UpdateHeader("Настройки", "Настройки подключения и управления ботом");
        }

        #region Navigation

        private void btnTemplates_Click(object? sender, EventArgs e)
        {
            navigation.Open(templatesPage);
            templatesPage.PerformLayout(); // ✅ принудительный пересчёт
            UpdateHeader("Шаблоны", "Управление шаблонами сообщений для рассылки");
        }

        private void btnGroups_Click(object? sender, EventArgs e)
        {
            navigation.Open(groupsPage);
            groupsPage.PerformLayout(); // ✅ добавь и сюда, раз была та же проблема
            UpdateHeader("Группы", "Управление подключенными группами и каналами");
        }

        private void btnAttachments_Click(object? sender, EventArgs e)
        {
            navigation.Open(attachmentsPage);
            attachmentsPage.PerformLayout(); // ✅ и сюда
            UpdateHeader("Вложения", "Управление файлами и медиа для отправки");
        }

        private void btnBotSettings_Click(object? sender, EventArgs e)
        {
            OpenBotSettings();
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Обновить заголовок и описание
        /// </summary>
        private void UpdateHeader(string title, string description)
        {
            if (lblTitle != null)
            {
                lblTitle.Text = $"Telegram: {title}";
            }

            if (lblDescription != null)
            {
                lblDescription.Text = description;
            }
        }

        #endregion
    }
}