using BotLauncher.Controls;
using BotLauncher.Services.Telegram;
using BotLauncher.Shared.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotLauncher
{
    public partial class mainForm : Form
    {
        public TelegramBotService TelegramService => AppServices.TelegramBot;

        private readonly DashboardPage dashboardPage;
        private readonly YouTubeSettingsPage youtubePage;
        private readonly TelegramSettingsPage telegramPage;
        private readonly LogsPage logsPage;
        private readonly SettingsPage settingsPage;

        private SplashScreen? _splashScreen;
        private MissingTokenOverlay? _tokenOverlay;
        private Control? _currentPage;

        public mainForm()
        {
            InitializeComponent();

            dashboardPage = new DashboardPage();
            youtubePage = new YouTubeSettingsPage();
            telegramPage = new TelegramSettingsPage();
            logsPage = new LogsPage();
            settingsPage = new SettingsPage();

            dashboardPage.Dock = DockStyle.Fill;
            youtubePage.Dock = DockStyle.Fill;
            telegramPage.Dock = DockStyle.Fill;
            logsPage.Dock = DockStyle.Fill;
            settingsPage.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(dashboardPage);
            contentPanel.Controls.Add(youtubePage);
            contentPanel.Controls.Add(telegramPage);
            contentPanel.Controls.Add(logsPage);
            contentPanel.Controls.Add(settingsPage);

            dashboardPage.Visible = false;
            youtubePage.Visible = false;
            telegramPage.Visible = false;
            logsPage.Visible = false;
            settingsPage.Visible = false;

            ShowPage(dashboardPage);

            _tokenOverlay = new MissingTokenOverlay();
            _tokenOverlay.Dock = DockStyle.Fill;
            _tokenOverlay.Visible = false;

            _tokenOverlay.OpenSettingsRequested += OnOpenSettingsRequested;
            _tokenOverlay.CloseRequested += OnCloseRequested;

            this.Controls.Add(_tokenOverlay);
            _tokenOverlay.BringToFront();

            TelegramService.BotConnected += OnBotConnected;
            this.Load += MainForm_Load;
        }

        private async void MainForm_Load(object? sender, EventArgs e)
        {
            await ShowSplashScreenAsync();

            // ГЛАВНАЯ ПРОВЕРКА: Если флаг НЕ установлен И бот НЕ подключен -> показываем оверлей
            if (!Program.BotConnectedAtStartup && !TelegramService.IsConnected)
            {
                ShowTokenOverlay();
            }
        }

        private async Task ShowSplashScreenAsync()
        {
            _splashScreen = new SplashScreen();
            _splashScreen.Dock = DockStyle.Fill;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != _splashScreen)
                {
                    ctrl.Visible = false;
                }
            }

            this.Controls.Add(_splashScreen);
            _splashScreen.BringToFront();

            await _splashScreen.RunStartupChecksAsync(
                CheckProfileAsync,
                CheckBotAsync
            );

            await Task.Delay(300);

            this.Controls.Remove(_splashScreen);
            _splashScreen.Dispose();
            _splashScreen = null;

            // ИСПРАВЛЕНИЕ: Восстанавливаем видимость всех контролов, КРОМЕ оверлея
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != _tokenOverlay) // <-- ВАЖНО: не показываем оверлей автоматически
                {
                    ctrl.Visible = true;
                }
            }
        }

        private async Task CheckProfileAsync() => await Task.Delay(200);
        private async Task CheckBotAsync() => await Task.Delay(100);

        private void ShowPage(Control page)
        {
            if (_currentPage == page) return;
            if (_currentPage != null) _currentPage.Visible = false;

            page.Visible = true;
            page.BringToFront();
            _currentPage = page;

            contentPanel.PerformLayout();
            page.PerformLayout();
        }

        private void ShowTokenOverlay()
        {
            if (_tokenOverlay == null) return;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != _tokenOverlay) ctrl.Visible = false;
            }

            _tokenOverlay.Visible = true;
            _tokenOverlay.BringToFront();
            _tokenOverlay.Focus();
        }

        private void HideTokenOverlay()
        {
            if (_tokenOverlay == null) return;

            _tokenOverlay.Visible = false;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != _tokenOverlay) ctrl.Visible = true;
            }
        }

        private void OnOpenSettingsRequested(object? sender, EventArgs e)
        {
            HideTokenOverlay();
            ShowPage(telegramPage);
            telegramPage.SwitchToBotSettings();
        }

        private void OnCloseRequested(object? sender, EventArgs e) => HideTokenOverlay();

        private void OnBotConnected()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(HideTokenOverlay));
            }
            else
            {
                HideTokenOverlay();
            }
        }

        private void btnHomePage_Click(object? sender, EventArgs e) => ShowPage(dashboardPage);
        private void btnYouTubePage_Click(object? sender, EventArgs e) => ShowPage(youtubePage);
        private void btnTelegramPage_Click(object? sender, EventArgs e) => ShowPage(telegramPage);
        private void btnLogPage_Click(object? sender, EventArgs e) => ShowPage(logsPage);
        private void btnSettingsPage_Click(object? sender, EventArgs e) => ShowPage(settingsPage);

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (_tokenOverlay != null)
            {
                _tokenOverlay.OpenSettingsRequested -= OnOpenSettingsRequested;
                _tokenOverlay.CloseRequested -= OnCloseRequested;
            }
            TelegramService.BotConnected -= OnBotConnected;
            base.OnFormClosed(e);
        }
    }
}