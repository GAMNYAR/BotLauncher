using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace BotLauncher.Forms
{
    public partial class AddTriggerRuleForm : Form
    {
        private readonly WebView2 webView;

        /// <summary>
        /// Возвращает true, если сценарий был создан/отредактирован и подтвержден
        /// </summary>
        public bool HasScenario { get; private set; }

        /// <summary>
        /// Возвращает JSON сценария из редактора
        /// </summary>
        public string ScenarioJson { get; private set; } = "{}";

        public AddTriggerRuleForm()
        {
            InitializeComponent();

            // ==========================================
            // НАСТРОЙКИ НЕЗАВИСИМОГО ОКНА (ВАРИАНТ B)
            // ==========================================
            this.TopMost = false;                // Не поверх всех окон
            this.ShowInTaskbar = true;           // Показывать на панели задач как отдельное приложение
            this.Owner = null;                   // Нет владельца, полностью независимо

            // Восстанавливаем сохраненные размеры и позицию
            this.StartPosition = FormStartPosition.Manual;

            if (Properties.Settings.Default.EditorWindowSize.IsEmpty ||
                Properties.Settings.Default.EditorWindowSize.Width < 800)
            {
                // ПЕРВЫЙ ЗАПУСК: задаем дефолтные размеры и центрируем
                this.Size = new Size(1200, 800);
                this.CenterToScreen();
            }
            else
            {
                // ПОСЛЕДУЮЩИЕ ЗАПУСКИ: восстанавливаем сохраненные
                this.Size = Properties.Settings.Default.EditorWindowSize;
                this.Location = Properties.Settings.Default.EditorWindowLocation;

                // ✅ ПРОФЕССИОНАЛЬНАЯ ЗАЩИТА: 
                // Если окно оказалось за пределами экрана (сменили монитор/разрешение), возвращаем его в центр
                var screen = Screen.FromPoint(this.Location);
                if (!screen.WorkingArea.IntersectsWith(new Rectangle(this.Location, this.Size)))
                {
                    this.CenterToScreen();
                }
            }

            // 1. Создаем и настраиваем WebView2 СРАЗУ в конструкторе
            webView = new WebView2
            {
                Dock = DockStyle.Fill,
                DefaultBackgroundColor = Color.FromArgb(15, 15, 30)
            };

            // 2. Добавляем на панель сразу
            pnlMain.Controls.Add(webView);

            // 3. Подписываемся на событие завершения загрузки страницы
            webView.NavigationCompleted += WebView_NavigationCompleted;

            // 4. Запускаем асинхронную инициализацию ядра
            InitializeWebViewAsync();
        }

        private async void InitializeWebViewAsync()
        {
            try
            {
                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string editorPath = Path.Combine(baseDirectory, "Resources", "ScenarioEditor", "editor.html");

                if (!File.Exists(editorPath))
                {
                    editorPath = Path.Combine(baseDirectory, "Resources", "WebEditor", "editor.html");
                }

                if (File.Exists(editorPath))
                {
                    Uri fileUri = new Uri(editorPath);
                    webView.CoreWebView2.Navigate(fileUri.ToString());
                }
                else
                {
                    MessageBox.Show(
                        $"Не удалось найти файл редактора по пути:\n{editorPath}\n\n" +
                        $"Текущая папка: {baseDirectory}\n\n" +
                        "Убедитесь, что папка существует и файлы настроены на копирование.",
                        "Ошибка загрузки редактора",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации WebView2:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void CoreWebView2_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                string message = e.WebMessageAsJson;

                if (message.StartsWith("\"") && message.EndsWith("\""))
                {
                    message = message.Substring(1, message.Length - 2);
                }

                if (message == "scenario_saved")
                {
                    HasScenario = true;
                }
                else if (message.StartsWith("scenario_data:"))
                {
                    ScenarioJson = message.Substring("scenario_data:".Length);
                    HasScenario = true;

                    this.Invoke(new Action(() => {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }));
                }
                else if (message == "scenario_cancelled")
                {
                    this.Invoke(new Action(() => {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing web message: {ex.Message}");
            }
        }

        private void WebView_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                string script = @"
                    window.sendToCSharp = function(message) {
                        window.chrome.webview.postMessage(message);
                    };
                    window.saveScenario = function(scenarioJson) {
                        window.sendToCSharp('scenario_data:' + scenarioJson);
                    };
                    window.cancelScenario = function() {
                        window.sendToCSharp('scenario_cancelled');
                    };
                    console.log('WebView2 initialized and ready');
                ";
                webView.CoreWebView2.ExecuteScriptAsync(script);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // ==========================================
            // СОХРАНЕНИЕ ПОЗИЦИИ И РАЗМЕРА ПРИ ЗАКРЫТИИ
            // ==========================================
            if (this.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.EditorWindowLocation = this.Location;
                Properties.Settings.Default.EditorWindowSize = this.Size;
            }
            else
            {
                // Если окно было развернуто на весь экран или свернуто, сохраняем его "нормальные" границы
                Properties.Settings.Default.EditorWindowLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.EditorWindowSize = this.RestoreBounds.Size;
            }

            // Сохраняем настройки на диск
            Properties.Settings.Default.Save();

            // Освобождаем ресурсы WebView2
            webView.Dispose();
            base.OnFormClosing(e);
        }
    }
}