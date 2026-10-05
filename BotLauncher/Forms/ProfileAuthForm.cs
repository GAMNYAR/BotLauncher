using BotLauncher.Models.Profile;
using BotLauncher.Pages.ProfileAuthForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotLauncher
{
    public partial class ProfileAuthForm : Form
    {
        public ProfileCreationSession? CreationSession { get; private set; }

        public ProfileAuthForm()
        {
            InitializeComponent();

            // Используем стандартную рамку Windows с возможностью изменения размера
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(450, 700);

            FormClosing += ProfileAuthForm_FormClosing;

            ShowWelcomePage();
        }

        public void StartProfileCreation() => CreationSession = new ProfileCreationSession();
        public void CancelProfileCreation() { CreationSession = null; ShowWelcomePage(); }
        public void CompleteProfileCreation() => CreationSession = null;

        public void ShowWelcomePage() => ShowPage(new WelcomePage());

        public void ShowPage(UserControl page)
        {
            if (page == null) throw new ArgumentNullException(nameof(page));
            page.Dock = DockStyle.Fill;
            page.Margin = new Padding(0);
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(page);
            page.BringToFront();
        }

        public bool ConfirmCancelProfileCreation()
        {
            DialogResult result = MessageBox.Show(
                "Введённые данные будут удалены.\nПрофиль не будет создан.",
                "Отменить создание профиля?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private void ProfileAuthForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (CreationSession == null || CreationSession.ProfileCreated) return;

            DialogResult result = MessageBox.Show(
                "Сейчас выполняется создание профиля.\nЕсли выйти, все введённые данные будут удалены, " +
                "а профиль не будет создан.\nВы действительно хотите выйти?",
                "Выйти из создания профиля?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            CreationSession = null;
        }
    }
}