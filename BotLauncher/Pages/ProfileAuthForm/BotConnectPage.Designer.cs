namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class BotConnectPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotConnectPage));
            btnBack = new Button();
            btnShowToken = new Sunny.UI.UIButton();
            txtBotToken = new Sunny.UI.UITextBox();
            lblTokenTitle = new Label();
            lblPageTitle = new Label();
            pnlBotInfo = new Sunny.UI.UIPanel();
            picBotAvatar = new PictureBox();
            picBotInfo = new PictureBox();
            lblProfileName = new Label();
            lblBotId = new Label();
            lblBotName = new Label();
            lblUsernameBot = new Label();
            lblBotStatus = new Label();
            lblTokenHint = new Label();
            btnConnectBot = new Button();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            picTokenError = new PictureBox();
            pnlBotInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBotAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBotInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTokenError).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(30, 30, 36);
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
            btnBack.TabIndex = 13;
            btnBack.Text = "Назад";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // btnShowToken
            // 
            btnShowToken.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShowToken.BackColor = Color.FromArgb(30, 30, 36);
            btnShowToken.BackgroundImage = (Image)resources.GetObject("btnShowToken.BackgroundImage");
            btnShowToken.BackgroundImageLayout = ImageLayout.Center;
            btnShowToken.FillColor = Color.Transparent;
            btnShowToken.FillColor2 = Color.Transparent;
            btnShowToken.FillDisableColor = Color.Transparent;
            btnShowToken.FillHoverColor = Color.Transparent;
            btnShowToken.FillPressColor = Color.Transparent;
            btnShowToken.FillSelectedColor = Color.Transparent;
            btnShowToken.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowToken.ForeColor = Color.Transparent;
            btnShowToken.ForeDisableColor = Color.Transparent;
            btnShowToken.ForeHoverColor = Color.Transparent;
            btnShowToken.ForePressColor = Color.Transparent;
            btnShowToken.ForeSelectedColor = Color.Transparent;
            btnShowToken.LightColor = Color.Transparent;
            btnShowToken.Location = new Point(477, 354);
            btnShowToken.Margin = new Padding(5);
            btnShowToken.MinimumSize = new Size(1, 1);
            btnShowToken.Name = "btnShowToken";
            btnShowToken.Radius = 10;
            btnShowToken.RectColor = Color.FromArgb(42, 45, 54);
            btnShowToken.RectDisableColor = Color.Transparent;
            btnShowToken.RectHoverColor = Color.MediumPurple;
            btnShowToken.RectPressColor = Color.Indigo;
            btnShowToken.RectSelectedColor = Color.Transparent;
            btnShowToken.Size = new Size(40, 40);
            btnShowToken.TabIndex = 41;
            btnShowToken.TipsColor = Color.Transparent;
            btnShowToken.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowToken.TipsForeColor = Color.Transparent;
            btnShowToken.Click += BtnShowToken_Click;
            // 
            // txtBotToken
            // 
            txtBotToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBotToken.BackColor = Color.FromArgb(30, 30, 36);
            txtBotToken.ButtonFillColor = Color.Transparent;
            txtBotToken.ButtonFillHoverColor = Color.Transparent;
            txtBotToken.ButtonFillPressColor = Color.Transparent;
            txtBotToken.ButtonForeColor = Color.Transparent;
            txtBotToken.ButtonForeHoverColor = Color.Transparent;
            txtBotToken.ButtonForePressColor = Color.Transparent;
            txtBotToken.ButtonRectColor = Color.Transparent;
            txtBotToken.ButtonRectHoverColor = Color.Transparent;
            txtBotToken.ButtonRectPressColor = Color.Transparent;
            txtBotToken.ButtonStyleInherited = false;
            txtBotToken.FillColor = Color.FromArgb(28, 30, 36);
            txtBotToken.FillColor2 = Color.FromArgb(28, 30, 36);
            txtBotToken.FillDisableColor = Color.FromArgb(28, 30, 36);
            txtBotToken.FillReadOnlyColor = Color.FromArgb(28, 30, 36);
            txtBotToken.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBotToken.ForeColor = Color.Transparent;
            txtBotToken.ForeDisableColor = Color.Transparent;
            txtBotToken.ForeReadOnlyColor = Color.Transparent;
            txtBotToken.Location = new Point(63, 354);
            txtBotToken.Margin = new Padding(5);
            txtBotToken.MinimumSize = new Size(1, 16);
            txtBotToken.Name = "txtBotToken";
            txtBotToken.RectColor = Color.FromArgb(42, 42, 54);
            txtBotToken.RectDisableColor = Color.Transparent;
            txtBotToken.RectReadOnlyColor = Color.Transparent;
            txtBotToken.ScrollBarBackColor = Color.Transparent;
            txtBotToken.ScrollBarColor = Color.Transparent;
            txtBotToken.ScrollBarStyleInherited = false;
            txtBotToken.ShowText = false;
            txtBotToken.Size = new Size(404, 40);
            txtBotToken.SymbolColor = Color.Transparent;
            txtBotToken.TabIndex = 40;
            txtBotToken.TextAlignment = ContentAlignment.MiddleLeft;
            txtBotToken.Watermark = "123456789:ABCdefGHIjklMNOpqrSTUvwxYZ";
            txtBotToken.WatermarkActiveColor = Color.Transparent;
            // 
            // lblTokenTitle
            // 
            lblTokenTitle.AutoSize = true;
            lblTokenTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTokenTitle.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblTokenTitle.Location = new Point(63, 330);
            lblTokenTitle.Name = "lblTokenTitle";
            lblTokenTitle.RightToLeft = RightToLeft.No;
            lblTokenTitle.Size = new Size(157, 19);
            lblTokenTitle.TabIndex = 39;
            lblTokenTitle.Text = "Telegram Bot API Token";
            lblTokenTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoEllipsis = true;
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(63, 188);
            lblPageTitle.Margin = new Padding(5);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(271, 31);
            lblPageTitle.TabIndex = 38;
            lblPageTitle.Text = "Подключение Telegram-бота";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblPageTitle.UseCompatibleTextRendering = true;
            // 
            // pnlBotInfo
            // 
            pnlBotInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBotInfo.Controls.Add(picBotAvatar);
            pnlBotInfo.Controls.Add(picBotInfo);
            pnlBotInfo.Controls.Add(lblProfileName);
            pnlBotInfo.Controls.Add(lblBotId);
            pnlBotInfo.Controls.Add(lblBotName);
            pnlBotInfo.Controls.Add(lblUsernameBot);
            pnlBotInfo.Controls.Add(lblBotStatus);
            pnlBotInfo.FillColor = Color.FromArgb(34, 36, 44);
            pnlBotInfo.FillColor2 = Color.FromArgb(34, 36, 44);
            pnlBotInfo.FillDisableColor = Color.FromArgb(34, 36, 44);
            pnlBotInfo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlBotInfo.ForeColor = Color.Transparent;
            pnlBotInfo.ForeDisableColor = Color.Transparent;
            pnlBotInfo.Location = new Point(63, 229);
            pnlBotInfo.Margin = new Padding(4, 5, 4, 5);
            pnlBotInfo.MinimumSize = new Size(1, 1);
            pnlBotInfo.Name = "pnlBotInfo";
            pnlBotInfo.Radius = 10;
            pnlBotInfo.RectColor = Color.FromArgb(42, 45, 54);
            pnlBotInfo.RectDisableColor = Color.Transparent;
            pnlBotInfo.Size = new Size(454, 89);
            pnlBotInfo.TabIndex = 42;
            pnlBotInfo.Text = null;
            pnlBotInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // picBotAvatar
            // 
            picBotAvatar.BackColor = Color.FromArgb(34, 36, 44);
            picBotAvatar.BackgroundImage = (Image)resources.GetObject("picBotAvatar.BackgroundImage");
            picBotAvatar.BackgroundImageLayout = ImageLayout.Zoom;
            picBotAvatar.Location = new Point(5, 19);
            picBotAvatar.Name = "picBotAvatar";
            picBotAvatar.Size = new Size(50, 50);
            picBotAvatar.TabIndex = 30;
            picBotAvatar.TabStop = false;
            // 
            // picBotInfo
            // 
            picBotInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picBotInfo.BackColor = Color.FromArgb(34, 36, 44);
            picBotInfo.BackgroundImage = (Image)resources.GetObject("picBotInfo.BackgroundImage");
            picBotInfo.BackgroundImageLayout = ImageLayout.Zoom;
            picBotInfo.Location = new Point(409, 29);
            picBotInfo.Name = "picBotInfo";
            picBotInfo.Size = new Size(35, 35);
            picBotInfo.TabIndex = 51;
            picBotInfo.TabStop = false;
            // 
            // lblProfileName
            // 
            lblProfileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProfileName.AutoEllipsis = true;
            lblProfileName.BackColor = Color.FromArgb(34, 36, 44);
            lblProfileName.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblProfileName.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblProfileName.Location = new Point(57, 6);
            lblProfileName.Margin = new Padding(0);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.RightToLeft = RightToLeft.No;
            lblProfileName.Size = new Size(347, 13);
            lblProfileName.TabIndex = 45;
            lblProfileName.Text = "Профиль: (не указано)";
            lblProfileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotId
            // 
            lblBotId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotId.AutoEllipsis = true;
            lblBotId.BackColor = Color.FromArgb(34, 36, 44);
            lblBotId.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblBotId.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblBotId.Location = new Point(57, 22);
            lblBotId.Margin = new Padding(0);
            lblBotId.Name = "lblBotId";
            lblBotId.RightToLeft = RightToLeft.No;
            lblBotId.Size = new Size(347, 13);
            lblBotId.TabIndex = 46;
            lblBotId.Text = "Bot ID: (Не привязан)";
            lblBotId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotName
            // 
            lblBotName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotName.AutoEllipsis = true;
            lblBotName.BackColor = Color.FromArgb(34, 36, 44);
            lblBotName.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblBotName.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblBotName.Location = new Point(57, 38);
            lblBotName.Margin = new Padding(0);
            lblBotName.Name = "lblBotName";
            lblBotName.RightToLeft = RightToLeft.No;
            lblBotName.Size = new Size(347, 13);
            lblBotName.TabIndex = 48;
            lblBotName.Text = "Название бота: —";
            lblBotName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsernameBot
            // 
            lblUsernameBot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsernameBot.AutoEllipsis = true;
            lblUsernameBot.BackColor = Color.FromArgb(34, 36, 44);
            lblUsernameBot.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblUsernameBot.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblUsernameBot.Location = new Point(57, 54);
            lblUsernameBot.Margin = new Padding(0);
            lblUsernameBot.Name = "lblUsernameBot";
            lblUsernameBot.RightToLeft = RightToLeft.No;
            lblUsernameBot.Size = new Size(347, 13);
            lblUsernameBot.TabIndex = 49;
            lblUsernameBot.Text = "Юзернейм бота: —";
            lblUsernameBot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotStatus
            // 
            lblBotStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBotStatus.AutoEllipsis = true;
            lblBotStatus.BackColor = Color.FromArgb(34, 36, 44);
            lblBotStatus.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            lblBotStatus.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblBotStatus.Location = new Point(57, 70);
            lblBotStatus.Margin = new Padding(0);
            lblBotStatus.Name = "lblBotStatus";
            lblBotStatus.RightToLeft = RightToLeft.No;
            lblBotStatus.Size = new Size(347, 13);
            lblBotStatus.TabIndex = 50;
            lblBotStatus.Text = "Статус: Не подключен";
            lblBotStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTokenHint
            // 
            lblTokenHint.AutoEllipsis = true;
            lblTokenHint.AutoSize = true;
            lblTokenHint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTokenHint.ForeColor = Color.FromArgb(1, 161, 161, 170);
            lblTokenHint.Location = new Point(69, 399);
            lblTokenHint.Name = "lblTokenHint";
            lblTokenHint.RightToLeft = RightToLeft.No;
            lblTokenHint.Size = new Size(265, 13);
            lblTokenHint.TabIndex = 43;
            lblTokenHint.Text = "Получить токен можно у @BotFather в Telegram";
            lblTokenHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConnectBot
            // 
            btnConnectBot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnConnectBot.BackColor = Color.FromArgb(124, 58, 237);
            btnConnectBot.BackgroundImageLayout = ImageLayout.Zoom;
            btnConnectBot.FlatAppearance.BorderSize = 0;
            btnConnectBot.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnConnectBot.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnConnectBot.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnConnectBot.FlatStyle = FlatStyle.Flat;
            btnConnectBot.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConnectBot.ForeColor = Color.White;
            btnConnectBot.Location = new Point(63, 442);
            btnConnectBot.Margin = new Padding(0);
            btnConnectBot.Name = "btnConnectBot";
            btnConnectBot.Size = new Size(454, 45);
            btnConnectBot.TabIndex = 44;
            btnConnectBot.Text = "Подключить бота";
            btnConnectBot.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConnectBot.UseVisualStyleBackColor = false;
            btnConnectBot.Click += BtnConnectBot_Click;
            // 
            // uiToolTip1
            // 
            uiToolTip1.BackColor = Color.FromArgb(30, 30, 36);
            uiToolTip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiToolTip1.ForeColor = Color.White;
            uiToolTip1.OwnerDraw = true;
            uiToolTip1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // picTokenError
            // 
            picTokenError.BackColor = Color.Transparent;
            picTokenError.BackgroundImage = (Image)resources.GetObject("picTokenError.BackgroundImage");
            picTokenError.BackgroundImageLayout = ImageLayout.Zoom;
            picTokenError.Cursor = Cursors.Hand;
            picTokenError.Location = new Point(30, 363);
            picTokenError.Name = "picTokenError";
            picTokenError.Size = new Size(25, 25);
            picTokenError.TabIndex = 50;
            picTokenError.TabStop = false;
            picTokenError.Visible = false;
            // 
            // BotConnectPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(btnBack);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlBotInfo);
            Controls.Add(lblTokenTitle);
            Controls.Add(txtBotToken);
            Controls.Add(btnShowToken);
            Controls.Add(lblTokenHint);
            Controls.Add(btnConnectBot);
            Controls.Add(picTokenError);
            Name = "BotConnectPage";
            Padding = new Padding(10);
            Size = new Size(580, 720);
            pnlBotInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBotAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBotInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTokenError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picTokenError;
        private Button btnBack;
        private Sunny.UI.UIButton btnShowToken;
        private Sunny.UI.UITextBox txtBotToken;
        private Label lblTokenTitle;
        private Label lblPageTitle;
        private Sunny.UI.UIPanel pnlBotInfo;
        private Label lblTokenHint;
        private Button btnConnectBot;
        private PictureBox picBotAvatar;
        private Label lblBotId;
        private Label lblProfileName;
        private Label lblBotStatus;
        private Label lblUsernameBot;
        private Label lblBotName;
        private Sunny.UI.UIToolTip uiToolTip1;
        private PictureBox picBotInfo;
    }
}