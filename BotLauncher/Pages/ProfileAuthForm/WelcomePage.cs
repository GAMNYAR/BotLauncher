using System;
using System.Windows.Forms;

using ProfileAuthWindow = global::BotLauncher.ProfileAuthForm;

namespace BotLauncher.Pages.ProfileAuthForm
{
    public partial class WelcomePage : UserControl
    {
        public WelcomePage()
        {
            InitializeComponent();

            // =========================================================
            // НАСТРОЙКА ПОДСКАЗОК (используем существующий uiToolTip1)
            // =========================================================
            uiToolTip1.SetToolTip(btnMyProfiles, "Просмотреть и управлять существующими профилями");
            uiToolTip1.SetToolTip(btnCreateProfile, "Создать новый профиль с нуля");
            uiToolTip1.SetToolTip(btnImportProfile, "Импортировать существующий профиль из файла .blp");
            uiToolTip1.SetToolTip(btnRememberInfo, "Информация о безопасности и хранении данных");
            // =========================================================

            // Подписка на события кнопок 
            btnMyProfiles.Click += BtnMyProfiles_Click;
            btnCreateProfile.Click += BtnCreateProfile_Click;
            btnImportProfile.Click += BtnImportProfile_Click;
        }

        // =========================================================
        // ФУНКЦИИ (ОБРАБОТЧИКИ) ДЛЯ КНОПОК
        // =========================================================

        private void BtnMyProfiles_Click(object? sender, EventArgs e)
        {
            // Переход к списку профилей
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.ShowPage(new ProfileListPage());
            }
        }

        private void BtnCreateProfile_Click(object? sender, EventArgs e)
        {
            // Переход к созданию профиля
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.StartProfileCreation();
                authForm.ShowPage(new CreateProfilePage());
            }
        }

        private void BtnImportProfile_Click(object? sender, EventArgs e)
        {
            // Переход к импорту профиля
            if (FindForm() is ProfileAuthWindow authForm)
            {
                authForm.ShowPage(new ImportProfilePage());
            }
        }
    }
}