using BotLauncher.Controls.Base;
using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using BotLauncher.Shared.Services;
using System;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Settings
{
    public partial class TelegramBotSettingsControl : BaseControl
    {
        private readonly TelegramBotService telegramBot;
        private readonly TelegramSettingsService settingsService;
        private TelegramSettings settings;

        public TelegramBotSettingsControl()
        {
            InitializeComponent();

            EnableDoubleBuffering(tableLayoutPanelMain);
            EnableDoubleBuffering(statusIndicatorPanel);
            EnableDoubleBuffering(botCardPanel);

            // Получаем единый экземпляр сервиса
            telegramBot = AppServices.TelegramBot;
            settingsService = new TelegramSettingsService();

            // =========================================================
            // ВАЖНО: Загружаем настройки (исправляет ошибку CS8618)
            // =========================================================
            settings = settingsService.Load();

            // Заполняем поля на экране данными из файла настроек
            LoadSettings();

            // Обновляем визуальный статус бота (Подключен/Отключен)
            // Так как Program.cs уже мог его подключить, здесь отобразится верный статус
            UpdateBotInfo();
        }

        /// <summary>
        /// Включает двойную буферизацию для предотвращения мерцания и пропадания границ
        /// </summary>
        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic)
                ?.SetValue(control, true, null);
        }

        /// <summary>
        /// Принудительно перерисовывает TableLayoutPanel и его элементы
        /// </summary>
        private void RefreshTableBorders()
        {
            if (tableLayoutPanelMain != null)
            {
                tableLayoutPanelMain.Refresh();
                foreach (Control ctrl in tableLayoutPanelMain.Controls)
                {
                    ctrl.Refresh();
                }
            }
        }

        // =========================================================
        // Автоматическое подключение (фоновое)
        // =========================================================
        private async Task AutoConnectAsync()
        {
            // Убеждаемся, что токен отображается в поле ввода
            if (InvokeRequired)
            {
                Invoke(new Action(() => txtBotToken.Text = settings.BotToken));
            }

            // Пытаемся подключиться
            bool connected = await telegramBot.ConnectAsync(settings.BotToken);

            // Обновляем интерфейс после подключения
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateBotInfo));
            }
            else
            {
                UpdateBotInfo();
            }
        }

        // =========================================================
        // Настройки
        // =========================================================
        private void LoadSettings()
        {
            txtBotToken.Text = settings.BotToken;
            txtChatId.Text = settings.ChatId;
            chkAutoConnect.Checked = settings.AutoConnect;
            chkHideToken.Checked = settings.HideToken;

            txtBotToken.PasswordChar = settings.HideToken ? '●' : '\0';

            // Принудительно обновляем отображение после загрузки
            RefreshTableBorders();
        }

        private void SaveSettings()
        {
            settings.BotToken = txtBotToken.Text.Trim();
            settings.ChatId = txtChatId.Text.Trim();
            settings.AutoConnect = chkAutoConnect.Checked;
            settings.HideToken = chkHideToken.Checked;

            settingsService.Save(settings);
        }

        // =========================================================
        // Информация о боте (Обновление UI)
        // =========================================================
        private void UpdateBotInfo()
        {
            if (!telegramBot.IsConnected || telegramBot.BotInfo == null)
            {
                lblBotName.Text = "-";
                lblUsername.Text = "-";
                lblBotID.Text = "-";
                lblAPIStatus.Text = "Отключено";
                lblAPIStatus.ForeColor = Color.Red;
                lblStatusConection.Text = "Отключено";
                lblStatusConection.ForeColor = Color.Gray;
                lblLastCheck.Text = "-";
            }
            else
            {
                lblBotName.Text = telegramBot.BotInfo.FirstName;
                lblUsername.Text = "@" + telegramBot.BotInfo.Username;
                lblBotID.Text = telegramBot.BotInfo.Id.ToString();
                lblAPIStatus.Text = "Подключено";
                lblAPIStatus.ForeColor = Color.LimeGreen;
                lblStatusConection.Text = "Активное соединение";
                lblStatusConection.ForeColor = Color.LimeGreen;
                lblLastCheck.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            }

            // Принудительно обновляем отображение границ после изменения данных
            RefreshTableBorders();
        }

        // =========================================================
        // Подключение (Ручное)
        // =========================================================
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if (string.IsNullOrWhiteSpace(settings.BotToken))
            {
                MessageBox.Show("Введите токен Telegram-бота.", "BotLauncher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConnect.Enabled = false;
            btnConnect.Text = "Подключение...";

            try
            {
                bool connected = await telegramBot.ConnectAsync(settings.BotToken);
                UpdateBotInfo();

                if (connected)
                {
                    MessageBox.Show(
                        $"Бот успешно подключен!\n\n" +
                        $"Имя: {telegramBot.BotInfo.FirstName}\n" +
                        $"Username: @{telegramBot.BotInfo.Username}\n" +
                        $"ID: {telegramBot.BotInfo.Id}",
                        "BotLauncher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не удалось подключиться к Telegram-боту.\n\nПроверьте токен и подключение к интернету.", "BotLauncher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                btnConnect.Enabled = true;
                btnConnect.Text = "Подключить";
            }
        }

        // =========================================================
        // Проверка соединения
        // =========================================================
        private async void btnCheckConnection_Click(object sender, EventArgs e)
        {
            if (!telegramBot.IsConnected)
            {
                UpdateBotInfo();
                MessageBox.Show("Бот сейчас не подключён.", "BotLauncher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnCheckConnection.Enabled = false;
            try
            {
                bool ok = await telegramBot.CheckConnectionAsync();
                UpdateBotInfo();

                MessageBox.Show(
                    ok ? "Соединение активно." : "Соединение отсутствует.",
                    "BotLauncher", MessageBoxButtons.OK,
                    ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            finally
            {
                btnCheckConnection.Enabled = true;
            }
        }

        // =========================================================
        // Отключение
        // =========================================================
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (!telegramBot.IsConnected)
            {
                UpdateBotInfo();
                return;
            }

            telegramBot.Disconnect();
            UpdateBotInfo();
            MessageBox.Show("Бот отключен.", "BotLauncher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =========================================================
        // Управление токеном (Показать/Скрыть/Вставить)
        // =========================================================
        private void btnShowHideToken_MouseDown(object sender, MouseEventArgs e)
        {
            txtBotToken.PasswordChar = '\0';
        }

        private void btnShowHideToken_MouseUp(object sender, MouseEventArgs e)
        {
            txtBotToken.PasswordChar = chkHideToken.Checked ? '●' : '\0';
        }

        private void btnShowHideToken_MouseLeave(object sender, EventArgs e)
        {
            txtBotToken.PasswordChar = chkHideToken.Checked ? '●' : '\0';
        }

        private void btnPasteToken_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtBotToken.Text = Clipboard.GetText().Trim();
                SaveSettings();
            }
        }

        // =========================================================
        // Реакция на изменение настроек
        // =========================================================
        private void chkHideToken_CheckedChanged(object sender, EventArgs e)
        {
            txtBotToken.PasswordChar = chkHideToken.Checked ? '●' : '\0';
            SaveSettings();
        }

        private void chkAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void txtBotToken_TextChanged(object sender, EventArgs e)
        {
            if (chkAutoConnect.Checked)
            {
                SaveSettings();
            }
        }

        // =========================================================
        // Обновление статуса
        // =========================================================
        private async void btnLastCheck_Click(object sender, EventArgs e)
        {
            if (!telegramBot.IsConnected)
            {
                UpdateBotInfo();
                return;
            }

            btnLastCheck.Enabled = false;
            try
            {
                await telegramBot.CheckConnectionAsync();
                UpdateBotInfo();
            }
            finally
            {
                btnLastCheck.Enabled = true;
            }
        }

        private void lblBotTokenHint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://t.me/BotFather",
                    UseShellExecute = true
                });
                lblBotTokenHint.LinkVisited = true;
            }
            catch
            {
                MessageBox.Show("Не удалось открыть ссылку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}