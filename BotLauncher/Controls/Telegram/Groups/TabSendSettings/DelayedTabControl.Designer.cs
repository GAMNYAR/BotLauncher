namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class DelayedTabControl
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
            grpDelayed = new Sunny.UI.UIGroupBox();
            pnlDelayedButtons = new Sunny.UI.UIPanel();
            chkDelayedManualConfirm = new Sunny.UI.UICheckBox();
            btnSaveDelayed = new Sunny.UI.UIButton();
            btnStartDelayed = new Sunny.UI.UIButton();
            pnlDelayedInner = new Panel();
            pnlDelayedContent = new Panel();
            grpDelayedHistory = new Sunny.UI.UIGroupBox();
            flpDelayedHistory = new FlowLayoutPanel();
            chkAnimatedEffect = new Sunny.UI.UICheckBox();
            cmbAnimatedEffect = new Sunny.UI.UIComboBox();
            cmbEffectApplyTo = new Sunny.UI.UIComboBox();
            chkAnimatedEmoji = new Sunny.UI.UICheckBox();
            cmbAnimatedEmoji = new Sunny.UI.UIComboBox();
            cmbEmojiApplyTo = new Sunny.UI.UIComboBox();
            chkAutoRestart = new Sunny.UI.UICheckBox();
            chkIgnoreErrors = new Sunny.UI.UICheckBox();
            chkOnlyIfAdmin = new Sunny.UI.UICheckBox();
            chkDeletePrevious = new Sunny.UI.UICheckBox();
            chkHideSpoiler = new Sunny.UI.UICheckBox();
            chkSilentSend = new Sunny.UI.UICheckBox();
            chkNoAuthorMention = new Sunny.UI.UICheckBox();
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
            cmbDelayedTimezone = new Sunny.UI.UIComboBox();
            lblDelayedTimezone = new Label();
            chkDelayedOnce = new Sunny.UI.UICheckBox();
            nudDelayedRepeat = new Sunny.UI.UIIntegerUpDown();
            lblDelayedRepeatUnit = new Label();
            lblDelayedRepeat = new Label();
            cmbDelayedPreDelayUnit = new Sunny.UI.UIComboBox();
            nudDelayedPreDelay = new Sunny.UI.UIIntegerUpDown();
            lblDelayedPreDelay = new Label();
            dtpDelayedTime = new Sunny.UI.UITimePicker();
            lblDelayedTime = new Label();
            dtpDelayedDate = new Sunny.UI.UIDatePicker();
            lblDelayedDate = new Label();
            lblDelayedTemplateHint = new Label();
            txtDelayedCustomText = new Sunny.UI.UITextBox();
            cmbDelayedTemplate = new Sunny.UI.UIComboBox();
            radUseTemplate = new Sunny.UI.UIRadioButton();
            radUseCustomText = new Sunny.UI.UIRadioButton();
            grpDelayed.SuspendLayout();
            pnlDelayedButtons.SuspendLayout();
            pnlDelayedInner.SuspendLayout();
            pnlDelayedContent.SuspendLayout();
            grpDelayedHistory.SuspendLayout();
            SuspendLayout();
            // 
            // grpDelayed
            // 
            grpDelayed.BackColor = Color.FromArgb(35, 39, 48);
            grpDelayed.Controls.Add(pnlDelayedButtons);
            grpDelayed.Controls.Add(pnlDelayedInner);
            grpDelayed.Dock = DockStyle.Fill;
            grpDelayed.FillColor = Color.Transparent;
            grpDelayed.FillColor2 = Color.Transparent;
            grpDelayed.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpDelayed.ForeColor = Color.White;
            grpDelayed.Location = new Point(0, 0);
            grpDelayed.Margin = new Padding(4, 5, 4, 5);
            grpDelayed.MinimumSize = new Size(1, 1);
            grpDelayed.Name = "grpDelayed";
            grpDelayed.Padding = new Padding(0, 32, 0, 0);
            grpDelayed.Radius = 15;
            grpDelayed.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpDelayed.RectColor = Color.FromArgb(58, 58, 69);
            grpDelayed.Size = new Size(696, 483);
            grpDelayed.Style = Sunny.UI.UIStyle.Custom;
            grpDelayed.TabIndex = 7;
            grpDelayed.Text = "Настройки отложенной отправки";
            grpDelayed.TextAlignment = ContentAlignment.MiddleLeft;
            grpDelayed.TitleInterval = 8;
            grpDelayed.TitleTop = 14;
            // 
            // pnlDelayedButtons
            // 
            pnlDelayedButtons.Controls.Add(chkDelayedManualConfirm);
            pnlDelayedButtons.Controls.Add(btnSaveDelayed);
            pnlDelayedButtons.Controls.Add(btnStartDelayed);
            pnlDelayedButtons.Dock = DockStyle.Bottom;
            pnlDelayedButtons.FillColor = Color.Transparent;
            pnlDelayedButtons.FillColor2 = Color.Transparent;
            pnlDelayedButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlDelayedButtons.ForeColor = Color.Transparent;
            pnlDelayedButtons.Location = new Point(0, 438);
            pnlDelayedButtons.Margin = new Padding(4, 5, 4, 5);
            pnlDelayedButtons.MinimumSize = new Size(1, 1);
            pnlDelayedButtons.Name = "pnlDelayedButtons";
            pnlDelayedButtons.Radius = 0;
            pnlDelayedButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlDelayedButtons.RectDisableColor = Color.Transparent;
            pnlDelayedButtons.Size = new Size(696, 45);
            pnlDelayedButtons.TabIndex = 19;
            pnlDelayedButtons.Text = null;
            pnlDelayedButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkDelayedManualConfirm
            // 
            chkDelayedManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkDelayedManualConfirm.BackColor = Color.Transparent;
            chkDelayedManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkDelayedManualConfirm.Checked = true;
            chkDelayedManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDelayedManualConfirm.ForeColor = Color.White;
            chkDelayedManualConfirm.Location = new Point(46, 10);
            chkDelayedManualConfirm.MinimumSize = new Size(1, 1);
            chkDelayedManualConfirm.Name = "chkDelayedManualConfirm";
            chkDelayedManualConfirm.Size = new Size(333, 25);
            chkDelayedManualConfirm.TabIndex = 27;
            chkDelayedManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSaveDelayed
            // 
            btnSaveDelayed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveDelayed.FillColor = Color.BlueViolet;
            btnSaveDelayed.FillColor2 = Color.Transparent;
            btnSaveDelayed.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSaveDelayed.FillHoverColor = Color.DarkOrchid;
            btnSaveDelayed.FillPressColor = Color.DarkViolet;
            btnSaveDelayed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveDelayed.Location = new Point(389, 5);
            btnSaveDelayed.MinimumSize = new Size(1, 1);
            btnSaveDelayed.Name = "btnSaveDelayed";
            btnSaveDelayed.Radius = 8;
            btnSaveDelayed.RectColor = Color.Transparent;
            btnSaveDelayed.Size = new Size(150, 35);
            btnSaveDelayed.Style = Sunny.UI.UIStyle.Custom;
            btnSaveDelayed.TabIndex = 13;
            btnSaveDelayed.Text = "Сохранить настройки";
            btnSaveDelayed.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnStartDelayed
            // 
            btnStartDelayed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartDelayed.FillColor = Color.Indigo;
            btnStartDelayed.FillColor2 = Color.Transparent;
            btnStartDelayed.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnStartDelayed.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnStartDelayed.FillPressColor = Color.FromArgb(109, 40, 217);
            btnStartDelayed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStartDelayed.Location = new Point(543, 5);
            btnStartDelayed.MinimumSize = new Size(1, 1);
            btnStartDelayed.Name = "btnStartDelayed";
            btnStartDelayed.Radius = 8;
            btnStartDelayed.RectColor = Color.Transparent;
            btnStartDelayed.Size = new Size(150, 35);
            btnStartDelayed.Style = Sunny.UI.UIStyle.Custom;
            btnStartDelayed.TabIndex = 14;
            btnStartDelayed.Text = "Начать сеанс";
            btnStartDelayed.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlDelayedInner
            // 
            pnlDelayedInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDelayedInner.AutoScroll = true;
            pnlDelayedInner.Controls.Add(pnlDelayedContent);
            pnlDelayedInner.Location = new Point(3, 25);
            pnlDelayedInner.Name = "pnlDelayedInner";
            pnlDelayedInner.Size = new Size(693, 413);
            pnlDelayedInner.TabIndex = 20;
            // 
            // pnlDelayedContent
            // 
            pnlDelayedContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlDelayedContent.Controls.Add(grpDelayedHistory);
            pnlDelayedContent.Controls.Add(chkAnimatedEffect);
            pnlDelayedContent.Controls.Add(cmbAnimatedEffect);
            pnlDelayedContent.Controls.Add(cmbEffectApplyTo);
            pnlDelayedContent.Controls.Add(chkAnimatedEmoji);
            pnlDelayedContent.Controls.Add(cmbAnimatedEmoji);
            pnlDelayedContent.Controls.Add(cmbEmojiApplyTo);
            pnlDelayedContent.Controls.Add(chkAutoRestart);
            pnlDelayedContent.Controls.Add(chkIgnoreErrors);
            pnlDelayedContent.Controls.Add(chkOnlyIfAdmin);
            pnlDelayedContent.Controls.Add(chkDeletePrevious);
            pnlDelayedContent.Controls.Add(chkHideSpoiler);
            pnlDelayedContent.Controls.Add(chkSilentSend);
            pnlDelayedContent.Controls.Add(chkNoAuthorMention);
            pnlDelayedContent.Controls.Add(chkDisablePreview);
            pnlDelayedContent.Controls.Add(chkSendTemplateFirst);
            pnlDelayedContent.Controls.Add(chkNotifyError);
            pnlDelayedContent.Controls.Add(cmbNotifyError1);
            pnlDelayedContent.Controls.Add(lblNotifyErrorOr);
            pnlDelayedContent.Controls.Add(cmbNotifyError2);
            pnlDelayedContent.Controls.Add(chkNotifyComplete);
            pnlDelayedContent.Controls.Add(cmbNotifyComplete1);
            pnlDelayedContent.Controls.Add(lblNotifyCompleteOr);
            pnlDelayedContent.Controls.Add(cmbNotifyComplete2);
            pnlDelayedContent.Controls.Add(chkNotifySuccess);
            pnlDelayedContent.Controls.Add(cmbNotifySuccess1);
            pnlDelayedContent.Controls.Add(lblNotifySuccessOr);
            pnlDelayedContent.Controls.Add(cmbNotifySuccess2);
            pnlDelayedContent.Controls.Add(cmbDelayedTimezone);
            pnlDelayedContent.Controls.Add(lblDelayedTimezone);
            pnlDelayedContent.Controls.Add(chkDelayedOnce);
            pnlDelayedContent.Controls.Add(nudDelayedRepeat);
            pnlDelayedContent.Controls.Add(lblDelayedRepeatUnit);
            pnlDelayedContent.Controls.Add(lblDelayedRepeat);
            pnlDelayedContent.Controls.Add(cmbDelayedPreDelayUnit);
            pnlDelayedContent.Controls.Add(nudDelayedPreDelay);
            pnlDelayedContent.Controls.Add(lblDelayedPreDelay);
            pnlDelayedContent.Controls.Add(dtpDelayedTime);
            pnlDelayedContent.Controls.Add(lblDelayedTime);
            pnlDelayedContent.Controls.Add(dtpDelayedDate);
            pnlDelayedContent.Controls.Add(lblDelayedDate);
            pnlDelayedContent.Controls.Add(lblDelayedTemplateHint);
            pnlDelayedContent.Controls.Add(txtDelayedCustomText);
            pnlDelayedContent.Controls.Add(cmbDelayedTemplate);
            pnlDelayedContent.Controls.Add(radUseTemplate);
            pnlDelayedContent.Controls.Add(radUseCustomText);
            pnlDelayedContent.Location = new Point(0, 0);
            pnlDelayedContent.MinimumSize = new Size(673, 0);
            pnlDelayedContent.Name = "pnlDelayedContent";
            pnlDelayedContent.Padding = new Padding(16, 0, 16, 0);
            pnlDelayedContent.Size = new Size(676, 1330);
            pnlDelayedContent.TabIndex = 0;
            // 
            // grpDelayedHistory
            // 
            grpDelayedHistory.Controls.Add(flpDelayedHistory);
            grpDelayedHistory.FillColor = Color.Transparent;
            grpDelayedHistory.FillColor2 = Color.Transparent;
            grpDelayedHistory.FillDisableColor = Color.Transparent;
            grpDelayedHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDelayedHistory.ForeColor = SystemColors.ActiveBorder;
            grpDelayedHistory.ForeDisableColor = Color.Transparent;
            grpDelayedHistory.Location = new Point(16, 610);
            grpDelayedHistory.Margin = new Padding(4, 5, 4, 5);
            grpDelayedHistory.MinimumSize = new Size(1, 1);
            grpDelayedHistory.Name = "grpDelayedHistory";
            grpDelayedHistory.Padding = new Padding(5, 32, 5, 5);
            grpDelayedHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpDelayedHistory.RectDisableColor = Color.Transparent;
            grpDelayedHistory.Size = new Size(644, 290);
            grpDelayedHistory.TabIndex = 30;
            grpDelayedHistory.Text = "История отправок:";
            grpDelayedHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpDelayedHistory.TitleTop = 10;
            // 
            // flpDelayedHistory
            // 
            flpDelayedHistory.AutoScroll = true;
            flpDelayedHistory.FlowDirection = FlowDirection.TopDown;
            flpDelayedHistory.Location = new Point(10, 20);
            flpDelayedHistory.Name = "flpDelayedHistory";
            flpDelayedHistory.Size = new Size(622, 259);
            flpDelayedHistory.TabIndex = 10;
            flpDelayedHistory.WrapContents = false;
            // 
            // chkAnimatedEffect
            // 
            chkAnimatedEffect.BackColor = Color.Transparent;
            chkAnimatedEffect.CheckBoxColor = Color.BlueViolet;
            chkAnimatedEffect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAnimatedEffect.ForeColor = Color.White;
            chkAnimatedEffect.Location = new Point(16, 570);
            chkAnimatedEffect.MinimumSize = new Size(1, 1);
            chkAnimatedEffect.Name = "chkAnimatedEffect";
            chkAnimatedEffect.Size = new Size(239, 25);
            chkAnimatedEffect.TabIndex = 74;
            chkAnimatedEffect.Text = "Добавить анимированный эффект:";
            // 
            // cmbAnimatedEffect
            // 
            cmbAnimatedEffect.DataSource = null;
            cmbAnimatedEffect.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAnimatedEffect.FillColor = Color.FromArgb(42, 46, 57);
            cmbAnimatedEffect.Font = new Font("Segoe UI", 9F);
            cmbAnimatedEffect.ForeColor = Color.White;
            cmbAnimatedEffect.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbAnimatedEffect.ItemForeColor = Color.White;
            cmbAnimatedEffect.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbAnimatedEffect.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbAnimatedEffect.Items.AddRange(new object[] { "Огонь", "Лайк", "Сердце", "Конфетти" });
            cmbAnimatedEffect.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbAnimatedEffect.ItemSelectForeColor = Color.White;
            cmbAnimatedEffect.Location = new Point(265, 570);
            cmbAnimatedEffect.Margin = new Padding(4, 5, 4, 5);
            cmbAnimatedEffect.MinimumSize = new Size(63, 0);
            cmbAnimatedEffect.Name = "cmbAnimatedEffect";
            cmbAnimatedEffect.Padding = new Padding(0, 0, 30, 2);
            cmbAnimatedEffect.RectColor = Color.FromArgb(65, 71, 84);
            cmbAnimatedEffect.Size = new Size(151, 25);
            cmbAnimatedEffect.Style = Sunny.UI.UIStyle.Custom;
            cmbAnimatedEffect.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAnimatedEffect.SymbolSize = 24;
            cmbAnimatedEffect.TabIndex = 72;
            cmbAnimatedEffect.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAnimatedEffect.Watermark = "Выберите эффект";
            // 
            // cmbEffectApplyTo
            // 
            cmbEffectApplyTo.DataSource = null;
            cmbEffectApplyTo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEffectApplyTo.FillColor = Color.FromArgb(42, 46, 57);
            cmbEffectApplyTo.Font = new Font("Segoe UI", 9F);
            cmbEffectApplyTo.ForeColor = Color.White;
            cmbEffectApplyTo.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbEffectApplyTo.ItemForeColor = Color.White;
            cmbEffectApplyTo.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbEffectApplyTo.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbEffectApplyTo.Items.AddRange(new object[] { "Только на сообщение", "Только на шаблон", "На оба" });
            cmbEffectApplyTo.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbEffectApplyTo.ItemSelectForeColor = Color.White;
            cmbEffectApplyTo.Location = new Point(426, 570);
            cmbEffectApplyTo.Margin = new Padding(4, 5, 4, 5);
            cmbEffectApplyTo.MinimumSize = new Size(63, 0);
            cmbEffectApplyTo.Name = "cmbEffectApplyTo";
            cmbEffectApplyTo.Padding = new Padding(0, 0, 30, 2);
            cmbEffectApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            cmbEffectApplyTo.Size = new Size(151, 25);
            cmbEffectApplyTo.Style = Sunny.UI.UIStyle.Custom;
            cmbEffectApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEffectApplyTo.SymbolSize = 24;
            cmbEffectApplyTo.TabIndex = 72;
            cmbEffectApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEffectApplyTo.Watermark = "Применить на";
            // 
            // chkAnimatedEmoji
            // 
            chkAnimatedEmoji.BackColor = Color.Transparent;
            chkAnimatedEmoji.CheckBoxColor = Color.BlueViolet;
            chkAnimatedEmoji.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAnimatedEmoji.ForeColor = Color.White;
            chkAnimatedEmoji.Location = new Point(16, 540);
            chkAnimatedEmoji.MinimumSize = new Size(1, 1);
            chkAnimatedEmoji.Name = "chkAnimatedEmoji";
            chkAnimatedEmoji.Size = new Size(239, 25);
            chkAnimatedEmoji.TabIndex = 73;
            chkAnimatedEmoji.Text = "Добавить анимированный смайлик:";
            // 
            // cmbAnimatedEmoji
            // 
            cmbAnimatedEmoji.DataSource = null;
            cmbAnimatedEmoji.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAnimatedEmoji.FillColor = Color.FromArgb(42, 46, 57);
            cmbAnimatedEmoji.Font = new Font("Segoe UI", 9F);
            cmbAnimatedEmoji.ForeColor = Color.White;
            cmbAnimatedEmoji.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbAnimatedEmoji.ItemForeColor = Color.White;
            cmbAnimatedEmoji.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbAnimatedEmoji.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbAnimatedEmoji.Items.AddRange(new object[] { "Кубик", "Мяч баскетбольный", "Слот-машина", "Дартс" });
            cmbAnimatedEmoji.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbAnimatedEmoji.ItemSelectForeColor = Color.White;
            cmbAnimatedEmoji.Location = new Point(265, 540);
            cmbAnimatedEmoji.Margin = new Padding(4, 5, 4, 5);
            cmbAnimatedEmoji.MinimumSize = new Size(63, 0);
            cmbAnimatedEmoji.Name = "cmbAnimatedEmoji";
            cmbAnimatedEmoji.Padding = new Padding(0, 0, 30, 2);
            cmbAnimatedEmoji.RectColor = Color.FromArgb(65, 71, 84);
            cmbAnimatedEmoji.Size = new Size(151, 25);
            cmbAnimatedEmoji.Style = Sunny.UI.UIStyle.Custom;
            cmbAnimatedEmoji.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAnimatedEmoji.SymbolSize = 24;
            cmbAnimatedEmoji.TabIndex = 71;
            cmbAnimatedEmoji.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAnimatedEmoji.Watermark = "Выберите смайлик";
            // 
            // cmbEmojiApplyTo
            // 
            cmbEmojiApplyTo.DataSource = null;
            cmbEmojiApplyTo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEmojiApplyTo.FillColor = Color.FromArgb(42, 46, 57);
            cmbEmojiApplyTo.Font = new Font("Segoe UI", 9F);
            cmbEmojiApplyTo.ForeColor = Color.White;
            cmbEmojiApplyTo.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbEmojiApplyTo.ItemForeColor = Color.White;
            cmbEmojiApplyTo.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbEmojiApplyTo.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbEmojiApplyTo.Items.AddRange(new object[] { "Только на сообщение", "Только на шаблон", "На оба" });
            cmbEmojiApplyTo.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbEmojiApplyTo.ItemSelectForeColor = Color.White;
            cmbEmojiApplyTo.Location = new Point(426, 540);
            cmbEmojiApplyTo.Margin = new Padding(4, 5, 4, 5);
            cmbEmojiApplyTo.MinimumSize = new Size(63, 0);
            cmbEmojiApplyTo.Name = "cmbEmojiApplyTo";
            cmbEmojiApplyTo.Padding = new Padding(0, 0, 30, 2);
            cmbEmojiApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            cmbEmojiApplyTo.Size = new Size(151, 25);
            cmbEmojiApplyTo.Style = Sunny.UI.UIStyle.Custom;
            cmbEmojiApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEmojiApplyTo.SymbolSize = 24;
            cmbEmojiApplyTo.TabIndex = 72;
            cmbEmojiApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEmojiApplyTo.Watermark = "Применить на";
            // 
            // chkAutoRestart
            // 
            chkAutoRestart.BackColor = Color.Transparent;
            chkAutoRestart.CheckBoxColor = Color.BlueViolet;
            chkAutoRestart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoRestart.ForeColor = Color.White;
            chkAutoRestart.Location = new Point(16, 500);
            chkAutoRestart.MinimumSize = new Size(1, 1);
            chkAutoRestart.Name = "chkAutoRestart";
            chkAutoRestart.Size = new Size(300, 25);
            chkAutoRestart.TabIndex = 93;
            chkAutoRestart.Text = "Автоматически перезапускать после сбоя бота";
            // 
            // chkIgnoreErrors
            // 
            chkIgnoreErrors.BackColor = Color.Transparent;
            chkIgnoreErrors.CheckBoxColor = Color.BlueViolet;
            chkIgnoreErrors.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkIgnoreErrors.ForeColor = Color.White;
            chkIgnoreErrors.Location = new Point(16, 470);
            chkIgnoreErrors.MinimumSize = new Size(1, 1);
            chkIgnoreErrors.Name = "chkIgnoreErrors";
            chkIgnoreErrors.Size = new Size(300, 25);
            chkIgnoreErrors.TabIndex = 95;
            chkIgnoreErrors.Text = "Игнорировать ошибки и продолжать сессию";
            // 
            // chkOnlyIfAdmin
            // 
            chkOnlyIfAdmin.BackColor = Color.Transparent;
            chkOnlyIfAdmin.CheckBoxColor = Color.BlueViolet;
            chkOnlyIfAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkOnlyIfAdmin.ForeColor = Color.White;
            chkOnlyIfAdmin.Location = new Point(16, 440);
            chkOnlyIfAdmin.MinimumSize = new Size(1, 1);
            chkOnlyIfAdmin.Name = "chkOnlyIfAdmin";
            chkOnlyIfAdmin.Size = new Size(300, 25);
            chkOnlyIfAdmin.TabIndex = 94;
            chkOnlyIfAdmin.Text = "Отправлять только если бот администратор";
            // 
            // chkDeletePrevious
            // 
            chkDeletePrevious.BackColor = Color.Transparent;
            chkDeletePrevious.CheckBoxColor = Color.BlueViolet;
            chkDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDeletePrevious.ForeColor = Color.White;
            chkDeletePrevious.Location = new Point(286, 410);
            chkDeletePrevious.MinimumSize = new Size(1, 1);
            chkDeletePrevious.Name = "chkDeletePrevious";
            chkDeletePrevious.Size = new Size(346, 25);
            chkDeletePrevious.TabIndex = 60;
            chkDeletePrevious.Text = "Удалить предыдущее сообщение бота перед отправкой";
            // 
            // chkHideSpoiler
            // 
            chkHideSpoiler.BackColor = Color.Transparent;
            chkHideSpoiler.CheckBoxColor = Color.BlueViolet;
            chkHideSpoiler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkHideSpoiler.ForeColor = Color.White;
            chkHideSpoiler.Location = new Point(16, 410);
            chkHideSpoiler.MinimumSize = new Size(1, 1);
            chkHideSpoiler.Name = "chkHideSpoiler";
            chkHideSpoiler.Size = new Size(231, 25);
            chkHideSpoiler.TabIndex = 59;
            chkHideSpoiler.Text = "Скрыть содержимое как спойлер";
            // 
            // chkSilentSend
            // 
            chkSilentSend.BackColor = Color.Transparent;
            chkSilentSend.CheckBoxColor = Color.BlueViolet;
            chkSilentSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSilentSend.ForeColor = Color.White;
            chkSilentSend.Location = new Point(16, 380);
            chkSilentSend.MinimumSize = new Size(1, 1);
            chkSilentSend.Name = "chkSilentSend";
            chkSilentSend.Size = new Size(231, 25);
            chkSilentSend.TabIndex = 29;
            chkSilentSend.Text = "Тихая отправка (без звука)";
            // 
            // chkNoAuthorMention
            // 
            chkNoAuthorMention.BackColor = Color.Transparent;
            chkNoAuthorMention.CheckBoxColor = Color.BlueViolet;
            chkNoAuthorMention.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNoAuthorMention.ForeColor = Color.White;
            chkNoAuthorMention.Location = new Point(286, 380);
            chkNoAuthorMention.MinimumSize = new Size(1, 1);
            chkNoAuthorMention.Name = "chkNoAuthorMention";
            chkNoAuthorMention.Size = new Size(346, 25);
            chkNoAuthorMention.TabIndex = 52;
            chkNoAuthorMention.Text = "Отправить без упоминания автора (как своё)";
            // 
            // chkDisablePreview
            // 
            chkDisablePreview.BackColor = Color.Transparent;
            chkDisablePreview.CheckBoxColor = Color.BlueViolet;
            chkDisablePreview.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDisablePreview.ForeColor = Color.White;
            chkDisablePreview.Location = new Point(286, 350);
            chkDisablePreview.MinimumSize = new Size(1, 1);
            chkDisablePreview.Name = "chkDisablePreview";
            chkDisablePreview.Size = new Size(346, 25);
            chkDisablePreview.TabIndex = 28;
            chkDisablePreview.Text = "Отключить предпросмотр ссылок";
            // 
            // chkSendTemplateFirst
            // 
            chkSendTemplateFirst.BackColor = Color.Transparent;
            chkSendTemplateFirst.CheckBoxColor = Color.BlueViolet;
            chkSendTemplateFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSendTemplateFirst.ForeColor = Color.White;
            chkSendTemplateFirst.Location = new Point(16, 350);
            chkSendTemplateFirst.MinimumSize = new Size(1, 1);
            chkSendTemplateFirst.Name = "chkSendTemplateFirst";
            chkSendTemplateFirst.Size = new Size(264, 25);
            chkSendTemplateFirst.TabIndex = 26;
            chkSendTemplateFirst.Text = "Отправить первым шаблон";
            // 
            // chkNotifyError
            // 
            chkNotifyError.BackColor = Color.Transparent;
            chkNotifyError.CheckBoxColor = Color.BlueViolet;
            chkNotifyError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyError.ForeColor = Color.White;
            chkNotifyError.Location = new Point(16, 305);
            chkNotifyError.MinimumSize = new Size(1, 1);
            chkNotifyError.Name = "chkNotifyError";
            chkNotifyError.Size = new Size(255, 25);
            chkNotifyError.TabIndex = 75;
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
            cmbNotifyError1.Location = new Point(280, 305);
            cmbNotifyError1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyError1.MinimumSize = new Size(63, 0);
            cmbNotifyError1.Name = "cmbNotifyError1";
            cmbNotifyError1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyError1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyError1.Size = new Size(146, 25);
            cmbNotifyError1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyError1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyError1.SymbolSize = 24;
            cmbNotifyError1.TabIndex = 56;
            cmbNotifyError1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError1.Watermark = "Куда отправить";
            // 
            // lblNotifyErrorOr
            // 
            lblNotifyErrorOr.AutoSize = true;
            lblNotifyErrorOr.BackColor = Color.Transparent;
            lblNotifyErrorOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyErrorOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyErrorOr.Location = new Point(432, 310);
            lblNotifyErrorOr.Name = "lblNotifyErrorOr";
            lblNotifyErrorOr.Size = new Size(39, 13);
            lblNotifyErrorOr.TabIndex = 78;
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
            cmbNotifyError2.Location = new Point(480, 305);
            cmbNotifyError2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyError2.MinimumSize = new Size(63, 0);
            cmbNotifyError2.Name = "cmbNotifyError2";
            cmbNotifyError2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyError2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyError2.Size = new Size(146, 25);
            cmbNotifyError2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyError2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyError2.SymbolSize = 24;
            cmbNotifyError2.TabIndex = 58;
            cmbNotifyError2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyError2.Watermark = "Куда отправить";
            // 
            // chkNotifyComplete
            // 
            chkNotifyComplete.BackColor = Color.Transparent;
            chkNotifyComplete.CheckBoxColor = Color.BlueViolet;
            chkNotifyComplete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyComplete.ForeColor = Color.White;
            chkNotifyComplete.Location = new Point(16, 275);
            chkNotifyComplete.MinimumSize = new Size(1, 1);
            chkNotifyComplete.Name = "chkNotifyComplete";
            chkNotifyComplete.Size = new Size(255, 25);
            chkNotifyComplete.TabIndex = 54;
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
            cmbNotifyComplete1.Location = new Point(280, 275);
            cmbNotifyComplete1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete1.MinimumSize = new Size(63, 0);
            cmbNotifyComplete1.Name = "cmbNotifyComplete1";
            cmbNotifyComplete1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete1.Size = new Size(146, 25);
            cmbNotifyComplete1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete1.SymbolSize = 24;
            cmbNotifyComplete1.TabIndex = 55;
            cmbNotifyComplete1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete1.Watermark = "Куда отправить";
            // 
            // lblNotifyCompleteOr
            // 
            lblNotifyCompleteOr.AutoSize = true;
            lblNotifyCompleteOr.BackColor = Color.Transparent;
            lblNotifyCompleteOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifyCompleteOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifyCompleteOr.Location = new Point(432, 280);
            lblNotifyCompleteOr.Name = "lblNotifyCompleteOr";
            lblNotifyCompleteOr.Size = new Size(39, 13);
            lblNotifyCompleteOr.TabIndex = 77;
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
            cmbNotifyComplete2.Location = new Point(480, 275);
            cmbNotifyComplete2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifyComplete2.MinimumSize = new Size(63, 0);
            cmbNotifyComplete2.Name = "cmbNotifyComplete2";
            cmbNotifyComplete2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifyComplete2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifyComplete2.Size = new Size(146, 25);
            cmbNotifyComplete2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifyComplete2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifyComplete2.SymbolSize = 24;
            cmbNotifyComplete2.TabIndex = 57;
            cmbNotifyComplete2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifyComplete2.Watermark = "Куда отправить";
            // 
            // chkNotifySuccess
            // 
            chkNotifySuccess.BackColor = Color.Transparent;
            chkNotifySuccess.CheckBoxColor = Color.BlueViolet;
            chkNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifySuccess.ForeColor = Color.White;
            chkNotifySuccess.Location = new Point(16, 245);
            chkNotifySuccess.MinimumSize = new Size(1, 1);
            chkNotifySuccess.Name = "chkNotifySuccess";
            chkNotifySuccess.Size = new Size(255, 25);
            chkNotifySuccess.TabIndex = 53;
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
            cmbNotifySuccess1.Location = new Point(280, 245);
            cmbNotifySuccess1.Margin = new Padding(4, 5, 4, 5);
            cmbNotifySuccess1.MinimumSize = new Size(63, 0);
            cmbNotifySuccess1.Name = "cmbNotifySuccess1";
            cmbNotifySuccess1.Padding = new Padding(0, 0, 30, 2);
            cmbNotifySuccess1.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifySuccess1.Size = new Size(146, 25);
            cmbNotifySuccess1.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifySuccess1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifySuccess1.SymbolSize = 24;
            cmbNotifySuccess1.TabIndex = 56;
            cmbNotifySuccess1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifySuccess1.Watermark = "Куда отправить";
            // 
            // lblNotifySuccessOr
            // 
            lblNotifySuccessOr.AutoSize = true;
            lblNotifySuccessOr.BackColor = Color.Transparent;
            lblNotifySuccessOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblNotifySuccessOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblNotifySuccessOr.Location = new Point(432, 250);
            lblNotifySuccessOr.Name = "lblNotifySuccessOr";
            lblNotifySuccessOr.Size = new Size(39, 13);
            lblNotifySuccessOr.TabIndex = 76;
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
            cmbNotifySuccess2.Location = new Point(480, 245);
            cmbNotifySuccess2.Margin = new Padding(4, 5, 4, 5);
            cmbNotifySuccess2.MinimumSize = new Size(63, 0);
            cmbNotifySuccess2.Name = "cmbNotifySuccess2";
            cmbNotifySuccess2.Padding = new Padding(0, 0, 30, 2);
            cmbNotifySuccess2.RectColor = Color.FromArgb(65, 71, 84);
            cmbNotifySuccess2.Size = new Size(146, 25);
            cmbNotifySuccess2.Style = Sunny.UI.UIStyle.Custom;
            cmbNotifySuccess2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbNotifySuccess2.SymbolSize = 24;
            cmbNotifySuccess2.TabIndex = 59;
            cmbNotifySuccess2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbNotifySuccess2.Watermark = "Куда отправить";
            // 
            // cmbDelayedTimezone
            // 
            cmbDelayedTimezone.DataSource = null;
            cmbDelayedTimezone.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbDelayedTimezone.FillColor = Color.FromArgb(42, 46, 57);
            cmbDelayedTimezone.Font = new Font("Segoe UI", 9F);
            cmbDelayedTimezone.ForeColor = Color.White;
            cmbDelayedTimezone.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbDelayedTimezone.ItemForeColor = Color.White;
            cmbDelayedTimezone.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbDelayedTimezone.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbDelayedTimezone.Items.AddRange(new object[] { "GMT-12 (Бейкер, Хауленд)", "GMT-11 (Нукуалофа, Паго-Паго, Ниуэ)", "GMT-10 (Гонолулу, Алеутские острова)", "GMT-9 (Анкоридж, Джуно, Аляска)", "GMT-8 (Лос-Анджелес, Сан-Франциско, Ванкувер, Сиэтл)", "GMT-7 (Денвер, Финикс, Калгари, Солт-Лейк-Сити)", "GMT-6 (Чикаго, Мехико, Гватемала, Сан-Хосе)", "GMT-5 (Нью-Йорк, Майами, Богота, Лима, Гавана)", "GMT-4 (Сантьяго, Ла-Пас, Каракас, Галифакс)", "GMT-3 (Буэнос-Айрес, Сан-Паулу, Монтевидео, Бразилиа)", "GMT-2 (Южная Георгия, Сандвичевы острова)", "GMT-1 (Азорские острова, Кабо-Верде)", "GMT+0 (Лондон, Лиссабон, Дублин, Аккра, Касабланка)", "GMT+1 (Париж, Берлин, Рим, Мадрид, Варшава, Амстердам)", "GMT+2 (Каир, Афины, Хельсинки, Киев, Бухарест, Стамбул)", "GMT+3 (Москва, Эр-Рияд, Найроби, Багдад, Кувейт)", "GMT+4 (Дубай, Баку, Тбилиси, Ереван, Маврикий)", "GMT+5 (Карачи, Ташкент, Екатеринбург, Мальдивы)", "GMT+6 (Дакка, Алматы, Омск, Коломбо, Бишкек)", "GMT+7 (Бангкок, Хошимин, Джакарта, Новосибирск, Красноярск)", "GMT+8 (Пекин, Сингапур, Манила, Куала-Лумпур, Улан-Батор, Иркутск)", "GMT+9 (Токио, Сеул, Пхеньян, Якутск, Осака)", "GMT+10 (Сидней, Мельбурн, Владивосток, Порт-Морсби, Гуам)", "GMT+11 (Нумеа, Соломоновы острова)", "GMT+12 (Окленд, Фиджи, Магадан, Веллингтон)", "GMT+13 (Нукуалофа, Самоа, Тонга)", "GMT+14 (Киритимати, Острова Лайн)" });
            cmbDelayedTimezone.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbDelayedTimezone.ItemSelectForeColor = Color.White;
            cmbDelayedTimezone.Location = new Point(106, 200);
            cmbDelayedTimezone.Margin = new Padding(4, 5, 4, 5);
            cmbDelayedTimezone.MinimumSize = new Size(63, 0);
            cmbDelayedTimezone.Name = "cmbDelayedTimezone";
            cmbDelayedTimezone.Padding = new Padding(0, 0, 30, 2);
            cmbDelayedTimezone.RectColor = Color.FromArgb(65, 71, 84);
            cmbDelayedTimezone.Size = new Size(554, 25);
            cmbDelayedTimezone.Style = Sunny.UI.UIStyle.Custom;
            cmbDelayedTimezone.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbDelayedTimezone.SymbolSize = 24;
            cmbDelayedTimezone.TabIndex = 5;
            cmbDelayedTimezone.TextAlignment = ContentAlignment.MiddleLeft;
            cmbDelayedTimezone.Watermark = "Выберите пояс";
            // 
            // lblDelayedTimezone
            // 
            lblDelayedTimezone.AutoSize = true;
            lblDelayedTimezone.BackColor = Color.Transparent;
            lblDelayedTimezone.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDelayedTimezone.ForeColor = Color.FromArgb(180, 180, 180);
            lblDelayedTimezone.Location = new Point(16, 205);
            lblDelayedTimezone.Name = "lblDelayedTimezone";
            lblDelayedTimezone.Size = new Size(84, 13);
            lblDelayedTimezone.TabIndex = 4;
            lblDelayedTimezone.Text = "Часовой пояс:";
            // 
            // chkDelayedOnce
            // 
            chkDelayedOnce.BackColor = Color.Transparent;
            chkDelayedOnce.CheckBoxColor = Color.BlueViolet;
            chkDelayedOnce.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDelayedOnce.ForeColor = Color.White;
            chkDelayedOnce.Location = new Point(290, 160);
            chkDelayedOnce.MinimumSize = new Size(1, 1);
            chkDelayedOnce.Name = "chkDelayedOnce";
            chkDelayedOnce.Size = new Size(168, 25);
            chkDelayedOnce.TabIndex = 6;
            chkDelayedOnce.Text = "Однократная отправка";
            // 
            // nudDelayedRepeat
            // 
            nudDelayedRepeat.FillColor = Color.FromArgb(42, 46, 57);
            nudDelayedRepeat.Font = new Font("Segoe UI", 9.75F);
            nudDelayedRepeat.ForeColor = Color.White;
            nudDelayedRepeat.Location = new Point(146, 160);
            nudDelayedRepeat.Margin = new Padding(4, 5, 4, 5);
            nudDelayedRepeat.Maximum = 10D;
            nudDelayedRepeat.Minimum = 1D;
            nudDelayedRepeat.MinimumSize = new Size(1, 16);
            nudDelayedRepeat.Name = "nudDelayedRepeat";
            nudDelayedRepeat.Padding = new Padding(5);
            nudDelayedRepeat.RectColor = Color.FromArgb(65, 71, 84);
            nudDelayedRepeat.RectHoverColor = Color.BlueViolet;
            nudDelayedRepeat.RectPressColor = Color.Indigo;
            nudDelayedRepeat.ShowText = false;
            nudDelayedRepeat.Size = new Size(92, 25);
            nudDelayedRepeat.TabIndex = 8;
            nudDelayedRepeat.Text = "1";
            nudDelayedRepeat.TextAlignment = ContentAlignment.MiddleCenter;
            nudDelayedRepeat.Value = 1;
            // 
            // lblDelayedRepeatUnit
            // 
            lblDelayedRepeatUnit.AutoSize = true;
            lblDelayedRepeatUnit.BackColor = Color.Transparent;
            lblDelayedRepeatUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDelayedRepeatUnit.ForeColor = Color.FromArgb(180, 180, 180);
            lblDelayedRepeatUnit.Location = new Point(245, 165);
            lblDelayedRepeatUnit.Name = "lblDelayedRepeatUnit";
            lblDelayedRepeatUnit.Size = new Size(25, 13);
            lblDelayedRepeatUnit.TabIndex = 9;
            lblDelayedRepeatUnit.Text = "раз";
            // 
            // lblDelayedRepeat
            // 
            lblDelayedRepeat.AutoSize = true;
            lblDelayedRepeat.BackColor = Color.Transparent;
            lblDelayedRepeat.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDelayedRepeat.ForeColor = Color.FromArgb(180, 180, 180);
            lblDelayedRepeat.Location = new Point(16, 165);
            lblDelayedRepeat.Name = "lblDelayedRepeat";
            lblDelayedRepeat.Size = new Size(120, 13);
            lblDelayedRepeat.TabIndex = 7;
            lblDelayedRepeat.Text = "Повторять отправку:";
            // 
            // cmbDelayedPreDelayUnit
            // 
            cmbDelayedPreDelayUnit.DataSource = null;
            cmbDelayedPreDelayUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbDelayedPreDelayUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbDelayedPreDelayUnit.Font = new Font("Segoe UI", 9F);
            cmbDelayedPreDelayUnit.ForeColor = Color.White;
            cmbDelayedPreDelayUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbDelayedPreDelayUnit.ItemForeColor = Color.White;
            cmbDelayedPreDelayUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbDelayedPreDelayUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbDelayedPreDelayUnit.Items.AddRange(new object[] { "секунд", "минут", "часов" });
            cmbDelayedPreDelayUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbDelayedPreDelayUnit.ItemSelectForeColor = Color.White;
            cmbDelayedPreDelayUnit.Location = new Point(392, 125);
            cmbDelayedPreDelayUnit.Margin = new Padding(4, 5, 4, 5);
            cmbDelayedPreDelayUnit.MinimumSize = new Size(63, 0);
            cmbDelayedPreDelayUnit.Name = "cmbDelayedPreDelayUnit";
            cmbDelayedPreDelayUnit.Padding = new Padding(0, 0, 30, 2);
            cmbDelayedPreDelayUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbDelayedPreDelayUnit.Size = new Size(85, 25);
            cmbDelayedPreDelayUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbDelayedPreDelayUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbDelayedPreDelayUnit.SymbolSize = 24;
            cmbDelayedPreDelayUnit.TabIndex = 31;
            cmbDelayedPreDelayUnit.Text = "секунд";
            cmbDelayedPreDelayUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbDelayedPreDelayUnit.Watermark = "";
            // 
            // nudDelayedPreDelay
            // 
            nudDelayedPreDelay.FillColor = Color.FromArgb(42, 46, 57);
            nudDelayedPreDelay.Font = new Font("Segoe UI", 9.75F);
            nudDelayedPreDelay.ForeColor = Color.White;
            nudDelayedPreDelay.Location = new Point(300, 125);
            nudDelayedPreDelay.Margin = new Padding(4, 5, 4, 5);
            nudDelayedPreDelay.Maximum = 3600D;
            nudDelayedPreDelay.Minimum = 0D;
            nudDelayedPreDelay.MinimumSize = new Size(1, 16);
            nudDelayedPreDelay.Name = "nudDelayedPreDelay";
            nudDelayedPreDelay.Padding = new Padding(5);
            nudDelayedPreDelay.RectColor = Color.FromArgb(65, 71, 84);
            nudDelayedPreDelay.RectHoverColor = Color.BlueViolet;
            nudDelayedPreDelay.RectPressColor = Color.Indigo;
            nudDelayedPreDelay.ShowText = false;
            nudDelayedPreDelay.Size = new Size(86, 25);
            nudDelayedPreDelay.TabIndex = 9;
            nudDelayedPreDelay.Text = "1";
            nudDelayedPreDelay.TextAlignment = ContentAlignment.MiddleCenter;
            nudDelayedPreDelay.Value = 1;
            // 
            // lblDelayedPreDelay
            // 
            lblDelayedPreDelay.AutoSize = true;
            lblDelayedPreDelay.BackColor = Color.Transparent;
            lblDelayedPreDelay.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDelayedPreDelay.ForeColor = Color.FromArgb(180, 180, 180);
            lblDelayedPreDelay.Location = new Point(300, 105);
            lblDelayedPreDelay.Name = "lblDelayedPreDelay";
            lblDelayedPreDelay.Size = new Size(158, 13);
            lblDelayedPreDelay.TabIndex = 22;
            lblDelayedPreDelay.Text = "Задержка перед отправкой:";
            // 
            // dtpDelayedTime
            // 
            dtpDelayedTime.FillColor = Color.FromArgb(42, 46, 57);
            dtpDelayedTime.Font = new Font("Segoe UI", 9.75F);
            dtpDelayedTime.ForeColor = Color.White;
            dtpDelayedTime.Location = new Point(170, 125);
            dtpDelayedTime.Margin = new Padding(4, 5, 4, 5);
            dtpDelayedTime.MaxLength = 8;
            dtpDelayedTime.MinimumSize = new Size(63, 0);
            dtpDelayedTime.Name = "dtpDelayedTime";
            dtpDelayedTime.Padding = new Padding(0, 0, 30, 2);
            dtpDelayedTime.RectColor = Color.FromArgb(65, 71, 84);
            dtpDelayedTime.Size = new Size(120, 25);
            dtpDelayedTime.Style = Sunny.UI.UIStyle.Custom;
            dtpDelayedTime.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpDelayedTime.SymbolDropDown = 61555;
            dtpDelayedTime.SymbolNormal = 61555;
            dtpDelayedTime.SymbolSize = 24;
            dtpDelayedTime.TabIndex = 3;
            dtpDelayedTime.Text = "21:33:13";
            dtpDelayedTime.TextAlignment = ContentAlignment.MiddleLeft;
            dtpDelayedTime.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpDelayedTime.Value = new DateTime(2026, 9, 13, 21, 33, 13, 0);
            dtpDelayedTime.Watermark = "";
            // 
            // lblDelayedTime
            // 
            lblDelayedTime.AutoSize = true;
            lblDelayedTime.BackColor = Color.Transparent;
            lblDelayedTime.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDelayedTime.ForeColor = Color.FromArgb(180, 180, 180);
            lblDelayedTime.Location = new Point(170, 105);
            lblDelayedTime.Name = "lblDelayedTime";
            lblDelayedTime.Size = new Size(98, 13);
            lblDelayedTime.TabIndex = 2;
            lblDelayedTime.Text = "Время отправки:";
            // 
            // dtpDelayedDate
            // 
            dtpDelayedDate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpDelayedDate.FillColor = Color.FromArgb(42, 46, 57);
            dtpDelayedDate.Font = new Font("Segoe UI", 9.75F);
            dtpDelayedDate.ForeColor = Color.White;
            dtpDelayedDate.Location = new Point(16, 125);
            dtpDelayedDate.Margin = new Padding(4, 5, 4, 5);
            dtpDelayedDate.MaxLength = 10;
            dtpDelayedDate.MinimumSize = new Size(63, 0);
            dtpDelayedDate.Name = "dtpDelayedDate";
            dtpDelayedDate.Padding = new Padding(0, 0, 30, 2);
            dtpDelayedDate.RectColor = Color.FromArgb(65, 71, 84);
            dtpDelayedDate.Size = new Size(140, 25);
            dtpDelayedDate.Style = Sunny.UI.UIStyle.Custom;
            dtpDelayedDate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpDelayedDate.SymbolDropDown = 61555;
            dtpDelayedDate.SymbolNormal = 61555;
            dtpDelayedDate.SymbolSize = 24;
            dtpDelayedDate.TabIndex = 1;
            dtpDelayedDate.Text = "2026-09-13";
            dtpDelayedDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpDelayedDate.Value = new DateTime(2026, 9, 13, 0, 0, 0, 0);
            dtpDelayedDate.Watermark = "";
            // 
            // lblDelayedDate
            // 
            lblDelayedDate.AutoSize = true;
            lblDelayedDate.BackColor = Color.Transparent;
            lblDelayedDate.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblDelayedDate.ForeColor = Color.FromArgb(180, 180, 180);
            lblDelayedDate.Location = new Point(16, 105);
            lblDelayedDate.Name = "lblDelayedDate";
            lblDelayedDate.Size = new Size(89, 13);
            lblDelayedDate.TabIndex = 0;
            lblDelayedDate.Text = "Дата отправки:";
            // 
            // lblDelayedTemplateHint
            // 
            lblDelayedTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblDelayedTemplateHint.ForeColor = Color.DarkGray;
            lblDelayedTemplateHint.Location = new Point(16, 76);
            lblDelayedTemplateHint.Name = "lblDelayedTemplateHint";
            lblDelayedTemplateHint.Size = new Size(644, 20);
            lblDelayedTemplateHint.TabIndex = 21;
            lblDelayedTemplateHint.Text = "Нельзя использовать оба варианта, отправку выбирает пользователь.";
            // 
            // txtDelayedCustomText
            // 
            txtDelayedCustomText.ButtonFillColor = Color.Transparent;
            txtDelayedCustomText.ButtonStyleInherited = false;
            txtDelayedCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtDelayedCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDelayedCustomText.ForeColor = Color.White;
            txtDelayedCustomText.Location = new Point(16, 47);
            txtDelayedCustomText.Margin = new Padding(4, 5, 4, 5);
            txtDelayedCustomText.MinimumSize = new Size(1, 16);
            txtDelayedCustomText.Name = "txtDelayedCustomText";
            txtDelayedCustomText.Padding = new Padding(5);
            txtDelayedCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtDelayedCustomText.ShowText = false;
            txtDelayedCustomText.Size = new Size(490, 25);
            txtDelayedCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtDelayedCustomText.TabIndex = 20;
            txtDelayedCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtDelayedCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbDelayedTemplate
            // 
            cmbDelayedTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbDelayedTemplate.DataSource = null;
            cmbDelayedTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbDelayedTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbDelayedTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbDelayedTemplate.ForeColor = Color.White;
            cmbDelayedTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbDelayedTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbDelayedTemplate.Location = new Point(16, 16);
            cmbDelayedTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbDelayedTemplate.MinimumSize = new Size(63, 0);
            cmbDelayedTemplate.Name = "cmbDelayedTemplate";
            cmbDelayedTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbDelayedTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbDelayedTemplate.Size = new Size(490, 25);
            cmbDelayedTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbDelayedTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbDelayedTemplate.SymbolSize = 24;
            cmbDelayedTemplate.TabIndex = 19;
            cmbDelayedTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbDelayedTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // radUseTemplate
            // 
            radUseTemplate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radUseTemplate.ForeColor = Color.White;
            radUseTemplate.Location = new Point(520, 16);
            radUseTemplate.MinimumSize = new Size(1, 1);
            radUseTemplate.Name = "radUseTemplate";
            radUseTemplate.RadioButtonColor = Color.FromArgb(102, 58, 183);
            radUseTemplate.RadioButtonSize = 14;
            radUseTemplate.Size = new Size(140, 25);
            radUseTemplate.Style = Sunny.UI.UIStyle.Custom;
            radUseTemplate.TabIndex = 96;
            radUseTemplate.Text = "Отправить его";
            // 
            // radUseCustomText
            // 
            radUseCustomText.Checked = true;
            radUseCustomText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            radUseCustomText.ForeColor = Color.White;
            radUseCustomText.Location = new Point(520, 47);
            radUseCustomText.MinimumSize = new Size(1, 1);
            radUseCustomText.Name = "radUseCustomText";
            radUseCustomText.RadioButtonColor = Color.FromArgb(102, 58, 183);
            radUseCustomText.RadioButtonSize = 14;
            radUseCustomText.Size = new Size(140, 25);
            radUseCustomText.Style = Sunny.UI.UIStyle.Custom;
            radUseCustomText.TabIndex = 97;
            radUseCustomText.Text = "Отправить его";
            // 
            // DelayedTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpDelayed);
            Name = "DelayedTabControl";
            Size = new Size(696, 483);
            grpDelayed.ResumeLayout(false);
            pnlDelayedButtons.ResumeLayout(false);
            pnlDelayedInner.ResumeLayout(false);
            pnlDelayedContent.ResumeLayout(false);
            pnlDelayedContent.PerformLayout();
            grpDelayedHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpDelayed;
        private Sunny.UI.UIPanel pnlDelayedButtons;
        private Sunny.UI.UICheckBox chkDelayedManualConfirm;
        private Sunny.UI.UIButton btnSaveDelayed;
        private Sunny.UI.UIButton btnStartDelayed;
        private Panel pnlDelayedInner;
        private Panel pnlDelayedContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbDelayedTemplate;
        private Sunny.UI.UITextBox txtDelayedCustomText;
        private Label lblDelayedTemplateHint;

        // Date/Time Settings
        private Label lblDelayedDate;
        private Sunny.UI.UIDatePicker dtpDelayedDate;
        private Label lblDelayedTime;
        private Sunny.UI.UITimePicker dtpDelayedTime;
        private Label lblDelayedPreDelay;
        private Sunny.UI.UIIntegerUpDown nudDelayedPreDelay;
        private Sunny.UI.UIComboBox cmbDelayedPreDelayUnit;

        // Repeat Settings
        private Sunny.UI.UICheckBox chkDelayedOnce;
        private Label lblDelayedRepeat;
        private Sunny.UI.UIIntegerUpDown nudDelayedRepeat;
        private Label lblDelayedRepeatUnit;

        // Timezone
        private Label lblDelayedTimezone;
        private Sunny.UI.UIComboBox cmbDelayedTimezone;

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
        private Sunny.UI.UICheckBox chkHideSpoiler;
        private Sunny.UI.UICheckBox chkDeletePrevious;
        private Sunny.UI.UICheckBox chkOnlyIfAdmin;
        private Sunny.UI.UICheckBox chkIgnoreErrors;
        private Sunny.UI.UICheckBox chkAutoRestart;

        // Animated Elements
        private Sunny.UI.UICheckBox chkAnimatedEmoji;
        private Sunny.UI.UIComboBox cmbAnimatedEmoji;
        private Sunny.UI.UIComboBox cmbEmojiApplyTo;
        private Sunny.UI.UICheckBox chkAnimatedEffect;
        private Sunny.UI.UIComboBox cmbAnimatedEffect;
        private Sunny.UI.UIComboBox cmbEffectApplyTo;

        // History
        private Sunny.UI.UIGroupBox grpDelayedHistory;
        private FlowLayoutPanel flpDelayedHistory;

        // Radio Buttons
        private Sunny.UI.UIRadioButton radUseTemplate;
        private Sunny.UI.UIRadioButton radUseCustomText;
    }
}