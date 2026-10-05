namespace BotLauncher.Controls
{
    partial class HistoryItemControl
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
            pnlRow = new Sunny.UI.UIPanel();
            lblDateTime = new Label();
            lblTemplateName = new Label();
            lblStatus = new Label();
            lblMessageId = new Label();
            pnlRow.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRow
            // 
            pnlRow.BackColor = Color.Transparent;
            pnlRow.Controls.Add(lblDateTime);
            pnlRow.Controls.Add(lblTemplateName);
            pnlRow.Controls.Add(lblStatus);
            pnlRow.Controls.Add(lblMessageId);
            pnlRow.Dock = DockStyle.Fill;
            pnlRow.FillColor = Color.FromArgb(35, 39, 48);
            pnlRow.FillColor2 = Color.Transparent;
            pnlRow.FillDisableColor = Color.Transparent;
            pnlRow.Font = new Font("Microsoft Sans Serif", 12F);
            pnlRow.ForeColor = Color.Transparent;
            pnlRow.ForeDisableColor = Color.Transparent;
            pnlRow.Location = new Point(0, 0);
            pnlRow.Margin = new Padding(0);
            pnlRow.MinimumSize = new Size(1, 1);
            pnlRow.Name = "pnlRow";
            pnlRow.Radius = 0;
            pnlRow.RectColor = Color.FromArgb(42, 47, 58);
            pnlRow.RectDisableColor = Color.Empty;
            pnlRow.Size = new Size(703, 43);
            pnlRow.TabIndex = 32;
            pnlRow.Text = null;
            pnlRow.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.FlatStyle = FlatStyle.Flat;
            lblDateTime.Font = new Font("Segoe UI", 9F);
            lblDateTime.ForeColor = Color.Gainsboro;
            lblDateTime.ImeMode = ImeMode.NoControl;
            lblDateTime.Location = new Point(10, 14);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(95, 15);
            lblDateTime.TabIndex = 28;
            lblDateTime.Text = "00.00.0000 00:00";
            lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTemplateName
            // 
            lblTemplateName.BackColor = Color.Transparent;
            lblTemplateName.FlatStyle = FlatStyle.Flat;
            lblTemplateName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTemplateName.ForeColor = Color.Gainsboro;
            lblTemplateName.ImeMode = ImeMode.NoControl;
            lblTemplateName.Location = new Point(118, 14);
            lblTemplateName.Name = "lblTemplateName";
            lblTemplateName.Size = new Size(250, 15);
            lblTemplateName.TabIndex = 33;
            lblTemplateName.Text = "Название шаблона";
            lblTemplateName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.FlatStyle = FlatStyle.Flat;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Chartreuse;
            lblStatus.ImeMode = ImeMode.NoControl;
            lblStatus.Location = new Point(379, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(97, 15);
            lblStatus.TabIndex = 31;
            lblStatus.Text = "Отправлено";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMessageId
            // 
            lblMessageId.BackColor = Color.Transparent;
            lblMessageId.FlatStyle = FlatStyle.Flat;
            lblMessageId.Font = new Font("Segoe UI", 9F);
            lblMessageId.ForeColor = Color.Gainsboro;
            lblMessageId.ImeMode = ImeMode.NoControl;
            lblMessageId.Location = new Point(518, 14);
            lblMessageId.Name = "lblMessageId";
            lblMessageId.Size = new Size(130, 15);
            lblMessageId.TabIndex = 32;
            lblMessageId.Text = "0112994744";
            lblMessageId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // HistoryItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRow);
            Name = "HistoryItemControl";
            Size = new Size(703, 43);
            pnlRow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel pnlRow;
        private Label lblDateTime;
        private Label lblTemplateName;
        private Label lblStatus;
        private Label lblMessageId;
    }
}
