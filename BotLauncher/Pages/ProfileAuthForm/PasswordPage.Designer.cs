namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class PasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordPage));
            lblTitle = new Label();
            lblPassword = new Label();
            txtPassword = new Sunny.UI.UITextBox();
            chkRememberMe = new Sunny.UI.UICheckBox();
            btnTogglePassword = new Sunny.UI.UIButton();
            btnInfo = new Sunny.UI.UIButton();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            btnBack = new Sunny.UI.UIButton();
            btnOpen = new Sunny.UI.UIButton();
            btnCancel = new Sunny.UI.UIButton();
            picFileError = new PictureBox();
            tableLayoutPanelButtons = new Sunny.UI.UITableLayoutPanel();
            lblProfileName = new Label();
            ((System.ComponentModel.ISupportInitialize)picFileError).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(63, 214);
            lblTitle.Margin = new Padding(5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 38);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Открытие профиля";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.UseCompatibleTextRendering = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblPassword.Location = new Point(63, 287);
            lblPassword.Name = "lblPassword";
            lblPassword.RightToLeft = RightToLeft.No;
            lblPassword.Size = new Size(118, 19);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Пароль профиля";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.ButtonFillColor = Color.Transparent;
            txtPassword.ButtonFillHoverColor = Color.Transparent;
            txtPassword.ButtonFillPressColor = Color.Transparent;
            txtPassword.ButtonForeColor = Color.Transparent;
            txtPassword.ButtonForeHoverColor = Color.Transparent;
            txtPassword.ButtonForePressColor = Color.Transparent;
            txtPassword.ButtonRectColor = Color.Transparent;
            txtPassword.ButtonRectHoverColor = Color.Transparent;
            txtPassword.ButtonRectPressColor = Color.Transparent;
            txtPassword.ButtonStyleInherited = false;
            txtPassword.FillColor = Color.FromArgb(34, 36, 44);
            txtPassword.FillColor2 = Color.Transparent;
            txtPassword.FillDisableColor = Color.Transparent;
            txtPassword.FillReadOnlyColor = Color.Transparent;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = Color.Transparent;
            txtPassword.ForeDisableColor = Color.Transparent;
            txtPassword.ForeReadOnlyColor = Color.Transparent;
            txtPassword.Location = new Point(63, 310);
            txtPassword.Margin = new Padding(5, 0, 5, 0);
            txtPassword.MinimumSize = new Size(150, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '●';
            txtPassword.RectColor = Color.FromArgb(42, 45, 54);
            txtPassword.RectDisableColor = Color.Transparent;
            txtPassword.RectReadOnlyColor = Color.Transparent;
            txtPassword.ScrollBarBackColor = Color.Transparent;
            txtPassword.ScrollBarColor = Color.Transparent;
            txtPassword.ScrollBarStyleInherited = false;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(404, 40);
            txtPassword.SymbolColor = Color.Transparent;
            txtPassword.TabIndex = 18;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            txtPassword.WatermarkActiveColor = Color.Transparent;
            txtPassword.WatermarkColor = Color.Transparent;
            // 
            // chkRememberMe
            // 
            chkRememberMe.CheckBoxColor = Color.FromArgb(139, 61, 255);
            chkRememberMe.CheckBoxSize = 18;
            chkRememberMe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkRememberMe.ForeColor = Color.DarkGray;
            chkRememberMe.Location = new Point(63, 362);
            chkRememberMe.MinimumSize = new Size(1, 1);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(271, 24);
            chkRememberMe.TabIndex = 19;
            chkRememberMe.Text = "Запомнить меня на этом компютере";
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTogglePassword.BackColor = Color.Transparent;
            btnTogglePassword.BackgroundImage = (Image)resources.GetObject("btnTogglePassword.BackgroundImage");
            btnTogglePassword.BackgroundImageLayout = ImageLayout.Center;
            btnTogglePassword.FillColor = Color.Transparent;
            btnTogglePassword.FillColor2 = Color.Transparent;
            btnTogglePassword.FillDisableColor = Color.Transparent;
            btnTogglePassword.FillHoverColor = Color.Transparent;
            btnTogglePassword.FillPressColor = Color.Transparent;
            btnTogglePassword.FillSelectedColor = Color.Transparent;
            btnTogglePassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnTogglePassword.ForeColor = Color.Transparent;
            btnTogglePassword.ForeDisableColor = Color.Transparent;
            btnTogglePassword.ForeHoverColor = Color.Transparent;
            btnTogglePassword.ForePressColor = Color.Transparent;
            btnTogglePassword.ForeSelectedColor = Color.Transparent;
            btnTogglePassword.LightColor = Color.Transparent;
            btnTogglePassword.Location = new Point(477, 310);
            btnTogglePassword.Margin = new Padding(5, 0, 0, 0);
            btnTogglePassword.MinimumSize = new Size(40, 40);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Radius = 10;
            btnTogglePassword.RectColor = Color.FromArgb(42, 45, 54);
            btnTogglePassword.RectDisableColor = Color.Transparent;
            btnTogglePassword.RectHoverColor = Color.Transparent;
            btnTogglePassword.RectPressColor = Color.Transparent;
            btnTogglePassword.RectSelectedColor = Color.Transparent;
            btnTogglePassword.Size = new Size(40, 40);
            btnTogglePassword.TabIndex = 23;
            btnTogglePassword.TipsColor = Color.Transparent;
            btnTogglePassword.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnTogglePassword.TipsForeColor = Color.Transparent;
            btnTogglePassword.Click += BtnTogglePassword_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.BackgroundImage = (Image)resources.GetObject("btnInfo.BackgroundImage");
            btnInfo.BackgroundImageLayout = ImageLayout.Center;
            btnInfo.FillColor = Color.Transparent;
            btnInfo.FillColor2 = Color.Transparent;
            btnInfo.FillDisableColor = Color.Transparent;
            btnInfo.FillHoverColor = Color.Transparent;
            btnInfo.FillPressColor = Color.Transparent;
            btnInfo.FillSelectedColor = Color.Transparent;
            btnInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnInfo.ForeColor = Color.Transparent;
            btnInfo.ForeDisableColor = Color.Transparent;
            btnInfo.ForeHoverColor = Color.Transparent;
            btnInfo.ForePressColor = Color.Transparent;
            btnInfo.ForeSelectedColor = Color.Transparent;
            btnInfo.LightColor = Color.Transparent;
            btnInfo.Location = new Point(340, 362);
            btnInfo.MinimumSize = new Size(1, 1);
            btnInfo.Name = "btnInfo";
            btnInfo.Radius = 10;
            btnInfo.RectColor = Color.Transparent;
            btnInfo.RectDisableColor = Color.Transparent;
            btnInfo.RectHoverColor = Color.Transparent;
            btnInfo.RectPressColor = Color.Transparent;
            btnInfo.RectSelectedColor = Color.Transparent;
            btnInfo.Size = new Size(24, 24);
            btnInfo.TabIndex = 24;
            btnInfo.TipsColor = Color.Transparent;
            btnInfo.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnInfo.TipsForeColor = Color.Transparent;
            btnInfo.Click += BtnInfo_Click;
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
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.FillColor = Color.Transparent;
            btnBack.FillColor2 = Color.Transparent;
            btnBack.FillDisableColor = Color.Transparent;
            btnBack.FillHoverColor = Color.Transparent;
            btnBack.FillPressColor = Color.Transparent;
            btnBack.FillSelectedColor = Color.Transparent;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.ForeDisableColor = Color.Transparent;
            btnBack.ForeSelectedColor = Color.Transparent;
            btnBack.LightColor = Color.Transparent;
            btnBack.Location = new Point(20, 20);
            btnBack.Margin = new Padding(5);
            btnBack.MinimumSize = new Size(1, 1);
            btnBack.Name = "btnBack";
            btnBack.Radius = 10;
            btnBack.RectColor = Color.FromArgb(42, 45, 54);
            btnBack.RectDisableColor = Color.Transparent;
            btnBack.RectHoverColor = Color.DarkGray;
            btnBack.RectPressColor = Color.WhiteSmoke;
            btnBack.RectSelectedColor = Color.Transparent;
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 59;
            btnBack.Text = "Назад";
            btnBack.TipsColor = Color.Transparent;
            btnBack.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.TipsForeColor = Color.Transparent;
            btnBack.Click += BtnBack_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Transparent;
            btnOpen.BackgroundImageLayout = ImageLayout.Center;
            btnOpen.Dock = DockStyle.Fill;
            btnOpen.FillColor = Color.FromArgb(124, 58, 237);
            btnOpen.FillColor2 = Color.Transparent;
            btnOpen.FillDisableColor = Color.Transparent;
            btnOpen.FillHoverColor = Color.MediumSlateBlue;
            btnOpen.FillPressColor = Color.Indigo;
            btnOpen.FillSelectedColor = Color.Transparent;
            btnOpen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpen.ForeDisableColor = Color.Transparent;
            btnOpen.ForeSelectedColor = Color.Transparent;
            btnOpen.LightColor = Color.Transparent;
            btnOpen.Location = new Point(237, 0);
            btnOpen.Margin = new Padding(10, 0, 0, 0);
            btnOpen.MinimumSize = new Size(1, 1);
            btnOpen.Name = "btnOpen";
            btnOpen.Radius = 10;
            btnOpen.RectColor = Color.FromArgb(124, 58, 237);
            btnOpen.RectDisableColor = Color.FromArgb(124, 58, 237);
            btnOpen.RectHoverColor = Color.FromArgb(124, 58, 237);
            btnOpen.RectPressColor = Color.FromArgb(124, 58, 237);
            btnOpen.RectSelectedColor = Color.FromArgb(124, 58, 237);
            btnOpen.Size = new Size(217, 45);
            btnOpen.TabIndex = 60;
            btnOpen.Text = "Открыть";
            btnOpen.TipsColor = Color.Transparent;
            btnOpen.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpen.TipsForeColor = Color.Transparent;
            btnOpen.Click += BtnOpen_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FillColor = Color.Transparent;
            btnCancel.FillColor2 = Color.Transparent;
            btnCancel.FillDisableColor = Color.Transparent;
            btnCancel.FillHoverColor = Color.Transparent;
            btnCancel.FillPressColor = Color.Transparent;
            btnCancel.FillSelectedColor = Color.Transparent;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeDisableColor = Color.Transparent;
            btnCancel.ForeSelectedColor = Color.Transparent;
            btnCancel.LightColor = Color.Transparent;
            btnCancel.Location = new Point(0, 0);
            btnCancel.Margin = new Padding(0, 0, 10, 0);
            btnCancel.MinimumSize = new Size(1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Radius = 10;
            btnCancel.RectColor = Color.FromArgb(42, 45, 54);
            btnCancel.RectDisableColor = Color.Transparent;
            btnCancel.RectHoverColor = Color.DarkGray;
            btnCancel.RectPressColor = Color.WhiteSmoke;
            btnCancel.RectSelectedColor = Color.Transparent;
            btnCancel.Size = new Size(217, 45);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Отмена";
            btnCancel.TipsColor = Color.Transparent;
            btnCancel.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.TipsForeColor = Color.Transparent;
            btnCancel.Click += BtnCancel_Click;
            // 
            // picFileError
            // 
            picFileError.BackColor = Color.Transparent;
            picFileError.BackgroundImage = (Image)resources.GetObject("picFileError.BackgroundImage");
            picFileError.BackgroundImageLayout = ImageLayout.Zoom;
            picFileError.Location = new Point(31, 320);
            picFileError.Name = "picFileError";
            picFileError.Size = new Size(24, 24);
            picFileError.TabIndex = 62;
            picFileError.TabStop = false;
            picFileError.Visible = false;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnOpen, 1, 0);
            tableLayoutPanelButtons.Location = new Point(63, 463);
            tableLayoutPanelButtons.MinimumSize = new Size(300, 45);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(454, 45);
            tableLayoutPanelButtons.TabIndex = 63;
            tableLayoutPanelButtons.TagString = null;
            // 
            // lblProfileName
            // 
            lblProfileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProfileName.AutoEllipsis = true;
            lblProfileName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblProfileName.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblProfileName.Location = new Point(63, 251);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.RightToLeft = RightToLeft.No;
            lblProfileName.Size = new Size(346, 21);
            lblProfileName.TabIndex = 15;
            lblProfileName.Text = "Пароль для профиля";
            lblProfileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(lblProfileName);
            Controls.Add(lblPassword);
            Controls.Add(picFileError);
            Controls.Add(txtPassword);
            Controls.Add(btnTogglePassword);
            Controls.Add(chkRememberMe);
            Controls.Add(btnInfo);
            Controls.Add(tableLayoutPanelButtons);
            ForeColor = Color.White;
            Name = "PasswordPage";
            Padding = new Padding(10);
            Size = new Size(580, 720);
            ((System.ComponentModel.ISupportInitialize)picFileError).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblPassword;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UICheckBox chkRememberMe;
        private Sunny.UI.UIButton btnTogglePassword;
        private Sunny.UI.UIButton btnInfo;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIButton btnBack;
        private Sunny.UI.UIButton btnOpen;
        private Sunny.UI.UIButton btnCancel;
        private PictureBox picFileError;
        private Sunny.UI.UITableLayoutPanel tableLayoutPanelButtons;
        private Label lblProfileName;
    }
}
