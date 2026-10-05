namespace BotLauncher
{
    partial class TelegramSettingsPage
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

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelegramSettingsPage));
            navigationButtonsPanel = new Sunny.UI.UIPanel();
            lblDescription = new Label();
            lblTitle = new Label();
            btnGroups = new Button();
            btnTemplates = new Button();
            btnAttachments = new Button();
            btnBotSettings = new Button();
            contentPanel = new Sunny.UI.UIPanel();
            navigationButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navigationButtonsPanel
            // 
            navigationButtonsPanel.BackColor = Color.Transparent;
            navigationButtonsPanel.Controls.Add(lblDescription);
            navigationButtonsPanel.Controls.Add(lblTitle);
            navigationButtonsPanel.Controls.Add(btnGroups);
            navigationButtonsPanel.Controls.Add(btnTemplates);
            navigationButtonsPanel.Controls.Add(btnAttachments);
            navigationButtonsPanel.Controls.Add(btnBotSettings);
            navigationButtonsPanel.Dock = DockStyle.Top;
            navigationButtonsPanel.FillColor = Color.FromArgb(32, 34, 39);
            navigationButtonsPanel.FillColor2 = Color.Transparent;
            navigationButtonsPanel.FillDisableColor = Color.Transparent;
            navigationButtonsPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            navigationButtonsPanel.ForeColor = Color.Transparent;
            navigationButtonsPanel.ForeDisableColor = Color.Transparent;
            navigationButtonsPanel.Location = new Point(0, 0);
            navigationButtonsPanel.Margin = new Padding(5);
            navigationButtonsPanel.MinimumSize = new Size(1, 1);
            navigationButtonsPanel.Name = "navigationButtonsPanel";
            navigationButtonsPanel.Padding = new Padding(5);
            navigationButtonsPanel.Radius = 0;
            navigationButtonsPanel.RectColor = Color.Transparent;
            navigationButtonsPanel.RectDisableColor = Color.Empty;
            navigationButtonsPanel.Size = new Size(976, 50);
            navigationButtonsPanel.Style = Sunny.UI.UIStyle.Custom;
            navigationButtonsPanel.TabIndex = 18;
            navigationButtonsPanel.Text = null;
            navigationButtonsPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoEllipsis = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(8, 27);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(297, 16);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Настройки подключения и управления ботом";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(8, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 22);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Telegram: Настройки";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGroups
            // 
            btnGroups.BackgroundImageLayout = ImageLayout.None;
            btnGroups.FlatAppearance.BorderColor = Color.FromArgb(42, 47, 58);
            btnGroups.FlatAppearance.BorderSize = 0;
            btnGroups.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnGroups.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnGroups.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            btnGroups.FlatStyle = FlatStyle.Flat;
            btnGroups.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnGroups.ForeColor = Color.White;
            btnGroups.Image = (Image)resources.GetObject("btnGroups.Image");
            btnGroups.ImageAlign = ContentAlignment.MiddleRight;
            btnGroups.Location = new Point(311, 3);
            btnGroups.Name = "btnGroups";
            btnGroups.Size = new Size(110, 45);
            btnGroups.TabIndex = 0;
            btnGroups.Text = " Группы";
            btnGroups.TextAlign = ContentAlignment.MiddleLeft;
            btnGroups.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGroups.UseVisualStyleBackColor = true;
            btnGroups.Click += btnGroups_Click;
            // 
            // btnTemplates
            // 
            btnTemplates.BackgroundImageLayout = ImageLayout.None;
            btnTemplates.FlatAppearance.BorderColor = Color.FromArgb(42, 47, 58);
            btnTemplates.FlatAppearance.BorderSize = 0;
            btnTemplates.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnTemplates.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnTemplates.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            btnTemplates.FlatStyle = FlatStyle.Flat;
            btnTemplates.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTemplates.ForeColor = Color.White;
            btnTemplates.Image = (Image)resources.GetObject("btnTemplates.Image");
            btnTemplates.ImageAlign = ContentAlignment.MiddleRight;
            btnTemplates.Location = new Point(429, 3);
            btnTemplates.Name = "btnTemplates";
            btnTemplates.Size = new Size(110, 45);
            btnTemplates.TabIndex = 1;
            btnTemplates.Text = " Шаблоны";
            btnTemplates.TextAlign = ContentAlignment.MiddleLeft;
            btnTemplates.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTemplates.UseVisualStyleBackColor = true;
            btnTemplates.Click += btnTemplates_Click;
            // 
            // btnAttachments
            // 
            btnAttachments.BackgroundImageLayout = ImageLayout.None;
            btnAttachments.FlatAppearance.BorderColor = Color.FromArgb(42, 47, 58);
            btnAttachments.FlatAppearance.BorderSize = 0;
            btnAttachments.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnAttachments.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnAttachments.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            btnAttachments.FlatStyle = FlatStyle.Flat;
            btnAttachments.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAttachments.ForeColor = Color.White;
            btnAttachments.Image = (Image)resources.GetObject("btnAttachments.Image");
            btnAttachments.ImageAlign = ContentAlignment.MiddleRight;
            btnAttachments.Location = new Point(547, 3);
            btnAttachments.Name = "btnAttachments";
            btnAttachments.Size = new Size(110, 45);
            btnAttachments.TabIndex = 2;
            btnAttachments.Text = " Вложения";
            btnAttachments.TextAlign = ContentAlignment.MiddleLeft;
            btnAttachments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttachments.UseVisualStyleBackColor = true;
            btnAttachments.Click += btnAttachments_Click;
            // 
            // btnBotSettings
            // 
            btnBotSettings.BackgroundImageLayout = ImageLayout.None;
            btnBotSettings.FlatAppearance.BorderColor = Color.FromArgb(42, 47, 58);
            btnBotSettings.FlatAppearance.BorderSize = 0;
            btnBotSettings.FlatAppearance.CheckedBackColor = Color.Indigo;
            btnBotSettings.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnBotSettings.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            btnBotSettings.FlatStyle = FlatStyle.Flat;
            btnBotSettings.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBotSettings.ForeColor = Color.White;
            btnBotSettings.Image = (Image)resources.GetObject("btnBotSettings.Image");
            btnBotSettings.ImageAlign = ContentAlignment.MiddleRight;
            btnBotSettings.Location = new Point(665, 3);
            btnBotSettings.Name = "btnBotSettings";
            btnBotSettings.Size = new Size(110, 45);
            btnBotSettings.TabIndex = 3;
            btnBotSettings.Text = " Настройки";
            btnBotSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnBotSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBotSettings.UseVisualStyleBackColor = true;
            btnBotSettings.Click += btnBotSettings_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(27, 29, 36);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.FillColor = Color.Transparent;
            contentPanel.FillColor2 = Color.Transparent;
            contentPanel.FillDisableColor = Color.Transparent;
            contentPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            contentPanel.ForeColor = Color.Transparent;
            contentPanel.ForeDisableColor = Color.Transparent;
            contentPanel.Location = new Point(0, 50);
            contentPanel.Margin = new Padding(0);
            contentPanel.MinimumSize = new Size(1, 1);
            contentPanel.Name = "contentPanel";
            contentPanel.Radius = 0;
            contentPanel.RectColor = Color.Transparent;
            contentPanel.RectDisableColor = Color.Empty;
            contentPanel.Size = new Size(976, 679);
            contentPanel.TabIndex = 17;
            contentPanel.Text = null;
            contentPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TelegramSettingsPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(27, 29, 36);
            Controls.Add(contentPanel);
            Controls.Add(navigationButtonsPanel);
            Name = "TelegramSettingsPage";
            Size = new Size(976, 729);
            navigationButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Поля объявлены в правильном порядке
        private Sunny.UI.UIPanel contentPanel;
        private Sunny.UI.UIPanel navigationButtonsPanel;
        private Button btnGroups;
        private Button btnTemplates;
        private Button btnAttachments;
        private Button btnBotSettings;
        private Label lblDescription;
        private Label lblTitle;
    }
}