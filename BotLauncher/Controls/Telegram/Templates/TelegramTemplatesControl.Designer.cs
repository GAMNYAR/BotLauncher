namespace BotLauncher.Controls.Telegram.Templates
{
    partial class TelegramTemplatesControl
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

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelegramTemplatesControl));
            uiPanelTemplateEditor = new Sunny.UI.UIPanel();
            btnPreview = new FontAwesome.Sharp.IconButton();
            btnSaveTemplate = new FontAwesome.Sharp.IconButton();
            uiPanelAttachments = new Sunny.UI.UIPanel();
            pnlSelectedFiles = new Sunny.UI.UIPanel();
            flpSelectedFiles = new Panel();
            pnlScrollBar = new Panel();
            pnlScrollBarThumb = new Panel();
            lblDropZoneHint = new Label();
            lblSelectedFilesCount = new Label();
            btnSelectFiles = new FontAwesome.Sharp.IconButton();
            lblAttachmentsHint = new Label();
            lblAttachmentsTitle = new Label();
            uiPanelMessageEditor = new Sunny.UI.UIPanel();
            lblCharCount = new Label();
            richTextBoxTemplate = new Sunny.UI.UIRichTextBox();
            lblMessageTitle = new Label();
            uiPanelTemplatesList = new Sunny.UI.UIPanel();
            lblTemplatesTitle = new Label();
            btnImportTemplate = new FontAwesome.Sharp.IconButton();
            txtSearchTemplates = new Sunny.UI.UITextBox();
            lblTemplatesCount = new Label();
            flpTemplatesList = new FlowLayoutPanel();
            uiPanelTemplateInfo = new Sunny.UI.UIPanel();
            btnNewTemplate = new Button();
            pnlInfoContent = new Sunny.UI.UIPanel();
            lblTemplateId = new Label();
            lblTemplateIdLabel = new Label();
            lblUsageValue = new Label();
            lblUsageLabel = new Label();
            lblModifiedValue = new Label();
            lblModifiedLabel = new Label();
            txtTemplateName = new Sunny.UI.UITextBox();
            lblCreatedValue = new Label();
            lblCreatedLabel = new Label();
            lblNameLabel = new Label();
            lblInfoTitle = new Label();
            uiPanelTemplateEditor.SuspendLayout();
            uiPanelAttachments.SuspendLayout();
            pnlSelectedFiles.SuspendLayout();
            pnlScrollBar.SuspendLayout();
            uiPanelMessageEditor.SuspendLayout();
            uiPanelTemplatesList.SuspendLayout();
            uiPanelTemplateInfo.SuspendLayout();
            pnlInfoContent.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanelTemplateEditor
            // 
            uiPanelTemplateEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanelTemplateEditor.BackColor = Color.Transparent;
            uiPanelTemplateEditor.Controls.Add(btnPreview);
            uiPanelTemplateEditor.Controls.Add(btnSaveTemplate);
            uiPanelTemplateEditor.Controls.Add(uiPanelAttachments);
            uiPanelTemplateEditor.Controls.Add(lblAttachmentsHint);
            uiPanelTemplateEditor.Controls.Add(lblAttachmentsTitle);
            uiPanelTemplateEditor.Controls.Add(uiPanelMessageEditor);
            uiPanelTemplateEditor.Controls.Add(lblMessageTitle);
            uiPanelTemplateEditor.FillColor = Color.FromArgb(35, 39, 48);
            uiPanelTemplateEditor.FillColor2 = Color.Transparent;
            uiPanelTemplateEditor.FillDisableColor = Color.Transparent;
            uiPanelTemplateEditor.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanelTemplateEditor.ForeColor = Color.Transparent;
            uiPanelTemplateEditor.ForeDisableColor = Color.Transparent;
            uiPanelTemplateEditor.Location = new Point(258, 129);
            uiPanelTemplateEditor.Margin = new Padding(0, 5, 0, 0);
            uiPanelTemplateEditor.MinimumSize = new Size(1, 1);
            uiPanelTemplateEditor.Name = "uiPanelTemplateEditor";
            uiPanelTemplateEditor.Radius = 16;
            uiPanelTemplateEditor.RectColor = Color.FromArgb(47, 51, 61);
            uiPanelTemplateEditor.RectDisableColor = Color.Empty;
            uiPanelTemplateEditor.Size = new Size(713, 545);
            uiPanelTemplateEditor.TabIndex = 36;
            uiPanelTemplateEditor.Text = null;
            uiPanelTemplateEditor.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnPreview
            // 
            btnPreview.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPreview.BackColor = Color.Transparent;
            btnPreview.FlatAppearance.BorderColor = Color.DimGray;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPreview.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnPreview.IconColor = Color.White;
            btnPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPreview.IconSize = 18;
            btnPreview.Location = new Point(412, 498);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(130, 35);
            btnPreview.TabIndex = 5;
            btnPreview.Text = "Предпросмотр";
            btnPreview.TextAlign = ContentAlignment.MiddleRight;
            btnPreview.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPreview.UseVisualStyleBackColor = false;
            // 
            // btnSaveTemplate
            // 
            btnSaveTemplate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveTemplate.BackColor = Color.FromArgb(124, 58, 237);
            btnSaveTemplate.FlatAppearance.BorderSize = 0;
            btnSaveTemplate.FlatStyle = FlatStyle.Flat;
            btnSaveTemplate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveTemplate.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSaveTemplate.IconColor = Color.White;
            btnSaveTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveTemplate.IconSize = 18;
            btnSaveTemplate.Location = new Point(548, 498);
            btnSaveTemplate.Name = "btnSaveTemplate";
            btnSaveTemplate.Size = new Size(148, 35);
            btnSaveTemplate.TabIndex = 3;
            btnSaveTemplate.Text = "Сохранить шаблон";
            btnSaveTemplate.TextAlign = ContentAlignment.MiddleRight;
            btnSaveTemplate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveTemplate.UseVisualStyleBackColor = false;
            // 
            // uiPanelAttachments
            // 
            uiPanelAttachments.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanelAttachments.Controls.Add(pnlSelectedFiles);
            uiPanelAttachments.Controls.Add(lblDropZoneHint);
            uiPanelAttachments.Controls.Add(lblSelectedFilesCount);
            uiPanelAttachments.Controls.Add(btnSelectFiles);
            uiPanelAttachments.FillColor = Color.FromArgb(35, 39, 48);
            uiPanelAttachments.FillColor2 = Color.Transparent;
            uiPanelAttachments.FillDisableColor = Color.Transparent;
            uiPanelAttachments.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            uiPanelAttachments.ForeColor = Color.Transparent;
            uiPanelAttachments.ForeDisableColor = Color.Transparent;
            uiPanelAttachments.Location = new Point(10, 360);
            uiPanelAttachments.Margin = new Padding(4, 5, 4, 5);
            uiPanelAttachments.MinimumSize = new Size(1, 1);
            uiPanelAttachments.Name = "uiPanelAttachments";
            uiPanelAttachments.Radius = 12;
            uiPanelAttachments.RectColor = Color.FromArgb(47, 51, 61);
            uiPanelAttachments.RectDisableColor = Color.Transparent;
            uiPanelAttachments.Size = new Size(693, 130);
            uiPanelAttachments.TabIndex = 4;
            uiPanelAttachments.Text = null;
            uiPanelAttachments.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlSelectedFiles
            // 
            pnlSelectedFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSelectedFiles.Controls.Add(flpSelectedFiles);
            pnlSelectedFiles.Controls.Add(pnlScrollBar);
            pnlSelectedFiles.FillColor = Color.Transparent;
            pnlSelectedFiles.FillColor2 = Color.Transparent;
            pnlSelectedFiles.FillDisableColor = Color.Transparent;
            pnlSelectedFiles.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlSelectedFiles.ForeColor = Color.Transparent;
            pnlSelectedFiles.ForeDisableColor = Color.Transparent;
            pnlSelectedFiles.Location = new Point(184, 0);
            pnlSelectedFiles.Margin = new Padding(4, 5, 4, 5);
            pnlSelectedFiles.MinimumSize = new Size(1, 1);
            pnlSelectedFiles.Name = "pnlSelectedFiles";
            pnlSelectedFiles.Padding = new Padding(5);
            pnlSelectedFiles.Radius = 12;
            pnlSelectedFiles.RadiusSides = Sunny.UI.UICornerRadiusSides.RightTop | Sunny.UI.UICornerRadiusSides.RightBottom;
            pnlSelectedFiles.RectColor = Color.FromArgb(47, 51, 61);
            pnlSelectedFiles.RectDisableColor = Color.Transparent;
            pnlSelectedFiles.Size = new Size(509, 130);
            pnlSelectedFiles.TabIndex = 5;
            pnlSelectedFiles.Text = null;
            pnlSelectedFiles.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flpSelectedFiles
            // 
            flpSelectedFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpSelectedFiles.BackColor = Color.Transparent;
            flpSelectedFiles.Location = new Point(5, 5);
            flpSelectedFiles.Name = "flpSelectedFiles";
            flpSelectedFiles.Size = new Size(499, 115);
            flpSelectedFiles.TabIndex = 0;
            // 
            // pnlScrollBar
            // 
            pnlScrollBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlScrollBar.BackColor = Color.FromArgb(31, 34, 42);
            pnlScrollBar.Controls.Add(pnlScrollBarThumb);
            pnlScrollBar.Location = new Point(0, 124);
            pnlScrollBar.Name = "pnlScrollBar";
            pnlScrollBar.Size = new Size(509, 6);
            pnlScrollBar.TabIndex = 6;
            pnlScrollBar.Visible = false;
            // 
            // pnlScrollBarThumb
            // 
            pnlScrollBarThumb.BackColor = Color.FromArgb(124, 58, 237);
            pnlScrollBarThumb.Cursor = Cursors.Hand;
            pnlScrollBarThumb.Location = new Point(0, 0);
            pnlScrollBarThumb.Name = "pnlScrollBarThumb";
            pnlScrollBarThumb.Size = new Size(100, 6);
            pnlScrollBarThumb.TabIndex = 0;
            // 
            // lblDropZoneHint
            // 
            lblDropZoneHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDropZoneHint.Font = new Font("Segoe UI", 9F);
            lblDropZoneHint.ForeColor = Color.DarkGray;
            lblDropZoneHint.Location = new Point(18, 22);
            lblDropZoneHint.Name = "lblDropZoneHint";
            lblDropZoneHint.Size = new Size(150, 33);
            lblDropZoneHint.TabIndex = 3;
            lblDropZoneHint.Text = "Нажми на кнопку ниже, чтобы добавить файлы";
            lblDropZoneHint.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSelectedFilesCount
            // 
            lblSelectedFilesCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSelectedFilesCount.Font = new Font("Segoe UI", 8F);
            lblSelectedFilesCount.ForeColor = Color.FromArgb(156, 163, 175);
            lblSelectedFilesCount.Location = new Point(18, 94);
            lblSelectedFilesCount.Name = "lblSelectedFilesCount";
            lblSelectedFilesCount.Size = new Size(150, 15);
            lblSelectedFilesCount.TabIndex = 2;
            lblSelectedFilesCount.Text = "Выбрано файлов: 0";
            lblSelectedFilesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSelectFiles.BackColor = Color.FromArgb(124, 58, 237);
            btnSelectFiles.FlatAppearance.BorderSize = 0;
            btnSelectFiles.FlatStyle = FlatStyle.Flat;
            btnSelectFiles.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSelectFiles.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnSelectFiles.IconColor = Color.White;
            btnSelectFiles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelectFiles.IconSize = 16;
            btnSelectFiles.Location = new Point(18, 58);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(150, 30);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Выбрать файлы";
            btnSelectFiles.TextAlign = ContentAlignment.MiddleRight;
            btnSelectFiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelectFiles.UseVisualStyleBackColor = false;
            // 
            // lblAttachmentsHint
            // 
            lblAttachmentsHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAttachmentsHint.Font = new Font("Segoe UI", 8F);
            lblAttachmentsHint.ForeColor = Color.FromArgb(156, 163, 175);
            lblAttachmentsHint.Location = new Point(10, 340);
            lblAttachmentsHint.Name = "lblAttachmentsHint";
            lblAttachmentsHint.Size = new Size(250, 13);
            lblAttachmentsHint.TabIndex = 3;
            lblAttachmentsHint.Text = "Файлы загружаются в отдельном окне";
            // 
            // lblAttachmentsTitle
            // 
            lblAttachmentsTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblAttachmentsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAttachmentsTitle.ForeColor = Color.White;
            lblAttachmentsTitle.Location = new Point(10, 320);
            lblAttachmentsTitle.Name = "lblAttachmentsTitle";
            lblAttachmentsTitle.Size = new Size(100, 17);
            lblAttachmentsTitle.TabIndex = 2;
            lblAttachmentsTitle.Text = "Вложения";
            // 
            // uiPanelMessageEditor
            // 
            uiPanelMessageEditor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanelMessageEditor.Controls.Add(lblCharCount);
            uiPanelMessageEditor.Controls.Add(richTextBoxTemplate);
            uiPanelMessageEditor.FillColor = Color.FromArgb(35, 39, 48);
            uiPanelMessageEditor.FillColor2 = Color.Transparent;
            uiPanelMessageEditor.FillDisableColor = Color.Transparent;
            uiPanelMessageEditor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            uiPanelMessageEditor.ForeColor = Color.Transparent;
            uiPanelMessageEditor.ForeDisableColor = Color.Transparent;
            uiPanelMessageEditor.Location = new Point(10, 32);
            uiPanelMessageEditor.Margin = new Padding(4, 5, 4, 5);
            uiPanelMessageEditor.MinimumSize = new Size(1, 1);
            uiPanelMessageEditor.Name = "uiPanelMessageEditor";
            uiPanelMessageEditor.Radius = 12;
            uiPanelMessageEditor.RectColor = Color.FromArgb(47, 51, 61);
            uiPanelMessageEditor.RectDisableColor = Color.Transparent;
            uiPanelMessageEditor.Size = new Size(693, 283);
            uiPanelMessageEditor.TabIndex = 1;
            uiPanelMessageEditor.Text = null;
            uiPanelMessageEditor.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCharCount
            // 
            lblCharCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCharCount.AutoEllipsis = true;
            lblCharCount.Font = new Font("Segoe UI", 8F);
            lblCharCount.ForeColor = Color.FromArgb(156, 163, 175);
            lblCharCount.Location = new Point(558, 262);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(124, 15);
            lblCharCount.TabIndex = 2;
            lblCharCount.Text = "Осталось: 4096";
            lblCharCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // richTextBoxTemplate
            // 
            richTextBoxTemplate.AcceptsTab = true;
            richTextBoxTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxTemplate.AutoWordSelection = false;
            richTextBoxTemplate.BackColor = Color.Transparent;
            richTextBoxTemplate.DetectUrls = false;
            richTextBoxTemplate.FillColor = Color.FromArgb(31, 34, 42);
            richTextBoxTemplate.FillColor2 = Color.Transparent;
            richTextBoxTemplate.FillDisableColor = Color.Transparent;
            richTextBoxTemplate.Font = new Font("Segoe UI", 9F);
            richTextBoxTemplate.ForeColor = Color.White;
            richTextBoxTemplate.ForeDisableColor = Color.Transparent;
            richTextBoxTemplate.HideSelection = false;
            richTextBoxTemplate.Location = new Point(0, 0);
            richTextBoxTemplate.Margin = new Padding(4, 5, 4, 5);
            richTextBoxTemplate.MaxLength = 0;
            richTextBoxTemplate.MinimumSize = new Size(1, 1);
            richTextBoxTemplate.Name = "richTextBoxTemplate";
            richTextBoxTemplate.Padding = new Padding(8);
            richTextBoxTemplate.Radius = 8;
            richTextBoxTemplate.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop;
            richTextBoxTemplate.RectColor = Color.FromArgb(47, 51, 61);
            richTextBoxTemplate.RectDisableColor = Color.Transparent;
            richTextBoxTemplate.ScrollBarBackColor = Color.FromArgb(35, 39, 48);
            richTextBoxTemplate.ScrollBarColor = Color.FromArgb(124, 58, 237);
            richTextBoxTemplate.ScrollBarHandleWidth = 8;
            richTextBoxTemplate.ScrollBarStyleInherited = false;
            richTextBoxTemplate.ShowText = false;
            richTextBoxTemplate.Size = new Size(693, 258);
            richTextBoxTemplate.Style = Sunny.UI.UIStyle.Custom;
            richTextBoxTemplate.TabIndex = 1;
            richTextBoxTemplate.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblMessageTitle
            // 
            lblMessageTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblMessageTitle.ForeColor = Color.White;
            lblMessageTitle.Location = new Point(9, 10);
            lblMessageTitle.Name = "lblMessageTitle";
            lblMessageTitle.Size = new Size(150, 17);
            lblMessageTitle.TabIndex = 0;
            lblMessageTitle.Text = "Текст сообщения";
            // 
            // uiPanelTemplatesList
            // 
            uiPanelTemplatesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiPanelTemplatesList.BackColor = Color.Transparent;
            uiPanelTemplatesList.Controls.Add(lblTemplatesTitle);
            uiPanelTemplatesList.Controls.Add(btnImportTemplate);
            uiPanelTemplatesList.Controls.Add(txtSearchTemplates);
            uiPanelTemplatesList.Controls.Add(lblTemplatesCount);
            uiPanelTemplatesList.Controls.Add(flpTemplatesList);
            uiPanelTemplatesList.FillColor = Color.FromArgb(35, 39, 48);
            uiPanelTemplatesList.FillColor2 = Color.Transparent;
            uiPanelTemplatesList.FillDisableColor = Color.Transparent;
            uiPanelTemplatesList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            uiPanelTemplatesList.ForeColor = Color.Transparent;
            uiPanelTemplatesList.ForeDisableColor = Color.Transparent;
            uiPanelTemplatesList.Location = new Point(5, 5);
            uiPanelTemplatesList.Margin = new Padding(0, 0, 5, 0);
            uiPanelTemplatesList.MinimumSize = new Size(1, 1);
            uiPanelTemplatesList.Name = "uiPanelTemplatesList";
            uiPanelTemplatesList.Radius = 16;
            uiPanelTemplatesList.RectColor = Color.FromArgb(47, 51, 61);
            uiPanelTemplatesList.RectDisableColor = Color.Transparent;
            uiPanelTemplatesList.Size = new Size(250, 669);
            uiPanelTemplatesList.TabIndex = 38;
            uiPanelTemplatesList.Text = null;
            uiPanelTemplatesList.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTemplatesTitle
            // 
            lblTemplatesTitle.BackColor = Color.FromArgb(35, 39, 48);
            lblTemplatesTitle.FlatStyle = FlatStyle.Flat;
            lblTemplatesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTemplatesTitle.ForeColor = Color.White;
            lblTemplatesTitle.Location = new Point(5, 8);
            lblTemplatesTitle.Name = "lblTemplatesTitle";
            lblTemplatesTitle.Size = new Size(230, 19);
            lblTemplatesTitle.TabIndex = 31;
            lblTemplatesTitle.Text = "Список шаблонов";
            // 
            // btnImportTemplate
            // 
            btnImportTemplate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnImportTemplate.BackColor = Color.FromArgb(35, 39, 48);
            btnImportTemplate.FlatAppearance.BorderColor = Color.FromArgb(47, 51, 61);
            btnImportTemplate.FlatAppearance.MouseDownBackColor = Color.MediumPurple;
            btnImportTemplate.FlatAppearance.MouseOverBackColor = Color.Indigo;
            btnImportTemplate.FlatStyle = FlatStyle.Flat;
            btnImportTemplate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnImportTemplate.ForeColor = Color.White;
            btnImportTemplate.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            btnImportTemplate.IconColor = Color.White;
            btnImportTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImportTemplate.IconSize = 20;
            btnImportTemplate.ImeMode = ImeMode.NoControl;
            btnImportTemplate.Location = new Point(8, 30);
            btnImportTemplate.Name = "btnImportTemplate";
            btnImportTemplate.Padding = new Padding(5, 0, 0, 0);
            btnImportTemplate.Size = new Size(234, 30);
            btnImportTemplate.TabIndex = 36;
            btnImportTemplate.Text = "Импорт шаблонов";
            btnImportTemplate.TextAlign = ContentAlignment.MiddleRight;
            btnImportTemplate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImportTemplate.UseVisualStyleBackColor = false;
            // 
            // txtSearchTemplates
            // 
            txtSearchTemplates.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchTemplates.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchTemplates.ButtonFillColor = Color.FromArgb(42, 46, 57);
            txtSearchTemplates.ButtonFillHoverColor = Color.FromArgb(42, 46, 57);
            txtSearchTemplates.ButtonFillPressColor = Color.FromArgb(42, 46, 57);
            txtSearchTemplates.ButtonForeHoverColor = Color.Silver;
            txtSearchTemplates.ButtonForePressColor = Color.DimGray;
            txtSearchTemplates.ButtonRectColor = Color.Transparent;
            txtSearchTemplates.ButtonRectHoverColor = Color.Transparent;
            txtSearchTemplates.ButtonRectPressColor = Color.Transparent;
            txtSearchTemplates.ButtonStyleInherited = false;
            txtSearchTemplates.ButtonSymbol = 61442;
            txtSearchTemplates.ButtonSymbolOffset = new Point(0, 0);
            txtSearchTemplates.ButtonSymbolSize = 20;
            txtSearchTemplates.ButtonWidth = 25;
            txtSearchTemplates.FillColor = Color.FromArgb(42, 46, 57);
            txtSearchTemplates.FillColor2 = Color.Transparent;
            txtSearchTemplates.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtSearchTemplates.ForeColor = Color.White;
            txtSearchTemplates.IconSize = 20;
            txtSearchTemplates.Location = new Point(8, 68);
            txtSearchTemplates.Margin = new Padding(4, 5, 4, 5);
            txtSearchTemplates.MinimumSize = new Size(1, 16);
            txtSearchTemplates.Name = "txtSearchTemplates";
            txtSearchTemplates.Padding = new Padding(5);
            txtSearchTemplates.RectColor = Color.FromArgb(58, 63, 75);
            txtSearchTemplates.RectDisableColor = Color.FromArgb(58, 63, 75);
            txtSearchTemplates.RectReadOnlyColor = Color.FromArgb(58, 63, 75);
            txtSearchTemplates.ScrollBarBackColor = Color.Transparent;
            txtSearchTemplates.ScrollBarColor = Color.Transparent;
            txtSearchTemplates.ScrollBarStyleInherited = false;
            txtSearchTemplates.ShowButton = true;
            txtSearchTemplates.ShowText = false;
            txtSearchTemplates.Size = new Size(234, 30);
            txtSearchTemplates.SymbolColor = Color.White;
            txtSearchTemplates.TabIndex = 38;
            txtSearchTemplates.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearchTemplates.Watermark = "Поиск по шаблонам...";
            txtSearchTemplates.WatermarkColor = Color.LightGray;
            // 
            // lblTemplatesCount
            // 
            lblTemplatesCount.AutoSize = true;
            lblTemplatesCount.BackColor = Color.Transparent;
            lblTemplatesCount.Font = new Font("Segoe UI", 8F);
            lblTemplatesCount.ForeColor = Color.FromArgb(156, 163, 175);
            lblTemplatesCount.ImeMode = ImeMode.NoControl;
            lblTemplatesCount.Location = new Point(5, 105);
            lblTemplatesCount.Name = "lblTemplatesCount";
            lblTemplatesCount.Size = new Size(107, 13);
            lblTemplatesCount.TabIndex = 37;
            lblTemplatesCount.Text = "Всего шаблонов: 0";
            // 
            // flpTemplatesList
            // 
            flpTemplatesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpTemplatesList.AutoScroll = true;
            flpTemplatesList.BackColor = Color.Transparent;
            flpTemplatesList.FlowDirection = FlowDirection.TopDown;
            flpTemplatesList.Location = new Point(0, 121);
            flpTemplatesList.Name = "flpTemplatesList";
            flpTemplatesList.Padding = new Padding(5, 10, 5, 10);
            flpTemplatesList.Size = new Size(250, 548);
            flpTemplatesList.TabIndex = 35;
            flpTemplatesList.WrapContents = false;
            // 
            // uiPanelTemplateInfo
            // 
            uiPanelTemplateInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanelTemplateInfo.BackColor = Color.Transparent;
            uiPanelTemplateInfo.Controls.Add(btnNewTemplate);
            uiPanelTemplateInfo.Controls.Add(pnlInfoContent);
            uiPanelTemplateInfo.Controls.Add(lblInfoTitle);
            uiPanelTemplateInfo.FillColor = Color.FromArgb(35, 39, 48);
            uiPanelTemplateInfo.FillColor2 = Color.Transparent;
            uiPanelTemplateInfo.FillDisableColor = Color.Transparent;
            uiPanelTemplateInfo.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanelTemplateInfo.ForeColor = Color.Transparent;
            uiPanelTemplateInfo.ForeDisableColor = Color.Transparent;
            uiPanelTemplateInfo.Location = new Point(258, 5);
            uiPanelTemplateInfo.Margin = new Padding(0, 0, 0, 5);
            uiPanelTemplateInfo.MinimumSize = new Size(1, 1);
            uiPanelTemplateInfo.Name = "uiPanelTemplateInfo";
            uiPanelTemplateInfo.Padding = new Padding(10);
            uiPanelTemplateInfo.Radius = 20;
            uiPanelTemplateInfo.RectColor = Color.FromArgb(42, 47, 58);
            uiPanelTemplateInfo.RectDisableColor = Color.Empty;
            uiPanelTemplateInfo.Size = new Size(713, 120);
            uiPanelTemplateInfo.TabIndex = 39;
            uiPanelTemplateInfo.Text = null;
            uiPanelTemplateInfo.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnNewTemplate
            // 
            btnNewTemplate.BackgroundImage = (Image)resources.GetObject("btnNewTemplate.BackgroundImage");
            btnNewTemplate.BackgroundImageLayout = ImageLayout.Stretch;
            btnNewTemplate.FlatAppearance.BorderSize = 0;
            btnNewTemplate.FlatStyle = FlatStyle.Flat;
            btnNewTemplate.Location = new Point(672, 8);
            btnNewTemplate.Name = "btnNewTemplate";
            btnNewTemplate.Size = new Size(25, 25);
            btnNewTemplate.TabIndex = 23;
            btnNewTemplate.UseVisualStyleBackColor = true;
            // 
            // pnlInfoContent
            // 
            pnlInfoContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInfoContent.Controls.Add(lblTemplateId);
            pnlInfoContent.Controls.Add(lblTemplateIdLabel);
            pnlInfoContent.Controls.Add(lblUsageValue);
            pnlInfoContent.Controls.Add(lblUsageLabel);
            pnlInfoContent.Controls.Add(lblModifiedValue);
            pnlInfoContent.Controls.Add(lblModifiedLabel);
            pnlInfoContent.Controls.Add(txtTemplateName);
            pnlInfoContent.Controls.Add(lblCreatedValue);
            pnlInfoContent.Controls.Add(lblCreatedLabel);
            pnlInfoContent.Controls.Add(lblNameLabel);
            pnlInfoContent.FillColor = Color.FromArgb(35, 39, 48);
            pnlInfoContent.FillColor2 = Color.Transparent;
            pnlInfoContent.FillDisableColor = Color.Transparent;
            pnlInfoContent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            pnlInfoContent.ForeColor = Color.Transparent;
            pnlInfoContent.ForeDisableColor = Color.Transparent;
            pnlInfoContent.Location = new Point(8, 35);
            pnlInfoContent.Margin = new Padding(4, 5, 4, 5);
            pnlInfoContent.MinimumSize = new Size(1, 1);
            pnlInfoContent.Name = "pnlInfoContent";
            pnlInfoContent.Radius = 12;
            pnlInfoContent.RectColor = Color.FromArgb(47, 51, 61);
            pnlInfoContent.RectDisableColor = Color.Transparent;
            pnlInfoContent.Size = new Size(696, 80);
            pnlInfoContent.TabIndex = 22;
            pnlInfoContent.Text = null;
            pnlInfoContent.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTemplateId
            // 
            lblTemplateId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTemplateId.AutoEllipsis = true;
            lblTemplateId.Font = new Font("Segoe UI", 9F);
            lblTemplateId.ForeColor = Color.Gainsboro;
            lblTemplateId.Location = new Point(590, 7);
            lblTemplateId.Name = "lblTemplateId";
            lblTemplateId.Size = new Size(100, 20);
            lblTemplateId.TabIndex = 10;
            lblTemplateId.Text = "—";
            lblTemplateId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTemplateIdLabel
            // 
            lblTemplateIdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTemplateIdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTemplateIdLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblTemplateIdLabel.Location = new Point(566, 7);
            lblTemplateIdLabel.Name = "lblTemplateIdLabel";
            lblTemplateIdLabel.Size = new Size(23, 20);
            lblTemplateIdLabel.TabIndex = 9;
            lblTemplateIdLabel.Text = "ID:";
            lblTemplateIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsageValue
            // 
            lblUsageValue.Font = new Font("Segoe UI", 9F);
            lblUsageValue.ForeColor = Color.Gainsboro;
            lblUsageValue.Location = new Point(86, 61);
            lblUsageValue.Name = "lblUsageValue";
            lblUsageValue.Size = new Size(150, 13);
            lblUsageValue.TabIndex = 8;
            lblUsageValue.Text = "—";
            // 
            // lblUsageLabel
            // 
            lblUsageLabel.Font = new Font("Segoe UI", 8F);
            lblUsageLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblUsageLabel.Location = new Point(8, 61);
            lblUsageLabel.Name = "lblUsageLabel";
            lblUsageLabel.Size = new Size(81, 13);
            lblUsageLabel.TabIndex = 7;
            lblUsageLabel.Text = "Используется:";
            // 
            // lblModifiedValue
            // 
            lblModifiedValue.Font = new Font("Segoe UI", 9F);
            lblModifiedValue.ForeColor = Color.Gainsboro;
            lblModifiedValue.Location = new Point(63, 45);
            lblModifiedValue.Name = "lblModifiedValue";
            lblModifiedValue.Size = new Size(173, 13);
            lblModifiedValue.TabIndex = 6;
            lblModifiedValue.Text = "—";
            // 
            // lblModifiedLabel
            // 
            lblModifiedLabel.Font = new Font("Segoe UI", 8F);
            lblModifiedLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblModifiedLabel.Location = new Point(8, 45);
            lblModifiedLabel.Name = "lblModifiedLabel";
            lblModifiedLabel.Size = new Size(70, 13);
            lblModifiedLabel.TabIndex = 5;
            lblModifiedLabel.Text = "Изменён:";
            // 
            // txtTemplateName
            // 
            txtTemplateName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTemplateName.ButtonFillColor = Color.Transparent;
            txtTemplateName.ButtonFillHoverColor = Color.Transparent;
            txtTemplateName.ButtonFillPressColor = Color.Transparent;
            txtTemplateName.ButtonForeColor = Color.Transparent;
            txtTemplateName.ButtonForeHoverColor = Color.Transparent;
            txtTemplateName.ButtonForePressColor = Color.Transparent;
            txtTemplateName.ButtonRectColor = Color.Transparent;
            txtTemplateName.ButtonRectHoverColor = Color.Transparent;
            txtTemplateName.ButtonRectPressColor = Color.Transparent;
            txtTemplateName.ButtonStyleInherited = false;
            txtTemplateName.FillColor = Color.FromArgb(42, 46, 57);
            txtTemplateName.FillColor2 = Color.Transparent;
            txtTemplateName.FillDisableColor = Color.Transparent;
            txtTemplateName.FillReadOnlyColor = Color.Transparent;
            txtTemplateName.Font = new Font("Segoe UI", 9F);
            txtTemplateName.ForeColor = Color.White;
            txtTemplateName.ForeDisableColor = Color.Transparent;
            txtTemplateName.ForeReadOnlyColor = Color.Transparent;
            txtTemplateName.Location = new Point(77, 7);
            txtTemplateName.Margin = new Padding(4, 5, 4, 5);
            txtTemplateName.MinimumSize = new Size(1, 16);
            txtTemplateName.Name = "txtTemplateName";
            txtTemplateName.Padding = new Padding(5);
            txtTemplateName.RectColor = Color.FromArgb(47, 51, 61);
            txtTemplateName.RectDisableColor = Color.Transparent;
            txtTemplateName.RectReadOnlyColor = Color.Transparent;
            txtTemplateName.ScrollBarBackColor = Color.Transparent;
            txtTemplateName.ScrollBarColor = Color.Transparent;
            txtTemplateName.ScrollBarStyleInherited = false;
            txtTemplateName.ShowText = false;
            txtTemplateName.Size = new Size(482, 20);
            txtTemplateName.Style = Sunny.UI.UIStyle.Custom;
            txtTemplateName.SymbolColor = Color.Transparent;
            txtTemplateName.TabIndex = 4;
            txtTemplateName.TextAlignment = ContentAlignment.MiddleLeft;
            txtTemplateName.Watermark = "Введите название шаблону...";
            // 
            // lblCreatedValue
            // 
            lblCreatedValue.Font = new Font("Segoe UI", 9F);
            lblCreatedValue.ForeColor = Color.Gainsboro;
            lblCreatedValue.Location = new Point(52, 29);
            lblCreatedValue.Name = "lblCreatedValue";
            lblCreatedValue.Size = new Size(184, 13);
            lblCreatedValue.TabIndex = 3;
            lblCreatedValue.Text = "—";
            // 
            // lblCreatedLabel
            // 
            lblCreatedLabel.Font = new Font("Microsoft Sans Serif", 8F);
            lblCreatedLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblCreatedLabel.Location = new Point(8, 29);
            lblCreatedLabel.Name = "lblCreatedLabel";
            lblCreatedLabel.Size = new Size(70, 13);
            lblCreatedLabel.TabIndex = 2;
            lblCreatedLabel.Text = "Создан:";
            // 
            // lblNameLabel
            // 
            lblNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNameLabel.ForeColor = Color.FromArgb(156, 163, 175);
            lblNameLabel.Location = new Point(8, 7);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(70, 20);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Название:";
            lblNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoEllipsis = true;
            lblInfoTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblInfoTitle.ForeColor = Color.White;
            lblInfoTitle.ImeMode = ImeMode.NoControl;
            lblInfoTitle.Location = new Point(10, 9);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(200, 19);
            lblInfoTitle.TabIndex = 21;
            lblInfoTitle.Text = "Информация о шаблоне";
            lblInfoTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TelegramTemplatesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(27, 29, 36);
            Controls.Add(uiPanelTemplatesList);
            Controls.Add(uiPanelTemplateInfo);
            Controls.Add(uiPanelTemplateEditor);
            Margin = new Padding(0);
            Name = "TelegramTemplatesControl";
            Padding = new Padding(5);
            Size = new Size(976, 679);
            uiPanelTemplateEditor.ResumeLayout(false);
            uiPanelAttachments.ResumeLayout(false);
            pnlSelectedFiles.ResumeLayout(false);
            pnlScrollBar.ResumeLayout(false);
            uiPanelMessageEditor.ResumeLayout(false);
            uiPanelTemplatesList.ResumeLayout(false);
            uiPanelTemplatesList.PerformLayout();
            uiPanelTemplateInfo.ResumeLayout(false);
            pnlInfoContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanelTemplateEditor;
        private Sunny.UI.UIPanel uiPanelTemplatesList;
        private Label lblTemplatesTitle;
        private Sunny.UI.UITextBox txtSearchTemplates;
        private Label lblTemplatesCount;
        private FlowLayoutPanel flpTemplatesList;
        private FontAwesome.Sharp.IconButton btnImportTemplate;
        private Sunny.UI.UIPanel uiPanelTemplateInfo;
        private Label lblInfoTitle;
        private Sunny.UI.UIPanel pnlInfoContent;
        private Label lblCreatedValue;
        private Label lblCreatedLabel;
        private Label lblNameLabel;
        private Sunny.UI.UITextBox txtTemplateName;
        private Label lblUsageLabel;
        private Label lblModifiedValue;
        private Label lblModifiedLabel;
        private Label lblUsageValue;
        private Label lblMessageTitle;
        private Sunny.UI.UIPanel uiPanelMessageEditor;
        private Sunny.UI.UIRichTextBox richTextBoxTemplate;
        private Label lblCharCount;
        private Label lblAttachmentsTitle;
        private Sunny.UI.UIPanel uiPanelAttachments;
        private FontAwesome.Sharp.IconButton btnSelectFiles;
        private Label lblAttachmentsHint;
        private Label lblSelectedFilesCount;
        private FontAwesome.Sharp.IconButton btnSaveTemplate;
        private Label lblDropZoneHint;
        private Label lblTemplateId;
        private Label lblTemplateIdLabel;
        private FontAwesome.Sharp.IconButton btnPreview;
        private Panel flpSelectedFiles; // ИЗМЕНЕНО: был FlowLayoutPanel
        private Sunny.UI.UIPanel pnlSelectedFiles;
        private Panel pnlScrollBar;
        private Panel pnlScrollBarThumb;
        private Button btnNewTemplate;
    }
}