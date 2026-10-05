namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class EventTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventTabControl));
            grpEvent = new Sunny.UI.UIGroupBox();
            pnlEventButtons = new Sunny.UI.UIPanel();
            chkEventManualConfirm = new Sunny.UI.UICheckBox();
            btnSaveEvent = new Sunny.UI.UIButton();
            btnStartEvent = new Sunny.UI.UIButton();
            pnlEventInner = new Panel();
            pnlEventContent = new Panel();
            grpEventHistory = new Sunny.UI.UIGroupBox();
            flpEventHistory = new FlowLayoutPanel();
            chkNotifyError = new Sunny.UI.UICheckBox();
            cmbNotifyError1 = new Sunny.UI.UIComboBox();
            lblNotifyErrorOr = new Label();
            cmbNotifyError2 = new Sunny.UI.UIComboBox();
            chkNotifySuccess = new Sunny.UI.UICheckBox();
            cmbNotifySuccess1 = new Sunny.UI.UIComboBox();
            lblNotifySuccessOr = new Label();
            cmbNotifySuccess2 = new Sunny.UI.UIComboBox();
            nudEventPriority = new Sunny.UI.UIIntegerUpDown();
            lblEventPriority = new Label();
            chkEventRegex = new Sunny.UI.UICheckBox();
            chkEventWholeWord = new Sunny.UI.UICheckBox();
            chkEventCaseSensitive = new Sunny.UI.UICheckBox();
            chkStopOnMatch = new Sunny.UI.UICheckBox();
            chkLogEvent = new Sunny.UI.UICheckBox();
            chkSendNotification = new Sunny.UI.UICheckBox();
            chkAutoPublish = new Sunny.UI.UICheckBox();
            lblEventActions = new Label();
            grpTriggerConditions = new Sunny.UI.UIGroupBox();
            pnlTriggerConditions = new FlowLayoutPanel();
            cmbEventType = new Sunny.UI.UIComboBox();
            lblEventType = new Label();
            cmbTriggerTarget = new Sunny.UI.UIComboBox();
            lblTriggerTarget = new Label();
            lblEventTemplateHint = new Label();
            txtEventCustomText = new Sunny.UI.UITextBox();
            cmbEventTemplate = new Sunny.UI.UIComboBox();
            grpEvent.SuspendLayout();
            pnlEventButtons.SuspendLayout();
            pnlEventInner.SuspendLayout();
            pnlEventContent.SuspendLayout();
            grpEventHistory.SuspendLayout();
            grpTriggerConditions.SuspendLayout();
            SuspendLayout();
            // 
            // grpEvent
            // 
            grpEvent.BackColor = Color.FromArgb(35, 39, 48);
            grpEvent.Controls.Add(pnlEventButtons);
            grpEvent.Controls.Add(pnlEventInner);
            grpEvent.Dock = DockStyle.Fill;
            grpEvent.FillColor = Color.Transparent;
            grpEvent.FillColor2 = Color.Transparent;
            grpEvent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpEvent.ForeColor = Color.White;
            grpEvent.Location = new Point(0, 0);
            grpEvent.Margin = new Padding(4, 5, 4, 5);
            grpEvent.MinimumSize = new Size(1, 1);
            grpEvent.Name = "grpEvent";
            grpEvent.Padding = new Padding(0, 32, 0, 0);
            grpEvent.Radius = 15;
            grpEvent.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpEvent.RectColor = Color.FromArgb(58, 58, 69);
            grpEvent.Size = new Size(696, 483);
            grpEvent.Style = Sunny.UI.UIStyle.Custom;
            grpEvent.TabIndex = 11;
            grpEvent.Text = "Настройки события отправки";
            grpEvent.TextAlignment = ContentAlignment.MiddleLeft;
            grpEvent.TitleInterval = 8;
            grpEvent.TitleTop = 14;
            // 
            // pnlEventButtons
            // 
            pnlEventButtons.Controls.Add(chkEventManualConfirm);
            pnlEventButtons.Controls.Add(btnSaveEvent);
            pnlEventButtons.Controls.Add(btnStartEvent);
            pnlEventButtons.Dock = DockStyle.Bottom;
            pnlEventButtons.FillColor = Color.Transparent;
            pnlEventButtons.FillColor2 = Color.Transparent;
            pnlEventButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlEventButtons.ForeColor = Color.Transparent;
            pnlEventButtons.Location = new Point(0, 438);
            pnlEventButtons.Margin = new Padding(4, 5, 4, 5);
            pnlEventButtons.MinimumSize = new Size(1, 1);
            pnlEventButtons.Name = "pnlEventButtons";
            pnlEventButtons.Radius = 0;
            pnlEventButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlEventButtons.RectDisableColor = Color.Transparent;
            pnlEventButtons.Size = new Size(696, 45);
            pnlEventButtons.TabIndex = 21;
            pnlEventButtons.Text = null;
            pnlEventButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkEventManualConfirm
            // 
            chkEventManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkEventManualConfirm.BackColor = Color.Transparent;
            chkEventManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkEventManualConfirm.Checked = true;
            chkEventManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkEventManualConfirm.ForeColor = Color.White;
            chkEventManualConfirm.Location = new Point(46, 10);
            chkEventManualConfirm.MinimumSize = new Size(1, 1);
            chkEventManualConfirm.Name = "chkEventManualConfirm";
            chkEventManualConfirm.Size = new Size(333, 25);
            chkEventManualConfirm.TabIndex = 27;
            chkEventManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSaveEvent
            // 
            btnSaveEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveEvent.FillColor = Color.BlueViolet;
            btnSaveEvent.FillColor2 = Color.Transparent;
            btnSaveEvent.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSaveEvent.FillHoverColor = Color.DarkOrchid;
            btnSaveEvent.FillPressColor = Color.DarkViolet;
            btnSaveEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveEvent.Location = new Point(389, 5);
            btnSaveEvent.MinimumSize = new Size(1, 1);
            btnSaveEvent.Name = "btnSaveEvent";
            btnSaveEvent.Radius = 8;
            btnSaveEvent.RectColor = Color.Transparent;
            btnSaveEvent.Size = new Size(150, 35);
            btnSaveEvent.Style = Sunny.UI.UIStyle.Custom;
            btnSaveEvent.TabIndex = 13;
            btnSaveEvent.Text = "Сохранить настройки";
            btnSaveEvent.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnStartEvent
            // 
            btnStartEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartEvent.FillColor = Color.Indigo;
            btnStartEvent.FillColor2 = Color.Transparent;
            btnStartEvent.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnStartEvent.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnStartEvent.FillPressColor = Color.FromArgb(109, 40, 217);
            btnStartEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartEvent.Location = new Point(543, 5);
            btnStartEvent.MinimumSize = new Size(1, 1);
            btnStartEvent.Name = "btnStartEvent";
            btnStartEvent.Radius = 8;
            btnStartEvent.RectColor = Color.Transparent;
            btnStartEvent.Size = new Size(150, 35);
            btnStartEvent.Style = Sunny.UI.UIStyle.Custom;
            btnStartEvent.TabIndex = 14;
            btnStartEvent.Text = "Начать сеанс";
            btnStartEvent.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlEventInner
            // 
            pnlEventInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEventInner.AutoScroll = true;
            pnlEventInner.Controls.Add(pnlEventContent);
            pnlEventInner.Location = new Point(3, 25);
            pnlEventInner.Name = "pnlEventInner";
            pnlEventInner.Size = new Size(693, 413);
            pnlEventInner.TabIndex = 22;
            // 
            // pnlEventContent
            // 
            pnlEventContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlEventContent.Controls.Add(grpEventHistory);
            pnlEventContent.Controls.Add(chkNotifyError);
            pnlEventContent.Controls.Add(cmbNotifyError1);
            pnlEventContent.Controls.Add(lblNotifyErrorOr);
            pnlEventContent.Controls.Add(cmbNotifyError2);
            pnlEventContent.Controls.Add(chkNotifySuccess);
            pnlEventContent.Controls.Add(cmbNotifySuccess1);
            pnlEventContent.Controls.Add(lblNotifySuccessOr);
            pnlEventContent.Controls.Add(cmbNotifySuccess2);
            pnlEventContent.Controls.Add(nudEventPriority);
            pnlEventContent.Controls.Add(lblEventPriority);
            pnlEventContent.Controls.Add(chkEventRegex);
            pnlEventContent.Controls.Add(chkEventWholeWord);
            pnlEventContent.Controls.Add(chkEventCaseSensitive);
            pnlEventContent.Controls.Add(chkStopOnMatch);
            pnlEventContent.Controls.Add(chkLogEvent);
            pnlEventContent.Controls.Add(chkSendNotification);
            pnlEventContent.Controls.Add(chkAutoPublish);
            pnlEventContent.Controls.Add(lblEventActions);
            pnlEventContent.Controls.Add(grpTriggerConditions);
            pnlEventContent.Controls.Add(cmbEventType);
            pnlEventContent.Controls.Add(lblEventType);
            pnlEventContent.Controls.Add(cmbTriggerTarget);
            pnlEventContent.Controls.Add(lblTriggerTarget);
            pnlEventContent.Controls.Add(lblEventTemplateHint);
            pnlEventContent.Controls.Add(txtEventCustomText);
            pnlEventContent.Controls.Add(cmbEventTemplate);
            pnlEventContent.Location = new Point(0, 0);
            pnlEventContent.MinimumSize = new Size(673, 0);
            pnlEventContent.Name = "pnlEventContent";
            pnlEventContent.Padding = new Padding(9, 0, 9, 0);
            pnlEventContent.Size = new Size(676, 1330);
            pnlEventContent.TabIndex = 0;
            // 
            // grpEventHistory
            // 
            grpEventHistory.Controls.Add(flpEventHistory);
            grpEventHistory.FillColor = Color.Transparent;
            grpEventHistory.FillColor2 = Color.Transparent;
            grpEventHistory.FillDisableColor = Color.Transparent;
            grpEventHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpEventHistory.ForeColor = SystemColors.ActiveBorder;
            grpEventHistory.ForeDisableColor = Color.Transparent;
            grpEventHistory.Location = new Point(9, 663);
            grpEventHistory.Margin = new Padding(4, 5, 4, 5);
            grpEventHistory.MinimumSize = new Size(1, 1);
            grpEventHistory.Name = "grpEventHistory";
            grpEventHistory.Padding = new Padding(5, 32, 5, 5);
            grpEventHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpEventHistory.RectDisableColor = Color.Transparent;
            grpEventHistory.Size = new Size(658, 290);
            grpEventHistory.TabIndex = 28;
            grpEventHistory.Text = "История срабатываний:";
            grpEventHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpEventHistory.TitleTop = 10;
            // 
            // flpEventHistory
            // 
            flpEventHistory.AutoScroll = true;
            flpEventHistory.FlowDirection = FlowDirection.TopDown;
            flpEventHistory.Location = new Point(10, 20);
            flpEventHistory.Name = "flpEventHistory";
            flpEventHistory.Size = new Size(636, 259);
            flpEventHistory.TabIndex = 10;
            flpEventHistory.WrapContents = false;
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
            chkNotifyError.TabIndex = 88;
            chkNotifyError.Text = "Уведомлять об ошибках в:";
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
            lblNotifyErrorOr.Location = new Point(442, 618);
            lblNotifyErrorOr.Name = "lblNotifyErrorOr";
            lblNotifyErrorOr.Size = new Size(39, 13);
            lblNotifyErrorOr.TabIndex = 90;
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
            cmbNotifyError2.TabIndex = 85;
            cmbNotifyError2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError2.Watermark = "Куда отправить";
            // 
            // chkNotifySuccess
            // 
            chkNotifySuccess.BackColor = Color.Transparent;
            chkNotifySuccess.CheckBoxColor = Color.BlueViolet;
            chkNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifySuccess.ForeColor = Color.White;
            chkNotifySuccess.Location = new Point(9, 583);
            chkNotifySuccess.MinimumSize = new Size(1, 1);
            chkNotifySuccess.Name = "chkNotifySuccess";
            chkNotifySuccess.Size = new Size(265, 25);
            chkNotifySuccess.TabIndex = 80;
            chkNotifySuccess.Text = "Уведомлять о срабатывании в:";
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
            cmbNotifySuccess1.Location = new Point(290, 583);
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
            lblNotifySuccessOr.Location = new Point(442, 588);
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
            cmbNotifySuccess2.Location = new Point(489, 583);
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
            // nudEventPriority
            // 
            nudEventPriority.FillColor = Color.FromArgb(42, 46, 57);
            nudEventPriority.Font = new Font("Segoe UI", 9.75F);
            nudEventPriority.ForeColor = Color.White;
            nudEventPriority.Location = new Point(135, 543);
            nudEventPriority.Margin = new Padding(4, 5, 4, 5);
            nudEventPriority.Maximum = 100D;
            nudEventPriority.Minimum = 1D;
            nudEventPriority.MinimumSize = new Size(1, 16);
            nudEventPriority.Name = "nudEventPriority";
            nudEventPriority.Padding = new Padding(5);
            nudEventPriority.RectColor = Color.FromArgb(65, 71, 84);
            nudEventPriority.RectHoverColor = Color.BlueViolet;
            nudEventPriority.RectPressColor = Color.Indigo;
            nudEventPriority.ShowText = false;
            nudEventPriority.Size = new Size(80, 25);
            nudEventPriority.TabIndex = 23;
            nudEventPriority.Text = "50";
            nudEventPriority.TextAlignment = ContentAlignment.MiddleCenter;
            nudEventPriority.Value = 50;
            // 
            // lblEventPriority
            // 
            lblEventPriority.AutoSize = true;
            lblEventPriority.BackColor = Color.Transparent;
            lblEventPriority.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblEventPriority.ForeColor = Color.FromArgb(180, 180, 180);
            lblEventPriority.Location = new Point(9, 548);
            lblEventPriority.Name = "lblEventPriority";
            lblEventPriority.Size = new Size(117, 13);
            lblEventPriority.TabIndex = 22;
            lblEventPriority.Text = "Приоритет события:";
            // 
            // chkEventRegex
            // 
            chkEventRegex.BackColor = Color.Transparent;
            chkEventRegex.CheckBoxColor = Color.BlueViolet;
            chkEventRegex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkEventRegex.ForeColor = Color.White;
            chkEventRegex.Location = new Point(9, 513);
            chkEventRegex.MinimumSize = new Size(1, 1);
            chkEventRegex.Name = "chkEventRegex";
            chkEventRegex.Size = new Size(250, 25);
            chkEventRegex.TabIndex = 21;
            chkEventRegex.Text = "Использовать регулярные выражения";
            // 
            // chkEventWholeWord
            // 
            chkEventWholeWord.BackColor = Color.Transparent;
            chkEventWholeWord.CheckBoxColor = Color.BlueViolet;
            chkEventWholeWord.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkEventWholeWord.ForeColor = Color.White;
            chkEventWholeWord.Location = new Point(280, 483);
            chkEventWholeWord.MinimumSize = new Size(1, 1);
            chkEventWholeWord.Name = "chkEventWholeWord";
            chkEventWholeWord.Size = new Size(250, 25);
            chkEventWholeWord.TabIndex = 20;
            chkEventWholeWord.Text = "Только целые слова";
            // 
            // chkEventCaseSensitive
            // 
            chkEventCaseSensitive.BackColor = Color.Transparent;
            chkEventCaseSensitive.CheckBoxColor = Color.BlueViolet;
            chkEventCaseSensitive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkEventCaseSensitive.ForeColor = Color.White;
            chkEventCaseSensitive.Location = new Point(9, 483);
            chkEventCaseSensitive.MinimumSize = new Size(1, 1);
            chkEventCaseSensitive.Name = "chkEventCaseSensitive";
            chkEventCaseSensitive.Size = new Size(250, 25);
            chkEventCaseSensitive.TabIndex = 19;
            chkEventCaseSensitive.Text = "Учитывать регистр";
            // 
            // chkStopOnMatch
            // 
            chkStopOnMatch.BackColor = Color.Transparent;
            chkStopOnMatch.CheckBoxColor = Color.BlueViolet;
            chkStopOnMatch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkStopOnMatch.ForeColor = Color.White;
            chkStopOnMatch.Location = new Point(330, 443);
            chkStopOnMatch.MinimumSize = new Size(1, 1);
            chkStopOnMatch.Name = "chkStopOnMatch";
            chkStopOnMatch.Size = new Size(300, 25);
            chkStopOnMatch.TabIndex = 18;
            chkStopOnMatch.Text = "Остановить обработку после срабатывания";
            // 
            // chkLogEvent
            // 
            chkLogEvent.BackColor = Color.Transparent;
            chkLogEvent.CheckBoxColor = Color.BlueViolet;
            chkLogEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkLogEvent.ForeColor = Color.White;
            chkLogEvent.Location = new Point(9, 443);
            chkLogEvent.MinimumSize = new Size(1, 1);
            chkLogEvent.Name = "chkLogEvent";
            chkLogEvent.Size = new Size(300, 25);
            chkLogEvent.TabIndex = 17;
            chkLogEvent.Text = "Логировать событие";
            // 
            // chkSendNotification
            // 
            chkSendNotification.BackColor = Color.Transparent;
            chkSendNotification.CheckBoxColor = Color.BlueViolet;
            chkSendNotification.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSendNotification.ForeColor = Color.White;
            chkSendNotification.Location = new Point(330, 413);
            chkSendNotification.MinimumSize = new Size(1, 1);
            chkSendNotification.Name = "chkSendNotification";
            chkSendNotification.Size = new Size(300, 25);
            chkSendNotification.TabIndex = 16;
            chkSendNotification.Text = "Отправить уведомление";
            // 
            // chkAutoPublish
            // 
            chkAutoPublish.BackColor = Color.Transparent;
            chkAutoPublish.CheckBoxColor = Color.BlueViolet;
            chkAutoPublish.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoPublish.ForeColor = Color.White;
            chkAutoPublish.Location = new Point(9, 413);
            chkAutoPublish.MinimumSize = new Size(1, 1);
            chkAutoPublish.Name = "chkAutoPublish";
            chkAutoPublish.Size = new Size(300, 25);
            chkAutoPublish.TabIndex = 15;
            chkAutoPublish.Text = "Автоматически публиковать при событии";
            // 
            // lblEventActions
            // 
            lblEventActions.AutoSize = true;
            lblEventActions.BackColor = Color.Transparent;
            lblEventActions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEventActions.ForeColor = Color.FromArgb(180, 180, 180);
            lblEventActions.Location = new Point(9, 388);
            lblEventActions.Name = "lblEventActions";
            lblEventActions.Size = new Size(138, 15);
            lblEventActions.TabIndex = 14;
            lblEventActions.Text = "Действия при событии:";
            // 
            // grpTriggerConditions
            // 
            grpTriggerConditions.Controls.Add(pnlTriggerConditions);
            grpTriggerConditions.FillColor = Color.Transparent;
            grpTriggerConditions.FillColor2 = Color.Transparent;
            grpTriggerConditions.FillDisableColor = Color.Transparent;
            grpTriggerConditions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpTriggerConditions.ForeColor = SystemColors.ActiveBorder;
            grpTriggerConditions.ForeDisableColor = Color.Transparent;
            grpTriggerConditions.Location = new Point(9, 243);
            grpTriggerConditions.Margin = new Padding(4, 5, 4, 5);
            grpTriggerConditions.MinimumSize = new Size(1, 1);
            grpTriggerConditions.Name = "grpTriggerConditions";
            grpTriggerConditions.Padding = new Padding(5, 32, 5, 5);
            grpTriggerConditions.RectColor = Color.FromArgb(58, 58, 69);
            grpTriggerConditions.RectDisableColor = Color.Transparent;
            grpTriggerConditions.Size = new Size(658, 130);
            grpTriggerConditions.TabIndex = 29;
            grpTriggerConditions.Text = "Условия триггера (динамически добавляются)";
            grpTriggerConditions.TextAlignment = ContentAlignment.MiddleLeft;
            grpTriggerConditions.TitleTop = 10;
            // 
            // pnlTriggerConditions
            // 
            pnlTriggerConditions.AutoScroll = true;
            pnlTriggerConditions.Dock = DockStyle.Fill;
            pnlTriggerConditions.FlowDirection = FlowDirection.TopDown;
            pnlTriggerConditions.Location = new Point(5, 32);
            pnlTriggerConditions.Name = "pnlTriggerConditions";
            pnlTriggerConditions.Size = new Size(648, 93);
            pnlTriggerConditions.TabIndex = 10;
            pnlTriggerConditions.WrapContents = false;
            // 
            // cmbEventType
            // 
            cmbEventType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEventType.DataSource = null;
            cmbEventType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEventType.FillColor = Color.FromArgb(42, 46, 57);
            cmbEventType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbEventType.ForeColor = Color.White;
            cmbEventType.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbEventType.ItemForeColor = Color.White;
            cmbEventType.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbEventType.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbEventType.Items.AddRange(new object[] { "Новое сообщение", "Ключевое слово", "Упоминание", "Команда", "Медиа (фото/видео)", "Новый участник", "Ответ (Reply)", "Редактирование сообщения", "Удаление сообщения", "Закрепление сообщения", "Изменение статуса" });
            cmbEventType.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbEventType.ItemSelectForeColor = Color.White;
            cmbEventType.Location = new Point(9, 203);
            cmbEventType.Margin = new Padding(4, 5, 4, 5);
            cmbEventType.MinimumSize = new Size(63, 0);
            cmbEventType.Name = "cmbEventType";
            cmbEventType.Padding = new Padding(0, 0, 30, 2);
            cmbEventType.RectColor = Color.FromArgb(65, 71, 84);
            cmbEventType.Size = new Size(658, 25);
            cmbEventType.Style = Sunny.UI.UIStyle.Custom;
            cmbEventType.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEventType.SymbolSize = 24;
            cmbEventType.TabIndex = 13;
            cmbEventType.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEventType.Watermark = "Выберите тип события";
            // 
            // lblEventType
            // 
            lblEventType.AutoSize = true;
            lblEventType.BackColor = Color.Transparent;
            lblEventType.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblEventType.ForeColor = Color.FromArgb(180, 180, 180);
            lblEventType.Location = new Point(9, 183);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(77, 13);
            lblEventType.TabIndex = 13;
            lblEventType.Text = "Тип события:";
            // 
            // cmbTriggerTarget
            // 
            cmbTriggerTarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTriggerTarget.DataSource = null;
            cmbTriggerTarget.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbTriggerTarget.FillColor = Color.FromArgb(42, 46, 57);
            cmbTriggerTarget.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbTriggerTarget.ForeColor = Color.White;
            cmbTriggerTarget.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbTriggerTarget.ItemForeColor = Color.White;
            cmbTriggerTarget.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbTriggerTarget.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbTriggerTarget.Items.AddRange(new object[] { "Telegram", "YouTube", "Discord", "VK" });
            cmbTriggerTarget.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbTriggerTarget.ItemSelectForeColor = Color.White;
            cmbTriggerTarget.Location = new Point(9, 148);
            cmbTriggerTarget.Margin = new Padding(4, 5, 4, 5);
            cmbTriggerTarget.MinimumSize = new Size(63, 0);
            cmbTriggerTarget.Name = "cmbTriggerTarget";
            cmbTriggerTarget.Padding = new Padding(0, 0, 30, 2);
            cmbTriggerTarget.RectColor = Color.FromArgb(65, 71, 84);
            cmbTriggerTarget.Size = new Size(658, 25);
            cmbTriggerTarget.Style = Sunny.UI.UIStyle.Custom;
            cmbTriggerTarget.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbTriggerTarget.SymbolSize = 24;
            cmbTriggerTarget.TabIndex = 12;
            cmbTriggerTarget.TextAlignment = ContentAlignment.MiddleLeft;
            cmbTriggerTarget.Watermark = "Выберите цель триггера";
            // 
            // lblTriggerTarget
            // 
            lblTriggerTarget.AutoSize = true;
            lblTriggerTarget.BackColor = Color.Transparent;
            lblTriggerTarget.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblTriggerTarget.ForeColor = Color.FromArgb(180, 180, 180);
            lblTriggerTarget.Location = new Point(9, 128);
            lblTriggerTarget.Name = "lblTriggerTarget";
            lblTriggerTarget.Size = new Size(86, 13);
            lblTriggerTarget.TabIndex = 12;
            lblTriggerTarget.Text = "Цель триггера:";
            // 
            // lblEventTemplateHint
            // 
            lblEventTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblEventTemplateHint.ForeColor = Color.DarkGray;
            lblEventTemplateHint.Location = new Point(9, 69);
            lblEventTemplateHint.Name = "lblEventTemplateHint";
            lblEventTemplateHint.Size = new Size(658, 45);
            lblEventTemplateHint.TabIndex = 27;
            lblEventTemplateHint.Text = resources.GetString("lblEventTemplateHint.Text");
            // 
            // txtEventCustomText
            // 
            txtEventCustomText.ButtonFillColor = Color.Transparent;
            txtEventCustomText.ButtonStyleInherited = false;
            txtEventCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtEventCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtEventCustomText.ForeColor = Color.White;
            txtEventCustomText.Location = new Point(9, 40);
            txtEventCustomText.Margin = new Padding(4, 5, 4, 5);
            txtEventCustomText.MinimumSize = new Size(1, 16);
            txtEventCustomText.Name = "txtEventCustomText";
            txtEventCustomText.Padding = new Padding(5);
            txtEventCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtEventCustomText.ShowText = false;
            txtEventCustomText.Size = new Size(658, 25);
            txtEventCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtEventCustomText.TabIndex = 26;
            txtEventCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtEventCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbEventTemplate
            // 
            cmbEventTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbEventTemplate.DataSource = null;
            cmbEventTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEventTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbEventTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbEventTemplate.ForeColor = Color.White;
            cmbEventTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbEventTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbEventTemplate.Location = new Point(9, 9);
            cmbEventTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbEventTemplate.MinimumSize = new Size(63, 0);
            cmbEventTemplate.Name = "cmbEventTemplate";
            cmbEventTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbEventTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbEventTemplate.Size = new Size(658, 25);
            cmbEventTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbEventTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEventTemplate.SymbolSize = 24;
            cmbEventTemplate.TabIndex = 25;
            cmbEventTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEventTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // EventTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpEvent);
            Name = "EventTabControl";
            Size = new Size(696, 483);
            grpEvent.ResumeLayout(false);
            pnlEventButtons.ResumeLayout(false);
            pnlEventInner.ResumeLayout(false);
            pnlEventContent.ResumeLayout(false);
            pnlEventContent.PerformLayout();
            grpEventHistory.ResumeLayout(false);
            grpTriggerConditions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpEvent;
        private Sunny.UI.UIPanel pnlEventButtons;
        private Sunny.UI.UICheckBox chkEventManualConfirm;
        private Sunny.UI.UIButton btnSaveEvent;
        private Sunny.UI.UIButton btnStartEvent;
        private Panel pnlEventInner;
        private Panel pnlEventContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbEventTemplate;
        private Sunny.UI.UITextBox txtEventCustomText;
        private Label lblEventTemplateHint;

        // Trigger Settings
        private Label lblTriggerTarget;
        private Sunny.UI.UIComboBox cmbTriggerTarget;
        private Label lblEventType;
        private Sunny.UI.UIComboBox cmbEventType;

        // Trigger Conditions (Expandable)
        private Sunny.UI.UIGroupBox grpTriggerConditions;
        private FlowLayoutPanel pnlTriggerConditions;

        // Event Actions
        private Sunny.UI.UICheckBox chkAutoPublish;
        private Label lblEventActions;
        private Sunny.UI.UICheckBox chkSendNotification;
        private Sunny.UI.UICheckBox chkLogEvent;
        private Sunny.UI.UICheckBox chkStopOnMatch;

        // Advanced Settings
        private Sunny.UI.UICheckBox chkEventCaseSensitive;
        private Sunny.UI.UICheckBox chkEventWholeWord;
        private Sunny.UI.UICheckBox chkEventRegex;
        private Label lblEventPriority;
        private Sunny.UI.UIIntegerUpDown nudEventPriority;

        // Notifications
        private Sunny.UI.UICheckBox chkNotifySuccess;
        private Sunny.UI.UIComboBox cmbNotifySuccess1;
        private Label lblNotifySuccessOr;
        private Sunny.UI.UIComboBox cmbNotifySuccess2;
        private Sunny.UI.UICheckBox chkNotifyError;
        private Sunny.UI.UIComboBox cmbNotifyError1;
        private Label lblNotifyErrorOr;
        private Sunny.UI.UIComboBox cmbNotifyError2;

        // History
        private Sunny.UI.UIGroupBox grpEventHistory;
        private FlowLayoutPanel flpEventHistory;
    }
}