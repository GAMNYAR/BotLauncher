using BotLauncher.Models.Profile;
using BotLauncher.Services.Telegram;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class SuccessPage : UserControl
    {
        private bool launching;
        private readonly TelegramProfileManager profileManager;
        private readonly RememberedProfileService rememberedProfileService;

        public SuccessPage()
        {
            InitializeComponent();
            profileManager = new TelegramProfileManager();
            rememberedProfileService = new RememberedProfileService();

            this.Load += SuccessPage_Load;
            btnLaunchBotLauncher.Click += BtnLaunchBotLauncher_Click;
            btnRememberInfo.Click += BtnRememberInfo_Click;
            chkRememberMe.CheckedChanged += ChkRememberMe_CheckedChanged;
        }

        // =========================================================
        // Надежное получение родительской формы
        // =========================================================
        private ProfileAuthWindow? GetAuthForm()
        {
            return this.FindForm() as ProfileAuthWindow ?? this.ParentForm as ProfileAuthWindow;
        }

        private void SuccessPage_Load(object? sender, EventArgs e)
        {
            var authForm = GetAuthForm();

            // КРИТИЧЕСКАЯ ПРОВЕРКА: Если формы или сессии нет, немедленно уходим на главный экран.
            // Это предотвращает появление "сломанной" страницы и странных ошибок.
            if (authForm == null || authForm.CreationSession == null)
            {
                System.Diagnostics.Debug.WriteLine("[SuccessPage] Сессия отсутствует при загрузке. Перенаправление на WelcomePage.");
                authForm?.ShowWelcomePage();
                return;
            }

            InitializePage();
            LoadCreationSession(authForm.CreationSession);
        }

        private void InitializePage()
        {
            chkRememberMe.Enabled = true;
            chkRememberMe.Checked = false;
        }

        private void LoadCreationSession(ProfileCreationSession session)
        {
            lblProfileInfoValue.Text = string.IsNullOrWhiteSpace(session.ProfileName) ? "Не указано" : session.ProfileName;

            lblBotUsernameValue.Text = string.IsNullOrWhiteSpace(session.BotUsername)
                ? "Не указан"
                : (session.BotUsername.StartsWith("@") ? session.BotUsername : "@" + session.BotUsername);

            lblBotNameValue.Text = string.IsNullOrWhiteSpace(session.BotFirstName) ? "Не указано" : session.BotFirstName;
            lblBotIdValue.Text = session.BotId > 0 ? session.BotId.ToString() : "Не указан";
            lblCreatedAtValue.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            chkRememberMe.Checked = session.RememberMe;

            // Активируем кнопку только если сессия валидна
            btnLaunchBotLauncher.Enabled = true;
            btnLaunchBotLauncher.Text = "Запустить Bot Launcher";
        }

        private void ChkRememberMe_CheckedChanged(object? sender, EventArgs e)
        {
            var authForm = GetAuthForm();
            if (authForm?.CreationSession != null)
            {
                authForm.CreationSession.RememberMe = chkRememberMe.Checked;
            }
        }

        private void BtnRememberInfo_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Если включить эту опцию, Bot Launcher сможет запомнить выбор профиля на этом компьютере.\n\n" +
                "При следующем запуске программы профиль откроется автоматически без ввода пароля.\n\n" +
                "⚠️ Внимание: используйте эту функцию только на личных устройствах!",
                "Запомнить профиль",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnLaunchBotLauncher_Click(object? sender, EventArgs e)
        {
            if (launching) return;

            var authForm = GetAuthForm();
            if (authForm == null)
            {
                MessageBox.Show("Ошибка навигации: не удалось найти главное окно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (authForm.CreationSession == null)
            {
                authForm.ShowWelcomePage();
                return;
            }

            var session = authForm.CreationSession;

            if (!session.BotConnected || session.BotId <= 0 || string.IsNullOrWhiteSpace(session.BotToken))
            {
                MessageBox.Show("Telegram-бот не был корректно подключён.\n\nВернитесь назад и подключите бота.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(session.Password))
            {
                MessageBox.Show("Пароль профиля не задан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            launching = true;
            btnLaunchBotLauncher.Enabled = false;
            btnLaunchBotLauncher.Text = "Создание профиля...";

            try
            {
                // Шаг 1: Создание профиля в памяти
                var profile = profileManager.CreateProfile(session.ProfileName);
                if (profile == null)
                {
                    MessageBox.Show("Ошибка: не удалось создать профиль в памяти.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Шаг 2: Привязка бота
                bool bound = profileManager.BindBot(session.BotId, session.BotUsername, session.BotFirstName, session.BotToken);
                if (!bound)
                {
                    MessageBox.Show("Не удалось привязать бота к профилю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Шаг 3: Подготовка пути
                string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                string fileName = session.ProfileName + ".blp";
                string fullPath = Path.Combine(dataFolder, fileName);

                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                }

                // Шаг 4: Сохранение профиля
                bool saved = profileManager.CreateAndSaveProfile(fullPath, session.Password);

                if (!saved)
                {
                    MessageBox.Show("Не удалось сохранить профиль. Проверьте права доступа к папке Data.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Шаг 5: Если галочка "Запомнить меня" стоит - сохраняем для авто-входа
                if (chkRememberMe.Checked)
                {
                    try
                    {
                        rememberedProfileService.RememberProfile(
                            Path.Combine("Data", fileName),
                            session.ProfileName,
                            session.Password
                        );
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"[SuccessPage] Ошибка сохранения запомненного профиля: {ex.Message}");
                        // Не прерываем процесс, просто не сохраняем для авто-входа
                    }
                }

                // Успех
                session.ProfileCreated = true;
                authForm.CompleteProfileCreation();

                MessageBox.Show(
                    $"Профиль успешно создан и сохранён!\n\n" +
                    $"Путь: {fullPath}\n\n" +
                    (chkRememberMe.Checked ? "✓ Авто-вход включен" : ""),
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                authForm.DialogResult = DialogResult.OK;
                authForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка:\n\n{ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                launching = false;
                btnLaunchBotLauncher.Enabled = true;
                btnLaunchBotLauncher.Text = "Запустить Bot Launcher";
            }
        }
    }
}