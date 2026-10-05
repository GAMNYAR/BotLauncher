namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class CreateProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfilePage));
            btnBack = new Button();
            lblCreateProfileTitle = new Label();
            txtProfileName = new Sunny.UI.UITextBox();
            lblProfileName = new Label();
            btnShowPassword = new Sunny.UI.UIButton();
            txtPassword = new Sunny.UI.UITextBox();
            lblPassword = new Label();
            btnShowConfirmPassword = new Sunny.UI.UIButton();
            txtConfirmPassword = new Sunny.UI.UITextBox();
            lblConfirmPassword = new Label();
            lblProfileNameHint = new Label();
            lblPasswordHint = new Label();
            lblPasswordStrength = new Label();
            lblPasswordStrengthLable = new Label();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            picProfileNameError = new PictureBox();
            picPasswordError = new PictureBox();
            picConfirmPasswordError = new PictureBox();
            tableLayoutPanelButtons = new Sunny.UI.UITableLayoutPanel();
            btnCancel = new Sunny.UI.UIButton();
            btnCreateProfile = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)picProfileNameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPasswordError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picConfirmPasswordError).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(42, 45, 54);
            btnBack.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnBack.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.ForeColor = Color.White;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageAlign = ContentAlignment.MiddleRight;
            btnBack.Location = new Point(20, 20);
            btnBack.Margin = new Padding(10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblCreateProfileTitle
            // 
            lblCreateProfileTitle.AutoEllipsis = true;
            lblCreateProfileTitle.AutoSize = true;
            lblCreateProfileTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCreateProfileTitle.ForeColor = Color.White;
            lblCreateProfileTitle.Location = new Point(63, 115);
            lblCreateProfileTitle.Margin = new Padding(5);
            lblCreateProfileTitle.Name = "lblCreateProfileTitle";
            lblCreateProfileTitle.Size = new Size(180, 31);
            lblCreateProfileTitle.TabIndex = 2;
            lblCreateProfileTitle.Text = "Создание профиля";
            lblCreateProfileTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblCreateProfileTitle.UseCompatibleTextRendering = true;
            // 
            // txtProfileName
            // 
            txtProfileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProfileName.ButtonFillColor = Color.Transparent;
            txtProfileName.ButtonFillHoverColor = Color.Transparent;
            txtProfileName.ButtonFillPressColor = Color.Transparent;
            txtProfileName.ButtonForeColor = Color.Transparent;
            txtProfileName.ButtonForeHoverColor = Color.Transparent;
            txtProfileName.ButtonForePressColor = Color.Transparent;
            txtProfileName.ButtonRectColor = Color.Transparent;
            txtProfileName.ButtonRectHoverColor = Color.Transparent;
            txtProfileName.ButtonRectPressColor = Color.Transparent;
            txtProfileName.ButtonStyleInherited = false;
            txtProfileName.FillColor = Color.FromArgb(34, 36, 44);
            txtProfileName.FillColor2 = Color.Transparent;
            txtProfileName.FillDisableColor = Color.Transparent;
            txtProfileName.FillReadOnlyColor = Color.Transparent;
            txtProfileName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtProfileName.ForeColor = Color.Transparent;
            txtProfileName.ForeDisableColor = Color.Transparent;
            txtProfileName.ForeReadOnlyColor = Color.Transparent;
            txtProfileName.Location = new Point(63, 175);
            txtProfileName.Margin = new Padding(5, 0, 5, 0);
            txtProfileName.MaxLength = 50;
            txtProfileName.MinimumSize = new Size(1, 16);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.Padding = new Padding(5);
            txtProfileName.RectColor = Color.FromArgb(42, 45, 54);
            txtProfileName.RectDisableColor = Color.Transparent;
            txtProfileName.RectReadOnlyColor = Color.Transparent;
            txtProfileName.ScrollBarBackColor = Color.Transparent;
            txtProfileName.ScrollBarColor = Color.Transparent;
            txtProfileName.ScrollBarStyleInherited = false;
            txtProfileName.ShowText = false;
            txtProfileName.Size = new Size(450, 40);
            txtProfileName.SymbolColor = Color.Transparent;
            txtProfileName.TabIndex = 4;
            txtProfileName.TextAlignment = ContentAlignment.MiddleLeft;
            txtProfileName.Watermark = "Например: Основной бот";
            txtProfileName.WatermarkActiveColor = Color.Transparent;
            txtProfileName.TextChanged += TxtProfileName_TextChanged;
            // 
            // lblProfileName
            // 
            lblProfileName.AutoEllipsis = true;
            lblProfileName.AutoSize = true;
            lblProfileName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblProfileName.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblProfileName.Location = new Point(63, 151);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.RightToLeft = RightToLeft.No;
            lblProfileName.Size = new Size(131, 19);
            lblProfileName.TabIndex = 3;
            lblProfileName.Text = "Название профиля";
            lblProfileName.TextAlign = ContentAlignment.MiddleLeft;
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
            btnShowPassword.Location = new Point(473, 296);
            btnShowPassword.Margin = new Padding(5);
            btnShowPassword.MinimumSize = new Size(1, 1);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Radius = 10;
            btnShowPassword.RectColor = Color.FromArgb(42, 45, 54);
            btnShowPassword.RectDisableColor = Color.Transparent;
            btnShowPassword.RectHoverColor = Color.MediumPurple;
            btnShowPassword.RectPressColor = Color.Indigo;
            btnShowPassword.RectSelectedColor = Color.Transparent;
            btnShowPassword.Size = new Size(40, 40);
            btnShowPassword.TabIndex = 7;
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
            txtPassword.Location = new Point(63, 296);
            txtPassword.Margin = new Padding(5, 0, 5, 0);
            txtPassword.MaxLength = 128;
            txtPassword.MinimumSize = new Size(1, 16);
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
            txtPassword.Size = new Size(400, 40);
            txtPassword.SymbolColor = Color.Transparent;
            txtPassword.TabIndex = 6;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            txtPassword.WatermarkActiveColor = Color.Transparent;
            txtPassword.WatermarkColor = Color.Transparent;
            txtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoEllipsis = true;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPassword.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblPassword.Location = new Point(63, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.RightToLeft = RightToLeft.No;
            lblPassword.Size = new Size(57, 19);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Пароль";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnShowConfirmPassword
            // 
            btnShowConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowConfirmPassword.BackColor = Color.Transparent;
            btnShowConfirmPassword.BackgroundImage = (Image)resources.GetObject("btnShowConfirmPassword.BackgroundImage");
            btnShowConfirmPassword.BackgroundImageLayout = ImageLayout.Center;
            btnShowConfirmPassword.FillColor = Color.Transparent;
            btnShowConfirmPassword.FillColor2 = Color.Transparent;
            btnShowConfirmPassword.FillDisableColor = Color.Transparent;
            btnShowConfirmPassword.FillHoverColor = Color.Transparent;
            btnShowConfirmPassword.FillPressColor = Color.Transparent;
            btnShowConfirmPassword.FillSelectedColor = Color.Transparent;
            btnShowConfirmPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowConfirmPassword.ForeColor = Color.Transparent;
            btnShowConfirmPassword.ForeDisableColor = Color.Transparent;
            btnShowConfirmPassword.ForeHoverColor = Color.Transparent;
            btnShowConfirmPassword.ForePressColor = Color.Transparent;
            btnShowConfirmPassword.ForeSelectedColor = Color.Transparent;
            btnShowConfirmPassword.LightColor = Color.Transparent;
            btnShowConfirmPassword.Location = new Point(473, 450);
            btnShowConfirmPassword.Margin = new Padding(5);
            btnShowConfirmPassword.MinimumSize = new Size(1, 1);
            btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            btnShowConfirmPassword.Radius = 10;
            btnShowConfirmPassword.RectColor = Color.FromArgb(42, 45, 54);
            btnShowConfirmPassword.RectDisableColor = Color.Transparent;
            btnShowConfirmPassword.RectHoverColor = Color.MediumPurple;
            btnShowConfirmPassword.RectPressColor = Color.Indigo;
            btnShowConfirmPassword.RectSelectedColor = Color.Transparent;
            btnShowConfirmPassword.Size = new Size(40, 40);
            btnShowConfirmPassword.TabIndex = 10;
            btnShowConfirmPassword.TipsColor = Color.Transparent;
            btnShowConfirmPassword.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowConfirmPassword.TipsForeColor = Color.Transparent;
            btnShowConfirmPassword.Click += BtnShowConfirmPassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.ButtonFillColor = Color.Transparent;
            txtConfirmPassword.ButtonFillHoverColor = Color.Transparent;
            txtConfirmPassword.ButtonFillPressColor = Color.Transparent;
            txtConfirmPassword.ButtonForeColor = Color.Transparent;
            txtConfirmPassword.ButtonForeHoverColor = Color.Transparent;
            txtConfirmPassword.ButtonForePressColor = Color.Transparent;
            txtConfirmPassword.ButtonRectColor = Color.Transparent;
            txtConfirmPassword.ButtonRectHoverColor = Color.Transparent;
            txtConfirmPassword.ButtonRectPressColor = Color.Transparent;
            txtConfirmPassword.ButtonStyleInherited = false;
            txtConfirmPassword.FillColor = Color.FromArgb(34, 36, 44);
            txtConfirmPassword.FillColor2 = Color.Transparent;
            txtConfirmPassword.FillDisableColor = Color.Transparent;
            txtConfirmPassword.FillReadOnlyColor = Color.Transparent;
            txtConfirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtConfirmPassword.ForeColor = Color.Transparent;
            txtConfirmPassword.ForeDisableColor = Color.Transparent;
            txtConfirmPassword.ForeReadOnlyColor = Color.Transparent;
            txtConfirmPassword.Location = new Point(63, 450);
            txtConfirmPassword.Margin = new Padding(5, 0, 5, 0);
            txtConfirmPassword.MaxLength = 128;
            txtConfirmPassword.MinimumSize = new Size(1, 16);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(5);
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.RectColor = Color.FromArgb(42, 45, 54);
            txtConfirmPassword.RectDisableColor = Color.Transparent;
            txtConfirmPassword.RectReadOnlyColor = Color.Transparent;
            txtConfirmPassword.ScrollBarBackColor = Color.Transparent;
            txtConfirmPassword.ScrollBarColor = Color.Transparent;
            txtConfirmPassword.ScrollBarStyleInherited = false;
            txtConfirmPassword.ShowText = false;
            txtConfirmPassword.Size = new Size(400, 40);
            txtConfirmPassword.SymbolColor = Color.Transparent;
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtConfirmPassword.Watermark = "";
            txtConfirmPassword.WatermarkActiveColor = Color.Transparent;
            txtConfirmPassword.WatermarkColor = Color.Transparent;
            txtConfirmPassword.TextChanged += TxtConfirmPassword_TextChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoEllipsis = true;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblConfirmPassword.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblConfirmPassword.Location = new Point(63, 431);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.RightToLeft = RightToLeft.No;
            lblConfirmPassword.Size = new Size(128, 19);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Повторите пароль";
            lblConfirmPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfileNameHint
            // 
            lblProfileNameHint.AutoEllipsis = true;
            lblProfileNameHint.AutoSize = true;
            lblProfileNameHint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblProfileNameHint.ForeColor = Color.FromArgb(161, 161, 170);
            lblProfileNameHint.Location = new Point(63, 220);
            lblProfileNameHint.Name = "lblProfileNameHint";
            lblProfileNameHint.RightToLeft = RightToLeft.No;
            lblProfileNameHint.Size = new Size(263, 39);
            lblProfileNameHint.TabIndex = 44;
            lblProfileNameHint.Text = "Минимум: 3 символов.\r\nМаксимум: 50 символа.\r\nДопустимые символы: буквы, цифры, пробелы.";
            lblProfileNameHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.AutoEllipsis = true;
            lblPasswordHint.AutoSize = true;
            lblPasswordHint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPasswordHint.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblPasswordHint.Location = new Point(63, 341);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.RightToLeft = RightToLeft.No;
            lblPasswordHint.Size = new Size(242, 52);
            lblPasswordHint.TabIndex = 45;
            lblPasswordHint.Text = "Минимум: 5 символов.\r\nРекомендуется: 12+ символов.\r\nБез пробелов.\r\nИспользуйте буквы, цифры и спецсимволы.";
            lblPasswordHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPasswordStrength
            // 
            lblPasswordStrength.AutoEllipsis = true;
            lblPasswordStrength.AutoSize = true;
            lblPasswordStrength.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPasswordStrength.ForeColor = Color.Yellow;
            lblPasswordStrength.Location = new Point(138, 393);
            lblPasswordStrength.Name = "lblPasswordStrength";
            lblPasswordStrength.RightToLeft = RightToLeft.No;
            lblPasswordStrength.Size = new Size(75, 15);
            lblPasswordStrength.TabIndex = 46;
            lblPasswordStrength.Text = "Нормально.";
            lblPasswordStrength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPasswordStrengthLable
            // 
            lblPasswordStrengthLable.AutoEllipsis = true;
            lblPasswordStrengthLable.AutoSize = true;
            lblPasswordStrengthLable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPasswordStrengthLable.ForeColor = Color.White;
            lblPasswordStrengthLable.Location = new Point(63, 393);
            lblPasswordStrengthLable.Name = "lblPasswordStrengthLable";
            lblPasswordStrengthLable.RightToLeft = RightToLeft.No;
            lblPasswordStrengthLable.Size = new Size(79, 15);
            lblPasswordStrengthLable.TabIndex = 47;
            lblPasswordStrengthLable.Text = "Надёжность:";
            lblPasswordStrengthLable.TextAlign = ContentAlignment.MiddleLeft;
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
            // picProfileNameError
            // 
            picProfileNameError.BackColor = Color.Transparent;
            picProfileNameError.BackgroundImage = (Image)resources.GetObject("picProfileNameError.BackgroundImage");
            picProfileNameError.BackgroundImageLayout = ImageLayout.Zoom;
            picProfileNameError.Location = new Point(31, 183);
            picProfileNameError.Name = "picProfileNameError";
            picProfileNameError.Size = new Size(24, 24);
            picProfileNameError.TabIndex = 50;
            picProfileNameError.TabStop = false;
            picProfileNameError.Visible = false;
            // 
            // picPasswordError
            // 
            picPasswordError.BackColor = Color.Transparent;
            picPasswordError.BackgroundImage = (Image)resources.GetObject("picPasswordError.BackgroundImage");
            picPasswordError.BackgroundImageLayout = ImageLayout.Zoom;
            picPasswordError.Location = new Point(31, 304);
            picPasswordError.Name = "picPasswordError";
            picPasswordError.Size = new Size(24, 24);
            picPasswordError.TabIndex = 51;
            picPasswordError.TabStop = false;
            picPasswordError.Visible = false;
            // 
            // picConfirmPasswordError
            // 
            picConfirmPasswordError.BackColor = Color.Transparent;
            picConfirmPasswordError.BackgroundImage = (Image)resources.GetObject("picConfirmPasswordError.BackgroundImage");
            picConfirmPasswordError.BackgroundImageLayout = ImageLayout.Zoom;
            picConfirmPasswordError.Location = new Point(31, 458);
            picConfirmPasswordError.Name = "picConfirmPasswordError";
            picConfirmPasswordError.Size = new Size(24, 24);
            picConfirmPasswordError.TabIndex = 52;
            picConfirmPasswordError.TabStop = false;
            picConfirmPasswordError.Visible = false;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnCreateProfile, 1, 0);
            tableLayoutPanelButtons.Location = new Point(63, 536);
            tableLayoutPanelButtons.MinimumSize = new Size(300, 45);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.Size = new Size(450, 45);
            tableLayoutPanelButtons.TabIndex = 64;
            tableLayoutPanelButtons.TagString = null;
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
            btnCancel.Size = new Size(215, 45);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Отмена";
            btnCancel.TipsColor = Color.Transparent;
            btnCancel.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.TipsForeColor = Color.Transparent;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.BackColor = Color.Transparent;
            btnCreateProfile.BackgroundImageLayout = ImageLayout.Center;
            btnCreateProfile.Dock = DockStyle.Fill;
            btnCreateProfile.FillColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.FillColor2 = Color.Transparent;
            btnCreateProfile.FillDisableColor = Color.Transparent;
            btnCreateProfile.FillHoverColor = Color.MediumSlateBlue;
            btnCreateProfile.FillPressColor = Color.Indigo;
            btnCreateProfile.FillSelectedColor = Color.Transparent;
            btnCreateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateProfile.ForeDisableColor = Color.Transparent;
            btnCreateProfile.ForeSelectedColor = Color.Transparent;
            btnCreateProfile.LightColor = Color.Transparent;
            btnCreateProfile.Location = new Point(235, 0);
            btnCreateProfile.Margin = new Padding(10, 0, 0, 0);
            btnCreateProfile.MinimumSize = new Size(1, 1);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Radius = 10;
            btnCreateProfile.RectColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectDisableColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectHoverColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectPressColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectSelectedColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.Size = new Size(215, 45);
            btnCreateProfile.TabIndex = 60;
            btnCreateProfile.Text = "Создать профиль";
            btnCreateProfile.TipsColor = Color.Transparent;
            btnCreateProfile.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateProfile.TipsForeColor = Color.Transparent;
            btnCreateProfile.Click += BtnCreateProfile_Click;
            // 
            // CreateProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(btnBack);
            Controls.Add(lblCreateProfileTitle);
            Controls.Add(lblProfileName);
            Controls.Add(txtProfileName);
            Controls.Add(lblProfileNameHint);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnShowPassword);
            Controls.Add(lblPasswordHint);
            Controls.Add(lblPasswordStrengthLable);
            Controls.Add(lblPasswordStrength);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnShowConfirmPassword);
            Controls.Add(tableLayoutPanelButtons);
            Controls.Add(picProfileNameError);
            Controls.Add(picPasswordError);
            Controls.Add(picConfirmPasswordError);
            Name = "CreateProfilePage";
            Padding = new Padding(10);
            Size = new Size(580, 720);
            ((System.ComponentModel.ISupportInitialize)picProfileNameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPasswordError).EndInit();
            ((System.ComponentModel.ISupportInitialize)picConfirmPasswordError).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picProfileNameError;
        private PictureBox picPasswordError;
        private PictureBox picConfirmPasswordError;
        private Button btnBack;
        private Label lblCreateProfileTitle;
        private Sunny.UI.UITextBox txtProfileName;
        private Label lblProfileName;
        private Sunny.UI.UIButton btnShowPassword;
        private Sunny.UI.UITextBox txtPassword;
        private Label lblPassword;
        private Sunny.UI.UIButton btnShowConfirmPassword;
        private Sunny.UI.UITextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Label lblProfileNameHint;
        private Label lblPasswordHint;
        private Label lblPasswordStrength;
        private Label lblPasswordStrengthLable;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UITableLayoutPanel tableLayoutPanelButtons;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnCreateProfile;
    }
}
