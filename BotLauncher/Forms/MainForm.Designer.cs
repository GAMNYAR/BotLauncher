namespace BotLauncher
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            leftMenuPanel = new Sunny.UI.UIPanel();
            pnlBotStatus = new Sunny.UI.UIPanel();
            pnlStatusCard = new Sunny.UI.UIPanel();
            lblStatusTitle = new Label();
            picStatusIcon = new PictureBox();
            lblStatusValue = new Label();
            lblBotWorkStatus = new Label();
            lblApiStatus = new Label();
            lblUptime = new Label();
            btnBotOnOff = new Sunny.UI.UIButton();
            btnBotRestart = new Sunny.UI.UIButton();
            pnlAppInfo = new Sunny.UI.UIPanel();
            lblCopyright = new Label();
            lblAppVersion = new Label();
            pnlNavigation = new Panel();
            btnSettingsPage = new Button();
            btnLogPage = new Button();
            btnTelegramPage = new Button();
            btnYouTubePage = new Button();
            btnHomePage = new Button();
            pnlBotProfile = new Sunny.UI.UIPanel();
            picAvatarBot = new PictureBox();
            lblNameBot = new Label();
            lblUsernameBot = new Label();
            contentPanel = new Sunny.UI.UIPanel();
            leftMenuPanel.SuspendLayout();
            pnlBotStatus.SuspendLayout();
            pnlStatusCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStatusIcon).BeginInit();
            pnlAppInfo.SuspendLayout();
            pnlNavigation.SuspendLayout();
            pnlBotProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatarBot).BeginInit();
            SuspendLayout();
            // 
            // leftMenuPanel
            // 
            leftMenuPanel.BackColor = Color.FromArgb(23, 25, 32);
            leftMenuPanel.Controls.Add(pnlBotStatus);
            leftMenuPanel.Controls.Add(pnlAppInfo);
            leftMenuPanel.Controls.Add(pnlNavigation);
            leftMenuPanel.Controls.Add(pnlBotProfile);
            leftMenuPanel.Dock = DockStyle.Left;
            leftMenuPanel.FillColor = Color.Transparent;
            leftMenuPanel.FillColor2 = Color.Transparent;
            leftMenuPanel.FillDisableColor = Color.Transparent;
            leftMenuPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            leftMenuPanel.ForeColor = Color.Transparent;
            leftMenuPanel.ForeDisableColor = Color.Transparent;
            leftMenuPanel.Location = new Point(0, 0);
            leftMenuPanel.Margin = new Padding(4, 5, 4, 5);
            leftMenuPanel.MinimumSize = new Size(240, 0);
            leftMenuPanel.Name = "leftMenuPanel";
            leftMenuPanel.Radius = 0;
            leftMenuPanel.RectColor = Color.Transparent;
            leftMenuPanel.RectDisableColor = Color.Transparent;
            leftMenuPanel.Size = new Size(240, 729);
            leftMenuPanel.Style = Sunny.UI.UIStyle.Custom;
            leftMenuPanel.TabIndex = 1;
            leftMenuPanel.Text = null;
            leftMenuPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlBotStatus
            // 
            pnlBotStatus.BackColor = Color.Transparent;
            pnlBotStatus.Controls.Add(pnlStatusCard);
            pnlBotStatus.Dock = DockStyle.Bottom;
            pnlBotStatus.FillColor = Color.Transparent;
            pnlBotStatus.FillColor2 = Color.Transparent;
            pnlBotStatus.FillDisableColor = Color.Transparent;
            pnlBotStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlBotStatus.ForeColor = Color.Transparent;
            pnlBotStatus.ForeDisableColor = Color.Transparent;
            pnlBotStatus.Location = new Point(0, 365);
            pnlBotStatus.Margin = new Padding(4, 5, 4, 5);
            pnlBotStatus.MinimumSize = new Size(1, 1);
            pnlBotStatus.Name = "pnlBotStatus";
            pnlBotStatus.Padding = new Padding(15, 30, 15, 10);
            pnlBotStatus.RectColor = Color.Transparent;
            pnlBotStatus.RectDisableColor = Color.Transparent;
            pnlBotStatus.Size = new Size(240, 329);
            pnlBotStatus.TabIndex = 4;
            pnlBotStatus.Text = null;
            pnlBotStatus.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlStatusCard
            // 
            pnlStatusCard.AutoSize = true;
            pnlStatusCard.Controls.Add(lblStatusTitle);
            pnlStatusCard.Controls.Add(picStatusIcon);
            pnlStatusCard.Controls.Add(lblStatusValue);
            pnlStatusCard.Controls.Add(lblBotWorkStatus);
            pnlStatusCard.Controls.Add(lblApiStatus);
            pnlStatusCard.Controls.Add(lblUptime);
            pnlStatusCard.Controls.Add(btnBotOnOff);
            pnlStatusCard.Controls.Add(btnBotRestart);
            pnlStatusCard.Dock = DockStyle.Fill;
            pnlStatusCard.FillColor = Color.FromArgb(32, 35, 45);
            pnlStatusCard.FillColor2 = Color.Transparent;
            pnlStatusCard.FillDisableColor = Color.Transparent;
            pnlStatusCard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlStatusCard.ForeColor = Color.Transparent;
            pnlStatusCard.ForeDisableColor = Color.Transparent;
            pnlStatusCard.Location = new Point(15, 30);
            pnlStatusCard.Margin = new Padding(5);
            pnlStatusCard.MinimumSize = new Size(1, 1);
            pnlStatusCard.Name = "pnlStatusCard";
            pnlStatusCard.Radius = 20;
            pnlStatusCard.RectColor = Color.FromArgb(42, 47, 58);
            pnlStatusCard.RectDisableColor = Color.Transparent;
            pnlStatusCard.Size = new Size(210, 289);
            pnlStatusCard.TabIndex = 0;
            pnlStatusCard.Text = null;
            pnlStatusCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.BackColor = Color.FromArgb(32, 35, 45);
            lblStatusTitle.FlatStyle = FlatStyle.Flat;
            lblStatusTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStatusTitle.ForeColor = Color.White;
            lblStatusTitle.Location = new Point(20, 19);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(96, 20);
            lblStatusTitle.TabIndex = 6;
            lblStatusTitle.Text = "Статус бота:";
            // 
            // picStatusIcon
            // 
            picStatusIcon.BackColor = Color.Transparent;
            picStatusIcon.BackgroundImage = (Image)resources.GetObject("picStatusIcon.BackgroundImage");
            picStatusIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picStatusIcon.Location = new Point(20, 48);
            picStatusIcon.Name = "picStatusIcon";
            picStatusIcon.Size = new Size(25, 25);
            picStatusIcon.TabIndex = 5;
            picStatusIcon.TabStop = false;
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.BackColor = Color.Transparent;
            lblStatusValue.FlatStyle = FlatStyle.Flat;
            lblStatusValue.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStatusValue.ForeColor = Color.White;
            lblStatusValue.Location = new Point(47, 50);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(72, 20);
            lblStatusValue.TabIndex = 1;
            lblStatusValue.Text = "Запущен";
            // 
            // lblBotWorkStatus
            // 
            lblBotWorkStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotWorkStatus.AutoEllipsis = true;
            lblBotWorkStatus.BackColor = Color.Transparent;
            lblBotWorkStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBotWorkStatus.ForeColor = Color.Silver;
            lblBotWorkStatus.Location = new Point(20, 76);
            lblBotWorkStatus.Name = "lblBotWorkStatus";
            lblBotWorkStatus.Size = new Size(170, 15);
            lblBotWorkStatus.TabIndex = 2;
            lblBotWorkStatus.Text = "Бот: Работает исправно";
            // 
            // lblApiStatus
            // 
            lblApiStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblApiStatus.AutoEllipsis = true;
            lblApiStatus.BackColor = Color.Transparent;
            lblApiStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblApiStatus.ForeColor = Color.Silver;
            lblApiStatus.Location = new Point(20, 91);
            lblApiStatus.Name = "lblApiStatus";
            lblApiStatus.Size = new Size(170, 15);
            lblApiStatus.TabIndex = 8;
            lblApiStatus.Text = "Статус API: Подключено";
            // 
            // lblUptime
            // 
            lblUptime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUptime.AutoEllipsis = true;
            lblUptime.BackColor = Color.Transparent;
            lblUptime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUptime.ForeColor = Color.Silver;
            lblUptime.Location = new Point(20, 106);
            lblUptime.Name = "lblUptime";
            lblUptime.Size = new Size(170, 15);
            lblUptime.TabIndex = 4;
            lblUptime.Text = "Время работы: 00:00:00";
            // 
            // btnBotOnOff
            // 
            btnBotOnOff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBotOnOff.BackColor = Color.Transparent;
            btnBotOnOff.BackgroundImageLayout = ImageLayout.Center;
            btnBotOnOff.FillColor = Color.Red;
            btnBotOnOff.FillColor2 = Color.Transparent;
            btnBotOnOff.FillDisableColor = Color.Transparent;
            btnBotOnOff.FillHoverColor = Color.FromArgb(255, 128, 128);
            btnBotOnOff.FillPressColor = Color.FromArgb(192, 0, 0);
            btnBotOnOff.FillSelectedColor = Color.Transparent;
            btnBotOnOff.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBotOnOff.ForeDisableColor = Color.Transparent;
            btnBotOnOff.ForeSelectedColor = Color.Transparent;
            btnBotOnOff.LightColor = Color.Transparent;
            btnBotOnOff.Location = new Point(20, 185);
            btnBotOnOff.Margin = new Padding(5);
            btnBotOnOff.MinimumSize = new Size(1, 1);
            btnBotOnOff.Name = "btnBotOnOff";
            btnBotOnOff.Radius = 10;
            btnBotOnOff.RectColor = Color.Transparent;
            btnBotOnOff.RectDisableColor = Color.Transparent;
            btnBotOnOff.RectHoverColor = Color.Transparent;
            btnBotOnOff.RectPressColor = Color.Transparent;
            btnBotOnOff.RectSelectedColor = Color.Transparent;
            btnBotOnOff.Size = new Size(170, 40);
            btnBotOnOff.TabIndex = 57;
            btnBotOnOff.Text = "Остановить";
            btnBotOnOff.TipsColor = Color.Transparent;
            btnBotOnOff.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBotOnOff.TipsForeColor = Color.Transparent;
            // 
            // btnBotRestart
            // 
            btnBotRestart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBotRestart.BackColor = Color.Transparent;
            btnBotRestart.BackgroundImageLayout = ImageLayout.Center;
            btnBotRestart.FillColor = Color.Transparent;
            btnBotRestart.FillColor2 = Color.Transparent;
            btnBotRestart.FillDisableColor = Color.Transparent;
            btnBotRestart.FillHoverColor = Color.Yellow;
            btnBotRestart.FillPressColor = Color.Gold;
            btnBotRestart.FillSelectedColor = Color.Transparent;
            btnBotRestart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBotRestart.ForeDisableColor = Color.Transparent;
            btnBotRestart.ForeSelectedColor = Color.Transparent;
            btnBotRestart.LightColor = Color.Transparent;
            btnBotRestart.Location = new Point(20, 235);
            btnBotRestart.Margin = new Padding(5);
            btnBotRestart.MinimumSize = new Size(1, 1);
            btnBotRestart.Name = "btnBotRestart";
            btnBotRestart.Radius = 10;
            btnBotRestart.RectColor = Color.FromArgb(42, 45, 54);
            btnBotRestart.RectDisableColor = Color.Transparent;
            btnBotRestart.RectHoverColor = Color.DarkGray;
            btnBotRestart.RectPressColor = Color.WhiteSmoke;
            btnBotRestart.RectSelectedColor = Color.Transparent;
            btnBotRestart.Size = new Size(170, 40);
            btnBotRestart.TabIndex = 59;
            btnBotRestart.Text = "Перезапустить";
            btnBotRestart.TipsColor = Color.Transparent;
            btnBotRestart.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBotRestart.TipsForeColor = Color.Transparent;
            // 
            // pnlAppInfo
            // 
            pnlAppInfo.BackColor = Color.Transparent;
            pnlAppInfo.Controls.Add(lblCopyright);
            pnlAppInfo.Controls.Add(lblAppVersion);
            pnlAppInfo.Dock = DockStyle.Bottom;
            pnlAppInfo.FillColor = Color.Transparent;
            pnlAppInfo.FillColor2 = Color.Transparent;
            pnlAppInfo.FillDisableColor = Color.Transparent;
            pnlAppInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlAppInfo.ForeColor = Color.Transparent;
            pnlAppInfo.ForeDisableColor = Color.Transparent;
            pnlAppInfo.Location = new Point(0, 694);
            pnlAppInfo.Margin = new Padding(0);
            pnlAppInfo.MinimumSize = new Size(1, 1);
            pnlAppInfo.Name = "pnlAppInfo";
            pnlAppInfo.RectColor = Color.Transparent;
            pnlAppInfo.RectDisableColor = Color.Transparent;
            pnlAppInfo.Size = new Size(240, 35);
            pnlAppInfo.TabIndex = 3;
            pnlAppInfo.Text = null;
            pnlAppInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            lblCopyright.Anchor = AnchorStyles.Bottom;
            lblCopyright.AutoSize = true;
            lblCopyright.BackColor = Color.Transparent;
            lblCopyright.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCopyright.ForeColor = Color.Silver;
            lblCopyright.Location = new Point(63, 16);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(115, 13);
            lblCopyright.TabIndex = 1;
            lblCopyright.Text = "© 2026 Bot Launcher";
            lblCopyright.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAppVersion
            // 
            lblAppVersion.Anchor = AnchorStyles.Bottom;
            lblAppVersion.AutoSize = true;
            lblAppVersion.BackColor = Color.Transparent;
            lblAppVersion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAppVersion.ForeColor = Color.Silver;
            lblAppVersion.Location = new Point(83, 0);
            lblAppVersion.Name = "lblAppVersion";
            lblAppVersion.Size = new Size(75, 13);
            lblAppVersion.TabIndex = 0;
            lblAppVersion.Text = "Версия: 1.0.0";
            lblAppVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNavigation
            // 
            pnlNavigation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlNavigation.AutoSize = true;
            pnlNavigation.Controls.Add(btnSettingsPage);
            pnlNavigation.Controls.Add(btnLogPage);
            pnlNavigation.Controls.Add(btnTelegramPage);
            pnlNavigation.Controls.Add(btnYouTubePage);
            pnlNavigation.Controls.Add(btnHomePage);
            pnlNavigation.Location = new Point(0, 140);
            pnlNavigation.Margin = new Padding(0);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(240, 225);
            pnlNavigation.TabIndex = 1;
            // 
            // btnSettingsPage
            // 
            btnSettingsPage.BackColor = Color.Transparent;
            btnSettingsPage.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsPage.Dock = DockStyle.Top;
            btnSettingsPage.FlatAppearance.BorderSize = 0;
            btnSettingsPage.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnSettingsPage.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnSettingsPage.FlatStyle = FlatStyle.Flat;
            btnSettingsPage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSettingsPage.ForeColor = Color.White;
            btnSettingsPage.Image = (Image)resources.GetObject("btnSettingsPage.Image");
            btnSettingsPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettingsPage.Location = new Point(0, 180);
            btnSettingsPage.Margin = new Padding(0);
            btnSettingsPage.MinimumSize = new Size(0, 45);
            btnSettingsPage.Name = "btnSettingsPage";
            btnSettingsPage.Padding = new Padding(15, 0, 0, 0);
            btnSettingsPage.Size = new Size(240, 45);
            btnSettingsPage.TabIndex = 14;
            btnSettingsPage.Text = "  Настройки";
            btnSettingsPage.TextAlign = ContentAlignment.MiddleLeft;
            btnSettingsPage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettingsPage.UseVisualStyleBackColor = false;
            btnSettingsPage.Click += btnSettingsPage_Click;
            // 
            // btnLogPage
            // 
            btnLogPage.BackColor = Color.Transparent;
            btnLogPage.BackgroundImageLayout = ImageLayout.Center;
            btnLogPage.Dock = DockStyle.Top;
            btnLogPage.FlatAppearance.BorderSize = 0;
            btnLogPage.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnLogPage.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnLogPage.FlatStyle = FlatStyle.Flat;
            btnLogPage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogPage.ForeColor = Color.White;
            btnLogPage.Image = (Image)resources.GetObject("btnLogPage.Image");
            btnLogPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogPage.Location = new Point(0, 135);
            btnLogPage.Margin = new Padding(0);
            btnLogPage.MinimumSize = new Size(0, 45);
            btnLogPage.Name = "btnLogPage";
            btnLogPage.Padding = new Padding(15, 0, 0, 0);
            btnLogPage.Size = new Size(240, 45);
            btnLogPage.TabIndex = 13;
            btnLogPage.Text = "  Логи";
            btnLogPage.TextAlign = ContentAlignment.MiddleLeft;
            btnLogPage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogPage.UseVisualStyleBackColor = false;
            btnLogPage.Click += btnLogPage_Click;
            // 
            // btnTelegramPage
            // 
            btnTelegramPage.BackColor = Color.Transparent;
            btnTelegramPage.BackgroundImageLayout = ImageLayout.Center;
            btnTelegramPage.Dock = DockStyle.Top;
            btnTelegramPage.FlatAppearance.BorderSize = 0;
            btnTelegramPage.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnTelegramPage.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnTelegramPage.FlatStyle = FlatStyle.Flat;
            btnTelegramPage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnTelegramPage.ForeColor = Color.White;
            btnTelegramPage.Image = (Image)resources.GetObject("btnTelegramPage.Image");
            btnTelegramPage.ImageAlign = ContentAlignment.MiddleLeft;
            btnTelegramPage.Location = new Point(0, 90);
            btnTelegramPage.Margin = new Padding(0);
            btnTelegramPage.MinimumSize = new Size(0, 45);
            btnTelegramPage.Name = "btnTelegramPage";
            btnTelegramPage.Padding = new Padding(15, 0, 0, 0);
            btnTelegramPage.Size = new Size(240, 45);
            btnTelegramPage.TabIndex = 12;
            btnTelegramPage.Text = "  Telegram";
            btnTelegramPage.TextAlign = ContentAlignment.MiddleLeft;
            btnTelegramPage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTelegramPage.UseVisualStyleBackColor = false;
            btnTelegramPage.Click += btnTelegramPage_Click;
            // 
            // btnYouTubePage
            // 
            btnYouTubePage.BackColor = Color.Transparent;
            btnYouTubePage.BackgroundImageLayout = ImageLayout.Center;
            btnYouTubePage.Dock = DockStyle.Top;
            btnYouTubePage.FlatAppearance.BorderSize = 0;
            btnYouTubePage.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnYouTubePage.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            btnYouTubePage.FlatStyle = FlatStyle.Flat;
            btnYouTubePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnYouTubePage.ForeColor = Color.White;
            btnYouTubePage.Image = (Image)resources.GetObject("btnYouTubePage.Image");
            btnYouTubePage.ImageAlign = ContentAlignment.MiddleLeft;
            btnYouTubePage.Location = new Point(0, 45);
            btnYouTubePage.Margin = new Padding(0);
            btnYouTubePage.MinimumSize = new Size(0, 45);
            btnYouTubePage.Name = "btnYouTubePage";
            btnYouTubePage.Padding = new Padding(15, 0, 0, 0);
            btnYouTubePage.Size = new Size(240, 45);
            btnYouTubePage.TabIndex = 11;
            btnYouTubePage.Text = "  YouTube";
            btnYouTubePage.TextAlign = ContentAlignment.MiddleLeft;
            btnYouTubePage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnYouTubePage.UseVisualStyleBackColor = false;
            btnYouTubePage.Click += btnYouTubePage_Click;
            // 
            // btnHomePage
            // 
            btnHomePage.BackColor = Color.Transparent;
            btnHomePage.BackgroundImageLayout = ImageLayout.Center;
            btnHomePage.Dock = DockStyle.Top;
            btnHomePage.FlatAppearance.BorderSize = 0;
            btnHomePage.FlatAppearance.MouseDownBackColor = Color.Indigo;
            btnHomePage.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnHomePage.FlatStyle = FlatStyle.Flat;
            btnHomePage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnHomePage.ForeColor = Color.White;
            btnHomePage.Image = (Image)resources.GetObject("btnHomePage.Image");
            btnHomePage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomePage.Location = new Point(0, 0);
            btnHomePage.Margin = new Padding(0);
            btnHomePage.MinimumSize = new Size(0, 45);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Padding = new Padding(15, 0, 0, 0);
            btnHomePage.Size = new Size(240, 45);
            btnHomePage.TabIndex = 10;
            btnHomePage.Text = "  Главная";
            btnHomePage.TextAlign = ContentAlignment.MiddleLeft;
            btnHomePage.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHomePage.UseVisualStyleBackColor = false;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // pnlBotProfile
            // 
            pnlBotProfile.BackColor = Color.Transparent;
            pnlBotProfile.Controls.Add(picAvatarBot);
            pnlBotProfile.Controls.Add(lblNameBot);
            pnlBotProfile.Controls.Add(lblUsernameBot);
            pnlBotProfile.Dock = DockStyle.Top;
            pnlBotProfile.FillColor = Color.Transparent;
            pnlBotProfile.FillColor2 = Color.Transparent;
            pnlBotProfile.FillDisableColor = Color.Transparent;
            pnlBotProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlBotProfile.ForeColor = Color.Transparent;
            pnlBotProfile.ForeDisableColor = Color.Transparent;
            pnlBotProfile.Location = new Point(0, 0);
            pnlBotProfile.Margin = new Padding(4, 5, 4, 5);
            pnlBotProfile.MinimumSize = new Size(0, 140);
            pnlBotProfile.Name = "pnlBotProfile";
            pnlBotProfile.RectColor = Color.Transparent;
            pnlBotProfile.RectDisableColor = Color.Transparent;
            pnlBotProfile.Size = new Size(240, 140);
            pnlBotProfile.Style = Sunny.UI.UIStyle.Custom;
            pnlBotProfile.TabIndex = 0;
            pnlBotProfile.Text = null;
            pnlBotProfile.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // picAvatarBot
            // 
            picAvatarBot.BackgroundImage = (Image)resources.GetObject("picAvatarBot.BackgroundImage");
            picAvatarBot.BackgroundImageLayout = ImageLayout.Zoom;
            picAvatarBot.Location = new Point(85, 17);
            picAvatarBot.Name = "picAvatarBot";
            picAvatarBot.Size = new Size(70, 70);
            picAvatarBot.TabIndex = 0;
            picAvatarBot.TabStop = false;
            // 
            // lblNameBot
            // 
            lblNameBot.AutoEllipsis = true;
            lblNameBot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNameBot.Location = new Point(0, 87);
            lblNameBot.Name = "lblNameBot";
            lblNameBot.Size = new Size(240, 20);
            lblNameBot.TabIndex = 1;
            lblNameBot.Text = "Name Bot";
            lblNameBot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameBot
            // 
            lblUsernameBot.BackColor = Color.Transparent;
            lblUsernameBot.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblUsernameBot.ForeColor = Color.Silver;
            lblUsernameBot.Location = new Point(0, 109);
            lblUsernameBot.Name = "lblUsernameBot";
            lblUsernameBot.Size = new Size(240, 15);
            lblUsernameBot.TabIndex = 6;
            lblUsernameBot.Text = "@usernamebot";
            lblUsernameBot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(27, 29, 36);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.FillColor = Color.Transparent;
            contentPanel.FillColor2 = Color.Transparent;
            contentPanel.FillDisableColor = Color.Transparent;
            contentPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contentPanel.ForeColor = Color.Transparent;
            contentPanel.ForeDisableColor = Color.Transparent;
            contentPanel.Location = new Point(240, 0);
            contentPanel.Margin = new Padding(0);
            contentPanel.MinimumSize = new Size(1, 1);
            contentPanel.Name = "contentPanel";
            contentPanel.Radius = 0;
            contentPanel.RectColor = Color.Transparent;
            contentPanel.RectDisableColor = Color.Transparent;
            contentPanel.Size = new Size(976, 729);
            contentPanel.Style = Sunny.UI.UIStyle.Custom;
            contentPanel.TabIndex = 2;
            contentPanel.Text = null;
            contentPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 29, 36);
            ClientSize = new Size(1216, 729);
            Controls.Add(contentPanel);
            Controls.Add(leftMenuPanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(1232, 768);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bot Launcher";
            leftMenuPanel.ResumeLayout(false);
            leftMenuPanel.PerformLayout();
            pnlBotStatus.ResumeLayout(false);
            pnlBotStatus.PerformLayout();
            pnlStatusCard.ResumeLayout(false);
            pnlStatusCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStatusIcon).EndInit();
            pnlAppInfo.ResumeLayout(false);
            pnlAppInfo.PerformLayout();
            pnlNavigation.ResumeLayout(false);
            pnlBotProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAvatarBot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel leftMenuPanel;
        private Sunny.UI.UIPanel contentPanel;
        private Sunny.UI.UIPanel pnlBotProfile;
        private Label lblNameBot;
        private PictureBox picAvatarBot;
        private Panel pnlNavigation;
        private Sunny.UI.UIPanel pnlStatusCard;
        private Label lblStatusValue;
        private Label lblBotWorkStatus;
        private Label lblUptime;
        private PictureBox picStatusIcon;
        private Label lblUsernameBot;
        private Sunny.UI.UIPanel pnlAppInfo;
        private Label lblCopyright;
        private Label lblAppVersion;
        private Label lblStatusTitle;
        private Label lblApiStatus;
        private Button btnHomePage;
        private Button btnYouTubePage;
        private Button btnSettingsPage;
        private Button btnLogPage;
        private Button btnTelegramPage;
        private Sunny.UI.UIPanel pnlBotStatus;
        private Sunny.UI.UIButton btnBotOnOff;
        private Sunny.UI.UIButton btnBotRestart;
    }
}