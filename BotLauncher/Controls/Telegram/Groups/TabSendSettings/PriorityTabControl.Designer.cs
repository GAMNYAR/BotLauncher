namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class PriorityTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriorityTabControl));
            grpPriority = new Sunny.UI.UIGroupBox();
            pnlPriorityButtons = new Sunny.UI.UIPanel();
            chkPriorityManualConfirm = new Sunny.UI.UICheckBox();
            btnSavePriority = new Sunny.UI.UIButton();
            btnStartPriority = new Sunny.UI.UIButton();
            pnlPriorityInner = new Panel();
            pnlPriorityContent = new Panel();
            grpPriorityHistory = new Sunny.UI.UIGroupBox();
            flpPriorityHistory = new FlowLayoutPanel();
            chkDeletePrevious = new Sunny.UI.UICheckBox();
            chkHideSpoiler = new Sunny.UI.UICheckBox();
            chkProtectContent = new Sunny.UI.UICheckBox();
            chkNoAuthorMention = new Sunny.UI.UICheckBox();
            chkSilentSend = new Sunny.UI.UICheckBox();
            chkDisablePreview = new Sunny.UI.UICheckBox();
            chkSendTemplateFirst = new Sunny.UI.UICheckBox();
            chkNotifyError = new Sunny.UI.UICheckBox();
            cmbNotifyError1 = new Sunny.UI.UIComboBox();
            lblNotifyErrorOr = new Label();
            cmbNotifyError2 = new Sunny.UI.UIComboBox();
            chkNotifyComplete = new Sunny.UI.UICheckBox();
            cmbNotifyComplete1 = new Sunny.UI.UIComboBox();
            lblNotifyCompleteOr = new Label();
            cmbNotifyComplete2 = new Sunny.UI.UIComboBox();
            chkNotifySuccess = new Sunny.UI.UICheckBox();
            cmbNotifySuccess1 = new Sunny.UI.UIComboBox();
            lblNotifySuccessOr = new Label();
            cmbNotifySuccess2 = new Sunny.UI.UIComboBox();
            grpPriorityLevels = new Sunny.UI.UIGroupBox();
            pnlPriorityLevels = new FlowLayoutPanel();
            btnAddPriorityLevel = new Sunny.UI.UIButton();
            cmbPriorityOverflow = new Sunny.UI.UIComboBox();
            lblPriorityOverflow = new Label();
            nudPriorityMaxQueue = new Sunny.UI.UIIntegerUpDown();
            lblPriorityQueueUnit = new Label();
            lblPriorityMaxQueue = new Label();
            lblPriorityTemplateHint = new Label();
            txtPriorityCustomText = new Sunny.UI.UITextBox();
            cmbPriorityTemplate = new Sunny.UI.UIComboBox();
            lblHighPriority = new Label();
            lblHighDelay = new Label();
            nudHighDelay = new Sunny.UI.UIIntegerUpDown();
            lblHighDelayUnit = new Label();
            lblHighMaxTime = new Label();
            nudHighMaxTime = new Sunny.UI.UIIntegerUpDown();
            cmbHighMaxTimeUnit = new Sunny.UI.UIComboBox();
            grpPriority.SuspendLayout();
            pnlPriorityButtons.SuspendLayout();
            pnlPriorityInner.SuspendLayout();
            pnlPriorityContent.SuspendLayout();
            grpPriorityHistory.SuspendLayout();
            grpPriorityLevels.SuspendLayout();
            SuspendLayout();
            // 
            // grpPriority
            // 
            grpPriority.BackColor = Color.FromArgb(35, 39, 48);
            grpPriority.Controls.Add(pnlPriorityButtons);
            grpPriority.Controls.Add(pnlPriorityInner);
            grpPriority.Dock = DockStyle.Fill;
            grpPriority.FillColor = Color.Transparent;
            grpPriority.FillColor2 = Color.Transparent;
            grpPriority.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpPriority.ForeColor = Color.White;
            grpPriority.Location = new Point(0, 0);
            grpPriority.Margin = new Padding(4, 5, 4, 5);
            grpPriority.MinimumSize = new Size(1, 1);
            grpPriority.Name = "grpPriority";
            grpPriority.Padding = new Padding(0, 32, 0, 0);
            grpPriority.Radius = 15;
            grpPriority.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpPriority.RectColor = Color.FromArgb(58, 58, 69);
            grpPriority.Size = new Size(696, 483);
            grpPriority.Style = Sunny.UI.UIStyle.Custom;
            grpPriority.TabIndex = 8;
            grpPriority.Text = "Настройки приоритетной отправки";
            grpPriority.TextAlignment = ContentAlignment.MiddleLeft;
            grpPriority.TitleInterval = 8;
            grpPriority.TitleTop = 14;
            // 
            // pnlPriorityButtons
            // 
            pnlPriorityButtons.Controls.Add(chkPriorityManualConfirm);
            pnlPriorityButtons.Controls.Add(btnSavePriority);
            pnlPriorityButtons.Controls.Add(btnStartPriority);
            pnlPriorityButtons.Dock = DockStyle.Bottom;
            pnlPriorityButtons.FillColor = Color.Transparent;
            pnlPriorityButtons.FillColor2 = Color.Transparent;
            pnlPriorityButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlPriorityButtons.ForeColor = Color.Transparent;
            pnlPriorityButtons.Location = new Point(0, 438);
            pnlPriorityButtons.Margin = new Padding(4, 5, 4, 5);
            pnlPriorityButtons.MinimumSize = new Size(1, 1);
            pnlPriorityButtons.Name = "pnlPriorityButtons";
            pnlPriorityButtons.Radius = 0;
            pnlPriorityButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlPriorityButtons.RectDisableColor = Color.Transparent;
            pnlPriorityButtons.Size = new Size(696, 45);
            pnlPriorityButtons.TabIndex = 23;
            pnlPriorityButtons.Text = null;
            pnlPriorityButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkPriorityManualConfirm
            // 
            chkPriorityManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkPriorityManualConfirm.BackColor = Color.Transparent;
            chkPriorityManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkPriorityManualConfirm.Checked = true;
            chkPriorityManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPriorityManualConfirm.ForeColor = Color.White;
            chkPriorityManualConfirm.Location = new Point(46, 10);
            chkPriorityManualConfirm.MinimumSize = new Size(1, 1);
            chkPriorityManualConfirm.Name = "chkPriorityManualConfirm";
            chkPriorityManualConfirm.Size = new Size(333, 25);
            chkPriorityManualConfirm.TabIndex = 27;
            chkPriorityManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSavePriority
            // 
            btnSavePriority.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSavePriority.FillColor = Color.BlueViolet;
            btnSavePriority.FillColor2 = Color.Transparent;
            btnSavePriority.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSavePriority.FillHoverColor = Color.DarkOrchid;
            btnSavePriority.FillPressColor = Color.DarkViolet;
            btnSavePriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSavePriority.Location = new Point(389, 5);
            btnSavePriority.MinimumSize = new Size(1, 1);
            btnSavePriority.Name = "btnSavePriority";
            btnSavePriority.Radius = 8;
            btnSavePriority.RectColor = Color.Transparent;
            btnSavePriority.Size = new Size(150, 35);
            btnSavePriority.Style = Sunny.UI.UIStyle.Custom;
            btnSavePriority.TabIndex = 13;
            btnSavePriority.Text = "Сохранить настройки";
            btnSavePriority.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnStartPriority
            // 
            btnStartPriority.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartPriority.FillColor = Color.Indigo;
            btnStartPriority.FillColor2 = Color.Transparent;
            btnStartPriority.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnStartPriority.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnStartPriority.FillPressColor = Color.FromArgb(109, 40, 217);
            btnStartPriority.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartPriority.Location = new Point(543, 5);
            btnStartPriority.MinimumSize = new Size(1, 1);
            btnStartPriority.Name = "btnStartPriority";
            btnStartPriority.Radius = 8;
            btnStartPriority.RectColor = Color.Transparent;
            btnStartPriority.Size = new Size(150, 35);
            btnStartPriority.Style = Sunny.UI.UIStyle.Custom;
            btnStartPriority.TabIndex = 14;
            btnStartPriority.Text = "Начать сеанс";
            btnStartPriority.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlPriorityInner
            // 
            pnlPriorityInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPriorityInner.AutoScroll = true;
            pnlPriorityInner.Controls.Add(pnlPriorityContent);
            pnlPriorityInner.Location = new Point(3, 25);
            pnlPriorityInner.Name = "pnlPriorityInner";
            pnlPriorityInner.Size = new Size(693, 413);
            pnlPriorityInner.TabIndex = 24;
            // 
            // pnlPriorityContent
            // 
            pnlPriorityContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlPriorityContent.Controls.Add(grpPriorityHistory);
            pnlPriorityContent.Controls.Add(chkDeletePrevious);
            pnlPriorityContent.Controls.Add(chkHideSpoiler);
            pnlPriorityContent.Controls.Add(chkProtectContent);
            pnlPriorityContent.Controls.Add(chkNoAuthorMention);
            pnlPriorityContent.Controls.Add(chkSilentSend);
            pnlPriorityContent.Controls.Add(chkDisablePreview);
            pnlPriorityContent.Controls.Add(chkSendTemplateFirst);
            pnlPriorityContent.Controls.Add(chkNotifyError);
            pnlPriorityContent.Controls.Add(cmbNotifyError1);
            pnlPriorityContent.Controls.Add(lblNotifyErrorOr);
            pnlPriorityContent.Controls.Add(cmbNotifyError2);
            pnlPriorityContent.Controls.Add(chkNotifyComplete);
            pnlPriorityContent.Controls.Add(cmbNotifyComplete1);
            pnlPriorityContent.Controls.Add(lblNotifyCompleteOr);
            pnlPriorityContent.Controls.Add(cmbNotifyComplete2);
            pnlPriorityContent.Controls.Add(chkNotifySuccess);
            pnlPriorityContent.Controls.Add(cmbNotifySuccess1);
            pnlPriorityContent.Controls.Add(lblNotifySuccessOr);
            pnlPriorityContent.Controls.Add(cmbNotifySuccess2);
            pnlPriorityContent.Controls.Add(grpPriorityLevels);
            pnlPriorityContent.Controls.Add(btnAddPriorityLevel);
            pnlPriorityContent.Controls.Add(cmbPriorityOverflow);
            pnlPriorityContent.Controls.Add(lblPriorityOverflow);
            pnlPriorityContent.Controls.Add(nudPriorityMaxQueue);
            pnlPriorityContent.Controls.Add(lblPriorityQueueUnit);
            pnlPriorityContent.Controls.Add(lblPriorityMaxQueue);
            pnlPriorityContent.Controls.Add(lblPriorityTemplateHint);
            pnlPriorityContent.Controls.Add(txtPriorityCustomText);
            pnlPriorityContent.Controls.Add(cmbPriorityTemplate);
            pnlPriorityContent.Location = new Point(0, 0);
            pnlPriorityContent.MinimumSize = new Size(673, 0);
            pnlPriorityContent.Name = "pnlPriorityContent";
            pnlPriorityContent.Padding = new Padding(9, 0, 9, 0);
            pnlPriorityContent.Size = new Size(676, 1330);
            pnlPriorityContent.TabIndex = 0;
            // 
            // grpPriorityHistory
            // 
            grpPriorityHistory.Controls.Add(flpPriorityHistory);
            grpPriorityHistory.FillColor = Color.Transparent;
            grpPriorityHistory.FillColor2 = Color.Transparent;
            grpPriorityHistory.FillDisableColor = Color.Transparent;
            grpPriorityHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPriorityHistory.ForeColor = SystemColors.ActiveBorder;
            grpPriorityHistory.ForeDisableColor = Color.Transparent;
            grpPriorityHistory.Location = new Point(9, 695);
            grpPriorityHistory.Margin = new Padding(4, 5, 4, 5);
            grpPriorityHistory.MinimumSize = new Size(1, 1);
            grpPriorityHistory.Name = "grpPriorityHistory";
            grpPriorityHistory.Padding = new Padding(5, 32, 5, 5);
            grpPriorityHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpPriorityHistory.RectDisableColor = Color.Transparent;
            grpPriorityHistory.Size = new Size(658, 290);
            grpPriorityHistory.TabIndex = 31;
            grpPriorityHistory.Text = "История отправок:";
            grpPriorityHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpPriorityHistory.TitleTop = 10;
            // 
            // flpPriorityHistory
            // 
            flpPriorityHistory.AutoScroll = true;
            flpPriorityHistory.FlowDirection = FlowDirection.TopDown;
            flpPriorityHistory.Location = new Point(10, 20);
            flpPriorityHistory.Name = "flpPriorityHistory";
            flpPriorityHistory.Size = new Size(636, 259);
            flpPriorityHistory.TabIndex = 10;
            flpPriorityHistory.WrapContents = false;
            // 
            // chkDeletePrevious
            // 
            chkDeletePrevious.BackColor = Color.Transparent;
            chkDeletePrevious.CheckBoxColor = Color.BlueViolet;
            chkDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDeletePrevious.ForeColor = Color.White;
            chkDeletePrevious.Location = new Point(9, 655);
            chkDeletePrevious.MinimumSize = new Size(1, 1);
            chkDeletePrevious.Name = "chkDeletePrevious";
            chkDeletePrevious.Size = new Size(346, 25);
            chkDeletePrevious.TabIndex = 111;
            chkDeletePrevious.Text = "Удалить предыдущее сообщение бота перед отправкой";
            // 
            // chkHideSpoiler
            // 
            chkHideSpoiler.BackColor = Color.Transparent;
            chkHideSpoiler.CheckBoxColor = Color.BlueViolet;
            chkHideSpoiler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkHideSpoiler.ForeColor = Color.White;
            chkHideSpoiler.Location = new Point(286, 625);
            chkHideSpoiler.MinimumSize = new Size(1, 1);
            chkHideSpoiler.Name = "chkHideSpoiler";
            chkHideSpoiler.Size = new Size(346, 25);
            chkHideSpoiler.TabIndex = 110;
            chkHideSpoiler.Text = "Скрыть содержимое как спойлер";
            // 
            // chkProtectContent
            // 
            chkProtectContent.BackColor = Color.Transparent;
            chkProtectContent.CheckBoxColor = Color.BlueViolet;
            chkProtectContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkProtectContent.ForeColor = Color.White;
            chkProtectContent.Location = new Point(9, 625);
            chkProtectContent.MinimumSize = new Size(1, 1);
            chkProtectContent.Name = "chkProtectContent";
            chkProtectContent.Size = new Size(264, 25);
            chkProtectContent.TabIndex = 109;
            chkProtectContent.Text = "Защитить от копирования и пересылки";
            // 
            // chkNoAuthorMention
            // 
            chkNoAuthorMention.BackColor = Color.Transparent;
            chkNoAuthorMention.CheckBoxColor = Color.BlueViolet;
            chkNoAuthorMention.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNoAuthorMention.ForeColor = Color.White;
            chkNoAuthorMention.Location = new Point(286, 595);
            chkNoAuthorMention.MinimumSize = new Size(1, 1);
            chkNoAuthorMention.Name = "chkNoAuthorMention";
            chkNoAuthorMention.Size = new Size(346, 25);
            chkNoAuthorMention.TabIndex = 108;
            chkNoAuthorMention.Text = "Отправить без упоминания автора (как своё)";
            // 
            // chkSilentSend
            // 
            chkSilentSend.BackColor = Color.Transparent;
            chkSilentSend.CheckBoxColor = Color.BlueViolet;
            chkSilentSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSilentSend.ForeColor = Color.White;
            chkSilentSend.Location = new Point(9, 595);
            chkSilentSend.MinimumSize = new Size(1, 1);
            chkSilentSend.Name = "chkSilentSend";
            chkSilentSend.Size = new Size(264, 25);
            chkSilentSend.TabIndex = 106;
            chkSilentSend.Text = "Тихая отправка (без звука)";
            // 
            // chkDisablePreview
            // 
            chkDisablePreview.BackColor = Color.Transparent;
            chkDisablePreview.CheckBoxColor = Color.BlueViolet;
            chkDisablePreview.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDisablePreview.ForeColor = Color.White;
            chkDisablePreview.Location = new Point(286, 565);
            chkDisablePreview.MinimumSize = new Size(1, 1);
            chkDisablePreview.Name = "chkDisablePreview";
            chkDisablePreview.Size = new Size(346, 25);
            chkDisablePreview.TabIndex = 105;
            chkDisablePreview.Text = "Отключить предпросмотр ссылок";
            // 
            // chkSendTemplateFirst
            // 
            chkSendTemplateFirst.BackColor = Color.Transparent;
            chkSendTemplateFirst.CheckBoxColor = Color.BlueViolet;
            chkSendTemplateFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSendTemplateFirst.ForeColor = Color.White;
            chkSendTemplateFirst.Location = new Point(9, 565);
            chkSendTemplateFirst.MinimumSize = new Size(1, 1);
            chkSendTemplateFirst.Name = "chkSendTemplateFirst";
            chkSendTemplateFirst.Size = new Size(264, 25);
            chkSendTemplateFirst.TabIndex = 104;
            chkSendTemplateFirst.Text = "Отправить первым шаблон";
            // 
            // chkNotifyError
            // 
            chkNotifyError.BackColor = Color.Transparent;
            chkNotifyError.CheckBoxColor = Color.BlueViolet;
            chkNotifyError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyError.ForeColor = Color.White;
            chkNotifyError.Location = new Point(9, 520);
            chkNotifyError.MinimumSize = new Size(1, 1);
            chkNotifyError.Name = "chkNotifyError";
            chkNotifyError.Size = new Size(265, 25);
            chkNotifyError.TabIndex = 88;
            chkNotifyError.Text = "Уведомлять любую ошибку в:";
            // 
            // cmbNotifyError1
            // 
            cmbNotifyError1.DataSource = null;
            cmbNotifyError1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotifyError1.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyError1.Font = new Font("Segoe UI", 9F);
            cmbNotifyError1.ForeColor = Color.White;
            cmbNotifyError1.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyError1.ItemForeColor = Color.White;
            cmbNotifyError1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotifyError1.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotifyError1.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotifyError1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotifyError1.ItemSelectForeColor = Color.White;
            cmbNotifyError1.Location = new Point(290, 520);
            cmbNotifyError1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyError1.MinimumSize = new Size(63, 0);
            cmbNotifyError1.Name = "cmbNotifyError1";
            cmbNotifyError1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyError1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyError1.Size = new Size(146, 25);
            cmbNotifyError1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyError1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyError1.SymbolSize = 24;
            cmbNotifyError1.TabIndex = 82;
            cmbNotifyError1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError1.Watermark = "Куда отправить";
            // 
            // lblNotifyErrorOr
            // 
            lblNotifyErrorOr.AutoSize = true;
            lblNotifyErrorOr.BackColor = Color.Transparent;
            lblNotifyErrorOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyErrorOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyErrorOr.Location = new Point(442, 525);
            lblNotifyErrorOr.Name = "lblNotifyErrorOr";
            lblNotifyErrorOr.Size = new Size(39, 13);
            lblNotifyErrorOr.TabIndex = 91;
            lblNotifyErrorOr.Text = "и/или";
            // 
            // cmbNotifyError2
            // 
            cmbNotifyError2.DataSource = null;
            cmbNotifyError2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotifyError2.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyError2.Font = new Font("Segoe UI", 9F);
            cmbNotifyError2.ForeColor = Color.White;
            cmbNotifyError2.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyError2.ItemForeColor = Color.White;
            cmbNotifyError2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotifyError2.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotifyError2.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotifyError2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotifyError2.ItemSelectForeColor = Color.White;
            cmbNotifyError2.Location = new Point(489, 520);
            cmbNotifyError2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyError2.MinimumSize = new Size(63, 0);
            cmbNotifyError2.Name = "cmbNotifyError2";
            cmbNotifyError2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyError2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyError2.Size = new Size(146, 25);
            cmbNotifyError2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyError2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyError2.SymbolSize = 24;
            cmbNotifyError2.TabIndex = 85;
            cmbNotifyError2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError2.Watermark = "Куда отправить";
            // 
            // chkNotifyComplete
            // 
            chkNotifyComplete.BackColor = Color.Transparent;
            chkNotifyComplete.CheckBoxColor = Color.BlueViolet;
            chkNotifyComplete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyComplete.ForeColor = Color.White;
            chkNotifyComplete.Location = new Point(9, 490);
            chkNotifyComplete.MinimumSize = new Size(1, 1);
            chkNotifyComplete.Name = "chkNotifyComplete";
            chkNotifyComplete.Size = new Size(265, 25);
            chkNotifyComplete.TabIndex = 81;
            chkNotifyComplete.Text = "Уведомить при завершении сессии в:";
            // 
            // cmbNotifyComplete1
            // 
            cmbNotifyComplete1.DataSource = null;
            cmbNotifyComplete1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotifyComplete1.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyComplete1.Font = new Font("Segoe UI", 9F);
            cmbNotifyComplete1.ForeColor = Color.White;
            cmbNotifyComplete1.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyComplete1.ItemForeColor = Color.White;
            cmbNotifyComplete1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotifyComplete1.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotifyComplete1.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotifyComplete1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotifyComplete1.ItemSelectForeColor = Color.White;
            cmbNotifyComplete1.Location = new Point(290, 490);
            cmbNotifyComplete1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete1.MinimumSize = new Size(63, 0);
            cmbNotifyComplete1.Name = "cmbNotifyComplete1";
            cmbNotifyComplete1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete1.Size = new Size(146, 25);
            cmbNotifyComplete1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete1.SymbolSize = 24;
            cmbNotifyComplete1.TabIndex = 84;
            cmbNotifyComplete1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete1.Watermark = "Куда отправить";
            // 
            // lblNotifyCompleteOr
            // 
            lblNotifyCompleteOr.AutoSize = true;
            lblNotifyCompleteOr.BackColor = Color.Transparent;
            lblNotifyCompleteOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyCompleteOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyCompleteOr.Location = new Point(442, 495);
            lblNotifyCompleteOr.Name = "lblNotifyCompleteOr";
            lblNotifyCompleteOr.Size = new Size(39, 13);
            lblNotifyCompleteOr.TabIndex = 90;
            lblNotifyCompleteOr.Text = "и/или";
            // 
            // cmbNotifyComplete2
            // 
            cmbNotifyComplete2.DataSource = null;
            cmbNotifyComplete2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotifyComplete2.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyComplete2.Font = new Font("Segoe UI", 9F);
            cmbNotifyComplete2.ForeColor = Color.White;
            cmbNotifyComplete2.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotifyComplete2.ItemForeColor = Color.White;
            cmbNotifyComplete2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotifyComplete2.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotifyComplete2.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotifyComplete2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotifyComplete2.ItemSelectForeColor = Color.White;
            cmbNotifyComplete2.Location = new Point(489, 490);
            cmbNotifyComplete2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete2.MinimumSize = new Size(63, 0);
            cmbNotifyComplete2.Name = "cmbNotifyComplete2";
            cmbNotifyComplete2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete2.Size = new Size(146, 25);
            cmbNotifyComplete2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete2.SymbolSize = 24;
            cmbNotifyComplete2.TabIndex = 87;
            cmbNotifyComplete2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete2.Watermark = "Куда отправить";
            // 
            // chkNotifySuccess
            // 
            chkNotifySuccess.BackColor = Color.Transparent;
            chkNotifySuccess.CheckBoxColor = Color.BlueViolet;
            chkNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifySuccess.ForeColor = Color.White;
            chkNotifySuccess.Location = new Point(9, 460);
            chkNotifySuccess.MinimumSize = new Size(1, 1);
            chkNotifySuccess.Name = "chkNotifySuccess";
            chkNotifySuccess.Size = new Size(265, 25);
            chkNotifySuccess.TabIndex = 80;
            chkNotifySuccess.Text = "Уведомлять все успешные отправки в:";
            // 
            // cmbNotifySuccess1
            // 
            cmbNotifySuccess1.DataSource = null;
            cmbNotifySuccess1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotifySuccess1.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotifySuccess1.Font = new Font("Segoe UI", 9F);
            cmbNotifySuccess1.ForeColor = Color.White;
            cmbNotifySuccess1.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotifySuccess1.ItemForeColor = Color.White;
            cmbNotifySuccess1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotifySuccess1.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotifySuccess1.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotifySuccess1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotifySuccess1.ItemSelectForeColor = Color.White;
            cmbNotifySuccess1.Location = new Point(290, 460);
            cmbNotifySuccess1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifySuccess1.MinimumSize = new Size(63, 0);
            cmbNotifySuccess1.Name = "cmbNotifySuccess1";
            cmbNotifySuccess1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifySuccess1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifySuccess1.Size = new Size(146, 25);
            cmbNotifySuccess1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifySuccess1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifySuccess1.SymbolSize = 24;
            cmbNotifySuccess1.TabIndex = 83;
            cmbNotifySuccess1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifySuccess1.Watermark = "Куда отправить";
            // 
            // lblNotifySuccessOr
            // 
            lblNotifySuccessOr.AutoSize = true;
            lblNotifySuccessOr.BackColor = Color.Transparent;
            lblNotifySuccessOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifySuccessOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifySuccessOr.Location = new Point(442, 465);
            lblNotifySuccessOr.Name = "lblNotifySuccessOr";
            lblNotifySuccessOr.Size = new Size(39, 13);
            lblNotifySuccessOr.TabIndex = 89;
            lblNotifySuccessOr.Text = "и/или";
            // 
            // cmbNotifySuccess2
            // 
            cmbNotifySuccess2.DataSource = null;
            cmbNotifySuccess2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbNotifySuccess2.FillColor = Color.FromArgb(42, 46, 57);
            cmbNotifySuccess2.Font = new Font("Segoe UI", 9F);
            cmbNotifySuccess2.ForeColor = Color.White;
            cmbNotifySuccess2.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbNotifySuccess2.ItemForeColor = Color.White;
            cmbNotifySuccess2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbNotifySuccess2.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbNotifySuccess2.Items.AddRange(new object[] { "В личные сообщения", "В отдельный чат", "В приложении" });
            cmbNotifySuccess2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbNotifySuccess2.ItemSelectForeColor = Color.White;
            cmbNotifySuccess2.Location = new Point(489, 460);
            cmbNotifySuccess2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifySuccess2.MinimumSize = new Size(63, 0);
            cmbNotifySuccess2.Name = "cmbNotifySuccess2";
            cmbNotifySuccess2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifySuccess2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifySuccess2.Size = new Size(146, 25);
            cmbNotifySuccess2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifySuccess2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifySuccess2.SymbolSize = 24;
            cmbNotifySuccess2.TabIndex = 86;
            cmbNotifySuccess2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifySuccess2.Watermark = "Куда отправить";
            // 
            // grpPriorityLevels
            // 
            grpPriorityLevels.Controls.Add(pnlPriorityLevels);
            grpPriorityLevels.FillColor = Color.Transparent;
            grpPriorityLevels.FillColor2 = Color.Transparent;
            grpPriorityLevels.FillDisableColor = Color.Transparent;
            grpPriorityLevels.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPriorityLevels.ForeColor = SystemColors.ActiveBorder;
            grpPriorityLevels.ForeDisableColor = Color.Transparent;
            grpPriorityLevels.Location = new Point(9, 210);
            grpPriorityLevels.Margin = new Padding(4, 5, 4, 5);
            grpPriorityLevels.MinimumSize = new Size(1, 1);
            grpPriorityLevels.Name = "grpPriorityLevels";
            grpPriorityLevels.Padding = new Padding(5, 32, 5, 5);
            grpPriorityLevels.RectColor = Color.FromArgb(58, 58, 69);
            grpPriorityLevels.RectDisableColor = Color.Transparent;
            grpPriorityLevels.Size = new Size(658, 200);
            grpPriorityLevels.TabIndex = 31;
            grpPriorityLevels.Text = "Уровни приоритета (динамически добавляются)";
            grpPriorityLevels.TextAlignment = ContentAlignment.MiddleLeft;
            grpPriorityLevels.TitleTop = 10;
            // 
            // pnlPriorityLevels
            // 
            pnlPriorityLevels.AutoScroll = true;
            pnlPriorityLevels.Dock = DockStyle.Fill;
            pnlPriorityLevels.FlowDirection = FlowDirection.TopDown;
            pnlPriorityLevels.Location = new Point(5, 32);
            pnlPriorityLevels.Name = "pnlPriorityLevels";
            pnlPriorityLevels.Size = new Size(648, 163);
            pnlPriorityLevels.TabIndex = 10;
            pnlPriorityLevels.WrapContents = false;
            // 
            // btnAddPriorityLevel
            // 
            btnAddPriorityLevel.FillColor = Color.BlueViolet;
            btnAddPriorityLevel.FillColor2 = Color.Transparent;
            btnAddPriorityLevel.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnAddPriorityLevel.FillHoverColor = Color.DarkOrchid;
            btnAddPriorityLevel.FillPressColor = Color.DarkViolet;
            btnAddPriorityLevel.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            btnAddPriorityLevel.Location = new Point(9, 420);
            btnAddPriorityLevel.MinimumSize = new Size(1, 1);
            btnAddPriorityLevel.Name = "btnAddPriorityLevel";
            btnAddPriorityLevel.Radius = 8;
            btnAddPriorityLevel.RectColor = Color.Transparent;
            btnAddPriorityLevel.Size = new Size(200, 25);
            btnAddPriorityLevel.Style = Sunny.UI.UIStyle.Custom;
            btnAddPriorityLevel.TabIndex = 72;
            btnAddPriorityLevel.Text = "+ Добавить уровень приоритета";
            btnAddPriorityLevel.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // cmbPriorityOverflow
            // 
            cmbPriorityOverflow.DataSource = null;
            cmbPriorityOverflow.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPriorityOverflow.FillColor = Color.FromArgb(42, 46, 57);
            cmbPriorityOverflow.Font = new Font("Segoe UI", 9F);
            cmbPriorityOverflow.ForeColor = Color.White;
            cmbPriorityOverflow.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPriorityOverflow.ItemForeColor = Color.White;
            cmbPriorityOverflow.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPriorityOverflow.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPriorityOverflow.Items.AddRange(new object[] { "Ожидать освобождения места", "Отклонять новые сообщения", "Заменять самое старое", "Заменять самое новое" });
            cmbPriorityOverflow.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPriorityOverflow.ItemSelectForeColor = Color.White;
            cmbPriorityOverflow.Location = new Point(178, 175);
            cmbPriorityOverflow.Margin = new Padding(4, 5, 4, 5);
            cmbPriorityOverflow.MinimumSize = new Size(63, 0);
            cmbPriorityOverflow.Name = "cmbPriorityOverflow";
            cmbPriorityOverflow.Padding = new Padding(0, 0, 30, 2);
            cmbPriorityOverflow.RectColor = Color.FromArgb(65, 71, 84);
            cmbPriorityOverflow.Size = new Size(280, 25);
            cmbPriorityOverflow.Style = Sunny.UI.UIStyle.Custom;
            cmbPriorityOverflow.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPriorityOverflow.SymbolSize = 24;
            cmbPriorityOverflow.TabIndex = 66;
            cmbPriorityOverflow.Text = "Заменять самое старое";
            cmbPriorityOverflow.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPriorityOverflow.Watermark = "";
            // 
            // lblPriorityOverflow
            // 
            lblPriorityOverflow.AutoSize = true;
            lblPriorityOverflow.BackColor = Color.Transparent;
            lblPriorityOverflow.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPriorityOverflow.ForeColor = Color.FromArgb(180, 180, 180);
            lblPriorityOverflow.Location = new Point(9, 180);
            lblPriorityOverflow.Name = "lblPriorityOverflow";
            lblPriorityOverflow.Size = new Size(163, 13);
            lblPriorityOverflow.TabIndex = 63;
            lblPriorityOverflow.Text = "При переполнении очереди:";
            // 
            // nudPriorityMaxQueue
            // 
            nudPriorityMaxQueue.FillColor = Color.FromArgb(42, 46, 57);
            nudPriorityMaxQueue.Font = new Font("Segoe UI", 9.75F);
            nudPriorityMaxQueue.ForeColor = Color.White;
            nudPriorityMaxQueue.Location = new Point(145, 138);
            nudPriorityMaxQueue.Margin = new Padding(4, 5, 4, 5);
            nudPriorityMaxQueue.Maximum = 10000D;
            nudPriorityMaxQueue.Minimum = 0D;
            nudPriorityMaxQueue.MinimumSize = new Size(1, 16);
            nudPriorityMaxQueue.Name = "nudPriorityMaxQueue";
            nudPriorityMaxQueue.Padding = new Padding(5);
            nudPriorityMaxQueue.RectColor = Color.FromArgb(65, 71, 84);
            nudPriorityMaxQueue.RectHoverColor = Color.BlueViolet;
            nudPriorityMaxQueue.RectPressColor = Color.Indigo;
            nudPriorityMaxQueue.ShowText = false;
            nudPriorityMaxQueue.Size = new Size(100, 25);
            nudPriorityMaxQueue.TabIndex = 61;
            nudPriorityMaxQueue.Text = "0";
            nudPriorityMaxQueue.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblPriorityQueueUnit
            // 
            lblPriorityQueueUnit.AutoSize = true;
            lblPriorityQueueUnit.BackColor = Color.Transparent;
            lblPriorityQueueUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPriorityQueueUnit.ForeColor = Color.FromArgb(180, 180, 180);
            lblPriorityQueueUnit.Location = new Point(251, 143);
            lblPriorityQueueUnit.Name = "lblPriorityQueueUnit";
            lblPriorityQueueUnit.Size = new Size(72, 13);
            lblPriorityQueueUnit.TabIndex = 62;
            lblPriorityQueueUnit.Text = "сообщений.";
            // 
            // lblPriorityMaxQueue
            // 
            lblPriorityMaxQueue.AutoSize = true;
            lblPriorityMaxQueue.BackColor = Color.Transparent;
            lblPriorityMaxQueue.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPriorityMaxQueue.ForeColor = Color.FromArgb(180, 180, 180);
            lblPriorityMaxQueue.Location = new Point(9, 143);
            lblPriorityMaxQueue.Name = "lblPriorityMaxQueue";
            lblPriorityMaxQueue.Size = new Size(130, 13);
            lblPriorityMaxQueue.TabIndex = 52;
            lblPriorityMaxQueue.Text = "Макс. размер очереди:";
            // 
            // lblPriorityTemplateHint
            // 
            lblPriorityTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblPriorityTemplateHint.ForeColor = Color.DarkGray;
            lblPriorityTemplateHint.Location = new Point(9, 69);
            lblPriorityTemplateHint.Name = "lblPriorityTemplateHint";
            lblPriorityTemplateHint.Size = new Size(658, 55);
            lblPriorityTemplateHint.TabIndex = 30;
            lblPriorityTemplateHint.Text = resources.GetString("lblPriorityTemplateHint.Text");
            // 
            // txtPriorityCustomText
            // 
            txtPriorityCustomText.ButtonFillColor = Color.Transparent;
            txtPriorityCustomText.ButtonStyleInherited = false;
            txtPriorityCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtPriorityCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPriorityCustomText.ForeColor = Color.White;
            txtPriorityCustomText.Location = new Point(9, 40);
            txtPriorityCustomText.Margin = new Padding(4, 5, 4, 5);
            txtPriorityCustomText.MinimumSize = new Size(1, 16);
            txtPriorityCustomText.Name = "txtPriorityCustomText";
            txtPriorityCustomText.Padding = new Padding(5);
            txtPriorityCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtPriorityCustomText.ShowText = false;
            txtPriorityCustomText.Size = new Size(658, 25);
            txtPriorityCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtPriorityCustomText.TabIndex = 29;
            txtPriorityCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtPriorityCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbPriorityTemplate
            // 
            cmbPriorityTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPriorityTemplate.DataSource = null;
            cmbPriorityTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPriorityTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbPriorityTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbPriorityTemplate.ForeColor = Color.White;
            cmbPriorityTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbPriorityTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbPriorityTemplate.Location = new Point(9, 9);
            cmbPriorityTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbPriorityTemplate.MinimumSize = new Size(63, 0);
            cmbPriorityTemplate.Name = "cmbPriorityTemplate";
            cmbPriorityTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbPriorityTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbPriorityTemplate.Size = new Size(658, 25);
            cmbPriorityTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbPriorityTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPriorityTemplate.SymbolSize = 24;
            cmbPriorityTemplate.TabIndex = 28;
            cmbPriorityTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPriorityTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // lblHighPriority
            // 
            lblHighPriority.AutoSize = true;
            lblHighPriority.BackColor = Color.Transparent;
            lblHighPriority.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHighPriority.ForeColor = Color.FromArgb(180, 180, 180);
            lblHighPriority.Location = new Point(9, 220);
            lblHighPriority.Name = "lblHighPriority";
            lblHighPriority.Size = new Size(183, 15);
            lblHighPriority.TabIndex = 67;
            lblHighPriority.Text = "ВЫСОКИЙ ПРИОРИТЕТ (срочные)";
            lblHighPriority.Visible = false;
            // 
            // lblHighDelay
            // 
            lblHighDelay.AutoSize = true;
            lblHighDelay.BackColor = Color.Transparent;
            lblHighDelay.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblHighDelay.ForeColor = Color.FromArgb(180, 180, 180);
            lblHighDelay.Location = new Point(9, 245);
            lblHighDelay.Name = "lblHighDelay";
            lblHighDelay.Size = new Size(62, 13);
            lblHighDelay.TabIndex = 68;
            lblHighDelay.Text = "Задержка:";
            lblHighDelay.Visible = false;
            // 
            // nudHighDelay
            // 
            nudHighDelay.FillColor = Color.FromArgb(42, 46, 57);
            nudHighDelay.Font = new Font("Segoe UI", 9.75F);
            nudHighDelay.ForeColor = Color.White;
            nudHighDelay.Location = new Point(77, 240);
            nudHighDelay.Margin = new Padding(4, 5, 4, 5);
            nudHighDelay.Maximum = 10000D;
            nudHighDelay.Minimum = 0D;
            nudHighDelay.MinimumSize = new Size(1, 16);
            nudHighDelay.Name = "nudHighDelay";
            nudHighDelay.Padding = new Padding(5);
            nudHighDelay.RectColor = Color.FromArgb(65, 71, 84);
            nudHighDelay.RectHoverColor = Color.BlueViolet;
            nudHighDelay.RectPressColor = Color.Indigo;
            nudHighDelay.ShowText = false;
            nudHighDelay.Size = new Size(100, 25);
            nudHighDelay.TabIndex = 62;
            nudHighDelay.Text = "0";
            nudHighDelay.TextAlignment = ContentAlignment.MiddleCenter;
            nudHighDelay.Visible = false;
            // 
            // lblHighDelayUnit
            // 
            lblHighDelayUnit.AutoSize = true;
            lblHighDelayUnit.BackColor = Color.Transparent;
            lblHighDelayUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblHighDelayUnit.ForeColor = Color.FromArgb(180, 180, 180);
            lblHighDelayUnit.Location = new Point(183, 245);
            lblHighDelayUnit.Name = "lblHighDelayUnit";
            lblHighDelayUnit.Size = new Size(24, 13);
            lblHighDelayUnit.TabIndex = 69;
            lblHighDelayUnit.Text = "сек";
            lblHighDelayUnit.Visible = false;
            // 
            // lblHighMaxTime
            // 
            lblHighMaxTime.AutoSize = true;
            lblHighMaxTime.BackColor = Color.Transparent;
            lblHighMaxTime.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblHighMaxTime.ForeColor = Color.FromArgb(180, 180, 180);
            lblHighMaxTime.Location = new Point(230, 245);
            lblHighMaxTime.Name = "lblHighMaxTime";
            lblHighMaxTime.Size = new Size(133, 13);
            lblHighMaxTime.TabIndex = 70;
            lblHighMaxTime.Text = "Макс. время в очереди:";
            lblHighMaxTime.Visible = false;
            // 
            // nudHighMaxTime
            // 
            nudHighMaxTime.FillColor = Color.FromArgb(42, 46, 57);
            nudHighMaxTime.Font = new Font("Segoe UI", 9.75F);
            nudHighMaxTime.ForeColor = Color.White;
            nudHighMaxTime.Location = new Point(369, 240);
            nudHighMaxTime.Margin = new Padding(4, 5, 4, 5);
            nudHighMaxTime.Maximum = 10000D;
            nudHighMaxTime.Minimum = 0D;
            nudHighMaxTime.MinimumSize = new Size(1, 16);
            nudHighMaxTime.Name = "nudHighMaxTime";
            nudHighMaxTime.Padding = new Padding(5);
            nudHighMaxTime.RectColor = Color.FromArgb(65, 71, 84);
            nudHighMaxTime.RectHoverColor = Color.BlueViolet;
            nudHighMaxTime.RectPressColor = Color.Indigo;
            nudHighMaxTime.ShowText = false;
            nudHighMaxTime.Size = new Size(100, 25);
            nudHighMaxTime.TabIndex = 63;
            nudHighMaxTime.Text = "0";
            nudHighMaxTime.TextAlignment = ContentAlignment.MiddleCenter;
            nudHighMaxTime.Visible = false;
            // 
            // cmbHighMaxTimeUnit
            // 
            cmbHighMaxTimeUnit.DataSource = null;
            cmbHighMaxTimeUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbHighMaxTimeUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbHighMaxTimeUnit.Font = new Font("Segoe UI", 9F);
            cmbHighMaxTimeUnit.ForeColor = Color.White;
            cmbHighMaxTimeUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbHighMaxTimeUnit.ItemForeColor = Color.White;
            cmbHighMaxTimeUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbHighMaxTimeUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbHighMaxTimeUnit.Items.AddRange(new object[] { "секунд", "минут", "часов" });
            cmbHighMaxTimeUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbHighMaxTimeUnit.ItemSelectForeColor = Color.White;
            cmbHighMaxTimeUnit.Location = new Point(475, 240);
            cmbHighMaxTimeUnit.Margin = new Padding(4, 5, 4, 5);
            cmbHighMaxTimeUnit.MinimumSize = new Size(63, 0);
            cmbHighMaxTimeUnit.Name = "cmbHighMaxTimeUnit";
            cmbHighMaxTimeUnit.Padding = new Padding(0, 0, 30, 2);
            cmbHighMaxTimeUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbHighMaxTimeUnit.Size = new Size(73, 25);
            cmbHighMaxTimeUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbHighMaxTimeUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbHighMaxTimeUnit.SymbolSize = 24;
            cmbHighMaxTimeUnit.TabIndex = 71;
            cmbHighMaxTimeUnit.Text = "секунд";
            cmbHighMaxTimeUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbHighMaxTimeUnit.Visible = false;
            cmbHighMaxTimeUnit.Watermark = "";
            // 
            // PriorityTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpPriority);
            Name = "PriorityTabControl";
            Size = new Size(696, 483);
            grpPriority.ResumeLayout(false);
            pnlPriorityButtons.ResumeLayout(false);
            pnlPriorityInner.ResumeLayout(false);
            pnlPriorityContent.ResumeLayout(false);
            pnlPriorityContent.PerformLayout();
            grpPriorityHistory.ResumeLayout(false);
            grpPriorityLevels.ResumeLayout(false);
            ResumeLayout(false);
        }


        private Sunny.UI.UIGroupBox grpPriority;
        private Sunny.UI.UIPanel pnlPriorityButtons;
        private Sunny.UI.UICheckBox chkPriorityManualConfirm;
        private Sunny.UI.UIButton btnSavePriority;
        private Sunny.UI.UIButton btnStartPriority;
        private Panel pnlPriorityInner;
        private Panel pnlPriorityContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbPriorityTemplate;
        private Sunny.UI.UITextBox txtPriorityCustomText;
        private Label lblPriorityTemplateHint;

        // Queue Settings
        private Label lblPriorityMaxQueue;
        private Sunny.UI.UIIntegerUpDown nudPriorityMaxQueue;
        private Label lblPriorityQueueUnit;
        private Label lblPriorityOverflow;
        private Sunny.UI.UIComboBox cmbPriorityOverflow;

        // Priority Levels (Expandable)
        private Sunny.UI.UIGroupBox grpPriorityLevels;
        private FlowLayoutPanel pnlPriorityLevels;
        private Sunny.UI.UIButton btnAddPriorityLevel;

        // High Priority (default, can be moved to FlowLayoutPanel at runtime)
        private Label lblHighPriority;
        private Label lblHighDelay;
        private Sunny.UI.UIIntegerUpDown nudHighDelay;
        private Label lblHighDelayUnit;
        private Label lblHighMaxTime;
        private Sunny.UI.UIIntegerUpDown nudHighMaxTime;
        private Sunny.UI.UIComboBox cmbHighMaxTimeUnit;

        // Notifications
        private Sunny.UI.UICheckBox chkNotifySuccess;
        private Sunny.UI.UIComboBox cmbNotifySuccess1;
        private Label lblNotifySuccessOr;
        private Sunny.UI.UIComboBox cmbNotifySuccess2;
        private Sunny.UI.UICheckBox chkNotifyComplete;
        private Sunny.UI.UIComboBox cmbNotifyComplete1;
        private Label lblNotifyCompleteOr;
        private Sunny.UI.UIComboBox cmbNotifyComplete2;
        private Sunny.UI.UICheckBox chkNotifyError;
        private Sunny.UI.UIComboBox cmbNotifyError1;
        private Label lblNotifyErrorOr;
        private Sunny.UI.UIComboBox cmbNotifyError2;

        // Advanced Options
        private Sunny.UI.UICheckBox chkSendTemplateFirst;
        private Sunny.UI.UICheckBox chkDisablePreview;
        private Sunny.UI.UICheckBox chkSilentSend;
        private Sunny.UI.UICheckBox chkNoAuthorMention;
        private Sunny.UI.UICheckBox chkProtectContent;
        private Sunny.UI.UICheckBox chkHideSpoiler;
        private Sunny.UI.UICheckBox chkDeletePrevious;

        // History
        private Sunny.UI.UIGroupBox grpPriorityHistory;
        private FlowLayoutPanel flpPriorityHistory;
    }
}