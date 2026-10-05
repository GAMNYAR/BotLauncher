namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class ImportProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportProfilePage));
            lblTitle = new Label();
            txtFilePath = new Sunny.UI.UITextBox();
            lblFileHint = new Label();
            btnShowPassword = new Sunny.UI.UIButton();
            txtPassword = new Sunny.UI.UITextBox();
            lblPasswordHint = new Label();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            picFileError = new PictureBox();
            picPasswordError = new PictureBox();
            btnCancel = new Sunny.UI.UIButton();
            btnImport = new Sunny.UI.UIButton();
            btnSelectFile = new Sunny.UI.UIButton();
            btnBack = new Sunny.UI.UIButton();
            tableLayoutPanelButtons = new Sunny.UI.UITableLayoutPanel();
            chkRememberMe = new Sunny.UI.UICheckBox();
            btnInfo = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)picFileError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPasswordError).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(63, 162);
            lblTitle.Margin = new Padding(5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(165, 31);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Импорт профиля";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.UseCompatibleTextRendering = true;
            // 
            // txtFilePath
            // 
            txtFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFilePath.ButtonFillColor = Color.Transparent;
            txtFilePath.ButtonFillHoverColor = Color.Transparent;
            txtFilePath.ButtonFillPressColor = Color.Transparent;
            txtFilePath.ButtonForeColor = Color.Transparent;
            txtFilePath.ButtonForeHoverColor = Color.Transparent;
            txtFilePath.ButtonForePressColor = Color.Transparent;
            txtFilePath.ButtonRectColor = Color.Transparent;
            txtFilePath.ButtonRectHoverColor = Color.Transparent;
            txtFilePath.ButtonRectPressColor = Color.Transparent;
            txtFilePath.ButtonStyleInherited = false;
            txtFilePath.FillColor = Color.FromArgb(34, 36, 44);
            txtFilePath.FillColor2 = Color.Transparent;
            txtFilePath.FillDisableColor = Color.Transparent;
            txtFilePath.FillReadOnlyColor = Color.Transparent;
            txtFilePath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtFilePath.ForeColor = Color.Transparent;
            txtFilePath.ForeDisableColor = Color.Transparent;
            txtFilePath.ForeReadOnlyColor = Color.Transparent;
            txtFilePath.Location = new Point(63, 237);
            txtFilePath.Margin = new Padding(0, 0, 5, 0);
            txtFilePath.MinimumSize = new Size(150, 0);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Padding = new Padding(5);
            txtFilePath.RectColor = Color.FromArgb(42, 45, 54);
            txtFilePath.RectDisableColor = Color.Transparent;
            txtFilePath.RectReadOnlyColor = Color.Transparent;
            txtFilePath.ScrollBarBackColor = Color.Transparent;
            txtFilePath.ScrollBarColor = Color.Transparent;
            txtFilePath.ScrollBarStyleInherited = false;
            txtFilePath.ShowText = false;
            txtFilePath.Size = new Size(324, 40);
            txtFilePath.SymbolColor = Color.Transparent;
            txtFilePath.TabIndex = 27;
            txtFilePath.TextAlignment = ContentAlignment.MiddleLeft;
            txtFilePath.Watermark = "";
            txtFilePath.WatermarkActiveColor = Color.Transparent;
            txtFilePath.WatermarkColor = Color.Transparent;
            // 
            // lblFileHint
            // 
            lblFileHint.AutoSize = true;
            lblFileHint.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFileHint.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblFileHint.Location = new Point(63, 212);
            lblFileHint.Name = "lblFileHint";
            lblFileHint.RightToLeft = RightToLeft.No;
            lblFileHint.Size = new Size(141, 19);
            lblFileHint.TabIndex = 26;
            lblFileHint.Text = "Файл профиля (.blp)";
            lblFileHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnShowPassword
            // 
            btnShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.BackgroundImage = (Image)resources.GetObject("btnShowPassword.BackgroundImage");
            btnShowPassword.BackgroundImageLayout = ImageLayout.Center;
            btnShowPassword.FillColor = Color.Transparent;
            btnShowPassword.FillColor2 = Color.Transparent;
            btnShowPassword.FillDisableColor = Color.Transparent;
            btnShowPassword.FillHoverColor = Color.Transparent;
            btnShowPassword.FillPressColor = Color.Transparent;
            btnShowPassword.FillSelectedColor = Color.Transparent;
            btnShowPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowPassword.ForeColor = Color.Transparent;
            btnShowPassword.ForeDisableColor = Color.Transparent;
            btnShowPassword.ForeHoverColor = Color.Transparent;
            btnShowPassword.ForePressColor = Color.Transparent;
            btnShowPassword.ForeSelectedColor = Color.Transparent;
            btnShowPassword.LightColor = Color.Transparent;
            btnShowPassword.Location = new Point(477, 329);
            btnShowPassword.Margin = new Padding(5, 0, 0, 0);
            btnShowPassword.MinimumSize = new Size(40, 40);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Radius = 10;
            btnShowPassword.RectColor = Color.FromArgb(42, 45, 54);
            btnShowPassword.RectDisableColor = Color.Transparent;
            btnShowPassword.RectHoverColor = Color.Silver;
            btnShowPassword.RectPressColor = Color.White;
            btnShowPassword.RectSelectedColor = Color.Transparent;
            btnShowPassword.Size = new Size(40, 40);
            btnShowPassword.TabIndex = 37;
            btnShowPassword.TipsColor = Color.Transparent;
            btnShowPassword.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowPassword.TipsForeColor = Color.Transparent;
            btnShowPassword.Click += BtnShowPassword_Click;
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
            txtPassword.Location = new Point(63, 329);
            txtPassword.Margin = new Padding(0, 0, 5, 0);
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
            txtPassword.TabIndex = 36;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            txtPassword.WatermarkActiveColor = Color.Transparent;
            txtPassword.WatermarkColor = Color.Transparent;
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.AutoSize = true;
            lblPasswordHint.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPasswordHint.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblPasswordHint.Location = new Point(63, 305);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.RightToLeft = RightToLeft.No;
            lblPasswordHint.Size = new Size(119, 19);
            lblPasswordHint.TabIndex = 35;
            lblPasswordHint.Text = "Пороль профиля";
            lblPasswordHint.TextAlign = ContentAlignment.MiddleLeft;
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
            // picFileError
            // 
            picFileError.BackColor = Color.Transparent;
            picFileError.BackgroundImage = (Image)resources.GetObject("picFileError.BackgroundImage");
            picFileError.BackgroundImageLayout = ImageLayout.Zoom;
            picFileError.Location = new Point(31, 244);
            picFileError.Name = "picFileError";
            picFileError.Size = new Size(24, 24);
            picFileError.TabIndex = 51;
            picFileError.TabStop = false;
            picFileError.Visible = false;
            // 
            // picPasswordError
            // 
            picPasswordError.BackColor = Color.Transparent;
            picPasswordError.BackgroundImage = (Image)resources.GetObject("picPasswordError.BackgroundImage");
            picPasswordError.BackgroundImageLayout = ImageLayout.Zoom;
            picPasswordError.Location = new Point(31, 337);
            picPasswordError.Name = "picPasswordError";
            picPasswordError.Size = new Size(24, 24);
            picPasswordError.TabIndex = 52;
            picPasswordError.TabStop = false;
            picPasswordError.Visible = false;
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
            btnCancel.MinimumSize = new Size(150, 45);
            btnCancel.Name = "btnCancel";
            btnCancel.Radius = 10;
            btnCancel.RectColor = Color.FromArgb(42, 45, 54);
            btnCancel.RectDisableColor = Color.Transparent;
            btnCancel.RectHoverColor = Color.DarkGray;
            btnCancel.RectPressColor = Color.WhiteSmoke;
            btnCancel.RectSelectedColor = Color.Transparent;
            btnCancel.Size = new Size(217, 45);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Отмена";
            btnCancel.TipsColor = Color.Transparent;
            btnCancel.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.TipsForeColor = Color.Transparent;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.Transparent;
            btnImport.BackgroundImageLayout = ImageLayout.Center;
            btnImport.Dock = DockStyle.Fill;
            btnImport.FillColor = Color.FromArgb(124, 58, 237);
            btnImport.FillColor2 = Color.Transparent;
            btnImport.FillDisableColor = Color.Transparent;
            btnImport.FillHoverColor = Color.DarkSlateBlue;
            btnImport.FillPressColor = Color.Indigo;
            btnImport.FillSelectedColor = Color.Transparent;
            btnImport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImport.ForeDisableColor = Color.Transparent;
            btnImport.ForeSelectedColor = Color.Transparent;
            btnImport.LightColor = Color.Transparent;
            btnImport.Location = new Point(237, 0);
            btnImport.Margin = new Padding(10, 0, 0, 0);
            btnImport.MinimumSize = new Size(150, 45);
            btnImport.Name = "btnImport";
            btnImport.Radius = 10;
            btnImport.RectColor = Color.Transparent;
            btnImport.RectDisableColor = Color.Transparent;
            btnImport.RectHoverColor = Color.Transparent;
            btnImport.RectPressColor = Color.Transparent;
            btnImport.RectSelectedColor = Color.Transparent;
            btnImport.Size = new Size(217, 45);
            btnImport.TabIndex = 54;
            btnImport.Text = "Импортировать";
            btnImport.TipsColor = Color.Transparent;
            btnImport.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImport.TipsForeColor = Color.Transparent;
            btnImport.Click += BtnImport_Click;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectFile.BackColor = Color.Transparent;
            btnSelectFile.BackgroundImageLayout = ImageLayout.Center;
            btnSelectFile.FillColor = Color.FromArgb(110, 72, 195);
            btnSelectFile.FillColor2 = Color.Transparent;
            btnSelectFile.FillDisableColor = Color.Transparent;
            btnSelectFile.FillHoverColor = Color.DarkSlateBlue;
            btnSelectFile.FillPressColor = Color.Indigo;
            btnSelectFile.FillSelectedColor = Color.Transparent;
            btnSelectFile.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSelectFile.ForeDisableColor = Color.Transparent;
            btnSelectFile.ForeSelectedColor = Color.Transparent;
            btnSelectFile.LightColor = Color.Transparent;
            btnSelectFile.Location = new Point(397, 237);
            btnSelectFile.Margin = new Padding(5, 0, 0, 0);
            btnSelectFile.MinimumSize = new Size(120, 40);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Radius = 10;
            btnSelectFile.RectColor = Color.Transparent;
            btnSelectFile.RectDisableColor = Color.Transparent;
            btnSelectFile.RectHoverColor = Color.Transparent;
            btnSelectFile.RectPressColor = Color.Transparent;
            btnSelectFile.RectSelectedColor = Color.Transparent;
            btnSelectFile.Size = new Size(120, 40);
            btnSelectFile.TabIndex = 55;
            btnSelectFile.Text = "Выбрать файл";
            btnSelectFile.TipsColor = Color.Transparent;
            btnSelectFile.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSelectFile.TipsForeColor = Color.Transparent;
            btnSelectFile.Click += BtnSelectFile_Click;
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
            btnBack.TabIndex = 58;
            btnBack.Text = "Назад";
            btnBack.TipsColor = Color.Transparent;
            btnBack.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.TipsForeColor = Color.Transparent;
            btnBack.Click += BtnBack_Click;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnImport, 1, 0);
            tableLayoutPanelButtons.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanelButtons.Location = new Point(63, 514);
            tableLayoutPanelButtons.MinimumSize = new Size(300, 45);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(454, 45);
            tableLayoutPanelButtons.TabIndex = 59;
            tableLayoutPanelButtons.TagString = null;
            // 
            // chkRememberMe
            // 
            chkRememberMe.CheckBoxColor = Color.FromArgb(139, 61, 255);
            chkRememberMe.CheckBoxSize = 18;
            chkRememberMe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkRememberMe.ForeColor = Color.DarkGray;
            chkRememberMe.Location = new Point(63, 383);
            chkRememberMe.MinimumSize = new Size(1, 1);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(270, 29);
            chkRememberMe.TabIndex = 60;
            chkRememberMe.Text = "Запомнить меня на этом компютере";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Transparent;
            btnInfo.BackgroundImage = (Image)resources.GetObject("btnInfo.BackgroundImage");
            btnInfo.BackgroundImageLayout = ImageLayout.Zoom;
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
            btnInfo.Location = new Point(335, 387);
            btnInfo.MinimumSize = new Size(1, 1);
            btnInfo.Name = "btnInfo";
            btnInfo.Radius = 10;
            btnInfo.RectColor = Color.Transparent;
            btnInfo.RectDisableColor = Color.Transparent;
            btnInfo.RectHoverColor = Color.Transparent;
            btnInfo.RectPressColor = Color.Transparent;
            btnInfo.RectSelectedColor = Color.Transparent;
            btnInfo.Size = new Size(24, 24);
            btnInfo.TabIndex = 61;
            btnInfo.TipsColor = Color.Transparent;
            btnInfo.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnInfo.TipsForeColor = Color.Transparent;
            // 
            // ImportProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(chkRememberMe);
            Controls.Add(btnInfo);
            Controls.Add(btnSelectFile);
            Controls.Add(btnShowPassword);
            Controls.Add(txtFilePath);
            Controls.Add(txtPassword);
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(lblFileHint);
            Controls.Add(picFileError);
            Controls.Add(lblPasswordHint);
            Controls.Add(picPasswordError);
            Name = "ImportProfilePage";
            Padding = new Padding(10);
            Size = new Size(580, 720);
            ((System.ComponentModel.ISupportInitialize)picFileError).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPasswordError).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Sunny.UI.UITextBox txtFilePath;
        private Label lblFileHint;
        private Sunny.UI.UIButton btnShowPassword;
        private Sunny.UI.UITextBox txtPassword;
        private Label lblPasswordHint;
        private Sunny.UI.UIToolTip uiToolTip1;
        private PictureBox picFileError;
        private PictureBox picPasswordError;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnImport;
        private Sunny.UI.UIButton btnSelectFile;
        private Sunny.UI.UIButton btnBack;
        private Sunny.UI.UITableLayoutPanel tableLayoutPanelButtons;
        private Sunny.UI.UICheckBox chkRememberMe;
        private Sunny.UI.UIButton btnInfo;
    }
}
