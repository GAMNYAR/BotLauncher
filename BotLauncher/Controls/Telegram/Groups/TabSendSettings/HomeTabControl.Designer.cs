namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class HomeTabControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTabControl));
            grpHome = new Sunny.UI.UIGroupBox();
            pnlHomeButtons = new Sunny.UI.UIPanel();
            chkHomeManualConfirm = new Sunny.UI.UICheckBox();
            btnSaveHome = new Sunny.UI.UIButton();
            btnStartHome = new Sunny.UI.UIButton();
            pnlHomeInner = new Panel();
            pnlHomeContent = new Panel();
            grpHomeHistory = new Sunny.UI.UIGroupBox();
            flpHomeHistory = new FlowLayoutPanel();
            grpModeDescription = new Sunny.UI.UIGroupBox();
            lblModeDescription = new Label();
            grpQuickActions = new Sunny.UI.UIGroupBox();
            pnlQuickActions = new FlowLayoutPanel();
            cmbNotificationChat = new Sunny.UI.UIComboBox();
            lblNotificationChat = new Label();
            chkQuietMode = new Sunny.UI.UICheckBox();
            chkNotifyComplete = new Sunny.UI.UICheckBox();
            chkNotifyErrors = new Sunny.UI.UICheckBox();
            nudDailyLimit = new Sunny.UI.UIIntegerUpDown();
            lblDailyLimit = new Label();
            cmbTimezone = new Sunny.UI.UIComboBox();
            lblTimezone = new Label();
            lblGeneralSettings = new Label();
            grpQuickStats = new Sunny.UI.UIGroupBox();
            pnlQuickStats = new FlowLayoutPanel();
            btnConfigureMode = new Sunny.UI.UIButton();
            radModeManual = new Sunny.UI.UIRadioButton();
            radModePriority = new Sunny.UI.UIRadioButton();
            radModeEvent = new Sunny.UI.UIRadioButton();
            radModeSchedule = new Sunny.UI.UIRadioButton();
            radModePeriodic = new Sunny.UI.UIRadioButton();
            radModeDelayed = new Sunny.UI.UIRadioButton();
            radModeAuto = new Sunny.UI.UIRadioButton();
            cmbActiveMode = new Sunny.UI.UIComboBox();
            lblActiveMode = new Label();
            grpGroupInfo = new Sunny.UI.UIGroupBox();
            pnlGroupInfo = new Panel();
            lblGroupId = new Label();
            lblGroupMembers = new Label();
            lblGroupType = new Label();
            lblGroupUsername = new Label();
            lblGroupTitle = new Label();
            picGroupStatus = new PictureBox();
            lblGroupStatus = new Label();
            lblStatTotalSent = new Label();
            lblStatSuccess = new Label();
            lblStatErrors = new Label();
            lblStatQueue = new Label();
            lblStatUptime = new Label();
            btnTestSend = new Sunny.UI.UIButton();
            btnPause = new Sunny.UI.UIButton();
            btnResume = new Sunny.UI.UIButton();
            btnClearQueue = new Sunny.UI.UIButton();
            btnExportSettings = new Sunny.UI.UIButton();
            btnImportSettings = new Sunny.UI.UIButton();
            btnPreview = new Sunny.UI.UIButton();
            btnDailyReport = new Sunny.UI.UIButton();
            grpHome.SuspendLayout();
            pnlHomeButtons.SuspendLayout();
            pnlHomeInner.SuspendLayout();
            pnlHomeContent.SuspendLayout();
            grpHomeHistory.SuspendLayout();
            grpModeDescription.SuspendLayout();
            grpQuickActions.SuspendLayout();
            grpQuickStats.SuspendLayout();
            grpGroupInfo.SuspendLayout();
            pnlGroupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGroupStatus).BeginInit();
            SuspendLayout();
            // 
            // grpHome
            // 
            grpHome.BackColor = Color.FromArgb(35, 39, 48);
            grpHome.Controls.Add(pnlHomeButtons);
            grpHome.Controls.Add(pnlHomeInner);
            grpHome.Dock = DockStyle.Fill;
            grpHome.FillColor = Color.Transparent;
            grpHome.FillColor2 = Color.Transparent;
            grpHome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpHome.ForeColor = Color.White;
            grpHome.Location = new Point(0, 0);
            grpHome.Margin = new Padding(4, 5, 4, 5);
            grpHome.MinimumSize = new Size(1, 1);
            grpHome.Name = "grpHome";
            grpHome.Padding = new Padding(0, 32, 0, 0);
            grpHome.Radius = 15;
            grpHome.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpHome.RectColor = Color.FromArgb(58, 58, 69);
            grpHome.Size = new Size(696, 483);
            grpHome.Style = Sunny.UI.UIStyle.Custom;
            grpHome.TabIndex = 1;
            grpHome.Text = "Главная — Управление группой";
            grpHome.TextAlignment = ContentAlignment.MiddleLeft;
            grpHome.TitleInterval = 8;
            grpHome.TitleTop = 14;
            // 
            // pnlHomeButtons
            // 
            pnlHomeButtons.Controls.Add(chkHomeManualConfirm);
            pnlHomeButtons.Controls.Add(btnSaveHome);
            pnlHomeButtons.Controls.Add(btnStartHome);
            pnlHomeButtons.Dock = DockStyle.Bottom;
            pnlHomeButtons.FillColor = Color.Transparent;
            pnlHomeButtons.FillColor2 = Color.Transparent;
            pnlHomeButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlHomeButtons.ForeColor = Color.Transparent;
            pnlHomeButtons.Location = new Point(0, 438);
            pnlHomeButtons.Margin = new Padding(4, 5, 4, 5);
            pnlHomeButtons.MinimumSize = new Size(1, 1);
            pnlHomeButtons.Name = "pnlHomeButtons";
            pnlHomeButtons.Radius = 0;
            pnlHomeButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlHomeButtons.RectDisableColor = Color.Transparent;
            pnlHomeButtons.Size = new Size(696, 45);
            pnlHomeButtons.TabIndex = 24;
            pnlHomeButtons.Text = null;
            pnlHomeButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkHomeManualConfirm
            // 
            chkHomeManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkHomeManualConfirm.BackColor = Color.Transparent;
            chkHomeManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkHomeManualConfirm.Checked = true;
            chkHomeManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkHomeManualConfirm.ForeColor = Color.White;
            chkHomeManualConfirm.Location = new Point(46, 10);
            chkHomeManualConfirm.MinimumSize = new Size(1, 1);
            chkHomeManualConfirm.Name = "chkHomeManualConfirm";
            chkHomeManualConfirm.Size = new Size(333, 25);
            chkHomeManualConfirm.TabIndex = 27;
            chkHomeManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSaveHome
            // 
            btnSaveHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveHome.FillColor = Color.BlueViolet;
            btnSaveHome.FillColor2 = Color.Transparent;
            btnSaveHome.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSaveHome.FillHoverColor = Color.DarkOrchid;
            btnSaveHome.FillPressColor = Color.DarkViolet;
            btnSaveHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveHome.Location = new Point(389, 5);
            btnSaveHome.MinimumSize = new Size(1, 1);
            btnSaveHome.Name = "btnSaveHome";
            btnSaveHome.Radius = 8;
            btnSaveHome.RectColor = Color.Transparent;
            btnSaveHome.Size = new Size(150, 35);
            btnSaveHome.Style = Sunny.UI.UIStyle.Custom;
            btnSaveHome.TabIndex = 13;
            btnSaveHome.Text = "Сохранить настройки";
            btnSaveHome.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnStartHome
            // 
            btnStartHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartHome.FillColor = Color.Indigo;
            btnStartHome.FillColor2 = Color.Transparent;
            btnStartHome.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnStartHome.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnStartHome.FillPressColor = Color.FromArgb(109, 40, 217);
            btnStartHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartHome.Location = new Point(543, 5);
            btnStartHome.MinimumSize = new Size(1, 1);
            btnStartHome.Name = "btnStartHome";
            btnStartHome.Radius = 8;
            btnStartHome.RectColor = Color.Transparent;
            btnStartHome.Size = new Size(150, 35);
            btnStartHome.Style = Sunny.UI.UIStyle.Custom;
            btnStartHome.TabIndex = 14;
            btnStartHome.Text = "Начать сеанс";
            btnStartHome.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlHomeInner
            // 
            pnlHomeInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlHomeInner.AutoScroll = true;
            pnlHomeInner.Controls.Add(pnlHomeContent);
            pnlHomeInner.Location = new Point(3, 25);
            pnlHomeInner.Name = "pnlHomeInner";
            pnlHomeInner.Size = new Size(693, 413);
            pnlHomeInner.TabIndex = 25;
            // 
            // pnlHomeContent
            // 
            pnlHomeContent.BackColor = Color.Transparent;
            pnlHomeContent.Controls.Add(grpHomeHistory);
            pnlHomeContent.Controls.Add(grpModeDescription);
            pnlHomeContent.Controls.Add(grpQuickActions);
            pnlHomeContent.Controls.Add(cmbNotificationChat);
            pnlHomeContent.Controls.Add(lblNotificationChat);
            pnlHomeContent.Controls.Add(chkQuietMode);
            pnlHomeContent.Controls.Add(chkNotifyComplete);
            pnlHomeContent.Controls.Add(chkNotifyErrors);
            pnlHomeContent.Controls.Add(nudDailyLimit);
            pnlHomeContent.Controls.Add(lblDailyLimit);
            pnlHomeContent.Controls.Add(cmbTimezone);
            pnlHomeContent.Controls.Add(lblTimezone);
            pnlHomeContent.Controls.Add(lblGeneralSettings);
            pnlHomeContent.Controls.Add(grpQuickStats);
            pnlHomeContent.Controls.Add(btnConfigureMode);
            pnlHomeContent.Controls.Add(radModeManual);
            pnlHomeContent.Controls.Add(radModePriority);
            pnlHomeContent.Controls.Add(radModeEvent);
            pnlHomeContent.Controls.Add(radModeSchedule);
            pnlHomeContent.Controls.Add(radModePeriodic);
            pnlHomeContent.Controls.Add(radModeDelayed);
            pnlHomeContent.Controls.Add(radModeAuto);
            pnlHomeContent.Controls.Add(cmbActiveMode);
            pnlHomeContent.Controls.Add(lblActiveMode);
            pnlHomeContent.Controls.Add(grpGroupInfo);
            pnlHomeContent.Location = new Point(1, 0);
            pnlHomeContent.MinimumSize = new Size(673, 0);
            pnlHomeContent.Name = "pnlHomeContent";
            pnlHomeContent.Padding = new Padding(9, 0, 9, 0);
            pnlHomeContent.Size = new Size(675, 1530);
            pnlHomeContent.TabIndex = 0;
            // 
            // grpHomeHistory
            // 
            grpHomeHistory.Controls.Add(flpHomeHistory);
            grpHomeHistory.FillColor = Color.Transparent;
            grpHomeHistory.FillColor2 = Color.Transparent;
            grpHomeHistory.FillDisableColor = Color.Transparent;
            grpHomeHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpHomeHistory.ForeColor = SystemColors.ActiveBorder;
            grpHomeHistory.ForeDisableColor = Color.Transparent;
            grpHomeHistory.Location = new Point(9, 893);
            grpHomeHistory.Margin = new Padding(4, 5, 4, 5);
            grpHomeHistory.MinimumSize = new Size(1, 1);
            grpHomeHistory.Name = "grpHomeHistory";
            grpHomeHistory.Padding = new Padding(5, 32, 5, 5);
            grpHomeHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpHomeHistory.RectDisableColor = Color.Transparent;
            grpHomeHistory.Size = new Size(658, 290);
            grpHomeHistory.TabIndex = 33;
            grpHomeHistory.Text = "📋 История и логи";
            grpHomeHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpHomeHistory.TitleTop = 10;
            // 
            // flpHomeHistory
            // 
            flpHomeHistory.AutoScroll = true;
            flpHomeHistory.FlowDirection = FlowDirection.TopDown;
            flpHomeHistory.Location = new Point(10, 20);
            flpHomeHistory.Name = "flpHomeHistory";
            flpHomeHistory.Size = new Size(636, 259);
            flpHomeHistory.TabIndex = 10;
            flpHomeHistory.WrapContents = false;
            // 
            // grpModeDescription
            // 
            grpModeDescription.Controls.Add(lblModeDescription);
            grpModeDescription.FillColor = Color.Transparent;
            grpModeDescription.FillColor2 = Color.Transparent;
            grpModeDescription.FillDisableColor = Color.Transparent;
            grpModeDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpModeDescription.ForeColor = Color.White;
            grpModeDescription.ForeDisableColor = Color.Transparent;
            grpModeDescription.Location = new Point(9, 690);
            grpModeDescription.Margin = new Padding(4, 5, 4, 5);
            grpModeDescription.MinimumSize = new Size(1, 1);
            grpModeDescription.Name = "grpModeDescription";
            grpModeDescription.Padding = new Padding(5, 32, 5, 5);
            grpModeDescription.RectColor = Color.FromArgb(58, 58, 69);
            grpModeDescription.RectDisableColor = Color.Transparent;
            grpModeDescription.Size = new Size(658, 90);
            grpModeDescription.TabIndex = 32;
            grpModeDescription.Text = "ℹ️ Описание режима";
            grpModeDescription.TextAlignment = ContentAlignment.MiddleLeft;
            grpModeDescription.TitleTop = 10;
            // 
            // lblModeDescription
            // 
            lblModeDescription.AutoSize = true;
            lblModeDescription.BackColor = Color.Transparent;
            lblModeDescription.Font = new Font("Segoe UI", 9F);
            lblModeDescription.ForeColor = Color.FromArgb(180, 180, 180);
            lblModeDescription.Location = new Point(5, 32);
            lblModeDescription.Name = "lblModeDescription";
            lblModeDescription.Size = new Size(425, 60);
            lblModeDescription.TabIndex = 0;
            lblModeDescription.Text = resources.GetString("lblModeDescription.Text");
            // 
            // grpQuickActions
            // 
            grpQuickActions.Controls.Add(pnlQuickActions);
            grpQuickActions.FillColor = Color.Transparent;
            grpQuickActions.FillColor2 = Color.Transparent;
            grpQuickActions.FillDisableColor = Color.Transparent;
            grpQuickActions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpQuickActions.ForeColor = Color.White;
            grpQuickActions.ForeDisableColor = Color.Transparent;
            grpQuickActions.Location = new Point(9, 570);
            grpQuickActions.Margin = new Padding(4, 5, 4, 5);
            grpQuickActions.MinimumSize = new Size(1, 1);
            grpQuickActions.Name = "grpQuickActions";
            grpQuickActions.Padding = new Padding(5, 32, 5, 5);
            grpQuickActions.RectColor = Color.FromArgb(58, 58, 69);
            grpQuickActions.RectDisableColor = Color.Transparent;
            grpQuickActions.Size = new Size(658, 110);
            grpQuickActions.TabIndex = 31;
            grpQuickActions.Text = "🛠 Быстрые инструменты";
            grpQuickActions.TextAlignment = ContentAlignment.MiddleLeft;
            grpQuickActions.TitleTop = 10;
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.AutoScroll = true;
            pnlQuickActions.Dock = DockStyle.Fill;
            pnlQuickActions.Location = new Point(5, 32);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new Size(648, 73);
            pnlQuickActions.TabIndex = 0;
            // 
            // cmbNotificationChat
            // 
            cmbNotificationChat.DataSource = null;
            cmbNotificationChat.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotificationChat.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotificationChat.Font = new Font("Segoe UI", 9F);
            cmbNotificationChat.ForeColor = Color.White;
            cmbNotificationChat.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotificationChat.ItemForeColor = Color.White;
            cmbNotificationChat.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotificationChat.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotificationChat.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotificationChat.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotificationChat.ItemSelectForeColor = Color.White;
            cmbNotificationChat.Location = new Point(350, 440);
            cmbNotificationChat.Margin = new Padding(4, 5, 4, 5);
            cmbNotificationChat.MinimumSize = new Size(63, 0);
            cmbNotificationChat.Name = "cmbNotificationChat";
            cmbNotificationChat.Padding = new Padding(0, 0, 30, 2);
            cmbNotificationChat.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotificationChat.Size = new Size(300, 25);
            cmbNotificationChat.Style = Sunny.UI.UIStyle.Custom;
            cmbNotificationChat.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotificationChat.SymbolSize = 24;
            cmbNotificationChat.TabIndex = 30;
            cmbNotificationChat.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotificationChat.Watermark = "Выберите чат";
            // 
            // lblNotificationChat
            // 
            lblNotificationChat.AutoSize = true;
            lblNotificationChat.BackColor = Color.Transparent;
            lblNotificationChat.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotificationChat.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotificationChat.Location = new Point(350, 420);
            lblNotificationChat.Name = "lblNotificationChat";
            lblNotificationChat.Size = new Size(172, 13);
            lblNotificationChat.TabIndex = 29;
            lblNotificationChat.Text = "Куда отправлять уведомления:";
            // 
            // chkQuietMode
            // 
            chkQuietMode.BackColor = Color.Transparent;
            chkQuietMode.CheckBoxColor = Color.BlueViolet;
            chkQuietMode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkQuietMode.ForeColor = Color.White;
            chkQuietMode.Location = new Point(9, 540);
            chkQuietMode.MinimumSize = new Size(1, 1);
            chkQuietMode.Name = "chkQuietMode";
            chkQuietMode.Size = new Size(300, 25);
            chkQuietMode.TabIndex = 28;
            chkQuietMode.Text = "Тихий режим (без уведомлений бота)";
            // 
            // chkNotifyComplete
            // 
            chkNotifyComplete.BackColor = Color.Transparent;
            chkNotifyComplete.CheckBoxColor = Color.BlueViolet;
            chkNotifyComplete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyComplete.ForeColor = Color.White;
            chkNotifyComplete.Location = new Point(9, 510);
            chkNotifyComplete.MinimumSize = new Size(1, 1);
            chkNotifyComplete.Name = "chkNotifyComplete";
            chkNotifyComplete.Size = new Size(300, 25);
            chkNotifyComplete.TabIndex = 27;
            chkNotifyComplete.Text = "Уведомлять о завершении сессии";
            // 
            // chkNotifyErrors
            // 
            chkNotifyErrors.BackColor = Color.Transparent;
            chkNotifyErrors.CheckBoxColor = Color.BlueViolet;
            chkNotifyErrors.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyErrors.ForeColor = Color.White;
            chkNotifyErrors.Location = new Point(9, 480);
            chkNotifyErrors.MinimumSize = new Size(1, 1);
            chkNotifyErrors.Name = "chkNotifyErrors";
            chkNotifyErrors.Size = new Size(250, 25);
            chkNotifyErrors.TabIndex = 26;
            chkNotifyErrors.Text = "Уведомлять об ошибках";
            // 
            // nudDailyLimit
            // 
            nudDailyLimit.FillColor = Color.FromArgb(42, 46, 57);
            nudDailyLimit.Font = new Font("Segoe UI", 9.75F);
            nudDailyLimit.ForeColor = Color.White;
            nudDailyLimit.Location = new Point(100, 445);
            nudDailyLimit.Margin = new Padding(4, 5, 4, 5);
            nudDailyLimit.Maximum = 100000D;
            nudDailyLimit.Minimum = 0D;
            nudDailyLimit.MinimumSize = new Size(1, 16);
            nudDailyLimit.Name = "nudDailyLimit";
            nudDailyLimit.Padding = new Padding(5);
            nudDailyLimit.RectColor = Color.FromArgb(65, 71, 84);
            nudDailyLimit.RectHoverColor = Color.BlueViolet;
            nudDailyLimit.RectPressColor = Color.Indigo;
            nudDailyLimit.ShowText = false;
            nudDailyLimit.Size = new Size(100, 25);
            nudDailyLimit.TabIndex = 25;
            nudDailyLimit.Text = "1000";
            nudDailyLimit.TextAlignment = ContentAlignment.MiddleCenter;
            nudDailyLimit.Value = 1000;
            // 
            // lblDailyLimit
            // 
            lblDailyLimit.AutoSize = true;
            lblDailyLimit.BackColor = Color.Transparent;
            lblDailyLimit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDailyLimit.ForeColor = Color.FromArgb(180, 180, 180);
            lblDailyLimit.Location = new Point(9, 450);
            lblDailyLimit.Name = "lblDailyLimit";
            lblDailyLimit.Size = new Size(82, 13);
            lblDailyLimit.TabIndex = 24;
            lblDailyLimit.Text = "Лимит в день:";
            // 
            // cmbTimezone
            // 
            cmbTimezone.DataSource = null;
            cmbTimezone.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbTimezone.FillColor = Color.FromArgb(42, 46, 57);
            cmbTimezone.Font = new Font("Segoe UI", 9F);
            cmbTimezone.ForeColor = Color.White;
            cmbTimezone.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbTimezone.ItemForeColor = Color.White;
            cmbTimezone.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbTimezone.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbTimezone.Items.AddRange(new object[] { "GMT-12 (Бейкер, Хауленд)", "GMT-11 (Нукуалофа, Паго-Паго)", "GMT-10 (Гонолулу)", "GMT-9 (Анкоридж)", "GMT-8 (Лос-Анджелес)", "GMT-7 (Денвер)", "GMT-6 (Чикаго)", "GMT-5 (Нью-Йорк)", "GMT-4 (Сантьяго)", "GMT-3 (Буэнос-Айрес)", "GMT-2 (Южная Георгия)", "GMT-1 (Азорские острова)", "GMT+0 (Лондон)", "GMT+1 (Париж, Берлин)", "GMT+2 (Каир, Афины)", "GMT+3 (Москва)", "GMT+4 (Дубай)", "GMT+5 (Карачи)", "GMT+6 (Алматы)", "GMT+7 (Бангкок)", "GMT+8 (Пекин, Сингапур)", "GMT+9 (Токио, Сеул)", "GMT+10 (Сидней)", "GMT+11 (Нумеа)", "GMT+12 (Окленд)", "GMT+13 (Нукуалофа)", "GMT+14 (Киритимати)" });
            cmbTimezone.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbTimezone.ItemSelectForeColor = Color.White;
            cmbTimezone.Location = new Point(100, 415);
            cmbTimezone.Margin = new Padding(4, 5, 4, 5);
            cmbTimezone.MinimumSize = new Size(63, 0);
            cmbTimezone.Name = "cmbTimezone";
            cmbTimezone.Padding = new Padding(0, 0, 30, 2);
            cmbTimezone.RectColor = Color.FromArgb(65, 71, 84);
            cmbTimezone.Size = new Size(300, 25);
            cmbTimezone.Style = Sunny.UI.UIStyle.Custom;
            cmbTimezone.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbTimezone.SymbolSize = 24;
            cmbTimezone.TabIndex = 23;
            cmbTimezone.TextAlignment = ContentAlignment.MiddleLeft;
            cmbTimezone.Watermark = "Выберите пояс";
            // 
            // lblTimezone
            // 
            lblTimezone.AutoSize = true;
            lblTimezone.BackColor = Color.Transparent;
            lblTimezone.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblTimezone.ForeColor = Color.FromArgb(180, 180, 180);
            lblTimezone.Location = new Point(9, 420);
            lblTimezone.Name = "lblTimezone";
            lblTimezone.Size = new Size(84, 13);
            lblTimezone.TabIndex = 22;
            lblTimezone.Text = "Часовой пояс:";
            // 
            // lblGeneralSettings
            // 
            lblGeneralSettings.AutoSize = true;
            lblGeneralSettings.BackColor = Color.Transparent;
            lblGeneralSettings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblGeneralSettings.ForeColor = Color.White;
            lblGeneralSettings.Location = new Point(9, 390);
            lblGeneralSettings.Name = "lblGeneralSettings";
            lblGeneralSettings.Size = new Size(150, 19);
            lblGeneralSettings.TabIndex = 21;
            lblGeneralSettings.Text = "⚙️ Общие настройки";
            // 
            // grpQuickStats
            // 
            grpQuickStats.Controls.Add(pnlQuickStats);
            grpQuickStats.FillColor = Color.Transparent;
            grpQuickStats.FillColor2 = Color.Transparent;
            grpQuickStats.FillDisableColor = Color.Transparent;
            grpQuickStats.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpQuickStats.ForeColor = Color.White;
            grpQuickStats.ForeDisableColor = Color.Transparent;
            grpQuickStats.Location = new Point(9, 310);
            grpQuickStats.Margin = new Padding(4, 5, 4, 5);
            grpQuickStats.MinimumSize = new Size(1, 1);
            grpQuickStats.Name = "grpQuickStats";
            grpQuickStats.Padding = new Padding(5, 32, 5, 5);
            grpQuickStats.RectColor = Color.FromArgb(58, 58, 69);
            grpQuickStats.RectDisableColor = Color.Transparent;
            grpQuickStats.Size = new Size(658, 70);
            grpQuickStats.TabIndex = 20;
            grpQuickStats.Text = "📊 Статистика за сегодня";
            grpQuickStats.TextAlignment = ContentAlignment.MiddleLeft;
            grpQuickStats.TitleTop = 10;
            // 
            // pnlQuickStats
            // 
            pnlQuickStats.AutoScroll = true;
            pnlQuickStats.Dock = DockStyle.Fill;
            pnlQuickStats.Location = new Point(5, 32);
            pnlQuickStats.Name = "pnlQuickStats";
            pnlQuickStats.Size = new Size(648, 33);
            pnlQuickStats.TabIndex = 0;
            pnlQuickStats.WrapContents = false;
            // 
            // btnConfigureMode
            // 
            btnConfigureMode.FillColor = Color.BlueViolet;
            btnConfigureMode.FillColor2 = Color.Transparent;
            btnConfigureMode.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnConfigureMode.FillHoverColor = Color.DarkOrchid;
            btnConfigureMode.FillPressColor = Color.DarkViolet;
            btnConfigureMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfigureMode.Location = new Point(420, 184);
            btnConfigureMode.MinimumSize = new Size(1, 1);
            btnConfigureMode.Name = "btnConfigureMode";
            btnConfigureMode.Radius = 8;
            btnConfigureMode.RectColor = Color.Transparent;
            btnConfigureMode.Size = new Size(230, 25);
            btnConfigureMode.Style = Sunny.UI.UIStyle.Custom;
            btnConfigureMode.TabIndex = 19;
            btnConfigureMode.Text = "⚙️ Настроить выбранный режим →";
            btnConfigureMode.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // radModeManual
            // 
            radModeManual.AutoSize = true;
            radModeManual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModeManual.ForeColor = Color.White;
            radModeManual.Location = new Point(15, 275);
            radModeManual.MinimumSize = new Size(1, 1);
            radModeManual.Name = "radModeManual";
            radModeManual.RadioButtonColor = Color.BlueViolet;
            radModeManual.RadioButtonSize = 14;
            radModeManual.Size = new Size(69, 20);
            radModeManual.Style = Sunny.UI.UIStyle.Custom;
            radModeManual.TabIndex = 18;
            radModeManual.Text = "Ручной";
            // 
            // radModePriority
            // 
            radModePriority.AutoSize = true;
            radModePriority.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModePriority.ForeColor = Color.White;
            radModePriority.Location = new Point(330, 245);
            radModePriority.MinimumSize = new Size(1, 1);
            radModePriority.Name = "radModePriority";
            radModePriority.RadioButtonColor = Color.BlueViolet;
            radModePriority.RadioButtonSize = 14;
            radModePriority.Size = new Size(111, 20);
            radModePriority.Style = Sunny.UI.UIStyle.Custom;
            radModePriority.TabIndex = 17;
            radModePriority.Text = "Приоритетный";
            // 
            // radModeEvent
            // 
            radModeEvent.AutoSize = true;
            radModeEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModeEvent.ForeColor = Color.White;
            radModeEvent.Location = new Point(170, 245);
            radModeEvent.MinimumSize = new Size(1, 1);
            radModeEvent.Name = "radModeEvent";
            radModeEvent.RadioButtonColor = Color.BlueViolet;
            radModeEvent.RadioButtonSize = 14;
            radModeEvent.Size = new Size(98, 20);
            radModeEvent.Style = Sunny.UI.UIStyle.Custom;
            radModeEvent.TabIndex = 16;
            radModeEvent.Text = "По событию";
            // 
            // radModeSchedule
            // 
            radModeSchedule.AutoSize = true;
            radModeSchedule.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModeSchedule.ForeColor = Color.White;
            radModeSchedule.Location = new Point(15, 245);
            radModeSchedule.MinimumSize = new Size(1, 1);
            radModeSchedule.Name = "radModeSchedule";
            radModeSchedule.RadioButtonColor = Color.BlueViolet;
            radModeSchedule.RadioButtonSize = 14;
            radModeSchedule.Size = new Size(116, 20);
            radModeSchedule.Style = Sunny.UI.UIStyle.Custom;
            radModeSchedule.TabIndex = 15;
            radModeSchedule.Text = "По расписанию";
            // 
            // radModePeriodic
            // 
            radModePeriodic.AutoSize = true;
            radModePeriodic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModePeriodic.ForeColor = Color.White;
            radModePeriodic.Location = new Point(330, 215);
            radModePeriodic.MinimumSize = new Size(1, 1);
            radModePeriodic.Name = "radModePeriodic";
            radModePeriodic.RadioButtonColor = Color.BlueViolet;
            radModePeriodic.RadioButtonSize = 14;
            radModePeriodic.Size = new Size(117, 20);
            radModePeriodic.Style = Sunny.UI.UIStyle.Custom;
            radModePeriodic.TabIndex = 14;
            radModePeriodic.Text = "Периодический";
            // 
            // radModeDelayed
            // 
            radModeDelayed.AutoSize = true;
            radModeDelayed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModeDelayed.ForeColor = Color.White;
            radModeDelayed.Location = new Point(170, 215);
            radModeDelayed.MinimumSize = new Size(1, 1);
            radModeDelayed.Name = "radModeDelayed";
            radModeDelayed.RadioButtonColor = Color.BlueViolet;
            radModeDelayed.RadioButtonSize = 14;
            radModeDelayed.Size = new Size(102, 20);
            radModeDelayed.Style = Sunny.UI.UIStyle.Custom;
            radModeDelayed.TabIndex = 13;
            radModeDelayed.Text = "Отложенный";
            // 
            // radModeAuto
            // 
            radModeAuto.AutoSize = true;
            radModeAuto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radModeAuto.ForeColor = Color.White;
            radModeAuto.Location = new Point(15, 215);
            radModeAuto.MinimumSize = new Size(1, 1);
            radModeAuto.Name = "radModeAuto";
            radModeAuto.RadioButtonColor = Color.BlueViolet;
            radModeAuto.RadioButtonSize = 14;
            radModeAuto.Size = new Size(121, 20);
            radModeAuto.Style = Sunny.UI.UIStyle.Custom;
            radModeAuto.TabIndex = 12;
            radModeAuto.Text = "Автоматический";
            // 
            // cmbActiveMode
            // 
            cmbActiveMode.DataSource = null;
            cmbActiveMode.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbActiveMode.FillColor = Color.FromArgb(42, 46, 57);
            cmbActiveMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbActiveMode.ForeColor = Color.White;
            cmbActiveMode.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbActiveMode.Items.AddRange(new object[] { "Автоматический (каждые N минут)", "Отложенный (один раз через N)", "Периодический (регулярно)", "По расписанию (в конкретное время)", "По событию (при триггере)", "Приоритетный (очередь)", "Ручной (по кнопке)", "Не использовать (только ручной)" });
            cmbActiveMode.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbActiveMode.Location = new Point(9, 184);
            cmbActiveMode.Margin = new Padding(4, 5, 4, 5);
            cmbActiveMode.MinimumSize = new Size(63, 0);
            cmbActiveMode.Name = "cmbActiveMode";
            cmbActiveMode.Padding = new Padding(0, 0, 30, 2);
            cmbActiveMode.RectColor = Color.FromArgb(65, 71, 84);
            cmbActiveMode.Size = new Size(400, 25);
            cmbActiveMode.Style = Sunny.UI.UIStyle.Custom;
            cmbActiveMode.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbActiveMode.SymbolSize = 24;
            cmbActiveMode.TabIndex = 11;
            cmbActiveMode.TextAlignment = ContentAlignment.MiddleLeft;
            cmbActiveMode.Watermark = "Выберите режим";
            // 
            // lblActiveMode
            // 
            lblActiveMode.AutoSize = true;
            lblActiveMode.BackColor = Color.Transparent;
            lblActiveMode.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblActiveMode.ForeColor = Color.White;
            lblActiveMode.Location = new Point(9, 159);
            lblActiveMode.Name = "lblActiveMode";
            lblActiveMode.Size = new Size(213, 19);
            lblActiveMode.TabIndex = 10;
            lblActiveMode.Text = "🎯 Активный режим отправки:";
            // 
            // grpGroupInfo
            // 
            grpGroupInfo.Controls.Add(pnlGroupInfo);
            grpGroupInfo.FillColor = Color.Transparent;
            grpGroupInfo.FillColor2 = Color.Transparent;
            grpGroupInfo.FillDisableColor = Color.Transparent;
            grpGroupInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpGroupInfo.ForeColor = Color.White;
            grpGroupInfo.ForeDisableColor = Color.Transparent;
            grpGroupInfo.Location = new Point(9, 9);
            grpGroupInfo.Margin = new Padding(4, 5, 4, 5);
            grpGroupInfo.MinimumSize = new Size(1, 1);
            grpGroupInfo.Name = "grpGroupInfo";
            grpGroupInfo.Padding = new Padding(5, 32, 5, 5);
            grpGroupInfo.RectColor = Color.FromArgb(58, 58, 69);
            grpGroupInfo.RectDisableColor = Color.Transparent;
            grpGroupInfo.Size = new Size(658, 140);
            grpGroupInfo.TabIndex = 0;
            grpGroupInfo.Text = "Информация о группе";
            grpGroupInfo.TextAlignment = ContentAlignment.MiddleLeft;
            grpGroupInfo.TitleTop = 10;
            // 
            // pnlGroupInfo
            // 
            pnlGroupInfo.BackColor = Color.FromArgb(35, 39, 48);
            pnlGroupInfo.Controls.Add(lblGroupId);
            pnlGroupInfo.Controls.Add(lblGroupMembers);
            pnlGroupInfo.Controls.Add(lblGroupType);
            pnlGroupInfo.Controls.Add(lblGroupUsername);
            pnlGroupInfo.Controls.Add(lblGroupTitle);
            pnlGroupInfo.Controls.Add(picGroupStatus);
            pnlGroupInfo.Controls.Add(lblGroupStatus);
            pnlGroupInfo.Dock = DockStyle.Fill;
            pnlGroupInfo.Location = new Point(5, 32);
            pnlGroupInfo.Name = "pnlGroupInfo";
            pnlGroupInfo.Size = new Size(648, 103);
            pnlGroupInfo.TabIndex = 0;
            // 
            // lblGroupId
            // 
            lblGroupId.AutoSize = true;
            lblGroupId.BackColor = Color.Transparent;
            lblGroupId.Font = new Font("Segoe UI", 8.25F);
            lblGroupId.ForeColor = Color.FromArgb(180, 180, 180);
            lblGroupId.Location = new Point(350, 48);
            lblGroupId.Name = "lblGroupId";
            lblGroupId.Size = new Size(88, 13);
            lblGroupId.TabIndex = 6;
            lblGroupId.Text = "ID: -1001234567";
            // 
            // lblGroupMembers
            // 
            lblGroupMembers.AutoSize = true;
            lblGroupMembers.BackColor = Color.Transparent;
            lblGroupMembers.Font = new Font("Segoe UI", 8.25F);
            lblGroupMembers.ForeColor = Color.FromArgb(180, 180, 180);
            lblGroupMembers.Location = new Point(350, 25);
            lblGroupMembers.Name = "lblGroupMembers";
            lblGroupMembers.Size = new Size(102, 13);
            lblGroupMembers.TabIndex = 5;
            lblGroupMembers.Text = "Участников: 1,234";
            // 
            // lblGroupType
            // 
            lblGroupType.AutoSize = true;
            lblGroupType.BackColor = Color.Transparent;
            lblGroupType.Font = new Font("Segoe UI", 8.25F);
            lblGroupType.ForeColor = Color.FromArgb(180, 180, 180);
            lblGroupType.Location = new Point(350, 5);
            lblGroupType.Name = "lblGroupType";
            lblGroupType.Size = new Size(63, 13);
            lblGroupType.TabIndex = 4;
            lblGroupType.Text = "Тип: Канал";
            // 
            // lblGroupUsername
            // 
            lblGroupUsername.AutoSize = true;
            lblGroupUsername.BackColor = Color.Transparent;
            lblGroupUsername.Font = new Font("Segoe UI", 9F);
            lblGroupUsername.ForeColor = Color.FromArgb(156, 163, 175);
            lblGroupUsername.Location = new Point(50, 48);
            lblGroupUsername.Name = "lblGroupUsername";
            lblGroupUsername.Size = new Size(70, 15);
            lblGroupUsername.TabIndex = 3;
            lblGroupUsername.Text = "@nickname";
            // 
            // lblGroupTitle
            // 
            lblGroupTitle.AutoSize = true;
            lblGroupTitle.BackColor = Color.Transparent;
            lblGroupTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGroupTitle.ForeColor = Color.White;
            lblGroupTitle.Location = new Point(50, 25);
            lblGroupTitle.Name = "lblGroupTitle";
            lblGroupTitle.Size = new Size(132, 20);
            lblGroupTitle.TabIndex = 2;
            lblGroupTitle.Text = "Название канала";
            // 
            // picGroupStatus
            // 
            picGroupStatus.BackColor = Color.Lime;
            picGroupStatus.Location = new Point(10, 5);
            picGroupStatus.Name = "picGroupStatus";
            picGroupStatus.Size = new Size(30, 30);
            picGroupStatus.TabIndex = 1;
            picGroupStatus.TabStop = false;
            // 
            // lblGroupStatus
            // 
            lblGroupStatus.AutoSize = true;
            lblGroupStatus.BackColor = Color.Transparent;
            lblGroupStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblGroupStatus.ForeColor = Color.Lime;
            lblGroupStatus.Location = new Point(50, 5);
            lblGroupStatus.Name = "lblGroupStatus";
            lblGroupStatus.Size = new Size(53, 15);
            lblGroupStatus.TabIndex = 0;
            lblGroupStatus.Text = "Активна";
            // 
            // lblStatTotalSent
            // 
            lblStatTotalSent.AutoSize = true;
            lblStatTotalSent.BackColor = Color.Transparent;
            lblStatTotalSent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatTotalSent.ForeColor = Color.White;
            lblStatTotalSent.Location = new Point(3, 0);
            lblStatTotalSent.Margin = new Padding(3, 0, 20, 0);
            lblStatTotalSent.Name = "lblStatTotalSent";
            lblStatTotalSent.Size = new Size(120, 15);
            lblStatTotalSent.TabIndex = 0;
            lblStatTotalSent.Text = "Отправлено: 47";
            // 
            // lblStatSuccess
            // 
            lblStatSuccess.AutoSize = true;
            lblStatSuccess.BackColor = Color.Transparent;
            lblStatSuccess.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatSuccess.ForeColor = Color.Lime;
            lblStatSuccess.Location = new Point(126, 0);
            lblStatSuccess.Margin = new Padding(3, 0, 20, 0);
            lblStatSuccess.Name = "lblStatSuccess";
            lblStatSuccess.Size = new Size(80, 15);
            lblStatSuccess.TabIndex = 1;
            lblStatSuccess.Text = "Успех: 94%";
            // 
            // lblStatErrors
            // 
            lblStatErrors.AutoSize = true;
            lblStatErrors.BackColor = Color.Transparent;
            lblStatErrors.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatErrors.ForeColor = Color.Red;
            lblStatErrors.Location = new Point(209, 0);
            lblStatErrors.Margin = new Padding(3, 0, 20, 0);
            lblStatErrors.Name = "lblStatErrors";
            lblStatErrors.Size = new Size(70, 15);
            lblStatErrors.TabIndex = 2;
            lblStatErrors.Text = "Ошибки: 2";
            // 
            // lblStatQueue
            // 
            lblStatQueue.AutoSize = true;
            lblStatQueue.BackColor = Color.Transparent;
            lblStatQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatQueue.ForeColor = Color.Orange;
            lblStatQueue.Location = new Point(282, 0);
            lblStatQueue.Margin = new Padding(3, 0, 20, 0);
            lblStatQueue.Name = "lblStatQueue";
            lblStatQueue.Size = new Size(70, 15);
            lblStatQueue.TabIndex = 3;
            lblStatQueue.Text = "В очереди: 1";
            // 
            // lblStatUptime
            // 
            lblStatUptime.AutoSize = true;
            lblStatUptime.BackColor = Color.Transparent;
            lblStatUptime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatUptime.ForeColor = Color.CornflowerBlue;
            lblStatUptime.Location = new Point(355, 0);
            lblStatUptime.Margin = new Padding(3, 0, 20, 0);
            lblStatUptime.Name = "lblStatUptime";
            lblStatUptime.Size = new Size(120, 15);
            lblStatUptime.TabIndex = 4;
            lblStatUptime.Text = "Работает: 2ч 15мин";
            // 
            // btnTestSend
            // 
            btnTestSend.FillColor = Color.FromArgb(124, 58, 237);
            btnTestSend.FillColor2 = Color.Transparent;
            btnTestSend.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnTestSend.FillHoverColor = Color.DarkOrchid;
            btnTestSend.FillPressColor = Color.DarkViolet;
            btnTestSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTestSend.Location = new Point(3, 3);
            btnTestSend.MinimumSize = new Size(1, 1);
            btnTestSend.Name = "btnTestSend";
            btnTestSend.Radius = 8;
            btnTestSend.RectColor = Color.Transparent;
            btnTestSend.Size = new Size(150, 30);
            btnTestSend.Style = Sunny.UI.UIStyle.Custom;
            btnTestSend.TabIndex = 0;
            btnTestSend.Text = " Тестовая отправка";
            btnTestSend.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnPause
            // 
            btnPause.FillColor = Color.Orange;
            btnPause.FillColor2 = Color.Transparent;
            btnPause.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnPause.FillHoverColor = Color.DarkOrange;
            btnPause.FillPressColor = Color.OrangeRed;
            btnPause.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPause.Location = new Point(159, 3);
            btnPause.MinimumSize = new Size(1, 1);
            btnPause.Name = "btnPause";
            btnPause.Radius = 8;
            btnPause.RectColor = Color.Transparent;
            btnPause.Size = new Size(100, 30);
            btnPause.Style = Sunny.UI.UIStyle.Custom;
            btnPause.TabIndex = 1;
            btnPause.Text = "⏸ Пауза";
            btnPause.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnResume
            // 
            btnResume.FillColor = Color.Lime;
            btnResume.FillColor2 = Color.Transparent;
            btnResume.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnResume.FillHoverColor = Color.DarkGreen;
            btnResume.FillPressColor = Color.Green;
            btnResume.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResume.Location = new Point(265, 3);
            btnResume.MinimumSize = new Size(1, 1);
            btnResume.Name = "btnResume";
            btnResume.Radius = 8;
            btnResume.RectColor = Color.Transparent;
            btnResume.Size = new Size(100, 30);
            btnResume.Style = Sunny.UI.UIStyle.Custom;
            btnResume.TabIndex = 2;
            btnResume.Text = "▶ Старт";
            btnResume.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnClearQueue
            // 
            btnClearQueue.FillColor = Color.Red;
            btnClearQueue.FillColor2 = Color.Transparent;
            btnClearQueue.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnClearQueue.FillHoverColor = Color.DarkRed;
            btnClearQueue.FillPressColor = Color.IndianRed;
            btnClearQueue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearQueue.Location = new Point(371, 3);
            btnClearQueue.MinimumSize = new Size(1, 1);
            btnClearQueue.Name = "btnClearQueue";
            btnClearQueue.Radius = 8;
            btnClearQueue.RectColor = Color.Transparent;
            btnClearQueue.Size = new Size(120, 30);
            btnClearQueue.Style = Sunny.UI.UIStyle.Custom;
            btnClearQueue.TabIndex = 3;
            btnClearQueue.Text = " Очистить очередь";
            btnClearQueue.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnExportSettings
            // 
            btnExportSettings.FillColor = Color.FromArgb(42, 46, 57);
            btnExportSettings.FillColor2 = Color.Transparent;
            btnExportSettings.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnExportSettings.FillHoverColor = Color.DarkSlateGray;
            btnExportSettings.FillPressColor = Color.SlateGray;
            btnExportSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportSettings.Location = new Point(3, 39);
            btnExportSettings.MinimumSize = new Size(1, 1);
            btnExportSettings.Name = "btnExportSettings";
            btnExportSettings.Radius = 8;
            btnExportSettings.RectColor = Color.Transparent;
            btnExportSettings.Size = new Size(130, 30);
            btnExportSettings.Style = Sunny.UI.UIStyle.Custom;
            btnExportSettings.TabIndex = 4;
            btnExportSettings.Text = "💾 Экспорт";
            btnExportSettings.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnImportSettings
            // 
            btnImportSettings.FillColor = Color.FromArgb(42, 46, 57);
            btnImportSettings.FillColor2 = Color.Transparent;
            btnImportSettings.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnImportSettings.FillHoverColor = Color.DarkSlateGray;
            btnImportSettings.FillPressColor = Color.SlateGray;
            btnImportSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnImportSettings.Location = new Point(139, 39);
            btnImportSettings.MinimumSize = new Size(1, 1);
            btnImportSettings.Name = "btnImportSettings";
            btnImportSettings.Radius = 8;
            btnImportSettings.RectColor = Color.Transparent;
            btnImportSettings.Size = new Size(130, 30);
            btnImportSettings.Style = Sunny.UI.UIStyle.Custom;
            btnImportSettings.TabIndex = 5;
            btnImportSettings.Text = "📥 Импорт";
            btnImportSettings.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnPreview
            // 
            btnPreview.FillColor = Color.Teal;
            btnPreview.FillColor2 = Color.Transparent;
            btnPreview.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnPreview.FillHoverColor = Color.DarkCyan;
            btnPreview.FillPressColor = Color.Cyan;
            btnPreview.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPreview.Location = new Point(275, 39);
            btnPreview.MinimumSize = new Size(1, 1);
            btnPreview.Name = "btnPreview";
            btnPreview.Radius = 8;
            btnPreview.RectColor = Color.Transparent;
            btnPreview.Size = new Size(130, 30);
            btnPreview.Style = Sunny.UI.UIStyle.Custom;
            btnPreview.TabIndex = 6;
            btnPreview.Text = "👁 Предпросмотр";
            btnPreview.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnDailyReport
            // 
            btnDailyReport.FillColor = Color.FromArgb(124, 58, 237);
            btnDailyReport.FillColor2 = Color.Transparent;
            btnDailyReport.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnDailyReport.FillHoverColor = Color.DarkOrchid;
            btnDailyReport.FillPressColor = Color.DarkViolet;
            btnDailyReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDailyReport.Location = new Point(411, 39);
            btnDailyReport.MinimumSize = new Size(1, 1);
            btnDailyReport.Name = "btnDailyReport";
            btnDailyReport.Radius = 8;
            btnDailyReport.RectColor = Color.Transparent;
            btnDailyReport.Size = new Size(130, 30);
            btnDailyReport.Style = Sunny.UI.UIStyle.Custom;
            btnDailyReport.TabIndex = 7;
            btnDailyReport.Text = "📊 Отчёт за день";
            btnDailyReport.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // HomeTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpHome);
            Name = "HomeTabControl";
            Size = new Size(696, 483);
            grpHome.ResumeLayout(false);
            pnlHomeButtons.ResumeLayout(false);
            pnlHomeInner.ResumeLayout(false);
            pnlHomeContent.ResumeLayout(false);
            pnlHomeContent.PerformLayout();
            grpHomeHistory.ResumeLayout(false);
            grpModeDescription.ResumeLayout(false);
            grpModeDescription.PerformLayout();
            grpQuickActions.ResumeLayout(false);
            grpQuickStats.ResumeLayout(false);
            grpGroupInfo.ResumeLayout(false);
            pnlGroupInfo.ResumeLayout(false);
            pnlGroupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGroupStatus).EndInit();
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpHome;
        private Sunny.UI.UIPanel pnlHomeButtons;
        private Sunny.UI.UICheckBox chkHomeManualConfirm;
        private Sunny.UI.UIButton btnSaveHome;
        private Sunny.UI.UIButton btnStartHome;
        private Panel pnlHomeInner;
        private Panel pnlHomeContent;

        // Group Info Section
        private Sunny.UI.UIGroupBox grpGroupInfo;
        private Panel pnlGroupInfo;
        private Label lblGroupStatus;
        private PictureBox picGroupStatus;
        private Label lblGroupTitle;
        private Label lblGroupUsername;
        private Label lblGroupType;
        private Label lblGroupMembers;
        private Label lblGroupId;

        // Active Mode Selection
        private Label lblActiveMode;
        private Sunny.UI.UIComboBox cmbActiveMode;
        private Sunny.UI.UIRadioButton radModeAuto;
        private Sunny.UI.UIRadioButton radModeDelayed;
        private Sunny.UI.UIRadioButton radModePeriodic;
        private Sunny.UI.UIRadioButton radModeSchedule;
        private Sunny.UI.UIRadioButton radModeEvent;
        private Sunny.UI.UIRadioButton radModePriority;
        private Sunny.UI.UIRadioButton radModeManual;
        private Sunny.UI.UIButton btnConfigureMode;

        // Quick Stats
        private Sunny.UI.UIGroupBox grpQuickStats;
        private FlowLayoutPanel pnlQuickStats;
        private Label lblStatTotalSent;
        private Label lblStatSuccess;
        private Label lblStatErrors;
        private Label lblStatQueue;
        private Label lblStatUptime;

        // General Settings
        private Label lblGeneralSettings;
        private Label lblTimezone;
        private Sunny.UI.UIComboBox cmbTimezone;
        private Label lblDailyLimit;
        private Sunny.UI.UIIntegerUpDown nudDailyLimit;
        private Sunny.UI.UICheckBox chkNotifyErrors;
        private Sunny.UI.UICheckBox chkNotifyComplete;
        private Sunny.UI.UICheckBox chkQuietMode;
        private Label lblNotificationChat;
        private Sunny.UI.UIComboBox cmbNotificationChat;

        // Quick Actions
        private Sunny.UI.UIGroupBox grpQuickActions;
        private FlowLayoutPanel pnlQuickActions;
        private Sunny.UI.UIButton btnTestSend;
        private Sunny.UI.UIButton btnPause;
        private Sunny.UI.UIButton btnResume;
        private Sunny.UI.UIButton btnClearQueue;
        private Sunny.UI.UIButton btnExportSettings;
        private Sunny.UI.UIButton btnImportSettings;
        private Sunny.UI.UIButton btnPreview;
        private Sunny.UI.UIButton btnDailyReport;

        // Mode Description
        private Sunny.UI.UIGroupBox grpModeDescription;
        private Label lblModeDescription;

        // History/Logs
        private Sunny.UI.UIGroupBox grpHomeHistory;
        private FlowLayoutPanel flpHomeHistory;
    }
}