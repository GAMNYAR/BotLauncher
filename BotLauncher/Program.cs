using BotLauncher.Services.Telegram;
using BotLauncher.Shared.Services;
using System;
using System.Windows.Forms;

namespace BotLauncher
{
    internal static class Program
    {
        // СТАТИЧЕСКИЙ ФЛАГ — доступен из любой формы
        public static bool BotConnectedAtStartup = false;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                var settingsService = new TelegramSettingsService();
                var settings = settingsService.Load();

                if (settings != null && settings.AutoConnect && !string.IsNullOrWhiteSpace(settings.BotToken))
                {
                    var bot = AppServices.TelegramBot;
                    var connectTask = bot.ConnectAsync(settings.BotToken);

                    bool taskCompleted = connectTask.Wait(TimeSpan.FromSeconds(5));

                    if (taskCompleted && connectTask.Result && bot.IsConnected)
                    {
                        BotConnectedAtStartup = true;
                    }
                }
            }
            catch
            {
                // Намеренно игнорируем любые ошибки при автоподключении, 
                // чтобы приложение могло запуститься и позволить настроить бота вручную.
                // (Это убирает предупреждения компилятора)
            }

            Application.Run(new mainForm());
        }
    }
}