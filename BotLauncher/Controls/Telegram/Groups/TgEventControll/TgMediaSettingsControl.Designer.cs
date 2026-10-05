namespace BotLauncher.Controls.Telegram.Groups
{
    partial class TgMediaSettingsControl
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
            grpTgEventMedia = new Sunny.UI.UIGroupBox();
            grpMediaSpecifics = new Sunny.UI.UIGroupBox();
            lblMediaTypes = new Label();
            chkPhoto = new Sunny.UI.UICheckBox();
            chkVideo = new Sunny.UI.UICheckBox();
            chkAudio = new Sunny.UI.UICheckBox();
            chkDocument = new Sunny.UI.UICheckBox();
            chkSticker = new Sunny.UI.UICheckBox();
            chkAnimation = new Sunny.UI.UICheckBox();
            chkVoice = new Sunny.UI.UICheckBox();
            chkVideoNote = new Sunny.UI.UICheckBox();
            nudMinFileSize = new Sunny.UI.UIIntegerUpDown();
            lblMinFileSize = new Label();
            nudMaxFileSize = new Sunny.UI.UIIntegerUpDown();
            lblMaxFileSize = new Label();
            lblFileSizeUnit = new Label();
            grpBasicFilters = new Sunny.UI.UIGroupBox();
            cmbTgUserFilter = new Sunny.UI.UIComboBox();
            lblTgUserFilter = new Label();
            nudCaptionMinLength = new Sunny.UI.UIIntegerUpDown();
            lblCaptionMinLength = new Label();
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
            chkIgnoreNoCaption = new Sunny.UI.UICheckBox();
            chkIgnoreLinks = new Sunny.UI.UICheckBox();
            chkIgnoreForwarded = new Sunny.UI.UICheckBox();
            grpLists = new Sunny.UI.UIGroupBox();
            txtWhitelist = new Sunny.UI.UITextBox();
            lblWhitelist = new Label();
            txtBlacklist = new Sunny.UI.UITextBox();
            lblBlacklist = new Label();
            grpActions = new Sunny.UI.UIGroupBox();
            chkLogEvent = new Sunny.UI.UICheckBox();
            cmbPriority = new Sunny.UI.UIComboBox();
            lblPriority = new Label();
            lblCooldownUnit = new Label();
            nudCooldown = new Sunny.UI.UIIntegerUpDown();
            lblCooldown = new Label();
            grpTgEventMedia.SuspendLayout();
            grpMediaSpecifics.SuspendLayout();
            grpBasicFilters.SuspendLayout();
            grpTimeFilter.SuspendLayout();
            grpAntiSpam.SuspendLayout();
            grpAdditionalFilters.SuspendLayout();
            grpLists.SuspendLayout();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // grpTgEventMedia
            // 
            grpTgEventMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpTgEventMedia.BackColor = Color.Transparent;
            grpTgEventMedia.Controls.Add(grpMediaSpecifics);
            grpTgEventMedia.Controls.Add(grpBasicFilters);
            grpTgEventMedia.Controls.Add(grpTimeFilter);
            grpTgEventMedia.Controls.Add(grpAntiSpam);
            grpTgEventMedia.Controls.Add(grpAdditionalFilters);
            grpTgEventMedia.Controls.Add(grpLists);
            grpTgEventMedia.Controls.Add(grpActions);
            grpTgEventMedia.FillColor = Color.Transparent;
            grpTgEventMedia.FillColor2 = Color.Transparent;
            grpTgEventMedia.FillDisableColor = Color.Transparent;
            grpTgEventMedia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpTgEventMedia.ForeColor = Color.White;
            grpTgEventMedia.ForeDisableColor = Color.Transparent;
            grpTgEventMedia.Location = new Point(5, 0);
            grpTgEventMedia.Margin = new Padding(0);
            grpTgEventMedia.MinimumSize = new Size(1, 1);
            grpTgEventMedia.Name = "grpTgEventMedia";
            grpTgEventMedia.Padding = new Padding(0, 32, 0, 0);
            grpTgEventMedia.Radius = 15;
            grpTgEventMedia.RectColor = Color.FromArgb(58, 58, 69);
            grpTgEventMedia.RectDisableColor = Color.Transparent;
            grpTgEventMedia.Size = new Size(680, 890);
            grpTgEventMedia.TabIndex = 22;
            grpTgEventMedia.Text = "Настройки события (\"Медиа\")";
            grpTgEventMedia.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // grpMediaSpecifics
            // 
            grpMediaSpecifics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpMediaSpecifics.BackColor = Color.Transparent;
            grpMediaSpecifics.Controls.Add(lblMediaTypes);
            grpMediaSpecifics.Controls.Add(chkPhoto);
            grpMediaSpecifics.Controls.Add(chkVideo);
            grpMediaSpecifics.Controls.Add(chkAudio);
            grpMediaSpecifics.Controls.Add(chkDocument);
            grpMediaSpecifics.Controls.Add(chkSticker);
            grpMediaSpecifics.Controls.Add(chkAnimation);
            grpMediaSpecifics.Controls.Add(chkVoice);
            grpMediaSpecifics.Controls.Add(chkVideoNote);
            grpMediaSpecifics.Controls.Add(nudMinFileSize);
            grpMediaSpecifics.Controls.Add(lblMinFileSize);
            grpMediaSpecifics.Controls.Add(nudMaxFileSize);
            grpMediaSpecifics.Controls.Add(lblMaxFileSize);
            grpMediaSpecifics.Controls.Add(lblFileSizeUnit);
            grpMediaSpecifics.FillColor = Color.Transparent;
            grpMediaSpecifics.FillColor2 = Color.Transparent;
            grpMediaSpecifics.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpMediaSpecifics.ForeColor = Color.White;
            grpMediaSpecifics.ForeDisableColor = Color.Transparent;
            grpMediaSpecifics.Location = new Point(0, 25);
            grpMediaSpecifics.Margin = new Padding(0);
            grpMediaSpecifics.MinimumSize = new Size(1, 1);
            grpMediaSpecifics.Name = "grpMediaSpecifics";
            grpMediaSpecifics.Padding = new Padding(0, 32, 0, 0);
            grpMediaSpecifics.Radius = 0;
            grpMediaSpecifics.RectColor = Color.FromArgb(58, 58, 69);
            grpMediaSpecifics.RectDisableColor = Color.Transparent;
            grpMediaSpecifics.Size = new Size(680, 150);
            grpMediaSpecifics.TabIndex = 30;
            grpMediaSpecifics.Text = "Параметры медиафайлов";
            grpMediaSpecifics.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblMediaTypes
            // 
            lblMediaTypes.AutoSize = true;
            lblMediaTypes.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMediaTypes.ForeColor = SystemColors.ActiveBorder;
            lblMediaTypes.Location = new Point(14, 28);
            lblMediaTypes.Name = "lblMediaTypes";
            lblMediaTypes.Size = new Size(118, 13);
            lblMediaTypes.TabIndex = 0;
            lblMediaTypes.Text = "Типы медиафайлов:";
            // 
            // chkPhoto
            // 
            chkPhoto.CheckBoxColor = Color.BlueViolet;
            chkPhoto.Checked = true;
            chkPhoto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkPhoto.ForeColor = Color.White;
            chkPhoto.Location = new Point(14, 45);
            chkPhoto.MinimumSize = new Size(1, 1);
            chkPhoto.Name = "chkPhoto";
            chkPhoto.Size = new Size(65, 25);
            chkPhoto.TabIndex = 1;
            chkPhoto.Text = "Фото";
            // 
            // chkVideo
            // 
            chkVideo.CheckBoxColor = Color.BlueViolet;
            chkVideo.Checked = true;
            chkVideo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkVideo.ForeColor = Color.White;
            chkVideo.Location = new Point(85, 45);
            chkVideo.MinimumSize = new Size(1, 1);
            chkVideo.Name = "chkVideo";
            chkVideo.Size = new Size(65, 25);
            chkVideo.TabIndex = 2;
            chkVideo.Text = "Видео";
            // 
            // chkAudio
            // 
            chkAudio.CheckBoxColor = Color.BlueViolet;
            chkAudio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkAudio.ForeColor = Color.White;
            chkAudio.Location = new Point(156, 45);
            chkAudio.MinimumSize = new Size(1, 1);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(65, 25);
            chkAudio.TabIndex = 3;
            chkAudio.Text = "Аудио";
            // 
            // chkDocument
            // 
            chkDocument.CheckBoxColor = Color.BlueViolet;
            chkDocument.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkDocument.ForeColor = Color.White;
            chkDocument.Location = new Point(227, 45);
            chkDocument.MinimumSize = new Size(1, 1);
            chkDocument.Name = "chkDocument";
            chkDocument.Size = new Size(85, 25);
            chkDocument.TabIndex = 4;
            chkDocument.Text = "Документ";
            // 
            // chkSticker
            // 
            chkSticker.CheckBoxColor = Color.BlueViolet;
            chkSticker.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkSticker.ForeColor = Color.White;
            chkSticker.Location = new Point(318, 45);
            chkSticker.MinimumSize = new Size(1, 1);
            chkSticker.Name = "chkSticker";
            chkSticker.Size = new Size(81, 25);
            chkSticker.TabIndex = 5;
            chkSticker.Text = "Стикеры";
            // 
            // chkAnimation
            // 
            chkAnimation.CheckBoxColor = Color.BlueViolet;
            chkAnimation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkAnimation.ForeColor = Color.White;
            chkAnimation.Location = new Point(405, 45);
            chkAnimation.MinimumSize = new Size(1, 1);
            chkAnimation.Name = "chkAnimation";
            chkAnimation.Size = new Size(111, 25);
            chkAnimation.TabIndex = 6;
            chkAnimation.Text = "GIF/Анимация";
            // 
            // chkVoice
            // 
            chkVoice.CheckBoxColor = Color.BlueViolet;
            chkVoice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkVoice.ForeColor = Color.White;
            chkVoice.Location = new Point(156, 72);
            chkVoice.MinimumSize = new Size(1, 1);
            chkVoice.Name = "chkVoice";
            chkVoice.Size = new Size(90, 25);
            chkVoice.TabIndex = 7;
            chkVoice.Text = "Голосовые";
            // 
            // chkVideoNote
            // 
            chkVideoNote.CheckBoxColor = Color.BlueViolet;
            chkVideoNote.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkVideoNote.ForeColor = Color.White;
            chkVideoNote.Location = new Point(14, 72);
            chkVideoNote.MinimumSize = new Size(1, 1);
            chkVideoNote.Name = "chkVideoNote";
            chkVideoNote.Size = new Size(134, 25);
            chkVideoNote.TabIndex = 8;
            chkVideoNote.Text = "Видеосообщения";
            // 
            // nudMinFileSize
            // 
            nudMinFileSize.FillColor = Color.FromArgb(42, 46, 57);
            nudMinFileSize.FillColor2 = Color.Transparent;
            nudMinFileSize.FillDisableColor = Color.Transparent;
            nudMinFileSize.FillReadOnlyColor = Color.Transparent;
            nudMinFileSize.Font = new Font("Segoe UI", 9F);
            nudMinFileSize.ForeColor = Color.White;
            nudMinFileSize.ForeDisableColor = Color.Transparent;
            nudMinFileSize.ForeReadOnlyColor = Color.Transparent;
            nudMinFileSize.Location = new Point(14, 116);
            nudMinFileSize.Margin = new Padding(4, 5, 4, 5);
            nudMinFileSize.Maximum = 2000D;
            nudMinFileSize.Minimum = 0D;
            nudMinFileSize.MinimumSize = new Size(1, 16);
            nudMinFileSize.Name = "nudMinFileSize";
            nudMinFileSize.Padding = new Padding(5);
            nudMinFileSize.RectColor = Color.FromArgb(65, 71, 84);
            nudMinFileSize.RectDisableColor = Color.Transparent;
            nudMinFileSize.RectHoverColor = Color.BlueViolet;
            nudMinFileSize.RectPressColor = Color.Indigo;
            nudMinFileSize.RectReadOnlyColor = Color.Transparent;
            nudMinFileSize.ShowText = false;
            nudMinFileSize.Size = new Size(81, 25);
            nudMinFileSize.TabIndex = 9;
            nudMinFileSize.Text = "0";
            nudMinFileSize.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblMinFileSize
            // 
            lblMinFileSize.AutoSize = true;
            lblMinFileSize.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMinFileSize.ForeColor = SystemColors.ActiveBorder;
            lblMinFileSize.Location = new Point(14, 99);
            lblMinFileSize.Name = "lblMinFileSize";
            lblMinFileSize.Size = new Size(81, 13);
            lblMinFileSize.TabIndex = 10;
            lblMinFileSize.Text = "Мин. размер:";
            // 
            // nudMaxFileSize
            // 
            nudMaxFileSize.FillColor = Color.FromArgb(42, 46, 57);
            nudMaxFileSize.FillColor2 = Color.Transparent;
            nudMaxFileSize.FillDisableColor = Color.Transparent;
            nudMaxFileSize.FillReadOnlyColor = Color.Transparent;
            nudMaxFileSize.Font = new Font("Segoe UI", 9F);
            nudMaxFileSize.ForeColor = Color.White;
            nudMaxFileSize.ForeDisableColor = Color.Transparent;
            nudMaxFileSize.ForeReadOnlyColor = Color.Transparent;
            nudMaxFileSize.Location = new Point(150, 116);
            nudMaxFileSize.Margin = new Padding(4, 5, 4, 5);
            nudMaxFileSize.Maximum = 2000D;
            nudMaxFileSize.Minimum = 0D;
            nudMaxFileSize.MinimumSize = new Size(1, 16);
            nudMaxFileSize.Name = "nudMaxFileSize";
            nudMaxFileSize.Padding = new Padding(5);
            nudMaxFileSize.RectColor = Color.FromArgb(65, 71, 84);
            nudMaxFileSize.RectDisableColor = Color.Transparent;
            nudMaxFileSize.RectHoverColor = Color.BlueViolet;
            nudMaxFileSize.RectPressColor = Color.Indigo;
            nudMaxFileSize.RectReadOnlyColor = Color.Transparent;
            nudMaxFileSize.ShowText = false;
            nudMaxFileSize.Size = new Size(84, 25);
            nudMaxFileSize.TabIndex = 11;
            nudMaxFileSize.Text = "0";
            nudMaxFileSize.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblMaxFileSize
            // 
            lblMaxFileSize.AutoSize = true;
            lblMaxFileSize.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMaxFileSize.ForeColor = SystemColors.ActiveBorder;
            lblMaxFileSize.Location = new Point(150, 99);
            lblMaxFileSize.Name = "lblMaxFileSize";
            lblMaxFileSize.Size = new Size(84, 13);
            lblMaxFileSize.TabIndex = 12;
            lblMaxFileSize.Text = "Макс. размер:";
            // 
            // lblFileSizeUnit
            // 
            lblFileSizeUnit.AutoSize = true;
            lblFileSizeUnit.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFileSizeUnit.ForeColor = SystemColors.ActiveBorder;
            lblFileSizeUnit.Location = new Point(238, 121);
            lblFileSizeUnit.Name = "lblFileSizeUnit";
            lblFileSizeUnit.Size = new Size(115, 13);
            lblFileSizeUnit.TabIndex = 13;
            lblFileSizeUnit.Text = "МБ (0 = без лимита)";
            // 
            // grpBasicFilters
            // 
            grpBasicFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBasicFilters.BackColor = Color.Transparent;
            grpBasicFilters.Controls.Add(cmbTgUserFilter);
            grpBasicFilters.Controls.Add(lblTgUserFilter);
            grpBasicFilters.Controls.Add(nudCaptionMinLength);
            grpBasicFilters.Controls.Add(lblCaptionMinLength);
            grpBasicFilters.FillColor = Color.Transparent;
            grpBasicFilters.FillColor2 = Color.Transparent;
            grpBasicFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpBasicFilters.ForeColor = Color.White;
            grpBasicFilters.ForeDisableColor = Color.Transparent;
            grpBasicFilters.Location = new Point(0, 175);
            grpBasicFilters.Margin = new Padding(0);
            grpBasicFilters.MinimumSize = new Size(1, 1);
            grpBasicFilters.Name = "grpBasicFilters";
            grpBasicFilters.Padding = new Padding(0, 32, 0, 0);
            grpBasicFilters.Radius = 0;
            grpBasicFilters.RectColor = Color.FromArgb(58, 58, 69);
            grpBasicFilters.RectDisableColor = Color.Transparent;
            grpBasicFilters.Size = new Size(680, 80);
            grpBasicFilters.TabIndex = 22;
            grpBasicFilters.Text = "Основные фильтры";
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
            // nudCaptionMinLength
            // 
            nudCaptionMinLength.FillColor = Color.FromArgb(42, 46, 57);
            nudCaptionMinLength.FillColor2 = Color.Transparent;
            nudCaptionMinLength.FillDisableColor = Color.Transparent;
            nudCaptionMinLength.FillReadOnlyColor = Color.Transparent;
            nudCaptionMinLength.Font = new Font("Segoe UI", 9F);
            nudCaptionMinLength.ForeColor = Color.White;
            nudCaptionMinLength.ForeDisableColor = Color.Transparent;
            nudCaptionMinLength.ForeReadOnlyColor = Color.Transparent;
            nudCaptionMinLength.Location = new Point(210, 45);
            nudCaptionMinLength.Margin = new Padding(4, 5, 4, 5);
            nudCaptionMinLength.Maximum = 4000D;
            nudCaptionMinLength.Minimum = 0D;
            nudCaptionMinLength.MinimumSize = new Size(1, 16);
            nudCaptionMinLength.Name = "nudCaptionMinLength";
            nudCaptionMinLength.Padding = new Padding(5);
            nudCaptionMinLength.RectColor = Color.FromArgb(65, 71, 84);
            nudCaptionMinLength.RectDisableColor = Color.Transparent;
            nudCaptionMinLength.RectHoverColor = Color.BlueViolet;
            nudCaptionMinLength.RectPressColor = Color.Indigo;
            nudCaptionMinLength.RectReadOnlyColor = Color.Transparent;
            nudCaptionMinLength.ShowText = false;
            nudCaptionMinLength.Size = new Size(100, 25);
            nudCaptionMinLength.TabIndex = 4;
            nudCaptionMinLength.Text = "0";
            nudCaptionMinLength.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionMinLength
            // 
            lblCaptionMinLength.AutoSize = true;
            lblCaptionMinLength.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCaptionMinLength.ForeColor = SystemColors.ActiveBorder;
            lblCaptionMinLength.Location = new Point(210, 28);
            lblCaptionMinLength.Name = "lblCaptionMinLength";
            lblCaptionMinLength.Size = new Size(180, 13);
            lblCaptionMinLength.TabIndex = 3;
            lblCaptionMinLength.Text = "Мин. длина описания (caption):";
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
            grpTimeFilter.Location = new Point(0, 255);
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
            grpAntiSpam.Location = new Point(0, 375);
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
            grpAdditionalFilters.Controls.Add(chkIgnoreNoCaption);
            grpAdditionalFilters.Controls.Add(chkIgnoreLinks);
            grpAdditionalFilters.Controls.Add(chkIgnoreForwarded);
            grpAdditionalFilters.FillColor = Color.Transparent;
            grpAdditionalFilters.FillColor2 = Color.Transparent;
            grpAdditionalFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpAdditionalFilters.ForeColor = Color.White;
            grpAdditionalFilters.ForeDisableColor = Color.Transparent;
            grpAdditionalFilters.Location = new Point(0, 475);
            grpAdditionalFilters.Margin = new Padding(0);
            grpAdditionalFilters.MinimumSize = new Size(1, 1);
            grpAdditionalFilters.Name = "grpAdditionalFilters";
            grpAdditionalFilters.Padding = new Padding(0, 32, 0, 0);
            grpAdditionalFilters.Radius = 0;
            grpAdditionalFilters.RectColor = Color.FromArgb(58, 58, 69);
            grpAdditionalFilters.RectDisableColor = Color.Transparent;
            grpAdditionalFilters.Size = new Size(680, 110);
            grpAdditionalFilters.TabIndex = 24;
            grpAdditionalFilters.Text = "Дополнительные фильтры";
            grpAdditionalFilters.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // chkIgnoreNoCaption
            // 
            chkIgnoreNoCaption.CheckBoxColor = Color.BlueViolet;
            chkIgnoreNoCaption.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreNoCaption.ForeColor = Color.White;
            chkIgnoreNoCaption.Location = new Point(16, 28);
            chkIgnoreNoCaption.MinimumSize = new Size(1, 1);
            chkIgnoreNoCaption.Name = "chkIgnoreNoCaption";
            chkIgnoreNoCaption.Size = new Size(450, 25);
            chkIgnoreNoCaption.TabIndex = 22;
            chkIgnoreNoCaption.Text = "Игнорировать медиафайлы без текстового описания (caption)";
            // 
            // chkIgnoreLinks
            // 
            chkIgnoreLinks.CheckBoxColor = Color.BlueViolet;
            chkIgnoreLinks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreLinks.ForeColor = Color.White;
            chkIgnoreLinks.Location = new Point(16, 55);
            chkIgnoreLinks.MinimumSize = new Size(1, 1);
            chkIgnoreLinks.Name = "chkIgnoreLinks";
            chkIgnoreLinks.Size = new Size(450, 25);
            chkIgnoreLinks.TabIndex = 23;
            chkIgnoreLinks.Text = "Игнорировать сообщения со ссылками в описании";
            // 
            // chkIgnoreForwarded
            // 
            chkIgnoreForwarded.CheckBoxColor = Color.BlueViolet;
            chkIgnoreForwarded.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkIgnoreForwarded.ForeColor = Color.White;
            chkIgnoreForwarded.Location = new Point(16, 82);
            chkIgnoreForwarded.MinimumSize = new Size(1, 1);
            chkIgnoreForwarded.Name = "chkIgnoreForwarded";
            chkIgnoreForwarded.Size = new Size(450, 25);
            chkIgnoreForwarded.TabIndex = 21;
            chkIgnoreForwarded.Text = "Игнорировать пересланные медиафайлы из других чатов";
            // 
            // grpLists
            // 
            grpLists.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpLists.BackColor = Color.Transparent;
            grpLists.Controls.Add(txtWhitelist);
            grpLists.Controls.Add(lblWhitelist);
            grpLists.Controls.Add(txtBlacklist);
            grpLists.Controls.Add(lblBlacklist);
            grpLists.FillColor = Color.Transparent;
            grpLists.FillColor2 = Color.Transparent;
            grpLists.FillDisableColor = Color.Transparent;
            grpLists.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grpLists.ForeColor = Color.White;
            grpLists.ForeDisableColor = Color.Transparent;
            grpLists.Location = new Point(0, 585);
            grpLists.Margin = new Padding(0);
            grpLists.MinimumSize = new Size(1, 1);
            grpLists.Name = "grpLists";
            grpLists.Padding = new Padding(0, 32, 0, 0);
            grpLists.Radius = 0;
            grpLists.RectColor = Color.FromArgb(58, 58, 69);
            grpLists.RectDisableColor = Color.Transparent;
            grpLists.Size = new Size(680, 180);
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
            txtWhitelist.Location = new Point(16, 121);
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
            lblWhitelist.Location = new Point(16, 104);
            lblWhitelist.Name = "lblWhitelist";
            lblWhitelist.Size = new Size(318, 13);
            lblWhitelist.TabIndex = 23;
            lblWhitelist.Text = "Белый список пользователей (@username через запятую):";
            // 
            // txtBlacklist
            // 
            txtBlacklist.FillColor = Color.FromArgb(42, 46, 57);
            txtBlacklist.FillColor2 = Color.Transparent;
            txtBlacklist.FillDisableColor = Color.Transparent;
            txtBlacklist.FillReadOnlyColor = Color.Transparent;
            txtBlacklist.Font = new Font("Segoe UI", 9F);
            txtBlacklist.ForeColor = Color.White;
            txtBlacklist.ForeDisableColor = Color.Transparent;
            txtBlacklist.ForeReadOnlyColor = Color.Transparent;
            txtBlacklist.Location = new Point(16, 45);
            txtBlacklist.Margin = new Padding(4, 5, 4, 5);
            txtBlacklist.MinimumSize = new Size(1, 16);
            txtBlacklist.Multiline = true;
            txtBlacklist.Name = "txtBlacklist";
            txtBlacklist.Padding = new Padding(5);
            txtBlacklist.RectColor = Color.FromArgb(65, 71, 84);
            txtBlacklist.RectDisableColor = Color.Transparent;
            txtBlacklist.RectReadOnlyColor = Color.Transparent;
            txtBlacklist.ShowText = false;
            txtBlacklist.Size = new Size(608, 50);
            txtBlacklist.TabIndex = 22;
            txtBlacklist.TextAlignment = ContentAlignment.TopLeft;
            txtBlacklist.Watermark = "Например: .exe, .apk, спам, реклама (расширения или слова в caption)";
            txtBlacklist.WatermarkActiveColor = Color.LightGray;
            txtBlacklist.WatermarkColor = Color.LightGray;
            // 
            // lblBlacklist
            // 
            lblBlacklist.AutoSize = true;
            lblBlacklist.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBlacklist.ForeColor = SystemColors.ActiveBorder;
            lblBlacklist.Location = new Point(16, 28);
            lblBlacklist.Name = "lblBlacklist";
            lblBlacklist.Size = new Size(335, 13);
            lblBlacklist.TabIndex = 21;
            lblBlacklist.Text = "Черный список (расширения файлов или слова в описании):";
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
            grpActions.Location = new Point(0, 765);
            grpActions.Margin = new Padding(0);
            grpActions.MinimumSize = new Size(1, 1);
            grpActions.Name = "grpActions";
            grpActions.Padding = new Padding(0, 32, 0, 0);
            grpActions.Radius = 0;
            grpActions.RectColor = Color.FromArgb(58, 58, 69);
            grpActions.RectDisableColor = Color.Transparent;
            grpActions.Size = new Size(680, 112);
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
            // TgMediaSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(grpTgEventMedia);
            DoubleBuffered = true;
            ForeColor = Color.Transparent;
            Name = "TgMediaSettingsControl";
            Size = new Size(690, 900);
            grpTgEventMedia.ResumeLayout(false);
            grpMediaSpecifics.ResumeLayout(false);
            grpMediaSpecifics.PerformLayout();
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

        private Sunny.UI.UIGroupBox grpTgEventMedia;
        private Sunny.UI.UIGroupBox grpMediaSpecifics;
        private Label lblMediaTypes;
        private Sunny.UI.UICheckBox chkPhoto;
        private Sunny.UI.UICheckBox chkVideo;
        private Sunny.UI.UICheckBox chkAudio;
        private Sunny.UI.UICheckBox chkDocument;
        private Sunny.UI.UICheckBox chkSticker;
        private Sunny.UI.UICheckBox chkAnimation;
        private Sunny.UI.UICheckBox chkVoice;
        private Sunny.UI.UICheckBox chkVideoNote;
        private Sunny.UI.UIIntegerUpDown nudMinFileSize;
        private Label lblMinFileSize;
        private Sunny.UI.UIIntegerUpDown nudMaxFileSize;
        private Label lblMaxFileSize;
        private Label lblFileSizeUnit;
        private Sunny.UI.UIGroupBox grpBasicFilters;
        private Sunny.UI.UIComboBox cmbTgUserFilter;
        private Label lblTgUserFilter;
        private Sunny.UI.UIIntegerUpDown nudCaptionMinLength;
        private Label lblCaptionMinLength;
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
        private Sunny.UI.UICheckBox chkIgnoreNoCaption;
        private Sunny.UI.UICheckBox chkIgnoreLinks;
        private Sunny.UI.UICheckBox chkIgnoreForwarded;
        private Sunny.UI.UIGroupBox grpLists;
        private Label lblBlacklist;
        private Sunny.UI.UITextBox txtBlacklist;
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