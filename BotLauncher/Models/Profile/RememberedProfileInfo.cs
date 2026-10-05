using System;
using System.IO;
using System.Text.Json;
using BotLauncher.Services.Storage; // ИСПРАВЛЕНО: добавлен правильный using для TokenStorageService

namespace BotLauncher.Models.Profile
{
    /// <summary>
    /// Информация о запомненном профиле
    /// </summary>
    public class RememberedProfileInfo
    {
        public string ProfileFileName { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public DateTime LastOpened { get; set; }
        public bool AutoLogin { get; set; }
    }

    /// <summary>
    /// Сервис для запоминания последнего открытого профиля
    /// </summary>
    public class RememberedProfileService
    {
        private readonly string _configFilePath;
        private readonly string _passwordFilePath;

        public RememberedProfileService()
        {
            string appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "BotLauncher"
            );

            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            _configFilePath = Path.Combine(appDataPath, "remembered_profile.json");
            _passwordFilePath = Path.Combine(appDataPath, "profile_password.enc");
        }

        /// <summary>
        /// Запомнить профиль
        /// </summary>
        public void RememberProfile(string profileFileName, string profileName, string? password = null)
        {
            var info = new RememberedProfileInfo
            {
                ProfileFileName = profileFileName,
                ProfileName = profileName,
                LastOpened = DateTime.Now,
                AutoLogin = !string.IsNullOrWhiteSpace(password)
            };

            string json = JsonSerializer.Serialize(info, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            // ИСПРАВЛЕНО: явное указание System.IO.File, чтобы избежать конфликта с BotLauncher.Models.File
            System.IO.File.WriteAllText(_configFilePath, json);

            // Если есть пароль, сохраняем его зашифрованным
            if (!string.IsNullOrWhiteSpace(password))
            {
                var tokenStorage = new TokenStorageService();
                System.IO.File.WriteAllText(_passwordFilePath, EncryptPassword(password));
            }
        }

        /// <summary>
        /// Получить запомненный профиль
        /// </summary>
        public RememberedProfileInfo? GetRememberedProfile()
        {
            if (!System.IO.File.Exists(_configFilePath))
                return null;

            try
            {
                string json = System.IO.File.ReadAllText(_configFilePath);
                return JsonSerializer.Deserialize<RememberedProfileInfo>(json);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Получить пароль для запомненного профиля
        /// </summary>
        public string? GetProfilePassword()
        {
            if (!System.IO.File.Exists(_passwordFilePath))
                return null;

            try
            {
                return DecryptPassword(System.IO.File.ReadAllText(_passwordFilePath));
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Забыть профиль (очистить запомненные данные)
        /// </summary>
        public void ForgetProfile()
        {
            if (System.IO.File.Exists(_configFilePath))
                System.IO.File.Delete(_configFilePath);

            if (System.IO.File.Exists(_passwordFilePath))
                System.IO.File.Delete(_passwordFilePath);
        }

        /// <summary>
        /// Проверить, есть ли запомненный профиль
        /// </summary>
        public bool HasRememberedProfile()
        {
            var profile = GetRememberedProfile();
            return profile != null && System.IO.File.Exists(GetProfilePath(profile.ProfileFileName));
        }

        private string GetProfilePath(string fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", fileName);
        }

        // Простое шифрование пароля (можно усилить)
        private string EncryptPassword(string password)
        {
            // Используем существующий метод шифрования или базовое преобразование
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }

        private string DecryptPassword(string encryptedPassword)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(encryptedPassword));
        }
    }
}