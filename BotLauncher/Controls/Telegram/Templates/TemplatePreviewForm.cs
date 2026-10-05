using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotLauncher.Controls.Telegram.Templates
{
    public class TemplatePreviewForm : Form
    {
        private readonly TelegramTemplate _template;
        private readonly TemplateTagService _tagService;
        private bool _isMobileView = true;
        private bool _isDarkTheme = true;
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
            Size = new Size(1000, 750);
            MinimumSize = new Size(700, 600);
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
                    BackColor = Color.FromArgb(14, 22, 33)
                };
                Controls.Add(_webView);

                var env = await CoreWebView2Environment.CreateAsync();
                await _webView.EnsureCoreWebView2Async(env);
                _webView.WebMessageReceived += OnWebMessageReceived;
                _isWebViewReady = true;

                string htmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "preview.html");
                if (File.Exists(htmlPath))
                {
                    _webView.CoreWebView2.Navigate($"file:///{htmlPath.Replace("\\", "/")}");
                }
                else
                {
                    MessageBox.Show("Файл preview.html не найден в папке проекта!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка WebView2: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else if (msg == "toggle_view")
                {
                    _isMobileView = !_isMobileView;
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

                // Название канала и тип
                string channelName = "Бот";
                string channelType = "канал"; // Исправлено: убрана проверка IsGroup, которой нет в модели
                int views = new Random().Next(10, 1000);

                // Формируем JSON для передачи в JavaScript
                string jsonData = "{";
                jsonData += $"\"date\": \"{date}\",";
                jsonData += $"\"channelName\": \"{EscapeJson(channelName)}\",";
                jsonData += $"\"channelType\": \"{channelType}\",";
                jsonData += $"\"attachmentsHtml\": \"{EscapeJson(attachmentsHtml)}\",";
                jsonData += $"\"messageText\": \"{EscapeJson(formattedMessage)}\",";
                jsonData += $"\"views\": {views},";
                jsonData += $"\"time\": \"{time}\"";
                jsonData += "}";

                string script = $"updatePreview({jsonData})";
                _webView.ExecuteScriptAsync(script);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string EscapeJson(string text)
        {
            return text.Replace("\\", "\\\\")
                      .Replace("\"", "\\\"")
                      .Replace("\n", "\\n")
                      .Replace("\r", "")
                      .Replace("\t", "\\t");
        }

        private string FormatMessage(string text)
        {
            if (string.IsNullOrEmpty(text)) return "<i>(пустое сообщение)</i>";
            text = System.Net.WebUtility.HtmlEncode(text);
            text = text.Replace("&lt;b&gt;", "<b>").Replace("&lt;/b&gt;", "</b>");
            text = text.Replace("&lt;i&gt;", "<i>").Replace("&lt;/i&gt;", "</i>");
            text = text.Replace("&lt;code&gt;", "<code>").Replace("&lt;/code&gt;", "</code>");
            text = text.Replace("&lt;pre&gt;", "<pre>").Replace("&lt;/pre&gt;", "</pre>");
            return text;
        }

        private string GenerateAttachmentsHtml()
        {
            if (_template.Attachments == null || _template.Attachments.Count == 0) return "";

            var sb = new StringBuilder();
            int count = _template.Attachments.Count;

            // Определяем класс сетки
            string gridClass = count switch
            {
                1 => "group-1",
                2 => "group-2",
                3 => "group-3",
                4 => "group-4",
                5 => "group-5",
                6 => "group-6",
                7 => "group-7",
                8 => "group-8",
                9 => "group-9",
                10 => "group-10",
                11 => "group-11",
                12 => "group-12",
                _ => "group-many"
            };

            sb.Append($"<div class='attachment-group {gridClass}'>");

            // Для 7-12 файлов создаём строки
            if (count >= 7 && count <= 12)
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
                            var file = _template.Attachments[index];
                            try
                            {
                                var ext = Path.GetExtension(file).ToLower();

                                if (ext is ".jpg" or ".jpeg" or ".png" or ".gif" or ".webp")
                                {
                                    byte[] bytes = File.ReadAllBytes(file);
                                    string base64 = Convert.ToBase64String(bytes);
                                    sb.Append($"<div class='att-item'><img src='data:image/jpeg;base64,{base64}'></div>");
                                }
                                else if (ext is ".mp4" or ".avi" or ".mov" or ".mkv" or ".webm")
                                {
                                    string? thumb = ExtractVideoThumbnail(file);
                                    string duration = GetVideoDuration(file);

                                    if (!string.IsNullOrEmpty(thumb))
                                    {
                                        sb.Append($"<div class='att-item'>");
                                        sb.Append($"<img src='{thumb}' style='width:100%;height:100%;object-fit:cover;'>");
                                        sb.Append($"<div class='play-icon'><svg class='icon-svg-play' viewBox='0 0 24 24'><path d='M8 5v14l11-7z'/></svg></div>");
                                        sb.Append($"<div class='video-duration'>{duration}</div>");
                                        sb.Append($"</div>");
                                    }
                                    else
                                    {
                                        sb.Append($"<div class='att-item' style='background:linear-gradient(135deg,#667eea,#764ba2);display:flex;align-items:center;justify-content:center;'>");
                                        sb.Append($"<div class='play-icon'><svg class='icon-svg-play' viewBox='0 0 24 24'><path d='M8 5v14l11-7z'/></svg></div>");
                                        sb.Append($"<div class='video-duration'>{duration}</div>");
                                        sb.Append($"</div>");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Ошибка обработки файла {file}: {ex.Message}");
                            }
                        }
                    }
                    sb.Append("</div>");
                }
            }
            else
            {
                // Для 1-6 и 9 файлов
                foreach (var file in _template.Attachments)
                {
                    try
                    {
                        var ext = Path.GetExtension(file).ToLower();

                        if (ext is ".jpg" or ".jpeg" or ".png" or ".gif" or ".webp")
                        {
                            byte[] bytes = File.ReadAllBytes(file);
                            string base64 = Convert.ToBase64String(bytes);
                            sb.Append($"<div class='att-item'><img src='data:image/jpeg;base64,{base64}'></div>");
                        }
                        else if (ext is ".mp4" or ".avi" or ".mov" or ".mkv" or ".webm")
                        {
                            string? thumb = ExtractVideoThumbnail(file);
                            string duration = GetVideoDuration(file);

                            if (!string.IsNullOrEmpty(thumb))
                            {
                                sb.Append($"<div class='att-item'>");
                                sb.Append($"<img src='{thumb}' style='width:100%;height:100%;object-fit:cover;'>");
                                sb.Append($"<div class='play-icon'><svg class='icon-svg-play' viewBox='0 0 24 24'><path d='M8 5v14l11-7z'/></svg></div>");
                                sb.Append($"<div class='video-duration'>{duration}</div>");
                                sb.Append($"</div>");
                            }
                            else
                            {
                                sb.Append($"<div class='att-item' style='background:linear-gradient(135deg,#667eea,#764ba2);display:flex;align-items:center;justify-content:center;'>");
                                sb.Append($"<div class='play-icon'><svg class='icon-svg-play' viewBox='0 0 24 24'><path d='M8 5v14l11-7z'/></svg></div>");
                                sb.Append($"<div class='video-duration'>{duration}</div>");
                                sb.Append($"</div>");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Ошибка обработки файла {file}: {ex.Message}");
                    }
                }
            }

            sb.Append("</div>");
            return sb.ToString();
        }

        private string GetVideoDuration(string videoPath)
        {
            try
            {
                string? ffmpegPath = FindFFmpeg();
                if (string.IsNullOrEmpty(ffmpegPath)) return "00:00";

                var processInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = $"-i \"{videoPath}\"",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    WorkingDirectory = Path.GetDirectoryName(ffmpegPath) ?? ""
                };

                using (var process = Process.Start(processInfo))
                {
                    if (process != null)
                    {
                        string output = process.StandardError.ReadToEnd();
                        process.WaitForExit(5000);

                        var match = System.Text.RegularExpressions.Regex.Match(output, @"Duration: (\d{2}):(\d{2}):(\d{2})");
                        if (match.Success)
                        {
                            return $"{match.Groups[1].Value}:{match.Groups[2].Value}";
                        }
                    }
                }
                return "00:00";
            }
            catch
            {
                return "00:00";
            }
        }

        private string? ExtractVideoThumbnail(string videoPath)
        {
            try
            {
                string? ffmpegPath = FindFFmpeg();
                if (string.IsNullOrEmpty(ffmpegPath)) return null;

                string tempFrame = Path.Combine(Path.GetTempPath(), $"video_thumb_{Guid.NewGuid():N}.jpg");
                var processInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = $"-i \"{videoPath}\" -ss 00:00:01 -vframes 1 -q:v 2 \"{tempFrame}\"",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    WorkingDirectory = Path.GetDirectoryName(ffmpegPath) ?? ""
                };

                using (var process = Process.Start(processInfo))
                {
                    if (process != null)
                    {
                        process.WaitForExit(15000);
                        if (File.Exists(tempFrame) && new FileInfo(tempFrame).Length > 0)
                        {
                            byte[] bytes = File.ReadAllBytes(tempFrame);
                            string base64 = Convert.ToBase64String(bytes);
                            File.Delete(tempFrame);
                            return $"data:image/jpeg;base64,{base64}";
                        }
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        private string? FindFFmpeg()
        {
            string localPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
            if (File.Exists(localPath)) return localPath;

            string parentPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.FullName ?? "", "ffmpeg.exe");
            if (File.Exists(parentPath)) return parentPath;

            string? pathEnv = Environment.GetEnvironmentVariable("PATH");
            if (!string.IsNullOrEmpty(pathEnv))
            {
                foreach (string path in pathEnv.Split(';'))
                {
                    string trimmedPath = path.Trim();
                    if (string.IsNullOrEmpty(trimmedPath)) continue;
                    string ffmpegPath = Path.Combine(trimmedPath, "ffmpeg.exe");
                    if (File.Exists(ffmpegPath)) return ffmpegPath;
                }
            }

            string[] commonPaths = new string[]
            {
                @"C:\ffmpeg\bin\ffmpeg.exe",
                @"C:\Program Files\ffmpeg\bin\ffmpeg.exe",
                @"C:\Program Files (x86)\ffmpeg\bin\ffmpeg.exe",
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "ffmpeg.exe")
            };

            foreach (string path in commonPaths)
            {
                if (File.Exists(path)) return path;
            }

            return null;
        }
    }
}