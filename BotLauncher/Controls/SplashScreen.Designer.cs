namespace BotLauncher.Controls
{
    partial class SplashScreen
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Поля элементов управления

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVersion;

        #endregion

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
            picLogo = new PictureBox();
            lblTitle = new Label();
            lblStatus = new Label();
            lblVersion = new Label();
            progressBar = new Sunny.UI.UIProcessBar();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top;
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Image = Properties.Resources.robot_solid;
            picLogo.Location = new Point(564, 135);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(424, 275);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 60);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Bot Launcher";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 14F);
            lblStatus.ForeColor = Color.FromArgb(161, 161, 170);
            lblStatus.Location = new Point(424, 335);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(400, 35);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Инициализация...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 10F);
            lblVersion.ForeColor = Color.Silver;
            lblVersion.Location = new Point(424, 404);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(400, 25);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "Версия 1.0.0";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.FillColor = Color.White;
            progressBar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            progressBar.ForeColor = Color.FromArgb(102, 58, 183);
            progressBar.Location = new Point(353, 373);
            progressBar.MinimumSize = new Size(3, 3);
            progressBar.Name = "progressBar";
            progressBar.ProcessColor = Color.FromArgb(102, 58, 183);
            progressBar.ProcessForeColor = Color.White;
            progressBar.Radius = 8;
            progressBar.RectColor = Color.Indigo;
            progressBar.Size = new Size(542, 25);
            progressBar.Style = Sunny.UI.UIStyle.Custom;
            progressBar.TabIndex = 4;
            progressBar.Text = "uiProcessBar1";
            progressBar.Value = 50;
            // 
            // SplashScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 15, 20);
            Controls.Add(progressBar);
            Controls.Add(lblVersion);
            Controls.Add(lblStatus);
            Controls.Add(lblTitle);
            Controls.Add(picLogo);
            Name = "SplashScreen";
            Size = new Size(1249, 719);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIProcessBar progressBar;
    }
}