using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class CreateProfilePage : UserControl
    {
        public CreateProfilePage()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';

            // Скрываем все иконки ошибок при загрузке
            HideAllErrors();

            UpdatePasswordStrength();
        }

        // =========================================================
        // Показ ошибки с иконкой
        // =========================================================
        private void ShowFieldError(PictureBox errorIcon, string message)
        {
            errorIcon.Visible = true;

            // Добавляем подсказку при наведении
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(errorIcon, message);
        }

        // =========================================================
        // Скрыть ошибку
        // =========================================================
        private void HideFieldError(PictureBox errorIcon)
        {
            errorIcon.Visible = false;
        }

        // =========================================================
        // Скрыть все ошибки
        // =========================================================
        private void HideAllErrors()
        {
            HideFieldError(picProfileNameError);
            HideFieldError(picPasswordError);
            HideFieldError(picConfirmPasswordError);
        }

        // =========================================================
        // Создание профиля
        // =========================================================
        private void BtnCreateProfile_Click(object? sender, EventArgs e)
        {
            if (FindForm() is not ProfileAuthWindow authForm) return;
            if (authForm.CreationSession == null)
            {
                authForm.ShowWelcomePage();
                return;
            }

            HideAllErrors();

            string profileName = txtProfileName.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // --- Валидация имени ---
            if (string.IsNullOrWhiteSpace(profileName))
            {
                ShowFieldError(picProfileNameError, "Введите название профиля");
                txtProfileName.Focus();
                return;
            }
            if (profileName.Length < 3 || profileName.Length > 50)
            {
                ShowFieldError(picProfileNameError, "От 3 до 50 символов");
                txtProfileName.Focus();
                return;
            }

            // --- Валидация пароля ---
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowFieldError(picPasswordError, "Введите пароль");
                txtPassword.Focus();
                return;
            }
            if (password.Length < 5)
            {
                ShowFieldError(picPasswordError, "Минимум 5 символов");
                txtPassword.Focus();
                return;
            }
            if (password.Any(char.IsWhiteSpace))
            {
                ShowFieldError(picPasswordError, "Без пробелов");
                txtPassword.Focus();
                return;
            }

            // --- Подтверждение пароля ---
            if (password != confirmPassword)
            {
                ShowFieldError(picConfirmPasswordError, "Пароли не совпадают");
                txtConfirmPassword.Focus();
                return;
            }

            // --- Успех: сохраняем и переходим дальше ---
            authForm.CreationSession.ProfileName = profileName;
            authForm.CreationSession.Password = password;
            authForm.ShowPage(new BotConnectPage());
        }

        // =========================================================
        // НАЗАД
        // =========================================================
        private void BtnBack_Click(object? sender, EventArgs e) => CancelCreation();
        private void BtnCancel_Click(object? sender, EventArgs e) => CancelCreation();

        private void CancelCreation()
        {
            if (FindForm() is not ProfileAuthWindow authForm)
            {
                MessageBox.Show("Ошибка навигации: не удалось найти главное окно.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!authForm.ConfirmCancelProfileCreation())
            {
                return;
            }

            ClearFields();
            authForm.CancelProfileCreation();
        }

        // =========================================================
        // Показ/скрытие пароля
        // =========================================================
        private void BtnShowPassword_Click(object? sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '\0' ? '●' : '\0';
        }

        private void BtnShowConfirmPassword_Click(object? sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = txtConfirmPassword.PasswordChar == '\0' ? '●' : '\0';
        }

        // =========================================================
        // Реакция на ввод (мгновенная очистка ошибок)
        // =========================================================
        private void TxtProfileName_TextChanged(object? sender, EventArgs e)
        {
            HideFieldError(picProfileNameError);
        }

        private void TxtConfirmPassword_TextChanged(object? sender, EventArgs e)
        {
            HideFieldError(picConfirmPasswordError);
        }

        private void TxtPassword_TextChanged(object? sender, EventArgs e)
        {
            HideFieldError(picPasswordError);
            UpdatePasswordStrength();
        }

        // =========================================================
        // Надёжность пароля
        // =========================================================
        private void UpdatePasswordStrength()
        {
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                lblPasswordStrength.Text = "Не определена";
                lblPasswordStrength.ForeColor = Color.FromArgb(161, 161, 170);
                return;
            }

            int score = 0;
            if (password.Length >= 5) score++;
            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (password.Length >= 16) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) score++;

            var (strength, color) = score switch
            {
                <= 1 => ("Очень слабый", Color.FromArgb(220, 38, 38)),
                2 => ("Слабый", Color.FromArgb(239, 68, 68)),
                3 => ("Ниже среднего", Color.FromArgb(249, 115, 22)),
                4 => ("Средний", Color.FromArgb(234, 179, 8)),
                5 => ("Нормальный", Color.FromArgb(250, 204, 21)),
                6 => ("Хороший", Color.FromArgb(132, 204, 22)),
                7 => ("Сильный", Color.FromArgb(74, 222, 128)),
                _ => ("Очень сильный", Color.FromArgb(34, 197, 94))
            };

            lblPasswordStrength.Text = strength;
            lblPasswordStrength.ForeColor = color;
        }

        // =========================================================
        // Утилиты
        // =========================================================
        private void ClearFields()
        {
            txtProfileName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPassword.PasswordChar = '●';
            txtConfirmPassword.PasswordChar = '●';
            HideAllErrors();
            UpdatePasswordStrength();
        }
    }
}