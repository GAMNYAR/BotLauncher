namespace BotLauncher.Pages.ProfileAuthForm
{
    partial class ProfileListPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            pnlEmptyState = new Sunny.UI.UIPanel();
            scrollPanel = new Panel();
            tableLayoutPanelProfiles = new Sunny.UI.UITableLayoutPanel();
            uiToolTip1 = new Sunny.UI.UIToolTip(components);
            lblTitle = new Label();
            btnCreateProfile = new Sunny.UI.UIButton();
            btnImportProfile = new Sunny.UI.UIButton();
            btnBack = new Sunny.UI.UIButton();
            btnRefresh = new Sunny.UI.UIButton();
            pnlEmptyState.SuspendLayout();
            scrollPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEmptyState
            // 
            pnlEmptyState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEmptyState.Controls.Add(scrollPanel);
            pnlEmptyState.FillColor = Color.Transparent;
            pnlEmptyState.FillColor2 = Color.Transparent;
            pnlEmptyState.FillDisableColor = Color.Transparent;
            pnlEmptyState.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlEmptyState.ForeColor = Color.DarkGray;
            pnlEmptyState.ForeDisableColor = Color.Transparent;
            pnlEmptyState.Location = new Point(20, 70);
            pnlEmptyState.Margin = new Padding(4, 5, 4, 5);
            pnlEmptyState.MinimumSize = new Size(1, 1);
            pnlEmptyState.Name = "pnlEmptyState";
            pnlEmptyState.Radius = 10;
            pnlEmptyState.RectColor = Color.FromArgb(42, 45, 54);
            pnlEmptyState.RectDisableColor = Color.Transparent;
            pnlEmptyState.Size = new Size(540, 507);
            pnlEmptyState.TabIndex = 15;
            pnlEmptyState.Text = null;
            pnlEmptyState.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // scrollPanel
            // 
            scrollPanel.AutoScroll = true;
            scrollPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            scrollPanel.BackColor = Color.Transparent;
            scrollPanel.Controls.Add(tableLayoutPanelProfiles);
            scrollPanel.Dock = DockStyle.Fill;
            scrollPanel.Location = new Point(0, 0);
            scrollPanel.Name = "scrollPanel";
            scrollPanel.Size = new Size(540, 507);
            scrollPanel.TabIndex = 59;
            // 
            // tableLayoutPanelProfiles
            // 
            tableLayoutPanelProfiles.AutoSize = true;
            tableLayoutPanelProfiles.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelProfiles.BackColor = Color.Transparent;
            tableLayoutPanelProfiles.ColumnCount = 1;
            tableLayoutPanelProfiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelProfiles.Dock = DockStyle.Top;
            tableLayoutPanelProfiles.Location = new Point(0, 0);
            tableLayoutPanelProfiles.Name = "tableLayoutPanelProfiles";
            tableLayoutPanelProfiles.RowCount = 1;
            tableLayoutPanelProfiles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelProfiles.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelProfiles.Size = new Size(540, 0);
            tableLayoutPanelProfiles.TabIndex = 59;
            tableLayoutPanelProfiles.TagString = null;
            // 
            // uiToolTip1
            // 
            uiToolTip1.BackColor = Color.FromArgb(30, 30, 36);
            uiToolTip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiToolTip1.ForeColor = Color.White;
            uiToolTip1.OwnerDraw = true;
            uiToolTip1.RectColor = Color.FromArgb(42, 45, 54);
            uiToolTip1.TitleFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(225, 28);
            lblTitle.Margin = new Padding(10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 21);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Ваши профили";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateProfile.BackColor = Color.Transparent;
            btnCreateProfile.BackgroundImageLayout = ImageLayout.Center;
            btnCreateProfile.FillColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.FillColor2 = Color.Transparent;
            btnCreateProfile.FillDisableColor = Color.Transparent;
            btnCreateProfile.FillHoverColor = Color.MediumSlateBlue;
            btnCreateProfile.FillPressColor = Color.Indigo;
            btnCreateProfile.FillSelectedColor = Color.Transparent;
            btnCreateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateProfile.ForeDisableColor = Color.Transparent;
            btnCreateProfile.ForeSelectedColor = Color.Transparent;
            btnCreateProfile.LightColor = Color.Transparent;
            btnCreateProfile.Location = new Point(20, 594);
            btnCreateProfile.Margin = new Padding(5);
            btnCreateProfile.MinimumSize = new Size(1, 1);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Radius = 10;
            btnCreateProfile.RectColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectDisableColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectHoverColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectPressColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.RectSelectedColor = Color.FromArgb(124, 58, 237);
            btnCreateProfile.Size = new Size(540, 45);
            btnCreateProfile.TabIndex = 55;
            btnCreateProfile.Text = "Создать профиль";
            btnCreateProfile.TipsColor = Color.Transparent;
            btnCreateProfile.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreateProfile.TipsForeColor = Color.Transparent;
            btnCreateProfile.Click += BtnCreateProfile_Click;
            // 
            // btnImportProfile
            // 
            btnImportProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnImportProfile.BackColor = Color.Transparent;
            btnImportProfile.BackgroundImageLayout = ImageLayout.Center;
            btnImportProfile.FillColor = Color.Transparent;
            btnImportProfile.FillColor2 = Color.Transparent;
            btnImportProfile.FillDisableColor = Color.Transparent;
            btnImportProfile.FillHoverColor = Color.Transparent;
            btnImportProfile.FillPressColor = Color.Transparent;
            btnImportProfile.FillSelectedColor = Color.Transparent;
            btnImportProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImportProfile.ForeDisableColor = Color.Transparent;
            btnImportProfile.ForeSelectedColor = Color.Transparent;
            btnImportProfile.LightColor = Color.Transparent;
            btnImportProfile.Location = new Point(20, 652);
            btnImportProfile.Margin = new Padding(5);
            btnImportProfile.MinimumSize = new Size(1, 1);
            btnImportProfile.Name = "btnImportProfile";
            btnImportProfile.Radius = 10;
            btnImportProfile.RectColor = Color.FromArgb(42, 45, 54);
            btnImportProfile.RectDisableColor = Color.Transparent;
            btnImportProfile.RectHoverColor = Color.DarkGray;
            btnImportProfile.RectPressColor = Color.WhiteSmoke;
            btnImportProfile.RectSelectedColor = Color.Transparent;
            btnImportProfile.Size = new Size(540, 45);
            btnImportProfile.TabIndex = 56;
            btnImportProfile.Text = "Импортировать профиль";
            btnImportProfile.TipsColor = Color.Transparent;
            btnImportProfile.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImportProfile.TipsForeColor = Color.Transparent;
            btnImportProfile.Click += BtnImportProfile_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.FillColor = Color.Transparent;
            btnBack.FillColor2 = Color.Transparent;
            btnBack.FillDisableColor = Color.Transparent;
            btnBack.FillHoverColor = Color.Transparent;
            btnBack.FillPressColor = Color.Transparent;
            btnBack.FillSelectedColor = Color.Transparent;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.ForeDisableColor = Color.Transparent;
            btnBack.ForeSelectedColor = Color.Transparent;
            btnBack.LightColor = Color.Transparent;
            btnBack.Location = new Point(20, 20);
            btnBack.Margin = new Padding(5);
            btnBack.MinimumSize = new Size(1, 1);
            btnBack.Name = "btnBack";
            btnBack.Radius = 10;
            btnBack.RectColor = Color.FromArgb(42, 45, 54);
            btnBack.RectDisableColor = Color.Transparent;
            btnBack.RectHoverColor = Color.DarkGray;
            btnBack.RectPressColor = Color.WhiteSmoke;
            btnBack.RectSelectedColor = Color.Transparent;
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 57;
            btnBack.Text = "Назад";
            btnBack.TipsColor = Color.Transparent;
            btnBack.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.TipsForeColor = Color.Transparent;
            btnBack.Click += BtnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImageLayout = ImageLayout.Center;
            btnRefresh.FillColor = Color.FromArgb(110, 72, 195);
            btnRefresh.FillColor2 = Color.Transparent;
            btnRefresh.FillDisableColor = Color.Transparent;
            btnRefresh.FillHoverColor = Color.MediumSlateBlue;
            btnRefresh.FillPressColor = Color.Indigo;
            btnRefresh.FillSelectedColor = Color.Transparent;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRefresh.ForeDisableColor = Color.Transparent;
            btnRefresh.ForeSelectedColor = Color.Transparent;
            btnRefresh.LightColor = Color.Transparent;
            btnRefresh.Location = new Point(460, 20);
            btnRefresh.Margin = new Padding(5);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Radius = 10;
            btnRefresh.RectColor = Color.FromArgb(110, 72, 195);
            btnRefresh.RectDisableColor = Color.FromArgb(110, 72, 195);
            btnRefresh.RectHoverColor = Color.FromArgb(110, 72, 195);
            btnRefresh.RectPressColor = Color.FromArgb(110, 72, 195);
            btnRefresh.RectSelectedColor = Color.FromArgb(110, 72, 195);
            btnRefresh.Size = new Size(100, 35);
            btnRefresh.TabIndex = 58;
            btnRefresh.Text = "Обновить";
            btnRefresh.TipsColor = Color.Transparent;
            btnRefresh.TipsFont = new Font("3270 Semi-Condensed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRefresh.TipsForeColor = Color.Transparent;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // ProfileListPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 36);
            Controls.Add(btnBack);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(pnlEmptyState);
            Controls.Add(btnCreateProfile);
            Controls.Add(btnImportProfile);
            Margin = new Padding(0);
            Name = "ProfileListPage";
            Padding = new Padding(20);
            Size = new Size(580, 720);
            pnlEmptyState.ResumeLayout(false);
            scrollPanel.ResumeLayout(false);
            scrollPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIPanel pnlEmptyState;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Label lblTitle;
        private Sunny.UI.UIButton btnCreateProfile;
        private Sunny.UI.UIButton btnImportProfile;
        private Sunny.UI.UIButton btnBack;
        private Sunny.UI.UIButton btnRefresh;
        private Sunny.UI.UITableLayoutPanel tableLayoutPanelProfiles;
        private Panel scrollPanel;
    }
}
