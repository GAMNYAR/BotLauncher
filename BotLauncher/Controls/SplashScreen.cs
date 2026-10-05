using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotLauncher.Controls
{
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновить прогресс и статус
        /// </summary>
        public void UpdateProgress(int value, string status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateProgress(value, status)));
                return;
            }

            // Это работает и для стандартного, и для ReaLTaiizor прогресс-бара
            progressBar.Value = value;
            lblStatus.Text = status;
        }

        /// <summary>
        /// Симуляция загрузки с этапами
        /// </summary>
        public async Task RunStartupChecksAsync(Func<Task> checkProfile, Func<Task> checkBot)
        {
            UpdateProgress(10, "Загрузка настроек...");
            await Task.Delay(300);

            UpdateProgress(30, "Проверка профиля...");
            await checkProfile();
            await Task.Delay(400);

            UpdateProgress(60, "Подключение к Telegram...");
            await checkBot();
            await Task.Delay(500);

            UpdateProgress(90, "Подготовка интерфейса...");
            await Task.Delay(300);

            UpdateProgress(100, "Готово!");
            await Task.Delay(200);
        }
    }
}