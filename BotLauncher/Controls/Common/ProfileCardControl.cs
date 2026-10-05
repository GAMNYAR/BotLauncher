using System;
using System.Drawing;
using System.Windows.Forms;
using BotLauncher.Services.Telegram;

namespace BotLauncher.Controls
{
    public partial class ProfileCardControl : UserControl
    {
        // События
        public event EventHandler<string>? OpenRequested;
        public event EventHandler<string>? DeleteRequested;
        public event EventHandler<string>? MigrateRequested;

        private string profileName = string.Empty;
        private string filePath = string.Empty;
        private int formatVersion = 1;

        public ProfileCardControl()
        {
            InitializeComponent();

            // Базовые настройки для корректной работы внутри TableLayoutPanel
            this.AutoSize = false;
            this.MinimumSize = new Size(300, 100);
            this.MaximumSize = new Size(1200, 100);
        }

        public void SetData(string name, string path, DateTime lastUsed, string? username = null)
        {
            profileName = name;
            filePath = path;

            lblProfileName.Text = name;

            if (!string.IsNullOrWhiteSpace(username))
            {
                lblProfileUsername.Text = username;
                lblProfileUsername.Visible = true;
            }
            else
            {
                lblProfileUsername.Text = "@unknown";
                lblProfileUsername.Visible = true;
            }

            lblLastUsed.Text = $"Последнее использование: {lastUsed:dd.MM.yyyy HH:mm}";

            // Определяем версию формата и сразу обновляем текст
            DetectFormatVersion();
        }

        // =========================================================
        // Определение версии формата файла
        // =========================================================
        private void DetectFormatVersion()
        {
            try
            {
                var storage = new TelegramProfileStorageService();
                var header = storage.ReadHeader(filePath);

                if (header != null)
                {
                    formatVersion = 2;
                    lblFormatVersion.Text = "Версия файла: v.0.2";
                }
                else
                {
                    formatVersion = 1;
                    lblFormatVersion.Text = "Версия файла: v.0.1";
                }
                lblFormatVersion.Visible = true;
            }
            catch
            {
                formatVersion = 1;
                lblFormatVersion.Text = "Версия файла: v.0.1";
                lblFormatVersion.Visible = true;
            }
        }

        // =========================================================
        // Кнопка "Открыть"
        // =========================================================
        private void btnOpenProfile_Click(object? sender, EventArgs e)
        {
            OpenRequested?.Invoke(this, filePath);
        }

        // =========================================================
        // Кнопка меню (три точки)
        // =========================================================
        private void btnProfileMenu_Click(object? sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem openItem = new ToolStripMenuItem("Открыть");
            openItem.Click += (s, ev) => OpenRequested?.Invoke(this, filePath);

            // Кнопка миграции (только для старых файлов)
            if (formatVersion == 1)
            {
                ToolStripMenuItem migrateItem = new ToolStripMenuItem("Обновить формат файла");
                migrateItem.ForeColor = Color.FromArgb(138, 43, 226); // Фиолетовый
                migrateItem.Click += (s, ev) => MigrateRequested?.Invoke(this, filePath);
                menu.Items.Add(migrateItem);
                menu.Items.Add(new ToolStripSeparator());
            }

            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Удалить");
            deleteItem.ForeColor = Color.Red;
            deleteItem.Click += (s, ev) => DeleteRequested?.Invoke(this, filePath);

            menu.Items.Add(openItem);
            menu.Items.Add(deleteItem);

            menu.Show(btnProfileMenu, new Point(0, btnProfileMenu.Height));
        }

        public string GetProfileName() => profileName;
        public string GetFilePath() => filePath;
        public int GetFormatVersion() => formatVersion;
    }
}