namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class ScheduleTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleTabControl));
            grpSchedule = new Sunny.UI.UIGroupBox();
            pnlScheduleButtons = new Sunny.UI.UIPanel();
            chkScheduleManualConfirm = new Sunny.UI.UICheckBox();
            btnSaveSchedule = new Sunny.UI.UIButton();
            btnStartSchedule = new Sunny.UI.UIButton();
            pnlScheduleInner = new Panel();
            pnlScheduleContent = new Panel();
            grpScheduleHistory = new Sunny.UI.UIGroupBox();
            flpScheduleHistory = new FlowLayoutPanel();
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
            cmbScheduleTimezone = new Sunny.UI.UIComboBox();
            lblScheduleTimezone = new Label();
            cmbScheduleRandomUnit = new Sunny.UI.UIComboBox();
            nudScheduleRandomMax = new Sunny.UI.UIIntegerUpDown();
            lblScheduleRandomTo = new Label();
            nudScheduleRandomMin = new Sunny.UI.UIIntegerUpDown();
            chkScheduleRandomDelay = new Sunny.UI.UICheckBox();
            dtpScheduleEndTime = new Sunny.UI.UITimePicker();
            dtpScheduleEndDate = new Sunny.UI.UIDatePicker();
            lblScheduleEndDate = new Label();
            dtpScheduleStartTime = new Sunny.UI.UITimePicker();
            dtpScheduleStartDate = new Sunny.UI.UIDatePicker();
            lblSchedulePeriod = new Label();
            grpScheduleList = new Sunny.UI.UIGroupBox();
            flpScheduleList = new FlowLayoutPanel();
            btnAddScheduleTime = new Sunny.UI.UIButton();
            dtpScheduleTime = new Sunny.UI.UITimePicker();
            lblScheduleTime = new Label();
            chkScheduleDaySun = new Sunny.UI.UICheckBox();
            chkScheduleDaySat = new Sunny.UI.UICheckBox();
            chkScheduleDayFri = new Sunny.UI.UICheckBox();
            chkScheduleDayThu = new Sunny.UI.UICheckBox();
            chkScheduleDayWed = new Sunny.UI.UICheckBox();
            chkScheduleDayTue = new Sunny.UI.UICheckBox();
            chkScheduleDayMon = new Sunny.UI.UICheckBox();
            lblScheduleDays = new Label();
            lblScheduleTemplateHint = new Label();
            txtScheduleCustomText = new Sunny.UI.UITextBox();
            cmbScheduleTemplate = new Sunny.UI.UIComboBox();
            chkScheduleEndless = new Sunny.UI.UICheckBox();
            grpSchedule.SuspendLayout();
            pnlScheduleButtons.SuspendLayout();
            pnlScheduleInner.SuspendLayout();
            pnlScheduleContent.SuspendLayout();
            grpScheduleHistory.SuspendLayout();
            grpScheduleList.SuspendLayout();
            SuspendLayout();
            // 
            // grpSchedule
            // 
            grpSchedule.BackColor = Color.FromArgb(35, 39, 48);
            grpSchedule.Controls.Add(pnlScheduleButtons);
            grpSchedule.Controls.Add(pnlScheduleInner);
            grpSchedule.Dock = DockStyle.Fill;
            grpSchedule.FillColor = Color.Transparent;
            grpSchedule.FillColor2 = Color.Transparent;
            grpSchedule.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpSchedule.ForeColor = Color.White;
            grpSchedule.Location = new Point(0, 0);
            grpSchedule.Margin = new Padding(4, 5, 4, 5);
            grpSchedule.MinimumSize = new Size(1, 1);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Padding = new Padding(0, 32, 0, 0);
            grpSchedule.Radius = 15;
            grpSchedule.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpSchedule.RectColor = Color.FromArgb(58, 58, 69);
            grpSchedule.Size = new Size(696, 483);
            grpSchedule.Style = Sunny.UI.UIStyle.Custom;
            grpSchedule.TabIndex = 5;
            grpSchedule.Text = "Настройки по расписанию отправки";
            grpSchedule.TextAlignment = ContentAlignment.MiddleLeft;
            grpSchedule.TitleInterval = 8;
            grpSchedule.TitleTop = 14;
            // 
            // pnlScheduleButtons
            // 
            pnlScheduleButtons.Controls.Add(chkScheduleManualConfirm);
            pnlScheduleButtons.Controls.Add(btnSaveSchedule);
            pnlScheduleButtons.Controls.Add(btnStartSchedule);
            pnlScheduleButtons.Dock = DockStyle.Bottom;
            pnlScheduleButtons.FillColor = Color.Transparent;
            pnlScheduleButtons.FillColor2 = Color.Transparent;
            pnlScheduleButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlScheduleButtons.ForeColor = Color.Transparent;
            pnlScheduleButtons.Location = new Point(0, 438);
            pnlScheduleButtons.Margin = new Padding(4, 5, 4, 5);
            pnlScheduleButtons.MinimumSize = new Size(1, 1);
            pnlScheduleButtons.Name = "pnlScheduleButtons";
            pnlScheduleButtons.Radius = 0;
            pnlScheduleButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlScheduleButtons.RectDisableColor = Color.Transparent;
            pnlScheduleButtons.Size = new Size(696, 45);
            pnlScheduleButtons.TabIndex = 23;
            pnlScheduleButtons.Text = null;
            pnlScheduleButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkScheduleManualConfirm
            // 
            chkScheduleManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkScheduleManualConfirm.BackColor = Color.Transparent;
            chkScheduleManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkScheduleManualConfirm.Checked = true;
            chkScheduleManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleManualConfirm.ForeColor = Color.White;
            chkScheduleManualConfirm.Location = new Point(46, 10);
            chkScheduleManualConfirm.MinimumSize = new Size(1, 1);
            chkScheduleManualConfirm.Name = "chkScheduleManualConfirm";
            chkScheduleManualConfirm.Size = new Size(333, 25);
            chkScheduleManualConfirm.TabIndex = 27;
            chkScheduleManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSaveSchedule
            // 
            btnSaveSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveSchedule.FillColor = Color.BlueViolet;
            btnSaveSchedule.FillColor2 = Color.Transparent;
            btnSaveSchedule.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSaveSchedule.FillHoverColor = Color.DarkOrchid;
            btnSaveSchedule.FillPressColor = Color.DarkViolet;
            btnSaveSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveSchedule.Location = new Point(389, 5);
            btnSaveSchedule.MinimumSize = new Size(1, 1);
            btnSaveSchedule.Name = "btnSaveSchedule";
            btnSaveSchedule.Radius = 8;
            btnSaveSchedule.RectColor = Color.Transparent;
            btnSaveSchedule.Size = new Size(150, 35);
            btnSaveSchedule.Style = Sunny.UI.UIStyle.Custom;
            btnSaveSchedule.TabIndex = 13;
            btnSaveSchedule.Text = "Сохранить настройки";
            btnSaveSchedule.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnStartSchedule
            // 
            btnStartSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartSchedule.FillColor = Color.Indigo;
            btnStartSchedule.FillColor2 = Color.Transparent;
            btnStartSchedule.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnStartSchedule.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnStartSchedule.FillPressColor = Color.FromArgb(109, 40, 217);
            btnStartSchedule.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartSchedule.Location = new Point(543, 5);
            btnStartSchedule.MinimumSize = new Size(1, 1);
            btnStartSchedule.Name = "btnStartSchedule";
            btnStartSchedule.Radius = 8;
            btnStartSchedule.RectColor = Color.Transparent;
            btnStartSchedule.Size = new Size(150, 35);
            btnStartSchedule.Style = Sunny.UI.UIStyle.Custom;
            btnStartSchedule.TabIndex = 14;
            btnStartSchedule.Text = "Начать сеанс";
            btnStartSchedule.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlScheduleInner
            // 
            pnlScheduleInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlScheduleInner.AutoScroll = true;
            pnlScheduleInner.Controls.Add(pnlScheduleContent);
            pnlScheduleInner.Location = new Point(3, 25);
            pnlScheduleInner.Name = "pnlScheduleInner";
            pnlScheduleInner.Size = new Size(693, 413);
            pnlScheduleInner.TabIndex = 22;
            // 
            // pnlScheduleContent
            // 
            pnlScheduleContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlScheduleContent.Controls.Add(grpScheduleHistory);
            pnlScheduleContent.Controls.Add(chkDeletePrevious);
            pnlScheduleContent.Controls.Add(chkHideSpoiler);
            pnlScheduleContent.Controls.Add(chkProtectContent);
            pnlScheduleContent.Controls.Add(chkSkipIfInactive);
            pnlScheduleContent.Controls.Add(chkNoAuthorMention);
            pnlScheduleContent.Controls.Add(chkSilentSend);
            pnlScheduleContent.Controls.Add(chkDisablePreview);
            pnlScheduleContent.Controls.Add(chkSendTemplateFirst);
            pnlScheduleContent.Controls.Add(chkNotifyError);
            pnlScheduleContent.Controls.Add(cmbNotifyError1);
            pnlScheduleContent.Controls.Add(lblNotifyErrorOr);
            pnlScheduleContent.Controls.Add(cmbNotifyError2);
            pnlScheduleContent.Controls.Add(chkNotifyComplete);
            pnlScheduleContent.Controls.Add(cmbNotifyComplete1);
            pnlScheduleContent.Controls.Add(lblNotifyCompleteOr);
            pnlScheduleContent.Controls.Add(cmbNotifyComplete2);
            pnlScheduleContent.Controls.Add(chkNotifySuccess);
            pnlScheduleContent.Controls.Add(cmbNotifySuccess1);
            pnlScheduleContent.Controls.Add(lblNotifySuccessOr);
            pnlScheduleContent.Controls.Add(cmbNotifySuccess2);
            pnlScheduleContent.Controls.Add(cmbScheduleTimezone);
            pnlScheduleContent.Controls.Add(lblScheduleTimezone);
            pnlScheduleContent.Controls.Add(cmbScheduleRandomUnit);
            pnlScheduleContent.Controls.Add(nudScheduleRandomMax);
            pnlScheduleContent.Controls.Add(lblScheduleRandomTo);
            pnlScheduleContent.Controls.Add(nudScheduleRandomMin);
            pnlScheduleContent.Controls.Add(chkScheduleRandomDelay);
            pnlScheduleContent.Controls.Add(dtpScheduleEndTime);
            pnlScheduleContent.Controls.Add(dtpScheduleEndDate);
            pnlScheduleContent.Controls.Add(lblScheduleEndDate);
            pnlScheduleContent.Controls.Add(dtpScheduleStartTime);
            pnlScheduleContent.Controls.Add(dtpScheduleStartDate);
            pnlScheduleContent.Controls.Add(lblSchedulePeriod);
            pnlScheduleContent.Controls.Add(grpScheduleList);
            pnlScheduleContent.Controls.Add(btnAddScheduleTime);
            pnlScheduleContent.Controls.Add(dtpScheduleTime);
            pnlScheduleContent.Controls.Add(lblScheduleTime);
            pnlScheduleContent.Controls.Add(chkScheduleDaySun);
            pnlScheduleContent.Controls.Add(chkScheduleDaySat);
            pnlScheduleContent.Controls.Add(chkScheduleDayFri);
            pnlScheduleContent.Controls.Add(chkScheduleDayThu);
            pnlScheduleContent.Controls.Add(chkScheduleDayWed);
            pnlScheduleContent.Controls.Add(chkScheduleDayTue);
            pnlScheduleContent.Controls.Add(chkScheduleDayMon);
            pnlScheduleContent.Controls.Add(lblScheduleDays);
            pnlScheduleContent.Controls.Add(lblScheduleTemplateHint);
            pnlScheduleContent.Controls.Add(txtScheduleCustomText);
            pnlScheduleContent.Controls.Add(cmbScheduleTemplate);
            pnlScheduleContent.Location = new Point(0, 0);
            pnlScheduleContent.MinimumSize = new Size(673, 0);
            pnlScheduleContent.Name = "pnlScheduleContent";
            pnlScheduleContent.Padding = new Padding(9, 0, 9, 0);
            pnlScheduleContent.Size = new Size(676, 1330);
            pnlScheduleContent.TabIndex = 0;
            // 
            // grpScheduleHistory
            // 
            grpScheduleHistory.Controls.Add(flpScheduleHistory);
            grpScheduleHistory.FillColor = Color.Transparent;
            grpScheduleHistory.FillColor2 = Color.Transparent;
            grpScheduleHistory.FillDisableColor = Color.Transparent;
            grpScheduleHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpScheduleHistory.ForeColor = SystemColors.ActiveBorder;
            grpScheduleHistory.ForeDisableColor = Color.Transparent;
            grpScheduleHistory.Location = new Point(9, 818);
            grpScheduleHistory.Margin = new Padding(4, 5, 4, 5);
            grpScheduleHistory.MinimumSize = new Size(1, 1);
            grpScheduleHistory.Name = "grpScheduleHistory";
            grpScheduleHistory.Padding = new Padding(5, 32, 5, 5);
            grpScheduleHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpScheduleHistory.RectDisableColor = Color.Transparent;
            grpScheduleHistory.Size = new Size(658, 290);
            grpScheduleHistory.TabIndex = 28;
            grpScheduleHistory.Text = "История отправок:";
            grpScheduleHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpScheduleHistory.TitleTop = 10;
            // 
            // flpScheduleHistory
            // 
            flpScheduleHistory.AutoScroll = true;
            flpScheduleHistory.FlowDirection = FlowDirection.TopDown;
            flpScheduleHistory.Location = new Point(10, 20);
            flpScheduleHistory.Name = "flpScheduleHistory";
            flpScheduleHistory.Size = new Size(636, 259);
            flpScheduleHistory.TabIndex = 10;
            flpScheduleHistory.WrapContents = false;
            // 
            // chkDeletePrevious
            // 
            chkDeletePrevious.BackColor = Color.Transparent;
            chkDeletePrevious.CheckBoxColor = Color.BlueViolet;
            chkDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDeletePrevious.ForeColor = Color.White;
            chkDeletePrevious.Location = new Point(286, 748);
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
            chkHideSpoiler.Location = new Point(9, 748);
            chkHideSpoiler.MinimumSize = new Size(1, 1);
            chkHideSpoiler.Name = "chkHideSpoiler";
            chkHideSpoiler.Size = new Size(264, 25);
            chkHideSpoiler.TabIndex = 110;
            chkHideSpoiler.Text = "Скрыть содержимое как спойлер";
            // 
            // chkProtectContent
            // 
            chkProtectContent.BackColor = Color.Transparent;
            chkProtectContent.CheckBoxColor = Color.BlueViolet;
            chkProtectContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkProtectContent.ForeColor = Color.White;
            chkProtectContent.Location = new Point(286, 718);
            chkProtectContent.MinimumSize = new Size(1, 1);
            chkProtectContent.Name = "chkProtectContent";
            chkProtectContent.Size = new Size(346, 25);
            chkProtectContent.TabIndex = 109;
            chkProtectContent.Text = "Защитить от копирования и пересылки";
            // 
            // chkSkipIfInactive
            // 
            chkSkipIfInactive.BackColor = Color.Transparent;
            chkSkipIfInactive.CheckBoxColor = Color.BlueViolet;
            chkSkipIfInactive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSkipIfInactive.ForeColor = Color.White;
            chkSkipIfInactive.Location = new Point(9, 718);
            chkSkipIfInactive.MinimumSize = new Size(1, 1);
            chkSkipIfInactive.Name = "chkSkipIfInactive";
            chkSkipIfInactive.Size = new Size(264, 25);
            chkSkipIfInactive.TabIndex = 107;
            chkSkipIfInactive.Text = "Пропускать если активности нет";
            // 
            // chkNoAuthorMention
            // 
            chkNoAuthorMention.BackColor = Color.Transparent;
            chkNoAuthorMention.CheckBoxColor = Color.BlueViolet;
            chkNoAuthorMention.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNoAuthorMention.ForeColor = Color.White;
            chkNoAuthorMention.Location = new Point(286, 688);
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
            chkSilentSend.Location = new Point(9, 688);
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
            chkDisablePreview.Location = new Point(286, 658);
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
            chkSendTemplateFirst.Location = new Point(9, 658);
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
            chkNotifyError.Location = new Point(9, 613);
            chkNotifyError.MinimumSize = new Size(1, 1);
            chkNotifyError.Name = "chkNotifyError";
            chkNotifyError.Size = new Size(265, 25);
            chkNotifyError.TabIndex = 100;
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
            cmbNotifyError1.Location = new Point(290, 613);
            cmbNotifyError1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyError1.MinimumSize = new Size(63, 0);
            cmbNotifyError1.Name = "cmbNotifyError1";
            cmbNotifyError1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyError1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyError1.Size = new Size(146, 25);
            cmbNotifyError1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyError1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyError1.SymbolSize = 24;
            cmbNotifyError1.TabIndex = 96;
            cmbNotifyError1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError1.Watermark = "Куда отправить";
            // 
            // lblNotifyErrorOr
            // 
            lblNotifyErrorOr.AutoSize = true;
            lblNotifyErrorOr.BackColor = Color.Transparent;
            lblNotifyErrorOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyErrorOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyErrorOr.Location = new Point(442, 618);
            lblNotifyErrorOr.Name = "lblNotifyErrorOr";
            lblNotifyErrorOr.Size = new Size(39, 13);
            lblNotifyErrorOr.TabIndex = 103;
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
            cmbNotifyError2.Location = new Point(489, 613);
            cmbNotifyError2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyError2.MinimumSize = new Size(63, 0);
            cmbNotifyError2.Name = "cmbNotifyError2";
            cmbNotifyError2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyError2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyError2.Size = new Size(146, 25);
            cmbNotifyError2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyError2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyError2.SymbolSize = 24;
            cmbNotifyError2.TabIndex = 98;
            cmbNotifyError2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError2.Watermark = "Куда отправить";
            // 
            // chkNotifyComplete
            // 
            chkNotifyComplete.BackColor = Color.Transparent;
            chkNotifyComplete.CheckBoxColor = Color.BlueViolet;
            chkNotifyComplete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyComplete.ForeColor = Color.White;
            chkNotifyComplete.Location = new Point(9, 583);
            chkNotifyComplete.MinimumSize = new Size(1, 1);
            chkNotifyComplete.Name = "chkNotifyComplete";
            chkNotifyComplete.Size = new Size(265, 25);
            chkNotifyComplete.TabIndex = 93;
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
            cmbNotifyComplete1.Location = new Point(290, 583);
            cmbNotifyComplete1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete1.MinimumSize = new Size(63, 0);
            cmbNotifyComplete1.Name = "cmbNotifyComplete1";
            cmbNotifyComplete1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete1.Size = new Size(146, 25);
            cmbNotifyComplete1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete1.SymbolSize = 24;
            cmbNotifyComplete1.TabIndex = 94;
            cmbNotifyComplete1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete1.Watermark = "Куда отправить";
            // 
            // lblNotifyCompleteOr
            // 
            lblNotifyCompleteOr.AutoSize = true;
            lblNotifyCompleteOr.BackColor = Color.Transparent;
            lblNotifyCompleteOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyCompleteOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyCompleteOr.Location = new Point(442, 588);
            lblNotifyCompleteOr.Name = "lblNotifyCompleteOr";
            lblNotifyCompleteOr.Size = new Size(39, 13);
            lblNotifyCompleteOr.TabIndex = 102;
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
            cmbNotifyComplete2.Location = new Point(489, 583);
            cmbNotifyComplete2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete2.MinimumSize = new Size(63, 0);
            cmbNotifyComplete2.Name = "cmbNotifyComplete2";
            cmbNotifyComplete2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete2.Size = new Size(146, 25);
            cmbNotifyComplete2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete2.SymbolSize = 24;
            cmbNotifyComplete2.TabIndex = 97;
            cmbNotifyComplete2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete2.Watermark = "Куда отправить";
            // 
            // chkNotifySuccess
            // 
            chkNotifySuccess.BackColor = Color.Transparent;
            chkNotifySuccess.CheckBoxColor = Color.BlueViolet;
            chkNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifySuccess.ForeColor = Color.White;
            chkNotifySuccess.Location = new Point(9, 553);
            chkNotifySuccess.MinimumSize = new Size(1, 1);
            chkNotifySuccess.Name = "chkNotifySuccess";
            chkNotifySuccess.Size = new Size(265, 25);
            chkNotifySuccess.TabIndex = 92;
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
            cmbNotifySuccess1.Location = new Point(290, 553);
            cmbNotifySuccess1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifySuccess1.MinimumSize = new Size(63, 0);
            cmbNotifySuccess1.Name = "cmbNotifySuccess1";
            cmbNotifySuccess1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifySuccess1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifySuccess1.Size = new Size(146, 25);
            cmbNotifySuccess1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifySuccess1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifySuccess1.SymbolSize = 24;
            cmbNotifySuccess1.TabIndex = 95;
            cmbNotifySuccess1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifySuccess1.Watermark = "Куда отправить";
            // 
            // lblNotifySuccessOr
            // 
            lblNotifySuccessOr.AutoSize = true;
            lblNotifySuccessOr.BackColor = Color.Transparent;
            lblNotifySuccessOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifySuccessOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifySuccessOr.Location = new Point(442, 558);
            lblNotifySuccessOr.Name = "lblNotifySuccessOr";
            lblNotifySuccessOr.Size = new Size(39, 13);
            lblNotifySuccessOr.TabIndex = 101;
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
            cmbNotifySuccess2.Location = new Point(489, 553);
            cmbNotifySuccess2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifySuccess2.MinimumSize = new Size(63, 0);
            cmbNotifySuccess2.Name = "cmbNotifySuccess2";
            cmbNotifySuccess2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifySuccess2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifySuccess2.Size = new Size(146, 25);
            cmbNotifySuccess2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifySuccess2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifySuccess2.SymbolSize = 24;
            cmbNotifySuccess2.TabIndex = 99;
            cmbNotifySuccess2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifySuccess2.Watermark = "Куда отправить";
            // 
            // cmbScheduleTimezone
            // 
            cmbScheduleTimezone.DataSource = null;
            cmbScheduleTimezone.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbScheduleTimezone.FillColor = Color.FromArgb(42, 46, 57);
            cmbScheduleTimezone.Font = new Font("Segoe UI", 9F);
            cmbScheduleTimezone.ForeColor = Color.White;
            cmbScheduleTimezone.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbScheduleTimezone.ItemForeColor = Color.White;
            cmbScheduleTimezone.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbScheduleTimezone.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbScheduleTimezone.Items.AddRange(new object[] { "GMT-12 (Бейкер, Хауленд)", "GMT-11 (Нукуалофа, Паго-Паго, Ниуэ)", "GMT-10 (Гонолулу, Алеутские острова)", "GMT-9 (Анкоридж, Джуно, Аляска)", "GMT-8 (Лос-Анджелес, Сан-Франциско, Ванкувер, Сиэтл)", "GMT-7 (Денвер, Финикс, Калгари, Солт-Лейк-Сити)", "GMT-6 (Чикаго, Мехико, Гватемала, Сан-Хосе)", "GMT-5 (Нью-Йорк, Майами, Богота, Лима, Гавана)", "GMT-4 (Сантьяго, Ла-Пас, Каракас, Галифакс)", "GMT-3 (Буэнос-Айрес, Сан-Паулу, Монтевидео, Бразилиа)", "GMT-2 (Южная Георгия, Сандвичевы острова)", "GMT-1 (Азорские острова, Кабо-Верде)", "GMT+0 (Лондон, Лиссабон, Дублин, Аккра, Касабланка)", "GMT+1 (Париж, Берлин, Рим, Мадрид, Варшава, Амстердам)", "GMT+2 (Каир, Афины, Хельсинки, Киев, Бухарест, Стамбул)", "GMT+3 (Москва, Эр-Рияд, Найроби, Багдад, Кувейт)", "GMT+4 (Дубай, Баку, Тбилиси, Ереван, Маврикий)", "GMT+5 (Карачи, Ташкент, Екатеринбург, Мальдивы)", "GMT+6 (Дакка, Алматы, Омск, Коломбо, Бишкек)", "GMT+7 (Бангкок, Хошимин, Джакарта, Новосибирск, Красноярск)", "GMT+8 (Пекин, Сингапур, Манила, Куала-Лумпур, Улан-Батор, Иркутск)", "GMT+9 (Токио, Сеул, Пхеньян, Якутск, Осака)", "GMT+10 (Сидней, Мельбурн, Владивосток, Порт-Морсби, Гуам)", "GMT+11 (Нумеа, Соломоновы острова)", "GMT+12 (Окленд, Фиджи, Магадан, Веллингтон)", "GMT+13 (Нукуалофа, Самоа, Тонга)", "GMT+14 (Киритимати, Острова Лайн)" });
            cmbScheduleTimezone.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbScheduleTimezone.ItemSelectForeColor = Color.White;
            cmbScheduleTimezone.Location = new Point(105, 508);
            cmbScheduleTimezone.Margin = new Padding(4, 5, 4, 5);
            cmbScheduleTimezone.MinimumSize = new Size(63, 0);
            cmbScheduleTimezone.Name = "cmbScheduleTimezone";
            cmbScheduleTimezone.Padding = new Padding(0, 0, 30, 2);
            cmbScheduleTimezone.RectColor = Color.FromArgb(65, 71, 84);
            cmbScheduleTimezone.Size = new Size(550, 25);
            cmbScheduleTimezone.Style = Sunny.UI.UIStyle.Custom;
            cmbScheduleTimezone.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbScheduleTimezone.SymbolSize = 24;
            cmbScheduleTimezone.TabIndex = 52;
            cmbScheduleTimezone.TextAlignment = ContentAlignment.MiddleLeft;
            cmbScheduleTimezone.Watermark = "Выберите пояс";
            // 
            // lblScheduleTimezone
            // 
            lblScheduleTimezone.AutoSize = true;
            lblScheduleTimezone.BackColor = Color.Transparent;
            lblScheduleTimezone.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblScheduleTimezone.ForeColor = Color.FromArgb(180, 180, 180);
            lblScheduleTimezone.Location = new Point(9, 513);
            lblScheduleTimezone.Name = "lblScheduleTimezone";
            lblScheduleTimezone.Size = new Size(84, 13);
            lblScheduleTimezone.TabIndex = 51;
            lblScheduleTimezone.Text = "Часовой пояс:";
            // 
            // cmbScheduleRandomUnit
            // 
            cmbScheduleRandomUnit.DataSource = null;
            cmbScheduleRandomUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbScheduleRandomUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbScheduleRandomUnit.Font = new Font("Segoe UI", 9F);
            cmbScheduleRandomUnit.ForeColor = Color.White;
            cmbScheduleRandomUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbScheduleRandomUnit.ItemForeColor = Color.White;
            cmbScheduleRandomUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbScheduleRandomUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbScheduleRandomUnit.Items.AddRange(new object[] { "секунд", "минут", "часов", "секунд", "минут" });
            cmbScheduleRandomUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbScheduleRandomUnit.ItemSelectForeColor = Color.White;
            cmbScheduleRandomUnit.Location = new Point(480, 463);
            cmbScheduleRandomUnit.Margin = new Padding(4, 5, 4, 5);
            cmbScheduleRandomUnit.MinimumSize = new Size(63, 0);
            cmbScheduleRandomUnit.Name = "cmbScheduleRandomUnit";
            cmbScheduleRandomUnit.Padding = new Padding(0, 0, 30, 2);
            cmbScheduleRandomUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbScheduleRandomUnit.Size = new Size(73, 25);
            cmbScheduleRandomUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbScheduleRandomUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbScheduleRandomUnit.SymbolSize = 24;
            cmbScheduleRandomUnit.TabIndex = 66;
            cmbScheduleRandomUnit.Text = "минут";
            cmbScheduleRandomUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbScheduleRandomUnit.Watermark = "";
            // 
            // nudScheduleRandomMax
            // 
            nudScheduleRandomMax.FillColor = Color.FromArgb(42, 46, 57);
            nudScheduleRandomMax.Font = new Font("Segoe UI", 9.75F);
            nudScheduleRandomMax.ForeColor = Color.White;
            nudScheduleRandomMax.Location = new Point(374, 463);
            nudScheduleRandomMax.Margin = new Padding(4, 5, 4, 5);
            nudScheduleRandomMax.Maximum = 10000D;
            nudScheduleRandomMax.Minimum = 0D;
            nudScheduleRandomMax.MinimumSize = new Size(1, 16);
            nudScheduleRandomMax.Name = "nudScheduleRandomMax";
            nudScheduleRandomMax.Padding = new Padding(5);
            nudScheduleRandomMax.RectColor = Color.FromArgb(65, 71, 84);
            nudScheduleRandomMax.RectHoverColor = Color.BlueViolet;
            nudScheduleRandomMax.RectPressColor = Color.Indigo;
            nudScheduleRandomMax.ShowText = false;
            nudScheduleRandomMax.Size = new Size(100, 25);
            nudScheduleRandomMax.TabIndex = 61;
            nudScheduleRandomMax.Text = "60";
            nudScheduleRandomMax.TextAlignment = ContentAlignment.MiddleCenter;
            nudScheduleRandomMax.Value = 60;
            // 
            // lblScheduleRandomTo
            // 
            lblScheduleRandomTo.AutoSize = true;
            lblScheduleRandomTo.BackColor = Color.Transparent;
            lblScheduleRandomTo.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblScheduleRandomTo.ForeColor = Color.FromArgb(180, 180, 180);
            lblScheduleRandomTo.Location = new Point(348, 468);
            lblScheduleRandomTo.Name = "lblScheduleRandomTo";
            lblScheduleRandomTo.Size = new Size(20, 13);
            lblScheduleRandomTo.TabIndex = 63;
            lblScheduleRandomTo.Text = "до";
            // 
            // nudScheduleRandomMin
            // 
            nudScheduleRandomMin.FillColor = Color.FromArgb(42, 46, 57);
            nudScheduleRandomMin.Font = new Font("Segoe UI", 9.75F);
            nudScheduleRandomMin.ForeColor = Color.White;
            nudScheduleRandomMin.Location = new Point(241, 463);
            nudScheduleRandomMin.Margin = new Padding(4, 5, 4, 5);
            nudScheduleRandomMin.Maximum = 10000D;
            nudScheduleRandomMin.Minimum = 0D;
            nudScheduleRandomMin.MinimumSize = new Size(1, 16);
            nudScheduleRandomMin.Name = "nudScheduleRandomMin";
            nudScheduleRandomMin.Padding = new Padding(5);
            nudScheduleRandomMin.RectColor = Color.FromArgb(65, 71, 84);
            nudScheduleRandomMin.RectHoverColor = Color.BlueViolet;
            nudScheduleRandomMin.RectPressColor = Color.Indigo;
            nudScheduleRandomMin.ShowText = false;
            nudScheduleRandomMin.Size = new Size(100, 25);
            nudScheduleRandomMin.TabIndex = 60;
            nudScheduleRandomMin.Text = "0";
            nudScheduleRandomMin.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkScheduleRandomDelay
            // 
            chkScheduleRandomDelay.BackColor = Color.Transparent;
            chkScheduleRandomDelay.CheckBoxColor = Color.BlueViolet;
            chkScheduleRandomDelay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleRandomDelay.ForeColor = Color.White;
            chkScheduleRandomDelay.Location = new Point(9, 463);
            chkScheduleRandomDelay.MinimumSize = new Size(1, 1);
            chkScheduleRandomDelay.Name = "chkScheduleRandomDelay";
            chkScheduleRandomDelay.Size = new Size(224, 25);
            chkScheduleRandomDelay.TabIndex = 62;
            chkScheduleRandomDelay.Text = "Добавлять случайную задержку c:";
            // 
            // dtpScheduleEndTime
            // 
            dtpScheduleEndTime.FillColor = Color.FromArgb(42, 46, 57);
            dtpScheduleEndTime.Font = new Font("Segoe UI", 9.75F);
            dtpScheduleEndTime.ForeColor = Color.White;
            dtpScheduleEndTime.Location = new Point(135, 424);
            dtpScheduleEndTime.Margin = new Padding(4, 5, 4, 5);
            dtpScheduleEndTime.MaxLength = 8;
            dtpScheduleEndTime.MinimumSize = new Size(63, 0);
            dtpScheduleEndTime.Name = "dtpScheduleEndTime";
            dtpScheduleEndTime.Padding = new Padding(0, 0, 30, 2);
            dtpScheduleEndTime.RectColor = Color.FromArgb(65, 71, 84);
            dtpScheduleEndTime.Size = new Size(100, 25);
            dtpScheduleEndTime.Style = Sunny.UI.UIStyle.Custom;
            dtpScheduleEndTime.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpScheduleEndTime.SymbolDropDown = 61555;
            dtpScheduleEndTime.SymbolNormal = 61555;
            dtpScheduleEndTime.SymbolSize = 24;
            dtpScheduleEndTime.TabIndex = 59;
            dtpScheduleEndTime.Text = "23:59:59";
            dtpScheduleEndTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpScheduleEndTime.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpScheduleEndTime.Value = new DateTime(2026, 9, 25, 23, 59, 59, 0);
            dtpScheduleEndTime.Watermark = "";
            // 
            // dtpScheduleEndDate
            // 
            dtpScheduleEndDate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpScheduleEndDate.DateFormat = "dd-MM-yyyy";
            dtpScheduleEndDate.FillColor = Color.FromArgb(42, 46, 57);
            dtpScheduleEndDate.Font = new Font("Segoe UI", 9.75F);
            dtpScheduleEndDate.ForeColor = Color.White;
            dtpScheduleEndDate.Location = new Point(9, 424);
            dtpScheduleEndDate.Margin = new Padding(4, 5, 4, 5);
            dtpScheduleEndDate.MaxLength = 10;
            dtpScheduleEndDate.MinimumSize = new Size(63, 0);
            dtpScheduleEndDate.Name = "dtpScheduleEndDate";
            dtpScheduleEndDate.Padding = new Padding(0, 0, 30, 2);
            dtpScheduleEndDate.RectColor = Color.FromArgb(65, 71, 84);
            dtpScheduleEndDate.Size = new Size(120, 25);
            dtpScheduleEndDate.Style = Sunny.UI.UIStyle.Custom;
            dtpScheduleEndDate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpScheduleEndDate.SymbolDropDown = 61555;
            dtpScheduleEndDate.SymbolNormal = 61555;
            dtpScheduleEndDate.SymbolSize = 24;
            dtpScheduleEndDate.TabIndex = 56;
            dtpScheduleEndDate.Text = "25-09-2026";
            dtpScheduleEndDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpScheduleEndDate.Value = new DateTime(2026, 9, 25, 0, 0, 0, 0);
            dtpScheduleEndDate.Watermark = "";
            // 
            // lblScheduleEndDate
            // 
            lblScheduleEndDate.AutoSize = true;
            lblScheduleEndDate.BackColor = Color.Transparent;
            lblScheduleEndDate.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblScheduleEndDate.ForeColor = Color.FromArgb(180, 180, 180);
            lblScheduleEndDate.Location = new Point(9, 406);
            lblScheduleEndDate.Name = "lblScheduleEndDate";
            lblScheduleEndDate.Size = new Size(44, 13);
            lblScheduleEndDate.TabIndex = 55;
            lblScheduleEndDate.Text = "Конец:";
            // 
            // dtpScheduleStartTime
            // 
            dtpScheduleStartTime.FillColor = Color.FromArgb(42, 46, 57);
            dtpScheduleStartTime.Font = new Font("Segoe UI", 9.75F);
            dtpScheduleStartTime.ForeColor = Color.White;
            dtpScheduleStartTime.Location = new Point(135, 375);
            dtpScheduleStartTime.Margin = new Padding(4, 5, 4, 5);
            dtpScheduleStartTime.MaxLength = 8;
            dtpScheduleStartTime.MinimumSize = new Size(63, 0);
            dtpScheduleStartTime.Name = "dtpScheduleStartTime";
            dtpScheduleStartTime.Padding = new Padding(0, 0, 30, 2);
            dtpScheduleStartTime.RectColor = Color.FromArgb(65, 71, 84);
            dtpScheduleStartTime.Size = new Size(100, 25);
            dtpScheduleStartTime.Style = Sunny.UI.UIStyle.Custom;
            dtpScheduleStartTime.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpScheduleStartTime.SymbolDropDown = 61555;
            dtpScheduleStartTime.SymbolNormal = 61555;
            dtpScheduleStartTime.SymbolSize = 24;
            dtpScheduleStartTime.TabIndex = 58;
            dtpScheduleStartTime.Text = "00:00:00";
            dtpScheduleStartTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpScheduleStartTime.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpScheduleStartTime.Value = new DateTime(2026, 9, 25, 0, 0, 0, 0);
            dtpScheduleStartTime.Watermark = "";
            // 
            // dtpScheduleStartDate
            // 
            dtpScheduleStartDate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpScheduleStartDate.DateFormat = "dd-MM-yyyy";
            dtpScheduleStartDate.FillColor = Color.FromArgb(42, 46, 57);
            dtpScheduleStartDate.Font = new Font("Segoe UI", 9.75F);
            dtpScheduleStartDate.ForeColor = Color.White;
            dtpScheduleStartDate.Location = new Point(9, 375);
            dtpScheduleStartDate.Margin = new Padding(4, 5, 4, 5);
            dtpScheduleStartDate.MaxLength = 10;
            dtpScheduleStartDate.MinimumSize = new Size(63, 0);
            dtpScheduleStartDate.Name = "dtpScheduleStartDate";
            dtpScheduleStartDate.Padding = new Padding(0, 0, 30, 2);
            dtpScheduleStartDate.RectColor = Color.FromArgb(65, 71, 84);
            dtpScheduleStartDate.Size = new Size(120, 25);
            dtpScheduleStartDate.Style = Sunny.UI.UIStyle.Custom;
            dtpScheduleStartDate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpScheduleStartDate.SymbolDropDown = 61555;
            dtpScheduleStartDate.SymbolNormal = 61555;
            dtpScheduleStartDate.SymbolSize = 24;
            dtpScheduleStartDate.TabIndex = 54;
            dtpScheduleStartDate.Text = "13-09-2026";
            dtpScheduleStartDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpScheduleStartDate.Value = new DateTime(2026, 9, 13, 0, 0, 0, 0);
            dtpScheduleStartDate.Watermark = "";
            // 
            // lblSchedulePeriod
            // 
            lblSchedulePeriod.AutoSize = true;
            lblSchedulePeriod.BackColor = Color.Transparent;
            lblSchedulePeriod.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblSchedulePeriod.ForeColor = Color.FromArgb(180, 180, 180);
            lblSchedulePeriod.Location = new Point(9, 357);
            lblSchedulePeriod.Name = "lblSchedulePeriod";
            lblSchedulePeriod.Size = new Size(102, 13);
            lblSchedulePeriod.TabIndex = 67;
            lblSchedulePeriod.Text = "Период действия:";
            // 
            // grpScheduleList
            // 
            grpScheduleList.Controls.Add(flpScheduleList);
            grpScheduleList.FillColor = Color.Transparent;
            grpScheduleList.FillColor2 = Color.Transparent;
            grpScheduleList.FillDisableColor = Color.Transparent;
            grpScheduleList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpScheduleList.ForeColor = SystemColors.ActiveBorder;
            grpScheduleList.ForeDisableColor = Color.Transparent;
            grpScheduleList.Location = new Point(9, 214);
            grpScheduleList.Margin = new Padding(4, 5, 4, 5);
            grpScheduleList.MinimumSize = new Size(1, 1);
            grpScheduleList.Name = "grpScheduleList";
            grpScheduleList.Padding = new Padding(5, 32, 5, 5);
            grpScheduleList.RectColor = Color.FromArgb(58, 58, 69);
            grpScheduleList.RectDisableColor = Color.Transparent;
            grpScheduleList.Size = new Size(658, 130);
            grpScheduleList.TabIndex = 29;
            grpScheduleList.Text = "Расписание отправок";
            grpScheduleList.TextAlignment = ContentAlignment.MiddleLeft;
            grpScheduleList.TitleTop = 10;
            // 
            // flpScheduleList
            // 
            flpScheduleList.AutoScroll = true;
            flpScheduleList.FlowDirection = FlowDirection.TopDown;
            flpScheduleList.Location = new Point(10, 20);
            flpScheduleList.Name = "flpScheduleList";
            flpScheduleList.Size = new Size(636, 99);
            flpScheduleList.TabIndex = 10;
            flpScheduleList.WrapContents = false;
            // 
            // btnAddScheduleTime
            // 
            btnAddScheduleTime.FillColor = Color.BlueViolet;
            btnAddScheduleTime.FillColor2 = Color.Transparent;
            btnAddScheduleTime.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnAddScheduleTime.FillHoverColor = Color.DarkOrchid;
            btnAddScheduleTime.FillPressColor = Color.DarkViolet;
            btnAddScheduleTime.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            btnAddScheduleTime.Location = new Point(135, 179);
            btnAddScheduleTime.MinimumSize = new Size(1, 1);
            btnAddScheduleTime.Name = "btnAddScheduleTime";
            btnAddScheduleTime.Radius = 8;
            btnAddScheduleTime.RectColor = Color.Transparent;
            btnAddScheduleTime.Size = new Size(128, 25);
            btnAddScheduleTime.Style = Sunny.UI.UIStyle.Custom;
            btnAddScheduleTime.TabIndex = 28;
            btnAddScheduleTime.Text = "+ Добавить время";
            btnAddScheduleTime.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // dtpScheduleTime
            // 
            dtpScheduleTime.FillColor = Color.FromArgb(42, 46, 57);
            dtpScheduleTime.Font = new Font("Segoe UI", 9.75F);
            dtpScheduleTime.ForeColor = Color.White;
            dtpScheduleTime.Location = new Point(9, 179);
            dtpScheduleTime.Margin = new Padding(4, 5, 4, 5);
            dtpScheduleTime.MaxLength = 8;
            dtpScheduleTime.MinimumSize = new Size(63, 0);
            dtpScheduleTime.Name = "dtpScheduleTime";
            dtpScheduleTime.Padding = new Padding(0, 0, 30, 2);
            dtpScheduleTime.RectColor = Color.FromArgb(65, 71, 84);
            dtpScheduleTime.Size = new Size(120, 25);
            dtpScheduleTime.Style = Sunny.UI.UIStyle.Custom;
            dtpScheduleTime.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpScheduleTime.SymbolDropDown = 61555;
            dtpScheduleTime.SymbolNormal = 61555;
            dtpScheduleTime.SymbolSize = 24;
            dtpScheduleTime.TabIndex = 60;
            dtpScheduleTime.Text = "00:00:00";
            dtpScheduleTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpScheduleTime.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpScheduleTime.Value = new DateTime(2026, 9, 25, 0, 0, 0, 0);
            dtpScheduleTime.Watermark = "";
            // 
            // lblScheduleTime
            // 
            lblScheduleTime.AutoSize = true;
            lblScheduleTime.BackColor = Color.Transparent;
            lblScheduleTime.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblScheduleTime.ForeColor = Color.FromArgb(180, 180, 180);
            lblScheduleTime.Location = new Point(9, 159);
            lblScheduleTime.Name = "lblScheduleTime";
            lblScheduleTime.Size = new Size(98, 13);
            lblScheduleTime.TabIndex = 58;
            lblScheduleTime.Text = "Время отправки:";
            // 
            // chkScheduleDaySun
            // 
            chkScheduleDaySun.BackColor = Color.Transparent;
            chkScheduleDaySun.CheckBoxColor = Color.BlueViolet;
            chkScheduleDaySun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDaySun.ForeColor = Color.White;
            chkScheduleDaySun.Location = new Point(447, 123);
            chkScheduleDaySun.MinimumSize = new Size(1, 1);
            chkScheduleDaySun.Name = "chkScheduleDaySun";
            chkScheduleDaySun.Size = new Size(50, 25);
            chkScheduleDaySun.TabIndex = 50;
            chkScheduleDaySun.Text = "Вс";
            // 
            // chkScheduleDaySat
            // 
            chkScheduleDaySat.BackColor = Color.Transparent;
            chkScheduleDaySat.CheckBoxColor = Color.BlueViolet;
            chkScheduleDaySat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDaySat.ForeColor = Color.White;
            chkScheduleDaySat.Location = new Point(392, 123);
            chkScheduleDaySat.MinimumSize = new Size(1, 1);
            chkScheduleDaySat.Name = "chkScheduleDaySat";
            chkScheduleDaySat.Size = new Size(50, 25);
            chkScheduleDaySat.TabIndex = 49;
            chkScheduleDaySat.Text = "Сб";
            // 
            // chkScheduleDayFri
            // 
            chkScheduleDayFri.BackColor = Color.Transparent;
            chkScheduleDayFri.CheckBoxColor = Color.BlueViolet;
            chkScheduleDayFri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDayFri.ForeColor = Color.White;
            chkScheduleDayFri.Location = new Point(337, 123);
            chkScheduleDayFri.MinimumSize = new Size(1, 1);
            chkScheduleDayFri.Name = "chkScheduleDayFri";
            chkScheduleDayFri.Size = new Size(50, 25);
            chkScheduleDayFri.TabIndex = 48;
            chkScheduleDayFri.Text = "Пт";
            // 
            // chkScheduleDayThu
            // 
            chkScheduleDayThu.BackColor = Color.Transparent;
            chkScheduleDayThu.CheckBoxColor = Color.BlueViolet;
            chkScheduleDayThu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDayThu.ForeColor = Color.White;
            chkScheduleDayThu.Location = new Point(282, 123);
            chkScheduleDayThu.MinimumSize = new Size(1, 1);
            chkScheduleDayThu.Name = "chkScheduleDayThu";
            chkScheduleDayThu.Size = new Size(50, 25);
            chkScheduleDayThu.TabIndex = 47;
            chkScheduleDayThu.Text = "Чт";
            // 
            // chkScheduleDayWed
            // 
            chkScheduleDayWed.BackColor = Color.Transparent;
            chkScheduleDayWed.CheckBoxColor = Color.BlueViolet;
            chkScheduleDayWed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDayWed.ForeColor = Color.White;
            chkScheduleDayWed.Location = new Point(227, 123);
            chkScheduleDayWed.MinimumSize = new Size(1, 1);
            chkScheduleDayWed.Name = "chkScheduleDayWed";
            chkScheduleDayWed.Size = new Size(50, 25);
            chkScheduleDayWed.TabIndex = 46;
            chkScheduleDayWed.Text = "Ср";
            // 
            // chkScheduleDayTue
            // 
            chkScheduleDayTue.BackColor = Color.Transparent;
            chkScheduleDayTue.CheckBoxColor = Color.BlueViolet;
            chkScheduleDayTue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDayTue.ForeColor = Color.White;
            chkScheduleDayTue.Location = new Point(172, 123);
            chkScheduleDayTue.MinimumSize = new Size(1, 1);
            chkScheduleDayTue.Name = "chkScheduleDayTue";
            chkScheduleDayTue.Size = new Size(50, 25);
            chkScheduleDayTue.TabIndex = 45;
            chkScheduleDayTue.Text = "Вт";
            // 
            // chkScheduleDayMon
            // 
            chkScheduleDayMon.BackColor = Color.Transparent;
            chkScheduleDayMon.CheckBoxColor = Color.BlueViolet;
            chkScheduleDayMon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleDayMon.ForeColor = Color.White;
            chkScheduleDayMon.Location = new Point(117, 123);
            chkScheduleDayMon.MinimumSize = new Size(1, 1);
            chkScheduleDayMon.Name = "chkScheduleDayMon";
            chkScheduleDayMon.Size = new Size(50, 25);
            chkScheduleDayMon.TabIndex = 44;
            chkScheduleDayMon.Text = "Пн";
            // 
            // lblScheduleDays
            // 
            lblScheduleDays.AutoSize = true;
            lblScheduleDays.BackColor = Color.Transparent;
            lblScheduleDays.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblScheduleDays.ForeColor = Color.FromArgb(180, 180, 180);
            lblScheduleDays.Location = new Point(9, 128);
            lblScheduleDays.Name = "lblScheduleDays";
            lblScheduleDays.Size = new Size(102, 13);
            lblScheduleDays.TabIndex = 43;
            lblScheduleDays.Text = "Неделя отправки:";
            // 
            // lblScheduleTemplateHint
            // 
            lblScheduleTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblScheduleTemplateHint.ForeColor = Color.DarkGray;
            lblScheduleTemplateHint.Location = new Point(9, 69);
            lblScheduleTemplateHint.Name = "lblScheduleTemplateHint";
            lblScheduleTemplateHint.Size = new Size(658, 45);
            lblScheduleTemplateHint.TabIndex = 27;
            lblScheduleTemplateHint.Text = resources.GetString("lblScheduleTemplateHint.Text");
            // 
            // txtScheduleCustomText
            // 
            txtScheduleCustomText.ButtonFillColor = Color.Transparent;
            txtScheduleCustomText.ButtonStyleInherited = false;
            txtScheduleCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtScheduleCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtScheduleCustomText.ForeColor = Color.White;
            txtScheduleCustomText.Location = new Point(9, 40);
            txtScheduleCustomText.Margin = new Padding(4, 5, 4, 5);
            txtScheduleCustomText.MinimumSize = new Size(1, 16);
            txtScheduleCustomText.Name = "txtScheduleCustomText";
            txtScheduleCustomText.Padding = new Padding(5);
            txtScheduleCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtScheduleCustomText.ShowText = false;
            txtScheduleCustomText.Size = new Size(658, 25);
            txtScheduleCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtScheduleCustomText.TabIndex = 26;
            txtScheduleCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtScheduleCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbScheduleTemplate
            // 
            cmbScheduleTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbScheduleTemplate.DataSource = null;
            cmbScheduleTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbScheduleTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbScheduleTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbScheduleTemplate.ForeColor = Color.White;
            cmbScheduleTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbScheduleTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbScheduleTemplate.Location = new Point(9, 9);
            cmbScheduleTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbScheduleTemplate.MinimumSize = new Size(63, 0);
            cmbScheduleTemplate.Name = "cmbScheduleTemplate";
            cmbScheduleTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbScheduleTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbScheduleTemplate.Size = new Size(658, 25);
            cmbScheduleTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbScheduleTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbScheduleTemplate.SymbolSize = 24;
            cmbScheduleTemplate.TabIndex = 25;
            cmbScheduleTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbScheduleTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // chkScheduleEndless
            // 
            chkScheduleEndless.BackColor = Color.Transparent;
            chkScheduleEndless.CheckBoxColor = Color.BlueViolet;
            chkScheduleEndless.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkScheduleEndless.ForeColor = Color.White;
            chkScheduleEndless.Location = new Point(241, 428);
            chkScheduleEndless.MinimumSize = new Size(1, 1);
            chkScheduleEndless.Name = "chkScheduleEndless";
            chkScheduleEndless.Size = new Size(95, 25);
            chkScheduleEndless.TabIndex = 57;
            chkScheduleEndless.Text = "Бессрочно";
            // 
            // ScheduleTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpSchedule);
            Name = "ScheduleTabControl";
            Size = new Size(696, 483);
            grpSchedule.ResumeLayout(false);
            pnlScheduleButtons.ResumeLayout(false);
            pnlScheduleInner.ResumeLayout(false);
            pnlScheduleContent.ResumeLayout(false);
            pnlScheduleContent.PerformLayout();
            grpScheduleHistory.ResumeLayout(false);
            grpScheduleList.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpSchedule;
        private Sunny.UI.UIPanel pnlScheduleButtons;
        private Sunny.UI.UICheckBox chkScheduleManualConfirm;
        private Sunny.UI.UIButton btnSaveSchedule;
        private Sunny.UI.UIButton btnStartSchedule;
        private Panel pnlScheduleInner;
        private Panel pnlScheduleContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbScheduleTemplate;
        private Sunny.UI.UITextBox txtScheduleCustomText;
        private Label lblScheduleTemplateHint;

        // Days of Week
        private Label lblScheduleDays;
        private Sunny.UI.UICheckBox chkScheduleDayMon;
        private Sunny.UI.UICheckBox chkScheduleDayTue;
        private Sunny.UI.UICheckBox chkScheduleDayWed;
        private Sunny.UI.UICheckBox chkScheduleDayThu;
        private Sunny.UI.UICheckBox chkScheduleDayFri;
        private Sunny.UI.UICheckBox chkScheduleDaySat;
        private Sunny.UI.UICheckBox chkScheduleDaySun;

        // Time Settings
        private Label lblScheduleTime;
        private Sunny.UI.UITimePicker dtpScheduleTime;
        private Sunny.UI.UIButton btnAddScheduleTime;

        // Schedule List
        private Sunny.UI.UIGroupBox grpScheduleList;
        private FlowLayoutPanel flpScheduleList;

        // Period Settings
        private Label lblSchedulePeriod;
        private Sunny.UI.UIDatePicker dtpScheduleStartDate;
        private Sunny.UI.UITimePicker dtpScheduleStartTime;
        private Label lblScheduleEndDate;
        private Sunny.UI.UIDatePicker dtpScheduleEndDate;
        private Sunny.UI.UITimePicker dtpScheduleEndTime;
        private Sunny.UI.UICheckBox chkScheduleEndless;

        // Random Delay
        private Sunny.UI.UICheckBox chkScheduleRandomDelay;
        private Sunny.UI.UIIntegerUpDown nudScheduleRandomMin;
        private Label lblScheduleRandomTo;
        private Sunny.UI.UIIntegerUpDown nudScheduleRandomMax;
        private Sunny.UI.UIComboBox cmbScheduleRandomUnit;

        // Timezone
        private Label lblScheduleTimezone;
        private Sunny.UI.UIComboBox cmbScheduleTimezone;

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
        private Sunny.UI.UIGroupBox grpScheduleHistory;
        private FlowLayoutPanel flpScheduleHistory;
    }
}