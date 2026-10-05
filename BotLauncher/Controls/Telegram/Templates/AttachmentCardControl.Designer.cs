namespace BotLauncher.Controls.Telegram.Templates
{
    partial class AttachmentCardControl
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
            pnlCard = new Panel();
            btnRemove = new Button();
            picWarning = new PictureBox();
            lblIcon = new Label();
            pictureBox = new PictureBox();
            lblFileName = new Label();
            lblFileSize = new Label();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(35, 39, 48);
            pnlCard.Controls.Add(btnRemove);
            pnlCard.Controls.Add(picWarning);
            pnlCard.Controls.Add(lblIcon);
            pnlCard.Controls.Add(pictureBox);
            pnlCard.Controls.Add(lblFileName);
            pnlCard.Controls.Add(lblFileSize);
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(0, 0, 10, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(150, 130);
            pnlCard.TabIndex = 0;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor = Color.Transparent;
            btnRemove.BackgroundImage = Properties.Resources.icon_close_hover;
            btnRemove.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(124, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(24, 24);
            btnRemove.TabIndex = 4;
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // picWarning
            // 
            picWarning.BackColor = Color.Transparent;
            picWarning.BackgroundImage = Properties.Resources.triangle_exclamation_solid_RED;
            picWarning.BackgroundImageLayout = ImageLayout.Stretch;
            picWarning.Location = new Point(4, 4);
            picWarning.Name = "picWarning";
            picWarning.Size = new Size(25, 25);
            picWarning.SizeMode = PictureBoxSizeMode.Zoom;
            picWarning.TabIndex = 5;
            picWarning.TabStop = false;
            picWarning.Visible = false;
            // 
            // lblIcon
            // 
            lblIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblIcon.Font = new Font("Segoe UI Emoji", 40F);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(150, 90);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "📄";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblIcon.Visible = false;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BackColor = Color.FromArgb(31, 34, 42);
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(150, 90);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Visible = false;
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFileName.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFileName.ForeColor = Color.White;
            lblFileName.Location = new Point(5, 93);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(140, 20);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "file.txt";
            lblFileName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFileSize
            // 
            lblFileSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFileSize.BackColor = Color.Transparent;
            lblFileSize.Font = new Font("Segoe UI", 7.5F);
            lblFileSize.ForeColor = Color.FromArgb(156, 163, 175);
            lblFileSize.Location = new Point(5, 113);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(140, 15);
            lblFileSize.TabIndex = 3;
            lblFileSize.Text = "1.5 МБ";
            lblFileSize.TextAlign = ContentAlignment.TopCenter;
            // 
            // AttachmentCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlCard);
            Name = "AttachmentCardControl";
            Size = new Size(150, 130);
            pnlCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox picWarning; // ИЗМЕНЕНО: был Label
    }
}