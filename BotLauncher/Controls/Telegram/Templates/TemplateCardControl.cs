using System;
using System.Drawing;
using System.Windows.Forms;
using BotLauncher.Models.Telegram;

namespace BotLauncher.Controls.Telegram.Templates
{
    public partial class TemplateCardControl : UserControl
    {
        private TelegramTemplate? template;
        private bool isSelected;

        public event Action<TelegramTemplate>? TemplateSelected;
        public event Action<TelegramTemplate>? DeleteRequested;

        public TemplateCardControl()
        {
            InitializeComponent();

            this.MinimumSize = new Size(230, 90);
            this.MaximumSize = new Size(230, 90);
            this.Size = new Size(230, 90);

            pnlCard.FillColor = Color.FromArgb(42, 46, 57);
            pnlCard.Radius = 12;
            pnlCard.RectColor = Color.FromArgb(47, 51, 61);

            btnDelete.Click += (s, e) => OnDeleteClicked();

            this.Click += (s, e) => OnTemplateSelected();
            pnlCard.Click += (s, e) => OnTemplateSelected();
            lblTemplateName.Click += (s, e) => OnTemplateSelected();
            lblPreview.Click += (s, e) => OnTemplateSelected();

            this.MouseEnter += (s, e) => { if (!isSelected) pnlCard.FillColor = Color.FromArgb(58, 63, 75); };
            this.MouseLeave += (s, e) => { if (!isSelected) pnlCard.FillColor = Color.FromArgb(42, 46, 57); };
        }

        public void SetData(TelegramTemplate template)
        {
            this.template = template;

            lblTemplateName.Text = string.IsNullOrEmpty(template.Name) ? "Без названия" : template.Name;

            // Простое превью (Label сам обрежет с троеточием благодаря AutoEllipsis)
            string preview = string.IsNullOrEmpty(template.Message)
                ? "Пустой шаблон"
                : template.Message.Replace("\n", " ").Replace("\r", " ");

            // Обрезаем до 100 символов для превью
            if (preview.Length > 100)
                preview = preview.Substring(0, 100) + "...";

            lblPreview.Text = preview;

            lblModifiedDate.Text = template.ModifiedAt.ToString("dd.MM.yyyy HH:mm");

            int attachmentsCount = template.Attachments?.Count ?? 0;
            lblAttachments.Text = attachmentsCount > 0 ? $"📎 {attachmentsCount}" : "";
            lblAttachments.Visible = attachmentsCount > 0;

            UpdateCardBorder();
        }

        public TelegramTemplate? GetTemplate() => template;

        public void SetSelected(bool selected)
        {
            isSelected = selected;

            if (selected)
            {
                pnlCard.FillColor = Color.FromArgb(124, 58, 237);
                pnlCard.RectColor = Color.FromArgb(139, 92, 246);
                lblPreview.ForeColor = Color.FromArgb(240, 240, 255);
                lblTemplateName.ForeColor = Color.White;
            }
            else
            {
                pnlCard.FillColor = Color.FromArgb(42, 46, 57);
                pnlCard.RectColor = template?.UsageCount > 0 ? Color.FromArgb(245, 158, 11) : Color.FromArgb(47, 51, 61);
                lblPreview.ForeColor = Color.FromArgb(156, 163, 175);
                lblTemplateName.ForeColor = Color.White;
            }
        }

        private void UpdateCardBorder()
        {
            if (template?.UsageCount > 0)
                pnlCard.RectColor = Color.FromArgb(245, 158, 11);
            else
                pnlCard.RectColor = Color.FromArgb(47, 51, 61);
        }

        private void OnTemplateSelected()
        {
            if (template != null)
                TemplateSelected?.Invoke(template);
        }

        private void OnDeleteClicked()
        {
            if (template != null)
                DeleteRequested?.Invoke(template);
        }
    }
}