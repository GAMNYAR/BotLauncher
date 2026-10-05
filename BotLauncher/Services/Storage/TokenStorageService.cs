using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BotLauncher.Services.Storage
{
    public class TokenStorageService
    {
        private readonly string _tokenFilePath;
        private readonly string _rememberMeFilePath;

        public TokenStorageService()
        {
            string appDataPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "BotLauncher"
            );

            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            _tokenFilePath = Path.Combine(appDataPath, "bot_token.enc");
            _rememberMeFilePath = Path.Combine(appDataPath, "remember_me.txt");
        }

        /// <summary>
        /// Сохранить токен
        /// </summary>
        public void SaveToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) return;

            string encryptedToken = Encrypt(token);
            File.WriteAllText(_tokenFilePath, encryptedToken);
        }

        /// <summary>
        /// Получить сохраненный токен
        /// </summary>
        public string? GetToken()
        {
            if (!File.Exists(_tokenFilePath)) return null;

            try
            {
                string encryptedToken = File.ReadAllText(_tokenFilePath);
                return Decrypt(encryptedToken);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Удалить сохраненный токен
        /// </summary>
        public void DeleteToken()
        {
            if (File.Exists(_tokenFilePath))
            {
                File.Delete(_tokenFilePath);
            }
        }

        /// <summary>
        /// Проверить, стоит ли галочка "Запомнить меня"
        /// </summary>
        public bool IsRememberMeEnabled()
        {
            if (!File.Exists(_rememberMeFilePath)) return false;

            return File.ReadAllText(_rememberMeFilePath) == "true";
        }

        /// <summary>
        /// Установить галочку "Запомнить меня"
        /// </summary>
        public void SetRememberMe(bool enabled)
        {
            File.WriteAllText(_rememberMeFilePath, enabled.ToString().ToLower());
        }

        /// <summary>
        /// Простое шифрование токена
        /// </summary>
        private string Encrypt(string text)
        {
            using (var aes = Aes.Create())
            {
                string key = "BotLauncherSecretKey2024!"; // Можно усложнить
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
                aes.IV = new byte[16];

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(text);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        /// <summary>
        /// Расшифровка токена
        /// </summary>
        private string Decrypt(string encryptedText)
        {
            using (var aes = Aes.Create())
            {
                string key = "BotLauncherSecretKey2024!";
                aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
                aes.IV = new byte[16];

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (var ms = new MemoryStream(Convert.FromBase64String(encryptedText)))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}