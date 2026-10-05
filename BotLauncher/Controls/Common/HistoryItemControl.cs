using System;
using System.Drawing;
using System.Windows.Forms;

namespace BotLauncher.Controls
{
    public partial class HistoryItemControl : UserControl
    {
        private Color _defaultBackColor = Color.FromArgb(33, 37, 45);
        private Color _hoverBackColor = Color.FromArgb(42, 47, 58);

        public HistoryItemControl()
        {
            InitializeComponent();
            SetupStyling();
            SetupHoverEffects();
        }

        private void SetupStyling()
        {
            // Настройка панели
            if (pnlRow != null)
            {
                pnlRow.BackColor = _defaultBackColor;
                pnlRow.Cursor = Cursors.Hand;

                // Если используешь Sunny.UI.UIPanel
                if (pnlRow is Sunny.UI.UIPanel uiPanel)
                {
                    uiPanel.FillColor = _defaultBackColor;
                    uiPanel.Radius = 8; // Скругление углов
                }
            }

            // Настройка шрифтов
            lblDateTime.Font = new Font("Segoe UI", 9F);
            lblTemplateName.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMessageId.Font = new Font("Segoe UI", 9F);

            // Цвета текста
            lblDateTime.ForeColor = Color.FromArgb(156, 163, 175);
            lblTemplateName.ForeColor = Color.White;
            lblMessageId.ForeColor = Color.FromArgb(156, 163, 175);
        }

        private void SetupHoverEffects()
        {
            if (pnlRow != null)
            {
                pnlRow.MouseEnter += (s, e) =>
                {
                    pnlRow.BackColor = _hoverBackColor;
                    if (pnlRow is Sunny.UI.UIPanel uiPanel)
                    {
                        uiPanel.FillColor = _hoverBackColor;
                        uiPanel.Invalidate();
                    }
                };

                pnlRow.MouseLeave += (s, e) =>
                {
                    pnlRow.BackColor = _defaultBackColor;
                    if (pnlRow is Sunny.UI.UIPanel uiPanel)
                    {
                        uiPanel.FillColor = _defaultBackColor;
                        uiPanel.Invalidate();
                    }
                };
            }
        }

        /// <summary>
        /// Установить данные для элемента истории
        /// </summary>
        public void SetData(DateTime dateTime, string templateName, string status, string messageId)
        {
            lblDateTime.Text = dateTime.ToString("dd.MM.yyyy HH:mm");
            lblTemplateName.Text = templateName;
            lblMessageId.Text = messageId;

            // Устанавливаем статус с цветом
            SetStatus(status);
        }

        /// <summary>
        /// Установить статус с соответствующим цветом
        /// </summary>
        private void SetStatus(string status)
        {
            lblStatus.Text = status;

            // Определяем цвет по статусу
            switch (status.ToLower())
            {
                case "отправлено":
                case "отправлен":
                case "success":
                case "sent":
                    lblStatus.ForeColor = Color.FromArgb(16, 185, 129); // Яркий зелёный
                    break;

                case "ошибка":
                case "error":
                case "failed":
                    lblStatus.ForeColor = Color.FromArgb(239, 68, 68); // Красный
                    break;

                case "ожидание":
                case "pending":
                case "в очереди":
                    lblStatus.ForeColor = Color.FromArgb(245, 158, 11); // Оранжевый
                    break;

                case "в процессе":
                case "processing":
                case "отправка":
                    lblStatus.ForeColor = Color.FromArgb(59, 130, 246); // Синий
                    break;

                default:
                    lblStatus.ForeColor = Color.White;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Рисуем скруглённые углы если нужно
            if (pnlRow == null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 8;
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, Height - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    using (var brush = new SolidBrush(_defaultBackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
            }
        }
    }
}