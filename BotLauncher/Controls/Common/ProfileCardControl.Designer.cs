namespace BotLauncher.Controls
{
    partial class ProfileCardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileCardControl));
            cardPanel = new Sunny.UI.UIPanel();
            btnOpenProfile = new Button();
            btnProfileMenu = new Button();
            lblFormatVersion = new Label();
            lblLastUsed = new Label();
            lblProfileUsername = new Label();
            lblProfileName = new Label();
            picProfileIcon = new PictureBox();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfileIcon).BeginInit();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardPanel.BackColor = Color.Transparent;
            cardPanel.Controls.Add(btnOpenProfile);
            cardPanel.Controls.Add(btnProfileMenu);
            cardPanel.Controls.Add(lblFormatVersion);
            cardPanel.Controls.Add(lblLastUsed);
            cardPanel.Controls.Add(lblProfileUsername);
            cardPanel.Controls.Add(lblProfileName);
            cardPanel.Controls.Add(picProfileIcon);
            cardPanel.FillColor = Color.FromArgb(35, 39, 48);
            cardPanel.FillColor2 = Color.Transparent;
            cardPanel.FillDisableColor = Color.Transparent;
            cardPanel.Font = new Font("Microsoft Sans Serif", 12F);
            cardPanel.ForeColor = Color.Transparent;
            cardPanel.ForeDisableColor = Color.Transparent;
            cardPanel.Location = new Point(0, 0);
            cardPanel.Margin = new Padding(0);
            cardPanel.MinimumSize = new Size(1, 1);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(5);
            cardPanel.Radius = 12;
            cardPanel.RectColor = Color.FromArgb(42, 47, 58);
            cardPanel.RectDisableColor = Color.Empty;
            cardPanel.Size = new Size(523, 100);
            cardPanel.TabIndex = 33;
            cardPanel.Text = null;
            cardPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnOpenProfile
            // 
            btnOpenProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOpenProfile.BackColor = Color.FromArgb(124, 58, 237);
            btnOpenProfile.BackgroundImageLayout = ImageLayout.Zoom;
            btnOpenProfile.FlatAppearance.BorderColor = Color.FromArgb(42, 45, 54);
            btnOpenProfile.FlatAppearance.BorderSize = 0;
            btnOpenProfile.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnOpenProfile.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnOpenProfile.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnOpenProfile.FlatStyle = FlatStyle.Flat;
            btnOpenProfile.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpenProfile.ForeColor = Color.White;
            btnOpenProfile.ImageAlign = ContentAlignment.MiddleRight;
            btnOpenProfile.Location = new Point(428, 55);
            btnOpenProfile.Margin = new Padding(10);
            btnOpenProfile.Name = "btnOpenProfile";
            btnOpenProfile.Size = new Size(80, 30);
            btnOpenProfile.TabIndex = 33;
            btnOpenProfile.Text = "Открыть";
            btnOpenProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpenProfile.UseVisualStyleBackColor = false;
            btnOpenProfile.Click += btnOpenProfile_Click;
            // 
            // btnProfileMenu
            // 
            btnProfileMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfileMenu.BackgroundImage = (Image)resources.GetObject("btnProfileMenu.BackgroundImage");
            btnProfileMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnProfileMenu.Cursor = Cursors.Hand;
            btnProfileMenu.FlatAppearance.BorderSize = 0;
            btnProfileMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProfileMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfileMenu.FlatStyle = FlatStyle.Flat;
            btnProfileMenu.Location = new Point(478, 15);
            btnProfileMenu.Name = "btnProfileMenu";
            btnProfileMenu.Size = new Size(25, 25);
            btnProfileMenu.TabIndex = 38;
            btnProfileMenu.UseVisualStyleBackColor = true;
            btnProfileMenu.Click += btnProfileMenu_Click;
            // 
            // lblFormatVersion
            // 
            lblFormatVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFormatVersion.AutoEllipsis = true;
            lblFormatVersion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFormatVersion.ForeColor = Color.FromArgb(161, 161, 170);
            lblFormatVersion.Location = new Point(85, 68);
            lblFormatVersion.Name = "lblFormatVersion";
            lblFormatVersion.Size = new Size(343, 15);
            lblFormatVersion.TabIndex = 39;
            lblFormatVersion.Text = "Версия файла: v.0.1";
            lblFormatVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLastUsed
            // 
            lblLastUsed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLastUsed.AutoEllipsis = true;
            lblLastUsed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLastUsed.ForeColor = Color.FromArgb(161, 161, 170);
            lblLastUsed.Location = new Point(85, 53);
            lblLastUsed.Name = "lblLastUsed";
            lblLastUsed.Size = new Size(343, 15);
            lblLastUsed.TabIndex = 37;
            lblLastUsed.Text = "Последнее использование: 00.00.0000 00:00";
            lblLastUsed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfileUsername
            // 
            lblProfileUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProfileUsername.AutoEllipsis = true;
            lblProfileUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblProfileUsername.ForeColor = Color.FromArgb(161, 161, 170);
            lblProfileUsername.Location = new Point(85, 38);
            lblProfileUsername.Name = "lblProfileUsername";
            lblProfileUsername.Size = new Size(343, 15);
            lblProfileUsername.TabIndex = 36;
            lblProfileUsername.Text = "@username";
            lblProfileUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProfileName
            // 
            lblProfileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProfileName.AutoEllipsis = true;
            lblProfileName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblProfileName.Location = new Point(85, 17);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(343, 20);
            lblProfileName.TabIndex = 35;
            lblProfileName.Text = "Название профиля";
            lblProfileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picProfileIcon
            // 
            picProfileIcon.BackColor = Color.Transparent;
            picProfileIcon.BackgroundImage = Properties.Resources.robot_solid;
            picProfileIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picProfileIcon.Location = new Point(15, 18);
            picProfileIcon.Margin = new Padding(5);
            picProfileIcon.Name = "picProfileIcon";
            picProfileIcon.Size = new Size(64, 64);
            picProfileIcon.TabIndex = 34;
            picProfileIcon.TabStop = false;
            // 
            // ProfileCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(cardPanel);
            ForeColor = Color.Transparent;
            Name = "ProfileCardControl";
            Size = new Size(523, 100);
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfileIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel cardPanel;
        private Button btnOpenProfile;
        private Button btnProfileMenu;
        private Label lblLastUsed;
        private Label lblProfileUsername;
        private Label lblProfileName;
        private PictureBox picProfileIcon;
        private Label lblFormatVersion;
    }
}
