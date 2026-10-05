namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class AutoTabControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoTabControl));
            grpAutomatic = new Sunny.UI.UIGroupBox();
            pnlAutoButtons = new Sunny.UI.UIPanel();
            chkAutoManualConfirm = new Sunny.UI.UICheckBox();
            btnSaveAutomatic = new Sunny.UI.UIButton();
            btnGoAutomatic = new Sunny.UI.UIButton();
            pnlAuto = new Panel();
            pnlAutoContent = new Panel();
            grpAutoHistory = new Sunny.UI.UIGroupBox();
            flpAutomaticHistory = new FlowLayoutPanel();
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
            chkProtectContent = new Sunny.UI.UICheckBox();
            chkPinMessage = new Sunny.UI.UICheckBox();
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
            chkAutoDaySun = new Sunny.UI.UICheckBox();
            chkAutoDaySat = new Sunny.UI.UICheckBox();
            chkAutoDayFri = new Sunny.UI.UICheckBox();
            chkAutoDayThu = new Sunny.UI.UICheckBox();
            chkAutoDayWed = new Sunny.UI.UICheckBox();
            chkAutoDayTue = new Sunny.UI.UICheckBox();
            chkAutoDayMon = new Sunny.UI.UICheckBox();
            lblAutoDays = new Label();
            chkAutoEndDate = new Sunny.UI.UICheckBox();
            dtpAutoStartDate = new Sunny.UI.UIDatePicker();
            lblAutoDateTo = new Label();
            dtpAutoEndDate = new Sunny.UI.UIDatePicker();
            chkAutoTimeLimit = new Sunny.UI.UICheckBox();
            dtpAutoTimeFrom = new Sunny.UI.UITimePicker();
            lblAutoTimeTo = new Label();
            dtpAutoTimeTo = new Sunny.UI.UITimePicker();
            chkRandomDelay = new Sunny.UI.UICheckBox();
            nudRandomDelayFrom = new Sunny.UI.UIIntegerUpDown();
            cmbRandomDelayFromUnit = new Sunny.UI.UIComboBox();
            lblRandomDelayTo = new Label();
            nudRandomDelayTo = new Sunny.UI.UIIntegerUpDown();
            cmbRandomDelayToUnit = new Sunny.UI.UIComboBox();
            lblAutoMaxMessages = new Label();
            nudAutoMaxMessages = new Sunny.UI.UIIntegerUpDown();
            lblAutoMaxHint = new Label();
            lblAutoPause = new Label();
            nudAutoPause = new Sunny.UI.UIIntegerUpDown();
            cmbAutoPauseUnit = new Sunny.UI.UIComboBox();
            lblAutoRetry = new Label();
            nudAutoRetry = new Sunny.UI.UIIntegerUpDown();
            lblAutoRetryUnit = new Label();
            lblAutoInterval = new Label();
            nudAutoInterval = new Sunny.UI.UIIntegerUpDown();
            cmbAutoIntervalUnit = new Sunny.UI.UIComboBox();
            lblManualTemplateHint = new Label();
            txtManualCustomText = new Sunny.UI.UITextBox();
            cmbAutoTemplate = new Sunny.UI.UIComboBox();
            picInfo1 = new PictureBox();
            picInfo2 = new PictureBox();
            picInfo3 = new PictureBox();
            grpAutomatic.SuspendLayout();
            pnlAutoButtons.SuspendLayout();
            pnlAuto.SuspendLayout();
            pnlAutoContent.SuspendLayout();
            grpAutoHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInfo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfo3).BeginInit();
            SuspendLayout();
            // 
            // grpAutomatic
            // 
            grpAutomatic.BackColor = Color.FromArgb(35, 39, 48);
            grpAutomatic.Controls.Add(pnlAutoButtons);
            grpAutomatic.Controls.Add(pnlAuto);
            grpAutomatic.Dock = DockStyle.Fill;
            grpAutomatic.FillColor = Color.Transparent;
            grpAutomatic.FillColor2 = Color.Transparent;
            grpAutomatic.FillDisableColor = Color.Transparent;
            grpAutomatic.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpAutomatic.ForeColor = Color.White;
            grpAutomatic.ForeDisableColor = Color.Transparent;
            grpAutomatic.Location = new Point(0, 0);
            grpAutomatic.Margin = new Padding(4, 5, 4, 5);
            grpAutomatic.MinimumSize = new Size(1, 1);
            grpAutomatic.Name = "grpAutomatic";
            grpAutomatic.Padding = new Padding(0, 32, 0, 0);
            grpAutomatic.Radius = 15;
            grpAutomatic.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpAutomatic.RectColor = Color.FromArgb(58, 58, 69);
            grpAutomatic.RectDisableColor = Color.Transparent;
            grpAutomatic.Size = new Size(696, 483);
            grpAutomatic.Style = Sunny.UI.UIStyle.Custom;
            grpAutomatic.TabIndex = 10;
            grpAutomatic.Text = "Настройки автоматической отправки";
            grpAutomatic.TextAlignment = ContentAlignment.MiddleLeft;
            grpAutomatic.TitleInterval = 8;
            grpAutomatic.TitleTop = 14;
            // 
            // pnlAutoButtons
            // 
            pnlAutoButtons.Controls.Add(chkAutoManualConfirm);
            pnlAutoButtons.Controls.Add(btnSaveAutomatic);
            pnlAutoButtons.Controls.Add(btnGoAutomatic);
            pnlAutoButtons.Dock = DockStyle.Bottom;
            pnlAutoButtons.FillColor = Color.Transparent;
            pnlAutoButtons.FillColor2 = Color.Transparent;
            pnlAutoButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlAutoButtons.ForeColor = Color.Transparent;
            pnlAutoButtons.ForeDisableColor = Color.Transparent;
            pnlAutoButtons.Location = new Point(0, 438);
            pnlAutoButtons.Margin = new Padding(4, 5, 4, 5);
            pnlAutoButtons.MinimumSize = new Size(1, 1);
            pnlAutoButtons.Name = "pnlAutoButtons";
            pnlAutoButtons.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            pnlAutoButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlAutoButtons.RectDisableColor = Color.Transparent;
            pnlAutoButtons.Size = new Size(696, 45);
            pnlAutoButtons.TabIndex = 18;
            pnlAutoButtons.Text = null;
            pnlAutoButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkAutoManualConfirm
            // 
            chkAutoManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkAutoManualConfirm.BackColor = Color.Transparent;
            chkAutoManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkAutoManualConfirm.Checked = true;
            chkAutoManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoManualConfirm.ForeColor = Color.White;
            chkAutoManualConfirm.Location = new Point(46, 10);
            chkAutoManualConfirm.MinimumSize = new Size(1, 1);
            chkAutoManualConfirm.Name = "chkAutoManualConfirm";
            chkAutoManualConfirm.Size = new Size(333, 25);
            chkAutoManualConfirm.TabIndex = 26;
            chkAutoManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSaveAutomatic
            // 
            btnSaveAutomatic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveAutomatic.FillColor = Color.BlueViolet;
            btnSaveAutomatic.FillColor2 = Color.Transparent;
            btnSaveAutomatic.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnSaveAutomatic.FillHoverColor = Color.DarkOrchid;
            btnSaveAutomatic.FillPressColor = Color.DarkViolet;
            btnSaveAutomatic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveAutomatic.Location = new Point(389, 5);
            btnSaveAutomatic.MinimumSize = new Size(1, 1);
            btnSaveAutomatic.Name = "btnSaveAutomatic";
            btnSaveAutomatic.Radius = 8;
            btnSaveAutomatic.RectColor = Color.Transparent;
            btnSaveAutomatic.Size = new Size(150, 35);
            btnSaveAutomatic.Style = Sunny.UI.UIStyle.Custom;
            btnSaveAutomatic.TabIndex = 13;
            btnSaveAutomatic.Text = "Сохранить настройки";
            btnSaveAutomatic.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnGoAutomatic
            // 
            btnGoAutomatic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGoAutomatic.FillColor = Color.Indigo;
            btnGoAutomatic.FillColor2 = Color.Transparent;
            btnGoAutomatic.FillDisableColor = Color.FromArgb(30, 33, 40);
            btnGoAutomatic.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnGoAutomatic.FillPressColor = Color.FromArgb(109, 40, 217);
            btnGoAutomatic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGoAutomatic.Location = new Point(543, 5);
            btnGoAutomatic.MinimumSize = new Size(1, 1);
            btnGoAutomatic.Name = "btnGoAutomatic";
            btnGoAutomatic.Radius = 8;
            btnGoAutomatic.RectColor = Color.Transparent;
            btnGoAutomatic.Size = new Size(150, 35);
            btnGoAutomatic.Style = Sunny.UI.UIStyle.Custom;
            btnGoAutomatic.TabIndex = 14;
            btnGoAutomatic.Text = "Начать сеанс";
            btnGoAutomatic.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlAuto
            // 
            pnlAuto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAuto.AutoScroll = true;
            pnlAuto.Controls.Add(pnlAutoContent);
            pnlAuto.Location = new Point(3, 25);
            pnlAuto.Name = "pnlAuto";
            pnlAuto.Size = new Size(693, 413);
            pnlAuto.TabIndex = 20;
            // 
            // pnlAutoContent
            // 
            pnlAutoContent.AutoScroll = true;
            pnlAutoContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlAutoContent.Controls.Add(grpAutoHistory);
            pnlAutoContent.Controls.Add(chkAnimatedEffect);
            pnlAutoContent.Controls.Add(cmbAnimatedEffect);
            pnlAutoContent.Controls.Add(cmbEffectApplyTo);
            pnlAutoContent.Controls.Add(chkAnimatedEmoji);
            pnlAutoContent.Controls.Add(cmbAnimatedEmoji);
            pnlAutoContent.Controls.Add(cmbEmojiApplyTo);
            pnlAutoContent.Controls.Add(chkAutoRestart);
            pnlAutoContent.Controls.Add(chkIgnoreErrors);
            pnlAutoContent.Controls.Add(chkOnlyIfAdmin);
            pnlAutoContent.Controls.Add(chkDeletePrevious);
            pnlAutoContent.Controls.Add(chkHideSpoiler);
            pnlAutoContent.Controls.Add(chkProtectContent);
            pnlAutoContent.Controls.Add(chkPinMessage);
            pnlAutoContent.Controls.Add(chkSilentSend);
            pnlAutoContent.Controls.Add(chkNoAuthorMention);
            pnlAutoContent.Controls.Add(chkDisablePreview);
            pnlAutoContent.Controls.Add(chkSendTemplateFirst);
            pnlAutoContent.Controls.Add(chkNotifyError);
            pnlAutoContent.Controls.Add(cmbNotifyError1);
            pnlAutoContent.Controls.Add(lblNotifyErrorOr);
            pnlAutoContent.Controls.Add(cmbNotifyError2);
            pnlAutoContent.Controls.Add(chkNotifyComplete);
            pnlAutoContent.Controls.Add(cmbNotifyComplete1);
            pnlAutoContent.Controls.Add(lblNotifyCompleteOr);
            pnlAutoContent.Controls.Add(cmbNotifyComplete2);
            pnlAutoContent.Controls.Add(chkNotifySuccess);
            pnlAutoContent.Controls.Add(cmbNotifySuccess1);
            pnlAutoContent.Controls.Add(lblNotifySuccessOr);
            pnlAutoContent.Controls.Add(cmbNotifySuccess2);
            pnlAutoContent.Controls.Add(chkAutoDaySun);
            pnlAutoContent.Controls.Add(chkAutoDaySat);
            pnlAutoContent.Controls.Add(chkAutoDayFri);
            pnlAutoContent.Controls.Add(chkAutoDayThu);
            pnlAutoContent.Controls.Add(chkAutoDayWed);
            pnlAutoContent.Controls.Add(chkAutoDayTue);
            pnlAutoContent.Controls.Add(chkAutoDayMon);
            pnlAutoContent.Controls.Add(lblAutoDays);
            pnlAutoContent.Controls.Add(chkAutoEndDate);
            pnlAutoContent.Controls.Add(dtpAutoStartDate);
            pnlAutoContent.Controls.Add(lblAutoDateTo);
            pnlAutoContent.Controls.Add(dtpAutoEndDate);
            pnlAutoContent.Controls.Add(chkAutoTimeLimit);
            pnlAutoContent.Controls.Add(dtpAutoTimeFrom);
            pnlAutoContent.Controls.Add(lblAutoTimeTo);
            pnlAutoContent.Controls.Add(dtpAutoTimeTo);
            pnlAutoContent.Controls.Add(chkRandomDelay);
            pnlAutoContent.Controls.Add(nudRandomDelayFrom);
            pnlAutoContent.Controls.Add(cmbRandomDelayFromUnit);
            pnlAutoContent.Controls.Add(lblRandomDelayTo);
            pnlAutoContent.Controls.Add(nudRandomDelayTo);
            pnlAutoContent.Controls.Add(cmbRandomDelayToUnit);
            pnlAutoContent.Controls.Add(lblAutoMaxMessages);
            pnlAutoContent.Controls.Add(nudAutoMaxMessages);
            pnlAutoContent.Controls.Add(lblAutoMaxHint);
            pnlAutoContent.Controls.Add(lblAutoPause);
            pnlAutoContent.Controls.Add(nudAutoPause);
            pnlAutoContent.Controls.Add(cmbAutoPauseUnit);
            pnlAutoContent.Controls.Add(lblAutoRetry);
            pnlAutoContent.Controls.Add(nudAutoRetry);
            pnlAutoContent.Controls.Add(lblAutoRetryUnit);
            pnlAutoContent.Controls.Add(lblAutoInterval);
            pnlAutoContent.Controls.Add(nudAutoInterval);
            pnlAutoContent.Controls.Add(cmbAutoIntervalUnit);
            pnlAutoContent.Controls.Add(lblManualTemplateHint);
            pnlAutoContent.Controls.Add(txtManualCustomText);
            pnlAutoContent.Controls.Add(cmbAutoTemplate);
            pnlAutoContent.Location = new Point(0, -1);
            pnlAutoContent.MinimumSize = new Size(673, 0);
            pnlAutoContent.Name = "pnlAutoContent";
            pnlAutoContent.Padding = new Padding(16, 0, 16, 0);
            pnlAutoContent.Size = new Size(676, 1335);
            pnlAutoContent.TabIndex = 19;
            // 
            // grpAutoHistory
            // 
            grpAutoHistory.Controls.Add(flpAutomaticHistory);
            grpAutoHistory.FillColor = Color.Transparent;
            grpAutoHistory.FillColor2 = Color.Transparent;
            grpAutoHistory.FillDisableColor = Color.Transparent;
            grpAutoHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAutoHistory.ForeColor = SystemColors.ActiveBorder;
            grpAutoHistory.ForeDisableColor = Color.Transparent;
            grpAutoHistory.Location = new Point(9, 832);
            grpAutoHistory.Margin = new Padding(4, 5, 4, 5);
            grpAutoHistory.MinimumSize = new Size(1, 1);
            grpAutoHistory.Name = "grpAutoHistory";
            grpAutoHistory.Padding = new Padding(5, 32, 5, 5);
            grpAutoHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpAutoHistory.RectDisableColor = Color.Transparent;
            grpAutoHistory.Size = new Size(644, 290);
            grpAutoHistory.TabIndex = 0;
            grpAutoHistory.Text = "История отправок:";
            grpAutoHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpAutoHistory.TitleTop = 10;
            // 
            // flpAutomaticHistory
            // 
            flpAutomaticHistory.AutoScroll = true;
            flpAutomaticHistory.FlowDirection = FlowDirection.TopDown;
            flpAutomaticHistory.Location = new Point(10, 20);
            flpAutomaticHistory.Name = "flpAutomaticHistory";
            flpAutomaticHistory.Size = new Size(622, 259);
            flpAutomaticHistory.TabIndex = 10;
            flpAutomaticHistory.WrapContents = false;
            // 
            // chkAnimatedEffect
            // 
            chkAnimatedEffect.BackColor = Color.Transparent;
            chkAnimatedEffect.CheckBoxColor = Color.BlueViolet;
            chkAnimatedEffect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAnimatedEffect.ForeColor = Color.White;
            chkAnimatedEffect.Location = new Point(9, 792);
            chkAnimatedEffect.MinimumSize = new Size(1, 1);
            chkAnimatedEffect.Name = "chkAnimatedEffect";
            chkAnimatedEffect.Size = new Size(239, 25);
            chkAnimatedEffect.TabIndex = 70;
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
            cmbAnimatedEffect.Location = new Point(258, 792);
            cmbAnimatedEffect.Margin = new Padding(4, 5, 4, 5);
            cmbAnimatedEffect.MinimumSize = new Size(63, 0);
            cmbAnimatedEffect.Name = "cmbAnimatedEffect";
            cmbAnimatedEffect.Padding = new Padding(0, 0, 30, 2);
            cmbAnimatedEffect.RectColor = Color.FromArgb(65, 71, 84);
            cmbAnimatedEffect.Size = new Size(151, 25);
            cmbAnimatedEffect.Style = Sunny.UI.UIStyle.Custom;
            cmbAnimatedEffect.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAnimatedEffect.SymbolSize = 24;
            cmbAnimatedEffect.TabIndex = 61;
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
            cmbEffectApplyTo.Location = new Point(419, 792);
            cmbEffectApplyTo.Margin = new Padding(4, 5, 4, 5);
            cmbEffectApplyTo.MinimumSize = new Size(63, 0);
            cmbEffectApplyTo.Name = "cmbEffectApplyTo";
            cmbEffectApplyTo.Padding = new Padding(0, 0, 30, 2);
            cmbEffectApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            cmbEffectApplyTo.Size = new Size(151, 25);
            cmbEffectApplyTo.Style = Sunny.UI.UIStyle.Custom;
            cmbEffectApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEffectApplyTo.SymbolSize = 24;
            cmbEffectApplyTo.TabIndex = 73;
            cmbEffectApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEffectApplyTo.Watermark = "Применить на";
            // 
            // chkAnimatedEmoji
            // 
            chkAnimatedEmoji.BackColor = Color.Transparent;
            chkAnimatedEmoji.CheckBoxColor = Color.BlueViolet;
            chkAnimatedEmoji.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAnimatedEmoji.ForeColor = Color.White;
            chkAnimatedEmoji.Location = new Point(9, 762);
            chkAnimatedEmoji.MinimumSize = new Size(1, 1);
            chkAnimatedEmoji.Name = "chkAnimatedEmoji";
            chkAnimatedEmoji.Size = new Size(239, 25);
            chkAnimatedEmoji.TabIndex = 69;
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
            cmbAnimatedEmoji.Location = new Point(258, 762);
            cmbAnimatedEmoji.Margin = new Padding(4, 5, 4, 5);
            cmbAnimatedEmoji.MinimumSize = new Size(63, 0);
            cmbAnimatedEmoji.Name = "cmbAnimatedEmoji";
            cmbAnimatedEmoji.Padding = new Padding(0, 0, 30, 2);
            cmbAnimatedEmoji.RectColor = Color.FromArgb(65, 71, 84);
            cmbAnimatedEmoji.Size = new Size(151, 25);
            cmbAnimatedEmoji.Style = Sunny.UI.UIStyle.Custom;
            cmbAnimatedEmoji.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAnimatedEmoji.SymbolSize = 24;
            cmbAnimatedEmoji.TabIndex = 60;
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
            cmbEmojiApplyTo.Location = new Point(419, 762);
            cmbEmojiApplyTo.Margin = new Padding(4, 5, 4, 5);
            cmbEmojiApplyTo.MinimumSize = new Size(63, 0);
            cmbEmojiApplyTo.Name = "cmbEmojiApplyTo";
            cmbEmojiApplyTo.Padding = new Padding(0, 0, 30, 2);
            cmbEmojiApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            cmbEmojiApplyTo.Size = new Size(151, 25);
            cmbEmojiApplyTo.Style = Sunny.UI.UIStyle.Custom;
            cmbEmojiApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEmojiApplyTo.SymbolSize = 24;
            cmbEmojiApplyTo.TabIndex = 74;
            cmbEmojiApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEmojiApplyTo.Watermark = "Применить на";
            // 
            // chkAutoRestart
            // 
            chkAutoRestart.BackColor = Color.Transparent;
            chkAutoRestart.CheckBoxColor = Color.BlueViolet;
            chkAutoRestart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoRestart.ForeColor = Color.White;
            chkAutoRestart.Location = new Point(9, 722);
            chkAutoRestart.MinimumSize = new Size(1, 1);
            chkAutoRestart.Name = "chkAutoRestart";
            chkAutoRestart.Size = new Size(300, 25);
            chkAutoRestart.TabIndex = 46;
            chkAutoRestart.Text = "Автоматически перезапускать после сбоя бота";
            // 
            // chkIgnoreErrors
            // 
            chkIgnoreErrors.BackColor = Color.Transparent;
            chkIgnoreErrors.CheckBoxColor = Color.BlueViolet;
            chkIgnoreErrors.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkIgnoreErrors.ForeColor = Color.White;
            chkIgnoreErrors.Location = new Point(9, 692);
            chkIgnoreErrors.MinimumSize = new Size(1, 1);
            chkIgnoreErrors.Name = "chkIgnoreErrors";
            chkIgnoreErrors.Size = new Size(300, 25);
            chkIgnoreErrors.TabIndex = 92;
            chkIgnoreErrors.Text = "Игнорировать ошибки и продолжать сессию";
            // 
            // chkOnlyIfAdmin
            // 
            chkOnlyIfAdmin.BackColor = Color.Transparent;
            chkOnlyIfAdmin.CheckBoxColor = Color.BlueViolet;
            chkOnlyIfAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkOnlyIfAdmin.ForeColor = Color.White;
            chkOnlyIfAdmin.Location = new Point(9, 662);
            chkOnlyIfAdmin.MinimumSize = new Size(1, 1);
            chkOnlyIfAdmin.Name = "chkOnlyIfAdmin";
            chkOnlyIfAdmin.Size = new Size(300, 25);
            chkOnlyIfAdmin.TabIndex = 91;
            chkOnlyIfAdmin.Text = "Отправлять только если бот администратор";
            // 
            // chkDeletePrevious
            // 
            chkDeletePrevious.BackColor = Color.Transparent;
            chkDeletePrevious.CheckBoxColor = Color.BlueViolet;
            chkDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDeletePrevious.ForeColor = Color.White;
            chkDeletePrevious.Location = new Point(279, 632);
            chkDeletePrevious.MinimumSize = new Size(1, 1);
            chkDeletePrevious.Name = "chkDeletePrevious";
            chkDeletePrevious.Size = new Size(346, 25);
            chkDeletePrevious.TabIndex = 68;
            chkDeletePrevious.Text = "Удалить предыдущее сообщение бота перед отправкой";
            // 
            // chkHideSpoiler
            // 
            chkHideSpoiler.BackColor = Color.Transparent;
            chkHideSpoiler.CheckBoxColor = Color.BlueViolet;
            chkHideSpoiler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkHideSpoiler.ForeColor = Color.White;
            chkHideSpoiler.Location = new Point(9, 632);
            chkHideSpoiler.MinimumSize = new Size(1, 1);
            chkHideSpoiler.Name = "chkHideSpoiler";
            chkHideSpoiler.Size = new Size(264, 25);
            chkHideSpoiler.TabIndex = 67;
            chkHideSpoiler.Text = "Скрыть содержимое как спойлер";
            // 
            // chkProtectContent
            // 
            chkProtectContent.BackColor = Color.Transparent;
            chkProtectContent.CheckBoxColor = Color.BlueViolet;
            chkProtectContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkProtectContent.ForeColor = Color.White;
            chkProtectContent.Location = new Point(279, 602);
            chkProtectContent.MinimumSize = new Size(1, 1);
            chkProtectContent.Name = "chkProtectContent";
            chkProtectContent.Size = new Size(346, 25);
            chkProtectContent.TabIndex = 65;
            chkProtectContent.Text = "Защитить от копирования и пересылки";
            // 
            // chkPinMessage
            // 
            chkPinMessage.BackColor = Color.Transparent;
            chkPinMessage.CheckBoxColor = Color.BlueViolet;
            chkPinMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkPinMessage.ForeColor = Color.White;
            chkPinMessage.Location = new Point(9, 602);
            chkPinMessage.MinimumSize = new Size(1, 1);
            chkPinMessage.Name = "chkPinMessage";
            chkPinMessage.Size = new Size(264, 25);
            chkPinMessage.TabIndex = 66;
            chkPinMessage.Text = "Закрепить сообщение\\шаблон";
            // 
            // chkSilentSend
            // 
            chkSilentSend.BackColor = Color.Transparent;
            chkSilentSend.CheckBoxColor = Color.BlueViolet;
            chkSilentSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSilentSend.ForeColor = Color.White;
            chkSilentSend.Location = new Point(9, 572);
            chkSilentSend.MinimumSize = new Size(1, 1);
            chkSilentSend.Name = "chkSilentSend";
            chkSilentSend.Size = new Size(264, 25);
            chkSilentSend.TabIndex = 63;
            chkSilentSend.Text = "Тихая отправка (без звука)";
            // 
            // chkNoAuthorMention
            // 
            chkNoAuthorMention.BackColor = Color.Transparent;
            chkNoAuthorMention.CheckBoxColor = Color.BlueViolet;
            chkNoAuthorMention.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNoAuthorMention.ForeColor = Color.White;
            chkNoAuthorMention.Location = new Point(279, 572);
            chkNoAuthorMention.MinimumSize = new Size(1, 1);
            chkNoAuthorMention.Name = "chkNoAuthorMention";
            chkNoAuthorMention.Size = new Size(346, 25);
            chkNoAuthorMention.TabIndex = 64;
            chkNoAuthorMention.Text = "Отправить без упоминания автора (как своё)";
            // 
            // chkDisablePreview
            // 
            chkDisablePreview.BackColor = Color.Transparent;
            chkDisablePreview.CheckBoxColor = Color.BlueViolet;
            chkDisablePreview.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkDisablePreview.ForeColor = Color.White;
            chkDisablePreview.Location = new Point(279, 542);
            chkDisablePreview.MinimumSize = new Size(1, 1);
            chkDisablePreview.Name = "chkDisablePreview";
            chkDisablePreview.Size = new Size(346, 25);
            chkDisablePreview.TabIndex = 62;
            chkDisablePreview.Text = "Отключить предпросмотр ссылок";
            // 
            // chkSendTemplateFirst
            // 
            chkSendTemplateFirst.BackColor = Color.Transparent;
            chkSendTemplateFirst.CheckBoxColor = Color.BlueViolet;
            chkSendTemplateFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkSendTemplateFirst.ForeColor = Color.White;
            chkSendTemplateFirst.Location = new Point(9, 542);
            chkSendTemplateFirst.MinimumSize = new Size(1, 1);
            chkSendTemplateFirst.Name = "chkSendTemplateFirst";
            chkSendTemplateFirst.Size = new Size(264, 25);
            chkSendTemplateFirst.TabIndex = 61;
            chkSendTemplateFirst.Text = "Отправить первым шаблон";
            // 
            // chkNotifyError
            // 
            chkNotifyError.BackColor = Color.Transparent;
            chkNotifyError.CheckBoxColor = Color.BlueViolet;
            chkNotifyError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkNotifyError.ForeColor = Color.White;
            chkNotifyError.Location = new Point(9, 503);
            chkNotifyError.MinimumSize = new Size(1, 1);
            chkNotifyError.Name = "chkNotifyError";
            chkNotifyError.Size = new Size(265, 25);
            chkNotifyError.TabIndex = 87;
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
            cmbNotifyError1.Location = new Point(283, 503);
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
            lblNotifyErrorOr.Location = new Point(435, 508);
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
            cmbNotifyError2.Location = new Point(482, 503);
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
            chkNotifyComplete.Location = new Point(9, 473);
            chkNotifyComplete.MinimumSize = new Size(1, 1);
            chkNotifyComplete.Name = "chkNotifyComplete";
            chkNotifyComplete.Size = new Size(265, 25);
            chkNotifyComplete.TabIndex = 80;
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
            cmbNotifyComplete1.Location = new Point(283, 473);
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
            lblNotifyCompleteOr.Location = new Point(436, 478);
            lblNotifyCompleteOr.Name = "lblNotifyCompleteOr";
            lblNotifyCompleteOr.Size = new Size(39, 13);
            lblNotifyCompleteOr.TabIndex = 89;
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
            cmbNotifyComplete2.Location = new Point(482, 473);
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
            chkNotifySuccess.Location = new Point(9, 443);
            chkNotifySuccess.MinimumSize = new Size(1, 1);
            chkNotifySuccess.Name = "chkNotifySuccess";
            chkNotifySuccess.Size = new Size(265, 25);
            chkNotifySuccess.TabIndex = 79;
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
            cmbNotifySuccess1.Location = new Point(283, 443);
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
            lblNotifySuccessOr.Location = new Point(435, 448);
            lblNotifySuccessOr.Name = "lblNotifySuccessOr";
            lblNotifySuccessOr.Size = new Size(39, 13);
            lblNotifySuccessOr.TabIndex = 88;
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
            cmbNotifySuccess2.Location = new Point(482, 443);
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
            // chkAutoDaySun
            // 
            chkAutoDaySun.BackColor = Color.Transparent;
            chkAutoDaySun.CheckBoxColor = Color.BlueViolet;
            chkAutoDaySun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDaySun.ForeColor = Color.White;
            chkAutoDaySun.Location = new Point(453, 398);
            chkAutoDaySun.MinimumSize = new Size(1, 1);
            chkAutoDaySun.Name = "chkAutoDaySun";
            chkAutoDaySun.Size = new Size(50, 25);
            chkAutoDaySun.TabIndex = 42;
            chkAutoDaySun.Text = "Вс";
            // 
            // chkAutoDaySat
            // 
            chkAutoDaySat.BackColor = Color.Transparent;
            chkAutoDaySat.CheckBoxColor = Color.BlueViolet;
            chkAutoDaySat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDaySat.ForeColor = Color.White;
            chkAutoDaySat.Location = new Point(398, 398);
            chkAutoDaySat.MinimumSize = new Size(1, 1);
            chkAutoDaySat.Name = "chkAutoDaySat";
            chkAutoDaySat.Size = new Size(50, 25);
            chkAutoDaySat.TabIndex = 41;
            chkAutoDaySat.Text = "Сб";
            // 
            // chkAutoDayFri
            // 
            chkAutoDayFri.BackColor = Color.Transparent;
            chkAutoDayFri.CheckBoxColor = Color.BlueViolet;
            chkAutoDayFri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDayFri.ForeColor = Color.White;
            chkAutoDayFri.Location = new Point(343, 398);
            chkAutoDayFri.MinimumSize = new Size(1, 1);
            chkAutoDayFri.Name = "chkAutoDayFri";
            chkAutoDayFri.Size = new Size(50, 25);
            chkAutoDayFri.TabIndex = 40;
            chkAutoDayFri.Text = "Пт";
            // 
            // chkAutoDayThu
            // 
            chkAutoDayThu.BackColor = Color.Transparent;
            chkAutoDayThu.CheckBoxColor = Color.BlueViolet;
            chkAutoDayThu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDayThu.ForeColor = Color.White;
            chkAutoDayThu.Location = new Point(288, 398);
            chkAutoDayThu.MinimumSize = new Size(1, 1);
            chkAutoDayThu.Name = "chkAutoDayThu";
            chkAutoDayThu.Size = new Size(50, 25);
            chkAutoDayThu.TabIndex = 39;
            chkAutoDayThu.Text = "Чт";
            // 
            // chkAutoDayWed
            // 
            chkAutoDayWed.BackColor = Color.Transparent;
            chkAutoDayWed.CheckBoxColor = Color.BlueViolet;
            chkAutoDayWed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDayWed.ForeColor = Color.White;
            chkAutoDayWed.Location = new Point(233, 398);
            chkAutoDayWed.MinimumSize = new Size(1, 1);
            chkAutoDayWed.Name = "chkAutoDayWed";
            chkAutoDayWed.Size = new Size(50, 25);
            chkAutoDayWed.TabIndex = 38;
            chkAutoDayWed.Text = "Ср";
            // 
            // chkAutoDayTue
            // 
            chkAutoDayTue.BackColor = Color.Transparent;
            chkAutoDayTue.CheckBoxColor = Color.BlueViolet;
            chkAutoDayTue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDayTue.ForeColor = Color.White;
            chkAutoDayTue.Location = new Point(178, 398);
            chkAutoDayTue.MinimumSize = new Size(1, 1);
            chkAutoDayTue.Name = "chkAutoDayTue";
            chkAutoDayTue.Size = new Size(50, 25);
            chkAutoDayTue.TabIndex = 37;
            chkAutoDayTue.Text = "Вт";
            // 
            // chkAutoDayMon
            // 
            chkAutoDayMon.BackColor = Color.Transparent;
            chkAutoDayMon.CheckBoxColor = Color.BlueViolet;
            chkAutoDayMon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoDayMon.ForeColor = Color.White;
            chkAutoDayMon.Location = new Point(123, 398);
            chkAutoDayMon.MinimumSize = new Size(1, 1);
            chkAutoDayMon.Name = "chkAutoDayMon";
            chkAutoDayMon.Size = new Size(50, 25);
            chkAutoDayMon.TabIndex = 36;
            chkAutoDayMon.Text = "Пн";
            // 
            // lblAutoDays
            // 
            lblAutoDays.AutoSize = true;
            lblAutoDays.BackColor = Color.Transparent;
            lblAutoDays.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoDays.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoDays.Location = new Point(9, 403);
            lblAutoDays.Name = "lblAutoDays";
            lblAutoDays.Size = new Size(102, 13);
            lblAutoDays.TabIndex = 35;
            lblAutoDays.Text = "Неделя отправки:";
            // 
            // chkAutoEndDate
            // 
            chkAutoEndDate.BackColor = Color.Transparent;
            chkAutoEndDate.CheckBoxColor = Color.BlueViolet;
            chkAutoEndDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoEndDate.ForeColor = Color.White;
            chkAutoEndDate.Location = new Point(9, 353);
            chkAutoEndDate.MinimumSize = new Size(1, 1);
            chkAutoEndDate.Name = "chkAutoEndDate";
            chkAutoEndDate.Size = new Size(203, 25);
            chkAutoEndDate.TabIndex = 47;
            chkAutoEndDate.Text = "Ограничить датой отправки с:";
            // 
            // dtpAutoStartDate
            // 
            dtpAutoStartDate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpAutoStartDate.DateFormat = "dd.MM.yyyy";
            dtpAutoStartDate.FillColor = Color.FromArgb(42, 46, 57);
            dtpAutoStartDate.Font = new Font("Segoe UI", 9.75F);
            dtpAutoStartDate.ForeColor = Color.White;
            dtpAutoStartDate.Location = new Point(221, 353);
            dtpAutoStartDate.Margin = new Padding(4, 5, 4, 5);
            dtpAutoStartDate.MaxLength = 10;
            dtpAutoStartDate.MinimumSize = new Size(63, 0);
            dtpAutoStartDate.Name = "dtpAutoStartDate";
            dtpAutoStartDate.Padding = new Padding(0, 0, 30, 2);
            dtpAutoStartDate.RectColor = Color.FromArgb(65, 71, 84);
            dtpAutoStartDate.Size = new Size(100, 25);
            dtpAutoStartDate.Style = Sunny.UI.UIStyle.Custom;
            dtpAutoStartDate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpAutoStartDate.SymbolDropDown = 61555;
            dtpAutoStartDate.SymbolNormal = 61555;
            dtpAutoStartDate.SymbolSize = 24;
            dtpAutoStartDate.TabIndex = 33;
            dtpAutoStartDate.Text = "01.10.2026";
            dtpAutoStartDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpAutoStartDate.Value = new DateTime(2026, 10, 1, 0, 0, 0, 0);
            dtpAutoStartDate.Watermark = "";
            // 
            // lblAutoDateTo
            // 
            lblAutoDateTo.AutoSize = true;
            lblAutoDateTo.BackColor = Color.Transparent;
            lblAutoDateTo.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoDateTo.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoDateTo.Location = new Point(328, 358);
            lblAutoDateTo.Name = "lblAutoDateTo";
            lblAutoDateTo.Size = new Size(20, 13);
            lblAutoDateTo.TabIndex = 99;
            lblAutoDateTo.Text = "до";
            // 
            // dtpAutoEndDate
            // 
            dtpAutoEndDate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpAutoEndDate.DateFormat = "dd.MM.yyyy";
            dtpAutoEndDate.FillColor = Color.FromArgb(42, 46, 57);
            dtpAutoEndDate.Font = new Font("Segoe UI", 9.75F);
            dtpAutoEndDate.ForeColor = Color.White;
            dtpAutoEndDate.Location = new Point(357, 353);
            dtpAutoEndDate.Margin = new Padding(4, 5, 4, 5);
            dtpAutoEndDate.MaxLength = 10;
            dtpAutoEndDate.MinimumSize = new Size(63, 0);
            dtpAutoEndDate.Name = "dtpAutoEndDate";
            dtpAutoEndDate.Padding = new Padding(0, 0, 30, 2);
            dtpAutoEndDate.RectColor = Color.FromArgb(65, 71, 84);
            dtpAutoEndDate.Size = new Size(100, 25);
            dtpAutoEndDate.Style = Sunny.UI.UIStyle.Custom;
            dtpAutoEndDate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpAutoEndDate.SymbolDropDown = 61555;
            dtpAutoEndDate.SymbolNormal = 61555;
            dtpAutoEndDate.SymbolSize = 24;
            dtpAutoEndDate.TabIndex = 34;
            dtpAutoEndDate.Text = "31.10.2026";
            dtpAutoEndDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpAutoEndDate.Value = new DateTime(2026, 10, 31, 0, 0, 0, 0);
            dtpAutoEndDate.Watermark = "";
            // 
            // chkAutoTimeLimit
            // 
            chkAutoTimeLimit.BackColor = Color.Transparent;
            chkAutoTimeLimit.CheckBoxColor = Color.BlueViolet;
            chkAutoTimeLimit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkAutoTimeLimit.ForeColor = Color.White;
            chkAutoTimeLimit.Location = new Point(9, 313);
            chkAutoTimeLimit.MinimumSize = new Size(1, 1);
            chkAutoTimeLimit.Name = "chkAutoTimeLimit";
            chkAutoTimeLimit.Size = new Size(203, 25);
            chkAutoTimeLimit.TabIndex = 30;
            chkAutoTimeLimit.Text = "Ограничить время отправки c:";
            // 
            // dtpAutoTimeFrom
            // 
            dtpAutoTimeFrom.FillColor = Color.FromArgb(42, 46, 57);
            dtpAutoTimeFrom.Font = new Font("Segoe UI", 9.75F);
            dtpAutoTimeFrom.ForeColor = Color.White;
            dtpAutoTimeFrom.Location = new Point(221, 313);
            dtpAutoTimeFrom.Margin = new Padding(4, 5, 4, 5);
            dtpAutoTimeFrom.MaxLength = 8;
            dtpAutoTimeFrom.MinimumSize = new Size(63, 0);
            dtpAutoTimeFrom.Name = "dtpAutoTimeFrom";
            dtpAutoTimeFrom.Padding = new Padding(0, 0, 30, 2);
            dtpAutoTimeFrom.RectColor = Color.FromArgb(65, 71, 84);
            dtpAutoTimeFrom.Size = new Size(100, 25);
            dtpAutoTimeFrom.Style = Sunny.UI.UIStyle.Custom;
            dtpAutoTimeFrom.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpAutoTimeFrom.SymbolDropDown = 61555;
            dtpAutoTimeFrom.SymbolNormal = 61555;
            dtpAutoTimeFrom.SymbolSize = 24;
            dtpAutoTimeFrom.TabIndex = 48;
            dtpAutoTimeFrom.Text = "08:00:00";
            dtpAutoTimeFrom.TextAlignment = ContentAlignment.MiddleLeft;
            dtpAutoTimeFrom.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpAutoTimeFrom.Value = new DateTime(2026, 9, 25, 8, 0, 0, 0);
            dtpAutoTimeFrom.Watermark = "";
            // 
            // lblAutoTimeTo
            // 
            lblAutoTimeTo.AutoSize = true;
            lblAutoTimeTo.BackColor = Color.Transparent;
            lblAutoTimeTo.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoTimeTo.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoTimeTo.Location = new Point(328, 318);
            lblAutoTimeTo.Name = "lblAutoTimeTo";
            lblAutoTimeTo.Size = new Size(20, 13);
            lblAutoTimeTo.TabIndex = 34;
            lblAutoTimeTo.Text = "до";
            // 
            // dtpAutoTimeTo
            // 
            dtpAutoTimeTo.FillColor = Color.FromArgb(42, 46, 57);
            dtpAutoTimeTo.Font = new Font("Segoe UI", 9.75F);
            dtpAutoTimeTo.ForeColor = Color.White;
            dtpAutoTimeTo.Location = new Point(357, 313);
            dtpAutoTimeTo.Margin = new Padding(4, 5, 4, 5);
            dtpAutoTimeTo.MaxLength = 8;
            dtpAutoTimeTo.MinimumSize = new Size(63, 0);
            dtpAutoTimeTo.Name = "dtpAutoTimeTo";
            dtpAutoTimeTo.Padding = new Padding(0, 0, 30, 2);
            dtpAutoTimeTo.RectColor = Color.FromArgb(65, 71, 84);
            dtpAutoTimeTo.Size = new Size(100, 25);
            dtpAutoTimeTo.Style = Sunny.UI.UIStyle.Custom;
            dtpAutoTimeTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            dtpAutoTimeTo.SymbolDropDown = 61555;
            dtpAutoTimeTo.SymbolNormal = 61555;
            dtpAutoTimeTo.SymbolSize = 24;
            dtpAutoTimeTo.TabIndex = 49;
            dtpAutoTimeTo.Text = "23:00:00";
            dtpAutoTimeTo.TextAlignment = ContentAlignment.MiddleLeft;
            dtpAutoTimeTo.TimeCultureInfo = new System.Globalization.CultureInfo("ru-RU");
            dtpAutoTimeTo.Value = new DateTime(2026, 9, 25, 23, 0, 0, 0);
            dtpAutoTimeTo.Watermark = "";
            // 
            // chkRandomDelay
            // 
            chkRandomDelay.BackColor = Color.Transparent;
            chkRandomDelay.CheckBoxColor = Color.BlueViolet;
            chkRandomDelay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkRandomDelay.ForeColor = Color.White;
            chkRandomDelay.Location = new Point(9, 273);
            chkRandomDelay.MinimumSize = new Size(1, 1);
            chkRandomDelay.Name = "chkRandomDelay";
            chkRandomDelay.Size = new Size(224, 25);
            chkRandomDelay.TabIndex = 95;
            chkRandomDelay.Text = "Добавлять случайную задержку c:";
            // 
            // nudRandomDelayFrom
            // 
            nudRandomDelayFrom.FillColor = Color.FromArgb(42, 46, 57);
            nudRandomDelayFrom.Font = new Font("Segoe UI", 9.75F);
            nudRandomDelayFrom.ForeColor = Color.White;
            nudRandomDelayFrom.Location = new Point(235, 273);
            nudRandomDelayFrom.Margin = new Padding(4, 5, 4, 5);
            nudRandomDelayFrom.Maximum = 10000D;
            nudRandomDelayFrom.Minimum = 0D;
            nudRandomDelayFrom.MinimumSize = new Size(1, 16);
            nudRandomDelayFrom.Name = "nudRandomDelayFrom";
            nudRandomDelayFrom.Padding = new Padding(5);
            nudRandomDelayFrom.RectColor = Color.FromArgb(65, 71, 84);
            nudRandomDelayFrom.RectHoverColor = Color.BlueViolet;
            nudRandomDelayFrom.RectPressColor = Color.Indigo;
            nudRandomDelayFrom.ShowText = false;
            nudRandomDelayFrom.Size = new Size(100, 25);
            nudRandomDelayFrom.TabIndex = 93;
            nudRandomDelayFrom.Text = "0";
            nudRandomDelayFrom.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cmbRandomDelayFromUnit
            // 
            cmbRandomDelayFromUnit.DataSource = null;
            cmbRandomDelayFromUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbRandomDelayFromUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbRandomDelayFromUnit.Font = new Font("Segoe UI", 9F);
            cmbRandomDelayFromUnit.ForeColor = Color.White;
            cmbRandomDelayFromUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbRandomDelayFromUnit.ItemForeColor = Color.White;
            cmbRandomDelayFromUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbRandomDelayFromUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbRandomDelayFromUnit.Items.AddRange(new object[] { "секунд", "минут", "часов" });
            cmbRandomDelayFromUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbRandomDelayFromUnit.ItemSelectForeColor = Color.White;
            cmbRandomDelayFromUnit.Location = new Point(339, 273);
            cmbRandomDelayFromUnit.Margin = new Padding(4, 5, 4, 5);
            cmbRandomDelayFromUnit.MinimumSize = new Size(63, 0);
            cmbRandomDelayFromUnit.Name = "cmbRandomDelayFromUnit";
            cmbRandomDelayFromUnit.Padding = new Padding(0, 0, 30, 2);
            cmbRandomDelayFromUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbRandomDelayFromUnit.Size = new Size(73, 25);
            cmbRandomDelayFromUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbRandomDelayFromUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbRandomDelayFromUnit.SymbolSize = 24;
            cmbRandomDelayFromUnit.TabIndex = 97;
            cmbRandomDelayFromUnit.Text = "секунд";
            cmbRandomDelayFromUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbRandomDelayFromUnit.Watermark = "";
            // 
            // lblRandomDelayTo
            // 
            lblRandomDelayTo.AutoSize = true;
            lblRandomDelayTo.BackColor = Color.Transparent;
            lblRandomDelayTo.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblRandomDelayTo.ForeColor = Color.FromArgb(180, 180, 180);
            lblRandomDelayTo.Location = new Point(418, 279);
            lblRandomDelayTo.Name = "lblRandomDelayTo";
            lblRandomDelayTo.Size = new Size(20, 13);
            lblRandomDelayTo.TabIndex = 96;
            lblRandomDelayTo.Text = "до";
            // 
            // nudRandomDelayTo
            // 
            nudRandomDelayTo.FillColor = Color.FromArgb(42, 46, 57);
            nudRandomDelayTo.Font = new Font("Segoe UI", 9.75F);
            nudRandomDelayTo.ForeColor = Color.White;
            nudRandomDelayTo.Location = new Point(444, 273);
            nudRandomDelayTo.Margin = new Padding(4, 5, 4, 5);
            nudRandomDelayTo.Maximum = 10000D;
            nudRandomDelayTo.Minimum = 0D;
            nudRandomDelayTo.MinimumSize = new Size(1, 16);
            nudRandomDelayTo.Name = "nudRandomDelayTo";
            nudRandomDelayTo.Padding = new Padding(5);
            nudRandomDelayTo.RectColor = Color.FromArgb(65, 71, 84);
            nudRandomDelayTo.RectHoverColor = Color.BlueViolet;
            nudRandomDelayTo.RectPressColor = Color.Indigo;
            nudRandomDelayTo.ShowText = false;
            nudRandomDelayTo.Size = new Size(100, 25);
            nudRandomDelayTo.TabIndex = 94;
            nudRandomDelayTo.Text = "12";
            nudRandomDelayTo.TextAlignment = ContentAlignment.MiddleCenter;
            nudRandomDelayTo.Value = 12;
            // 
            // cmbRandomDelayToUnit
            // 
            cmbRandomDelayToUnit.DataSource = null;
            cmbRandomDelayToUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbRandomDelayToUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbRandomDelayToUnit.Font = new Font("Segoe UI", 9F);
            cmbRandomDelayToUnit.ForeColor = Color.White;
            cmbRandomDelayToUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbRandomDelayToUnit.ItemForeColor = Color.White;
            cmbRandomDelayToUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbRandomDelayToUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbRandomDelayToUnit.Items.AddRange(new object[] { "секунд", "минут", "часов" });
            cmbRandomDelayToUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbRandomDelayToUnit.ItemSelectForeColor = Color.White;
            cmbRandomDelayToUnit.Location = new Point(548, 273);
            cmbRandomDelayToUnit.Margin = new Padding(4, 5, 4, 5);
            cmbRandomDelayToUnit.MinimumSize = new Size(63, 0);
            cmbRandomDelayToUnit.Name = "cmbRandomDelayToUnit";
            cmbRandomDelayToUnit.Padding = new Padding(0, 0, 30, 2);
            cmbRandomDelayToUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbRandomDelayToUnit.Size = new Size(73, 25);
            cmbRandomDelayToUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbRandomDelayToUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbRandomDelayToUnit.SymbolSize = 24;
            cmbRandomDelayToUnit.TabIndex = 98;
            cmbRandomDelayToUnit.Text = "часов";
            cmbRandomDelayToUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbRandomDelayToUnit.Watermark = "";
            // 
            // lblAutoMaxMessages
            // 
            lblAutoMaxMessages.AutoSize = true;
            lblAutoMaxMessages.BackColor = Color.Transparent;
            lblAutoMaxMessages.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoMaxMessages.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoMaxMessages.Location = new Point(9, 233);
            lblAutoMaxMessages.Name = "lblAutoMaxMessages";
            lblAutoMaxMessages.Size = new Size(159, 13);
            lblAutoMaxMessages.TabIndex = 9;
            lblAutoMaxMessages.Text = "Макс. сообщений за сессию:";
            // 
            // nudAutoMaxMessages
            // 
            nudAutoMaxMessages.FillColor = Color.FromArgb(42, 46, 57);
            nudAutoMaxMessages.Font = new Font("Segoe UI", 9.75F);
            nudAutoMaxMessages.ForeColor = Color.White;
            nudAutoMaxMessages.Location = new Point(193, 228);
            nudAutoMaxMessages.Margin = new Padding(4, 5, 4, 5);
            nudAutoMaxMessages.Maximum = 10000D;
            nudAutoMaxMessages.Minimum = 0D;
            nudAutoMaxMessages.MinimumSize = new Size(1, 16);
            nudAutoMaxMessages.Name = "nudAutoMaxMessages";
            nudAutoMaxMessages.Padding = new Padding(5);
            nudAutoMaxMessages.RectColor = Color.FromArgb(65, 71, 84);
            nudAutoMaxMessages.RectHoverColor = Color.BlueViolet;
            nudAutoMaxMessages.RectPressColor = Color.Indigo;
            nudAutoMaxMessages.ShowText = false;
            nudAutoMaxMessages.Size = new Size(100, 25);
            nudAutoMaxMessages.TabIndex = 10;
            nudAutoMaxMessages.Text = "0";
            nudAutoMaxMessages.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblAutoMaxHint
            // 
            lblAutoMaxHint.AutoSize = true;
            lblAutoMaxHint.BackColor = Color.Transparent;
            lblAutoMaxHint.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoMaxHint.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoMaxHint.Location = new Point(299, 233);
            lblAutoMaxHint.Name = "lblAutoMaxHint";
            lblAutoMaxHint.Size = new Size(64, 13);
            lblAutoMaxHint.TabIndex = 19;
            lblAutoMaxHint.Text = "шт. (0 = ∞)";
            // 
            // lblAutoPause
            // 
            lblAutoPause.AutoSize = true;
            lblAutoPause.BackColor = Color.Transparent;
            lblAutoPause.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoPause.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoPause.Location = new Point(9, 198);
            lblAutoPause.Name = "lblAutoPause";
            lblAutoPause.Size = new Size(142, 13);
            lblAutoPause.TabIndex = 6;
            lblAutoPause.Text = "Пауза между повторами:";
            // 
            // nudAutoPause
            // 
            nudAutoPause.FillColor = Color.FromArgb(42, 46, 57);
            nudAutoPause.Font = new Font("Segoe UI", 9.75F);
            nudAutoPause.ForeColor = Color.White;
            nudAutoPause.Location = new Point(193, 193);
            nudAutoPause.Margin = new Padding(4, 5, 4, 5);
            nudAutoPause.Maximum = 3600D;
            nudAutoPause.Minimum = 0D;
            nudAutoPause.MinimumSize = new Size(1, 16);
            nudAutoPause.Name = "nudAutoPause";
            nudAutoPause.Padding = new Padding(5);
            nudAutoPause.RectColor = Color.FromArgb(65, 71, 84);
            nudAutoPause.RectHoverColor = Color.BlueViolet;
            nudAutoPause.RectPressColor = Color.Indigo;
            nudAutoPause.ShowText = false;
            nudAutoPause.Size = new Size(100, 25);
            nudAutoPause.TabIndex = 7;
            nudAutoPause.Text = "5";
            nudAutoPause.TextAlignment = ContentAlignment.MiddleCenter;
            nudAutoPause.Value = 5;
            // 
            // cmbAutoPauseUnit
            // 
            cmbAutoPauseUnit.DataSource = null;
            cmbAutoPauseUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAutoPauseUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbAutoPauseUnit.Font = new Font("Segoe UI", 9F);
            cmbAutoPauseUnit.ForeColor = Color.White;
            cmbAutoPauseUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbAutoPauseUnit.ItemForeColor = Color.White;
            cmbAutoPauseUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbAutoPauseUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbAutoPauseUnit.Items.AddRange(new object[] { "секунд", "минут", "часов" });
            cmbAutoPauseUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbAutoPauseUnit.ItemSelectForeColor = Color.White;
            cmbAutoPauseUnit.Location = new Point(299, 193);
            cmbAutoPauseUnit.Margin = new Padding(4, 5, 4, 5);
            cmbAutoPauseUnit.MinimumSize = new Size(63, 0);
            cmbAutoPauseUnit.Name = "cmbAutoPauseUnit";
            cmbAutoPauseUnit.Padding = new Padding(0, 0, 30, 2);
            cmbAutoPauseUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbAutoPauseUnit.Size = new Size(85, 25);
            cmbAutoPauseUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbAutoPauseUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAutoPauseUnit.SymbolSize = 24;
            cmbAutoPauseUnit.TabIndex = 26;
            cmbAutoPauseUnit.Text = "секунд";
            cmbAutoPauseUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAutoPauseUnit.Watermark = "";
            // 
            // lblAutoRetry
            // 
            lblAutoRetry.AutoSize = true;
            lblAutoRetry.BackColor = Color.Transparent;
            lblAutoRetry.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoRetry.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoRetry.Location = new Point(9, 163);
            lblAutoRetry.Name = "lblAutoRetry";
            lblAutoRetry.Size = new Size(172, 13);
            lblAutoRetry.TabIndex = 3;
            lblAutoRetry.Text = "Повтор при ошибке отправке:";
            // 
            // nudAutoRetry
            // 
            nudAutoRetry.FillColor = Color.FromArgb(42, 46, 57);
            nudAutoRetry.Font = new Font("Segoe UI", 9.75F);
            nudAutoRetry.ForeColor = Color.White;
            nudAutoRetry.Location = new Point(193, 158);
            nudAutoRetry.Margin = new Padding(4, 5, 4, 5);
            nudAutoRetry.Maximum = 100D;
            nudAutoRetry.Minimum = 0D;
            nudAutoRetry.MinimumSize = new Size(1, 16);
            nudAutoRetry.Name = "nudAutoRetry";
            nudAutoRetry.Padding = new Padding(5);
            nudAutoRetry.RectColor = Color.FromArgb(65, 71, 84);
            nudAutoRetry.RectHoverColor = Color.BlueViolet;
            nudAutoRetry.RectPressColor = Color.Indigo;
            nudAutoRetry.ShowText = false;
            nudAutoRetry.Size = new Size(100, 25);
            nudAutoRetry.TabIndex = 4;
            nudAutoRetry.Text = "3";
            nudAutoRetry.TextAlignment = ContentAlignment.MiddleCenter;
            nudAutoRetry.Value = 3;
            // 
            // lblAutoRetryUnit
            // 
            lblAutoRetryUnit.AutoSize = true;
            lblAutoRetryUnit.BackColor = Color.Transparent;
            lblAutoRetryUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoRetryUnit.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoRetryUnit.Location = new Point(300, 163);
            lblAutoRetryUnit.Name = "lblAutoRetryUnit";
            lblAutoRetryUnit.Size = new Size(25, 13);
            lblAutoRetryUnit.TabIndex = 5;
            lblAutoRetryUnit.Text = "раз";
            // 
            // lblAutoInterval
            // 
            lblAutoInterval.AutoSize = true;
            lblAutoInterval.BackColor = Color.Transparent;
            lblAutoInterval.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblAutoInterval.ForeColor = Color.FromArgb(180, 180, 180);
            lblAutoInterval.Location = new Point(9, 128);
            lblAutoInterval.Name = "lblAutoInterval";
            lblAutoInterval.Size = new Size(167, 13);
            lblAutoInterval.TabIndex = 0;
            lblAutoInterval.Text = "Интервал между отправками:";
            // 
            // nudAutoInterval
            // 
            nudAutoInterval.FillColor = Color.FromArgb(42, 46, 57);
            nudAutoInterval.Font = new Font("Segoe UI", 9.75F);
            nudAutoInterval.ForeColor = Color.White;
            nudAutoInterval.Location = new Point(193, 123);
            nudAutoInterval.Margin = new Padding(4, 5, 4, 5);
            nudAutoInterval.Maximum = 3600D;
            nudAutoInterval.Minimum = 1D;
            nudAutoInterval.MinimumSize = new Size(1, 16);
            nudAutoInterval.Name = "nudAutoInterval";
            nudAutoInterval.Padding = new Padding(5);
            nudAutoInterval.RectColor = Color.FromArgb(65, 71, 84);
            nudAutoInterval.RectHoverColor = Color.BlueViolet;
            nudAutoInterval.RectPressColor = Color.Indigo;
            nudAutoInterval.ShowText = false;
            nudAutoInterval.Size = new Size(100, 25);
            nudAutoInterval.TabIndex = 1;
            nudAutoInterval.Text = "60";
            nudAutoInterval.TextAlignment = ContentAlignment.MiddleCenter;
            nudAutoInterval.Value = 60;
            // 
            // cmbAutoIntervalUnit
            // 
            cmbAutoIntervalUnit.DataSource = null;
            cmbAutoIntervalUnit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAutoIntervalUnit.FillColor = Color.FromArgb(42, 46, 57);
            cmbAutoIntervalUnit.Font = new Font("Segoe UI", 9F);
            cmbAutoIntervalUnit.ForeColor = Color.White;
            cmbAutoIntervalUnit.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbAutoIntervalUnit.ItemForeColor = Color.White;
            cmbAutoIntervalUnit.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbAutoIntervalUnit.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbAutoIntervalUnit.Items.AddRange(new object[] { "секунд", "минут", "часов" });
            cmbAutoIntervalUnit.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbAutoIntervalUnit.ItemSelectForeColor = Color.White;
            cmbAutoIntervalUnit.Location = new Point(299, 123);
            cmbAutoIntervalUnit.Margin = new Padding(4, 5, 4, 5);
            cmbAutoIntervalUnit.MinimumSize = new Size(63, 0);
            cmbAutoIntervalUnit.Name = "cmbAutoIntervalUnit";
            cmbAutoIntervalUnit.Padding = new Padding(0, 0, 30, 2);
            cmbAutoIntervalUnit.RectColor = Color.FromArgb(65, 71, 84);
            cmbAutoIntervalUnit.Size = new Size(85, 25);
            cmbAutoIntervalUnit.Style = Sunny.UI.UIStyle.Custom;
            cmbAutoIntervalUnit.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAutoIntervalUnit.SymbolSize = 24;
            cmbAutoIntervalUnit.TabIndex = 2;
            cmbAutoIntervalUnit.Text = "секунд";
            cmbAutoIntervalUnit.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAutoIntervalUnit.Watermark = "";
            // 
            // lblManualTemplateHint
            // 
            lblManualTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblManualTemplateHint.ForeColor = Color.DarkGray;
            lblManualTemplateHint.Location = new Point(9, 69);
            lblManualTemplateHint.Name = "lblManualTemplateHint";
            lblManualTemplateHint.Size = new Size(644, 45);
            lblManualTemplateHint.TabIndex = 24;
            lblManualTemplateHint.Text = resources.GetString("lblManualTemplateHint.Text");
            // 
            // txtManualCustomText
            // 
            txtManualCustomText.ButtonFillColor = Color.Transparent;
            txtManualCustomText.ButtonStyleInherited = false;
            txtManualCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtManualCustomText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtManualCustomText.ForeColor = Color.White;
            txtManualCustomText.Location = new Point(9, 40);
            txtManualCustomText.Margin = new Padding(4, 5, 4, 5);
            txtManualCustomText.MinimumSize = new Size(1, 16);
            txtManualCustomText.Name = "txtManualCustomText";
            txtManualCustomText.Padding = new Padding(5);
            txtManualCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtManualCustomText.ShowText = false;
            txtManualCustomText.Size = new Size(644, 25);
            txtManualCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtManualCustomText.TabIndex = 23;
            txtManualCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtManualCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbAutoTemplate
            // 
            cmbAutoTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAutoTemplate.DataSource = null;
            cmbAutoTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbAutoTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbAutoTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbAutoTemplate.ForeColor = Color.White;
            cmbAutoTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbAutoTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbAutoTemplate.Location = new Point(9, 9);
            cmbAutoTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbAutoTemplate.MinimumSize = new Size(63, 0);
            cmbAutoTemplate.Name = "cmbAutoTemplate";
            cmbAutoTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbAutoTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbAutoTemplate.Size = new Size(644, 25);
            cmbAutoTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbAutoTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbAutoTemplate.SymbolSize = 24;
            cmbAutoTemplate.TabIndex = 18;
            cmbAutoTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbAutoTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // picInfo1
            // 
            picInfo1.BackgroundImage = Properties.Resources.circle_info_solid;
            picInfo1.BackgroundImageLayout = ImageLayout.Stretch;
            picInfo1.Location = new Point(306, 135);
            picInfo1.Name = "picInfo1";
            picInfo1.Size = new Size(15, 15);
            picInfo1.TabIndex = 100;
            picInfo1.TabStop = false;
            // 
            // picInfo2
            // 
            picInfo2.BackgroundImage = Properties.Resources.circle_info_solid;
            picInfo2.BackgroundImageLayout = ImageLayout.Stretch;
            picInfo2.Location = new Point(306, 170);
            picInfo2.Name = "picInfo2";
            picInfo2.Size = new Size(15, 15);
            picInfo2.TabIndex = 101;
            picInfo2.TabStop = false;
            // 
            // picInfo3
            // 
            picInfo3.BackgroundImage = Properties.Resources.circle_info_solid;
            picInfo3.BackgroundImageLayout = ImageLayout.Stretch;
            picInfo3.Location = new Point(306, 205);
            picInfo3.Name = "picInfo3";
            picInfo3.Size = new Size(15, 15);
            picInfo3.TabIndex = 102;
            picInfo3.TabStop = false;
            // 
            // AutoTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpAutomatic);
            Name = "AutoTabControl";
            Size = new Size(696, 483);
            grpAutomatic.ResumeLayout(false);
            pnlAutoButtons.ResumeLayout(false);
            pnlAuto.ResumeLayout(false);
            pnlAutoContent.ResumeLayout(false);
            pnlAutoContent.PerformLayout();
            grpAutoHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInfo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfo3).EndInit();
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpAutomatic;
        private Sunny.UI.UIPanel pnlAutoButtons;
        private Sunny.UI.UICheckBox chkAutoManualConfirm;
        private Sunny.UI.UIButton btnSaveAutomatic;
        private Sunny.UI.UIButton btnGoAutomatic;
        private Panel pnlAutoContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbAutoTemplate;
        private Sunny.UI.UITextBox txtManualCustomText;
        private Label lblManualTemplateHint;

        // Basic Settings
        private Label lblAutoInterval;
        private Sunny.UI.UIIntegerUpDown nudAutoInterval;
        private Sunny.UI.UIComboBox cmbAutoIntervalUnit;
        private Label lblAutoRetry;
        private Sunny.UI.UIIntegerUpDown nudAutoRetry;
        private Label lblAutoRetryUnit;
        private Label lblAutoPause;
        private Sunny.UI.UIIntegerUpDown nudAutoPause;
        private Sunny.UI.UIComboBox cmbAutoPauseUnit;
        private Label lblAutoMaxMessages;
        private Sunny.UI.UIIntegerUpDown nudAutoMaxMessages;
        private Label lblAutoMaxHint;

        // Random Delay
        private Sunny.UI.UICheckBox chkRandomDelay;
        private Sunny.UI.UIIntegerUpDown nudRandomDelayFrom;
        private Sunny.UI.UIComboBox cmbRandomDelayFromUnit;
        private Label lblRandomDelayTo;
        private Sunny.UI.UIIntegerUpDown nudRandomDelayTo;
        private Sunny.UI.UIComboBox cmbRandomDelayToUnit;

        // Time Limit
        private Sunny.UI.UICheckBox chkAutoTimeLimit;
        private Sunny.UI.UITimePicker dtpAutoTimeFrom;
        private Label lblAutoTimeTo;
        private Sunny.UI.UITimePicker dtpAutoTimeTo;

        // Date Limit
        private Sunny.UI.UICheckBox chkAutoEndDate;
        private Sunny.UI.UIDatePicker dtpAutoStartDate;
        private Label lblAutoDateTo;
        private Sunny.UI.UIDatePicker dtpAutoEndDate;

        // Days of Week
        private Label lblAutoDays;
        private Sunny.UI.UICheckBox chkAutoDayMon;
        private Sunny.UI.UICheckBox chkAutoDayTue;
        private Sunny.UI.UICheckBox chkAutoDayWed;
        private Sunny.UI.UICheckBox chkAutoDayThu;
        private Sunny.UI.UICheckBox chkAutoDayFri;
        private Sunny.UI.UICheckBox chkAutoDaySat;
        private Sunny.UI.UICheckBox chkAutoDaySun;

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
        private Sunny.UI.UICheckBox chkPinMessage;
        private Sunny.UI.UICheckBox chkProtectContent;
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
        private Sunny.UI.UIGroupBox grpAutoHistory;
        private FlowLayoutPanel flpAutomaticHistory;

        // Info Icons
        private PictureBox picInfo1;
        private PictureBox picInfo2;
        private PictureBox picInfo3;
        private Panel pnlAuto;
    }
}