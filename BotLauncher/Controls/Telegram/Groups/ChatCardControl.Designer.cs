namespace BotLauncher.Controls.Telegram.Groups
{
    partial class ChatCardControl
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
            cardPanel = new Sunny.UI.UIPanel();
            pnlAvatar = new Sunny.UI.UIPanel();
            lblChatName = new Label();
            lblChatUsername = new Label();
            lblChatType = new Label();
            lblBotRole = new Label();
            lblChatId = new Label();
            lblMembers = new Label();
            lblChatStatus = new Label();
            btnChatMenu = new Button();
            cardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.Transparent;
            cardPanel.Controls.Add(pnlAvatar);
            cardPanel.Controls.Add(lblChatName);
            cardPanel.Controls.Add(lblChatUsername);
            cardPanel.Controls.Add(lblChatType);
            cardPanel.Controls.Add(lblBotRole);
            cardPanel.Controls.Add(lblChatId);
            cardPanel.Controls.Add(lblMembers);
            cardPanel.Controls.Add(lblChatStatus);
            cardPanel.Controls.Add(btnChatMenu);
            cardPanel.Dock = DockStyle.Fill;
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
            cardPanel.Radius = 20;
            cardPanel.RectColor = Color.FromArgb(58, 58, 69);
            cardPanel.RectDisableColor = Color.Empty;
            cardPanel.Size = new Size(240, 140);
            cardPanel.TabIndex = 32;
            cardPanel.Text = null;
            cardPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlAvatar
            // 
            pnlAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pnlAvatar.FillColor = Color.Transparent;
            pnlAvatar.FillColor2 = Color.Transparent;
            pnlAvatar.FillDisableColor = Color.Transparent;
            pnlAvatar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlAvatar.ForeColor = Color.Transparent;
            pnlAvatar.ForeDisableColor = Color.Transparent;
            pnlAvatar.Location = new Point(10, 9);
            pnlAvatar.Margin = new Padding(4, 5, 4, 5);
            pnlAvatar.MinimumSize = new Size(1, 1);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Radius = 15;
            pnlAvatar.RectColor = Color.Silver;
            pnlAvatar.RectDisableColor = Color.Transparent;
            pnlAvatar.Size = new Size(64, 64);
            pnlAvatar.TabIndex = 35;
            pnlAvatar.Text = null;
            pnlAvatar.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblChatName
            // 
            lblChatName.AutoEllipsis = true;
            lblChatName.FlatStyle = FlatStyle.Flat;
            lblChatName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblChatName.ImageAlign = ContentAlignment.MiddleLeft;
            lblChatName.ImeMode = ImeMode.NoControl;
            lblChatName.Location = new Point(76, 10);
            lblChatName.Name = "lblChatName";
            lblChatName.Size = new Size(139, 15);
            lblChatName.TabIndex = 29;
            lblChatName.Text = "Название канала";
            lblChatName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChatUsername
            // 
            lblChatUsername.AutoEllipsis = true;
            lblChatUsername.BackColor = Color.Transparent;
            lblChatUsername.FlatStyle = FlatStyle.Flat;
            lblChatUsername.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblChatUsername.ForeColor = Color.FromArgb(156, 163, 175);
            lblChatUsername.ImageAlign = ContentAlignment.MiddleLeft;
            lblChatUsername.ImeMode = ImeMode.NoControl;
            lblChatUsername.Location = new Point(76, 27);
            lblChatUsername.Name = "lblChatUsername";
            lblChatUsername.Size = new Size(122, 15);
            lblChatUsername.TabIndex = 33;
            lblChatUsername.Text = "@username";
            lblChatUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChatType
            // 
            lblChatType.AutoEllipsis = true;
            lblChatType.BackColor = Color.Transparent;
            lblChatType.FlatStyle = FlatStyle.Flat;
            lblChatType.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblChatType.ForeColor = Color.FromArgb(156, 163, 175);
            lblChatType.ImageAlign = ContentAlignment.MiddleLeft;
            lblChatType.ImeMode = ImeMode.NoControl;
            lblChatType.Location = new Point(76, 42);
            lblChatType.Name = "lblChatType";
            lblChatType.Size = new Size(122, 15);
            lblChatType.TabIndex = 31;
            lblChatType.Text = "Канал";
            lblChatType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBotRole
            // 
            lblBotRole.AutoEllipsis = true;
            lblBotRole.BackColor = Color.Transparent;
            lblBotRole.FlatStyle = FlatStyle.Flat;
            lblBotRole.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblBotRole.ForeColor = Color.FromArgb(156, 163, 175);
            lblBotRole.ImageAlign = ContentAlignment.MiddleLeft;
            lblBotRole.ImeMode = ImeMode.NoControl;
            lblBotRole.Location = new Point(76, 57);
            lblBotRole.Name = "lblBotRole";
            lblBotRole.Size = new Size(122, 15);
            lblBotRole.TabIndex = 32;
            lblBotRole.Text = "Роль: Бот";
            lblBotRole.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChatId
            // 
            lblChatId.AutoEllipsis = true;
            lblChatId.BackColor = Color.Transparent;
            lblChatId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblChatId.ForeColor = Color.FromArgb(156, 163, 175);
            lblChatId.ImeMode = ImeMode.NoControl;
            lblChatId.Location = new Point(8, 77);
            lblChatId.Name = "lblChatId";
            lblChatId.Size = new Size(207, 20);
            lblChatId.TabIndex = 29;
            lblChatId.Text = "ID чата: -671232182136";
            lblChatId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMembers
            // 
            lblMembers.AutoEllipsis = true;
            lblMembers.BackColor = Color.Transparent;
            lblMembers.FlatStyle = FlatStyle.Flat;
            lblMembers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMembers.ForeColor = Color.FromArgb(156, 163, 175);
            lblMembers.ImageAlign = ContentAlignment.MiddleLeft;
            lblMembers.ImeMode = ImeMode.NoControl;
            lblMembers.Location = new Point(8, 94);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(207, 20);
            lblMembers.TabIndex = 29;
            lblMembers.Text = "Подписчиков: 21 000 200";
            lblMembers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChatStatus
            // 
            lblChatStatus.AutoEllipsis = true;
            lblChatStatus.BackColor = Color.Transparent;
            lblChatStatus.FlatStyle = FlatStyle.Flat;
            lblChatStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblChatStatus.ForeColor = Color.FromArgb(156, 163, 175);
            lblChatStatus.ImageAlign = ContentAlignment.MiddleLeft;
            lblChatStatus.ImeMode = ImeMode.NoControl;
            lblChatStatus.Location = new Point(8, 111);
            lblChatStatus.Name = "lblChatStatus";
            lblChatStatus.Size = new Size(207, 20);
            lblChatStatus.TabIndex = 34;
            lblChatStatus.Text = "Статус: Подключено";
            lblChatStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnChatMenu
            // 
            btnChatMenu.BackgroundImage = Properties.Resources.ellipsis_vertical_solid;
            btnChatMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnChatMenu.Cursor = Cursors.Hand;
            btnChatMenu.FlatAppearance.BorderSize = 0;
            btnChatMenu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChatMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChatMenu.FlatStyle = FlatStyle.Flat;
            btnChatMenu.Location = new Point(204, 48);
            btnChatMenu.Name = "btnChatMenu";
            btnChatMenu.Size = new Size(36, 35);
            btnChatMenu.TabIndex = 30;
            btnChatMenu.UseVisualStyleBackColor = true;
            // 
            // ChatCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(cardPanel);
            Name = "ChatCardControl";
            Size = new Size(240, 140);
            cardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel cardPanel;
        private Button btnChatMenu;
        private Label lblChatType;
        private Label lblMembers;
        private Label lblChatId;
        private Label lblChatName;
        private Label lblBotRole;
        private Label lblChatUsername;
        private Label lblChatStatus;
        private Sunny.UI.UIPanel pnlAvatar;
    }
}
