namespace BotLauncher
{
    partial class ProfileAuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contentPanel = new Sunny.UI.UIPanel();
            SuspendLayout();
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
            contentPanel.Location = new Point(0, 0);
            contentPanel.Margin = new Padding(4, 5, 4, 5);
            contentPanel.MinimumSize = new Size(126, 50);
            contentPanel.Name = "contentPanel";
            contentPanel.RectColor = Color.Transparent;
            contentPanel.RectDisableColor = Color.Transparent;
            contentPanel.Size = new Size(500, 700);
            contentPanel.TabIndex = 0;
            contentPanel.Text = null;
            contentPanel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ProfileAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            ClientSize = new Size(500, 700);
            Controls.Add(contentPanel);
            DoubleBuffered = true;
            ForeColor = Color.White;
            MinimumSize = new Size(450, 700);
            Name = "ProfileAuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bot Launcher";
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel contentPanel;
    }
}