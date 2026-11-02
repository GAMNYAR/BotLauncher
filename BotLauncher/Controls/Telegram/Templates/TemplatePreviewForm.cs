using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Templates
{
    public class TemplatePreviewForm : Form
    {
        private readonly TelegramTemplate _template;
        private readonly TemplateTagService _tagService;
        private bool _isMobileView = false; // По умолчанию десктоп
        private bool _isDarkTheme = true;   // По умолчанию темная тема
        private bool _isWebViewReady = false;

        private WebView2 _webView = null!;

        public TemplatePreviewForm(TelegramTemplate template, TemplateTagService tagService)
        {
            _template = template ?? throw new ArgumentNullException(nameof(template));
            _tagService = tagService ?? throw new ArgumentNullException(nameof(tagService));

            InitializeForm();
            _ = InitializeWebViewAsync();
        }

        private void InitializeForm()
        {
            Text = $"Предпросмотр: {_template.Name}";
            Size = new Size(900, 700); // Оптимальный размер для предпросмотра
            MinimumSize = new Size(600, 500);
            BackColor = Color.FromArgb(14, 22, 33);
            StartPosition = FormStartPosition.CenterParent;
        }

        private async Task InitializeWebViewAsync()
        {
            try
            {
                _webView = new WebView2
                {
                    Dock = DockStyle.Fill,
                    DefaultBackgroundColor = Color.FromArgb(14, 22, 33)
                };
                Controls.Add(_webView);

                var env = await CoreWebView2Environment.CreateAsync();
                await _webView.EnsureCoreWebView2Async(env);
                _webView.WebMessageReceived += OnWebMessageReceived;
                _isWebViewReady = true;

                // ✅ ИСПРАВЛЕННЫЙ ПУТЬ
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string htmlPath = Path.Combine(baseDirectory, "Resources", "TemplatePreview", "preview.html");

                if (File.Exists(htmlPath))
                {
                    _webView.CoreWebView2.Navigate($"file:///{htmlPath.Replace("\\", "/")}");
                }
                else
                {
                    MessageBox.Show($"Файл не найден:\n{htmlPath}\n\nПроверьте, что файл настроен на 'Копировать в выходной каталог'.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка WebView2: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnWebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                string msg = e.TryGetWebMessageAsString();
                if (msg == "ready")
                {
                    UpdateWebView();
                }
                else if (msg == "toggle_theme")
                {
                    _isDarkTheme = !_isDarkTheme;
                    UpdateWebView(); // Перерисовываем с новой темой
                }
                else if (msg == "toggle_view")
                {
                    _isMobileView = !_isMobileView;
                    UpdateWebView(); // Перерисовываем с новым видом
                }
            }
            catch { }
        }

        private void UpdateWebView()
        {
            if (!_isWebViewReady) return;

            try
            {
                string message = _tagService.ReplaceTags(_template.Message ?? "", _template);
                string formattedMessage = FormatMessage(message);
                string attachmentsHtml = GenerateAttachmentsHtml();
                string time = DateTime.Now.ToString("HH:mm");
                string date = DateTime.Now.ToString("d MMMM");

                string channelName = "Мой Канал"; // Можно брать из настроек бота
                string channelType = "канал";
                int views = new Random().Next(10, 5000);

                // ✅ ПРОФЕССИОНАЛЬНАЯ СЕРИАЛИЗАЦИЯ JSON (вместо ручной сборки строки)
                var previewData = new
                {
                    date = date,
                    channelName = channelName,
                    channelType = channelType,
                    attachmentsHtml = attachmentsHtml,
                    messageText = formattedMessage,
                    views = views,
                    time = time,
                    isMobile = _isMobileView,
                    isDark = _isDarkTheme
                };

                string jsonData = JsonSerializer.Serialize(previewData);
                string script = $"updatePreview({jsonData})";

                _webView.ExecuteScriptAsync(script);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string FormatMessage(string text)
        {
            if (string.IsNullOrEmpty(text)) return "<i style='color: var(--text-secondary)'>пустое сообщение</i>";

            // Экранируем HTML для безопасности
            text = System.Net.WebUtility.HtmlEncode(text);

            // 1. Скрытый текст (спойлер) ||text||
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"\\\|\\\|(.*?)\\\|\\\|",
                "<span class='spoiler'>$1</span>");

            // 2. Цитаты > text (в начале строки)
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"^&gt;\s+(.+)$",
                "<blockquote class='telegram-quote'>$1</blockquote>",
                System.Text.RegularExpressions.RegexOptions.Multiline);

            // 3. Ссылки [text](url)
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"\\[(.+?)\\]\\((.+?)\\)",
                "<a href='$2' class='telegram-link' target='_blank'>$1</a>");

            // 4. Жирный **text** или __text__
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"\\\*\\\*(.+?)\\\*\\\*",
                "<b>$1</b>");
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"__(.+?)__",
                "<b>$1</b>");

            // 5. Курсив *text* или _text_
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"\\\*(.+?)\\\*",
                "<i>$1</i>");
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"(?<!\\w)_(.+?)_(?!\\w)",
                "<i>$1</i>");

            // 6. Зачеркнутый ~text~
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"~(.+?)~",
                "<del>$1</del>");

            // 7. Подчеркнутый ++text++
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"\\\+(.+?)\\\+",
                "<u>$1</u>");

            // 8. Моноширинный `text`
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"`(.+?)`",
                "<code>$1</code>");

            // 9. Блок кода ```code```
            text = System.Text.RegularExpressions.Regex.Replace(text,
                @"```(.*?)```",
                "<pre>$1</pre>",
                System.Text.RegularExpressions.RegexOptions.Singleline);

            // 10. Переносы строк
            text = text.Replace("\n", "<br>");

            return text;
        }

        private string GenerateAttachmentsHtml()
        {
            if (_template.Attachments == null || _template.Attachments.Count == 0) return "";

            var sb = new StringBuilder();
            int count = _template.Attachments.Count;
            string gridClass = count <= 12 ? $"group-{count}" : "group-many";

            sb.Append($"<div class='attachment-group {gridClass}'>");

            if (count >= 7)
            {
                int itemsPerRow = 4;
                int rows = (count + itemsPerRow - 1) / itemsPerRow;

                for (int row = 0; row < rows; row++)
                {
                    sb.Append("<div class='row'>");
                    int itemsInRow = Math.Min(itemsPerRow, count - (row * itemsPerRow));

                    for (int col = 0; col < itemsInRow; col++)
                    {
                        int index = row * itemsPerRow + col;
                        if (index < _template.Attachments.Count)
                        {
                            sb.Append(RenderAttachmentItem(_template.Attachments[index]));
                        }
                    }
                    sb.Append("</div>");
                }
            }
            else
            {
                foreach (var file in _template.Attachments)
                {
                    sb.Append(RenderAttachmentItem(file));
                }
            }

            sb.Append("</div>");
            return sb.ToString();
        }

        private string RenderAttachmentItem(string file)
        {
            try
            {
                var ext = Path.GetExtension(file).ToLower();
                if (ext is ".jpg" or ".jpeg" or ".png" or ".gif" or ".webp")
                {
                    byte[] bytes = File.ReadAllBytes(file);
                    string base64 = Convert.ToBase64String(bytes);
                    return $"<div class='att-item'><img src='data:image/jpeg;base64,{base64}' loading='lazy'></div>";
                }
                else if (ext is ".mp4" or ".avi" or ".mov" or ".mkv" or ".webm")
                {
                    string? thumb = ExtractVideoThumbnail(file);
                    string duration = GetVideoDuration(file);

                    if (!string.IsNullOrEmpty(thumb))
                    {
                        return $"<div class='att-item'>" +
                               $"<img src='{thumb}' style='width:100%;height:100%;object-fit:cover;' loading='lazy'>" +
                               $"<div class='play-icon'><svg class='icon-svg-play' viewBox='0 0 24 24'><path d='M8 5v14l11-7z'/></svg></div>" +
                               $"<div class='video-duration'>{duration}</div>" +
                               $"</div>";
                    }
                    else
                    {
                        return $"<div class='att-item' style='background:linear-gradient(135deg,#667eea,#764ba2);display:flex;align-items:center;justify-content:center;'>" +
                               $"<div class='play-icon'><svg class='icon-svg-play' viewBox='0 0 24 24'><path d='M8 5v14l11-7z'/></svg></div>" +
                               $"<div class='video-duration'>{duration}</div>" +
                               $"</div>";
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка обработки файла {file}: {ex.Message}");
            }
            return "";
        }

        // ... (Методы GetVideoDuration, ExtractVideoThumbnail, FindFFmpeg оставляем без изменений, они отличные) ...
        private string GetVideoDuration(string videoPath) { /* твой код */ return "00:00"; }
        private string? ExtractVideoThumbnail(string videoPath) { /* твой код */ return null; }
        private string? FindFFmpeg() { /* твой код */ return null; }
    }
}