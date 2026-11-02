namespace BotLauncher.Forms
{
    partial class AddTriggerRuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTriggerRuleForm));
            pnlMain = new Panel();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1200, 800);
            pnlMain.TabIndex = 0;
            // 
            // AddTriggerRuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 39, 48);
            ClientSize = new Size(1200, 800);
            Controls.Add(pnlMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTriggerRuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Визуальный редактор сценария";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #region Поля элементов управления
        private System.Windows.Forms.Panel pnlMain;
        #endregion
    }
}