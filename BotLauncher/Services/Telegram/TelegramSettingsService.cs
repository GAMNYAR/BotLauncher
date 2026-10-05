using System.Text.Json;
using BotLauncher.Models.Telegram;

namespace BotLauncher.Services.Telegram
{
    /// <summary>
    /// Сервис загрузки и сохранения настроек Telegram.
    /// </summary>
    public class TelegramSettingsService
    {
        private readonly string folderPath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data");

        private readonly string filePath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data",
                "telegram_settings.json");

        private readonly JsonSerializerOptions jsonOptions =
            new JsonSerializerOptions
            {
                WriteIndented = true
            };

        public TelegramSettingsService()
        {
            EnsureStorageFolder();
        }

        // =========================================================
        // Загрузка
        // =========================================================

        /// <summary>
        /// Загрузить настройки Telegram.
        /// </summary>
        public TelegramSettings Load()
        {
            try
            {
                EnsureStorageFolder();

                if (!File.Exists(filePath))
                {
                    return new TelegramSettings();
                }

                string json =
                    File.ReadAllText(filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return new TelegramSettings();
                }

                TelegramSettings? settings =
                    JsonSerializer.Deserialize<TelegramSettings>(
                        json,
                        jsonOptions);

                return settings ??
                       new TelegramSettings();
            }
            catch (JsonException exception)
            {
                Console.WriteLine(
                    $"Ошибка чтения настроек Telegram: " +
                    $"{exception.Message}");

                return new TelegramSettings();
            }
            catch (IOException exception)
            {
                Console.WriteLine(
                    $"Ошибка доступа к файлу настроек Telegram: " +
                    $"{exception.Message}");

                return new TelegramSettings();
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Не удалось загрузить настройки Telegram: " +
                    $"{exception.Message}");

                return new TelegramSettings();
            }
        }

        // =========================================================
        // Сохранение
        // =========================================================

        /// <summary>
        /// Сохранить настройки Telegram.
        /// </summary>
        public bool Save(
            TelegramSettings settings)
        {
            if (settings == null)
                return false;

            try
            {
                EnsureStorageFolder();

                string json =
                    JsonSerializer.Serialize(
                        settings,
                        jsonOptions);

                string temporaryFilePath =
                    filePath + ".tmp";

                File.WriteAllText(
                    temporaryFilePath,
                    json);

                // Если основной файл существует,
                // удаляем его перед заменой.
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                File.Move(
                    temporaryFilePath,
                    filePath);

                return true;
            }
            catch (IOException exception)
            {
                Console.WriteLine(
                    $"Ошибка сохранения настроек Telegram: " +
                    $"{exception.Message}");

                TryDeleteTemporaryFile();

                return false;
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Не удалось сохранить настройки Telegram: " +
                    $"{exception.Message}");

                TryDeleteTemporaryFile();

                return false;
            }
        }

        // =========================================================
        // Проверка файла
        // =========================================================

        /// <summary>
        /// Проверить, существуют ли сохранённые настройки.
        /// </summary>
        public bool Exists()
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// Получить путь к файлу настроек.
        /// </summary>
        public string GetFilePath()
        {
            return filePath;
        }

        // =========================================================
        // Вспомогательные методы
        // =========================================================

        /// <summary>
        /// Создать папку Data, если её ещё нет.
        /// </summary>
        private void EnsureStorageFolder()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(
                    folderPath);
            }
        }

        /// <summary>
        /// Удалить временный файл после ошибки сохранения.
        /// </summary>
        private void TryDeleteTemporaryFile()
        {
            string temporaryFilePath =
                filePath + ".tmp";

            try
            {
                if (File.Exists(
                        temporaryFilePath))
                {
                    File.Delete(
                        temporaryFilePath);
                }
            }
            catch
            {
                // Ничего не делаем.
                // Ошибка очистки временного файла
                // не должна ломать приложение.
            }
        }
    }
}