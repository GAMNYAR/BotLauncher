using BotLauncher.Models;
using BotLauncher.Models.Profile;
using BotLauncher.Services.Telegram;
using System;
using System.Windows.Forms;

using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class PasswordPage : UserControl
    {
        private readonly TelegramProfileManager profileManager;
        private readonly RememberedProfileService rememberedProfileService;
        private readonly string profileFileName;
        private bool passwordVisible;

        public PasswordPage(string profileFileName)
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(profileFileName))
                throw new ArgumentException("Имя файла профиля не указано.", nameof(profileFileName));

            this.profileFileName = profileFileName;
            profileManager = new TelegramProfileManager();
            rememberedProfileService = new RememberedProfileService();

            InitializePage();
        }

        // =========================================================
        // Инициализация
        // =========================================================
        private void InitializePage()
        {
            btnBack.Click += BtnBack_Click;
            btnCancel.Click += BtnCancel_Click;
            btnOpen.Click += BtnOpen_Click;
            btnTogglePassword.Click += BtnTogglePassword_Click;
            btnInfo.Click += BtnInfo_Click;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            txtPassword.TextChanged += TxtPassword_TextChanged;

            // Проверяем, есть ли запомненный пароль для этого профиля
            string profileName = System.IO.Path.GetFileNameWithoutExtension(profileFileName);
            var rememberedProfile = rememberedProfileService.GetRememberedProfile();

            if (rememberedProfile != null && rememberedProfile.ProfileName == profileName)
            {
                // Профиль запомнен - можно показать галочку или автоматически войти
                // Но для безопасности лучше попросить подтвердить
                chkRememberMe.Checked = true;
                chkRememberMe.Enabled = false; // Показываем что уже запомнен
            }

            passwordVisible = false;
            HidePasswordError();
            UpdateProfileName();
        }

        // =========================================================
        // Имя профиля
        // =========================================================
        private void UpdateProfileName()
        {
            string profileName = System.IO.Path.GetFileNameWithoutExtension(profileFileName);
            lblProfileName.Text = profileName;
        }

        // =========================================================
        // Работа с иконкой ошибки
        // =========================================================
        private void ShowPasswordError(string message)
        {
            picFileError.Visible = true;
            uiToolTip1.SetToolTip(picFileError, message);
        }

        private void HidePasswordError()
        {
            picFileError.Visible = false;
        }

        private void TxtPassword_TextChanged(object? sender, EventArgs e)
        {
            HidePasswordError();
        }

        // =========================================================
        // Открытие профиля
        // =========================================================
        private void BtnOpen_Click(object? sender, EventArgs e)
        {
            OpenProfile();
        }

        private void TxtPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            OpenProfile();
        }

        private void OpenProfile()
        {
            HidePasswordError();

            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowPasswordError("Введите пароль");
                txtPassword.Focus();
                return;
            }

            btnOpen.Enabled = false;

            try
            {
                bool opened = profileManager.OpenProfile(profileFileName, password);

                if (!opened)
                {
                    ShowPasswordError("Неверный пароль");

                    MessageBox.Show(
                        "Неверный пароль.\n\nПроверьте правильность ввода пароля для этого профиля.",
                        "Ошибка пароля",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return;
                }

                // =========================================================
                // Профиль успешно открыт!
                // =========================================================

                // Если галочка "Запомнить меня" стоит - сохраняем для авто-входа
                if (chkRememberMe.Checked)
                {
                    try
                    {
                        string profileName = System.IO.Path.GetFileNameWithoutExtension(profileFileName);
                        rememberedProfileService.RememberProfile(
                            profileFileName,
                            profileName,
                            password
                        );
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"[PasswordPage] Ошибка сохранения запомненного профиля: {ex.Message}");
                    }
                }
                else
                {
                    // Если галочка снята - удаляем запомненные данные
                    rememberedProfileService.ForgetProfile();
                }

                if (FindForm() is ProfileAuthWindow authForm)
                {
                    authForm.DialogResult = DialogResult.OK;
                    authForm.Close();
                }
            }
            catch (Exception exception)
            {
                ShowPasswordError("Ошибка открытия");

                MessageBox.Show(
                    exception.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnOpen.Enabled = true;
            }
        }

        // =========================================================
        // Показать / скрыть пароль
        // =========================================================
        private void BtnTogglePassword_Click(object? sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtPassword.ShowText = passwordVisible;
        }

        // =========================================================
        // Информация
        // =========================================================
        private void BtnInfo_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Введите пароль, который был установлен при создании этого профиля.\n\n" +
                "Если вы включите опцию \"Запомнить меня\", профиль будет открываться автоматически при следующем запуске программы.",
                "Пароль профиля",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // Назад
        // =========================================================
        private void BtnBack_Click(object? sender, EventArgs e)
        {
            ShowProfileList();
        }

        // =========================================================
        // Отмена
        // =========================================================
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            ShowProfileList();
        }

        // =========================================================
        // Показать список профилей
        // =========================================================
        private void ShowProfileList()
        {
            ProfileAuthWindow? authForm = FindForm() as ProfileAuthWindow;

            if (authForm == null)
                return;

            authForm.ShowPage(new ProfileListPage());
        }
    }
}