namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class ManualTabControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualTabControl));
            grpManual = new Sunny.UI.UIGroupBox();
            pnlManualButtons = new Sunny.UI.UIPanel();
            chkManualConfirm = new Sunny.UI.UICheckBox();
            btnSaveManual = new Sunny.UI.UIButton();
            btnSendManual = new Sunny.UI.UIButton();
            pnlManualInner = new Panel();
            pnlManualContent = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nudManualAutoDeleteMinutes = new Sunny.UI.UIIntegerUpDown();
            nudManualAutoDeleteSeconds = new Sunny.UI.UIIntegerUpDown();
            nudManualDelayMinutes = new Sunny.UI.UIIntegerUpDown();
            nudManualDelaySeconds = new Sunny.UI.UIIntegerUpDown();
            chkManualAutoDelete = new Sunny.UI.UICheckBox();
            chkManualDelay = new Sunny.UI.UICheckBox();
            grpManualHistory = new Sunny.UI.UIGroupBox();
            flpManualHistory = new FlowLayoutPanel();
            chkManualAnimatedEffect = new Sunny.UI.UICheckBox();
            cmbManualAnimatedEffect = new Sunny.UI.UIComboBox();
            cmbManualEffectApplyTo = new Sunny.UI.UIComboBox();
            chkManualAnimatedEmoji = new Sunny.UI.UICheckBox();
            cmbManualAnimatedEmoji = new Sunny.UI.UIComboBox();
            cmbManualEmojiApplyTo = new Sunny.UI.UIComboBox();
            cmbManualPinTarget = new Sunny.UI.UIComboBox();
            chkManualPinMessage = new Sunny.UI.UICheckBox();
            chkManualDeletePrevious = new Sunny.UI.UICheckBox();
            chkManualProtectContent = new Sunny.UI.UICheckBox();
            chkManualHideSpoiler = new Sunny.UI.UICheckBox();
            chkManualReplyToLast = new Sunny.UI.UICheckBox();
            chkManualSilentSend = new Sunny.UI.UICheckBox();
            chkManualDisablePreview = new Sunny.UI.UICheckBox();
            chkManualSendTemplateFirst = new Sunny.UI.UICheckBox();
            chkManualNotifyError = new Sunny.UI.UICheckBox();
            cmbManualNotifyError1 = new Sunny.UI.UIComboBox();
            lblManualNotifyErrorOr = new Label();
            cmbManualNotifyError2 = new Sunny.UI.UIComboBox();
            chkManualNotifyComplete = new Sunny.UI.UICheckBox();
            cmbManualNotifyComplete1 = new Sunny.UI.UIComboBox();
            lblManualNotifyCompleteOr = new Label();
            cmbManualNotifyComplete2 = new Sunny.UI.UIComboBox();
            chkManualNotifySuccess = new Sunny.UI.UICheckBox();
            cmbManualNotifySuccess1 = new Sunny.UI.UIComboBox();
            lblManualNotifySuccessOr = new Label();
            cmbManualNotifySuccess2 = new Sunny.UI.UIComboBox();
            lblManualTemplateHint = new Label();
            txtManualCustomText = new Sunny.UI.UITextBox();
            cmbManualTemplate = new Sunny.UI.UIComboBox();
            toolTip1 = new Sunny.UI.UIToolTip(components);
            grpManual.SuspendLayout();
            pnlManualButtons.SuspendLayout();
            pnlManualInner.SuspendLayout();
            pnlManualContent.SuspendLayout();
            grpManualHistory.SuspendLayout();
            SuspendLayout();
            // 
            // grpManual
            // 
            grpManual.BackColor = Color.FromArgb(35, 39, 48);
            grpManual.Controls.Add(pnlManualButtons);
            grpManual.Controls.Add(pnlManualInner);
            grpManual.Dock = DockStyle.Fill;
            grpManual.FillColor = Color.Transparent;
            grpManual.FillColor2 = Color.Transparent;
            grpManual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            grpManual.ForeColor = Color.White;
            grpManual.Location = new Point(0, 0);
            grpManual.Margin = new Padding(4, 5, 4, 5);
            grpManual.MinimumSize = new Size(1, 1);
            grpManual.Name = "grpManual";
            grpManual.Padding = new Padding(0, 32, 0, 0);
            grpManual.Radius = 15;
            grpManual.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            grpManual.RectColor = Color.FromArgb(58, 58, 69);
            grpManual.Size = new Size(696, 483);
            grpManual.Style = Sunny.UI.UIStyle.Custom;
            grpManual.TabIndex = 9;
            grpManual.Text = "Настройка ручной отправки";
            grpManual.TextAlignment = ContentAlignment.MiddleLeft;
            grpManual.TitleInterval = 8;
            grpManual.TitleTop = 14;
            // 
            // pnlManualButtons
            // 
            pnlManualButtons.Controls.Add(chkManualConfirm);
            pnlManualButtons.Controls.Add(btnSaveManual);
            pnlManualButtons.Controls.Add(btnSendManual);
            pnlManualButtons.Dock = DockStyle.Bottom;
            pnlManualButtons.FillColor = Color.Transparent;
            pnlManualButtons.FillColor2 = Color.Transparent;
            pnlManualButtons.Font = new Font("Microsoft Sans Serif", 12F);
            pnlManualButtons.ForeColor = Color.Transparent;
            pnlManualButtons.Location = new Point(0, 438);
            pnlManualButtons.Margin = new Padding(4, 5, 4, 5);
            pnlManualButtons.MinimumSize = new Size(1, 1);
            pnlManualButtons.Name = "pnlManualButtons";
            pnlManualButtons.Radius = 0;
            pnlManualButtons.RectColor = Color.FromArgb(58, 58, 69);
            pnlManualButtons.RectDisableColor = Color.Transparent;
            pnlManualButtons.Size = new Size(696, 45);
            pnlManualButtons.TabIndex = 26;
            pnlManualButtons.Text = null;
            pnlManualButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkManualConfirm
            // 
            chkManualConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkManualConfirm.BackColor = Color.Transparent;
            chkManualConfirm.CheckBoxColor = Color.BlueViolet;
            chkManualConfirm.Checked = true;
            chkManualConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualConfirm.ForeColor = Color.White;
            chkManualConfirm.Location = new Point(46, 10);
            chkManualConfirm.MinimumSize = new Size(1, 1);
            chkManualConfirm.Name = "chkManualConfirm";
            chkManualConfirm.Size = new Size(333, 25);
            chkManualConfirm.TabIndex = 27;
            chkManualConfirm.Text = "Запрашивать подтверждение перед началом сеанса";
            // 
            // btnSaveManual
            // 
            btnSaveManual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveManual.FillColor = Color.FromArgb(108, 99, 255);
            btnSaveManual.FillColor2 = Color.Transparent;
            btnSaveManual.FillDisableColor = Color.FromArgb(46, 42, 110);
            btnSaveManual.FillHoverColor = Color.FromArgb(139, 133, 255);
            btnSaveManual.FillPressColor = Color.FromArgb(90, 82, 213);
            btnSaveManual.FillSelectedColor = Color.Transparent;
            btnSaveManual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveManual.ForeDisableColor = Color.White;
            btnSaveManual.Location = new Point(389, 5);
            btnSaveManual.MinimumSize = new Size(1, 1);
            btnSaveManual.Name = "btnSaveManual";
            btnSaveManual.Radius = 8;
            btnSaveManual.RectColor = Color.Transparent;
            btnSaveManual.RectDisableColor = Color.Transparent;
            btnSaveManual.RectHoverColor = Color.Transparent;
            btnSaveManual.RectPressColor = Color.Transparent;
            btnSaveManual.RectSelectedColor = Color.Transparent;
            btnSaveManual.Size = new Size(150, 35);
            btnSaveManual.Style = Sunny.UI.UIStyle.Custom;
            btnSaveManual.TabIndex = 13;
            btnSaveManual.Text = "Сохранить настройки";
            btnSaveManual.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnSendManual
            // 
            btnSendManual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSendManual.FillColor = Color.FromArgb(123, 44, 191);
            btnSendManual.FillColor2 = Color.Transparent;
            btnSendManual.FillDisableColor = Color.Transparent;
            btnSendManual.FillHoverColor = Color.FromArgb(157, 78, 221);
            btnSendManual.FillPressColor = Color.FromArgb(90, 24, 154);
            btnSendManual.FillSelectedColor = Color.Transparent;
            btnSendManual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSendManual.Location = new Point(543, 5);
            btnSendManual.MinimumSize = new Size(1, 1);
            btnSendManual.Name = "btnSendManual";
            btnSendManual.Radius = 8;
            btnSendManual.RectColor = Color.Transparent;
            btnSendManual.RectDisableColor = Color.Transparent;
            btnSendManual.RectHoverColor = Color.Transparent;
            btnSendManual.RectPressColor = Color.Transparent;
            btnSendManual.RectSelectedColor = Color.Transparent;
            btnSendManual.Size = new Size(150, 35);
            btnSendManual.Style = Sunny.UI.UIStyle.Custom;
            btnSendManual.TabIndex = 14;
            btnSendManual.Text = "Отправить сейчас";
            btnSendManual.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // pnlManualInner
            // 
            pnlManualInner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlManualInner.AutoScroll = true;
            pnlManualInner.Controls.Add(pnlManualContent);
            pnlManualInner.Location = new Point(3, 25);
            pnlManualInner.Name = "pnlManualInner";
            pnlManualInner.Size = new Size(693, 413);
            pnlManualInner.TabIndex = 27;
            // 
            // pnlManualContent
            // 
            pnlManualContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlManualContent.BackColor = Color.FromArgb(35, 39, 48);
            pnlManualContent.Controls.Add(label4);
            pnlManualContent.Controls.Add(label3);
            pnlManualContent.Controls.Add(label2);
            pnlManualContent.Controls.Add(label1);
            pnlManualContent.Controls.Add(nudManualAutoDeleteMinutes);
            pnlManualContent.Controls.Add(nudManualAutoDeleteSeconds);
            pnlManualContent.Controls.Add(nudManualDelayMinutes);
            pnlManualContent.Controls.Add(nudManualDelaySeconds);
            pnlManualContent.Controls.Add(chkManualAutoDelete);
            pnlManualContent.Controls.Add(chkManualDelay);
            pnlManualContent.Controls.Add(grpManualHistory);
            pnlManualContent.Controls.Add(chkManualAnimatedEffect);
            pnlManualContent.Controls.Add(cmbManualAnimatedEffect);
            pnlManualContent.Controls.Add(cmbManualEffectApplyTo);
            pnlManualContent.Controls.Add(chkManualAnimatedEmoji);
            pnlManualContent.Controls.Add(cmbManualAnimatedEmoji);
            pnlManualContent.Controls.Add(cmbManualEmojiApplyTo);
            pnlManualContent.Controls.Add(cmbManualPinTarget);
            pnlManualContent.Controls.Add(chkManualPinMessage);
            pnlManualContent.Controls.Add(chkManualDeletePrevious);
            pnlManualContent.Controls.Add(chkManualProtectContent);
            pnlManualContent.Controls.Add(chkManualHideSpoiler);
            pnlManualContent.Controls.Add(chkManualReplyToLast);
            pnlManualContent.Controls.Add(chkManualSilentSend);
            pnlManualContent.Controls.Add(chkManualDisablePreview);
            pnlManualContent.Controls.Add(chkManualSendTemplateFirst);
            pnlManualContent.Controls.Add(chkManualNotifyError);
            pnlManualContent.Controls.Add(cmbManualNotifyError1);
            pnlManualContent.Controls.Add(lblManualNotifyErrorOr);
            pnlManualContent.Controls.Add(cmbManualNotifyError2);
            pnlManualContent.Controls.Add(chkManualNotifyComplete);
            pnlManualContent.Controls.Add(cmbManualNotifyComplete1);
            pnlManualContent.Controls.Add(lblManualNotifyCompleteOr);
            pnlManualContent.Controls.Add(cmbManualNotifyComplete2);
            pnlManualContent.Controls.Add(chkManualNotifySuccess);
            pnlManualContent.Controls.Add(cmbManualNotifySuccess1);
            pnlManualContent.Controls.Add(lblManualNotifySuccessOr);
            pnlManualContent.Controls.Add(cmbManualNotifySuccess2);
            pnlManualContent.Controls.Add(lblManualTemplateHint);
            pnlManualContent.Controls.Add(txtManualCustomText);
            pnlManualContent.Controls.Add(cmbManualTemplate);
            pnlManualContent.Location = new Point(0, 0);
            pnlManualContent.MinimumSize = new Size(673, 0);
            pnlManualContent.Name = "pnlManualContent";
            pnlManualContent.Padding = new Padding(5, 0, 5, 0);
            pnlManualContent.Size = new Size(673, 850);
            pnlManualContent.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(180, 180, 180);
            label4.Location = new Point(441, 147);
            label4.Name = "label4";
            label4.Size = new Size(32, 13);
            label4.TabIndex = 121;
            label4.Text = "мин.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(180, 180, 180);
            label3.Location = new Point(441, 181);
            label3.Name = "label3";
            label3.Size = new Size(32, 13);
            label3.TabIndex = 120;
            label3.Text = "мин.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 180, 180);
            label2.Location = new Point(311, 181);
            label2.Name = "label2";
            label2.Size = new Size(27, 13);
            label2.TabIndex = 119;
            label2.Text = "сек.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(180, 180, 180);
            label1.Location = new Point(311, 147);
            label1.Name = "label1";
            label1.Size = new Size(27, 13);
            label1.TabIndex = 118;
            label1.Text = "сек.";
            // 
            // nudManualAutoDeleteMinutes
            // 
            nudManualAutoDeleteMinutes.FillColor = Color.FromArgb(42, 46, 57);
            nudManualAutoDeleteMinutes.FillColor2 = Color.Transparent;
            nudManualAutoDeleteMinutes.FillDisableColor = Color.FromArgb(42, 46, 57);
            nudManualAutoDeleteMinutes.FillReadOnlyColor = Color.Transparent;
            nudManualAutoDeleteMinutes.Font = new Font("Segoe UI", 9.75F);
            nudManualAutoDeleteMinutes.ForeColor = Color.White;
            nudManualAutoDeleteMinutes.ForeDisableColor = Color.White;
            nudManualAutoDeleteMinutes.ForeReadOnlyColor = Color.Transparent;
            nudManualAutoDeleteMinutes.Location = new Point(350, 175);
            nudManualAutoDeleteMinutes.Margin = new Padding(4, 5, 4, 5);
            nudManualAutoDeleteMinutes.Maximum = 59D;
            nudManualAutoDeleteMinutes.Minimum = 0D;
            nudManualAutoDeleteMinutes.MinimumSize = new Size(1, 16);
            nudManualAutoDeleteMinutes.Name = "nudManualAutoDeleteMinutes";
            nudManualAutoDeleteMinutes.Padding = new Padding(5);
            nudManualAutoDeleteMinutes.RectColor = Color.FromArgb(65, 71, 84);
            nudManualAutoDeleteMinutes.RectDisableColor = Color.FromArgb(53, 57, 68);
            nudManualAutoDeleteMinutes.RectHoverColor = Color.BlueViolet;
            nudManualAutoDeleteMinutes.RectPressColor = Color.Indigo;
            nudManualAutoDeleteMinutes.RectReadOnlyColor = Color.Transparent;
            nudManualAutoDeleteMinutes.ShowText = false;
            nudManualAutoDeleteMinutes.Size = new Size(84, 25);
            nudManualAutoDeleteMinutes.Style = Sunny.UI.UIStyle.Custom;
            nudManualAutoDeleteMinutes.TabIndex = 116;
            nudManualAutoDeleteMinutes.Text = "0";
            nudManualAutoDeleteMinutes.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // nudManualAutoDeleteSeconds
            // 
            nudManualAutoDeleteSeconds.FillColor = Color.FromArgb(42, 46, 57);
            nudManualAutoDeleteSeconds.FillColor2 = Color.Transparent;
            nudManualAutoDeleteSeconds.FillDisableColor = Color.FromArgb(42, 46, 57);
            nudManualAutoDeleteSeconds.FillReadOnlyColor = Color.Transparent;
            nudManualAutoDeleteSeconds.Font = new Font("Segoe UI", 9.75F);
            nudManualAutoDeleteSeconds.ForeColor = Color.White;
            nudManualAutoDeleteSeconds.ForeDisableColor = Color.White;
            nudManualAutoDeleteSeconds.ForeReadOnlyColor = Color.Transparent;
            nudManualAutoDeleteSeconds.Location = new Point(220, 175);
            nudManualAutoDeleteSeconds.Margin = new Padding(4, 5, 4, 5);
            nudManualAutoDeleteSeconds.Maximum = 59D;
            nudManualAutoDeleteSeconds.Minimum = 0D;
            nudManualAutoDeleteSeconds.MinimumSize = new Size(1, 16);
            nudManualAutoDeleteSeconds.Name = "nudManualAutoDeleteSeconds";
            nudManualAutoDeleteSeconds.Padding = new Padding(5);
            nudManualAutoDeleteSeconds.RectColor = Color.FromArgb(65, 71, 84);
            nudManualAutoDeleteSeconds.RectDisableColor = Color.FromArgb(53, 57, 68);
            nudManualAutoDeleteSeconds.RectHoverColor = Color.BlueViolet;
            nudManualAutoDeleteSeconds.RectPressColor = Color.Indigo;
            nudManualAutoDeleteSeconds.RectReadOnlyColor = Color.Transparent;
            nudManualAutoDeleteSeconds.ShowText = false;
            nudManualAutoDeleteSeconds.Size = new Size(84, 25);
            nudManualAutoDeleteSeconds.Style = Sunny.UI.UIStyle.Custom;
            nudManualAutoDeleteSeconds.TabIndex = 117;
            nudManualAutoDeleteSeconds.Text = "0";
            nudManualAutoDeleteSeconds.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // nudManualDelayMinutes
            // 
            nudManualDelayMinutes.FillColor = Color.FromArgb(42, 46, 57);
            nudManualDelayMinutes.FillColor2 = Color.Transparent;
            nudManualDelayMinutes.FillDisableColor = Color.FromArgb(42, 46, 57);
            nudManualDelayMinutes.FillReadOnlyColor = Color.Transparent;
            nudManualDelayMinutes.Font = new Font("Segoe UI", 9.75F);
            nudManualDelayMinutes.ForeColor = Color.White;
            nudManualDelayMinutes.ForeDisableColor = Color.White;
            nudManualDelayMinutes.ForeReadOnlyColor = Color.Transparent;
            nudManualDelayMinutes.Location = new Point(350, 140);
            nudManualDelayMinutes.Margin = new Padding(4, 5, 4, 5);
            nudManualDelayMinutes.Maximum = 59D;
            nudManualDelayMinutes.Minimum = 0D;
            nudManualDelayMinutes.MinimumSize = new Size(1, 16);
            nudManualDelayMinutes.Name = "nudManualDelayMinutes";
            nudManualDelayMinutes.Padding = new Padding(5);
            nudManualDelayMinutes.RectColor = Color.FromArgb(65, 71, 84);
            nudManualDelayMinutes.RectDisableColor = Color.FromArgb(53, 57, 68);
            nudManualDelayMinutes.RectHoverColor = Color.BlueViolet;
            nudManualDelayMinutes.RectPressColor = Color.Indigo;
            nudManualDelayMinutes.RectReadOnlyColor = Color.Transparent;
            nudManualDelayMinutes.ShowText = false;
            nudManualDelayMinutes.Size = new Size(84, 25);
            nudManualDelayMinutes.Style = Sunny.UI.UIStyle.Custom;
            nudManualDelayMinutes.TabIndex = 116;
            nudManualDelayMinutes.Text = "0";
            nudManualDelayMinutes.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // nudManualDelaySeconds
            // 
            nudManualDelaySeconds.FillColor = Color.FromArgb(42, 46, 57);
            nudManualDelaySeconds.FillColor2 = Color.Transparent;
            nudManualDelaySeconds.FillDisableColor = Color.FromArgb(42, 46, 57);
            nudManualDelaySeconds.FillReadOnlyColor = Color.Transparent;
            nudManualDelaySeconds.Font = new Font("Segoe UI", 9.75F);
            nudManualDelaySeconds.ForeColor = Color.White;
            nudManualDelaySeconds.ForeDisableColor = Color.White;
            nudManualDelaySeconds.ForeReadOnlyColor = Color.Transparent;
            nudManualDelaySeconds.Location = new Point(220, 140);
            nudManualDelaySeconds.Margin = new Padding(4, 5, 4, 5);
            nudManualDelaySeconds.Maximum = 59D;
            nudManualDelaySeconds.Minimum = 0D;
            nudManualDelaySeconds.MinimumSize = new Size(1, 16);
            nudManualDelaySeconds.Name = "nudManualDelaySeconds";
            nudManualDelaySeconds.Padding = new Padding(5);
            nudManualDelaySeconds.RectColor = Color.FromArgb(65, 71, 84);
            nudManualDelaySeconds.RectDisableColor = Color.FromArgb(53, 57, 68);
            nudManualDelaySeconds.RectHoverColor = Color.BlueViolet;
            nudManualDelaySeconds.RectPressColor = Color.Indigo;
            nudManualDelaySeconds.RectReadOnlyColor = Color.Transparent;
            nudManualDelaySeconds.ShowText = false;
            nudManualDelaySeconds.Size = new Size(84, 25);
            nudManualDelaySeconds.Style = Sunny.UI.UIStyle.Custom;
            nudManualDelaySeconds.TabIndex = 115;
            nudManualDelaySeconds.Text = "0";
            nudManualDelaySeconds.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chkManualAutoDelete
            // 
            chkManualAutoDelete.BackColor = Color.Transparent;
            chkManualAutoDelete.CheckBoxColor = Color.BlueViolet;
            chkManualAutoDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualAutoDelete.ForeColor = Color.White;
            chkManualAutoDelete.Location = new Point(5, 175);
            chkManualAutoDelete.MinimumSize = new Size(1, 1);
            chkManualAutoDelete.Name = "chkManualAutoDelete";
            chkManualAutoDelete.Size = new Size(208, 25);
            chkManualAutoDelete.TabIndex = 114;
            chkManualAutoDelete.Text = "Автоудаление после отправки:";
            // 
            // chkManualDelay
            // 
            chkManualDelay.BackColor = Color.Transparent;
            chkManualDelay.CheckBoxColor = Color.BlueViolet;
            chkManualDelay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualDelay.ForeColor = Color.White;
            chkManualDelay.Location = new Point(5, 140);
            chkManualDelay.MinimumSize = new Size(1, 1);
            chkManualDelay.Name = "chkManualDelay";
            chkManualDelay.Size = new Size(208, 25);
            chkManualDelay.TabIndex = 113;
            chkManualDelay.Text = "Задержка перед отправкой:";
            // 
            // grpManualHistory
            // 
            grpManualHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpManualHistory.Controls.Add(flpManualHistory);
            grpManualHistory.FillColor = Color.Transparent;
            grpManualHistory.FillColor2 = Color.Transparent;
            grpManualHistory.FillDisableColor = Color.Transparent;
            grpManualHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpManualHistory.ForeColor = SystemColors.ActiveBorder;
            grpManualHistory.ForeDisableColor = Color.Transparent;
            grpManualHistory.Location = new Point(5, 550);
            grpManualHistory.Margin = new Padding(4, 5, 4, 5);
            grpManualHistory.MinimumSize = new Size(1, 1);
            grpManualHistory.Name = "grpManualHistory";
            grpManualHistory.Padding = new Padding(5, 32, 5, 5);
            grpManualHistory.RectColor = Color.FromArgb(58, 58, 69);
            grpManualHistory.RectDisableColor = Color.Transparent;
            grpManualHistory.Size = new Size(655, 290);
            grpManualHistory.TabIndex = 34;
            grpManualHistory.Text = "История отправок:";
            grpManualHistory.TextAlignment = ContentAlignment.MiddleLeft;
            grpManualHistory.TitleTop = 10;
            // 
            // flpManualHistory
            // 
            flpManualHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpManualHistory.AutoScroll = true;
            flpManualHistory.FlowDirection = FlowDirection.TopDown;
            flpManualHistory.Location = new Point(10, 20);
            flpManualHistory.Name = "flpManualHistory";
            flpManualHistory.Size = new Size(636, 259);
            flpManualHistory.TabIndex = 10;
            flpManualHistory.WrapContents = false;
            // 
            // chkManualAnimatedEffect
            // 
            chkManualAnimatedEffect.BackColor = Color.Transparent;
            chkManualAnimatedEffect.CheckBoxColor = Color.BlueViolet;
            chkManualAnimatedEffect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualAnimatedEffect.ForeColor = Color.White;
            chkManualAnimatedEffect.Location = new Point(5, 510);
            chkManualAnimatedEffect.MinimumSize = new Size(1, 1);
            chkManualAnimatedEffect.Name = "chkManualAnimatedEffect";
            chkManualAnimatedEffect.Size = new Size(239, 25);
            chkManualAnimatedEffect.TabIndex = 78;
            chkManualAnimatedEffect.Text = "Добавить анимированный эффект:";
            // 
            // cmbManualAnimatedEffect
            // 
            cmbManualAnimatedEffect.DataSource = null;
            cmbManualAnimatedEffect.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualAnimatedEffect.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualAnimatedEffect.FillColor2 = Color.Transparent;
            cmbManualAnimatedEffect.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualAnimatedEffect.Font = new Font("Segoe UI", 9F);
            cmbManualAnimatedEffect.ForeColor = Color.White;
            cmbManualAnimatedEffect.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualAnimatedEffect.ItemForeColor = Color.White;
            cmbManualAnimatedEffect.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualAnimatedEffect.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualAnimatedEffect.Items.AddRange(new object[] { "Отменить выбор", "👍 Лайк", "👎 Дизлайк", "❤️ Сердце", "🔥 Огонь", "\U0001f970 Лицо с сердечками", "👏 Аплодисменты", "😁 Улыбка", "🤔 Задумчивость", "\U0001f92f Взрыв мозга", "😱 Крик от страха", "\U0001f92c Мат", "😢 Плач", "🎉 Праздник", "\U0001f929 Звёзды в глазах", "\U0001f92e Тошнота", "💩 Какашка", "🙏 Молитва", "👌 ОК", "🕊️ Голубь", "\U0001f91d Рукопожатие", "🍾 Бутылка", "🎂 Торт", "🎄 Ёлка", "🎆 Фейерверк", "🎇 Бенгальский огонь", "\U0001f9e8 Петарда", "✨ Искры", "🎈 Шарик", "🎊 Конфетти", "🎁 Подарок", "🏆 Трофей", "\U0001f947 Медаль", "⚽ Мяч", "🏀 Баскетбол", "🎯 Мишень", "🎲 Кубик", "🎰 Слот-машина", "🎳 Боулинг", "🍕 Пицца", "🍔 Бургер", "🍟 Картошка фри", "🍿 Попкорн", "☕ Кофе", "🍺 Пиво", "\U0001f942 Бокалы", "🚀 Ракета", "✈️ Самолёт", "🌟 Звезда", "💯 100 баллов", "🌈 Радуга", "☃️ Снеговик", "⛄ Снеговик", "🎃 Тыква", "🎅 Санта", "\U0001f936 Снегурочка", "🔔 Колокольчик", "🎵 Нота", "🎶 Ноты", "💤 Сон", "💣 Бомба", "💥 Столкновение", "💦 Капли", "💨 Ветер" });
            cmbManualAnimatedEffect.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualAnimatedEffect.ItemSelectForeColor = Color.White;
            cmbManualAnimatedEffect.Location = new Point(254, 510);
            cmbManualAnimatedEffect.Margin = new Padding(4, 5, 4, 5);
            cmbManualAnimatedEffect.MinimumSize = new Size(63, 0);
            cmbManualAnimatedEffect.Name = "cmbManualAnimatedEffect";
            cmbManualAnimatedEffect.Padding = new Padding(0, 0, 30, 2);
            cmbManualAnimatedEffect.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualAnimatedEffect.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualAnimatedEffect.Size = new Size(154, 25);
            cmbManualAnimatedEffect.Style = Sunny.UI.UIStyle.Custom;
            cmbManualAnimatedEffect.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualAnimatedEffect.SymbolSize = 24;
            cmbManualAnimatedEffect.TabIndex = 76;
            cmbManualAnimatedEffect.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualAnimatedEffect.Watermark = "Выберите эффект";
            // 
            // cmbManualEffectApplyTo
            // 
            cmbManualEffectApplyTo.DataSource = null;
            cmbManualEffectApplyTo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualEffectApplyTo.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualEffectApplyTo.FillColor2 = Color.Transparent;
            cmbManualEffectApplyTo.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualEffectApplyTo.Font = new Font("Segoe UI", 9F);
            cmbManualEffectApplyTo.ForeColor = Color.White;
            cmbManualEffectApplyTo.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualEffectApplyTo.ItemForeColor = Color.White;
            cmbManualEffectApplyTo.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualEffectApplyTo.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualEffectApplyTo.Items.AddRange(new object[] { "Отменить выбор", "Только на сообщение", "Только на шаблон", "На оба" });
            cmbManualEffectApplyTo.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualEffectApplyTo.ItemSelectForeColor = Color.White;
            cmbManualEffectApplyTo.Location = new Point(416, 510);
            cmbManualEffectApplyTo.Margin = new Padding(4, 5, 4, 5);
            cmbManualEffectApplyTo.MinimumSize = new Size(63, 0);
            cmbManualEffectApplyTo.Name = "cmbManualEffectApplyTo";
            cmbManualEffectApplyTo.Padding = new Padding(0, 0, 30, 2);
            cmbManualEffectApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualEffectApplyTo.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualEffectApplyTo.Size = new Size(244, 25);
            cmbManualEffectApplyTo.Style = Sunny.UI.UIStyle.Custom;
            cmbManualEffectApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualEffectApplyTo.SymbolSize = 24;
            cmbManualEffectApplyTo.TabIndex = 79;
            cmbManualEffectApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualEffectApplyTo.Watermark = "Применить на";
            // 
            // chkManualAnimatedEmoji
            // 
            chkManualAnimatedEmoji.BackColor = Color.Transparent;
            chkManualAnimatedEmoji.CheckBoxColor = Color.BlueViolet;
            chkManualAnimatedEmoji.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualAnimatedEmoji.ForeColor = Color.White;
            chkManualAnimatedEmoji.Location = new Point(5, 480);
            chkManualAnimatedEmoji.MinimumSize = new Size(1, 1);
            chkManualAnimatedEmoji.Name = "chkManualAnimatedEmoji";
            chkManualAnimatedEmoji.Size = new Size(239, 25);
            chkManualAnimatedEmoji.TabIndex = 77;
            chkManualAnimatedEmoji.Text = "Добавить анимированный смайлик:";
            // 
            // cmbManualAnimatedEmoji
            // 
            cmbManualAnimatedEmoji.DataSource = null;
            cmbManualAnimatedEmoji.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualAnimatedEmoji.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualAnimatedEmoji.FillColor2 = Color.Transparent;
            cmbManualAnimatedEmoji.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualAnimatedEmoji.Font = new Font("Segoe UI", 9F);
            cmbManualAnimatedEmoji.ForeColor = Color.White;
            cmbManualAnimatedEmoji.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualAnimatedEmoji.ItemForeColor = Color.White;
            cmbManualAnimatedEmoji.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualAnimatedEmoji.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualAnimatedEmoji.Items.AddRange(new object[] { "Отменить выбор", "👍 Лайк", "👎 Дизлайк", "❤️ Сердце", "🔥 Огонь", "\U0001f970 Лицо с сердечками", "👏 Аплодисменты", "😁 Улыбка", "🤔 Задумчивость", "\U0001f92f Взрыв мозга", "😱 Крик от страха", "\U0001f92c Мат", "😢 Плач", "🎉 Праздник", "\U0001f929 Звёзды в глазах", "\U0001f92e Тошнота", "💩 Какашка", "🙏 Молитва", "👌 ОК", "🕊️ Голубь", "\U0001f91d Рукопожатие", "🍾 Бутылка", "🎂 Торт", "🎄 Ёлка", "🎆 Фейерверк", "🎇 Бенгальский огонь", "\U0001f9e8 Петарда", "✨ Искры", "🎈 Шарик", "🎊 Конфетти", "🎁 Подарок", "🏆 Трофей", "\U0001f947 Медаль", "⚽ Мяч", "🏀 Баскетбол", "🎯 Мишень", "🎲 Кубик", "🎰 Слот-машина", "🎳 Боулинг", "🍕 Пицца", "🍔 Бургер", "🍟 Картошка фри", "🍿 Попкорн", "☕ Кофе", "🍺 Пиво", "\U0001f942 Бокалы", "🚀 Ракета", "✈️ Самолёт", "🌟 Звезда", "💯 100 баллов", "🌈 Радуга", "☃️ Снеговик", "⛄ Снеговик", "🎃 Тыква", "🎅 Санта", "\U0001f936 Снегурочка", "🔔 Колокольчик", "🎵 Нота", "🎶 Ноты", "💤 Сон", "💣 Бомба", "💥 Столкновение", "💦 Капли", "💨 Ветер" });
            cmbManualAnimatedEmoji.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualAnimatedEmoji.ItemSelectForeColor = Color.White;
            cmbManualAnimatedEmoji.Location = new Point(254, 480);
            cmbManualAnimatedEmoji.Margin = new Padding(4, 5, 4, 5);
            cmbManualAnimatedEmoji.MinimumSize = new Size(63, 0);
            cmbManualAnimatedEmoji.Name = "cmbManualAnimatedEmoji";
            cmbManualAnimatedEmoji.Padding = new Padding(0, 0, 30, 2);
            cmbManualAnimatedEmoji.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualAnimatedEmoji.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualAnimatedEmoji.Size = new Size(154, 25);
            cmbManualAnimatedEmoji.Style = Sunny.UI.UIStyle.Custom;
            cmbManualAnimatedEmoji.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualAnimatedEmoji.SymbolSize = 24;
            cmbManualAnimatedEmoji.TabIndex = 75;
            cmbManualAnimatedEmoji.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualAnimatedEmoji.Watermark = "Выберите смайлик";
            // 
            // cmbManualEmojiApplyTo
            // 
            cmbManualEmojiApplyTo.DataSource = null;
            cmbManualEmojiApplyTo.DropDownAutoWidth = true;
            cmbManualEmojiApplyTo.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualEmojiApplyTo.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualEmojiApplyTo.FillColor2 = Color.Transparent;
            cmbManualEmojiApplyTo.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualEmojiApplyTo.Font = new Font("Segoe UI", 9F);
            cmbManualEmojiApplyTo.ForeColor = Color.White;
            cmbManualEmojiApplyTo.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualEmojiApplyTo.ItemForeColor = Color.White;
            cmbManualEmojiApplyTo.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualEmojiApplyTo.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualEmojiApplyTo.Items.AddRange(new object[] { "Отменить выбор", "После пользовательского сообщения", "После шаблона", "После всех сообщений", "Перед всеми сообщениями", "После каждого сообщения" });
            cmbManualEmojiApplyTo.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualEmojiApplyTo.ItemSelectForeColor = Color.White;
            cmbManualEmojiApplyTo.Location = new Point(416, 480);
            cmbManualEmojiApplyTo.Margin = new Padding(4, 5, 4, 5);
            cmbManualEmojiApplyTo.MinimumSize = new Size(63, 0);
            cmbManualEmojiApplyTo.Name = "cmbManualEmojiApplyTo";
            cmbManualEmojiApplyTo.Padding = new Padding(0, 0, 30, 2);
            cmbManualEmojiApplyTo.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualEmojiApplyTo.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualEmojiApplyTo.Size = new Size(244, 25);
            cmbManualEmojiApplyTo.Style = Sunny.UI.UIStyle.Custom;
            cmbManualEmojiApplyTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualEmojiApplyTo.SymbolSize = 24;
            cmbManualEmojiApplyTo.TabIndex = 80;
            cmbManualEmojiApplyTo.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualEmojiApplyTo.Watermark = "Отправить после";
            // 
            // cmbManualPinTarget
            // 
            cmbManualPinTarget.DataSource = null;
            cmbManualPinTarget.DropDownAutoWidth = true;
            cmbManualPinTarget.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualPinTarget.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualPinTarget.FillColor2 = Color.Transparent;
            cmbManualPinTarget.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualPinTarget.Font = new Font("Segoe UI", 9F);
            cmbManualPinTarget.ForeColor = Color.White;
            cmbManualPinTarget.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualPinTarget.ItemForeColor = Color.White;
            cmbManualPinTarget.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualPinTarget.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualPinTarget.Items.AddRange(new object[] { "Отменить выбор", "Закрепить только шаблон", "Закрепить только текст", "Закрепить оба (сначала шаблон, потом текст)", "Закрепить оба (сначала текст, потом шаблон)" });
            cmbManualPinTarget.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualPinTarget.ItemSelectForeColor = Color.White;
            cmbManualPinTarget.Location = new Point(103, 442);
            cmbManualPinTarget.Margin = new Padding(4, 5, 4, 5);
            cmbManualPinTarget.MinimumSize = new Size(63, 0);
            cmbManualPinTarget.Name = "cmbManualPinTarget";
            cmbManualPinTarget.Padding = new Padding(0, 0, 30, 2);
            cmbManualPinTarget.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualPinTarget.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualPinTarget.Size = new Size(364, 25);
            cmbManualPinTarget.Style = Sunny.UI.UIStyle.Custom;
            cmbManualPinTarget.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualPinTarget.SymbolSize = 24;
            cmbManualPinTarget.TabIndex = 76;
            cmbManualPinTarget.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualPinTarget.Watermark = "Выберите что закрепить";
            // 
            // chkManualPinMessage
            // 
            chkManualPinMessage.BackColor = Color.Transparent;
            chkManualPinMessage.CheckBoxColor = Color.BlueViolet;
            chkManualPinMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualPinMessage.ForeColor = Color.White;
            chkManualPinMessage.Location = new Point(5, 442);
            chkManualPinMessage.MinimumSize = new Size(1, 1);
            chkManualPinMessage.Name = "chkManualPinMessage";
            chkManualPinMessage.Size = new Size(95, 25);
            chkManualPinMessage.TabIndex = 108;
            chkManualPinMessage.Text = "Закрепить:";
            // 
            // chkManualDeletePrevious
            // 
            chkManualDeletePrevious.BackColor = Color.Transparent;
            chkManualDeletePrevious.CheckBoxColor = Color.BlueViolet;
            chkManualDeletePrevious.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualDeletePrevious.ForeColor = Color.White;
            chkManualDeletePrevious.Location = new Point(5, 408);
            chkManualDeletePrevious.MinimumSize = new Size(1, 1);
            chkManualDeletePrevious.Name = "chkManualDeletePrevious";
            chkManualDeletePrevious.Size = new Size(346, 25);
            chkManualDeletePrevious.TabIndex = 110;
            chkManualDeletePrevious.Text = "Удалить предыдущее сообщение бота перед отправкой";
            // 
            // chkManualProtectContent
            // 
            chkManualProtectContent.BackColor = Color.Transparent;
            chkManualProtectContent.CheckBoxColor = Color.BlueViolet;
            chkManualProtectContent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualProtectContent.ForeColor = Color.White;
            chkManualProtectContent.Location = new Point(282, 377);
            chkManualProtectContent.MinimumSize = new Size(1, 1);
            chkManualProtectContent.Name = "chkManualProtectContent";
            chkManualProtectContent.Size = new Size(346, 25);
            chkManualProtectContent.TabIndex = 107;
            chkManualProtectContent.Text = "Защитить от копирования и пересылки";
            // 
            // chkManualHideSpoiler
            // 
            chkManualHideSpoiler.BackColor = Color.Transparent;
            chkManualHideSpoiler.CheckBoxColor = Color.BlueViolet;
            chkManualHideSpoiler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualHideSpoiler.ForeColor = Color.White;
            chkManualHideSpoiler.Location = new Point(5, 377);
            chkManualHideSpoiler.MinimumSize = new Size(1, 1);
            chkManualHideSpoiler.Name = "chkManualHideSpoiler";
            chkManualHideSpoiler.Size = new Size(264, 25);
            chkManualHideSpoiler.TabIndex = 109;
            chkManualHideSpoiler.Text = "Скрыть содержимое как спойлер";
            // 
            // chkManualReplyToLast
            // 
            chkManualReplyToLast.BackColor = Color.Transparent;
            chkManualReplyToLast.CheckBoxColor = Color.BlueViolet;
            chkManualReplyToLast.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualReplyToLast.ForeColor = Color.White;
            chkManualReplyToLast.Location = new Point(282, 347);
            chkManualReplyToLast.MinimumSize = new Size(1, 1);
            chkManualReplyToLast.Name = "chkManualReplyToLast";
            chkManualReplyToLast.Size = new Size(346, 25);
            chkManualReplyToLast.TabIndex = 106;
            chkManualReplyToLast.Text = "Ответить на последнее сообщение (Reply)";
            // 
            // chkManualSilentSend
            // 
            chkManualSilentSend.BackColor = Color.Transparent;
            chkManualSilentSend.CheckBoxColor = Color.BlueViolet;
            chkManualSilentSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualSilentSend.ForeColor = Color.White;
            chkManualSilentSend.Location = new Point(5, 347);
            chkManualSilentSend.MinimumSize = new Size(1, 1);
            chkManualSilentSend.Name = "chkManualSilentSend";
            chkManualSilentSend.Size = new Size(264, 25);
            chkManualSilentSend.TabIndex = 105;
            chkManualSilentSend.Text = "Тихая отправка (без звука)";
            // 
            // chkManualDisablePreview
            // 
            chkManualDisablePreview.BackColor = Color.Transparent;
            chkManualDisablePreview.CheckBoxColor = Color.BlueViolet;
            chkManualDisablePreview.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualDisablePreview.ForeColor = Color.White;
            chkManualDisablePreview.Location = new Point(282, 317);
            chkManualDisablePreview.MinimumSize = new Size(1, 1);
            chkManualDisablePreview.Name = "chkManualDisablePreview";
            chkManualDisablePreview.Size = new Size(346, 25);
            chkManualDisablePreview.TabIndex = 104;
            chkManualDisablePreview.Text = "Отключить предпросмотр ссылок";
            // 
            // chkManualSendTemplateFirst
            // 
            chkManualSendTemplateFirst.BackColor = Color.Transparent;
            chkManualSendTemplateFirst.CheckBoxColor = Color.BlueViolet;
            chkManualSendTemplateFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualSendTemplateFirst.ForeColor = Color.White;
            chkManualSendTemplateFirst.Location = new Point(5, 317);
            chkManualSendTemplateFirst.MinimumSize = new Size(1, 1);
            chkManualSendTemplateFirst.Name = "chkManualSendTemplateFirst";
            chkManualSendTemplateFirst.Size = new Size(264, 25);
            chkManualSendTemplateFirst.TabIndex = 103;
            chkManualSendTemplateFirst.Text = "Отправить первым шаблон";
            // 
            // chkManualNotifyError
            // 
            chkManualNotifyError.BackColor = Color.Transparent;
            chkManualNotifyError.CheckBoxColor = Color.BlueViolet;
            chkManualNotifyError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualNotifyError.ForeColor = Color.White;
            chkManualNotifyError.Location = new Point(5, 275);
            chkManualNotifyError.MinimumSize = new Size(1, 1);
            chkManualNotifyError.Name = "chkManualNotifyError";
            chkManualNotifyError.Size = new Size(265, 25);
            chkManualNotifyError.TabIndex = 99;
            chkManualNotifyError.Text = "Уведомлять любую ошибку в:";
            // 
            // cmbManualNotifyError1
            // 
            cmbManualNotifyError1.DataSource = null;
            cmbManualNotifyError1.DropDownAutoWidth = true;
            cmbManualNotifyError1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualNotifyError1.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyError1.FillColor2 = Color.Transparent;
            cmbManualNotifyError1.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualNotifyError1.Font = new Font("Segoe UI", 9F);
            cmbManualNotifyError1.ForeColor = Color.White;
            cmbManualNotifyError1.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyError1.ItemForeColor = Color.White;
            cmbManualNotifyError1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyError1.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualNotifyError1.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            cmbManualNotifyError1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyError1.ItemSelectForeColor = Color.White;
            cmbManualNotifyError1.Location = new Point(276, 275);
            cmbManualNotifyError1.Margin = new Padding(4, 5, 4, 5);
            cmbManualNotifyError1.MinimumSize = new Size(63, 0);
            cmbManualNotifyError1.Name = "cmbManualNotifyError1";
            cmbManualNotifyError1.Padding = new Padding(0, 0, 30, 2);
            cmbManualNotifyError1.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualNotifyError1.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualNotifyError1.Size = new Size(146, 25);
            cmbManualNotifyError1.Style = Sunny.UI.UIStyle.Custom;
            cmbManualNotifyError1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualNotifyError1.SymbolSize = 24;
            cmbManualNotifyError1.TabIndex = 97;
            cmbManualNotifyError1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualNotifyError1.Watermark = "Куда отправить";
            // 
            // lblManualNotifyErrorOr
            // 
            lblManualNotifyErrorOr.AutoSize = true;
            lblManualNotifyErrorOr.BackColor = Color.Transparent;
            lblManualNotifyErrorOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblManualNotifyErrorOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblManualNotifyErrorOr.Location = new Point(428, 280);
            lblManualNotifyErrorOr.Name = "lblManualNotifyErrorOr";
            lblManualNotifyErrorOr.Size = new Size(39, 13);
            lblManualNotifyErrorOr.TabIndex = 102;
            lblManualNotifyErrorOr.Text = "и/или";
            // 
            // cmbManualNotifyError2
            // 
            cmbManualNotifyError2.DataSource = null;
            cmbManualNotifyError2.DropDownAutoWidth = true;
            cmbManualNotifyError2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualNotifyError2.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyError2.FillColor2 = Color.Transparent;
            cmbManualNotifyError2.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualNotifyError2.Font = new Font("Segoe UI", 9F);
            cmbManualNotifyError2.ForeColor = Color.White;
            cmbManualNotifyError2.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyError2.ItemForeColor = Color.White;
            cmbManualNotifyError2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyError2.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualNotifyError2.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            cmbManualNotifyError2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyError2.ItemSelectForeColor = Color.White;
            cmbManualNotifyError2.Location = new Point(475, 275);
            cmbManualNotifyError2.Margin = new Padding(4, 5, 4, 5);
            cmbManualNotifyError2.MinimumSize = new Size(63, 0);
            cmbManualNotifyError2.Name = "cmbManualNotifyError2";
            cmbManualNotifyError2.Padding = new Padding(0, 0, 30, 2);
            cmbManualNotifyError2.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualNotifyError2.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualNotifyError2.Size = new Size(146, 25);
            cmbManualNotifyError2.Style = Sunny.UI.UIStyle.Custom;
            cmbManualNotifyError2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualNotifyError2.SymbolSize = 24;
            cmbManualNotifyError2.TabIndex = 98;
            cmbManualNotifyError2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualNotifyError2.Watermark = "Куда отправить";
            // 
            // chkManualNotifyComplete
            // 
            chkManualNotifyComplete.BackColor = Color.Transparent;
            chkManualNotifyComplete.CheckBoxColor = Color.BlueViolet;
            chkManualNotifyComplete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualNotifyComplete.ForeColor = Color.White;
            chkManualNotifyComplete.Location = new Point(5, 245);
            chkManualNotifyComplete.MinimumSize = new Size(1, 1);
            chkManualNotifyComplete.Name = "chkManualNotifyComplete";
            chkManualNotifyComplete.Size = new Size(265, 25);
            chkManualNotifyComplete.TabIndex = 92;
            chkManualNotifyComplete.Text = "Уведомить при завершении сессии в:";
            // 
            // cmbManualNotifyComplete1
            // 
            cmbManualNotifyComplete1.DataSource = null;
            cmbManualNotifyComplete1.DropDownAutoWidth = true;
            cmbManualNotifyComplete1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualNotifyComplete1.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyComplete1.FillColor2 = Color.Transparent;
            cmbManualNotifyComplete1.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualNotifyComplete1.Font = new Font("Segoe UI", 9F);
            cmbManualNotifyComplete1.ForeColor = Color.White;
            cmbManualNotifyComplete1.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyComplete1.ItemForeColor = Color.White;
            cmbManualNotifyComplete1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyComplete1.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualNotifyComplete1.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            cmbManualNotifyComplete1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyComplete1.ItemSelectForeColor = Color.White;
            cmbManualNotifyComplete1.Location = new Point(276, 245);
            cmbManualNotifyComplete1.Margin = new Padding(4, 5, 4, 5);
            cmbManualNotifyComplete1.MinimumSize = new Size(63, 0);
            cmbManualNotifyComplete1.Name = "cmbManualNotifyComplete1";
            cmbManualNotifyComplete1.Padding = new Padding(0, 0, 30, 2);
            cmbManualNotifyComplete1.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualNotifyComplete1.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualNotifyComplete1.Size = new Size(146, 25);
            cmbManualNotifyComplete1.Style = Sunny.UI.UIStyle.Custom;
            cmbManualNotifyComplete1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualNotifyComplete1.SymbolSize = 24;
            cmbManualNotifyComplete1.TabIndex = 94;
            cmbManualNotifyComplete1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualNotifyComplete1.Watermark = "Куда отправить";
            // 
            // lblManualNotifyCompleteOr
            // 
            lblManualNotifyCompleteOr.AutoSize = true;
            lblManualNotifyCompleteOr.BackColor = Color.Transparent;
            lblManualNotifyCompleteOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblManualNotifyCompleteOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblManualNotifyCompleteOr.Location = new Point(428, 250);
            lblManualNotifyCompleteOr.Name = "lblManualNotifyCompleteOr";
            lblManualNotifyCompleteOr.Size = new Size(39, 13);
            lblManualNotifyCompleteOr.TabIndex = 101;
            lblManualNotifyCompleteOr.Text = "и/или";
            // 
            // cmbManualNotifyComplete2
            // 
            cmbManualNotifyComplete2.DataSource = null;
            cmbManualNotifyComplete2.DropDownAutoWidth = true;
            cmbManualNotifyComplete2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualNotifyComplete2.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyComplete2.FillColor2 = Color.Transparent;
            cmbManualNotifyComplete2.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualNotifyComplete2.Font = new Font("Segoe UI", 9F);
            cmbManualNotifyComplete2.ForeColor = Color.White;
            cmbManualNotifyComplete2.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifyComplete2.ItemForeColor = Color.White;
            cmbManualNotifyComplete2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyComplete2.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualNotifyComplete2.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            cmbManualNotifyComplete2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifyComplete2.ItemSelectForeColor = Color.White;
            cmbManualNotifyComplete2.Location = new Point(475, 245);
            cmbManualNotifyComplete2.Margin = new Padding(4, 5, 4, 5);
            cmbManualNotifyComplete2.MinimumSize = new Size(63, 0);
            cmbManualNotifyComplete2.Name = "cmbManualNotifyComplete2";
            cmbManualNotifyComplete2.Padding = new Padding(0, 0, 30, 2);
            cmbManualNotifyComplete2.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualNotifyComplete2.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualNotifyComplete2.Size = new Size(146, 25);
            cmbManualNotifyComplete2.Style = Sunny.UI.UIStyle.Custom;
            cmbManualNotifyComplete2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualNotifyComplete2.SymbolSize = 24;
            cmbManualNotifyComplete2.TabIndex = 96;
            cmbManualNotifyComplete2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualNotifyComplete2.Watermark = "Куда отправить";
            // 
            // chkManualNotifySuccess
            // 
            chkManualNotifySuccess.BackColor = Color.Transparent;
            chkManualNotifySuccess.CheckBoxColor = Color.BlueViolet;
            chkManualNotifySuccess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            chkManualNotifySuccess.ForeColor = Color.White;
            chkManualNotifySuccess.Location = new Point(5, 215);
            chkManualNotifySuccess.MinimumSize = new Size(1, 1);
            chkManualNotifySuccess.Name = "chkManualNotifySuccess";
            chkManualNotifySuccess.Size = new Size(265, 25);
            chkManualNotifySuccess.TabIndex = 91;
            chkManualNotifySuccess.Text = "Уведомлять все успешные отправки в:";
            // 
            // cmbManualNotifySuccess1
            // 
            cmbManualNotifySuccess1.DataSource = null;
            cmbManualNotifySuccess1.DropDownAutoWidth = true;
            cmbManualNotifySuccess1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualNotifySuccess1.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifySuccess1.FillColor2 = Color.Transparent;
            cmbManualNotifySuccess1.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualNotifySuccess1.Font = new Font("Segoe UI", 9F);
            cmbManualNotifySuccess1.ForeColor = Color.White;
            cmbManualNotifySuccess1.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifySuccess1.ItemForeColor = Color.White;
            cmbManualNotifySuccess1.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifySuccess1.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualNotifySuccess1.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            cmbManualNotifySuccess1.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifySuccess1.ItemSelectForeColor = Color.White;
            cmbManualNotifySuccess1.Location = new Point(276, 215);
            cmbManualNotifySuccess1.Margin = new Padding(4, 5, 4, 5);
            cmbManualNotifySuccess1.MinimumSize = new Size(63, 0);
            cmbManualNotifySuccess1.Name = "cmbManualNotifySuccess1";
            cmbManualNotifySuccess1.Padding = new Padding(0, 0, 30, 2);
            cmbManualNotifySuccess1.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualNotifySuccess1.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualNotifySuccess1.Size = new Size(146, 25);
            cmbManualNotifySuccess1.Style = Sunny.UI.UIStyle.Custom;
            cmbManualNotifySuccess1.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualNotifySuccess1.SymbolSize = 24;
            cmbManualNotifySuccess1.TabIndex = 93;
            cmbManualNotifySuccess1.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualNotifySuccess1.Watermark = "Куда отправить";
            // 
            // lblManualNotifySuccessOr
            // 
            lblManualNotifySuccessOr.AutoSize = true;
            lblManualNotifySuccessOr.BackColor = Color.Transparent;
            lblManualNotifySuccessOr.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblManualNotifySuccessOr.ForeColor = Color.FromArgb(180, 180, 180);
            lblManualNotifySuccessOr.Location = new Point(428, 220);
            lblManualNotifySuccessOr.Name = "lblManualNotifySuccessOr";
            lblManualNotifySuccessOr.Size = new Size(39, 13);
            lblManualNotifySuccessOr.TabIndex = 100;
            lblManualNotifySuccessOr.Text = "и/или";
            // 
            // cmbManualNotifySuccess2
            // 
            cmbManualNotifySuccess2.DataSource = null;
            cmbManualNotifySuccess2.DropDownAutoWidth = true;
            cmbManualNotifySuccess2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualNotifySuccess2.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifySuccess2.FillColor2 = Color.Transparent;
            cmbManualNotifySuccess2.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualNotifySuccess2.Font = new Font("Segoe UI", 9F);
            cmbManualNotifySuccess2.ForeColor = Color.White;
            cmbManualNotifySuccess2.ItemFillColor = Color.FromArgb(42, 46, 57);
            cmbManualNotifySuccess2.ItemForeColor = Color.White;
            cmbManualNotifySuccess2.ItemHoverColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifySuccess2.ItemRectColor = Color.FromArgb(58, 63, 75);
            cmbManualNotifySuccess2.Items.AddRange(new object[] { "Отменить выбор", "В личные сообщения", "В приложении" });
            cmbManualNotifySuccess2.ItemSelectBackColor = Color.FromArgb(124, 58, 237);
            cmbManualNotifySuccess2.ItemSelectForeColor = Color.White;
            cmbManualNotifySuccess2.Location = new Point(475, 215);
            cmbManualNotifySuccess2.Margin = new Padding(4, 5, 4, 5);
            cmbManualNotifySuccess2.MinimumSize = new Size(63, 0);
            cmbManualNotifySuccess2.Name = "cmbManualNotifySuccess2";
            cmbManualNotifySuccess2.Padding = new Padding(0, 0, 30, 2);
            cmbManualNotifySuccess2.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualNotifySuccess2.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualNotifySuccess2.Size = new Size(146, 25);
            cmbManualNotifySuccess2.Style = Sunny.UI.UIStyle.Custom;
            cmbManualNotifySuccess2.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualNotifySuccess2.SymbolSize = 24;
            cmbManualNotifySuccess2.TabIndex = 95;
            cmbManualNotifySuccess2.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualNotifySuccess2.Watermark = "Куда отправить";
            // 
            // lblManualTemplateHint
            // 
            lblManualTemplateHint.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblManualTemplateHint.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            lblManualTemplateHint.ForeColor = Color.DarkGray;
            lblManualTemplateHint.Location = new Point(5, 69);
            lblManualTemplateHint.Name = "lblManualTemplateHint";
            lblManualTemplateHint.Size = new Size(658, 55);
            lblManualTemplateHint.TabIndex = 33;
            lblManualTemplateHint.Text = resources.GetString("lblManualTemplateHint.Text");
            // 
            // txtManualCustomText
            // 
            txtManualCustomText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtManualCustomText.ButtonFillColor = Color.Transparent;
            txtManualCustomText.ButtonStyleInherited = false;
            txtManualCustomText.FillColor = Color.FromArgb(42, 46, 57);
            txtManualCustomText.Font = new Font("Segoe UI", 9F);
            txtManualCustomText.ForeColor = Color.White;
            txtManualCustomText.Location = new Point(5, 40);
            txtManualCustomText.Margin = new Padding(4, 5, 4, 5);
            txtManualCustomText.MinimumSize = new Size(1, 16);
            txtManualCustomText.Name = "txtManualCustomText";
            txtManualCustomText.Padding = new Padding(5);
            txtManualCustomText.RectColor = Color.FromArgb(65, 71, 84);
            txtManualCustomText.RectDisableColor = Color.FromArgb(54, 59, 70);
            txtManualCustomText.RectReadOnlyColor = Color.Transparent;
            txtManualCustomText.ShowText = false;
            txtManualCustomText.Size = new Size(655, 25);
            txtManualCustomText.Style = Sunny.UI.UIStyle.Custom;
            txtManualCustomText.TabIndex = 32;
            txtManualCustomText.TextAlignment = ContentAlignment.MiddleLeft;
            txtManualCustomText.Watermark = "Пользовательское сообщение";
            // 
            // cmbManualTemplate
            // 
            cmbManualTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbManualTemplate.DataSource = null;
            cmbManualTemplate.DropDownAutoWidth = true;
            cmbManualTemplate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbManualTemplate.FillColor = Color.FromArgb(42, 46, 57);
            cmbManualTemplate.FillColor2 = Color.Transparent;
            cmbManualTemplate.FillDisableColor = Color.FromArgb(37, 40, 50);
            cmbManualTemplate.Font = new Font("Segoe UI", 9F);
            cmbManualTemplate.ForeColor = Color.White;
            cmbManualTemplate.ItemFillColor = Color.Indigo;
            cmbManualTemplate.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbManualTemplate.Items.AddRange(new object[] { "Отменить выбор" });
            cmbManualTemplate.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbManualTemplate.Location = new Point(5, 9);
            cmbManualTemplate.Margin = new Padding(4, 5, 4, 5);
            cmbManualTemplate.MinimumSize = new Size(63, 0);
            cmbManualTemplate.Name = "cmbManualTemplate";
            cmbManualTemplate.Padding = new Padding(0, 0, 30, 2);
            cmbManualTemplate.RectColor = Color.FromArgb(65, 71, 84);
            cmbManualTemplate.RectDisableColor = Color.FromArgb(54, 59, 70);
            cmbManualTemplate.Size = new Size(655, 25);
            cmbManualTemplate.Style = Sunny.UI.UIStyle.Custom;
            cmbManualTemplate.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbManualTemplate.SymbolSize = 24;
            cmbManualTemplate.TabIndex = 31;
            cmbManualTemplate.TextAlignment = ContentAlignment.MiddleLeft;
            cmbManualTemplate.Watermark = "Выберите шаблон сообщения";
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.FromArgb(30, 30, 36);
            toolTip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolTip1.ForeColor = Color.White;
            toolTip1.OwnerDraw = true;
            toolTip1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // ManualTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpManual);
            Name = "ManualTabControl";
            Size = new Size(696, 483);
            grpManual.ResumeLayout(false);
            pnlManualButtons.ResumeLayout(false);
            pnlManualInner.ResumeLayout(false);
            pnlManualContent.ResumeLayout(false);
            pnlManualContent.PerformLayout();
            grpManualHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Sunny.UI.UIGroupBox grpManual;
        private Sunny.UI.UIPanel pnlManualButtons;
        private Sunny.UI.UICheckBox chkManualConfirm;
        private Sunny.UI.UIButton btnSaveManual;
        private Sunny.UI.UIButton btnSendManual;
        private Panel pnlManualInner;
        private Panel pnlManualContent;

        // Message Section
        private Sunny.UI.UIComboBox cmbManualTemplate;
        private Sunny.UI.UITextBox txtManualCustomText;
        private Label lblManualTemplateHint;

        // Notifications
        private Sunny.UI.UICheckBox chkManualNotifySuccess;
        private Sunny.UI.UIComboBox cmbManualNotifySuccess1;
        private Label lblManualNotifySuccessOr;
        private Sunny.UI.UIComboBox cmbManualNotifySuccess2;
        private Sunny.UI.UICheckBox chkManualNotifyComplete;
        private Sunny.UI.UIComboBox cmbManualNotifyComplete1;
        private Label lblManualNotifyCompleteOr;
        private Sunny.UI.UIComboBox cmbManualNotifyComplete2;
        private Sunny.UI.UICheckBox chkManualNotifyError;
        private Sunny.UI.UIComboBox cmbManualNotifyError1;
        private Label lblManualNotifyErrorOr;
        private Sunny.UI.UIComboBox cmbManualNotifyError2;

        // Advanced Options
        private Sunny.UI.UICheckBox chkManualSendTemplateFirst;
        private Sunny.UI.UICheckBox chkManualDisablePreview;
        private Sunny.UI.UICheckBox chkManualSilentSend;
        private Sunny.UI.UICheckBox chkManualReplyToLast;
        private Sunny.UI.UICheckBox chkManualHideSpoiler;
        private Sunny.UI.UICheckBox chkManualProtectContent;
        private Sunny.UI.UICheckBox chkManualDeletePrevious;

        // Pin Message
        private Sunny.UI.UICheckBox chkManualPinMessage;
        private Sunny.UI.UIComboBox cmbManualPinTarget;

        // Animated Elements
        private Sunny.UI.UICheckBox chkManualAnimatedEmoji;
        private Sunny.UI.UIComboBox cmbManualAnimatedEmoji;
        private Sunny.UI.UIComboBox cmbManualEmojiApplyTo;
        private Sunny.UI.UICheckBox chkManualAnimatedEffect;
        private Sunny.UI.UIComboBox cmbManualAnimatedEffect;
        private Sunny.UI.UIComboBox cmbManualEffectApplyTo;

        // History
        private Sunny.UI.UIGroupBox grpManualHistory;
        private FlowLayoutPanel flpManualHistory;
        private Sunny.UI.UICheckBox chkManualAutoDelete;
        private Sunny.UI.UICheckBox chkManualDelay;
        private Sunny.UI.UIIntegerUpDown nudManualAutoDeleteMinutes;
        private Sunny.UI.UIIntegerUpDown nudManualAutoDeleteSeconds;
        private Sunny.UI.UIIntegerUpDown nudManualDelayMinutes;
        private Sunny.UI.UIIntegerUpDown nudManualDelaySeconds;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Sunny.UI.UIToolTip toolTip1;
    }
}