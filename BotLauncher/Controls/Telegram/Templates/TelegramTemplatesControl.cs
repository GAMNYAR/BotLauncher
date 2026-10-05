using BotLauncher.Controls.Base;
using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using BotLauncher.Shared.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Templates;

public partial class TelegramTemplatesControl : BaseControl
{
    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
    private const int SB_BOTH = 3;

    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

    [StructLayout(LayoutKind.Sequential)]
    private struct SHFILEINFO
    {
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    }

    private const uint SHGFI_ICON = 0x100;
    private const uint SHGFI_LARGEICON = 0x0;

    private const int CardWidth = 120;
    private const int CardHeight = 120;
    private const int PreviewHeight = 75;
    private const int ItemMargin = 10;

    private readonly TelegramTemplatesService _templatesService;
    private TelegramTemplate? _currentTemplate;
    private readonly List<string> _currentAttachments = new();
    private TemplateCardControl? _selectedCard;

    private int _scrollPosition = 0;
    private bool _isDragging = false;
    private int _dragStartX = 0;
    private int _startThumbPos = 0;

    public TelegramTemplatesControl()
    {
        InitializeComponent();
        _templatesService = new TelegramTemplatesService();

        if (DesignMode) return;

        btnImportTemplate.Click += BtnImportTemplate_Click;
        btnSaveTemplate.Click += BtnSaveTemplate_Click;
        btnPreview.Click += BtnPreview_Click;
        btnSelectFiles.Click += BtnSelectFiles_Click;
        richTextBoxTemplate.TextChanged += RichTextBoxTemplate_TextChanged;
        btnNewTemplate.Click += BtnNewTemplate_Click;

        pnlScrollBarThumb.MouseDown += ScrollThumb_MouseDown;
        pnlScrollBarThumb.MouseMove += ScrollThumb_MouseMove;
        pnlScrollBarThumb.MouseUp += ScrollThumb_MouseUp;
        pnlScrollBar.MouseClick += ScrollBar_MouseClick;

        Load += (s, e) => HideNativeScrollBar();
        SetupNewTemplateButton();
        LoadTemplatesList();
    }

    private void SetupNewTemplateButton()
    {
        btnNewTemplate.BackgroundImage = Properties.Resources.plus_solid_normal;
        btnNewTemplate.BackgroundImageLayout = ImageLayout.Zoom;
        btnNewTemplate.FlatStyle = FlatStyle.Flat;
        btnNewTemplate.FlatAppearance.BorderSize = 0;
        btnNewTemplate.Cursor = Cursors.Hand;
        btnNewTemplate.TabStop = false;

        btnNewTemplate.MouseEnter += (s, e) => btnNewTemplate.BackgroundImage = Properties.Resources.plus_solid_pressed;
        btnNewTemplate.MouseLeave += (s, e) => btnNewTemplate.BackgroundImage = Properties.Resources.plus_solid_normal;
        btnNewTemplate.MouseDown += (s, e) => btnNewTemplate.BackgroundImage = Properties.Resources.plus_solid_pressed;
        btnNewTemplate.MouseUp += (s, e) =>
        {
            if (btnNewTemplate.ClientRectangle.Contains(btnNewTemplate.PointToClient(Cursor.Position)))
                btnNewTemplate.BackgroundImage = Properties.Resources.plus_solid_pressed;
            else
                btnNewTemplate.BackgroundImage = Properties.Resources.plus_solid_normal;
        };
    }

    private void HideNativeScrollBar()
    {
        if (flpSelectedFiles.IsHandleCreated)
            ShowScrollBar(flpSelectedFiles.Handle, SB_BOTH, false);
    }

    #region Список шаблонов

    private void LoadTemplatesList()
    {
        flpTemplatesList.SuspendLayout();
        flpTemplatesList.Controls.Clear();

        var templates = _templatesService.GetAll();
        lblTemplatesCount.Text = $"Всего шаблонов: {templates.Count}";

        foreach (var template in templates)
        {
            var card = new TemplateCardControl();
            card.SetData(template);
            card.TemplateSelected += OnTemplateSelected;
            card.DeleteRequested += OnTemplateDeleteRequested;
            flpTemplatesList.Controls.Add(card);
        }

        flpTemplatesList.ResumeLayout();

        // ✅ ИСПРАВЛЕНИЕ: Принудительная перерисовка для гарантированного обновления UI
        flpTemplatesList.Refresh();
        this.Refresh();
    }

    private void OnTemplateSelected(TelegramTemplate template)
    {
        if (_selectedCard != null)
            _selectedCard.SetSelected(false);

        foreach (Control control in flpTemplatesList.Controls)
        {
            if (control is TemplateCardControl card && card.GetTemplate()?.Id == template.Id)
            {
                _selectedCard = card;
                card.SetSelected(true);
                break;
            }
        }

        LoadTemplateToEditor(template);
    }

    private void OnTemplateDeleteRequested(TelegramTemplate template)
    {
        DeleteTemplate(template.Id);
    }

    #endregion

    #region Создание и импорт

    private void BtnNewTemplate_Click(object? sender, EventArgs e)
    {
        if (HasUnsavedChanges())
        {
            var result = MessageBox.Show("У вас есть несохраненные изменения.\n\nСбросить текущий шаблон и создать новый?", "Подтверждение сброса", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
        }

        ClearEditor();

        if (_selectedCard != null)
        {
            _selectedCard.SetSelected(false);
            _selectedCard = null;
        }

        txtTemplateName.Focus();
    }

    private bool HasUnsavedChanges()
    {
        return _currentTemplate != null ||
               !string.IsNullOrWhiteSpace(richTextBoxTemplate.Text) ||
               !string.IsNullOrWhiteSpace(txtTemplateName.Text) ||
               _currentAttachments.Count > 0;
    }

    private void BtnImportTemplate_Click(object? sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog
        {
            Filter = "JSON файлы|*.json|Все файлы|*.*",
            Title = "Импорт шаблона из файла"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                var json = File.ReadAllText(openFileDialog.FileName);
                var template = JsonSerializer.Deserialize<TelegramTemplate>(json);

                if (template != null)
                {
                    template.Id = Guid.NewGuid().ToString("N")[..12];
                    template.CreatedAt = DateTime.Now;
                    template.ModifiedAt = DateTime.Now;

                    if (IsTemplateNameExists(template.Name))
                        template.Name = GetUniqueTemplateName(template.Name);

                    _templatesService.Save(template);
                    MessageBox.Show($"Шаблон \"{template.Name}\" успешно импортирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTemplatesList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка импорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    #endregion

    #region Редактирование и сохранение

    private void LoadTemplateToEditor(TelegramTemplate template)
    {
        _currentTemplate = template;
        _currentAttachments.Clear();
        _currentAttachments.AddRange(template.Attachments);

        txtTemplateName.Text = template.Name;
        richTextBoxTemplate.Text = template.Message;
        lblTemplateId.Text = template.Id;
        lblCreatedValue.Text = template.CreatedAt.ToString("dd.MM.yyyy HH:mm");
        lblModifiedValue.Text = template.ModifiedAt.ToString("dd.MM.yyyy HH:mm");
        lblUsageValue.Text = $"{template.UsageCount} раз";

        UpdateAttachmentsUI();
    }

    private void BtnSaveTemplate_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTemplateName.Text))
        {
            MessageBox.Show("Введите название шаблона!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var templateName = txtTemplateName.Text.Trim();

        if (IsTemplateNameExists(templateName) && (_currentTemplate == null || _currentTemplate.Name != templateName))
        {
            var result = MessageBox.Show(
                $"Шаблон с именем \"{templateName}\" уже существует.\n\nСохранить с другим именем?",
                "Конфликт имён",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            templateName = GetUniqueTemplateName(templateName);
        }

        TelegramTemplate templateToSave;

        if (_currentTemplate != null)
        {
            templateToSave = _currentTemplate;
            templateToSave.Name = templateName;
            templateToSave.Message = richTextBoxTemplate.Text;
            templateToSave.Attachments = new List<string>(_currentAttachments);
            templateToSave.ModifiedAt = DateTime.Now;
        }
        else
        {
            templateToSave = new TelegramTemplate
            {
                Name = templateName,
                Message = richTextBoxTemplate.Text,
                Attachments = new List<string>(_currentAttachments),
                CreatedBy = "GAMNYAR"
            };
        }

        _templatesService.Save(templateToSave);
        MessageBox.Show("Шаблон успешно сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

        if (_selectedCard != null)
        {
            _selectedCard.SetSelected(false);
            _selectedCard = null;
        }

        // ✅ ИСПРАВЛЕНО: Полностью пересоздаем список шаблонов
        LoadTemplatesList();

        // ✅ Ищем и выделяем только что сохраненный шаблон
        foreach (Control control in flpTemplatesList.Controls)
        {
            if (control is TemplateCardControl card && card.GetTemplate()?.Name == templateName)
            {
                _selectedCard = card;
                card.SetSelected(true);
                break;
            }
        }

        ClearEditor();
    }

    private void DeleteTemplate(string id)
    {
        if (MessageBox.Show("Удалить этот шаблон?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            _templatesService.Delete(id);

            if (_currentTemplate?.Id == id)
            {
                ClearEditor();
                _selectedCard = null;
            }

            LoadTemplatesList();
        }
    }

    private void ClearEditor()
    {
        _currentTemplate = null;
        _currentAttachments.Clear();
        _scrollPosition = 0;

        txtTemplateName.Text = string.Empty;
        richTextBoxTemplate.Text = string.Empty;
        lblTemplateId.Text = "—";
        lblCreatedValue.Text = "—";
        lblModifiedValue.Text = "—";
        lblUsageValue.Text = "—";

        UpdateAttachmentsUI();
    }

    #endregion

    #region Вложения

    private void BtnSelectFiles_Click(object? sender, EventArgs e)
    {
        if (_currentAttachments.Count >= 10)
        {
            MessageBox.Show("Максимум 10 файлов в одном сообщении!\n\nУдалите некоторые файлы, чтобы добавить новые.", "Лимит файлов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var openFileDialog = new OpenFileDialog
        {
            Filter = "Все файлы|*.*|Изображения|*.png;*.jpg;*.jpeg;*.gif;*.webp;*.bmp|Видео|*.mp4;*.avi;*.mov;*.mkv;*.webm|Документы|*.pdf;*.doc;*.docx;*.txt",
            Multiselect = true,
            Title = "Выберите файлы для вложения"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            int addedCount = 0;
            int skippedCount = 0;

            foreach (var file in openFileDialog.FileNames)
            {
                if (_currentAttachments.Count >= 10)
                {
                    skippedCount++;
                    continue;
                }

                try
                {
                    var fileInfo = new FileInfo(file);
                    if (fileInfo.Length > 2_147_483_648)
                    {
                        var result = MessageBox.Show($"Файл \"{fileInfo.Name}\" превышает 2 ГБ!\n\nTelegram не позволит отправить такой файл.\n\nВсё равно добавить?", "Файл слишком большой", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            skippedCount++;
                            continue;
                        }
                    }
                }
                catch { }

                if (!_currentAttachments.Contains(file))
                {
                    _currentAttachments.Add(file);
                    addedCount++;
                }
            }

            if (addedCount > 0 || skippedCount > 0)
            {
                var message = $"Добавлено файлов: {addedCount}";
                if (skippedCount > 0) message += $"\nПропущено: {skippedCount} (достигнут лимит 10 файлов)";
                MessageBox.Show(message, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateAttachmentsUI();
        }
    }

    private void UpdateAttachmentsUI()
    {
        flpSelectedFiles.SuspendLayout();
        flpSelectedFiles.Controls.Clear();
        flpSelectedFiles.AutoScroll = false;

        lblSelectedFilesCount.Text = $"Выбрано файлов: {_currentAttachments.Count}/10";
        lblSelectedFilesCount.ForeColor = _currentAttachments.Count >= 10 ? Color.FromArgb(239, 68, 68) : Color.FromArgb(156, 163, 175);

        int step = CardWidth + ItemMargin;

        for (int i = 0; i < _currentAttachments.Count; i++)
        {
            var card = CreateSimpleCard(_currentAttachments[i]);
            card.Location = new Point(-_scrollPosition + (i * step), 0);
            flpSelectedFiles.Controls.Add(card);
        }

        flpSelectedFiles.ResumeLayout();
        UpdateScrollBar();
        HideNativeScrollBar();
    }

    private Panel CreateSimpleCard(string filePath)
    {
        var fileName = Path.GetFileName(filePath);
        long fileSizeBytes = 0;
        string fileSizeStr = "0 КБ";
        bool isImage = false;
        bool isVideo = false;
        bool isTooLarge = false;
        Image? thumbnail = null;

        try
        {
            var fileInfo = new FileInfo(filePath);
            fileSizeBytes = fileInfo.Length;

            if (fileSizeBytes > 2_147_483_648)
            {
                isTooLarge = true;
                fileSizeStr = $"{fileSizeBytes / (1024 * 1024 * 1024):F1} ГБ";
            }
            else if (fileSizeBytes > 1024 * 1024)
            {
                fileSizeStr = $"{fileSizeBytes / (1024 * 1024):F1} МБ";
            }
            else
            {
                fileSizeStr = $"{fileSizeBytes / 1024} КБ";
            }

            var extension = fileInfo.Extension.ToLower();
            isImage = extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".gif" || extension == ".webp" || extension == ".bmp";
            isVideo = extension == ".mp4" || extension == ".avi" || extension == ".mov" || extension == ".mkv" || extension == ".webm";

            thumbnail = GetFileThumbnail(filePath, isImage, isVideo);
        }
        catch { }

        var panel = new Panel { Size = new Size(CardWidth, CardHeight), BackColor = Color.FromArgb(35, 39, 48), Margin = new Padding(0) };

        var btnRemove = new Button
        {
            BackgroundImage = Properties.Resources.icon_close_normal,
            BackgroundImageLayout = ImageLayout.Zoom,
            FlatStyle = FlatStyle.Flat,
            Location = new Point(CardWidth - 24, 2),
            Size = new Size(24, 24),
            Cursor = Cursors.Hand,
            TabStop = false,
            Text = ""
        };
        btnRemove.FlatAppearance.BorderSize = 0;

        btnRemove.MouseEnter += (s, e) => btnRemove.BackgroundImage = Properties.Resources.icon_close_hover;
        btnRemove.MouseLeave += (s, e) => btnRemove.BackgroundImage = Properties.Resources.icon_close_normal;
        btnRemove.MouseDown += (s, e) => btnRemove.BackgroundImage = Properties.Resources.icon_close_pressed;
        btnRemove.MouseUp += (s, e) =>
        {
            if (btnRemove.ClientRectangle.Contains(btnRemove.PointToClient(Cursor.Position)))
                btnRemove.BackgroundImage = Properties.Resources.icon_close_hover;
            else
                btnRemove.BackgroundImage = Properties.Resources.icon_close_normal;
        };

        btnRemove.Click += (s, e) =>
        {
            _currentAttachments.Remove(filePath);
            UpdateAttachmentsUI();
        };

        panel.Controls.Add(btnRemove);
        btnRemove.BringToFront();

        if (isTooLarge && Properties.Resources.triangle_exclamation_solid_RED != null)
        {
            var picWarning = new PictureBox
            {
                Image = Properties.Resources.triangle_exclamation_solid_RED,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(22, 22),
                Location = new Point(4, 4),
                BackColor = Color.Transparent,
                Visible = true
            };
            panel.Controls.Add(picWarning);
            picWarning.BringToFront();
        }

        if (isImage)
        {
            if (thumbnail != null)
            {
                panel.Controls.Add(new PictureBox { Size = new Size(CardWidth, PreviewHeight), Location = new Point(0, 0), SizeMode = PictureBoxSizeMode.Zoom, BackColor = Color.FromArgb(31, 34, 42), Image = thumbnail });
            }
            else
            {
                panel.Controls.Add(new Label { Text = "", Font = new Font("Segoe UI Emoji", 24F), Size = new Size(CardWidth, PreviewHeight), Location = new Point(0, 0), TextAlign = ContentAlignment.MiddleCenter, BackColor = Color.FromArgb(31, 34, 42) });
            }
        }
        else if (isVideo)
        {
            if (thumbnail != null)
            {
                panel.Controls.Add(new PictureBox { Size = new Size(CardWidth, PreviewHeight), Location = new Point(0, 0), SizeMode = PictureBoxSizeMode.Zoom, BackColor = Color.FromArgb(31, 34, 42), Image = thumbnail });
                panel.Controls.Add(new Label { Text = "▶", Font = new Font("Segoe UI", 16F, FontStyle.Bold), Size = new Size(36, 36), Location = new Point(CardWidth / 2 - 18, PreviewHeight / 2 - 18), TextAlign = ContentAlignment.MiddleCenter, BackColor = Color.FromArgb(0, 0, 0, 128), ForeColor = Color.White });
            }
            else
            {
                panel.Controls.Add(new Label { Text = "▶", Font = new Font("Segoe UI", 40F, FontStyle.Bold), Size = new Size(CardWidth, PreviewHeight), Location = new Point(0, 0), TextAlign = ContentAlignment.MiddleCenter, BackColor = Color.FromArgb(42, 46, 57), ForeColor = Color.White });
            }
        }
        else
        {
            panel.Controls.Add(new Label { Text = "📄", Font = new Font("Segoe UI Emoji", 24F), Size = new Size(CardWidth, PreviewHeight), Location = new Point(0, 0), TextAlign = ContentAlignment.MiddleCenter, BackColor = Color.FromArgb(31, 34, 42) });
        }

        panel.Controls.Add(new Label { Text = fileName, Font = new Font("Segoe UI", 7F, FontStyle.Bold), ForeColor = isTooLarge ? Color.FromArgb(239, 68, 68) : Color.White, Location = new Point(4, PreviewHeight + 4), Size = new Size(CardWidth - 8, 18), AutoEllipsis = true, BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter });
        panel.Controls.Add(new Label { Text = fileSizeStr, Font = new Font("Segoe UI", 6.5F), ForeColor = isTooLarge ? Color.FromArgb(239, 68, 68) : Color.FromArgb(156, 163, 175), Location = new Point(4, PreviewHeight + 22), Size = new Size(CardWidth - 8, 14), BackColor = Color.Transparent, TextAlign = ContentAlignment.MiddleCenter });

        return panel;
    }

    private Image? GetFileThumbnail(string filePath, bool isImage, bool isVideo)
    {
        try
        {
            if (!File.Exists(filePath)) return null;

            if (isImage)
            {
                try
                {
                    using var img = Image.FromFile(filePath);
                    return ResizeImage(new Bitmap(img), CardWidth, PreviewHeight);
                }
                catch { return null; }
            }

            var shinfo = new SHFILEINFO();
            IntPtr result = SHGetFileInfo(filePath, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), SHGFI_ICON | SHGFI_LARGEICON);

            if (result != IntPtr.Zero && shinfo.hIcon != IntPtr.Zero)
            {
                var icon = Icon.FromHandle(shinfo.hIcon);
                return ResizeImage(icon.ToBitmap(), CardWidth, PreviewHeight);
            }
        }
        catch { }
        return null;
    }

    private Image ResizeImage(Image img, int width, int height)
    {
        var resized = new Bitmap(width, height);
        using (var g = Graphics.FromImage(resized))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float scale = Math.Min((float)width / img.Width, (float)height / img.Height);
            int newWidth = (int)(img.Width * scale);
            int newHeight = (int)(img.Height * scale);
            int x = (width - newWidth) / 2;
            int y = (height - newHeight) / 2;

            g.Clear(Color.FromArgb(31, 34, 42));
            g.DrawImage(img, x, y, newWidth, newHeight);
        }
        return resized;
    }

    #endregion

    #region Кастомный скроллбар

    private void UpdateScrollBar()
    {
        if (_currentAttachments.Count == 0)
        {
            pnlScrollBar.Visible = false;
            return;
        }

        int totalContentWidth = _currentAttachments.Count * (CardWidth + ItemMargin);
        int visibleWidth = flpSelectedFiles.ClientSize.Width;
        int scrollableWidth = totalContentWidth - visibleWidth;

        if (scrollableWidth <= 0)
        {
            pnlScrollBar.Visible = false;
            _scrollPosition = 0;
            return;
        }

        pnlScrollBar.Visible = true;
        int thumbWidth = Math.Max(40, (visibleWidth * visibleWidth) / totalContentWidth);
        thumbWidth = Math.Min(thumbWidth, pnlScrollBar.Width);
        pnlScrollBarThumb.Width = thumbWidth;

        int maxThumbPos = pnlScrollBar.Width - thumbWidth;
        int thumbPos = (int)((_scrollPosition / (double)scrollableWidth) * maxThumbPos);
        thumbPos = Math.Max(0, Math.Min(thumbPos, maxThumbPos));

        pnlScrollBarThumb.Location = new Point(thumbPos, 0);
    }

    private void ScrollThumb_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            _isDragging = true;
            _dragStartX = Control.MousePosition.X;
            _startThumbPos = pnlScrollBarThumb.Left;
            pnlScrollBarThumb.Capture = true;
        }
    }

    private void ScrollThumb_MouseMove(object? sender, MouseEventArgs e)
    {
        if (!_isDragging) return;

        int deltaX = Control.MousePosition.X - _dragStartX;
        int newThumbPos = Math.Max(0, Math.Min(_startThumbPos + deltaX, pnlScrollBar.Width - pnlScrollBarThumb.Width));
        pnlScrollBarThumb.Location = new Point(newThumbPos, 0);

        int scrollableWidth = _currentAttachments.Count * (CardWidth + ItemMargin) - flpSelectedFiles.ClientSize.Width;
        if (scrollableWidth > 0 && (pnlScrollBar.Width - pnlScrollBarThumb.Width) > 0)
        {
            _scrollPosition = (int)((newThumbPos / (double)(pnlScrollBar.Width - pnlScrollBarThumb.Width)) * scrollableWidth);
            ApplyScrollPosition();
        }
    }

    private void ScrollThumb_MouseUp(object? sender, MouseEventArgs e)
    {
        _isDragging = false;
        pnlScrollBarThumb.Capture = false;
    }

    private void ScrollBar_MouseClick(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            int thumbCenter = pnlScrollBarThumb.Left + (pnlScrollBarThumb.Width / 2);
            ScrollByAmount(e.X < thumbCenter ? -100 : 100);
        }
    }

    private void ScrollByAmount(int amount)
    {
        int scrollableWidth = _currentAttachments.Count * (CardWidth + ItemMargin) - flpSelectedFiles.ClientSize.Width;
        if (scrollableWidth <= 0) return;

        _scrollPosition = Math.Max(0, Math.Min(_scrollPosition + amount, scrollableWidth));
        ApplyScrollPosition();
        UpdateScrollBar();
    }

    private void ApplyScrollPosition()
    {
        int step = CardWidth + ItemMargin;
        for (int i = 0; i < flpSelectedFiles.Controls.Count; i++)
        {
            flpSelectedFiles.Controls[i].Location = new Point(-_scrollPosition + (i * step), 0);
        }
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        base.OnMouseWheel(e);
        if (flpSelectedFiles.ClientRectangle.Contains(flpSelectedFiles.PointToClient(MousePosition)))
        {
            ScrollByAmount(e.Delta > 0 ? -50 : 50);
        }
    }

    #endregion

    #region Вспомогательные методы

    private bool IsTemplateNameExists(string name) => _templatesService.GetAll().Any(t => t.Name == name);

    private string GetUniqueTemplateName(string baseName)
    {
        var name = baseName;
        int counter = 2;
        while (IsTemplateNameExists(name))
        {
            name = $"{baseName} ({counter})";
            counter++;
        }
        return name;
    }

    private void RichTextBoxTemplate_TextChanged(object? sender, EventArgs e)
    {
        int remaining = 4096 - richTextBoxTemplate.TextLength;
        lblCharCount.Text = $"Осталось: {remaining}";
        lblCharCount.ForeColor = remaining < 0 ? Color.FromArgb(239, 68, 68) : Color.FromArgb(156, 163, 175);
    }

    private void BtnPreview_Click(object? sender, EventArgs e)
    {
        if (_currentTemplate == null && string.IsNullOrWhiteSpace(txtTemplateName.Text) && string.IsNullOrWhiteSpace(richTextBoxTemplate.Text) && _currentAttachments.Count == 0)
        {
            MessageBox.Show("Сначала выберите или создайте шаблон!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var tempTemplate = new TelegramTemplate
        {
            Name = string.IsNullOrWhiteSpace(txtTemplateName.Text) ? "Без названия" : txtTemplateName.Text,
            Message = richTextBoxTemplate.Text,
            Attachments = new List<string>(_currentAttachments)
        };

        var tagService = new TemplateTagService(AppServices.TelegramBot, AppServices.TelegramGroups);
        using var previewForm = new TemplatePreviewForm(tempTemplate, tagService);
        previewForm.ShowDialog(this);
    }

    #endregion
}