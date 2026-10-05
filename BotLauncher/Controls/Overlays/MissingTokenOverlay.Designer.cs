namespace BotLauncher.Controls
{
    partial class MissingTokenOverlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissingTokenOverlay));
            pnlContainer = new Sunny.UI.UIPanel();
            btnClose = new Sunny.UI.UIButton();
            picBotIcon = new PictureBox();
            lblTitle = new Label();
            lblDescription = new Label();
            btnOpenSettings = new Sunny.UI.UIButton();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBotIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.Transparent;
            pnlContainer.Controls.Add(btnClose);
            pnlContainer.Controls.Add(picBotIcon);
            pnlContainer.Controls.Add(lblTitle);
            pnlContainer.Controls.Add(lblDescription);
            pnlContainer.Controls.Add(btnOpenSettings);
            pnlContainer.FillColor = Color.FromArgb(34, 36, 44);
            pnlContainer.FillColor2 = Color.Transparent;
            pnlContainer.FillDisableColor = Color.Transparent;
            pnlContainer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlContainer.ForeColor = Color.Transparent;
            pnlContainer.ForeDisableColor = Color.Transparent;
            pnlContainer.Location = new Point(406, 194);
            pnlContainer.Margin = new Padding(4, 5, 4, 5);
            pnlContainer.MinimumSize = new Size(1, 1);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Radius = 16;
            pnlContainer.RectColor = Color.FromArgb(124, 58, 237);
            pnlContainer.RectDisableColor = Color.Transparent;
            pnlContainer.Size = new Size(420, 380);
            pnlContainer.TabIndex = 1;
            pnlContainer.Text = null;
            pnlContainer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.icon_close_normal;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FillColor = Color.Transparent;
            btnClose.FillColor2 = Color.Transparent;
            btnClose.FillDisableColor = Color.Transparent;
            btnClose.FillHoverColor = Color.Transparent;
            btnClose.FillPressColor = Color.Transparent;
            btnClose.FillSelectedColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.ForeColor = Color.Transparent;
            btnClose.ForeDisableColor = Color.Transparent;
            btnClose.ForeHoverColor = Color.Transparent;
            btnClose.ForePressColor = Color.Transparent;
            btnClose.ForeSelectedColor = Color.Transparent;
            btnClose.LightColor = Color.Transparent;
            btnClose.Location = new Point(378, 10);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 8;
            btnClose.RectColor = Color.Transparent;
            btnClose.RectDisableColor = Color.Transparent;
            btnClose.RectHoverColor = Color.Transparent;
            btnClose.RectPressColor = Color.Transparent;
            btnClose.RectSelectedColor = Color.Transparent;
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 0;
            btnClose.TipsColor = Color.Transparent;
            btnClose.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClose.Click += BtnClose_Click;
            // 
            // picBotIcon
            // 
            picBotIcon.BackColor = Color.Transparent;
            picBotIcon.BackgroundImage = Properties.Resources.robot_solid;
            picBotIcon.BackgroundImageLayout = ImageLayout.Stretch;
            picBotIcon.Location = new Point(170, 30);
            picBotIcon.Name = "picBotIcon";
            picBotIcon.Size = new Size(80, 80);
            picBotIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picBotIcon.TabIndex = 1;
            picBotIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 120);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 35);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Бот не настроен";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(161, 161, 170);
            lblDescription.Location = new Point(20, 160);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(380, 100);
            lblDescription.TabIndex = 3;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOpenSettings
            // 
            btnOpenSettings.FillColor = Color.FromArgb(124, 58, 237);
            btnOpenSettings.FillHoverColor = Color.FromArgb(139, 92, 246);
            btnOpenSettings.FillPressColor = Color.FromArgb(109, 40, 217);
            btnOpenSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOpenSettings.LightColor = Color.Transparent;
            btnOpenSettings.Location = new Point(20, 285);
            btnOpenSettings.MinimumSize = new Size(1, 1);
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.Radius = 12;
            btnOpenSettings.RectColor = Color.Transparent;
            btnOpenSettings.RectDisableColor = Color.Transparent;
            btnOpenSettings.RectHoverColor = Color.Transparent;
            btnOpenSettings.RectPressColor = Color.Transparent;
            btnOpenSettings.RectSelectedColor = Color.Transparent;
            btnOpenSettings.Size = new Size(380, 48);
            btnOpenSettings.TabIndex = 4;
            btnOpenSettings.Text = "Перейти к настройкам Telegram";
            btnOpenSettings.TipsColor = Color.White;
            btnOpenSettings.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOpenSettings.Click += BtnOpenSettings_Click;
            // 
            // MissingTokenOverlay
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(15, 15, 20);
            Controls.Add(pnlContainer);
            Name = "MissingTokenOverlay";
            Size = new Size(1232, 768);
            pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBotIcon).EndInit();
            ResumeLayout(false);
        }

        private Sunny.UI.UIPanel pnlContainer;
        internal Sunny.UI.UIButton btnClose;
        private System.Windows.Forms.PictureBox picBotIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        internal Sunny.UI.UIButton btnOpenSettings;
    }
}