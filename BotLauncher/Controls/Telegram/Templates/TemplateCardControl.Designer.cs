namespace BotLauncher.Controls.Telegram.Templates
{
    partial class TemplateCardControl
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
            pnlCard = new Sunny.UI.UIPanel();
            btnDelete = new FontAwesome.Sharp.IconButton();
            lblTemplateName = new Label();
            lblPreview = new Label();
            lblModifiedDate = new Label();
            lblDateTitle = new Label();
            lblAttachments = new Label();
            iconType = new FontAwesome.Sharp.IconButton();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.Controls.Add(btnDelete);
            pnlCard.Controls.Add(lblTemplateName);
            pnlCard.Controls.Add(lblPreview);
            pnlCard.Controls.Add(lblModifiedDate);
            pnlCard.Controls.Add(lblDateTitle);
            pnlCard.Controls.Add(lblAttachments);
            pnlCard.Controls.Add(iconType);
            pnlCard.FillColor = Color.FromArgb(42, 46, 57);
            pnlCard.FillColor2 = Color.Transparent;
            pnlCard.FillDisableColor = Color.Transparent;
            pnlCard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlCard.ForeColor = Color.Transparent;
            pnlCard.ForeDisableColor = Color.Transparent;
            pnlCard.Location = new Point(0, 0);
            pnlCard.Margin = new Padding(4, 5, 4, 5);
            pnlCard.MaximumSize = new Size(230, 90);
            pnlCard.MinimumSize = new Size(230, 90);
            pnlCard.Name = "pnlCard";
            pnlCard.Radius = 12;
            pnlCard.RectColor = Color.FromArgb(47, 51, 61);
            pnlCard.RectDisableColor = Color.Transparent;
            pnlCard.Size = new Size(230, 90);
            pnlCard.TabIndex = 0;
            pnlCard.Text = null;
            pnlCard.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 38, 38);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 16;
            btnDelete.Location = new Point(203, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(24, 24);
            btnDelete.TabIndex = 5;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTemplateName
            // 
            lblTemplateName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTemplateName.AutoEllipsis = true;
            lblTemplateName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTemplateName.ForeColor = Color.White;
            lblTemplateName.Location = new Point(32, 5);
            lblTemplateName.Name = "lblTemplateName";
            lblTemplateName.Size = new Size(165, 16);
            lblTemplateName.TabIndex = 0;
            lblTemplateName.Text = "Название шаблона";
            lblTemplateName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreview
            // 
            lblPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPreview.AutoEllipsis = true;
            lblPreview.Font = new Font("Segoe UI", 7.5F);
            lblPreview.ForeColor = Color.FromArgb(156, 163, 175);
            lblPreview.Location = new Point(7, 25);
            lblPreview.MaximumSize = new Size(217, 38);
            lblPreview.MinimumSize = new Size(217, 38);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(217, 38);
            lblPreview.TabIndex = 3;
            lblPreview.Text = "Превью текста сообщения...";
            // 
            // lblModifiedDate
            // 
            lblModifiedDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblModifiedDate.Font = new Font("Segoe UI", 7.5F);
            lblModifiedDate.ForeColor = Color.Silver;
            lblModifiedDate.Location = new Point(31, 71);
            lblModifiedDate.Name = "lblModifiedDate";
            lblModifiedDate.Size = new Size(100, 13);
            lblModifiedDate.TabIndex = 1;
            lblModifiedDate.Text = "01.01.2024 12:00";
            lblModifiedDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateTitle
            // 
            lblDateTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateTitle.Font = new Font("Segoe UI", 7.5F);
            lblDateTitle.ForeColor = Color.Silver;
            lblDateTitle.Location = new Point(7, 71);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new Size(26, 13);
            lblDateTitle.TabIndex = 4;
            lblDateTitle.Text = "Изм:";
            // 
            // lblAttachments
            // 
            lblAttachments.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAttachments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAttachments.ForeColor = Color.Silver;
            lblAttachments.Location = new Point(137, 70);
            lblAttachments.Name = "lblAttachments";
            lblAttachments.RightToLeft = RightToLeft.Yes;
            lblAttachments.Size = new Size(88, 15);
            lblAttachments.TabIndex = 6;
            lblAttachments.Text = "📎 0";
            lblAttachments.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconType
            // 
            iconType.BackColor = Color.Transparent;
            iconType.FlatAppearance.BorderSize = 0;
            iconType.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconType.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconType.FlatStyle = FlatStyle.Flat;
            iconType.Font = new Font("Segoe UI", 9F);
            iconType.ForeColor = Color.FromArgb(156, 163, 175);
            iconType.IconChar = FontAwesome.Sharp.IconChar.FileText;
            iconType.IconColor = Color.FromArgb(156, 163, 175);
            iconType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconType.IconSize = 16;
            iconType.Location = new Point(7, 3);
            iconType.Name = "iconType";
            iconType.Size = new Size(22, 20);
            iconType.TabIndex = 7;
            iconType.UseVisualStyleBackColor = false;
            // 
            // TemplateCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlCard);
            MaximumSize = new Size(230, 90);
            MinimumSize = new Size(230, 90);
            Name = "TemplateCardControl";
            Size = new Size(230, 90);
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #region Поля
        private Sunny.UI.UIPanel pnlCard;
        private Label lblTemplateName;
        private Label lblPreview; // ✅ Label вместо TextBox
        private Label lblModifiedDate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private Label lblDateTitle;
        private Label lblAttachments;
        private FontAwesome.Sharp.IconButton iconType;
        #endregion
    }
}