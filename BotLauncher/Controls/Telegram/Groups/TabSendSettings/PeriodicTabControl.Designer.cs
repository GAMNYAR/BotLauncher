namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class PeriodicTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodicTabControl));
            grpPeriodic = new Sunny.UI.UIGroupBox();
            pnlPeriodButtons = new Sunny.UI.UIPanel();
            chkPeriodicManualConfirm = new Sunny.UI.UICheckBox();
            btnSavePeriodic = new Sunny.UI.UIButton();
            btnStartPeriodic = new Sunny.UI.UIButton();
            pnlPeriodInner = new Panel();
            pnlPeriodContent = new Panel();
            grpPeriodHistory = new Sunny.UI.UIGroupBox();
            flpPeriodHistory = new FlowLayoutPanel();
            chkDeletePrevious = new Sunny.UI.UICheckBox();
            chkHideSpoiler = new Sunny.UI.UICheckBox();
            chkProtectContent = new Sunny.UI.UICheckBox();
            chkSkipIfInactive = new Sunny.UI.UICheckBox();
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
            cmbPeriodTimezone = new Sunny.UI.UIComboBox();
            lblPeriodTimezone = new Label();
            nudPeriodPause = new Sunny.UI.UIIntegerUpDown();
            cmbPeriodPauseUnit = new Sunny.UI.UIComboBox();
            lblPeriodPause = new Label();
            nudPeriodRetry = new Sunny.UI.UIIntegerUpDown();
            lblPeriodRetryUnit = new Label();
            lblPeriodRetry = new Label();
            nudPeriodMaxSends = new Sunny.UI.UIIntegerUpDown();
            lblPeriodMaxHint = new Label();
            lblPeriodMaxSends = new Label();
            cmbPeriodRandomUnit = new Sunny.UI.UIComboBox();
            nudPeriodRandomMax = new Sunny.UI.UIIntegerUpDown();
            lblPeriodRandomTo = new Label();
            nudPeriodRandomMin = new Sunny.UI.UIIntegerUpDown();
            chkPeriodRandomTime = new Sunny.UI.UICheckBox();
            txtPeriodMonthDays = new Sunny.UI.UITextBox();
            lblPeriodMonthDays = new Label();
            chkPeriodDaySun = new Sunny.UI.UICheckBox();
            chkPeriodDaySat = new Sunny.UI.UICheckBox();
            chkPeriodDayFri = new Sunny.UI.UICheckBox();
            chkPeriodDayThu = new Sunny.UI.UICheckBox();
            chkPeriodDayWed = new Sunny.UI.UICheckBox();
            chkPeriodDayTue = new Sunny.UI.UICheckBox();
            chkPeriodDayMon = new Sunny.UI.UICheckBox();
            lblPeriodDays = new Label();
            cmbPeriodCustomUnit = new Sunny.UI.UIComboBox();
            nudPeriodCustomCount = new Sunny.UI.UIIntegerUpDown();
            lblPeriodCustomCount = new Label();
            cmbPeriodIntervalUnit = new Sunny.UI.UIComboBox();
            nudPeriodInterval = new Sunny.UI.UIIntegerUpDown();
            lblPeriodInterval = new Label();
            chkPeriodEndless = new Sunny.UI.UICheckBox();
            dtpPeriodEndTime = new Sunny.UI.UITimePicker();
            lblPeriodEndTime = new Label();
            dtpPeriodEnd = new Sunny.UI.UIDatePicker();
            lblPeriodEnd = new Label();
            dtpPeriodStartTime = new Sunny.UI.UITimePicker();
            lblPeriodStartTime = new Label();
            dtpPeriodStart = new Sunny.UI.UIDatePicker();
            lblPeriodStart = new Label();
            chkPeriodSendFirst = new Sunny.UI.UICheckBox();
            radPeriodSpecial = new Sunny.UI.UIRadioButton();
            radPeriodCalendar = new Sunny.UI.UIRadioButton();
            radPeriodInterval = new Sunny.UI.UIRadioButton();
            cmbPeriodType = new Sunny.UI.UIComboBox();
            lblPeriodType = new Label();
            lblPeriodTemplateHint = new Label();
            txtPeriodCustomText = new Sunny.UI.UITextBox();
            cmbPeriodTemplate = new Sunny.UI.UIComboBox();
            grpPeriodic.SuspendLayout();
            pnlPeriodButtons.SuspendLayout();
            pnlPeriodInner.SuspendLayout();
            pnlPeriodContent.SuspendLayout();
            grpPeriodHistory.SuspendLayout();
            SuspendLayout();
            // 
            // grpPeriodic
            // 
            grpPeriodic.BackColor = Color.FromArgb(35, 39, 48);
            grpPeriodic.Controls.Add(pnlPeriodButtons);
            grpPeriodic.Controls.Add(pnlPeriodInner);
            grpPeriodic.Dock = DockStyle.Fill;
            grpPeriodic.FillColor = Color.Transparent;
            grpPeriodic.FillColor2 = Color.Transparent;
            grpPeriodic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpPeriodic.ForeColor = Color.White;
            grpPeriodic.Location = new Point(0, 0);
            grpPeriodic.Margin = new Padding(4, 5, 4, 5);
            grpPeriodic.MinimumSize = new Size(1, 1);
            grpPeriodic.Name = "grpPeriodic";
            grpPeriodic.Padding = new Padding(0, 32, 0, 0);
            grpPeriodic.Radius = 15;
            grpPeriodic.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpPeriodic.RectColor = Color.FromArgb(58, 58, 69);
            grpPeriodic.Size = new Size(696, 483);
            grpPeriodic.Style = Sunny.UI.UIStyle.Custom;
            grpPeriodic.TabIndex = 6;
            grpPeriodic.Text = "Настройки периодической отправки";
            grpPeriodic.TextAlignment = ContentAlignment.MiddleLeft;
            grpPeriodic.TitleInterval = 8;
            grpPeriodic.TitleTop = 14;
            // 
            // pnlPeriodButtons
            // 
            pnlPeriodButtons.Controls.Add(chkPeriodicManualConfirm);
            pnlPeriodButtons.Controls.Add(btnSavePeriodic);
            pnlPeriodButtons.Controls.Add(btnStartPeriodic);
            pnlPeriodButtons.Dock = DockStyle.Bottom;
            pnlPeriodButtons.FillColor = Color.Transparent;
            pnlPeriodButtons.FillColor2 = Color.Transparent;
            pnlPeriodButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlPeriodButtons.ForeColor = Color.Transparent;
            pnlPeriodButtons.Location = new Point(0, 438);
            pnlPeriodButtons.Margin = new Padding(4, 5, 4, 5);
            pnlPeriodButtons.MinimumSize = new Size(1, 1);
            pnlPeriodButtons.Name = "pnlPeriodButtons";
            pnlPeriodButtons.Radius = 0;
            pnlPeriodButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlPeriodButtons.Size = new Size(696, 45);
            pnlPeriodButtons.TabIndex = 20;
            pnlPeriodButtons.Text = null;
            pnlPeriodButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkPeriodicManualConfirm
            // 
            chkPeriodicManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkPeriodicManualConfirm.BackColor = Color.Transparent;
            chkPeriodicManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkPeriodicManualConfirm.Checked = true;
            chkPeriodicManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodicManualConfirm.ForeColor = Color.White;
            chkPeriodicManualConfirm.Location = new Point(46, 10);
            chkPeriodicManualConfirm.MinimumSize = new Size(1, 1);
            chkPeriodicManualConfirm.Name = "chkPeriodicManualConfirm";
            chkPeriodicManualConfirm.Size = new Size(333, 25);
            chkPeriodicManualConfirm.TabIndex = 27;
            chkPeriodicManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSavePeriodic
            // 
            btnSavePeriodic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSavePeriodic.FillColor = Color.BlueViolet;
            btnSavePeriodic.FillColor2 = Color.Transparent;
            btnSavePeriodic.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSavePeriodic.FillHoverColor = Color.DarkOrchid;
            btnSavePeriodic.FillPressColor = Color.DarkViolet;
            btnSavePeriodic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSavePeriodic.Location = new Point(389, 5);
            btnSavePeriodic.MinimumSize = new Size(1, 1);
            btnSavePeriodic.Name = "btnSavePeriodic";
            btnSavePeriodic.Radius = 8;
            btnSavePeriodic.RectColor = Color.Transparent;
            btnSavePeriodic.Size = new Size(150, 35);
            btnSavePeriodic.Style = Sunny.UI.UIStyle.Custom;
            btnSavePeriodic.TabIndex = 13;
            btnSavePeriodic.Text = "Сохранить настройки";
            btnSavePeriodic.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnStartPeriodic
            // 
            btnStartPeriodic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartPeriodic.FillColor = Color.Indigo;
            btnStartPeriodic.FillColor2 = Color.Transparent;
            btnStartPeriodic.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnStartPeriodic.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnStartPeriodic.FillPressColor = Color.FromArgb(109, 40, 217);
            btnStartPeriodic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartPeriodic.Location = new Point(543, 5);
            btnStartPeriodic.MinimumSize = new Size(1, 1);
            btnStartPeriodic.Name = "btnStartPeriodic";
            btnStartPeriodic.Radius = 8;
            btnStartPeriodic.RectColor = Color.Transparent;
            btnStartPeriodic.Size = new Size(150, 35);
            btnStartPeriodic.Style = Sunny.UI.UIStyle.Custom;
            btnStartPeriodic.TabIndex = 14;
            btnStartPeriodic.Text = "Начать сеанс";
            btnStartPeriodic.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlPeriodInner
            // 
            pnlPeriodInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPeriodInner.AutoScroll = true;
            pnlPeriodInner.Controls.Add(pnlPeriodContent);
            pnlPeriodInner.Location = new Point(3, 25);
            pnlPeriodInner.Name = "pnlPeriodInner";
            pnlPeriodInner.Size = new Size(693, 413);
            pnlPeriodInner.TabIndex = 21;
            // 
            // pnlPeriodContent
            // 
            pnlPeriodContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlPeriodContent.Controls.Add(grpPeriodHistory);
            pnlPeriodContent.Controls.Add(chkDeletePrevious);
            pnlPeriodContent.Controls.Add(chkHideSpoiler);
            pnlPeriodContent.Controls.Add(chkProtectContent);
            pnlPeriodContent.Controls.Add(chkSkipIfInactive);
            pnlPeriodContent.Controls.Add(chkNoAuthorMention);
            pnlPeriodContent.Controls.Add(chkSilentSend);
            pnlPeriodContent.Controls.Add(chkDisablePreview);
            pnlPeriodContent.Controls.Add(chkSendTemplateFirst);
            pnlPeriodContent.Controls.Add(chkNotifyError);
            pnlPeriodContent.Controls.Add(cmbNotifyError1);
            pnlPeriodContent.Controls.Add(lblNotifyErrorOr);
            pnlPeriodContent.Controls.Add(cmbNotifyError2);
            pnlPeriodContent.Controls.Add(chkNotifyComplete);
            pnlPeriodContent.Controls.Add(cmbNotifyComplete1);
            pnlPeriodContent.Controls.Add(lblNotifyCompleteOr);
            pnlPeriodContent.Controls.Add(cmbNotifyComplete2);
            pnlPeriodContent.Controls.Add(chkNotifySuccess);
            pnlPeriodContent.Controls.Add(cmbNotifySuccess1);
            pnlPeriodContent.Controls.Add(lblNotifySuccessOr);
            pnlPeriodContent.Controls.Add(cmbNotifySuccess2);
            pnlPeriodContent.Controls.Add(cmbPeriodTimezone);
            pnlPeriodContent.Controls.Add(lblPeriodTimezone);
            pnlPeriodContent.Controls.Add(nudPeriodPause);
            pnlPeriodContent.Controls.Add(cmbPeriodPauseUnit);
            pnlPeriodContent.Controls.Add(lblPeriodPause);
            pnlPeriodContent.Controls.Add(nudPeriodRetry);
            pnlPeriodContent.Controls.Add(lblPeriodRetryUnit);
            pnlPeriodContent.Controls.Add(lblPeriodRetry);
            pnlPeriodContent.Controls.Add(nudPeriodMaxSends);
            pnlPeriodContent.Controls.Add(lblPeriodMaxHint);
            pnlPeriodContent.Controls.Add(lblPeriodMaxSends);
            pnlPeriodContent.Controls.Add(cmbPeriodRandomUnit);
            pnlPeriodContent.Controls.Add(nudPeriodRandomMax);
            pnlPeriodContent.Controls.Add(lblPeriodRandomTo);
            pnlPeriodContent.Controls.Add(nudPeriodRandomMin);
            pnlPeriodContent.Controls.Add(chkPeriodRandomTime);
            pnlPeriodContent.Controls.Add(txtPeriodMonthDays);
            pnlPeriodContent.Controls.Add(lblPeriodMonthDays);
            pnlPeriodContent.Controls.Add(chkPeriodDaySun);
            pnlPeriodContent.Controls.Add(chkPeriodDaySat);
            pnlPeriodContent.Controls.Add(chkPeriodDayFri);
            pnlPeriodContent.Controls.Add(chkPeriodDayThu);
            pnlPeriodContent.Controls.Add(chkPeriodDayWed);
            pnlPeriodContent.Controls.Add(chkPeriodDayTue);
            pnlPeriodContent.Controls.Add(chkPeriodDayMon);
            pnlPeriodContent.Controls.Add(lblPeriodDays);
            pnlPeriodContent.Controls.Add(cmbPeriodCustomUnit);
            pnlPeriodContent.Controls.Add(nudPeriodCustomCount);
            pnlPeriodContent.Controls.Add(lblPeriodCustomCount);
            pnlPeriodContent.Controls.Add(cmbPeriodIntervalUnit);
            pnlPeriodContent.Controls.Add(nudPeriodInterval);
            pnlPeriodContent.Controls.Add(lblPeriodInterval);
            pnlPeriodContent.Controls.Add(chkPeriodEndless);
            pnlPeriodContent.Controls.Add(dtpPeriodEndTime);
            pnlPeriodContent.Controls.Add(lblPeriodEndTime);
            pnlPeriodContent.Controls.Add(dtpPeriodEnd);
            pnlPeriodContent.Controls.Add(lblPeriodEnd);
            pnlPeriodContent.Controls.Add(dtpPeriodStartTime);
            pnlPeriodContent.Controls.Add(lblPeriodStartTime);
            pnlPeriodContent.Controls.Add(dtpPeriodStart);
            pnlPeriodContent.Controls.Add(lblPeriodStart);
            pnlPeriodContent.Controls.Add(chkPeriodSendFirst);
            pnlPeriodContent.Controls.Add(radPeriodSpecial);
            pnlPeriodContent.Controls.Add(radPeriodCalendar);
            pnlPeriodContent.Controls.Add(radPeriodInterval);
            pnlPeriodContent.Controls.Add(cmbPeriodType);
            pnlPeriodContent.Controls.Add(lblPeriodType);
            pnlPeriodContent.Controls.Add(lblPeriodTemplateHint);
            pnlPeriodContent.Controls.Add(txtPeriodCustomText);
            pnlPeriodContent.Controls.Add(cmbPeriodTemplate);
            pnlPeriodContent.Location = new Point(0, 0);
            pnlPeriodContent.MinimumSize = new Size(673, 0);
            pnlPeriodContent.Name = "pnlPeriodContent";
            pnlPeriodContent.Padding = new Padding(16, 0, 16, 0);
            pnlPeriodContent.Size = new Size(676, 1330);
            pnlPeriodContent.TabIndex = 0;
            // 
            // grpPeriodHistory
            // 
            grpPeriodHistory.Controls.Add(flpPeriodHistory);
            grpPeriodHistory.FillColor = Color.Transparent;
            grpPeriodHistory.FillColor2 = Color.Transparent;
            grpPeriodHistory.FillDisableColor = Color.Transparent;
            grpPeriodHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpPeriodHistory.ForeColor = SystemColors.ActiveBorder;
            grpPeriodHistory.ForeDisableColor = Color.Transparent;
            grpPeriodHistory.Location = new Point(9, 890);
            grpPeriodHistory.Margin = new Padding(4, 5, 4, 5);
            grpPeriodHistory.MinimumSize = new Size(1, 1);
            grpPeriodHistory.Name = "grpPeriodHistory";
            grpPeriodHistory.Padding = new Padding(5, 32, 5, 5);
            grpPeriodHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpPeriodHistory.RectDisableColor = Color.Transparent;
            grpPeriodHistory.Size = new Size(644, 290);
            grpPeriodHistory.TabIndex = 25;
            grpPeriodHistory.Text = "История отправок:";
            grpPeriodHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpPeriodHistory.TitleTop = 10;
            // 
            // flpPeriodHistory
            // 
            flpPeriodHistory.AutoScroll = true;
            flpPeriodHistory.FlowDirection = FlowDirection.TopDown;
            flpPeriodHistory.Location = new Point(10, 20);
            flpPeriodHistory.Name = "flpPeriodHistory";
            flpPeriodHistory.Size = new Size(622, 259);
            flpPeriodHistory.TabIndex = 10;
            flpPeriodHistory.WrapContents = false;
            // 
            // chkDeletePrevious
            // 
            chkDeletePrevious.BackColor = Color.Transparent;
            chkDeletePrevious.CheckBoxColor = Color.BlueViolet;
            chkDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDeletePrevious.ForeColor = Color.White;
            chkDeletePrevious.Location = new Point(279, 850);
            chkDeletePrevious.MinimumSize = new Size(1, 1);
            chkDeletePrevious.Name = "chkDeletePrevious";
            chkDeletePrevious.Size = new Size(346, 25);
            chkDeletePrevious.TabIndex = 76;
            chkDeletePrevious.Text = "Удалить предыдущее сообщение бота перед отправкой";
            // 
            // chkHideSpoiler
            // 
            chkHideSpoiler.BackColor = Color.Transparent;
            chkHideSpoiler.CheckBoxColor = Color.BlueViolet;
            chkHideSpoiler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkHideSpoiler.ForeColor = Color.White;
            chkHideSpoiler.Location = new Point(9, 850);
            chkHideSpoiler.MinimumSize = new Size(1, 1);
            chkHideSpoiler.Name = "chkHideSpoiler";
            chkHideSpoiler.Size = new Size(264, 25);
            chkHideSpoiler.TabIndex = 75;
            chkHideSpoiler.Text = "Скрыть содержимое как спойлер";
            // 
            // chkProtectContent
            // 
            chkProtectContent.BackColor = Color.Transparent;
            chkProtectContent.CheckBoxColor = Color.BlueViolet;
            chkProtectContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkProtectContent.ForeColor = Color.White;
            chkProtectContent.Location = new Point(279, 820);
            chkProtectContent.MinimumSize = new Size(1, 1);
            chkProtectContent.Name = "chkProtectContent";
            chkProtectContent.Size = new Size(346, 25);
            chkProtectContent.TabIndex = 70;
            chkProtectContent.Text = "Защитить от копирования и пересылки";
            // 
            // chkSkipIfInactive
            // 
            chkSkipIfInactive.BackColor = Color.Transparent;
            chkSkipIfInactive.CheckBoxColor = Color.BlueViolet;
            chkSkipIfInactive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSkipIfInactive.ForeColor = Color.White;
            chkSkipIfInactive.Location = new Point(9, 820);
            chkSkipIfInactive.MinimumSize = new Size(1, 1);
            chkSkipIfInactive.Name = "chkSkipIfInactive";
            chkSkipIfInactive.Size = new Size(264, 25);
            chkSkipIfInactive.TabIndex = 68;
            chkSkipIfInactive.Text = "Пропускать если активности нет";
            // 
            // chkNoAuthorMention
            // 
            chkNoAuthorMention.BackColor = Color.Transparent;
            chkNoAuthorMention.CheckBoxColor = Color.BlueViolet;
            chkNoAuthorMention.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNoAuthorMention.ForeColor = Color.White;
            chkNoAuthorMention.Location = new Point(279, 790);
            chkNoAuthorMention.MinimumSize = new Size(1, 1);
            chkNoAuthorMention.Name = "chkNoAuthorMention";
            chkNoAuthorMention.Size = new Size(346, 25);
            chkNoAuthorMention.TabIndex = 69;
            chkNoAuthorMention.Text = "Отправить без упоминания автора (как своё)";
            // 
            // chkSilentSend
            // 
            chkSilentSend.BackColor = Color.Transparent;
            chkSilentSend.CheckBoxColor = Color.BlueViolet;
            chkSilentSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSilentSend.ForeColor = Color.White;
            chkSilentSend.Location = new Point(9, 790);
            chkSilentSend.MinimumSize = new Size(1, 1);
            chkSilentSend.Name = "chkSilentSend";
            chkSilentSend.Size = new Size(264, 25);
            chkSilentSend.TabIndex = 67;
            chkSilentSend.Text = "Тихая отправка (без звука)";
            // 
            // chkDisablePreview
            // 
            chkDisablePreview.BackColor = Color.Transparent;
            chkDisablePreview.CheckBoxColor = Color.BlueViolet;
            chkDisablePreview.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDisablePreview.ForeColor = Color.White;
            chkDisablePreview.Location = new Point(279, 760);
            chkDisablePreview.MinimumSize = new Size(1, 1);
            chkDisablePreview.Name = "chkDisablePreview";
            chkDisablePreview.Size = new Size(346, 25);
            chkDisablePreview.TabIndex = 66;
            chkDisablePreview.Text = "Отключить предпросмотр ссылок";
            // 
            // chkSendTemplateFirst
            // 
            chkSendTemplateFirst.BackColor = Color.Transparent;
            chkSendTemplateFirst.CheckBoxColor = Color.BlueViolet;
            chkSendTemplateFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSendTemplateFirst.ForeColor = Color.White;
            chkSendTemplateFirst.Location = new Point(9, 760);
            chkSendTemplateFirst.MinimumSize = new Size(1, 1);
            chkSendTemplateFirst.Name = "chkSendTemplateFirst";
            chkSendTemplateFirst.Size = new Size(264, 25);
            chkSendTemplateFirst.TabIndex = 65;
            chkSendTemplateFirst.Text = "Отправить первым шаблон";
            // 
            // chkNotifyError
            // 
            chkNotifyError.BackColor = Color.Transparent;
            chkNotifyError.CheckBoxColor = Color.BlueViolet;
            chkNotifyError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyError.ForeColor = Color.White;
            chkNotifyError.Location = new Point(9, 715);
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
            cmbNotifyError1.Location = new Point(283, 715);
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
            lblNotifyErrorOr.Location = new Point(435, 720);
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
            cmbNotifyError2.Location = new Point(482, 715);
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
            chkNotifyComplete.Location = new Point(9, 685);
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
            cmbNotifyComplete1.Location = new Point(283, 685);
            cmbNotifyComplete1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete1.MinimumSize = new Size(63, 0);
            cmbNotifyComplete1.Name = "cmbNotifyComplete1";
            cmbNotifyComplete1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete1.Size = new Size(146, 25);
            cmbNotifyComplete1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete1.SymbolSize = 24;
            cmbNotifyComplete1.TabIndex = 81;
            cmbNotifyComplete1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete1.Watermark = "Куда отправить";
            // 
            // lblNotifyCompleteOr
            // 
            lblNotifyCompleteOr.AutoSize = true;
            lblNotifyCompleteOr.BackColor = Color.Transparent;
            lblNotifyCompleteOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyCompleteOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyCompleteOr.Location = new Point(435, 690);
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
            cmbNotifyComplete2.Location = new Point(482, 685);
            cmbNotifyComplete2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete2.MinimumSize = new Size(63, 0);
            cmbNotifyComplete2.Name = "cmbNotifyComplete2";
            cmbNotifyComplete2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete2.Size = new Size(146, 25);
            cmbNotifyComplete2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete2.SymbolSize = 24;
            cmbNotifyComplete2.TabIndex = 84;
            cmbNotifyComplete2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete2.Watermark = "Куда отправить";
            // 
            // chkNotifySuccess
            // 
            chkNotifySuccess.BackColor = Color.Transparent;
            chkNotifySuccess.CheckBoxColor = Color.BlueViolet;
            chkNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifySuccess.ForeColor = Color.White;
            chkNotifySuccess.Location = new Point(9, 655);
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
            cmbNotifySuccess1.Location = new Point(283, 655);
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
            lblNotifySuccessOr.Location = new Point(435, 660);
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
            cmbNotifySuccess2.Location = new Point(482, 655);
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
            // cmbPeriodTimezone
            // 
            cmbPeriodTimezone.DataSource = null;
            cmbPeriodTimezone.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodTimezone.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodTimezone.Font = new Font("Segoe UI", 9F);
            cmbPeriodTimezone.ForeColor = Color.White;
            cmbPeriodTimezone.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodTimezone.ItemForeColor = Color.White;
            cmbPeriodTimezone.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPeriodTimezone.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPeriodTimezone.Items.AddRange(new object[] { "GMT-12 (Бейкер, Хауленд)", "GMT-11 (Нукуалофа, Паго-Паго, Ниуэ)", "GMT-10 (Гонолулу, Алеутские острова)", "GMT-9 (Анкоридж, Джуно, Аляска)", "GMT-8 (Лос-Анджелес, Сан-Франциско, Ванкувер, Сиэтл)", "GMT-7 (Денвер, Финикс, Калгари, Солт-Лейк-Сити)", "GMT-6 (Чикаго, Мехико, Гватемала, Сан-Хосе)", "GMT-5 (Нью-Йорк, Майами, Богота, Лима, Гавана)", "GMT-4 (Сантьяго, Ла-Пас, Каракас, Галифакс)", "GMT-3 (Буэнос-Айрес, Сан-Паулу, Монтевидео, Бразилиа)", "GMT-2 (Южная Георгия, Сандвичевы острова)", "GMT-1 (Азорские острова, Кабо-Верде)", "GMT+0 (Лондон, Лиссабон, Дублин, Аккра, Касабланка)", "GMT+1 (Париж, Берлин, Рим, Мадрид, Варшава, Амстердам)", "GMT+2 (Каир, Афины, Хельсинки, Киев, Бухарест, Стамбул)", "GMT+3 (Москва, Эр-Рияд, Найроби, Багдад, Кувейт)", "GMT+4 (Дубай, Баку, Тбилиси, Ереван, Маврикий)", "GMT+5 (Карачи, Ташкент, Екатеринбург, Мальдивы)", "GMT+6 (Дакка, Алматы, Омск, Коломбо, Бишкек)", "GMT+7 (Бангкок, Хошимин, Джакарта, Новосибирск, Красноярск)", "GMT+8 (Пекин, Сингапур, Манила, Куала-Лумпур, Улан-Батор, Иркутск)", "GMT+9 (Токио, Сеул, Пхеньян, Якутск, Осака)", "GMT+10 (Сидней, Мельбурн, Владивосток, Порт-Морсби, Гуам)", "GMT+11 (Нумеа, Соломоновы острова)", "GMT+12 (Окленд, Фиджи, Магадан, Веллингтон)", "GMT+13 (Нукуалофа, Самоа, Тонга)", "GMT+14 (Киритимати, Острова Лайн)" });
            cmbPeriodTimezone.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPeriodTimezone.ItemSelectForeColor = Color.White;
            cmbPeriodTimezone.Location = new Point(99, 615);
            cmbPeriodTimezone.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodTimezone.MinimumSize = new Size(63, 0);
            cmbPeriodTimezone.Name = "cmbPeriodTimezone";
            cmbPeriodTimezone.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodTimezone.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodTimezone.Size = new Size(554, 25);
            cmbPeriodTimezone.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodTimezone.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodTimezone.SymbolSize = 24;
            cmbPeriodTimezone.TabIndex = 29;
            cmbPeriodTimezone.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodTimezone.Watermark = "Выберите пояс";
            // 
            // lblPeriodTimezone
            // 
            lblPeriodTimezone.AutoSize = true;
            lblPeriodTimezone.BackColor = Color.Transparent;
            lblPeriodTimezone.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodTimezone.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodTimezone.Location = new Point(9, 620);
            lblPeriodTimezone.Name = "lblPeriodTimezone";
            lblPeriodTimezone.Size = new Size(84, 13);
            lblPeriodTimezone.TabIndex = 28;
            lblPeriodTimezone.Text = "Часовой пояс:";
            // 
            // nudPeriodPause
            // 
            nudPeriodPause.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodPause.Font = new Font("Segoe UI", 9.75F);
            nudPeriodPause.ForeColor = Color.White;
            nudPeriodPause.Location = new Point(173, 575);
            nudPeriodPause.Margin = new Padding(4, 5, 4, 5);
            nudPeriodPause.Maximum = 10000D;
            nudPeriodPause.Minimum = 1D;
            nudPeriodPause.MinimumSize = new Size(1, 16);
            nudPeriodPause.Name = "nudPeriodPause";
            nudPeriodPause.Padding = new Padding(5);
            nudPeriodPause.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodPause.RectHoverColor = Color.BlueViolet;
            nudPeriodPause.RectPressColor = Color.Indigo;
            nudPeriodPause.ShowText = false;
            nudPeriodPause.Size = new Size(100, 25);
            nudPeriodPause.TabIndex = 6;
            nudPeriodPause.Text = "0";
            nudPeriodPause.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cmbPeriodPauseUnit
            // 
            cmbPeriodPauseUnit.DataSource = null;
            cmbPeriodPauseUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodPauseUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodPauseUnit.Font = new Font("Segoe UI", 9F);
            cmbPeriodPauseUnit.ForeColor = Color.White;
            cmbPeriodPauseUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodPauseUnit.ItemForeColor = Color.White;
            cmbPeriodPauseUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPeriodPauseUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPeriodPauseUnit.Items.AddRange(new object[] { "секунд", "минут", "часов", "дней" });
            cmbPeriodPauseUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPeriodPauseUnit.ItemSelectForeColor = Color.White;
            cmbPeriodPauseUnit.Location = new Point(279, 575);
            cmbPeriodPauseUnit.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodPauseUnit.MinimumSize = new Size(63, 0);
            cmbPeriodPauseUnit.Name = "cmbPeriodPauseUnit";
            cmbPeriodPauseUnit.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodPauseUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodPauseUnit.Size = new Size(81, 25);
            cmbPeriodPauseUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodPauseUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodPauseUnit.SymbolSize = 24;
            cmbPeriodPauseUnit.TabIndex = 4;
            cmbPeriodPauseUnit.Text = "минут";
            cmbPeriodPauseUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodPauseUnit.Watermark = "";
            // 
            // lblPeriodPause
            // 
            lblPeriodPause.AutoSize = true;
            lblPeriodPause.BackColor = Color.Transparent;
            lblPeriodPause.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodPause.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodPause.Location = new Point(9, 580);
            lblPeriodPause.Name = "lblPeriodPause";
            lblPeriodPause.Size = new Size(142, 13);
            lblPeriodPause.TabIndex = 63;
            lblPeriodPause.Text = "Пауза между повторами:";
            // 
            // nudPeriodRetry
            // 
            nudPeriodRetry.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodRetry.Font = new Font("Segoe UI", 9.75F);
            nudPeriodRetry.ForeColor = Color.White;
            nudPeriodRetry.Location = new Point(173, 535);
            nudPeriodRetry.Margin = new Padding(4, 5, 4, 5);
            nudPeriodRetry.Maximum = 10000D;
            nudPeriodRetry.Minimum = 1D;
            nudPeriodRetry.MinimumSize = new Size(1, 16);
            nudPeriodRetry.Name = "nudPeriodRetry";
            nudPeriodRetry.Padding = new Padding(5);
            nudPeriodRetry.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodRetry.RectHoverColor = Color.BlueViolet;
            nudPeriodRetry.RectPressColor = Color.Indigo;
            nudPeriodRetry.ShowText = false;
            nudPeriodRetry.Size = new Size(100, 25);
            nudPeriodRetry.TabIndex = 5;
            nudPeriodRetry.Text = "0";
            nudPeriodRetry.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblPeriodRetryUnit
            // 
            lblPeriodRetryUnit.AutoSize = true;
            lblPeriodRetryUnit.BackColor = Color.Transparent;
            lblPeriodRetryUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodRetryUnit.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodRetryUnit.Location = new Point(279, 540);
            lblPeriodRetryUnit.Name = "lblPeriodRetryUnit";
            lblPeriodRetryUnit.Size = new Size(25, 13);
            lblPeriodRetryUnit.TabIndex = 62;
            lblPeriodRetryUnit.Text = "раз";
            // 
            // lblPeriodRetry
            // 
            lblPeriodRetry.AutoSize = true;
            lblPeriodRetry.BackColor = Color.Transparent;
            lblPeriodRetry.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodRetry.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodRetry.Location = new Point(9, 540);
            lblPeriodRetry.Name = "lblPeriodRetry";
            lblPeriodRetry.Size = new Size(119, 13);
            lblPeriodRetry.TabIndex = 61;
            lblPeriodRetry.Text = "Повтор при ошибке:";
            // 
            // nudPeriodMaxSends
            // 
            nudPeriodMaxSends.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodMaxSends.Font = new Font("Segoe UI", 9.75F);
            nudPeriodMaxSends.ForeColor = Color.White;
            nudPeriodMaxSends.Location = new Point(173, 495);
            nudPeriodMaxSends.Margin = new Padding(4, 5, 4, 5);
            nudPeriodMaxSends.Maximum = 10000D;
            nudPeriodMaxSends.Minimum = 1D;
            nudPeriodMaxSends.MinimumSize = new Size(1, 16);
            nudPeriodMaxSends.Name = "nudPeriodMaxSends";
            nudPeriodMaxSends.Padding = new Padding(5);
            nudPeriodMaxSends.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodMaxSends.RectHoverColor = Color.BlueViolet;
            nudPeriodMaxSends.RectPressColor = Color.Indigo;
            nudPeriodMaxSends.ShowText = false;
            nudPeriodMaxSends.Size = new Size(100, 25);
            nudPeriodMaxSends.TabIndex = 4;
            nudPeriodMaxSends.Text = "0";
            nudPeriodMaxSends.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblPeriodMaxHint
            // 
            lblPeriodMaxHint.AutoSize = true;
            lblPeriodMaxHint.BackColor = Color.Transparent;
            lblPeriodMaxHint.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodMaxHint.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodMaxHint.Location = new Point(279, 500);
            lblPeriodMaxHint.Name = "lblPeriodMaxHint";
            lblPeriodMaxHint.Size = new Size(95, 13);
            lblPeriodMaxHint.TabIndex = 60;
            lblPeriodMaxHint.Text = "(0 = без лимита)";
            // 
            // lblPeriodMaxSends
            // 
            lblPeriodMaxSends.AutoSize = true;
            lblPeriodMaxSends.BackColor = Color.Transparent;
            lblPeriodMaxSends.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodMaxSends.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodMaxSends.Location = new Point(9, 500);
            lblPeriodMaxSends.Name = "lblPeriodMaxSends";
            lblPeriodMaxSends.Size = new Size(94, 13);
            lblPeriodMaxSends.TabIndex = 59;
            lblPeriodMaxSends.Text = "Макс. отправок:";
            // 
            // cmbPeriodRandomUnit
            // 
            cmbPeriodRandomUnit.DataSource = null;
            cmbPeriodRandomUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodRandomUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodRandomUnit.Font = new Font("Segoe UI", 9F);
            cmbPeriodRandomUnit.ForeColor = Color.White;
            cmbPeriodRandomUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodRandomUnit.ItemForeColor = Color.White;
            cmbPeriodRandomUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPeriodRandomUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPeriodRandomUnit.Items.AddRange(new object[] { "секунд", "минут", "часов", "дней" });
            cmbPeriodRandomUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPeriodRandomUnit.ItemSelectForeColor = Color.White;
            cmbPeriodRandomUnit.Location = new Point(564, 450);
            cmbPeriodRandomUnit.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodRandomUnit.MinimumSize = new Size(63, 0);
            cmbPeriodRandomUnit.Name = "cmbPeriodRandomUnit";
            cmbPeriodRandomUnit.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodRandomUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodRandomUnit.Size = new Size(81, 25);
            cmbPeriodRandomUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodRandomUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodRandomUnit.SymbolSize = 24;
            cmbPeriodRandomUnit.TabIndex = 3;
            cmbPeriodRandomUnit.Text = "минут";
            cmbPeriodRandomUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodRandomUnit.Watermark = "";
            // 
            // nudPeriodRandomMax
            // 
            nudPeriodRandomMax.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodRandomMax.Font = new Font("Segoe UI", 9.75F);
            nudPeriodRandomMax.ForeColor = Color.White;
            nudPeriodRandomMax.Location = new Point(458, 450);
            nudPeriodRandomMax.Margin = new Padding(4, 5, 4, 5);
            nudPeriodRandomMax.Maximum = 1440D;
            nudPeriodRandomMax.Minimum = 1D;
            nudPeriodRandomMax.MinimumSize = new Size(1, 16);
            nudPeriodRandomMax.Name = "nudPeriodRandomMax";
            nudPeriodRandomMax.Padding = new Padding(5);
            nudPeriodRandomMax.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodRandomMax.RectHoverColor = Color.BlueViolet;
            nudPeriodRandomMax.RectPressColor = Color.Indigo;
            nudPeriodRandomMax.ShowText = false;
            nudPeriodRandomMax.Size = new Size(100, 25);
            nudPeriodRandomMax.TabIndex = 4;
            nudPeriodRandomMax.Text = "60";
            nudPeriodRandomMax.TextAlignment = ContentAlignment.MiddleCenter;
            nudPeriodRandomMax.Value = 60;
            // 
            // lblPeriodRandomTo
            // 
            lblPeriodRandomTo.AutoSize = true;
            lblPeriodRandomTo.BackColor = Color.Transparent;
            lblPeriodRandomTo.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodRandomTo.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodRandomTo.Location = new Point(429, 455);
            lblPeriodRandomTo.Name = "lblPeriodRandomTo";
            lblPeriodRandomTo.Size = new Size(20, 13);
            lblPeriodRandomTo.TabIndex = 57;
            lblPeriodRandomTo.Text = "до";
            // 
            // nudPeriodRandomMin
            // 
            nudPeriodRandomMin.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodRandomMin.Font = new Font("Segoe UI", 9.75F);
            nudPeriodRandomMin.ForeColor = Color.White;
            nudPeriodRandomMin.Location = new Point(319, 450);
            nudPeriodRandomMin.Margin = new Padding(4, 5, 4, 5);
            nudPeriodRandomMin.Maximum = 1440D;
            nudPeriodRandomMin.Minimum = 1D;
            nudPeriodRandomMin.MinimumSize = new Size(1, 16);
            nudPeriodRandomMin.Name = "nudPeriodRandomMin";
            nudPeriodRandomMin.Padding = new Padding(5);
            nudPeriodRandomMin.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodRandomMin.RectHoverColor = Color.BlueViolet;
            nudPeriodRandomMin.RectPressColor = Color.Indigo;
            nudPeriodRandomMin.ShowText = false;
            nudPeriodRandomMin.Size = new Size(100, 25);
            nudPeriodRandomMin.TabIndex = 3;
            nudPeriodRandomMin.Text = "1";
            nudPeriodRandomMin.TextAlignment = ContentAlignment.MiddleCenter;
            nudPeriodRandomMin.Value = 1;
            // 
            // chkPeriodRandomTime
            // 
            chkPeriodRandomTime.BackColor = Color.Transparent;
            chkPeriodRandomTime.CheckBoxColor = Color.BlueViolet;
            chkPeriodRandomTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodRandomTime.ForeColor = Color.White;
            chkPeriodRandomTime.Location = new Point(9, 450);
            chkPeriodRandomTime.MinimumSize = new Size(1, 1);
            chkPeriodRandomTime.Name = "chkPeriodRandomTime";
            chkPeriodRandomTime.Size = new Size(304, 25);
            chkPeriodRandomTime.TabIndex = 56;
            chkPeriodRandomTime.Text = "Добавлять случайное отклонение ко времени от:";
            // 
            // txtPeriodMonthDays
            // 
            txtPeriodMonthDays.ButtonFillColor = Color.Transparent;
            txtPeriodMonthDays.ButtonStyleInherited = false;
            txtPeriodMonthDays.FillColor = Color.FromArgb(42, 46, 57);
            txtPeriodMonthDays.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPeriodMonthDays.ForeColor = Color.White;
            txtPeriodMonthDays.Location = new Point(179, 410);
            txtPeriodMonthDays.Margin = new Padding(4, 5, 4, 5);
            txtPeriodMonthDays.MinimumSize = new Size(1, 16);
            txtPeriodMonthDays.Name = "txtPeriodMonthDays";
            txtPeriodMonthDays.Padding = new Padding(5);
            txtPeriodMonthDays.RectColor = Color.FromArgb(65, 71, 84);
            txtPeriodMonthDays.ShowText = false;
            txtPeriodMonthDays.Size = new Size(474, 25);
            txtPeriodMonthDays.Style = Sunny.UI.UIStyle.Custom;
            txtPeriodMonthDays.TabIndex = 54;
            txtPeriodMonthDays.Text = "0";
            txtPeriodMonthDays.TextAlignment = ContentAlignment.MiddleLeft;
            txtPeriodMonthDays.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            txtPeriodMonthDays.Watermark = "Например: 1, 5, 15, 30 (Обязательно через запятую)";
            // 
            // lblPeriodMonthDays
            // 
            lblPeriodMonthDays.AutoSize = true;
            lblPeriodMonthDays.BackColor = Color.Transparent;
            lblPeriodMonthDays.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodMonthDays.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodMonthDays.Location = new Point(9, 415);
            lblPeriodMonthDays.Name = "lblPeriodMonthDays";
            lblPeriodMonthDays.Size = new Size(164, 13);
            lblPeriodMonthDays.TabIndex = 53;
            lblPeriodMonthDays.Text = "Определенные числа месяца:";
            // 
            // chkPeriodDaySun
            // 
            chkPeriodDaySun.BackColor = Color.Transparent;
            chkPeriodDaySun.CheckBoxColor = Color.BlueViolet;
            chkPeriodDaySun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDaySun.ForeColor = Color.White;
            chkPeriodDaySun.Location = new Point(447, 365);
            chkPeriodDaySun.MinimumSize = new Size(1, 1);
            chkPeriodDaySun.Name = "chkPeriodDaySun";
            chkPeriodDaySun.Size = new Size(50, 25);
            chkPeriodDaySun.TabIndex = 50;
            chkPeriodDaySun.Text = "Вс";
            // 
            // chkPeriodDaySat
            // 
            chkPeriodDaySat.BackColor = Color.Transparent;
            chkPeriodDaySat.CheckBoxColor = Color.BlueViolet;
            chkPeriodDaySat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDaySat.ForeColor = Color.White;
            chkPeriodDaySat.Location = new Point(392, 365);
            chkPeriodDaySat.MinimumSize = new Size(1, 1);
            chkPeriodDaySat.Name = "chkPeriodDaySat";
            chkPeriodDaySat.Size = new Size(50, 25);
            chkPeriodDaySat.TabIndex = 49;
            chkPeriodDaySat.Text = "Сб";
            // 
            // chkPeriodDayFri
            // 
            chkPeriodDayFri.BackColor = Color.Transparent;
            chkPeriodDayFri.CheckBoxColor = Color.BlueViolet;
            chkPeriodDayFri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDayFri.ForeColor = Color.White;
            chkPeriodDayFri.Location = new Point(337, 365);
            chkPeriodDayFri.MinimumSize = new Size(1, 1);
            chkPeriodDayFri.Name = "chkPeriodDayFri";
            chkPeriodDayFri.Size = new Size(50, 25);
            chkPeriodDayFri.TabIndex = 48;
            chkPeriodDayFri.Text = "Пт";
            // 
            // chkPeriodDayThu
            // 
            chkPeriodDayThu.BackColor = Color.Transparent;
            chkPeriodDayThu.CheckBoxColor = Color.BlueViolet;
            chkPeriodDayThu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDayThu.ForeColor = Color.White;
            chkPeriodDayThu.Location = new Point(282, 365);
            chkPeriodDayThu.MinimumSize = new Size(1, 1);
            chkPeriodDayThu.Name = "chkPeriodDayThu";
            chkPeriodDayThu.Size = new Size(50, 25);
            chkPeriodDayThu.TabIndex = 47;
            chkPeriodDayThu.Text = "Чт";
            // 
            // chkPeriodDayWed
            // 
            chkPeriodDayWed.BackColor = Color.Transparent;
            chkPeriodDayWed.CheckBoxColor = Color.BlueViolet;
            chkPeriodDayWed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDayWed.ForeColor = Color.White;
            chkPeriodDayWed.Location = new Point(227, 365);
            chkPeriodDayWed.MinimumSize = new Size(1, 1);
            chkPeriodDayWed.Name = "chkPeriodDayWed";
            chkPeriodDayWed.Size = new Size(50, 25);
            chkPeriodDayWed.TabIndex = 46;
            chkPeriodDayWed.Text = "Ср";
            // 
            // chkPeriodDayTue
            // 
            chkPeriodDayTue.BackColor = Color.Transparent;
            chkPeriodDayTue.CheckBoxColor = Color.BlueViolet;
            chkPeriodDayTue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDayTue.ForeColor = Color.White;
            chkPeriodDayTue.Location = new Point(172, 365);
            chkPeriodDayTue.MinimumSize = new Size(1, 1);
            chkPeriodDayTue.Name = "chkPeriodDayTue";
            chkPeriodDayTue.Size = new Size(50, 25);
            chkPeriodDayTue.TabIndex = 45;
            chkPeriodDayTue.Text = "Вт";
            // 
            // chkPeriodDayMon
            // 
            chkPeriodDayMon.BackColor = Color.Transparent;
            chkPeriodDayMon.CheckBoxColor = Color.BlueViolet;
            chkPeriodDayMon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodDayMon.ForeColor = Color.White;
            chkPeriodDayMon.Location = new Point(117, 365);
            chkPeriodDayMon.MinimumSize = new Size(1, 1);
            chkPeriodDayMon.Name = "chkPeriodDayMon";
            chkPeriodDayMon.Size = new Size(50, 25);
            chkPeriodDayMon.TabIndex = 44;
            chkPeriodDayMon.Text = "Пн";
            // 
            // lblPeriodDays
            // 
            lblPeriodDays.AutoSize = true;
            lblPeriodDays.BackColor = Color.Transparent;
            lblPeriodDays.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodDays.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodDays.Location = new Point(9, 370);
            lblPeriodDays.Name = "lblPeriodDays";
            lblPeriodDays.Size = new Size(102, 13);
            lblPeriodDays.TabIndex = 43;
            lblPeriodDays.Text = "Неделя отправки:";
            // 
            // cmbPeriodCustomUnit
            // 
            cmbPeriodCustomUnit.DataSource = null;
            cmbPeriodCustomUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodCustomUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodCustomUnit.Font = new Font("Segoe UI", 9F);
            cmbPeriodCustomUnit.ForeColor = Color.White;
            cmbPeriodCustomUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodCustomUnit.ItemForeColor = Color.White;
            cmbPeriodCustomUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPeriodCustomUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPeriodCustomUnit.Items.AddRange(new object[] { "секунд", "минут", "часов", "день(дня,дней)" });
            cmbPeriodCustomUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPeriodCustomUnit.ItemSelectForeColor = Color.White;
            cmbPeriodCustomUnit.Location = new Point(247, 320);
            cmbPeriodCustomUnit.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodCustomUnit.MinimumSize = new Size(63, 0);
            cmbPeriodCustomUnit.Name = "cmbPeriodCustomUnit";
            cmbPeriodCustomUnit.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodCustomUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodCustomUnit.Size = new Size(122, 25);
            cmbPeriodCustomUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodCustomUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodCustomUnit.SymbolSize = 24;
            cmbPeriodCustomUnit.TabIndex = 3;
            cmbPeriodCustomUnit.Text = "день(дня,дней)";
            cmbPeriodCustomUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodCustomUnit.Watermark = "";
            // 
            // nudPeriodCustomCount
            // 
            nudPeriodCustomCount.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodCustomCount.Font = new Font("Segoe UI", 9.75F);
            nudPeriodCustomCount.ForeColor = Color.White;
            nudPeriodCustomCount.Location = new Point(141, 320);
            nudPeriodCustomCount.Margin = new Padding(4, 5, 4, 5);
            nudPeriodCustomCount.Maximum = 1440D;
            nudPeriodCustomCount.Minimum = 1D;
            nudPeriodCustomCount.MinimumSize = new Size(1, 16);
            nudPeriodCustomCount.Name = "nudPeriodCustomCount";
            nudPeriodCustomCount.Padding = new Padding(5);
            nudPeriodCustomCount.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodCustomCount.RectHoverColor = Color.BlueViolet;
            nudPeriodCustomCount.RectPressColor = Color.Indigo;
            nudPeriodCustomCount.ShowText = false;
            nudPeriodCustomCount.Size = new Size(100, 25);
            nudPeriodCustomCount.TabIndex = 2;
            nudPeriodCustomCount.Text = "1";
            nudPeriodCustomCount.TextAlignment = ContentAlignment.MiddleCenter;
            nudPeriodCustomCount.Value = 1;
            // 
            // lblPeriodCustomCount
            // 
            lblPeriodCustomCount.AutoSize = true;
            lblPeriodCustomCount.BackColor = Color.Transparent;
            lblPeriodCustomCount.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodCustomCount.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodCustomCount.Location = new Point(9, 325);
            lblPeriodCustomCount.Name = "lblPeriodCustomCount";
            lblPeriodCustomCount.Size = new Size(126, 13);
            lblPeriodCustomCount.TabIndex = 27;
            lblPeriodCustomCount.Text = "Количество отправок:";
            // 
            // cmbPeriodIntervalUnit
            // 
            cmbPeriodIntervalUnit.DataSource = null;
            cmbPeriodIntervalUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodIntervalUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodIntervalUnit.Font = new Font("Segoe UI", 9F);
            cmbPeriodIntervalUnit.ForeColor = Color.White;
            cmbPeriodIntervalUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodIntervalUnit.ItemForeColor = Color.White;
            cmbPeriodIntervalUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPeriodIntervalUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPeriodIntervalUnit.Items.AddRange(new object[] { "секунд", "минут", "часов", "день(дня,дней)" });
            cmbPeriodIntervalUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPeriodIntervalUnit.ItemSelectForeColor = Color.White;
            cmbPeriodIntervalUnit.Location = new Point(295, 282);
            cmbPeriodIntervalUnit.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodIntervalUnit.MinimumSize = new Size(63, 0);
            cmbPeriodIntervalUnit.Name = "cmbPeriodIntervalUnit";
            cmbPeriodIntervalUnit.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodIntervalUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodIntervalUnit.Size = new Size(100, 25);
            cmbPeriodIntervalUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodIntervalUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodIntervalUnit.SymbolSize = 24;
            cmbPeriodIntervalUnit.TabIndex = 2;
            cmbPeriodIntervalUnit.Text = "секунд";
            cmbPeriodIntervalUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodIntervalUnit.Watermark = "";
            // 
            // nudPeriodInterval
            // 
            nudPeriodInterval.FillColor = Color.FromArgb(42, 46, 57);
            nudPeriodInterval.Font = new Font("Segoe UI", 9.75F);
            nudPeriodInterval.ForeColor = Color.White;
            nudPeriodInterval.Location = new Point(189, 282);
            nudPeriodInterval.Margin = new Padding(4, 5, 4, 5);
            nudPeriodInterval.Maximum = 1440D;
            nudPeriodInterval.Minimum = 1D;
            nudPeriodInterval.MinimumSize = new Size(1, 16);
            nudPeriodInterval.Name = "nudPeriodInterval";
            nudPeriodInterval.Padding = new Padding(5);
            nudPeriodInterval.RectColor = Color.FromArgb(65, 71, 84);
            nudPeriodInterval.RectHoverColor = Color.BlueViolet;
            nudPeriodInterval.RectPressColor = Color.Indigo;
            nudPeriodInterval.ShowText = false;
            nudPeriodInterval.Size = new Size(100, 25);
            nudPeriodInterval.TabIndex = 1;
            nudPeriodInterval.Text = "60";
            nudPeriodInterval.TextAlignment = ContentAlignment.MiddleCenter;
            nudPeriodInterval.Value = 60;
            // 
            // lblPeriodInterval
            // 
            lblPeriodInterval.AutoSize = true;
            lblPeriodInterval.BackColor = Color.Transparent;
            lblPeriodInterval.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodInterval.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodInterval.Location = new Point(9, 287);
            lblPeriodInterval.Name = "lblPeriodInterval";
            lblPeriodInterval.Size = new Size(174, 13);
            lblPeriodInterval.TabIndex = 0;
            lblPeriodInterval.Text = "Интервал отправки каждый(е):";
            // 
            // chkPeriodEndless
            // 
            chkPeriodEndless.BackColor = Color.Transparent;
            chkPeriodEndless.CheckBoxColor = Color.BlueViolet;
            chkPeriodEndless.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodEndless.ForeColor = Color.White;
            chkPeriodEndless.Location = new Point(248, 245);
            chkPeriodEndless.MinimumSize = new Size(1, 1);
            chkPeriodEndless.Name = "chkPeriodEndless";
            chkPeriodEndless.Size = new Size(95, 25);
            chkPeriodEndless.TabIndex = 7;
            chkPeriodEndless.Text = "Бессрочно";
            // 
            // dtpPeriodEndTime
            // 
            dtpPeriodEndTime.FillColor = Color.FromArgb(42, 46, 57);
            dtpPeriodEndTime.Font = new Font("Segoe UI", 9.75F);
            dtpPeriodEndTime.ForeColor = Color.White;
            dtpPeriodEndTime.Location = new Point(138, 245);
            dtpPeriodEndTime.Margin = new Padding(4, 5, 4, 5);
            dtpPeriodEndTime.MaxLength = 8;
            dtpPeriodEndTime.MinimumSize = new Size(63, 0);
            dtpPeriodEndTime.Name = "dtpPeriodEndTime";
            dtpPeriodEndTime.Padding = new Padding(0, 0, 30, 2);
            dtpPeriodEndTime.RectColor = Color.FromArgb(65, 71, 84);
            dtpPeriodEndTime.Size = new Size(100, 25);
            dtpPeriodEndTime.Style = Sunny.UI.UIStyle.Custom;
            dtpPeriodEndTime.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpPeriodEndTime.SymbolDropDown = 61555;
            dtpPeriodEndTime.SymbolNormal = 61555;
            dtpPeriodEndTime.SymbolSize = 24;
            dtpPeriodEndTime.TabIndex = 52;
            dtpPeriodEndTime.Text = "23:59:59";
            dtpPeriodEndTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpPeriodEndTime.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpPeriodEndTime.Value = new DateTime(2026, 9, 25, 23, 59, 59, 0);
            dtpPeriodEndTime.Watermark = "";
            // 
            // lblPeriodEndTime
            // 
            lblPeriodEndTime.AutoSize = true;
            lblPeriodEndTime.BackColor = Color.Transparent;
            lblPeriodEndTime.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodEndTime.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodEndTime.Location = new Point(138, 225);
            lblPeriodEndTime.Name = "lblPeriodEndTime";
            lblPeriodEndTime.Size = new Size(44, 13);
            lblPeriodEndTime.TabIndex = 52;
            lblPeriodEndTime.Text = "Время:";
            // 
            // dtpPeriodEnd
            // 
            dtpPeriodEnd.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpPeriodEnd.DateFormat = "dd-MM-yyyy";
            dtpPeriodEnd.FillColor = Color.FromArgb(42, 46, 57);
            dtpPeriodEnd.Font = new Font("Segoe UI", 9.75F);
            dtpPeriodEnd.ForeColor = Color.White;
            dtpPeriodEnd.Location = new Point(9, 245);
            dtpPeriodEnd.Margin = new Padding(4, 5, 4, 5);
            dtpPeriodEnd.MaxLength = 10;
            dtpPeriodEnd.MinimumSize = new Size(63, 0);
            dtpPeriodEnd.Name = "dtpPeriodEnd";
            dtpPeriodEnd.Padding = new Padding(0, 0, 30, 2);
            dtpPeriodEnd.RectColor = Color.FromArgb(65, 71, 84);
            dtpPeriodEnd.Size = new Size(120, 25);
            dtpPeriodEnd.Style = Sunny.UI.UIStyle.Custom;
            dtpPeriodEnd.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpPeriodEnd.SymbolDropDown = 61555;
            dtpPeriodEnd.SymbolNormal = 61555;
            dtpPeriodEnd.SymbolSize = 24;
            dtpPeriodEnd.TabIndex = 6;
            dtpPeriodEnd.Text = "25-09-2026";
            dtpPeriodEnd.TextAlignment = ContentAlignment.MiddleLeft;
            dtpPeriodEnd.Value = new DateTime(2026, 9, 25, 0, 0, 0, 0);
            dtpPeriodEnd.Watermark = "";
            // 
            // lblPeriodEnd
            // 
            lblPeriodEnd.AutoSize = true;
            lblPeriodEnd.BackColor = Color.Transparent;
            lblPeriodEnd.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodEnd.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodEnd.Location = new Point(9, 225);
            lblPeriodEnd.Name = "lblPeriodEnd";
            lblPeriodEnd.Size = new Size(75, 13);
            lblPeriodEnd.TabIndex = 5;
            lblPeriodEnd.Text = "Закончить в:";
            // 
            // dtpPeriodStartTime
            // 
            dtpPeriodStartTime.FillColor = Color.FromArgb(42, 46, 57);
            dtpPeriodStartTime.Font = new Font("Segoe UI", 9.75F);
            dtpPeriodStartTime.ForeColor = Color.White;
            dtpPeriodStartTime.Location = new Point(138, 190);
            dtpPeriodStartTime.Margin = new Padding(4, 5, 4, 5);
            dtpPeriodStartTime.MaxLength = 8;
            dtpPeriodStartTime.MinimumSize = new Size(63, 0);
            dtpPeriodStartTime.Name = "dtpPeriodStartTime";
            dtpPeriodStartTime.Padding = new Padding(0, 0, 30, 2);
            dtpPeriodStartTime.RectColor = Color.FromArgb(65, 71, 84);
            dtpPeriodStartTime.Size = new Size(100, 25);
            dtpPeriodStartTime.Style = Sunny.UI.UIStyle.Custom;
            dtpPeriodStartTime.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpPeriodStartTime.SymbolDropDown = 61555;
            dtpPeriodStartTime.SymbolNormal = 61555;
            dtpPeriodStartTime.SymbolSize = 24;
            dtpPeriodStartTime.TabIndex = 51;
            dtpPeriodStartTime.Text = "00:00:00";
            dtpPeriodStartTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpPeriodStartTime.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpPeriodStartTime.Value = new DateTime(2026, 9, 25, 0, 0, 0, 0);
            dtpPeriodStartTime.Watermark = "";
            // 
            // lblPeriodStartTime
            // 
            lblPeriodStartTime.AutoSize = true;
            lblPeriodStartTime.BackColor = Color.Transparent;
            lblPeriodStartTime.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodStartTime.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodStartTime.Location = new Point(138, 170);
            lblPeriodStartTime.Name = "lblPeriodStartTime";
            lblPeriodStartTime.Size = new Size(44, 13);
            lblPeriodStartTime.TabIndex = 51;
            lblPeriodStartTime.Text = "Время:";
            // 
            // dtpPeriodStart
            // 
            dtpPeriodStart.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpPeriodStart.DateFormat = "dd-MM-yyyy";
            dtpPeriodStart.FillColor = Color.FromArgb(42, 46, 57);
            dtpPeriodStart.Font = new Font("Segoe UI", 9.75F);
            dtpPeriodStart.ForeColor = Color.White;
            dtpPeriodStart.Location = new Point(9, 190);
            dtpPeriodStart.Margin = new Padding(4, 5, 4, 5);
            dtpPeriodStart.MaxLength = 10;
            dtpPeriodStart.MinimumSize = new Size(63, 0);
            dtpPeriodStart.Name = "dtpPeriodStart";
            dtpPeriodStart.Padding = new Padding(0, 0, 30, 2);
            dtpPeriodStart.RectColor = Color.FromArgb(65, 71, 84);
            dtpPeriodStart.Size = new Size(120, 25);
            dtpPeriodStart.Style = Sunny.UI.UIStyle.Custom;
            dtpPeriodStart.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpPeriodStart.SymbolDropDown = 61555;
            dtpPeriodStart.SymbolNormal = 61555;
            dtpPeriodStart.SymbolSize = 24;
            dtpPeriodStart.TabIndex = 4;
            dtpPeriodStart.Text = "13-09-2026";
            dtpPeriodStart.TextAlignment = ContentAlignment.MiddleLeft;
            dtpPeriodStart.Value = new DateTime(2026, 9, 13, 0, 0, 0, 0);
            dtpPeriodStart.Watermark = "";
            // 
            // lblPeriodStart
            // 
            lblPeriodStart.AutoSize = true;
            lblPeriodStart.BackColor = Color.Transparent;
            lblPeriodStart.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodStart.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodStart.Location = new Point(9, 170);
            lblPeriodStart.Name = "lblPeriodStart";
            lblPeriodStart.Size = new Size(55, 13);
            lblPeriodStart.TabIndex = 3;
            lblPeriodStart.Text = "Начать с:";
            // 
            // chkPeriodSendFirst
            // 
            chkPeriodSendFirst.BackColor = Color.Transparent;
            chkPeriodSendFirst.CheckBoxColor = Color.BlueViolet;
            chkPeriodSendFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPeriodSendFirst.ForeColor = Color.White;
            chkPeriodSendFirst.Location = new Point(248, 190);
            chkPeriodSendFirst.MinimumSize = new Size(1, 1);
            chkPeriodSendFirst.Name = "chkPeriodSendFirst";
            chkPeriodSendFirst.Size = new Size(235, 25);
            chkPeriodSendFirst.TabIndex = 58;
            chkPeriodSendFirst.Text = "Отправить первое сообщение сразу";
            // 
            // radPeriodSpecial
            // 
            radPeriodSpecial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radPeriodSpecial.ForeColor = Color.White;
            radPeriodSpecial.Location = new Point(529, 136);
            radPeriodSpecial.MinimumSize = new Size(1, 1);
            radPeriodSpecial.Name = "radPeriodSpecial";
            radPeriodSpecial.RadioButtonColor = Color.FromArgb(102, 58, 183);
            radPeriodSpecial.RadioButtonSize = 14;
            radPeriodSpecial.Size = new Size(104, 25);
            radPeriodSpecial.Style = Sunny.UI.UIStyle.Custom;
            radPeriodSpecial.TabIndex = 79;
            radPeriodSpecial.Text = "Специальные";
            // 
            // radPeriodCalendar
            // 
            radPeriodCalendar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radPeriodCalendar.ForeColor = Color.White;
            radPeriodCalendar.Location = new Point(414, 136);
            radPeriodCalendar.MinimumSize = new Size(1, 1);
            radPeriodCalendar.Name = "radPeriodCalendar";
            radPeriodCalendar.RadioButtonColor = Color.FromArgb(102, 58, 183);
            radPeriodCalendar.RadioButtonSize = 14;
            radPeriodCalendar.Size = new Size(109, 25);
            radPeriodCalendar.Style = Sunny.UI.UIStyle.Custom;
            radPeriodCalendar.TabIndex = 78;
            radPeriodCalendar.Text = "По календарю";
            // 
            // radPeriodInterval
            // 
            radPeriodInterval.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radPeriodInterval.ForeColor = Color.White;
            radPeriodInterval.Location = new Point(317, 136);
            radPeriodInterval.MinimumSize = new Size(1, 1);
            radPeriodInterval.Name = "radPeriodInterval";
            radPeriodInterval.RadioButtonColor = Color.FromArgb(102, 58, 183);
            radPeriodInterval.RadioButtonSize = 14;
            radPeriodInterval.Size = new Size(91, 25);
            radPeriodInterval.Style = Sunny.UI.UIStyle.Custom;
            radPeriodInterval.TabIndex = 77;
            radPeriodInterval.Text = "Интервалы";
            // 
            // cmbPeriodType
            // 
            cmbPeriodType.DataSource = null;
            cmbPeriodType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodType.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodType.Font = new Font("Segoe UI", 9F);
            cmbPeriodType.ForeColor = Color.White;
            cmbPeriodType.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodType.ItemForeColor = Color.White;
            cmbPeriodType.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbPeriodType.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbPeriodType.Items.AddRange(new object[] { "Каждый день", "Каждый N время", "По дням недели", "По числам месяца", "Кастомные настройки", "Рандомно" });
            cmbPeriodType.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbPeriodType.ItemSelectForeColor = Color.White;
            cmbPeriodType.Location = new Point(9, 136);
            cmbPeriodType.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodType.MinimumSize = new Size(63, 0);
            cmbPeriodType.Name = "cmbPeriodType";
            cmbPeriodType.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodType.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodType.Size = new Size(304, 25);
            cmbPeriodType.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodType.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodType.SymbolSize = 24;
            cmbPeriodType.TabIndex = 3;
            cmbPeriodType.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodType.Watermark = "Список типов";
            // 
            // lblPeriodType
            // 
            lblPeriodType.AutoSize = true;
            lblPeriodType.BackColor = Color.Transparent;
            lblPeriodType.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblPeriodType.ForeColor = Color.FromArgb(180, 180, 180);
            lblPeriodType.Location = new Point(9, 118);
            lblPeriodType.Name = "lblPeriodType";
            lblPeriodType.Size = new Size(116, 13);
            lblPeriodType.TabIndex = 26;
            lblPeriodType.Text = "Тип периодичности:";
            // 
            // lblPeriodTemplateHint
            // 
            lblPeriodTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblPeriodTemplateHint.ForeColor = Color.DarkGray;
            lblPeriodTemplateHint.Location = new Point(9, 69);
            lblPeriodTemplateHint.Name = "lblPeriodTemplateHint";
            lblPeriodTemplateHint.Size = new Size(644, 45);
            lblPeriodTemplateHint.TabIndex = 24;
            lblPeriodTemplateHint.Text = resources.GetString("lblPeriodTemplateHint.Text");
            // 
            // txtPeriodCustomText
            // 
            txtPeriodCustomText.ButtonFillColor = Color.Transparent;
            txtPeriodCustomText.ButtonStyleInherited = false;
            txtPeriodCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtPeriodCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPeriodCustomText.ForeColor = Color.White;
            txtPeriodCustomText.Location = new Point(9, 40);
            txtPeriodCustomText.Margin = new Padding(4, 5, 4, 5);
            txtPeriodCustomText.MinimumSize = new Size(1, 16);
            txtPeriodCustomText.Name = "txtPeriodCustomText";
            txtPeriodCustomText.Padding = new Padding(5);
            txtPeriodCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtPeriodCustomText.ShowText = false;
            txtPeriodCustomText.Size = new Size(644, 25);
            txtPeriodCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtPeriodCustomText.TabIndex = 23;
            txtPeriodCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtPeriodCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbPeriodTemplate
            // 
            cmbPeriodTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPeriodTemplate.DataSource = null;
            cmbPeriodTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPeriodTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbPeriodTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbPeriodTemplate.ForeColor = Color.White;
            cmbPeriodTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbPeriodTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbPeriodTemplate.Location = new Point(9, 9);
            cmbPeriodTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbPeriodTemplate.MinimumSize = new Size(63, 0);
            cmbPeriodTemplate.Name = "cmbPeriodTemplate";
            cmbPeriodTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbPeriodTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbPeriodTemplate.Size = new Size(644, 25);
            cmbPeriodTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbPeriodTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPeriodTemplate.SymbolSize = 24;
            cmbPeriodTemplate.TabIndex = 22;
            cmbPeriodTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPeriodTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // PeriodicTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpPeriodic);
            Name = "PeriodicTabControl";
            Size = new Size(696, 483);
            grpPeriodic.ResumeLayout(false);
            pnlPeriodButtons.ResumeLayout(false);
            pnlPeriodInner.ResumeLayout(false);
            pnlPeriodContent.ResumeLayout(false);
            pnlPeriodContent.PerformLayout();
            grpPeriodHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpPeriodic;
        private Sunny.UI.UIPanel pnlPeriodButtons;
        private Sunny.UI.UICheckBox chkPeriodicManualConfirm;
        private Sunny.UI.UIButton btnSavePeriodic;
        private Sunny.UI.UIButton btnStartPeriodic;
        private Panel pnlPeriodInner;
        private Panel pnlPeriodContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbPeriodTemplate;
        private Sunny.UI.UITextBox txtPeriodCustomText;
        private Label lblPeriodTemplateHint;

        // Period Type
        private Label lblPeriodType;
        private Sunny.UI.UIComboBox cmbPeriodType;
        private Sunny.UI.UIRadioButton radPeriodInterval;
        private Sunny.UI.UIRadioButton radPeriodCalendar;
        private Sunny.UI.UIRadioButton radPeriodSpecial;

        // Date/Time Settings
        private Label lblPeriodStart;
        private Sunny.UI.UIDatePicker dtpPeriodStart;
        private Label lblPeriodStartTime;
        private Sunny.UI.UITimePicker dtpPeriodStartTime;
        private Label lblPeriodEnd;
        private Sunny.UI.UIDatePicker dtpPeriodEnd;
        private Label lblPeriodEndTime;
        private Sunny.UI.UITimePicker dtpPeriodEndTime;
        private Sunny.UI.UICheckBox chkPeriodSendFirst;
        private Sunny.UI.UICheckBox chkPeriodEndless;

        // Interval Settings
        private Label lblPeriodInterval;
        private Sunny.UI.UIIntegerUpDown nudPeriodInterval;
        private Sunny.UI.UIComboBox cmbPeriodIntervalUnit;

        // Custom Settings
        private Label lblPeriodCustomCount;
        private Sunny.UI.UIIntegerUpDown nudPeriodCustomCount;
        private Sunny.UI.UIComboBox cmbPeriodCustomUnit;

        // Days of Week
        private Label lblPeriodDays;
        private Sunny.UI.UICheckBox chkPeriodDayMon;
        private Sunny.UI.UICheckBox chkPeriodDayTue;
        private Sunny.UI.UICheckBox chkPeriodDayWed;
        private Sunny.UI.UICheckBox chkPeriodDayThu;
        private Sunny.UI.UICheckBox chkPeriodDayFri;
        private Sunny.UI.UICheckBox chkPeriodDaySat;
        private Sunny.UI.UICheckBox chkPeriodDaySun;

        // Month Days
        private Label lblPeriodMonthDays;
        private Sunny.UI.UITextBox txtPeriodMonthDays;

        // Random Time
        private Sunny.UI.UICheckBox chkPeriodRandomTime;
        private Sunny.UI.UIIntegerUpDown nudPeriodRandomMin;
        private Label lblPeriodRandomTo;
        private Sunny.UI.UIIntegerUpDown nudPeriodRandomMax;
        private Sunny.UI.UIComboBox cmbPeriodRandomUnit;

        // Max Sends
        private Label lblPeriodMaxSends;
        private Sunny.UI.UIIntegerUpDown nudPeriodMaxSends;
        private Label lblPeriodMaxHint;

        // Retry Settings
        private Label lblPeriodRetry;
        private Sunny.UI.UIIntegerUpDown nudPeriodRetry;
        private Label lblPeriodRetryUnit;

        // Pause Settings
        private Label lblPeriodPause;
        private Sunny.UI.UIIntegerUpDown nudPeriodPause;
        private Sunny.UI.UIComboBox cmbPeriodPauseUnit;

        // Timezone
        private Label lblPeriodTimezone;
        private Sunny.UI.UIComboBox cmbPeriodTimezone;

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
        private Sunny.UI.UICheckBox chkSkipIfInactive;
        private Sunny.UI.UICheckBox chkProtectContent;
        private Sunny.UI.UICheckBox chkHideSpoiler;
        private Sunny.UI.UICheckBox chkDeletePrevious;

        // History
        private Sunny.UI.UIGroupBox grpPeriodHistory;
        private FlowLayoutPanel flpPeriodHistory;
    }
}