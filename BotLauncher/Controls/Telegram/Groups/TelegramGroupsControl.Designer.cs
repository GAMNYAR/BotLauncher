namespace BotLauncher.Controls.Telegram.Groups
{
    partial class TelegramGroupsControl
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            pnlGroupInfo = new Sunny.UI.UIPanel();
            avatarPanel = new Sunny.UI.UIPanel();
            lblChannelName = new Label();
            lblChannelNickname = new Label();
            lblGroupTypeLabel = new Label();
            lblGroupTypeValue = new Label();
            lblGroupId = new Label();
            lblParticipantsLabel = new Label();
            lblParticipantsValue = new Label();
            lblStatusLabel = new Label();
            lblStatusValue = new Label();
            pnlSendSettings = new Sunny.UI.UIPanel();
            TabControl = new Sunny.UI.UITabControl();
            tabHome = new TabPage();
            grpHomePlaceholder = new Sunny.UI.UIGroupBox();
            lblHomeNoSelection = new Sunny.UI.UILabel();
            tabAuto = new TabPage();
            grpAutoPlaceholder = new Sunny.UI.UIGroupBox();
            lblAutoNoSelection = new Sunny.UI.UILabel();
            tabDelayed = new TabPage();
            grpDelayedPlaceholder = new Sunny.UI.UIGroupBox();
            lblDelayedNoSelection = new Sunny.UI.UILabel();
            tabPeriodic = new TabPage();
            grpPeriodicPlaceholder = new Sunny.UI.UIGroupBox();
            lblPeriodicNoSelection = new Sunny.UI.UILabel();
            tabSchedule = new TabPage();
            grpSchedulePlaceholder = new Sunny.UI.UIGroupBox();
            lblScheduleNoSelection = new Sunny.UI.UILabel();
            tabEvent = new TabPage();
            grpEventPlaceholder = new Sunny.UI.UIGroupBox();
            lblEventNoSelection = new Sunny.UI.UILabel();
            tabPriority = new TabPage();
            grpPriorityPlaceholder = new Sunny.UI.UIGroupBox();
            lblPriorityNoSelection = new Sunny.UI.UILabel();
            tabManual = new TabPage();
            grpManualPlaceholder = new Sunny.UI.UIGroupBox();
            lblManualNoSelection = new Sunny.UI.UILabel();
            lblTgNewMassegeInfo = new Label();
            pnlConnectedGroups = new Sunny.UI.UIPanel();
            flpConnectedChats = new FlowLayoutPanel();
            lblConnectedChatsTitle = new Label();
            btnAddConnectedChat = new FontAwesome.Sharp.IconButton();
            txtSearchGroups = new Sunny.UI.UITextBox();
            lblConnectedChatsCount = new Label();
            pnlGroupInfo.SuspendLayout();
            pnlSendSettings.SuspendLayout();
            TabControl.SuspendLayout();
            tabHome.SuspendLayout();
            grpHomePlaceholder.SuspendLayout();
            tabAuto.SuspendLayout();
            grpAutoPlaceholder.SuspendLayout();
            tabDelayed.SuspendLayout();
            grpDelayedPlaceholder.SuspendLayout();
            tabPeriodic.SuspendLayout();
            grpPeriodicPlaceholder.SuspendLayout();
            tabSchedule.SuspendLayout();
            grpSchedulePlaceholder.SuspendLayout();
            tabEvent.SuspendLayout();
            grpEventPlaceholder.SuspendLayout();
            tabPriority.SuspendLayout();
            grpPriorityPlaceholder.SuspendLayout();
            tabManual.SuspendLayout();
            grpManualPlaceholder.SuspendLayout();
            pnlConnectedGroups.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGroupInfo
            // 
            pnlGroupInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlGroupInfo.BackColor = Color.Transparent;
            pnlGroupInfo.Controls.Add(avatarPanel);
            pnlGroupInfo.Controls.Add(lblChannelName);
            pnlGroupInfo.Controls.Add(lblChannelNickname);
            pnlGroupInfo.Controls.Add(lblGroupTypeLabel);
            pnlGroupInfo.Controls.Add(lblGroupTypeValue);
            pnlGroupInfo.Controls.Add(lblGroupId);
            pnlGroupInfo.Controls.Add(lblParticipantsLabel);
            pnlGroupInfo.Controls.Add(lblParticipantsValue);
            pnlGroupInfo.Controls.Add(lblStatusLabel);
            pnlGroupInfo.Controls.Add(lblStatusValue);
            pnlGroupInfo.FillColor = Color.FromArgb(35, 39, 48);
            pnlGroupInfo.FillColor2 = Color.Transparent;
            pnlGroupInfo.FillDisableColor = Color.Transparent;
            pnlGroupInfo.Font = new Font("Microsoft Sans Serif", 12F);
            pnlGroupInfo.ForeColor = Color.Transparent;
            pnlGroupInfo.ForeDisableColor = Color.Transparent;
            pnlGroupInfo.Location = new Point(275, 5);
            pnlGroupInfo.Margin = new Padding(0);
            pnlGroupInfo.MinimumSize = new Size(1, 1);
            pnlGroupInfo.Name = "pnlGroupInfo";
            pnlGroupInfo.Padding = new Padding(10);
            pnlGroupInfo.Radius = 20;
            pnlGroupInfo.RadiusSides = Sunny.UI.UICornerRadiusSides.RightTop;
            pnlGroupInfo.RectColor = Color.FromArgb(42, 47, 58);
            pnlGroupInfo.RectDisableColor = Color.Empty;
            pnlGroupInfo.Size = new Size(696, 127);
            pnlGroupInfo.TabIndex = 16;
            pnlGroupInfo.Text = null;
            pnlGroupInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // avatarPanel
            // 
            avatarPanel.BackColor = Color.Transparent;
            avatarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            avatarPanel.FillColor = Color.Transparent;
            avatarPanel.FillColor2 = Color.Transparent;
            avatarPanel.FillDisableColor = Color.Transparent;
            avatarPanel.Font = new Font("Microsoft Sans Serif", 12F);
            avatarPanel.ForeColor = Color.Transparent;
            avatarPanel.ForeDisableColor = Color.Transparent;
            avatarPanel.Location = new Point(10, 17);
            avatarPanel.Margin = new Padding(4, 5, 4, 5);
            avatarPanel.MinimumSize = new Size(1, 1);
            avatarPanel.Name = "avatarPanel";
            avatarPanel.Radius = 95;
            avatarPanel.RectColor = Color.Silver;
            avatarPanel.RectDisableColor = Color.Empty;
            avatarPanel.Size = new Size(95, 95);
            avatarPanel.Style = Sunny.UI.UIStyle.Custom;
            avatarPanel.TabIndex = 48;
            avatarPanel.Text = null;
            avatarPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblChannelName
            // 
            lblChannelName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblChannelName.AutoEllipsis = true;
            lblChannelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblChannelName.ImeMode = ImeMode.NoControl;
            lblChannelName.Location = new Point(111, 12);
            lblChannelName.Name = "lblChannelName";
            lblChannelName.Size = new Size(562, 19);
            lblChannelName.TabIndex = 21;
            lblChannelName.Text = "Название канала";
            lblChannelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChannelNickname
            // 
            lblChannelNickname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblChannelNickname.BackColor = Color.Transparent;
            lblChannelNickname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblChannelNickname.ForeColor = Color.FromArgb(128, 128, 255);
            lblChannelNickname.ImeMode = ImeMode.NoControl;
            lblChannelNickname.Location = new Point(111, 31);
            lblChannelNickname.Name = "lblChannelNickname";
            lblChannelNickname.Size = new Size(348, 18);
            lblChannelNickname.TabIndex = 20;
            lblChannelNickname.Text = "@nickname";
            lblChannelNickname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGroupTypeLabel
            // 
            lblGroupTypeLabel.BackColor = Color.Transparent;
            lblGroupTypeLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblGroupTypeLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblGroupTypeLabel.ImeMode = ImeMode.NoControl;
            lblGroupTypeLabel.Location = new Point(111, 48);
            lblGroupTypeLabel.Name = "lblGroupTypeLabel";
            lblGroupTypeLabel.Size = new Size(33, 19);
            lblGroupTypeLabel.TabIndex = 43;
            lblGroupTypeLabel.Text = "Тип:";
            lblGroupTypeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGroupTypeValue
            // 
            lblGroupTypeValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGroupTypeValue.BackColor = Color.Transparent;
            lblGroupTypeValue.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblGroupTypeValue.ForeColor = Color.White;
            lblGroupTypeValue.ImeMode = ImeMode.NoControl;
            lblGroupTypeValue.Location = new Point(140, 47);
            lblGroupTypeValue.Name = "lblGroupTypeValue";
            lblGroupTypeValue.Size = new Size(97, 19);
            lblGroupTypeValue.TabIndex = 44;
            lblGroupTypeValue.Text = "-";
            lblGroupTypeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGroupId
            // 
            lblGroupId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGroupId.BackColor = Color.Transparent;
            lblGroupId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblGroupId.ForeColor = Color.LightGray;
            lblGroupId.ImeMode = ImeMode.NoControl;
            lblGroupId.Location = new Point(111, 66);
            lblGroupId.Name = "lblGroupId";
            lblGroupId.Size = new Size(123, 16);
            lblGroupId.TabIndex = 30;
            lblGroupId.Text = "ID:-";
            lblGroupId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblParticipantsLabel
            // 
            lblParticipantsLabel.BackColor = Color.Transparent;
            lblParticipantsLabel.Font = new Font("Segoe UI", 9.75F);
            lblParticipantsLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblParticipantsLabel.ImeMode = ImeMode.NoControl;
            lblParticipantsLabel.Location = new Point(111, 82);
            lblParticipantsLabel.Name = "lblParticipantsLabel";
            lblParticipantsLabel.Size = new Size(78, 17);
            lblParticipantsLabel.TabIndex = 46;
            lblParticipantsLabel.Text = "Участников:";
            // 
            // lblParticipantsValue
            // 
            lblParticipantsValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblParticipantsValue.BackColor = Color.Transparent;
            lblParticipantsValue.Font = new Font("Segoe UI", 9.75F);
            lblParticipantsValue.ForeColor = Color.White;
            lblParticipantsValue.ImeMode = ImeMode.NoControl;
            lblParticipantsValue.Location = new Point(187, 82);
            lblParticipantsValue.Name = "lblParticipantsValue";
            lblParticipantsValue.Size = new Size(85, 17);
            lblParticipantsValue.TabIndex = 47;
            lblParticipantsValue.Text = "-";
            lblParticipantsValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusLabel
            // 
            lblStatusLabel.BackColor = Color.Transparent;
            lblStatusLabel.Font = new Font("Segoe UI", 9.75F);
            lblStatusLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblStatusLabel.ImeMode = ImeMode.NoControl;
            lblStatusLabel.Location = new Point(111, 98);
            lblStatusLabel.Name = "lblStatusLabel";
            lblStatusLabel.Size = new Size(48, 17);
            lblStatusLabel.TabIndex = 41;
            lblStatusLabel.Text = "Статус:";
            // 
            // lblStatusValue
            // 
            lblStatusValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStatusValue.BackColor = Color.Transparent;
            lblStatusValue.FlatStyle = FlatStyle.Flat;
            lblStatusValue.Font = new Font("Segoe UI", 9.75F);
            lblStatusValue.ForeColor = Color.Gainsboro;
            lblStatusValue.ImeMode = ImeMode.NoControl;
            lblStatusValue.Location = new Point(155, 98);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(86, 17);
            lblStatusValue.TabIndex = 42;
            lblStatusValue.Text = "Неизвестно";
            lblStatusValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSendSettings
            // 
            pnlSendSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSendSettings.BackColor = Color.Transparent;
            pnlSendSettings.Controls.Add(TabControl);
            pnlSendSettings.FillColor = Color.FromArgb(35, 39, 48);
            pnlSendSettings.FillColor2 = Color.Transparent;
            pnlSendSettings.FillDisableColor = Color.Transparent;
            pnlSendSettings.Font = new Font("Microsoft Sans Serif", 12F);
            pnlSendSettings.ForeColor = Color.Transparent;
            pnlSendSettings.ForeDisableColor = Color.Transparent;
            pnlSendSettings.Location = new Point(275, 135);
            pnlSendSettings.Margin = new Padding(0, 5, 0, 5);
            pnlSendSettings.MinimumSize = new Size(1, 1);
            pnlSendSettings.Name = "pnlSendSettings";
            pnlSendSettings.Padding = new Padding(5);
            pnlSendSettings.Radius = 20;
            pnlSendSettings.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            pnlSendSettings.RectColor = Color.FromArgb(42, 47, 58);
            pnlSendSettings.RectDisableColor = Color.Empty;
            pnlSendSettings.Size = new Size(696, 518);
            pnlSendSettings.TabIndex = 17;
            pnlSendSettings.Text = null;
            pnlSendSettings.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(tabHome);
            TabControl.Controls.Add(tabAuto);
            TabControl.Controls.Add(tabDelayed);
            TabControl.Controls.Add(tabPeriodic);
            TabControl.Controls.Add(tabSchedule);
            TabControl.Controls.Add(tabEvent);
            TabControl.Controls.Add(tabPriority);
            TabControl.Controls.Add(tabManual);
            TabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            TabControl.FillColor = Color.Transparent;
            TabControl.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TabControl.ForbidCtrlTab = false;
            TabControl.ItemSize = new Size(115, 35);
            TabControl.Location = new Point(0, 0);
            TabControl.MainPage = "";
            TabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            TabControl.Name = "TabControl";
            TabControl.RightToLeft = RightToLeft.No;
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(696, 518);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.Style = Sunny.UI.UIStyle.Custom;
            TabControl.TabBackColor = Color.FromArgb(31, 35, 43);
            TabControl.TabIndex = 4;
            TabControl.TabPageTextAlignment = HorizontalAlignment.Center;
            TabControl.TabSelectedColor = Color.Indigo;
            TabControl.TabSelectedForeColor = Color.White;
            TabControl.TabSelectedHighColor = Color.MediumPurple;
            TabControl.TabUnSelectedColor = Color.FromArgb(31, 35, 43);
            TabControl.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            TabControl.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.Transparent;
            tabHome.Controls.Add(grpHomePlaceholder);
            tabHome.Location = new Point(0, 35);
            tabHome.Name = "tabHome";
            tabHome.Size = new Size(696, 483);
            tabHome.TabIndex = 7;
            tabHome.Text = "Главная";
            // 
            // grpHomePlaceholder
            // 
            grpHomePlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpHomePlaceholder.Controls.Add(lblHomeNoSelection);
            grpHomePlaceholder.Dock = DockStyle.Fill;
            grpHomePlaceholder.FillColor = Color.Transparent;
            grpHomePlaceholder.FillColor2 = Color.Transparent;
            grpHomePlaceholder.FillDisableColor = Color.Transparent;
            grpHomePlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpHomePlaceholder.ForeColor = Color.White;
            grpHomePlaceholder.ForeDisableColor = Color.Transparent;
            grpHomePlaceholder.Location = new Point(0, 0);
            grpHomePlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpHomePlaceholder.MinimumSize = new Size(1, 1);
            grpHomePlaceholder.Name = "grpHomePlaceholder";
            grpHomePlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpHomePlaceholder.Radius = 0;
            grpHomePlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpHomePlaceholder.RectDisableColor = Color.Transparent;
            grpHomePlaceholder.Size = new Size(696, 483);
            grpHomePlaceholder.TabIndex = 0;
            grpHomePlaceholder.Text = "Главная — Управление группой";
            grpHomePlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpHomePlaceholder.TitleInterval = 8;
            grpHomePlaceholder.TitleTop = 14;
            // 
            // lblHomeNoSelection
            // 
            lblHomeNoSelection.Dock = DockStyle.Fill;
            lblHomeNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblHomeNoSelection.ForeColor = Color.White;
            lblHomeNoSelection.Location = new Point(5, 32);
            lblHomeNoSelection.Name = "lblHomeNoSelection";
            lblHomeNoSelection.Size = new Size(686, 446);
            lblHomeNoSelection.TabIndex = 0;
            lblHomeNoSelection.Text = "Сначала выберите группу или канал";
            lblHomeNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabAuto
            // 
            tabAuto.AutoScroll = true;
            tabAuto.BackColor = Color.Transparent;
            tabAuto.Controls.Add(grpAutoPlaceholder);
            tabAuto.ForeColor = Color.White;
            tabAuto.Location = new Point(0, 40);
            tabAuto.Name = "tabAuto";
            tabAuto.Size = new Size(200, 60);
            tabAuto.TabIndex = 0;
            tabAuto.Text = "Автоматический";
            // 
            // grpAutoPlaceholder
            // 
            grpAutoPlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpAutoPlaceholder.Controls.Add(lblAutoNoSelection);
            grpAutoPlaceholder.Dock = DockStyle.Fill;
            grpAutoPlaceholder.FillColor = Color.Transparent;
            grpAutoPlaceholder.FillColor2 = Color.Transparent;
            grpAutoPlaceholder.FillDisableColor = Color.Transparent;
            grpAutoPlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpAutoPlaceholder.ForeColor = Color.White;
            grpAutoPlaceholder.ForeDisableColor = Color.Transparent;
            grpAutoPlaceholder.Location = new Point(0, 0);
            grpAutoPlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpAutoPlaceholder.MinimumSize = new Size(1, 1);
            grpAutoPlaceholder.Name = "grpAutoPlaceholder";
            grpAutoPlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpAutoPlaceholder.Radius = 0;
            grpAutoPlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpAutoPlaceholder.RectDisableColor = Color.Transparent;
            grpAutoPlaceholder.Size = new Size(200, 60);
            grpAutoPlaceholder.TabIndex = 1;
            grpAutoPlaceholder.Text = "Настройки автоматической отправки";
            grpAutoPlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpAutoPlaceholder.TitleInterval = 8;
            grpAutoPlaceholder.TitleTop = 14;
            // 
            // lblAutoNoSelection
            // 
            lblAutoNoSelection.Dock = DockStyle.Fill;
            lblAutoNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblAutoNoSelection.ForeColor = Color.White;
            lblAutoNoSelection.Location = new Point(5, 32);
            lblAutoNoSelection.Name = "lblAutoNoSelection";
            lblAutoNoSelection.Size = new Size(190, 23);
            lblAutoNoSelection.TabIndex = 0;
            lblAutoNoSelection.Text = "Сначала выберите группу или канал";
            lblAutoNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDelayed
            // 
            tabDelayed.AutoScroll = true;
            tabDelayed.BackColor = Color.Transparent;
            tabDelayed.Controls.Add(grpDelayedPlaceholder);
            tabDelayed.ForeColor = Color.White;
            tabDelayed.Location = new Point(0, 40);
            tabDelayed.Name = "tabDelayed";
            tabDelayed.Size = new Size(200, 60);
            tabDelayed.TabIndex = 1;
            tabDelayed.Text = "Отложенный";
            // 
            // grpDelayedPlaceholder
            // 
            grpDelayedPlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpDelayedPlaceholder.Controls.Add(lblDelayedNoSelection);
            grpDelayedPlaceholder.Dock = DockStyle.Fill;
            grpDelayedPlaceholder.FillColor = Color.Transparent;
            grpDelayedPlaceholder.FillColor2 = Color.Transparent;
            grpDelayedPlaceholder.FillDisableColor = Color.Transparent;
            grpDelayedPlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpDelayedPlaceholder.ForeColor = Color.White;
            grpDelayedPlaceholder.ForeDisableColor = Color.Transparent;
            grpDelayedPlaceholder.Location = new Point(0, 0);
            grpDelayedPlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpDelayedPlaceholder.MinimumSize = new Size(1, 1);
            grpDelayedPlaceholder.Name = "grpDelayedPlaceholder";
            grpDelayedPlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpDelayedPlaceholder.Radius = 0;
            grpDelayedPlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpDelayedPlaceholder.RectDisableColor = Color.Transparent;
            grpDelayedPlaceholder.Size = new Size(200, 60);
            grpDelayedPlaceholder.TabIndex = 1;
            grpDelayedPlaceholder.Text = "Настройки отложенной отправки";
            grpDelayedPlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpDelayedPlaceholder.TitleInterval = 8;
            grpDelayedPlaceholder.TitleTop = 14;
            // 
            // lblDelayedNoSelection
            // 
            lblDelayedNoSelection.Dock = DockStyle.Fill;
            lblDelayedNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblDelayedNoSelection.ForeColor = Color.White;
            lblDelayedNoSelection.Location = new Point(5, 32);
            lblDelayedNoSelection.Name = "lblDelayedNoSelection";
            lblDelayedNoSelection.Size = new Size(190, 23);
            lblDelayedNoSelection.TabIndex = 0;
            lblDelayedNoSelection.Text = "Сначала выберите группу или канал";
            lblDelayedNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPeriodic
            // 
            tabPeriodic.AutoScroll = true;
            tabPeriodic.BackColor = Color.Transparent;
            tabPeriodic.Controls.Add(grpPeriodicPlaceholder);
            tabPeriodic.ForeColor = Color.White;
            tabPeriodic.Location = new Point(0, 40);
            tabPeriodic.Name = "tabPeriodic";
            tabPeriodic.Size = new Size(200, 60);
            tabPeriodic.TabIndex = 2;
            tabPeriodic.Text = "Периодически";
            // 
            // grpPeriodicPlaceholder
            // 
            grpPeriodicPlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpPeriodicPlaceholder.Controls.Add(lblPeriodicNoSelection);
            grpPeriodicPlaceholder.Dock = DockStyle.Fill;
            grpPeriodicPlaceholder.FillColor = Color.Transparent;
            grpPeriodicPlaceholder.FillColor2 = Color.Transparent;
            grpPeriodicPlaceholder.FillDisableColor = Color.Transparent;
            grpPeriodicPlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpPeriodicPlaceholder.ForeColor = Color.White;
            grpPeriodicPlaceholder.ForeDisableColor = Color.Transparent;
            grpPeriodicPlaceholder.Location = new Point(0, 0);
            grpPeriodicPlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpPeriodicPlaceholder.MinimumSize = new Size(1, 1);
            grpPeriodicPlaceholder.Name = "grpPeriodicPlaceholder";
            grpPeriodicPlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpPeriodicPlaceholder.Radius = 0;
            grpPeriodicPlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpPeriodicPlaceholder.RectDisableColor = Color.Transparent;
            grpPeriodicPlaceholder.Size = new Size(200, 60);
            grpPeriodicPlaceholder.TabIndex = 1;
            grpPeriodicPlaceholder.Text = "Настройки периодической отправки";
            grpPeriodicPlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpPeriodicPlaceholder.TitleInterval = 8;
            grpPeriodicPlaceholder.TitleTop = 14;
            // 
            // lblPeriodicNoSelection
            // 
            lblPeriodicNoSelection.Dock = DockStyle.Fill;
            lblPeriodicNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPeriodicNoSelection.ForeColor = Color.White;
            lblPeriodicNoSelection.Location = new Point(5, 32);
            lblPeriodicNoSelection.Name = "lblPeriodicNoSelection";
            lblPeriodicNoSelection.Size = new Size(190, 23);
            lblPeriodicNoSelection.TabIndex = 0;
            lblPeriodicNoSelection.Text = "Сначала выберите группу или канал";
            lblPeriodicNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabSchedule
            // 
            tabSchedule.AutoScroll = true;
            tabSchedule.BackColor = Color.Transparent;
            tabSchedule.Controls.Add(grpSchedulePlaceholder);
            tabSchedule.ForeColor = Color.White;
            tabSchedule.Location = new Point(0, 40);
            tabSchedule.Name = "tabSchedule";
            tabSchedule.Size = new Size(200, 60);
            tabSchedule.TabIndex = 3;
            tabSchedule.Text = "По расписанию";
            // 
            // grpSchedulePlaceholder
            // 
            grpSchedulePlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpSchedulePlaceholder.Controls.Add(lblScheduleNoSelection);
            grpSchedulePlaceholder.Dock = DockStyle.Fill;
            grpSchedulePlaceholder.FillColor = Color.Transparent;
            grpSchedulePlaceholder.FillColor2 = Color.Transparent;
            grpSchedulePlaceholder.FillDisableColor = Color.Transparent;
            grpSchedulePlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpSchedulePlaceholder.ForeColor = Color.White;
            grpSchedulePlaceholder.ForeDisableColor = Color.Transparent;
            grpSchedulePlaceholder.Location = new Point(0, 0);
            grpSchedulePlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpSchedulePlaceholder.MinimumSize = new Size(1, 1);
            grpSchedulePlaceholder.Name = "grpSchedulePlaceholder";
            grpSchedulePlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpSchedulePlaceholder.Radius = 0;
            grpSchedulePlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpSchedulePlaceholder.RectDisableColor = Color.Transparent;
            grpSchedulePlaceholder.Size = new Size(200, 60);
            grpSchedulePlaceholder.TabIndex = 1;
            grpSchedulePlaceholder.Text = "Настройки по расписанию отправки";
            grpSchedulePlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpSchedulePlaceholder.TitleInterval = 8;
            grpSchedulePlaceholder.TitleTop = 14;
            // 
            // lblScheduleNoSelection
            // 
            lblScheduleNoSelection.Dock = DockStyle.Fill;
            lblScheduleNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblScheduleNoSelection.ForeColor = Color.White;
            lblScheduleNoSelection.Location = new Point(5, 32);
            lblScheduleNoSelection.Name = "lblScheduleNoSelection";
            lblScheduleNoSelection.Size = new Size(190, 23);
            lblScheduleNoSelection.TabIndex = 0;
            lblScheduleNoSelection.Text = "Сначала выберите группу или канал";
            lblScheduleNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabEvent
            // 
            tabEvent.AutoScroll = true;
            tabEvent.BackColor = Color.Transparent;
            tabEvent.Controls.Add(grpEventPlaceholder);
            tabEvent.ForeColor = Color.White;
            tabEvent.Location = new Point(0, 40);
            tabEvent.Name = "tabEvent";
            tabEvent.Size = new Size(200, 60);
            tabEvent.TabIndex = 4;
            tabEvent.Text = "По событию";
            // 
            // grpEventPlaceholder
            // 
            grpEventPlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpEventPlaceholder.Controls.Add(lblEventNoSelection);
            grpEventPlaceholder.Dock = DockStyle.Fill;
            grpEventPlaceholder.FillColor = Color.Transparent;
            grpEventPlaceholder.FillColor2 = Color.Transparent;
            grpEventPlaceholder.FillDisableColor = Color.Transparent;
            grpEventPlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpEventPlaceholder.ForeColor = Color.White;
            grpEventPlaceholder.ForeDisableColor = Color.Transparent;
            grpEventPlaceholder.Location = new Point(0, 0);
            grpEventPlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpEventPlaceholder.MinimumSize = new Size(1, 1);
            grpEventPlaceholder.Name = "grpEventPlaceholder";
            grpEventPlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpEventPlaceholder.Radius = 0;
            grpEventPlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpEventPlaceholder.RectDisableColor = Color.Transparent;
            grpEventPlaceholder.Size = new Size(200, 60);
            grpEventPlaceholder.TabIndex = 1;
            grpEventPlaceholder.Text = "Настройки события отправки";
            grpEventPlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpEventPlaceholder.TitleInterval = 8;
            grpEventPlaceholder.TitleTop = 14;
            // 
            // lblEventNoSelection
            // 
            lblEventNoSelection.Dock = DockStyle.Fill;
            lblEventNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblEventNoSelection.ForeColor = Color.White;
            lblEventNoSelection.Location = new Point(5, 32);
            lblEventNoSelection.Name = "lblEventNoSelection";
            lblEventNoSelection.Size = new Size(190, 23);
            lblEventNoSelection.TabIndex = 0;
            lblEventNoSelection.Text = "Сначала выберите группу или канал";
            lblEventNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPriority
            // 
            tabPriority.AutoScroll = true;
            tabPriority.BackColor = Color.Transparent;
            tabPriority.Controls.Add(grpPriorityPlaceholder);
            tabPriority.ForeColor = Color.White;
            tabPriority.Location = new Point(0, 40);
            tabPriority.Name = "tabPriority";
            tabPriority.Size = new Size(200, 60);
            tabPriority.TabIndex = 5;
            tabPriority.Text = "Приоритетный";
            // 
            // grpPriorityPlaceholder
            // 
            grpPriorityPlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpPriorityPlaceholder.Controls.Add(lblPriorityNoSelection);
            grpPriorityPlaceholder.Dock = DockStyle.Fill;
            grpPriorityPlaceholder.FillColor = Color.Transparent;
            grpPriorityPlaceholder.FillColor2 = Color.Transparent;
            grpPriorityPlaceholder.FillDisableColor = Color.Transparent;
            grpPriorityPlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpPriorityPlaceholder.ForeColor = Color.White;
            grpPriorityPlaceholder.ForeDisableColor = Color.Transparent;
            grpPriorityPlaceholder.Location = new Point(0, 0);
            grpPriorityPlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpPriorityPlaceholder.MinimumSize = new Size(1, 1);
            grpPriorityPlaceholder.Name = "grpPriorityPlaceholder";
            grpPriorityPlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpPriorityPlaceholder.Radius = 0;
            grpPriorityPlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpPriorityPlaceholder.RectDisableColor = Color.Transparent;
            grpPriorityPlaceholder.Size = new Size(200, 60);
            grpPriorityPlaceholder.TabIndex = 1;
            grpPriorityPlaceholder.Text = "Настройки приоритетной отправки";
            grpPriorityPlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpPriorityPlaceholder.TitleInterval = 8;
            grpPriorityPlaceholder.TitleTop = 14;
            // 
            // lblPriorityNoSelection
            // 
            lblPriorityNoSelection.Dock = DockStyle.Fill;
            lblPriorityNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblPriorityNoSelection.ForeColor = Color.White;
            lblPriorityNoSelection.Location = new Point(5, 32);
            lblPriorityNoSelection.Name = "lblPriorityNoSelection";
            lblPriorityNoSelection.Size = new Size(190, 23);
            lblPriorityNoSelection.TabIndex = 0;
            lblPriorityNoSelection.Text = "Сначала выберите группу или канал";
            lblPriorityNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabManual
            // 
            tabManual.AutoScroll = true;
            tabManual.BackColor = Color.Transparent;
            tabManual.Controls.Add(grpManualPlaceholder);
            tabManual.ForeColor = Color.White;
            tabManual.Location = new Point(0, 35);
            tabManual.Name = "tabManual";
            tabManual.Size = new Size(696, 483);
            tabManual.TabIndex = 6;
            tabManual.Text = "Ручной";
            // 
            // grpManualPlaceholder
            // 
            grpManualPlaceholder.BackColor = Color.FromArgb(31, 35, 43);
            grpManualPlaceholder.Controls.Add(lblManualNoSelection);
            grpManualPlaceholder.Dock = DockStyle.Fill;
            grpManualPlaceholder.FillColor = Color.Transparent;
            grpManualPlaceholder.FillColor2 = Color.Transparent;
            grpManualPlaceholder.FillDisableColor = Color.Transparent;
            grpManualPlaceholder.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpManualPlaceholder.ForeColor = Color.White;
            grpManualPlaceholder.ForeDisableColor = Color.Transparent;
            grpManualPlaceholder.Location = new Point(0, 0);
            grpManualPlaceholder.Margin = new Padding(4, 5, 4, 5);
            grpManualPlaceholder.MinimumSize = new Size(1, 1);
            grpManualPlaceholder.Name = "grpManualPlaceholder";
            grpManualPlaceholder.Padding = new Padding(5, 32, 5, 5);
            grpManualPlaceholder.Radius = 0;
            grpManualPlaceholder.RectColor = Color.FromArgb(58, 58, 69);
            grpManualPlaceholder.RectDisableColor = Color.Transparent;
            grpManualPlaceholder.Size = new Size(696, 483);
            grpManualPlaceholder.TabIndex = 1;
            grpManualPlaceholder.Text = "Настройки ручной отправки";
            grpManualPlaceholder.TextAlignment = ContentAlignment.TopLeft;
            grpManualPlaceholder.TitleInterval = 8;
            grpManualPlaceholder.TitleTop = 14;
            // 
            // lblManualNoSelection
            // 
            lblManualNoSelection.Dock = DockStyle.Fill;
            lblManualNoSelection.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblManualNoSelection.ForeColor = Color.White;
            lblManualNoSelection.Location = new Point(5, 32);
            lblManualNoSelection.Name = "lblManualNoSelection";
            lblManualNoSelection.Size = new Size(686, 446);
            lblManualNoSelection.TabIndex = 0;
            lblManualNoSelection.Text = "Сначала выберите группу или канал";
            lblManualNoSelection.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTgNewMassegeInfo
            // 
            lblTgNewMassegeInfo.AutoSize = true;
            lblTgNewMassegeInfo.BackColor = Color.Transparent;
            lblTgNewMassegeInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblTgNewMassegeInfo.ForeColor = Color.FromArgb(180, 180, 180);
            lblTgNewMassegeInfo.Location = new Point(16, 16);
            lblTgNewMassegeInfo.Name = "lblTgNewMassegeInfo";
            lblTgNewMassegeInfo.Size = new Size(372, 15);
            lblTgNewMassegeInfo.TabIndex = 100;
            lblTgNewMassegeInfo.Text = "Будет срабатывать на каждое новое сообщение в чате/канале.";
            // 
            // pnlConnectedGroups
            // 
            pnlConnectedGroups.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlConnectedGroups.BackColor = Color.Transparent;
            pnlConnectedGroups.Controls.Add(flpConnectedChats);
            pnlConnectedGroups.Controls.Add(lblConnectedChatsTitle);
            pnlConnectedGroups.Controls.Add(btnAddConnectedChat);
            pnlConnectedGroups.Controls.Add(txtSearchGroups);
            pnlConnectedGroups.Controls.Add(lblConnectedChatsCount);
            pnlConnectedGroups.FillColor = Color.FromArgb(35, 39, 48);
            pnlConnectedGroups.FillColor2 = Color.Transparent;
            pnlConnectedGroups.FillDisableColor = Color.Transparent;
            pnlConnectedGroups.Font = new Font("Microsoft Sans Serif", 12F);
            pnlConnectedGroups.ForeColor = Color.Transparent;
            pnlConnectedGroups.ForeDisableColor = Color.Transparent;
            pnlConnectedGroups.Location = new Point(5, 5);
            pnlConnectedGroups.Margin = new Padding(0, 0, 5, 0);
            pnlConnectedGroups.MinimumSize = new Size(1, 1);
            pnlConnectedGroups.Name = "pnlConnectedGroups";
            pnlConnectedGroups.Padding = new Padding(10);
            pnlConnectedGroups.Radius = 20;
            pnlConnectedGroups.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.LeftBottom;
            pnlConnectedGroups.RectColor = Color.FromArgb(42, 47, 58);
            pnlConnectedGroups.RectDisableColor = Color.Empty;
            pnlConnectedGroups.Size = new Size(265, 648);
            pnlConnectedGroups.TabIndex = 41;
            pnlConnectedGroups.Text = null;
            pnlConnectedGroups.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flpConnectedChats
            // 
            flpConnectedChats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpConnectedChats.AutoScroll = true;
            flpConnectedChats.FlowDirection = FlowDirection.TopDown;
            flpConnectedChats.Location = new Point(0, 130);
            flpConnectedChats.Name = "flpConnectedChats";
            flpConnectedChats.Size = new Size(265, 518);
            flpConnectedChats.TabIndex = 6;
            flpConnectedChats.WrapContents = false;
            // 
            // lblConnectedChatsTitle
            // 
            lblConnectedChatsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblConnectedChatsTitle.FlatStyle = FlatStyle.Flat;
            lblConnectedChatsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConnectedChatsTitle.ForeColor = Color.White;
            lblConnectedChatsTitle.Location = new Point(8, 11);
            lblConnectedChatsTitle.Name = "lblConnectedChatsTitle";
            lblConnectedChatsTitle.Size = new Size(249, 22);
            lblConnectedChatsTitle.TabIndex = 4;
            lblConnectedChatsTitle.Text = "Подключенные группы и каналы";
            lblConnectedChatsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddConnectedChat
            // 
            btnAddConnectedChat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddConnectedChat.BackColor = Color.FromArgb(35, 39, 48);
            btnAddConnectedChat.FlatAppearance.BorderColor = Color.FromArgb(58, 58, 69);
            btnAddConnectedChat.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnAddConnectedChat.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnAddConnectedChat.FlatStyle = FlatStyle.Flat;
            btnAddConnectedChat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddConnectedChat.ForeColor = Color.White;
            btnAddConnectedChat.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddConnectedChat.IconColor = Color.White;
            btnAddConnectedChat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddConnectedChat.IconSize = 20;
            btnAddConnectedChat.ImeMode = ImeMode.NoControl;
            btnAddConnectedChat.Location = new Point(8, 39);
            btnAddConnectedChat.Name = "btnAddConnectedChat";
            btnAddConnectedChat.Padding = new Padding(5, 0, 0, 0);
            btnAddConnectedChat.Size = new Size(249, 30);
            btnAddConnectedChat.TabIndex = 31;
            btnAddConnectedChat.Text = "Добавить группу или канал";
            btnAddConnectedChat.TextAlign = ContentAlignment.MiddleRight;
            btnAddConnectedChat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddConnectedChat.UseVisualStyleBackColor = false;
            // 
            // txtSearchGroups
            // 
            txtSearchGroups.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchGroups.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchGroups.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchGroups.ButtonFillColor = Color.FromArgb(42, 46, 57);
            txtSearchGroups.ButtonFillHoverColor = Color.FromArgb(42, 46, 57);
            txtSearchGroups.ButtonFillPressColor = Color.FromArgb(42, 46, 57);
            txtSearchGroups.ButtonForeHoverColor = Color.Silver;
            txtSearchGroups.ButtonForePressColor = Color.DimGray;
            txtSearchGroups.ButtonRectColor = Color.Transparent;
            txtSearchGroups.ButtonRectHoverColor = Color.Transparent;
            txtSearchGroups.ButtonRectPressColor = Color.Transparent;
            txtSearchGroups.ButtonStyleInherited = false;
            txtSearchGroups.ButtonSymbol = 61442;
            txtSearchGroups.ButtonSymbolOffset = new Point(0, 0);
            txtSearchGroups.ButtonSymbolSize = 20;
            txtSearchGroups.ButtonWidth = 25;
            txtSearchGroups.FillColor = Color.FromArgb(42, 46, 57);
            txtSearchGroups.FillColor2 = Color.Transparent;
            txtSearchGroups.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtSearchGroups.ForeColor = Color.White;
            txtSearchGroups.IconSize = 20;
            txtSearchGroups.Location = new Point(8, 77);
            txtSearchGroups.Margin = new Padding(4, 5, 4, 5);
            txtSearchGroups.MinimumSize = new Size(1, 16);
            txtSearchGroups.Name = "txtSearchGroups";
            txtSearchGroups.Padding = new Padding(5);
            txtSearchGroups.RectColor = Color.FromArgb(58, 63, 75);
            txtSearchGroups.RectDisableColor = Color.FromArgb(58, 63, 75);
            txtSearchGroups.RectReadOnlyColor = Color.FromArgb(58, 63, 75);
            txtSearchGroups.ScrollBarBackColor = Color.Transparent;
            txtSearchGroups.ScrollBarColor = Color.Transparent;
            txtSearchGroups.ScrollBarStyleInherited = false;
            txtSearchGroups.ShowButton = true;
            txtSearchGroups.ShowText = false;
            txtSearchGroups.Size = new Size(249, 30);
            txtSearchGroups.SymbolColor = Color.White;
            txtSearchGroups.TabIndex = 33;
            txtSearchGroups.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchGroups.Watermark = "Поиск по группам...";
            txtSearchGroups.WatermarkColor = Color.LightGray;
            // 
            // lblConnectedChatsCount
            // 
            lblConnectedChatsCount.AutoSize = true;
            lblConnectedChatsCount.BackColor = Color.Transparent;
            lblConnectedChatsCount.Font = new Font("Segoe UI", 8F);
            lblConnectedChatsCount.ForeColor = Color.FromArgb(156, 163, 175);
            lblConnectedChatsCount.ImeMode = ImeMode.NoControl;
            lblConnectedChatsCount.Location = new Point(8, 114);
            lblConnectedChatsCount.Name = "lblConnectedChatsCount";
            lblConnectedChatsCount.Size = new Size(83, 13);
            lblConnectedChatsCount.TabIndex = 32;
            lblConnectedChatsCount.Text = "Всего групп: 2";
            // 
            // TelegramGroupsControl
            // 
            BackColor = Color.FromArgb(27, 29, 36);
            Controls.Add(pnlConnectedGroups);
            Controls.Add(pnlGroupInfo);
            Controls.Add(pnlSendSettings);
            Name = "TelegramGroupsControl";
            Padding = new Padding(5);
            Size = new Size(976, 658);
            pnlGroupInfo.ResumeLayout(false);
            pnlSendSettings.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            grpHomePlaceholder.ResumeLayout(false);
            tabAuto.ResumeLayout(false);
            grpAutoPlaceholder.ResumeLayout(false);
            tabDelayed.ResumeLayout(false);
            grpDelayedPlaceholder.ResumeLayout(false);
            tabPeriodic.ResumeLayout(false);
            grpPeriodicPlaceholder.ResumeLayout(false);
            tabSchedule.ResumeLayout(false);
            grpSchedulePlaceholder.ResumeLayout(false);
            tabEvent.ResumeLayout(false);
            grpEventPlaceholder.ResumeLayout(false);
            tabPriority.ResumeLayout(false);
            grpPriorityPlaceholder.ResumeLayout(false);
            tabManual.ResumeLayout(false);
            grpManualPlaceholder.ResumeLayout(false);
            pnlConnectedGroups.ResumeLayout(false);
            pnlConnectedGroups.PerformLayout();
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlGroupInfo;
        private Sunny.UI.UIPanel pnlSendSettings;
        private Sunny.UI.UIPanel avatarPanel;
        private Label lblChannelNickname;
        private Label lblChannelName;
        private Label lblGroupId;
        private Label lblStatusLabel;
        private Sunny.UI.UIPanel pnlConnectedGroups;
        private Label lblConnectedChatsCount;
        private FontAwesome.Sharp.IconButton btnAddConnectedChat;
        private Label lblConnectedChatsTitle;
        private Label lblStatusValue;
        private Label lblGroupTypeLabel;
        private Label lblGroupTypeValue;
        private Label lblParticipantsValue;
        private Label lblParticipantsLabel;
        private Sunny.UI.UITextBox txtSearchGroups;
        private Label lblTgNewMassegeInfo;
        private FlowLayoutPanel flpConnectedChats;
        private Sunny.UI.UITabControl TabControl;
        private TabPage tabAuto;
        private TabPage tabDelayed;
        private TabPage tabPeriodic;
        private TabPage tabSchedule;
        private TabPage tabEvent;
        private TabPage tabPriority;
        private TabPage tabManual;
        private TabPage tabHome;
        private Sunny.UI.UIGroupBox grpHomePlaceholder;
        private Sunny.UI.UILabel lblHomeNoSelection;
        private Sunny.UI.UIGroupBox grpAutoPlaceholder;
        private Sunny.UI.UILabel lblAutoNoSelection;
        private Sunny.UI.UIGroupBox grpDelayedPlaceholder;
        private Sunny.UI.UILabel lblDelayedNoSelection;
        private Sunny.UI.UIGroupBox grpPeriodicPlaceholder;
        private Sunny.UI.UILabel lblPeriodicNoSelection;
        private Sunny.UI.UIGroupBox grpSchedulePlaceholder;
        private Sunny.UI.UILabel lblScheduleNoSelection;
        private Sunny.UI.UIGroupBox grpEventPlaceholder;
        private Sunny.UI.UILabel lblEventNoSelection;
        private Sunny.UI.UIGroupBox grpPriorityPlaceholder;
        private Sunny.UI.UILabel lblPriorityNoSelection;
        private Sunny.UI.UIGroupBox grpManualPlaceholder;
        private Sunny.UI.UILabel lblManualNoSelection;
    }
}