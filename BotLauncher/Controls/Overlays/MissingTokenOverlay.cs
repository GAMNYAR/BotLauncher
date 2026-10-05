using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotLauncher.Controls
{
    public partial class MissingTokenOverlay : UserControl
    {
        public event EventHandler? OpenSettingsRequested;
        public event EventHandler? CloseRequested;

        public MissingTokenOverlay()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(15, 15, 20);

            // Подписываемся на события мыши для смены иконки
            btnClose.MouseEnter += BtnClose_MouseEnter;
            btnClose.MouseLeave += BtnClose_MouseLeave;
            btnClose.MouseDown += BtnClose_MouseDown;
            btnClose.MouseUp += BtnClose_MouseUp;
        }

        // Методы из Designer (обязательно должны быть!)
        private void BtnOpenSettings_Click(object? sender, EventArgs e)
        {
            OpenSettingsRequested?.Invoke(this, EventArgs.Empty);
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }

        // Смена иконки при наведении
        private void BtnClose_MouseEnter(object? sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.icon_close_hover;
        }

        private void BtnClose_MouseLeave(object? sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.icon_close_normal;
        }

        private void BtnClose_MouseDown(object? sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.icon_close_pressed;
        }

        private void BtnClose_MouseUp(object? sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.icon_close_hover;
        }
    }
}