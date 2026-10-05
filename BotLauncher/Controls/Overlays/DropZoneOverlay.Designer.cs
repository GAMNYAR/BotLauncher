namespace BotLauncher.Controls
{
    partial class DropZoneOverlay
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
            picFileIcon = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            pnlBadge = new System.Windows.Forms.Panel();
            lblBadgeText = new System.Windows.Forms.Label();
            borderPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)picFileIcon).BeginInit();
            pnlBadge.SuspendLayout();
            borderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // picFileIcon
            // 
            picFileIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            picFileIcon.BackColor = System.Drawing.Color.Transparent;
            picFileIcon.Location = new System.Drawing.Point(242, 150);
            picFileIcon.Name = "picFileIcon";
            picFileIcon.Size = new System.Drawing.Size(100, 100);
            picFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picFileIcon.TabIndex = 0;
            picFileIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(90, 270);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(408, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Перетащите файл профиля сюда";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 190);
            lblSubtitle.Location = new System.Drawing.Point(140, 315);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(275, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Отпустите файл, чтобы начать импорт";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBadge
            // 
            pnlBadge.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlBadge.BackColor = System.Drawing.Color.FromArgb(120, 138, 43, 226);
            pnlBadge.Controls.Add(lblBadgeText);
            pnlBadge.Location = new System.Drawing.Point(190, 360);
            pnlBadge.Name = "pnlBadge";
            pnlBadge.Size = new System.Drawing.Size(204, 36);
            pnlBadge.TabIndex = 3;
            // 
            // lblBadgeText
            // 
            lblBadgeText.Dock = System.Windows.Forms.DockStyle.Fill;
            lblBadgeText.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblBadgeText.ForeColor = System.Drawing.Color.White;
            lblBadgeText.Location = new System.Drawing.Point(0, 0);
            lblBadgeText.Name = "lblBadgeText";
            lblBadgeText.Size = new System.Drawing.Size(204, 36);
            lblBadgeText.TabIndex = 0;
            lblBadgeText.Text = "Поддерживается формат .blp";
            lblBadgeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderPanel
            // 
            borderPanel.BackColor = System.Drawing.Color.Transparent;
            borderPanel.Controls.Add(picFileIcon);
            borderPanel.Controls.Add(lblTitle);
            borderPanel.Controls.Add(lblSubtitle);
            borderPanel.Controls.Add(pnlBadge);
            borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            borderPanel.Location = new System.Drawing.Point(0, 0);
            borderPanel.Name = "borderPanel";
            borderPanel.Size = new System.Drawing.Size(584, 721);
            borderPanel.TabIndex = 4;
            // 
            // DropZoneOverlay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(200, 20, 20, 30);
            Controls.Add(borderPanel);
            Name = "DropZoneOverlay";
            Size = new System.Drawing.Size(584, 721);
            ((System.ComponentModel.ISupportInitialize)picFileIcon).EndInit();
            pnlBadge.ResumeLayout(false);
            borderPanel.ResumeLayout(false);
            borderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picFileIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlBadge;
        private System.Windows.Forms.Label lblBadgeText;
        private System.Windows.Forms.Panel borderPanel;
    }
}