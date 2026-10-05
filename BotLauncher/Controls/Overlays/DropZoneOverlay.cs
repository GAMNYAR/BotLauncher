using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BotLauncher.Controls
{
    public partial class DropZoneOverlay : UserControl
    {
        // =========================================================
        // НАСТРОЙКИ ПУНКТИРНОЙ РАМКИ
        // Меняй значения ниже для настройки внешнего вида
        // =========================================================

        /// <summary>
        /// ЦВЕТ РАМКИ
        /// По умолчанию: фиолетовый (138, 43, 226)
        /// Примеры: Color.Purple, Color.Blue, Color.FromArgb(255, 0, 0) - красный
        /// </summary>
        private Color borderColor = Color.FromArgb(138, 43, 226);

        /// <summary>
        /// ТОЛЩИНА ЛИНИИ РАМКИ (в пикселях)
        /// По умолчанию: 4
        /// Рекомендуемые значения: 2-6
        /// </summary>
        private int borderWidth = 2;

        /// <summary>
        /// ДЛИНА ОДНОГО ШТРИХА (пунктир)
        /// По умолчанию: 20f
        /// Чем больше число, тем длиннее штрихи
        /// Рекомендуемые значения: 10-30
        /// </summary>
        private float borderDashSize = 10f;

        /// <summary>
        /// РАССТОЯНИЕ МЕЖДУ ШТРИХАМИ
        /// По умолчанию: 10f
        /// Чем больше число, тем больше промежуток
        /// Рекомендуемые значения: 5-15
        /// </summary>
        private float borderGapSize = 10f;

        /// <summary>
        /// ОТСТУП РАМКИ ОТ КРАЯ ОКНА (в пикселях)
        /// По умолчанию: 15
        /// Чем больше число, тем дальше рамка от края
        /// Рекомендуемые значения: 10-25
        /// </summary>
        private int borderMargin = 10;

        // =========================================================

        public DropZoneOverlay()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.FromArgb(200, 20, 20, 30);

            this.Resize += DropZoneOverlay_Resize;
            borderPanel.Paint += borderPanel_Paint;

            CenterControls();
        }

        private void DropZoneOverlay_Resize(object? sender, EventArgs e)
        {
            CenterControls();
            borderPanel.Invalidate();
        }

        private void borderPanel_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (var pen = new Pen(borderColor, borderWidth))
            {
                pen.DashStyle = DashStyle.Custom;
                pen.DashPattern = new float[] { borderDashSize, borderGapSize };
                pen.DashCap = DashCap.Round;

                Rectangle rect = new Rectangle(
                    borderMargin,
                    borderMargin,
                    borderPanel.Width - (borderMargin * 2) - 1,
                    borderPanel.Height - (borderMargin * 2) - 1
                );

                g.DrawRectangle(pen, rect);
            }
        }

        private void CenterControls()
        {
            if (this.Width > 0 && this.Height > 0)
            {
                picFileIcon.Left = (this.Width - picFileIcon.Width) / 2;
                lblTitle.Left = (this.Width - lblTitle.Width) / 2;
                lblSubtitle.Left = (this.Width - lblSubtitle.Width) / 2;
                pnlBadge.Left = (this.Width - pnlBadge.Width) / 2;
            }
        }

        // =========================================================
        // СВОЙСТВА (для программного доступа)
        // =========================================================

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; borderPanel.Invalidate(); }
        }

        public int BorderWidth
        {
            get => borderWidth;
            set { borderWidth = value; borderPanel.Invalidate(); }
        }

        public float BorderDashSize
        {
            get => borderDashSize;
            set { borderDashSize = value; borderPanel.Invalidate(); }
        }

        public float BorderGapSize
        {
            get => borderGapSize;
            set { borderGapSize = value; borderPanel.Invalidate(); }
        }

        public int BorderMargin
        {
            get => borderMargin;
            set { borderMargin = value; borderPanel.Invalidate(); }
        }

        public string TitleText
        {
            get => lblTitle.Text;
            set { lblTitle.Text = value; CenterControls(); }
        }

        public string SubtitleText
        {
            get => lblSubtitle.Text;
            set { lblSubtitle.Text = value; CenterControls(); }
        }

        public string BadgeText
        {
            get => lblBadgeText.Text;
            set => lblBadgeText.Text = value;
        }

        public Image DropIcon
        {
            get => picFileIcon.Image;
            set { picFileIcon.Image = value; }
        }

        public new Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; }
        }
    }
}