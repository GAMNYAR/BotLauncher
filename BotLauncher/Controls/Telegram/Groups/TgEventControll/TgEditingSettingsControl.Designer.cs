namespace BotLauncher.Controls.Telegram.Groups
{
    partial class TgEditingSettingsControl
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
            grpTgEventEditing = new Sunny.UI.UIGroupBox();
            grpEditSpecifics = new Sunny.UI.UIGroupBox();
            cmbEditorFilter = new Sunny.UI.UIComboBox();
            lblEditorFilter = new Label();
            nudMinMessageAge = new Sunny.UI.UIIntegerUpDown();
            lblMinMessageAge = new Label();
            chkOnlyTextChanges = new Sunny.UI.UICheckBox();
            chkIgnoreBotEdits = new Sunny.UI.UICheckBox();
            grpBasicFilters = new Sunny.UI.UIGroupBox();
            cmbTgUserFilter = new Sunny.UI.UIComboBox();
            lblTgUserFilter = new Label();
            nudTgMinLength = new Sunny.UI.UIIntegerUpDown();
            lblTgMinLength = new Label();
            grpTimeFilter = new Sunny.UI.UIGroupBox();
            chkSunday = new Sunny.UI.UICheckBox();
            chkSaturday = new Sunny.UI.UICheckBox();
            chkFriday = new Sunny.UI.UICheckBox();
            chkThursday = new Sunny.UI.UICheckBox();
            chkWednesday = new Sunny.UI.UICheckBox();
            chkTuesday = new Sunny.UI.UICheckBox();
            chkMonday = new Sunny.UI.UICheckBox();
            lblDaysOfWeek = new Label();
            chkTimeEnabled = new Sunny.UI.UICheckBox();
            timeTo = new Sunny.UI.UITimePicker();
            lblTimeTo = new Label();
            timeFrom = new Sunny.UI.UITimePicker();
            lblTimeFilter = new Label();
            grpAntiSpam = new Sunny.UI.UIGroupBox();
            lblMaxTriggersUnit = new Label();
            nudMaxTriggers = new Sunny.UI.UIIntegerUpDown();
            lblMaxTriggers = new Label();
            lblDuplicateUnit = new Label();
            nudDuplicateInterval = new Sunny.UI.UIIntegerUpDown();
            lblDuplicateInterva = new Label();
            chkIgnoreDuplicates = new Sunny.UI.UICheckBox();
            grpAdditionalFilters = new Sunny.UI.UIGroupBox();
            chkIgnoreEmoji = new Sunny.UI.UICheckBox();
            chkIgnoreLinks = new Sunny.UI.UICheckBox();
            chkIgnoreEmpty = new Sunny.UI.UICheckBox();
            chkIgnoreForwarded = new Sunny.UI.UICheckBox();
            grpLists = new Sunny.UI.UIGroupBox();
            txtWhitelist = new Sunny.UI.UITextBox();
            lblWhitelist = new Label();
            txtTgBlacklist = new Sunny.UI.UITextBox();
            lblBlacklist = new Label();
            grpActions = new Sunny.UI.UIGroupBox();
            chkLogEvent = new Sunny.UI.UICheckBox();
            cmbPriority = new Sunny.UI.UIComboBox();
            lblPriority = new Label();
            lblCooldownUnit = new Label();
            nudCooldown = new Sunny.UI.UIIntegerUpDown();
            lblCooldown = new Label();
            grpTgEventEditing.SuspendLayout();
            grpEditSpecifics.SuspendLayout();
            grpBasicFilters.SuspendLayout();
            grpTimeFilter.SuspendLayout();
            grpAntiSpam.SuspendLayout();
            grpAdditionalFilters.SuspendLayout();
            grpLists.SuspendLayout();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // grpTgEventEditing
            // 
            grpTgEventEditing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpTgEventEditing.BackColor = Color.Transparent;
            grpTgEventEditing.Controls.Add(grpEditSpecifics);
            grpTgEventEditing.Controls.Add(grpBasicFilters);
            grpTgEventEditing.Controls.Add(grpTimeFilter);
            grpTgEventEditing.Controls.Add(grpAntiSpam);
            grpTgEventEditing.Controls.Add(grpAdditionalFilters);
            grpTgEventEditing.Controls.Add(grpLists);
            grpTgEventEditing.Controls.Add(grpActions);
            grpTgEventEditing.FillColor = Color.Transparent;
            grpTgEventEditing.FillColor2 = Color.Transparent;
            grpTgEventEditing.FillDisableColor = Color.Transparent;
            grpTgEventEditing.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpTgEventEditing.ForeColor = Color.White;
            grpTgEventEditing.ForeDisableColor = Color.Transparent;
            grpTgEventEditing.Location = new Point(5, 0);
            grpTgEventEditing.Margin = new Padding(0);
            grpTgEventEditing.MinimumSize = new Size(1, 1);
            grpTgEventEditing.Name = "grpTgEventEditing";
            grpTgEventEditing.Padding = new Padding(0, 32, 0, 0);
            grpTgEventEditing.Radius = 15;
            grpTgEventEditing.RectColor = Color.FromArgb(58, 58, 69);
            grpTgEventEditing.RectDisableColor = Color.Transparent;
            grpTgEventEditing.Size = new Size(680, 905);
            grpTgEventEditing.TabIndex = 22;
            grpTgEventEditing.Text = "Настройки события (\"Редактирование сообщения\")";
            grpTgEventEditing.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // grpEditSpecifics
            // 
            grpEditSpecifics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpEditSpecifics.BackColor = Color.Transparent;
            grpEditSpecifics.Controls.Add(cmbEditorFilter);
            grpEditSpecifics.Controls.Add(lblEditorFilter);
            grpEditSpecifics.Controls.Add(nudMinMessageAge);
            grpEditSpecifics.Controls.Add(lblMinMessageAge);
            grpEditSpecifics.Controls.Add(chkOnlyTextChanges);
            grpEditSpecifics.Controls.Add(chkIgnoreBotEdits);
            grpEditSpecifics.FillColor = Color.Transparent;
            grpEditSpecifics.FillColor2 = Color.Transparent;
            grpEditSpecifics.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpEditSpecifics.ForeColor = Color.White;
            grpEditSpecifics.ForeDisableColor = Color.Transparent;
            grpEditSpecifics.Location = new Point(0, 25);
            grpEditSpecifics.Margin = new Padding(0);
            grpEditSpecifics.MinimumSize = new Size(1, 1);
            grpEditSpecifics.Name = "grpEditSpecifics";
            grpEditSpecifics.Padding = new Padding(0, 32, 0, 0);
            grpEditSpecifics.Radius = 0;
            grpEditSpecifics.RectColor = Color.FromArgb(58, 58, 69);
            grpEditSpecifics.RectDisableColor = Color.Transparent;
            grpEditSpecifics.Size = new Size(680, 140);
            grpEditSpecifics.TabIndex = 30;
            grpEditSpecifics.Text = "Специфичные настройки редактирования";
            grpEditSpecifics.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // cmbEditorFilter
            // 
            cmbEditorFilter.DataSource = null;
            cmbEditorFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbEditorFilter.FillColor = Color.FromArgb(42, 46, 57);
            cmbEditorFilter.FillColor2 = Color.Transparent;
            cmbEditorFilter.FillDisableColor = Color.Transparent;
            cmbEditorFilter.Font = new Font("Segoe UI", 9F);
            cmbEditorFilter.ForeColor = Color.White;
            cmbEditorFilter.ForeDisableColor = Color.Transparent;
            cmbEditorFilter.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbEditorFilter.Items.AddRange(new object[] { "Любой пользователь", "Только автор сообщения", "Только администраторы", "Кроме автора" });
            cmbEditorFilter.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbEditorFilter.Location = new Point(14, 45);
            cmbEditorFilter.Margin = new Padding(4, 5, 4, 5);
            cmbEditorFilter.MinimumSize = new Size(63, 0);
            cmbEditorFilter.Name = "cmbEditorFilter";
            cmbEditorFilter.Padding = new Padding(0, 0, 30, 2);
            cmbEditorFilter.RectColor = Color.FromArgb(65, 71, 84);
            cmbEditorFilter.RectDisableColor = Color.Transparent;
            cmbEditorFilter.Size = new Size(180, 25);
            cmbEditorFilter.Style = Sunny.UI.UIStyle.Custom;
            cmbEditorFilter.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbEditorFilter.SymbolSize = 24;
            cmbEditorFilter.TabIndex = 2;
            cmbEditorFilter.Text = "Любой пользователь";
            cmbEditorFilter.TextAlignment = ContentAlignment.MiddleLeft;
            cmbEditorFilter.Watermark = "";
            // 
            // lblEditorFilter
            // 
            lblEditorFilter.AutoSize = true;
            lblEditorFilter.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEditorFilter.ForeColor = SystemColors.ActiveBorder;
            lblEditorFilter.Location = new Point(14, 28);
            lblEditorFilter.Name = "lblEditorFilter";
            lblEditorFilter.Size = new Size(119, 13);
            lblEditorFilter.TabIndex = 1;
            lblEditorFilter.Text = "Кто внес изменения:";
            // 
            // nudMinMessageAge
            // 
            nudMinMessageAge.FillColor = Color.FromArgb(42, 46, 57);
            nudMinMessageAge.FillColor2 = Color.Transparent;
            nudMinMessageAge.FillDisableColor = Color.Transparent;
            nudMinMessageAge.FillReadOnlyColor = Color.Transparent;
            nudMinMessageAge.Font = new Font("Segoe UI", 9F);
            nudMinMessageAge.ForeColor = Color.White;
            nudMinMessageAge.ForeDisableColor = Color.Transparent;
            nudMinMessageAge.ForeReadOnlyColor = Color.Transparent;
            nudMinMessageAge.Location = new Point(210, 45);
            nudMinMessageAge.Margin = new Padding(4, 5, 4, 5);
            nudMinMessageAge.Maximum = 86400D;
            nudMinMessageAge.Minimum = 0D;
            nudMinMessageAge.MinimumSize = new Size(1, 16);
            nudMinMessageAge.Name = "nudMinMessageAge";
            nudMinMessageAge.Padding = new Padding(5);
            nudMinMessageAge.RectColor = Color.FromArgb(65, 71, 84);
            nudMinMessageAge.RectDisableColor = Color.Transparent;
            nudMinMessageAge.RectHoverColor = Color.BlueViolet;
            nudMinMessageAge.RectPressColor = Color.Indigo;
            nudMinMessageAge.RectReadOnlyColor = Color.Transparent;
            nudMinMessageAge.ShowText = false;
            nudMinMessageAge.Size = new Size(100, 25);
            nudMinMessageAge.TabIndex = 4;
            nudMinMessageAge.Text = "0";
            nudMinMessageAge.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblMinMessageAge
            // 
            lblMinMessageAge.AutoSize = true;
            lblMinMessageAge.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMinMessageAge.ForeColor = SystemColors.ActiveBorder;
            lblMinMessageAge.Location = new Point(210, 28);
            lblMinMessageAge.Name = "lblMinMessageAge";
            lblMinMessageAge.Size = new Size(175, 13);
            lblMinMessageAge.TabIndex = 3;
            lblMinMessageAge.Text = "Мин. возраст сообщения (сек):";
            // 
            // chkOnlyTextChanges
            // 
            chkOnlyTextChanges.CheckBoxColor = Color.BlueViolet;
            chkOnlyTextChanges.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkOnlyTextChanges.ForeColor = Color.White;
            chkOnlyTextChanges.Location = new Point(14, 78);
            chkOnlyTextChanges.MinimumSize = new Size(1, 1);
            chkOnlyTextChanges.Name = "chkOnlyTextChanges";
            chkOnlyTextChanges.Size = new Size(545, 25);
            chkOnlyTextChanges.TabIndex = 5;
            chkOnlyTextChanges.Text = "Только изменение текста (игнорировать смену медиа/прикрепленных файлов)";
            // 
            // chkIgnoreBotEdits
            // 
            chkIgnoreBotEdits.CheckBoxColor = Color.BlueViolet;
            chkIgnoreBotEdits.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreBotEdits.ForeColor = Color.White;
            chkIgnoreBotEdits.Location = new Point(14, 108);
            chkIgnoreBotEdits.MinimumSize = new Size(1, 1);
            chkIgnoreBotEdits.Name = "chkIgnoreBotEdits";
            chkIgnoreBotEdits.Size = new Size(545, 25);
            chkIgnoreBotEdits.TabIndex = 6;
            chkIgnoreBotEdits.Text = "Игнорировать редактирования, сделанные ботами";
            // 
            // grpBasicFilters
            // 
            grpBasicFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBasicFilters.BackColor = Color.Transparent;
            grpBasicFilters.Controls.Add(cmbTgUserFilter);
            grpBasicFilters.Controls.Add(lblTgUserFilter);
            grpBasicFilters.Controls.Add(nudTgMinLength);
            grpBasicFilters.Controls.Add(lblTgMinLength);
            grpBasicFilters.FillColor = Color.Transparent;
            grpBasicFilters.FillColor2 = Color.Transparent;
            grpBasicFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpBasicFilters.ForeColor = Color.White;
            grpBasicFilters.ForeDisableColor = Color.Transparent;
            grpBasicFilters.Location = new Point(0, 165);
            grpBasicFilters.Margin = new Padding(0);
            grpBasicFilters.MinimumSize = new Size(1, 1);
            grpBasicFilters.Name = "grpBasicFilters";
            grpBasicFilters.Padding = new Padding(0, 32, 0, 0);
            grpBasicFilters.Radius = 0;
            grpBasicFilters.RectColor = Color.FromArgb(58, 58, 69);
            grpBasicFilters.RectDisableColor = Color.Transparent;
            grpBasicFilters.Size = new Size(680, 80);
            grpBasicFilters.TabIndex = 22;
            grpBasicFilters.Text = "Основные фильтры (автор исходного сообщения)";
            grpBasicFilters.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // cmbTgUserFilter
            // 
            cmbTgUserFilter.DataSource = null;
            cmbTgUserFilter.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbTgUserFilter.FillColor = Color.FromArgb(42, 46, 57);
            cmbTgUserFilter.FillColor2 = Color.Transparent;
            cmbTgUserFilter.FillDisableColor = Color.Transparent;
            cmbTgUserFilter.Font = new Font("Segoe UI", 9F);
            cmbTgUserFilter.ForeColor = Color.White;
            cmbTgUserFilter.ForeDisableColor = Color.Transparent;
            cmbTgUserFilter.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbTgUserFilter.Items.AddRange(new object[] { "Все пользователи", "Только админы", "Только обычные", "Только боты", "Кроме ботов" });
            cmbTgUserFilter.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbTgUserFilter.Location = new Point(14, 45);
            cmbTgUserFilter.Margin = new Padding(4, 5, 4, 5);
            cmbTgUserFilter.MinimumSize = new Size(63, 0);
            cmbTgUserFilter.Name = "cmbTgUserFilter";
            cmbTgUserFilter.Padding = new Padding(0, 0, 30, 2);
            cmbTgUserFilter.RectColor = Color.FromArgb(65, 71, 84);
            cmbTgUserFilter.RectDisableColor = Color.Transparent;
            cmbTgUserFilter.Size = new Size(180, 25);
            cmbTgUserFilter.Style = Sunny.UI.UIStyle.Custom;
            cmbTgUserFilter.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbTgUserFilter.SymbolSize = 24;
            cmbTgUserFilter.TabIndex = 2;
            cmbTgUserFilter.Text = "Все пользователи";
            cmbTgUserFilter.TextAlignment = ContentAlignment.MiddleLeft;
            cmbTgUserFilter.Watermark = "";
            // 
            // lblTgUserFilter
            // 
            lblTgUserFilter.AutoSize = true;
            lblTgUserFilter.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTgUserFilter.ForeColor = SystemColors.ActiveBorder;
            lblTgUserFilter.Location = new Point(14, 28);
            lblTgUserFilter.Name = "lblTgUserFilter";
            lblTgUserFilter.Size = new Size(180, 13);
            lblTgUserFilter.TabIndex = 1;
            lblTgUserFilter.Text = "От кого принимать сообщения:";
            // 
            // nudTgMinLength
            // 
            nudTgMinLength.FillColor = Color.FromArgb(42, 46, 57);
            nudTgMinLength.FillColor2 = Color.Transparent;
            nudTgMinLength.FillDisableColor = Color.Transparent;
            nudTgMinLength.FillReadOnlyColor = Color.Transparent;
            nudTgMinLength.Font = new Font("Segoe UI", 9F);
            nudTgMinLength.ForeColor = Color.White;
            nudTgMinLength.ForeDisableColor = Color.Transparent;
            nudTgMinLength.ForeReadOnlyColor = Color.Transparent;
            nudTgMinLength.Location = new Point(210, 45);
            nudTgMinLength.Margin = new Padding(4, 5, 4, 5);
            nudTgMinLength.Maximum = 10000D;
            nudTgMinLength.Minimum = 0D;
            nudTgMinLength.MinimumSize = new Size(1, 16);
            nudTgMinLength.Name = "nudTgMinLength";
            nudTgMinLength.Padding = new Padding(5);
            nudTgMinLength.RectColor = Color.FromArgb(65, 71, 84);
            nudTgMinLength.RectDisableColor = Color.Transparent;
            nudTgMinLength.RectHoverColor = Color.BlueViolet;
            nudTgMinLength.RectPressColor = Color.Indigo;
            nudTgMinLength.RectReadOnlyColor = Color.Transparent;
            nudTgMinLength.ShowText = false;
            nudTgMinLength.Size = new Size(100, 25);
            nudTgMinLength.TabIndex = 4;
            nudTgMinLength.Text = "0";
            nudTgMinLength.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTgMinLength
            // 
            lblTgMinLength.AutoSize = true;
            lblTgMinLength.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTgMinLength.ForeColor = SystemColors.ActiveBorder;
            lblTgMinLength.Location = new Point(210, 28);
            lblTgMinLength.Name = "lblTgMinLength";
            lblTgMinLength.Size = new Size(140, 13);
            lblTgMinLength.TabIndex = 3;
            lblTgMinLength.Text = "Мин. длина сообщения:";
            // 
            // grpTimeFilter
            // 
            grpTimeFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpTimeFilter.BackColor = Color.Transparent;
            grpTimeFilter.Controls.Add(chkSunday);
            grpTimeFilter.Controls.Add(chkSaturday);
            grpTimeFilter.Controls.Add(chkFriday);
            grpTimeFilter.Controls.Add(chkThursday);
            grpTimeFilter.Controls.Add(chkWednesday);
            grpTimeFilter.Controls.Add(chkTuesday);
            grpTimeFilter.Controls.Add(chkMonday);
            grpTimeFilter.Controls.Add(lblDaysOfWeek);
            grpTimeFilter.Controls.Add(chkTimeEnabled);
            grpTimeFilter.Controls.Add(timeTo);
            grpTimeFilter.Controls.Add(lblTimeTo);
            grpTimeFilter.Controls.Add(timeFrom);
            grpTimeFilter.Controls.Add(lblTimeFilter);
            grpTimeFilter.FillColor = Color.Transparent;
            grpTimeFilter.FillColor2 = Color.Transparent;
            grpTimeFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpTimeFilter.ForeColor = Color.White;
            grpTimeFilter.ForeDisableColor = Color.Transparent;
            grpTimeFilter.Location = new Point(0, 245);
            grpTimeFilter.Margin = new Padding(0);
            grpTimeFilter.MinimumSize = new Size(1, 1);
            grpTimeFilter.Name = "grpTimeFilter";
            grpTimeFilter.Padding = new Padding(0, 32, 0, 0);
            grpTimeFilter.Radius = 0;
            grpTimeFilter.RectColor = Color.FromArgb(58, 58, 69);
            grpTimeFilter.RectDisableColor = Color.Transparent;
            grpTimeFilter.Size = new Size(680, 120);
            grpTimeFilter.TabIndex = 23;
            grpTimeFilter.Text = "Фильтр по времени";
            grpTimeFilter.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // chkSunday
            // 
            chkSunday.CheckBoxColor = Color.BlueViolet;
            chkSunday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkSunday.ForeColor = Color.White;
            chkSunday.Location = new Point(373, 83);
            chkSunday.MinimumSize = new Size(1, 1);
            chkSunday.Name = "chkSunday";
            chkSunday.Size = new Size(47, 25);
            chkSunday.TabIndex = 16;
            chkSunday.Text = "Вс";
            // 
            // chkSaturday
            // 
            chkSaturday.CheckBoxColor = Color.BlueViolet;
            chkSaturday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkSaturday.ForeColor = Color.White;
            chkSaturday.Location = new Point(326, 83);
            chkSaturday.MinimumSize = new Size(1, 1);
            chkSaturday.Name = "chkSaturday";
            chkSaturday.Size = new Size(47, 25);
            chkSaturday.TabIndex = 15;
            chkSaturday.Text = "Сб";
            // 
            // chkFriday
            // 
            chkFriday.CheckBoxColor = Color.BlueViolet;
            chkFriday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkFriday.ForeColor = Color.White;
            chkFriday.Location = new Point(279, 83);
            chkFriday.MinimumSize = new Size(1, 1);
            chkFriday.Name = "chkFriday";
            chkFriday.Size = new Size(47, 25);
            chkFriday.TabIndex = 14;
            chkFriday.Text = "Пт";
            // 
            // chkThursday
            // 
            chkThursday.CheckBoxColor = Color.BlueViolet;
            chkThursday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkThursday.ForeColor = Color.White;
            chkThursday.Location = new Point(232, 83);
            chkThursday.MinimumSize = new Size(1, 1);
            chkThursday.Name = "chkThursday";
            chkThursday.Size = new Size(47, 25);
            chkThursday.TabIndex = 13;
            chkThursday.Text = "Чт";
            // 
            // chkWednesday
            // 
            chkWednesday.CheckBoxColor = Color.BlueViolet;
            chkWednesday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkWednesday.ForeColor = Color.White;
            chkWednesday.Location = new Point(185, 83);
            chkWednesday.MinimumSize = new Size(1, 1);
            chkWednesday.Name = "chkWednesday";
            chkWednesday.Size = new Size(47, 25);
            chkWednesday.TabIndex = 12;
            chkWednesday.Text = "Ср";
            // 
            // chkTuesday
            // 
            chkTuesday.CheckBoxColor = Color.BlueViolet;
            chkTuesday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkTuesday.ForeColor = Color.White;
            chkTuesday.Location = new Point(138, 83);
            chkTuesday.MinimumSize = new Size(1, 1);
            chkTuesday.Name = "chkTuesday";
            chkTuesday.Size = new Size(47, 25);
            chkTuesday.TabIndex = 11;
            chkTuesday.Text = "Вт";
            // 
            // chkMonday
            // 
            chkMonday.CheckBoxColor = Color.BlueViolet;
            chkMonday.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkMonday.ForeColor = Color.White;
            chkMonday.Location = new Point(91, 83);
            chkMonday.MinimumSize = new Size(1, 1);
            chkMonday.Name = "chkMonday";
            chkMonday.Size = new Size(47, 25);
            chkMonday.TabIndex = 10;
            chkMonday.Text = "Пн";
            // 
            // lblDaysOfWeek
            // 
            lblDaysOfWeek.AutoSize = true;
            lblDaysOfWeek.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDaysOfWeek.ForeColor = SystemColors.ActiveBorder;
            lblDaysOfWeek.Location = new Point(16, 88);
            lblDaysOfWeek.Name = "lblDaysOfWeek";
            lblDaysOfWeek.Size = new Size(73, 13);
            lblDaysOfWeek.TabIndex = 9;
            lblDaysOfWeek.Text = "Дни недели:";
            // 
            // chkTimeEnabled
            // 
            chkTimeEnabled.CheckBoxColor = Color.BlueViolet;
            chkTimeEnabled.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkTimeEnabled.ForeColor = Color.White;
            chkTimeEnabled.Location = new Point(270, 49);
            chkTimeEnabled.MinimumSize = new Size(1, 1);
            chkTimeEnabled.Name = "chkTimeEnabled";
            chkTimeEnabled.Size = new Size(220, 25);
            chkTimeEnabled.TabIndex = 8;
            chkTimeEnabled.Text = "Включить фильтр по времени";
            // 
            // timeTo
            // 
            timeTo.FillColor = Color.FromArgb(42, 46, 57);
            timeTo.FillColor2 = Color.Transparent;
            timeTo.FillDisableColor = Color.Transparent;
            timeTo.Font = new Font("Segoe UI", 9F);
            timeTo.ForeColor = Color.White;
            timeTo.ForeDisableColor = Color.Transparent;
            timeTo.Location = new Point(150, 49);
            timeTo.Margin = new Padding(4, 5, 4, 5);
            timeTo.MaxLength = 8;
            timeTo.MinimumSize = new Size(63, 0);
            timeTo.Name = "timeTo";
            timeTo.Padding = new Padding(0, 0, 30, 2);
            timeTo.RectColor = Color.FromArgb(65, 71, 84);
            timeTo.RectDisableColor = Color.Transparent;
            timeTo.Size = new Size(100, 25);
            timeTo.Style = Sunny.UI.UIStyle.Custom;
            timeTo.StyleDropDown = Sunny.UI.UIStyle.Purple;
            timeTo.SymbolDropDown = 61555;
            timeTo.SymbolNormal = 61555;
            timeTo.SymbolSize = 24;
            timeTo.TabIndex = 2;
            timeTo.Text = "23:59:59";
            timeTo.TextAlignment = ContentAlignment.MiddleLeft;
            timeTo.TimeCultureInfo = new System.Globalization.CultureInfo("ru-KZ");
            timeTo.Value = new DateTime(2026, 9, 21, 23, 59, 59, 0);
            timeTo.Watermark = "";
            // 
            // lblTimeTo
            // 
            lblTimeTo.AutoSize = true;
            lblTimeTo.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTimeTo.ForeColor = SystemColors.ActiveBorder;
            lblTimeTo.Location = new Point(124, 54);
            lblTimeTo.Name = "lblTimeTo";
            lblTimeTo.Size = new Size(20, 13);
            lblTimeTo.TabIndex = 2;
            lblTimeTo.Text = "до";
            // 
            // timeFrom
            // 
            timeFrom.FillColor = Color.FromArgb(42, 46, 57);
            timeFrom.FillColor2 = Color.Transparent;
            timeFrom.FillDisableColor = Color.Transparent;
            timeFrom.Font = new Font("Segoe UI", 9F);
            timeFrom.ForeColor = Color.White;
            timeFrom.ForeDisableColor = Color.Transparent;
            timeFrom.Location = new Point(16, 49);
            timeFrom.Margin = new Padding(4, 5, 4, 5);
            timeFrom.MaxLength = 8;
            timeFrom.MinimumSize = new Size(63, 0);
            timeFrom.Name = "timeFrom";
            timeFrom.Padding = new Padding(0, 0, 30, 2);
            timeFrom.RectColor = Color.FromArgb(65, 71, 84);
            timeFrom.RectDisableColor = Color.Transparent;
            timeFrom.Size = new Size(100, 25);
            timeFrom.Style = Sunny.UI.UIStyle.Custom;
            timeFrom.StyleDropDown = Sunny.UI.UIStyle.Purple;
            timeFrom.SymbolDropDown = 61555;
            timeFrom.SymbolNormal = 61555;
            timeFrom.SymbolSize = 24;
            timeFrom.TabIndex = 1;
            timeFrom.Text = "00:00:00";
            timeFrom.TextAlignment = ContentAlignment.MiddleLeft;
            timeFrom.TimeCultureInfo = new System.Globalization.CultureInfo("ru-KZ");
            timeFrom.Value = new DateTime(2026, 9, 21, 0, 0, 0, 0);
            timeFrom.Watermark = "";
            // 
            // lblTimeFilter
            // 
            lblTimeFilter.AutoSize = true;
            lblTimeFilter.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTimeFilter.ForeColor = SystemColors.ActiveBorder;
            lblTimeFilter.Location = new Point(14, 32);
            lblTimeFilter.Name = "lblTimeFilter";
            lblTimeFilter.Size = new Size(135, 13);
            lblTimeFilter.TabIndex = 0;
            lblTimeFilter.Text = "Работать только в часы:";
            // 
            // grpAntiSpam
            // 
            grpAntiSpam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAntiSpam.BackColor = Color.Transparent;
            grpAntiSpam.Controls.Add(lblMaxTriggersUnit);
            grpAntiSpam.Controls.Add(nudMaxTriggers);
            grpAntiSpam.Controls.Add(lblMaxTriggers);
            grpAntiSpam.Controls.Add(lblDuplicateUnit);
            grpAntiSpam.Controls.Add(nudDuplicateInterval);
            grpAntiSpam.Controls.Add(lblDuplicateInterva);
            grpAntiSpam.Controls.Add(chkIgnoreDuplicates);
            grpAntiSpam.FillColor = Color.Transparent;
            grpAntiSpam.FillColor2 = Color.Transparent;
            grpAntiSpam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpAntiSpam.ForeColor = Color.White;
            grpAntiSpam.ForeDisableColor = Color.Transparent;
            grpAntiSpam.Location = new Point(0, 365);
            grpAntiSpam.Margin = new Padding(0);
            grpAntiSpam.MinimumSize = new Size(1, 1);
            grpAntiSpam.Name = "grpAntiSpam";
            grpAntiSpam.Padding = new Padding(0, 32, 0, 0);
            grpAntiSpam.Radius = 0;
            grpAntiSpam.RectColor = Color.FromArgb(58, 58, 69);
            grpAntiSpam.RectDisableColor = Color.Transparent;
            grpAntiSpam.Size = new Size(680, 100);
            grpAntiSpam.TabIndex = 24;
            grpAntiSpam.Text = "Анти-спам";
            grpAntiSpam.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblMaxTriggersUnit
            // 
            lblMaxTriggersUnit.AutoSize = true;
            lblMaxTriggersUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMaxTriggersUnit.ForeColor = SystemColors.ActiveBorder;
            lblMaxTriggersUnit.Location = new Point(483, 67);
            lblMaxTriggersUnit.Name = "lblMaxTriggersUnit";
            lblMaxTriggersUnit.Size = new Size(124, 13);
            lblMaxTriggersUnit.TabIndex = 20;
            lblMaxTriggersUnit.Text = "в час (0 = без лимита)";
            // 
            // nudMaxTriggers
            // 
            nudMaxTriggers.FillColor = Color.FromArgb(42, 46, 57);
            nudMaxTriggers.FillColor2 = Color.Transparent;
            nudMaxTriggers.FillDisableColor = Color.Transparent;
            nudMaxTriggers.FillReadOnlyColor = Color.Transparent;
            nudMaxTriggers.Font = new Font("Segoe UI", 9F);
            nudMaxTriggers.ForeColor = Color.White;
            nudMaxTriggers.ForeDisableColor = Color.Transparent;
            nudMaxTriggers.ForeReadOnlyColor = Color.Transparent;
            nudMaxTriggers.Location = new Point(400, 62);
            nudMaxTriggers.Margin = new Padding(4, 5, 4, 5);
            nudMaxTriggers.Maximum = 1000D;
            nudMaxTriggers.Minimum = 0D;
            nudMaxTriggers.MinimumSize = new Size(1, 16);
            nudMaxTriggers.Name = "nudMaxTriggers";
            nudMaxTriggers.Padding = new Padding(5);
            nudMaxTriggers.RectColor = Color.FromArgb(65, 71, 84);
            nudMaxTriggers.RectDisableColor = Color.Transparent;
            nudMaxTriggers.RectHoverColor = Color.BlueViolet;
            nudMaxTriggers.RectPressColor = Color.Indigo;
            nudMaxTriggers.RectReadOnlyColor = Color.Transparent;
            nudMaxTriggers.ShowText = false;
            nudMaxTriggers.Size = new Size(80, 25);
            nudMaxTriggers.TabIndex = 6;
            nudMaxTriggers.Text = "60";
            nudMaxTriggers.TextAlignment = ContentAlignment.MiddleCenter;
            nudMaxTriggers.Value = 60;
            // 
            // lblMaxTriggers
            // 
            lblMaxTriggers.AutoSize = true;
            lblMaxTriggers.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMaxTriggers.ForeColor = SystemColors.ActiveBorder;
            lblMaxTriggers.Location = new Point(280, 67);
            lblMaxTriggers.Name = "lblMaxTriggers";
            lblMaxTriggers.Size = new Size(120, 13);
            lblMaxTriggers.TabIndex = 19;
            lblMaxTriggers.Text = "Макс. срабатываний:";
            // 
            // lblDuplicateUnit
            // 
            lblDuplicateUnit.AutoSize = true;
            lblDuplicateUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDuplicateUnit.ForeColor = SystemColors.ActiveBorder;
            lblDuplicateUnit.Location = new Point(224, 67);
            lblDuplicateUnit.Name = "lblDuplicateUnit";
            lblDuplicateUnit.Size = new Size(24, 13);
            lblDuplicateUnit.TabIndex = 18;
            lblDuplicateUnit.Text = "сек";
            // 
            // nudDuplicateInterval
            // 
            nudDuplicateInterval.FillColor = Color.FromArgb(42, 46, 57);
            nudDuplicateInterval.FillColor2 = Color.Transparent;
            nudDuplicateInterval.FillDisableColor = Color.Transparent;
            nudDuplicateInterval.FillReadOnlyColor = Color.Transparent;
            nudDuplicateInterval.Font = new Font("Segoe UI", 9F);
            nudDuplicateInterval.ForeColor = Color.White;
            nudDuplicateInterval.ForeDisableColor = Color.Transparent;
            nudDuplicateInterval.ForeReadOnlyColor = Color.Transparent;
            nudDuplicateInterval.Location = new Point(134, 62);
            nudDuplicateInterval.Margin = new Padding(4, 5, 4, 5);
            nudDuplicateInterval.Maximum = 3600D;
            nudDuplicateInterval.Minimum = 0D;
            nudDuplicateInterval.MinimumSize = new Size(1, 16);
            nudDuplicateInterval.Name = "nudDuplicateInterval";
            nudDuplicateInterval.Padding = new Padding(5);
            nudDuplicateInterval.RectColor = Color.FromArgb(65, 71, 84);
            nudDuplicateInterval.RectDisableColor = Color.Transparent;
            nudDuplicateInterval.RectHoverColor = Color.BlueViolet;
            nudDuplicateInterval.RectPressColor = Color.Indigo;
            nudDuplicateInterval.RectReadOnlyColor = Color.Transparent;
            nudDuplicateInterval.ShowText = false;
            nudDuplicateInterval.Size = new Size(80, 25);
            nudDuplicateInterval.TabIndex = 5;
            nudDuplicateInterval.Text = "60";
            nudDuplicateInterval.TextAlignment = ContentAlignment.MiddleCenter;
            nudDuplicateInterval.Value = 60;
            // 
            // lblDuplicateInterva
            // 
            lblDuplicateInterva.AutoSize = true;
            lblDuplicateInterva.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDuplicateInterva.ForeColor = SystemColors.ActiveBorder;
            lblDuplicateInterva.Location = new Point(16, 67);
            lblDuplicateInterva.Name = "lblDuplicateInterva";
            lblDuplicateInterva.Size = new Size(116, 13);
            lblDuplicateInterva.TabIndex = 17;
            lblDuplicateInterva.Text = "Интервал повторов:";
            // 
            // chkIgnoreDuplicates
            // 
            chkIgnoreDuplicates.CheckBoxColor = Color.BlueViolet;
            chkIgnoreDuplicates.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreDuplicates.ForeColor = Color.White;
            chkIgnoreDuplicates.Location = new Point(16, 32);
            chkIgnoreDuplicates.MinimumSize = new Size(1, 1);
            chkIgnoreDuplicates.Name = "chkIgnoreDuplicates";
            chkIgnoreDuplicates.Size = new Size(350, 25);
            chkIgnoreDuplicates.TabIndex = 17;
            chkIgnoreDuplicates.Text = "Игнорировать повторяющиеся сообщения";
            // 
            // grpAdditionalFilters
            // 
            grpAdditionalFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpAdditionalFilters.BackColor = Color.Transparent;
            grpAdditionalFilters.Controls.Add(chkIgnoreEmoji);
            grpAdditionalFilters.Controls.Add(chkIgnoreLinks);
            grpAdditionalFilters.Controls.Add(chkIgnoreEmpty);
            grpAdditionalFilters.Controls.Add(chkIgnoreForwarded);
            grpAdditionalFilters.FillColor = Color.Transparent;
            grpAdditionalFilters.FillColor2 = Color.Transparent;
            grpAdditionalFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpAdditionalFilters.ForeColor = Color.White;
            grpAdditionalFilters.ForeDisableColor = Color.Transparent;
            grpAdditionalFilters.Location = new Point(0, 465);
            grpAdditionalFilters.Margin = new Padding(0);
            grpAdditionalFilters.MinimumSize = new Size(1, 1);
            grpAdditionalFilters.Name = "grpAdditionalFilters";
            grpAdditionalFilters.Padding = new Padding(0, 32, 0, 0);
            grpAdditionalFilters.Radius = 0;
            grpAdditionalFilters.RectColor = Color.FromArgb(58, 58, 69);
            grpAdditionalFilters.RectDisableColor = Color.Transparent;
            grpAdditionalFilters.Size = new Size(680, 140);
            grpAdditionalFilters.TabIndex = 24;
            grpAdditionalFilters.Text = "Дополнительные фильтры";
            grpAdditionalFilters.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // chkIgnoreEmoji
            // 
            chkIgnoreEmoji.CheckBoxColor = Color.BlueViolet;
            chkIgnoreEmoji.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreEmoji.ForeColor = Color.White;
            chkIgnoreEmoji.Location = new Point(16, 109);
            chkIgnoreEmoji.MinimumSize = new Size(1, 1);
            chkIgnoreEmoji.Name = "chkIgnoreEmoji";
            chkIgnoreEmoji.Size = new Size(450, 25);
            chkIgnoreEmoji.TabIndex = 24;
            chkIgnoreEmoji.Text = "Игнорировать сообщения, состоящие только из эмодзи";
            // 
            // chkIgnoreLinks
            // 
            chkIgnoreLinks.CheckBoxColor = Color.BlueViolet;
            chkIgnoreLinks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreLinks.ForeColor = Color.White;
            chkIgnoreLinks.Location = new Point(16, 82);
            chkIgnoreLinks.MinimumSize = new Size(1, 1);
            chkIgnoreLinks.Name = "chkIgnoreLinks";
            chkIgnoreLinks.Size = new Size(450, 25);
            chkIgnoreLinks.TabIndex = 23;
            chkIgnoreLinks.Text = "Игнорировать сообщения со ссылками";
            // 
            // chkIgnoreEmpty
            // 
            chkIgnoreEmpty.CheckBoxColor = Color.BlueViolet;
            chkIgnoreEmpty.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreEmpty.ForeColor = Color.White;
            chkIgnoreEmpty.Location = new Point(16, 55);
            chkIgnoreEmpty.MinimumSize = new Size(1, 1);
            chkIgnoreEmpty.Name = "chkIgnoreEmpty";
            chkIgnoreEmpty.Size = new Size(450, 25);
            chkIgnoreEmpty.TabIndex = 22;
            chkIgnoreEmpty.Text = "Игнорировать сообщения без текста (только медиа/стикеры)";
            // 
            // chkIgnoreForwarded
            // 
            chkIgnoreForwarded.CheckBoxColor = Color.BlueViolet;
            chkIgnoreForwarded.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreForwarded.ForeColor = Color.White;
            chkIgnoreForwarded.Location = new Point(16, 28);
            chkIgnoreForwarded.MinimumSize = new Size(1, 1);
            chkIgnoreForwarded.Name = "chkIgnoreForwarded";
            chkIgnoreForwarded.Size = new Size(450, 25);
            chkIgnoreForwarded.TabIndex = 21;
            chkIgnoreForwarded.Text = "Игнорировать пересланные сообщения из других чатов";
            // 
            // grpLists
            // 
            grpLists.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLists.BackColor = Color.Transparent;
            grpLists.Controls.Add(txtWhitelist);
            grpLists.Controls.Add(lblWhitelist);
            grpLists.Controls.Add(txtTgBlacklist);
            grpLists.Controls.Add(lblBlacklist);
            grpLists.FillColor = Color.Transparent;
            grpLists.FillColor2 = Color.Transparent;
            grpLists.FillDisableColor = Color.Transparent;
            grpLists.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpLists.ForeColor = Color.White;
            grpLists.ForeDisableColor = Color.Transparent;
            grpLists.Location = new Point(0, 605);
            grpLists.Margin = new Padding(0);
            grpLists.MinimumSize = new Size(1, 1);
            grpLists.Name = "grpLists";
            grpLists.Padding = new Padding(0, 32, 0, 0);
            grpLists.Radius = 0;
            grpLists.RectColor = Color.FromArgb(58, 58, 69);
            grpLists.RectDisableColor = Color.Transparent;
            grpLists.Size = new Size(680, 185);
            grpLists.TabIndex = 24;
            grpLists.Text = "Черный и белый списки";
            grpLists.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // txtWhitelist
            // 
            txtWhitelist.FillColor = Color.FromArgb(42, 46, 57);
            txtWhitelist.FillColor2 = Color.Transparent;
            txtWhitelist.FillDisableColor = Color.Transparent;
            txtWhitelist.FillReadOnlyColor = Color.Transparent;
            txtWhitelist.Font = new Font("Segoe UI", 9F);
            txtWhitelist.ForeColor = Color.White;
            txtWhitelist.ForeDisableColor = Color.Transparent;
            txtWhitelist.ForeReadOnlyColor = Color.Transparent;
            txtWhitelist.Location = new Point(16, 122);
            txtWhitelist.Margin = new Padding(4, 5, 4, 5);
            txtWhitelist.MinimumSize = new Size(1, 16);
            txtWhitelist.Multiline = true;
            txtWhitelist.Name = "txtWhitelist";
            txtWhitelist.Padding = new Padding(5);
            txtWhitelist.RectColor = Color.FromArgb(65, 71, 84);
            txtWhitelist.RectDisableColor = Color.Transparent;
            txtWhitelist.RectReadOnlyColor = Color.Transparent;
            txtWhitelist.ShowText = false;
            txtWhitelist.Size = new Size(608, 50);
            txtWhitelist.TabIndex = 23;
            txtWhitelist.TextAlignment = ContentAlignment.TopLeft;
            txtWhitelist.Watermark = "Например: @user1, @user2 (оставьте пустым для всех)";
            txtWhitelist.WatermarkActiveColor = Color.LightGray;
            txtWhitelist.WatermarkColor = Color.LightGray;
            // 
            // lblWhitelist
            // 
            lblWhitelist.AutoSize = true;
            lblWhitelist.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWhitelist.ForeColor = SystemColors.ActiveBorder;
            lblWhitelist.Location = new Point(16, 105);
            lblWhitelist.Name = "lblWhitelist";
            lblWhitelist.Size = new Size(318, 13);
            lblWhitelist.TabIndex = 23;
            lblWhitelist.Text = "Белый список пользователей (@username через запятую):";
            // 
            // txtTgBlacklist
            // 
            txtTgBlacklist.FillColor = Color.FromArgb(42, 46, 57);
            txtTgBlacklist.FillColor2 = Color.Transparent;
            txtTgBlacklist.FillDisableColor = Color.Transparent;
            txtTgBlacklist.FillReadOnlyColor = Color.Transparent;
            txtTgBlacklist.Font = new Font("Segoe UI", 9F);
            txtTgBlacklist.ForeColor = Color.White;
            txtTgBlacklist.ForeDisableColor = Color.Transparent;
            txtTgBlacklist.ForeReadOnlyColor = Color.Transparent;
            txtTgBlacklist.Location = new Point(16, 47);
            txtTgBlacklist.Margin = new Padding(4, 5, 4, 5);
            txtTgBlacklist.MinimumSize = new Size(1, 16);
            txtTgBlacklist.Multiline = true;
            txtTgBlacklist.Name = "txtTgBlacklist";
            txtTgBlacklist.Padding = new Padding(5);
            txtTgBlacklist.RectColor = Color.FromArgb(65, 71, 84);
            txtTgBlacklist.RectDisableColor = Color.Transparent;
            txtTgBlacklist.RectReadOnlyColor = Color.Transparent;
            txtTgBlacklist.ShowText = false;
            txtTgBlacklist.Size = new Size(608, 50);
            txtTgBlacklist.TabIndex = 22;
            txtTgBlacklist.TextAlignment = ContentAlignment.TopLeft;
            txtTgBlacklist.Watermark = "Например: спам, реклама, бот, казино";
            txtTgBlacklist.WatermarkActiveColor = Color.LightGray;
            txtTgBlacklist.WatermarkColor = Color.LightGray;
            // 
            // lblBlacklist
            // 
            lblBlacklist.AutoSize = true;
            lblBlacklist.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBlacklist.ForeColor = SystemColors.ActiveBorder;
            lblBlacklist.Location = new Point(16, 30);
            lblBlacklist.Name = "lblBlacklist";
            lblBlacklist.Size = new Size(239, 13);
            lblBlacklist.TabIndex = 21;
            lblBlacklist.Text = "Черный список слов/фраз (через запятую):";
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpActions.BackColor = Color.Transparent;
            grpActions.Controls.Add(chkLogEvent);
            grpActions.Controls.Add(cmbPriority);
            grpActions.Controls.Add(lblPriority);
            grpActions.Controls.Add(lblCooldownUnit);
            grpActions.Controls.Add(nudCooldown);
            grpActions.Controls.Add(lblCooldown);
            grpActions.FillColor = Color.Transparent;
            grpActions.FillColor2 = Color.Transparent;
            grpActions.FillDisableColor = Color.Transparent;
            grpActions.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpActions.ForeColor = Color.White;
            grpActions.ForeDisableColor = Color.Transparent;
            grpActions.Location = new Point(0, 790);
            grpActions.Margin = new Padding(0);
            grpActions.MinimumSize = new Size(1, 1);
            grpActions.Name = "grpActions";
            grpActions.Padding = new Padding(0, 32, 0, 0);
            grpActions.Radius = 0;
            grpActions.RectColor = Color.FromArgb(58, 58, 69);
            grpActions.RectDisableColor = Color.Transparent;
            grpActions.Size = new Size(680, 100);
            grpActions.TabIndex = 25;
            grpActions.Text = "Действия при срабатывании";
            grpActions.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // chkLogEvent
            // 
            chkLogEvent.CheckBoxColor = Color.BlueViolet;
            chkLogEvent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkLogEvent.ForeColor = Color.White;
            chkLogEvent.Location = new Point(446, 51);
            chkLogEvent.MinimumSize = new Size(1, 1);
            chkLogEvent.Name = "chkLogEvent";
            chkLogEvent.Size = new Size(193, 25);
            chkLogEvent.TabIndex = 25;
            chkLogEvent.Text = "Логировать событие в файл";
            // 
            // cmbPriority
            // 
            cmbPriority.DataSource = null;
            cmbPriority.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbPriority.FillColor = Color.FromArgb(42, 46, 57);
            cmbPriority.FillColor2 = Color.Transparent;
            cmbPriority.FillDisableColor = Color.Transparent;
            cmbPriority.Font = new Font("Segoe UI", 9F);
            cmbPriority.ForeColor = Color.White;
            cmbPriority.ForeDisableColor = Color.Transparent;
            cmbPriority.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий", "Критический" });
            cmbPriority.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbPriority.Location = new Point(271, 51);
            cmbPriority.Margin = new Padding(4, 5, 4, 5);
            cmbPriority.MinimumSize = new Size(63, 0);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Padding = new Padding(0, 0, 30, 2);
            cmbPriority.RectColor = Color.FromArgb(65, 71, 84);
            cmbPriority.RectDisableColor = Color.Transparent;
            cmbPriority.Size = new Size(150, 25);
            cmbPriority.Style = Sunny.UI.UIStyle.Custom;
            cmbPriority.StyleDropDown = Sunny.UI.UIStyle.Purple;
            cmbPriority.SymbolSize = 24;
            cmbPriority.TabIndex = 4;
            cmbPriority.Text = "Средний";
            cmbPriority.TextAlignment = ContentAlignment.MiddleLeft;
            cmbPriority.Watermark = "";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPriority.ForeColor = SystemColors.ActiveBorder;
            lblPriority.Location = new Point(271, 31);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(117, 13);
            lblPriority.TabIndex = 26;
            lblPriority.Text = "Приоритет события:";
            // 
            // lblCooldownUnit
            // 
            lblCooldownUnit.AutoSize = true;
            lblCooldownUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCooldownUnit.ForeColor = SystemColors.ActiveBorder;
            lblCooldownUnit.Location = new Point(105, 56);
            lblCooldownUnit.Name = "lblCooldownUnit";
            lblCooldownUnit.Size = new Size(147, 13);
            lblCooldownUnit.TabIndex = 25;
            lblCooldownUnit.Text = "сек (0 = без ограничений)";
            // 
            // nudCooldown
            // 
            nudCooldown.FillColor = Color.FromArgb(42, 46, 57);
            nudCooldown.FillColor2 = Color.Transparent;
            nudCooldown.FillDisableColor = Color.Transparent;
            nudCooldown.FillReadOnlyColor = Color.Transparent;
            nudCooldown.Font = new Font("Segoe UI", 9F);
            nudCooldown.ForeColor = Color.White;
            nudCooldown.ForeDisableColor = Color.Transparent;
            nudCooldown.ForeReadOnlyColor = Color.Transparent;
            nudCooldown.Location = new Point(16, 51);
            nudCooldown.Margin = new Padding(4, 5, 4, 5);
            nudCooldown.Maximum = 3600D;
            nudCooldown.Minimum = 0D;
            nudCooldown.MinimumSize = new Size(1, 16);
            nudCooldown.Name = "nudCooldown";
            nudCooldown.Padding = new Padding(5);
            nudCooldown.RectColor = Color.FromArgb(65, 71, 84);
            nudCooldown.RectDisableColor = Color.Transparent;
            nudCooldown.RectHoverColor = Color.BlueViolet;
            nudCooldown.RectPressColor = Color.Indigo;
            nudCooldown.RectReadOnlyColor = Color.Transparent;
            nudCooldown.ShowText = false;
            nudCooldown.Size = new Size(80, 25);
            nudCooldown.TabIndex = 6;
            nudCooldown.Text = "60";
            nudCooldown.TextAlignment = ContentAlignment.MiddleCenter;
            nudCooldown.Value = 60;
            // 
            // lblCooldown
            // 
            lblCooldown.AutoSize = true;
            lblCooldown.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCooldown.ForeColor = SystemColors.ActiveBorder;
            lblCooldown.Location = new Point(16, 31);
            lblCooldown.Name = "lblCooldown";
            lblCooldown.Size = new Size(185, 13);
            lblCooldown.TabIndex = 24;
            lblCooldown.Text = "Кулдаун между срабатываниями:";
            // 
            // TgEditingSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(grpTgEventEditing);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            Name = "TgEditingSettingsControl";
            Size = new Size(690, 925);
            grpTgEventEditing.ResumeLayout(false);
            grpEditSpecifics.ResumeLayout(false);
            grpEditSpecifics.PerformLayout();
            grpBasicFilters.ResumeLayout(false);
            grpBasicFilters.PerformLayout();
            grpTimeFilter.ResumeLayout(false);
            grpTimeFilter.PerformLayout();
            grpAntiSpam.ResumeLayout(false);
            grpAntiSpam.PerformLayout();
            grpAdditionalFilters.ResumeLayout(false);
            grpLists.ResumeLayout(false);
            grpLists.PerformLayout();
            grpActions.ResumeLayout(false);
            grpActions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox grpTgEventEditing;
        private Sunny.UI.UIGroupBox grpEditSpecifics;
        private Sunny.UI.UIComboBox cmbEditorFilter;
        private Label lblEditorFilter;
        private Sunny.UI.UIIntegerUpDown nudMinMessageAge;
        private Label lblMinMessageAge;
        private Sunny.UI.UICheckBox chkOnlyTextChanges;
        private Sunny.UI.UICheckBox chkIgnoreBotEdits;
        private Sunny.UI.UIGroupBox grpBasicFilters;
        private Sunny.UI.UIComboBox cmbTgUserFilter;
        private Label lblTgUserFilter;
        private Sunny.UI.UIIntegerUpDown nudTgMinLength;
        private Label lblTgMinLength;
        private Sunny.UI.UIGroupBox grpTimeFilter;
        private Sunny.UI.UICheckBox chkSunday;
        private Sunny.UI.UICheckBox chkSaturday;
        private Sunny.UI.UICheckBox chkFriday;
        private Sunny.UI.UICheckBox chkThursday;
        private Sunny.UI.UICheckBox chkWednesday;
        private Sunny.UI.UICheckBox chkTuesday;
        private Sunny.UI.UICheckBox chkMonday;
        private Label lblDaysOfWeek;
        private Sunny.UI.UICheckBox chkTimeEnabled;
        private Sunny.UI.UITimePicker timeTo;
        private Label lblTimeTo;
        private Sunny.UI.UITimePicker timeFrom;
        private Label lblTimeFilter;
        private Sunny.UI.UIGroupBox grpAntiSpam;
        private Label lblMaxTriggersUnit;
        private Sunny.UI.UIIntegerUpDown nudMaxTriggers;
        private Label lblMaxTriggers;
        private Label lblDuplicateUnit;
        private Sunny.UI.UIIntegerUpDown nudDuplicateInterval;
        private Label lblDuplicateInterva;
        private Sunny.UI.UICheckBox chkIgnoreDuplicates;
        private Sunny.UI.UIGroupBox grpAdditionalFilters;
        private Sunny.UI.UICheckBox chkIgnoreEmoji;
        private Sunny.UI.UICheckBox chkIgnoreLinks;
        private Sunny.UI.UICheckBox chkIgnoreEmpty;
        private Sunny.UI.UICheckBox chkIgnoreForwarded;
        private Sunny.UI.UIGroupBox grpLists;
        private Label lblBlacklist;
        private Sunny.UI.UITextBox txtTgBlacklist;
        private Sunny.UI.UITextBox txtWhitelist;
        private Label lblWhitelist;
        private Sunny.UI.UIGroupBox grpActions;
        private Label lblCooldown;
        private Label lblCooldownUnit;
        private Sunny.UI.UIIntegerUpDown nudCooldown;
        private Sunny.UI.UICheckBox chkLogEvent;
        private Sunny.UI.UIComboBox cmbPriority;
        private Label lblPriority;
    }
}