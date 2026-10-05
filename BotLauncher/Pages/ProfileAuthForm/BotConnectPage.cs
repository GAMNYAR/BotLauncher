using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using BotLauncher.Services.Telegram;

using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class BotConnectPage : UserControl
    {
        private readonly TelegramBotService telegramBotService;
        private bool tokenVisible;
        private bool isConnecting;
        private bool isBotConnected;

        public BotConnectPage()
        {
            InitializeComponent();
            telegramBotService = new TelegramBotService();

            // ВАЖНО: Инициализацию переносим в событие Load.
            this.Load += BotConnectPage_Load;

            telegramBotService.BotConnected += TelegramBotService_BotConnected;
            telegramBotService.BotDisconnected += TelegramBotService_BotDisconnected;
        }

        private void BotConnectPage_Load(object? sender, EventArgs e)
        {
            InitializePage();
            InitializeTooltips();
        }

        // =========================================================
        // Инициализация
        // =========================================================
        private void InitializePage()
        {
            tokenVisible = false;
            isConnecting = false;
            isBotConnected = false;

            SetTokenVisibility(false);
            UpdateUIState();

            // Очищаем поле токена
            txtBotToken.Clear();

            // Скрываем иконку ошибки
            picTokenError.Visible = false;

            // Получаем название профиля из сессии
            LoadProfileInfo();

            // Сбрасываем информацию о боте
            ResetBotInfo();
        }

        // =========================================================
        // Подсказки (Sunny.UI.UIToolTip)
        // =========================================================
        private void InitializeTooltips()
        {
            // Подсказка для поля токена
            uiToolTip1.SetToolTip(txtBotToken,
                "Введите Telegram Bot API Token.\n\n" +
                "Формат: 123456789:ABCdefGHIjklMNOpqrSTUvwxYZ\n" +
                "Получить токен можно у @BotFather в Telegram.");

            // Подсказка для кнопки показать/скрыть токен
            uiToolTip1.SetToolTip(btnShowToken,
                "Показать/скрыть токен");

            // Подсказка для иконки информации о боте
            uiToolTip1.SetToolTip(picBotInfo,
    "Как это работает:\n\n" +
    "1. Введите Bot Token от @BotFather\n" +
    "2. Нажмите «Подключить бота»\n" +
    "3. Здесь появится информация:\n" +
    "   • Профиль и Bot ID\n" +
    "   • Имя и username бота\n" +
    "   • Статус подключения\n\n" +
    "После проверки данных нажмите ещё раз для продолжения.");

            // Подсказка для кнопки подключения
            uiToolTip1.SetToolTip(btnConnectBot,
                "Первое нажатие — получить данные о боте.\n" +
                "Второе нажатие — подтвердить и продолжить.");

            // Подсказка для кнопки назад
            uiToolTip1.SetToolTip(btnBack,
                "Вернуться на предыдущий шаг");
        }

        private void LoadProfileInfo()
        {
            if (FindForm() is ProfileAuthWindow authForm &&
                authForm.CreationSession != null)
            {
                string name = authForm.CreationSession.ProfileName;
                lblProfileName.Text = string.IsNullOrWhiteSpace(name)
                    ? "Профиль: (не указано)"
                    : $"Профиль: {name}";
            }
            else
            {
                lblProfileName.Text = "Профиль: (не указано)";
            }
        }

        private void ResetBotInfo()
        {
            lblBotId.Text = "Bot ID: (Не привязан)";
            lblBotName.Text = "Название бота: —";
            lblUsernameBot.Text = "Юзернейм бота: —";
            lblBotStatus.Text = "Статус: Не подключен";
        }

        // =========================================================
        // Token
        // =========================================================
        private void SetTokenVisibility(bool visible)
        {
            tokenVisible = visible;
            try { txtBotToken.PasswordChar = visible ? '\0' : '●'; } catch { }
            try { txtBotToken.ShowText = visible; } catch { }
        }

        private void BtnShowToken_Click(object? sender, EventArgs e)
        {
            SetTokenVisibility(!tokenVisible);
            txtBotToken.Focus();
            try { txtBotToken.Select(txtBotToken.TextLength, 0); } catch { }
        }

        // =========================================================
        // Подключение (ДВУХЭТАПНОЕ!)
        // =========================================================
        private async void BtnConnectBot_Click(object? sender, EventArgs e)
        {
            if (isConnecting) return;

            if (FindForm() is not ProfileAuthWindow authForm)
            {
                MessageBox.Show("Ошибка навигации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (authForm.CreationSession == null)
            {
                MessageBox.Show("Сессия создания профиля не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authForm.ShowWelcomePage();
                return;
            }

            if (!isBotConnected)
            {
                await ConnectAndShowBotInfoAsync(authForm);
            }
            else
            {
                ConfirmAndProceed(authForm);
            }
        }

        private async Task ConnectAndShowBotInfoAsync(ProfileAuthWindow authForm)
        {
            string token = txtBotToken.Text.Trim();

            if (string.IsNullOrWhiteSpace(token))
            {
                // Показываем иконку ошибки
                ShowTokenError("Введите Telegram Bot API Token");
                picTokenError.Visible = true;
                txtBotToken.Focus();
                return;
            }

            isConnecting = true;
            UpdateUIState();
            HideTokenError();
            picTokenError.Visible = false;

            try
            {
                bool connected = await telegramBotService.ConnectAsync(token);

                if (!connected || telegramBotService.BotInfo == null)
                {
                    ShowTokenError("Не удалось подключиться к боту");
                    picTokenError.Visible = true;
                    UpdateBotInfo();
                    return;
                }

                // Сохраняем данные бота в сессии
                authForm.CreationSession!.BotToken = telegramBotService.BotInfo.Token;
                authForm.CreationSession.BotId = telegramBotService.BotInfo.Id;
                authForm.CreationSession.BotUsername = telegramBotService.BotInfo.Username;
                authForm.CreationSession.BotFirstName = telegramBotService.BotInfo.FirstName;

                // Обновляем UI с информацией о боте
                UpdateBotInfo();
                isBotConnected = true;
                UpdateUIState();
            }
            catch (Exception)
            {
                ShowTokenError("Ошибка подключения");
                picTokenError.Visible = true;
            }
            finally
            {
                isConnecting = false;
                UpdateUIState();
            }
        }

        private void ConfirmAndProceed(ProfileAuthWindow authForm)
        {
            if (authForm.CreationSession == null) return;

            if (authForm.CreationSession.BotId <= 0)
            {
                ShowTokenError("Данные о боте не получены");
                picTokenError.Visible = true;
                isBotConnected = false;
                UpdateUIState();
                return;
            }

            // Всё готово — переходим на SuccessPage
            authForm.CreationSession.BotConnected = true;
            authForm.ShowPage(new SuccessPage());
        }

        // =========================================================
        // Обновление UI
        // =========================================================
        private void UpdateUIState()
        {
            if (IsDisposed) return;

            bool enableControls = !isConnecting;

            btnConnectBot.Enabled = enableControls;
            btnShowToken.Enabled = enableControls;
            btnBack.Enabled = enableControls;
            txtBotToken.Enabled = enableControls;
            picBotInfo.Enabled = enableControls;

            if (isConnecting)
            {
                btnConnectBot.Text = "Подключение...";
            }
            else if (isBotConnected)
            {
                btnConnectBot.Text = "Подтвердить и продолжить";
                btnConnectBot.BackColor = Color.FromArgb(34, 197, 94); // Зелёный
            }
            else
            {
                btnConnectBot.Text = "Подключить бота";
                btnConnectBot.BackColor = Color.FromArgb(124, 58, 237); // Фиолетовый
            }
        }

        private void UpdateBotInfo()
        {
            if (IsDisposed) return;

            if (!telegramBotService.IsConnected || telegramBotService.BotInfo == null || telegramBotService.BotInfo.Id <= 0)
            {
                ResetBotInfo();
                return;
            }

            string username = telegramBotService.BotInfo.Username;
            string firstName = telegramBotService.BotInfo.FirstName;

            // Обновляем всю информацию о боте
            lblBotId.Text = $"Bot ID: {telegramBotService.BotInfo.Id}";
            lblBotName.Text = $"Название бота: {firstName}";
            lblUsernameBot.Text = $"Юзернейм бота: @{username}";
            lblBotStatus.Text = "Статус: Подключен";

            // Убеждаемся, что имя профиля всё ещё на месте
            LoadProfileInfo();
        }

        // =========================================================
        // События от сервиса
        // =========================================================
        private void TelegramBotService_BotConnected()
        {
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                BeginInvoke(new Action(TelegramBotService_BotConnected));
                return;
            }
            UpdateBotInfo();
        }

        private void TelegramBotService_BotDisconnected()
        {
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                BeginInvoke(new Action(TelegramBotService_BotDisconnected));
                return;
            }

            isBotConnected = false;
            UpdateBotInfo();
            UpdateUIState();
        }

        // =========================================================
        // Информация о боте (по клику на иконку)
        // =========================================================
        private void PicBotInfo_Click(object? sender, EventArgs e)
        {
            if (!telegramBotService.IsConnected || telegramBotService.BotInfo == null || telegramBotService.BotInfo.Id <= 0)
            {
                MessageBox.Show(
                    "Сначала подключите Telegram-бота, введя токен и нажав кнопку \"Подключить бота\".",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string firstName = telegramBotService.BotInfo.FirstName;
            string username = telegramBotService.BotInfo.Username;
            long botId = telegramBotService.BotInfo.Id;

            string usernameText = string.IsNullOrWhiteSpace(username) ? "(нет username)" : $"@{username}";

            MessageBox.Show(
                $"Telegram-бот\n\n" +
                $"Имя: {firstName}\n" +
                $"Username: {usernameText}\n" +
                $"Bot ID: {botId}\n\n" +
                $"Статус: Подключено",
                "Информация о боте",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // НАЗАД
        // =========================================================
        private void BtnBack_Click(object? sender, EventArgs e)
        {
            if (isConnecting)
            {
                MessageBox.Show("Подождите завершения подключения...", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ProfileAuthWindow? authForm = FindForm() as ProfileAuthWindow;

            if (authForm == null)
            {
                MessageBox.Show("Ошибка навигации: не удалось найти главное окно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Уточненный текст, чтобы пользователь не думал, что потеряет весь прогресс
            DialogResult result = MessageBox.Show(
                "Вы вернётесь к настройке имени и пароля профиля.\n\n" +
                "Данные о подключенном боте будут сброшены, но название профиля и пароль сохранятся.\n\n" +
                "Продолжить?",
                "Вернуться назад?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            isBotConnected = false;
            telegramBotService.Disconnect();
            HideTokenError();
            picTokenError.Visible = false;

            // Переходим назад, сессия (CreationSession) при этом СОХРАНЯЕТСЯ
            authForm.ShowPage(new CreateProfilePage());
        }


        // =========================================================
        // Ошибки
        // =========================================================
        private void ShowTokenError(string message)
        {
            uiToolTip1.SetToolTip(picTokenError, message);
        }

        private void HideTokenError()
        {
            uiToolTip1.SetToolTip(picTokenError, "");
        }

        // =========================================================
        // Реакция на ввод токена
        // =========================================================
        private void TxtBotToken_TextChanged(object? sender, EventArgs e)
        {
            HideTokenError();
            picTokenError.Visible = false;
        }
    }
}