namespace BotLauncher.Controls.Telegram.Groups.TabSendSettings
{
    partial class ScenarioCardControl
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
            lblInfo = new Label();
            lblStatus = new Label();
            btnEdit = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 8.5F);
            lblInfo.ForeColor = Color.FromArgb(180, 180, 180);
            lblInfo.Location = new Point(10, 29);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(200, 20);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Размер: 0 символов";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(100, 200, 100);
            lblStatus.Location = new Point(10, 52);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Статус: ✅ Готов к работе";
            // 
            // btnEdit
            // 
            btnEdit.FillColor = Color.FromArgb(108, 99, 255);
            btnEdit.FillHoverColor = Color.FromArgb(139, 133, 255);
            btnEdit.FillPressColor = Color.FromArgb(90, 82, 213);
            btnEdit.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnEdit.Location = new Point(475, 34);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Radius = 6;
            btnEdit.RectColor = Color.Transparent;
            btnEdit.Size = new Size(110, 30);
            btnEdit.Style = Sunny.UI.UIStyle.Custom;
            btnEdit.TabIndex = 0;
            btnEdit.Text = "✏️ Изменить";
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // btnDelete
            // 
            btnDelete.FillColor = Color.FromArgb(220, 53, 69);
            btnDelete.FillHoverColor = Color.FromArgb(230, 80, 90);
            btnDelete.FillPressColor = Color.FromArgb(180, 40, 55);
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(595, 34);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 6;
            btnDelete.RectColor = Color.Transparent;
            btnDelete.Size = new Size(40, 30);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.TabIndex = 1;
            btnDelete.Text = "️";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.Transparent;
            uiGroupBox1.Controls.Add(btnDelete);
            uiGroupBox1.Controls.Add(btnEdit);
            uiGroupBox1.Controls.Add(lblStatus);
            uiGroupBox1.Controls.Add(lblInfo);
            uiGroupBox1.FillColor = Color.Transparent;
            uiGroupBox1.FillColor2 = Color.Transparent;
            uiGroupBox1.FillDisableColor = Color.Transparent;
            uiGroupBox1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            uiGroupBox1.ForeColor = Color.White;
            uiGroupBox1.ForeDisableColor = Color.Transparent;
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.RectColor = Color.FromArgb(58, 58, 69);
            uiGroupBox1.RectDisableColor = Color.Transparent;
            uiGroupBox1.Size = new Size(646, 90);
            uiGroupBox1.TabIndex = 4;
            uiGroupBox1.Text = "Название сценария";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiGroupBox1.TitleTop = 7;
            // 
            // ScenarioCardControl
            // 
            BackColor = Color.FromArgb(30, 33, 40);
            Controls.Add(uiGroupBox1);
            Name = "ScenarioCardControl";
            Size = new Size(646, 90);
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStatus;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIGroupBox uiGroupBox1;
    }
}