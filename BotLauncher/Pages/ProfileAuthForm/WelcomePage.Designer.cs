namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            picWelcomIcon = new PictureBox();
            lblWelcomeTitle = new Label();
            lblWelcomeDescription = new Label();
            pnlSecurityInfo = new Sunny.UI.UIPanel();
            btnRememberInfo = new Sunny.UI.UIButton();
            lblSecurityInfo = new Label();
            picSecurityIcon = new PictureBox();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            btnMyProfiles = new Sunny.UI.UIButton();
            btnCreateProfile = new Sunny.UI.UIButton();
            btnImportProfile = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)picWelcomIcon).BeginInit();
            pnlSecurityInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSecurityIcon).BeginInit();
            SuspendLayout();
            // 
            // picWelcomIcon
            // 
            picWelcomIcon.Anchor = AnchorStyles.Top;
            picWelcomIcon.BackgroundImage = Properties.Resources.robot_solid;
            picWelcomIcon.BackgroundImageLayout = ImageLayout.Stretch;
            picWelcomIcon.Location = new Point(210, 30);
            picWelcomIcon.Margin = new Padding(10, 5, 10, 10);
            picWelcomIcon.MinimumSize = new Size(120, 120);
            picWelcomIcon.Name = "picWelcomIcon";
            picWelcomIcon.Size = new Size(150, 150);
            picWelcomIcon.TabIndex = 0;
            picWelcomIcon.TabStop = false;
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.Anchor = AnchorStyles.Top;
            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcomeTitle.ForeColor = Color.White;
            lblWelcomeTitle.Location = new Point(135, 195);
            lblWelcomeTitle.Margin = new Padding(5);
            lblWelcomeTitle.MinimumSize = new Size(280, 60);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(320, 78);
            lblWelcomeTitle.TabIndex = 1;
            lblWelcomeTitle.Text = "Добро пожаловать в\r\nBot Launcher";
            lblWelcomeTitle.TextAlign = ContentAlignment.TopCenter;
            lblWelcomeTitle.UseCompatibleTextRendering = true;
            // 
            // lblWelcomeDescription
            // 
            lblWelcomeDescription.Anchor = AnchorStyles.Top;
            lblWelcomeDescription.AutoSize = true;
            lblWelcomeDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWelcomeDescription.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblWelcomeDescription.Location = new Point(161, 280);
            lblWelcomeDescription.MinimumSize = new Size(220, 34);
            lblWelcomeDescription.Name = "lblWelcomeDescription";
            lblWelcomeDescription.RightToLeft = RightToLeft.No;
            lblWelcomeDescription.Size = new Size(247, 34);
            lblWelcomeDescription.TabIndex = 2;
            lblWelcomeDescription.Text = "Управляйте своими Telegram-ботами \r\nбыстро, удобно и безопасно.";
            lblWelcomeDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlSecurityInfo
            // 
            pnlSecurityInfo.Anchor = AnchorStyles.Bottom;
            pnlSecurityInfo.Controls.Add(btnRememberInfo);
            pnlSecurityInfo.Controls.Add(lblSecurityInfo);
            pnlSecurityInfo.Controls.Add(picSecurityIcon);
            pnlSecurityInfo.FillColor = Color.Transparent;
            pnlSecurityInfo.FillColor2 = Color.Transparent;
            pnlSecurityInfo.FillDisableColor = Color.Transparent;
            pnlSecurityInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlSecurityInfo.ForeColor = Color.Transparent;
            pnlSecurityInfo.ForeDisableColor = Color.Transparent;
            pnlSecurityInfo.Location = new Point(95, 550);
            pnlSecurityInfo.Margin = new Padding(10, 10, 10, 20);
            pnlSecurityInfo.MaximumSize = new Size(420, 60);
            pnlSecurityInfo.MinimumSize = new Size(300, 60);
            pnlSecurityInfo.Name = "pnlSecurityInfo";
            pnlSecurityInfo.Padding = new Padding(15, 10, 10, 10);
            pnlSecurityInfo.Radius = 10;
            pnlSecurityInfo.RectColor = Color.FromArgb(42, 45, 54);
            pnlSecurityInfo.RectDisableColor = Color.Transparent;
            pnlSecurityInfo.Size = new Size(380, 60);
            pnlSecurityInfo.TabIndex = 7;
            pnlSecurityInfo.Text = null;
            pnlSecurityInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnRememberInfo
            // 
            btnRememberInfo.Anchor = AnchorStyles.Right;
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
            btnRememberInfo.Location = new Point(341, 18);
            btnRememberInfo.MinimumSize = new Size(1, 1);
            btnRememberInfo.Name = "btnRememberInfo";
            btnRememberInfo.Radius = 10;
            btnRememberInfo.RectColor = Color.Transparent;
            btnRememberInfo.RectDisableColor = Color.Transparent;
            btnRememberInfo.RectHoverColor = Color.Transparent;
            btnRememberInfo.RectPressColor = Color.Transparent;
            btnRememberInfo.RectSelectedColor = Color.Transparent;
            btnRememberInfo.Size = new Size(24, 24);
            btnRememberInfo.TabIndex = 13;
            btnRememberInfo.TipsColor = Color.Transparent;
            btnRememberInfo.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRememberInfo.TipsForeColor = Color.Transparent;
            // 
            // lblSecurityInfo
            // 
            lblSecurityInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblSecurityInfo.BackColor = Color.Transparent;
            lblSecurityInfo.FlatStyle = FlatStyle.Flat;
            lblSecurityInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSecurityInfo.ForeColor = Color.Gray;
            lblSecurityInfo.Location = new Point(45, 14);
            lblSecurityInfo.Name = "lblSecurityInfo";
            lblSecurityInfo.Size = new Size(290, 32);
            lblSecurityInfo.TabIndex = 1;
            lblSecurityInfo.Text = "Профили хранятся локально на этом компьютере и защищены паролем.";
            lblSecurityInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picSecurityIcon
            // 
            picSecurityIcon.Anchor = AnchorStyles.Left;
            picSecurityIcon.BackgroundImage = (Image)resources.GetObject("picSecurityIcon.BackgroundImage");
            picSecurityIcon.BackgroundImageLayout = ImageLayout.Stretch;
            picSecurityIcon.Location = new Point(12, 14);
            picSecurityIcon.Name = "picSecurityIcon";
            picSecurityIcon.Size = new Size(32, 32);
            picSecurityIcon.TabIndex = 0;
            picSecurityIcon.TabStop = false;
            // 
            // uiToolTip1
            // 
            uiToolTip1.BackColor = Color.FromArgb(30, 30, 36);
            uiToolTip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiToolTip1.ForeColor = Color.White;
            uiToolTip1.OwnerDraw = true;
            uiToolTip1.RectColor = Color.FromArgb(42, 45, 54);
            uiToolTip1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // btnMyProfiles
            // 
            btnMyProfiles.Anchor = AnchorStyles.Top;
            btnMyProfiles.BackColor = Color.Transparent;
            btnMyProfiles.BackgroundImageLayout = ImageLayout.Center;
            btnMyProfiles.FillColor = Color.FromArgb(89, 40, 178);
            btnMyProfiles.FillColor2 = Color.Transparent;
            btnMyProfiles.FillDisableColor = Color.Transparent;
            btnMyProfiles.FillHoverColor = Color.FromArgb(63, 28, 126);
            btnMyProfiles.FillPressColor = Color.FromArgb(37, 16, 75);
            btnMyProfiles.FillSelectedColor = Color.Transparent;
            btnMyProfiles.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMyProfiles.ForeDisableColor = Color.Transparent;
            btnMyProfiles.ForeSelectedColor = Color.Transparent;
            btnMyProfiles.LightColor = Color.Transparent;
            btnMyProfiles.Location = new Point(142, 339);
            btnMyProfiles.Margin = new Padding(5);
            btnMyProfiles.MinimumSize = new Size(250, 45);
            btnMyProfiles.Name = "btnMyProfiles";
            btnMyProfiles.Radius = 10;
            btnMyProfiles.RectColor = Color.FromArgb(89, 40, 178);
            btnMyProfiles.RectDisableColor = Color.FromArgb(89, 40, 178);
            btnMyProfiles.RectHoverColor = Color.FromArgb(89, 40, 178);
            btnMyProfiles.RectPressColor = Color.FromArgb(89, 40, 178);
            btnMyProfiles.RectSelectedColor = Color.FromArgb(89, 40, 178);
            btnMyProfiles.Size = new Size(285, 45);
            btnMyProfiles.TabIndex = 56;
            btnMyProfiles.Text = "Мои профили";
            btnMyProfiles.TipsColor = Color.Transparent;
            btnMyProfiles.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMyProfiles.TipsForeColor = Color.Transparent;
            btnMyProfiles.Click += BtnMyProfiles_Click;
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.Anchor = AnchorStyles.Top;
            btnCreateProfile.BackColor = Color.Transparent;
            btnCreateProfile.BackgroundImageLayout = ImageLayout.Center;
            btnCreateProfile.FillColor = Color.FromArgb(110, 72, 195);
            btnCreateProfile.FillColor2 = Color.Transparent;
            btnCreateProfile.FillDisableColor = Color.Transparent;
            btnCreateProfile.FillHoverColor = Color.MediumSlateBlue;
            btnCreateProfile.FillPressColor = Color.Indigo;
            btnCreateProfile.FillSelectedColor = Color.Transparent;
            btnCreateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateProfile.ForeDisableColor = Color.Transparent;
            btnCreateProfile.ForeSelectedColor = Color.Transparent;
            btnCreateProfile.LightColor = Color.Transparent;
            btnCreateProfile.Location = new Point(142, 394);
            btnCreateProfile.Margin = new Padding(5);
            btnCreateProfile.MinimumSize = new Size(250, 45);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Radius = 10;
            btnCreateProfile.RectColor = Color.FromArgb(110, 72, 195);
            btnCreateProfile.RectDisableColor = Color.FromArgb(110, 72, 195);
            btnCreateProfile.RectHoverColor = Color.FromArgb(110, 72, 195);
            btnCreateProfile.RectPressColor = Color.FromArgb(110, 72, 195);
            btnCreateProfile.RectSelectedColor = Color.FromArgb(110, 72, 195);
            btnCreateProfile.Size = new Size(285, 45);
            btnCreateProfile.TabIndex = 57;
            btnCreateProfile.Text = "Создать профиль";
            btnCreateProfile.TipsColor = Color.Transparent;
            btnCreateProfile.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateProfile.TipsForeColor = Color.Transparent;
            btnCreateProfile.Click += BtnCreateProfile_Click;
            // 
            // btnImportProfile
            // 
            btnImportProfile.Anchor = AnchorStyles.Top;
            btnImportProfile.BackColor = Color.Transparent;
            btnImportProfile.BackgroundImageLayout = ImageLayout.Center;
            btnImportProfile.FillColor = Color.Transparent;
            btnImportProfile.FillColor2 = Color.Transparent;
            btnImportProfile.FillDisableColor = Color.Transparent;
            btnImportProfile.FillHoverColor = Color.Transparent;
            btnImportProfile.FillPressColor = Color.Transparent;
            btnImportProfile.FillSelectedColor = Color.Transparent;
            btnImportProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImportProfile.ForeDisableColor = Color.Transparent;
            btnImportProfile.ForeSelectedColor = Color.Transparent;
            btnImportProfile.LightColor = Color.Transparent;
            btnImportProfile.Location = new Point(142, 449);
            btnImportProfile.Margin = new Padding(5);
            btnImportProfile.MinimumSize = new Size(250, 45);
            btnImportProfile.Name = "btnImportProfile";
            btnImportProfile.Radius = 10;
            btnImportProfile.RectColor = Color.FromArgb(42, 45, 54);
            btnImportProfile.RectDisableColor = Color.Transparent;
            btnImportProfile.RectHoverColor = Color.DarkGray;
            btnImportProfile.RectPressColor = Color.WhiteSmoke;
            btnImportProfile.RectSelectedColor = Color.Transparent;
            btnImportProfile.Size = new Size(285, 45);
            btnImportProfile.TabIndex = 58;
            btnImportProfile.Text = "Импортировать профиль";
            btnImportProfile.TipsColor = Color.Transparent;
            btnImportProfile.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImportProfile.TipsForeColor = Color.Transparent;
            btnImportProfile.Click += BtnImportProfile_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(picWelcomIcon);
            Controls.Add(lblWelcomeTitle);
            Controls.Add(lblWelcomeDescription);
            Controls.Add(btnMyProfiles);
            Controls.Add(btnCreateProfile);
            Controls.Add(btnImportProfile);
            Controls.Add(pnlSecurityInfo);
            ForeColor = SystemColors.ControlText;
            Name = "WelcomePage";
            Size = new Size(569, 646);
            ((System.ComponentModel.ISupportInitialize)picWelcomIcon).EndInit();
            pnlSecurityInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSecurityIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picWelcomIcon;
        private Label lblWelcomeTitle;
        private Label lblWelcomeDescription;
        private Sunny.UI.UIPanel pnlSecurityInfo;
        private PictureBox picSecurityIcon;
        private Label lblSecurityInfo;
        private Sunny.UI.UIButton btnRememberInfo;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIButton btnMyProfiles;
        private Sunny.UI.UIButton btnCreateProfile;
        private Sunny.UI.UIButton btnImportProfile;
    }
}
