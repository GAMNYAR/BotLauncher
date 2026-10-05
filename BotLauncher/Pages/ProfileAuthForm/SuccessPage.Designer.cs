namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class SuccessPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessPage));
            lblSuccessTitle = new Label();
            picSuccessIcon = new PictureBox();
            pnlProfileInfo = new Sunny.UI.UIPanel();
            lblProfileInfoLabel = new Label();
            lblProfileInfoValue = new Label();
            lblBotInfoLabel = new Label();
            lblBotUsernameValue = new Label();
            lblBotNameLabel = new Label();
            lblBotNameValue = new Label();
            lblBotIdLabel = new Label();
            lblBotIdValue = new Label();
            lblCreatedAtLabel = new Label();
            lblCreatedAtValue = new Label();
            btnRememberInfo = new Sunny.UI.UIButton();
            chkRememberMe = new Sunny.UI.UICheckBox();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            btnLaunchBotLauncher = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)picSuccessIcon).BeginInit();
            pnlProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblSuccessTitle
            // 
            lblSuccessTitle.Anchor = AnchorStyles.Top;
            lblSuccessTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSuccessTitle.ForeColor = Color.White;
            lblSuccessTitle.Location = new Point(122, 288);
            lblSuccessTitle.Margin = new Padding(5);
            lblSuccessTitle.Name = "lblSuccessTitle";
            lblSuccessTitle.Size = new Size(336, 38);
            lblSuccessTitle.TabIndex = 16;
            lblSuccessTitle.Text = "Профиль успешно создан!";
            lblSuccessTitle.TextAlign = ContentAlignment.TopCenter;
            lblSuccessTitle.UseCompatibleTextRendering = true;
            // 
            // picSuccessIcon
            // 
            picSuccessIcon.Anchor = AnchorStyles.Top;
            picSuccessIcon.BackgroundImage = (Image)resources.GetObject("picSuccessIcon.BackgroundImage");
            picSuccessIcon.BackgroundImageLayout = ImageLayout.Stretch;
            picSuccessIcon.Location = new Point(213, 136);
            picSuccessIcon.Margin = new Padding(10);
            picSuccessIcon.Name = "picSuccessIcon";
            picSuccessIcon.Size = new Size(150, 150);
            picSuccessIcon.TabIndex = 15;
            picSuccessIcon.TabStop = false;
            // 
            // pnlProfileInfo
            // 
            pnlProfileInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlProfileInfo.Controls.Add(lblProfileInfoLabel);
            pnlProfileInfo.Controls.Add(lblProfileInfoValue);
            pnlProfileInfo.Controls.Add(lblBotInfoLabel);
            pnlProfileInfo.Controls.Add(lblBotUsernameValue);
            pnlProfileInfo.Controls.Add(lblBotNameLabel);
            pnlProfileInfo.Controls.Add(lblBotNameValue);
            pnlProfileInfo.Controls.Add(lblBotIdLabel);
            pnlProfileInfo.Controls.Add(lblBotIdValue);
            pnlProfileInfo.Controls.Add(lblCreatedAtLabel);
            pnlProfileInfo.Controls.Add(lblCreatedAtValue);
            pnlProfileInfo.FillColor = Color.FromArgb(34, 36, 44);
            pnlProfileInfo.FillColor2 = Color.Transparent;
            pnlProfileInfo.FillDisableColor = Color.Transparent;
            pnlProfileInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlProfileInfo.ForeColor = Color.Transparent;
            pnlProfileInfo.ForeDisableColor = Color.Transparent;
            pnlProfileInfo.Location = new Point(67, 336);
            pnlProfileInfo.Margin = new Padding(4, 5, 4, 5);
            pnlProfileInfo.MinimumSize = new Size(1, 1);
            pnlProfileInfo.Name = "pnlProfileInfo";
            pnlProfileInfo.Padding = new Padding(10);
            pnlProfileInfo.Radius = 10;
            pnlProfileInfo.RectColor = Color.FromArgb(42, 45, 54);
            pnlProfileInfo.RectDisableColor = Color.Transparent;
            pnlProfileInfo.Size = new Size(446, 140);
            pnlProfileInfo.TabIndex = 43;
            pnlProfileInfo.Text = null;
            pnlProfileInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblProfileInfoLabel
            // 
            lblProfileInfoLabel.BackColor = Color.Transparent;
            lblProfileInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblProfileInfoLabel.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblProfileInfoLabel.Location = new Point(17, 8);
            lblProfileInfoLabel.Name = "lblProfileInfoLabel";
            lblProfileInfoLabel.RightToLeft = RightToLeft.No;
            lblProfileInfoLabel.Size = new Size(107, 25);
            lblProfileInfoLabel.TabIndex = 45;
            lblProfileInfoLabel.Text = "Профиль:";
            lblProfileInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfileInfoValue
            // 
            lblProfileInfoValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProfileInfoValue.AutoEllipsis = true;
            lblProfileInfoValue.BackColor = Color.Transparent;
            lblProfileInfoValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblProfileInfoValue.ForeColor = Color.LightGray;
            lblProfileInfoValue.Location = new Point(126, 8);
            lblProfileInfoValue.Name = "lblProfileInfoValue";
            lblProfileInfoValue.RightToLeft = RightToLeft.No;
            lblProfileInfoValue.Size = new Size(303, 25);
            lblProfileInfoValue.TabIndex = 49;
            lblProfileInfoValue.Text = "Название профиля";
            lblProfileInfoValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotInfoLabel
            // 
            lblBotInfoLabel.BackColor = Color.Transparent;
            lblBotInfoLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBotInfoLabel.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblBotInfoLabel.Location = new Point(17, 33);
            lblBotInfoLabel.Name = "lblBotInfoLabel";
            lblBotInfoLabel.RightToLeft = RightToLeft.No;
            lblBotInfoLabel.Size = new Size(107, 25);
            lblBotInfoLabel.TabIndex = 46;
            lblBotInfoLabel.Text = "Бот:";
            lblBotInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotUsernameValue
            // 
            lblBotUsernameValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotUsernameValue.AutoEllipsis = true;
            lblBotUsernameValue.BackColor = Color.Transparent;
            lblBotUsernameValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBotUsernameValue.ForeColor = Color.LightGray;
            lblBotUsernameValue.Location = new Point(126, 33);
            lblBotUsernameValue.Name = "lblBotUsernameValue";
            lblBotUsernameValue.RightToLeft = RightToLeft.No;
            lblBotUsernameValue.Size = new Size(303, 25);
            lblBotUsernameValue.TabIndex = 50;
            lblBotUsernameValue.Text = "@Username";
            lblBotUsernameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotNameLabel
            // 
            lblBotNameLabel.BackColor = Color.Transparent;
            lblBotNameLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBotNameLabel.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblBotNameLabel.Location = new Point(17, 58);
            lblBotNameLabel.Name = "lblBotNameLabel";
            lblBotNameLabel.RightToLeft = RightToLeft.No;
            lblBotNameLabel.Size = new Size(107, 25);
            lblBotNameLabel.TabIndex = 53;
            lblBotNameLabel.Text = "Название:";
            lblBotNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotNameValue
            // 
            lblBotNameValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotNameValue.AutoEllipsis = true;
            lblBotNameValue.BackColor = Color.Transparent;
            lblBotNameValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBotNameValue.ForeColor = Color.LightGray;
            lblBotNameValue.Location = new Point(126, 58);
            lblBotNameValue.Name = "lblBotNameValue";
            lblBotNameValue.RightToLeft = RightToLeft.No;
            lblBotNameValue.Size = new Size(303, 25);
            lblBotNameValue.TabIndex = 54;
            lblBotNameValue.Text = "Название бота";
            lblBotNameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotIdLabel
            // 
            lblBotIdLabel.BackColor = Color.Transparent;
            lblBotIdLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBotIdLabel.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblBotIdLabel.Location = new Point(17, 83);
            lblBotIdLabel.Name = "lblBotIdLabel";
            lblBotIdLabel.RightToLeft = RightToLeft.No;
            lblBotIdLabel.Size = new Size(107, 25);
            lblBotIdLabel.TabIndex = 47;
            lblBotIdLabel.Text = "Bot ID:";
            lblBotIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotIdValue
            // 
            lblBotIdValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotIdValue.AutoEllipsis = true;
            lblBotIdValue.BackColor = Color.Transparent;
            lblBotIdValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBotIdValue.ForeColor = Color.LightGray;
            lblBotIdValue.Location = new Point(126, 83);
            lblBotIdValue.Name = "lblBotIdValue";
            lblBotIdValue.RightToLeft = RightToLeft.No;
            lblBotIdValue.Size = new Size(303, 25);
            lblBotIdValue.TabIndex = 51;
            lblBotIdValue.Text = "1234567890";
            lblBotIdValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCreatedAtLabel
            // 
            lblCreatedAtLabel.BackColor = Color.Transparent;
            lblCreatedAtLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCreatedAtLabel.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblCreatedAtLabel.Location = new Point(17, 108);
            lblCreatedAtLabel.Name = "lblCreatedAtLabel";
            lblCreatedAtLabel.RightToLeft = RightToLeft.No;
            lblCreatedAtLabel.Size = new Size(107, 25);
            lblCreatedAtLabel.TabIndex = 48;
            lblCreatedAtLabel.Text = "Дата создания:";
            lblCreatedAtLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCreatedAtValue
            // 
            lblCreatedAtValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCreatedAtValue.AutoEllipsis = true;
            lblCreatedAtValue.BackColor = Color.Transparent;
            lblCreatedAtValue.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCreatedAtValue.ForeColor = Color.LightGray;
            lblCreatedAtValue.Location = new Point(126, 108);
            lblCreatedAtValue.Name = "lblCreatedAtValue";
            lblCreatedAtValue.RightToLeft = RightToLeft.No;
            lblCreatedAtValue.Size = new Size(303, 25);
            lblCreatedAtValue.TabIndex = 52;
            lblCreatedAtValue.Text = "00.00.0000 00:00";
            lblCreatedAtValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRememberInfo
            // 
            btnRememberInfo.BackColor = Color.Transparent;
            btnRememberInfo.BackgroundImage = (Image)resources.GetObject("btnRememberInfo.BackgroundImage");
            btnRememberInfo.BackgroundImageLayout = ImageLayout.Zoom;
            btnRememberInfo.FillColor = Color.Transparent;
            btnRememberInfo.FillColor2 = Color.Transparent;
            btnRememberInfo.FillDisableColor = Color.Transparent;
            btnRememberInfo.FillHoverColor = Color.Transparent;
            btnRememberInfo.FillPressColor = Color.Transparent;
            btnRememberInfo.FillSelectedColor = Color.Transparent;
            btnRememberInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRememberInfo.ForeColor = Color.Transparent;
            btnRememberInfo.ForeDisableColor = Color.Transparent;
            btnRememberInfo.ForeHoverColor = Color.Transparent;
            btnRememberInfo.ForePressColor = Color.Transparent;
            btnRememberInfo.ForeSelectedColor = Color.Transparent;
            btnRememberInfo.LightColor = Color.Transparent;
            btnRememberInfo.Location = new Point(339, 495);
            btnRememberInfo.MinimumSize = new Size(1, 1);
            btnRememberInfo.Name = "btnRememberInfo";
            btnRememberInfo.Radius = 10;
            btnRememberInfo.RectColor = Color.Transparent;
            btnRememberInfo.RectDisableColor = Color.Transparent;
            btnRememberInfo.RectHoverColor = Color.Transparent;
            btnRememberInfo.RectPressColor = Color.Transparent;
            btnRememberInfo.RectSelectedColor = Color.Transparent;
            btnRememberInfo.Size = new Size(24, 24);
            btnRememberInfo.TabIndex = 47;
            btnRememberInfo.TipsColor = Color.Transparent;
            btnRememberInfo.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRememberInfo.TipsForeColor = Color.Transparent;
            btnRememberInfo.Click += BtnRememberInfo_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.CheckBoxColor = Color.FromArgb(139, 61, 255);
            chkRememberMe.CheckBoxSize = 18;
            chkRememberMe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkRememberMe.ForeColor = Color.DarkGray;
            chkRememberMe.Location = new Point(67, 491);
            chkRememberMe.MinimumSize = new Size(1, 1);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(270, 29);
            chkRememberMe.TabIndex = 46;
            chkRememberMe.Text = "Запомнить меня на этом компютере";
            // 
            // uiToolTip1
            // 
            uiToolTip1.AutoPopDelay = 5000;
            uiToolTip1.BackColor = Color.FromArgb(30, 30, 36);
            uiToolTip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiToolTip1.ForeColor = Color.White;
            uiToolTip1.InitialDelay = 300;
            uiToolTip1.OwnerDraw = true;
            uiToolTip1.RectColor = Color.FromArgb(42, 45, 54);
            uiToolTip1.ReshowDelay = 100;
            uiToolTip1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // btnLaunchBotLauncher
            // 
            btnLaunchBotLauncher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLaunchBotLauncher.BackColor = Color.Transparent;
            btnLaunchBotLauncher.BackgroundImageLayout = ImageLayout.Center;
            btnLaunchBotLauncher.FillColor = Color.FromArgb(124, 58, 237);
            btnLaunchBotLauncher.FillColor2 = Color.Transparent;
            btnLaunchBotLauncher.FillDisableColor = Color.Transparent;
            btnLaunchBotLauncher.FillHoverColor = Color.MediumSlateBlue;
            btnLaunchBotLauncher.FillPressColor = Color.Indigo;
            btnLaunchBotLauncher.FillSelectedColor = Color.Transparent;
            btnLaunchBotLauncher.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLaunchBotLauncher.ForeDisableColor = Color.Transparent;
            btnLaunchBotLauncher.ForeSelectedColor = Color.Transparent;
            btnLaunchBotLauncher.LightColor = Color.Transparent;
            btnLaunchBotLauncher.Location = new Point(67, 536);
            btnLaunchBotLauncher.Margin = new Padding(5);
            btnLaunchBotLauncher.MinimumSize = new Size(1, 1);
            btnLaunchBotLauncher.Name = "btnLaunchBotLauncher";
            btnLaunchBotLauncher.Radius = 10;
            btnLaunchBotLauncher.RectColor = Color.FromArgb(124, 58, 237);
            btnLaunchBotLauncher.RectDisableColor = Color.FromArgb(124, 58, 237);
            btnLaunchBotLauncher.RectHoverColor = Color.FromArgb(124, 58, 237);
            btnLaunchBotLauncher.RectPressColor = Color.FromArgb(124, 58, 237);
            btnLaunchBotLauncher.RectSelectedColor = Color.FromArgb(124, 58, 237);
            btnLaunchBotLauncher.Size = new Size(446, 45);
            btnLaunchBotLauncher.TabIndex = 56;
            btnLaunchBotLauncher.Text = "Запустить Bot Launcher";
            btnLaunchBotLauncher.TipsColor = Color.Transparent;
            btnLaunchBotLauncher.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLaunchBotLauncher.TipsForeColor = Color.Transparent;
            btnLaunchBotLauncher.Click += BtnLaunchBotLauncher_Click;
            // 
            // SuccessPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(picSuccessIcon);
            Controls.Add(lblSuccessTitle);
            Controls.Add(pnlProfileInfo);
            Controls.Add(chkRememberMe);
            Controls.Add(btnRememberInfo);
            Controls.Add(btnLaunchBotLauncher);
            Name = "SuccessPage";
            Size = new Size(580, 720);
            ((System.ComponentModel.ISupportInitialize)picSuccessIcon).EndInit();
            pnlProfileInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSuccessTitle;
        private PictureBox picSuccessIcon;
        private Sunny.UI.UIPanel pnlProfileInfo;
        private Label lblProfileInfoLabel;
        private Label lblCreatedAtLabel;
        private Label lblBotIdLabel;
        private Label lblBotInfoLabel;
        private Label lblCreatedAtValue;
        private Label lblBotIdValue;
        private Label lblBotUsernameValue;
        private Label lblProfileInfoValue;
        private Label lblBotNameValue;
        private Label lblBotNameLabel;
        private Sunny.UI.UIButton btnRememberInfo;
        private Sunny.UI.UICheckBox chkRememberMe;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIButton btnLaunchBotLauncher;
    }
}
