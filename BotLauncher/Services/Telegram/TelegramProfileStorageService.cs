using BotLauncher.Models.Telegram;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace BotLauncher.Services.Telegram;

public class TelegramProfileStorageService
{
    private const long MaxProfileFileSize = 10 * 1024 * 1024; // 10 MB

    private readonly TelegramProfileCryptoService crypto;
    private readonly string dataFolder;

    private readonly JsonSerializerOptions jsonOptions = new()
    {
        WriteIndented = false
    };

    public TelegramProfileStorageService()
    {
        crypto = new TelegramProfileCryptoService();
        dataFolder = Path.Combine(Application.StartupPath, "Data");
        EnsureDataFolder();
    }

    private void EnsureDataFolder()
    {
        if (!Directory.Exists(dataFolder))
        {
            Directory.CreateDirectory(dataFolder);
        }
    }

    public List<string> GetProfileFileNames()
    {
        List<string> profiles = new();
        try
        {
            EnsureDataFolder();
            string[] files = Directory.GetFiles(dataFolder, "*.blp", SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                FileInfo fileInfo = new(file);
                if (fileInfo.Length > 0 && fileInfo.Length <= MaxProfileFileSize)
                {
                    profiles.Add(fileInfo.Name);
                }
            }
            profiles.Sort(StringComparer.OrdinalIgnoreCase);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Ошибка получения списка профилей: {exception.Message}");
        }
        return profiles;
    }

    private string NormalizeFileName(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
            throw new ArgumentException("Имя файла не может быть пустым.", nameof(fileName));

        string name = Path.GetFileName(fileName.Trim());
        if (!name.EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
        {
            name += ".blp";
        }
        return name;
    }

    public string GetProfilePath(string fileName)
    {
        return Path.Combine(dataFolder, NormalizeFileName(fileName));
    }

    // =========================================================
    // Сохранение (с незашифрованным заголовком)
    // =========================================================
    public bool Save(TelegramProfile profile, string password, string fileName)
    {
        if (profile == null || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fileName))
            return false;

        string? temporaryFilePath = null;
        byte[]? plainData = null;

        try
        {
            EnsureDataFolder();

            if (profile.ProfileId == Guid.Empty)
                profile.ProfileId = Guid.NewGuid();

            if (profile.Bot == null)
                profile.Bot = new TelegramProfileBot();

            profile.UpdatedAt = DateTime.UtcNow;

            // 1. Сериализуем и шифруем основное тело
            string json = JsonSerializer.Serialize(profile, jsonOptions);
            plainData = Encoding.UTF8.GetBytes(json);
            byte[] encryptedData = crypto.Encrypt(password, plainData);

            // 2. Создаем незашифрованный заголовок
            var header = new TelegramProfileHeader
            {
                FormatVersion = profile.FormatVersion,
                ProfileName = profile.Name,
                BotUsername = profile.Bot.Username ?? string.Empty
            };
            string headerJson = JsonSerializer.Serialize(header, jsonOptions);
            byte[] headerBytes = Encoding.UTF8.GetBytes(headerJson);

            // 3. Собираем файл: [Длина заголовка (4 байта)] + [Заголовок] + [Зашифрованные данные]
            using var ms = new MemoryStream();
            using var writer = new BinaryWriter(ms);

            writer.Write(headerBytes.Length); // 4 байта (Int32)
            writer.Write(headerBytes);
            writer.Write(encryptedData);

            string filePath = GetProfilePath(fileName);
            temporaryFilePath = filePath + ".tmp";

            File.WriteAllBytes(temporaryFilePath, ms.ToArray());
            File.Move(temporaryFilePath, filePath, true);

            return true;
        }
        catch (Exception exception)
        {
            System.Diagnostics.Debug.WriteLine($"[Storage.Save] Ошибка: {exception.Message}");
            if (temporaryFilePath != null)
                TryDeleteFile(temporaryFilePath);
            return false;
        }
        finally
        {
            if (plainData != null)
                CryptographicOperations.ZeroMemory(plainData);
        }
    }

    // =========================================================
    // Загрузка (Публичный метод: принимает имя файла)
    // =========================================================
    public TelegramProfile? Load(string password, string fileName)
    {
        string fullPath = GetProfilePath(fileName);
        return LoadFromFile(password, fullPath);
    }

    // =========================================================
    // Загрузка (Внутренний метод: принимает полный путь, поддерживает оба формата)
    // =========================================================
    private TelegramProfile? LoadFromFile(string password, string fullPath)
    {
        if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullPath))
            return null;

        if (!File.Exists(fullPath))
            return null;

        try
        {
            byte[] fileBytes = File.ReadAllBytes(fullPath);

            // Проверяем формат файла
            if (fileBytes.Length < 4)
                return null;

            // Пробуем прочитать как новый формат (с заголовком)
            using var ms = new MemoryStream(fileBytes);
            using var reader = new BinaryReader(ms);

            int headerLength = reader.ReadInt32();

            // Если заголовок разумного размера — это новый формат
            if (headerLength > 0 && headerLength < 1024 && ms.Length > headerLength + 4)
            {
                // Новый формат: пропускаем заголовок и читаем зашифрованное тело
                byte[] headerBytes = reader.ReadBytes(headerLength);
                byte[] encryptedData = reader.ReadBytes((int)(ms.Length - ms.Position));

                byte[] plainData = crypto.Decrypt(password, encryptedData);

                try
                {
                    string json = Encoding.UTF8.GetString(plainData);
                    TelegramProfile? profile = JsonSerializer.Deserialize<TelegramProfile>(json, jsonOptions);

                    return ValidateLoadedProfile(profile) ? profile : null;
                }
                finally
                {
                    CryptographicOperations.ZeroMemory(plainData);
                }
            }
            else
            {
                // Старый формат: весь файл зашифрован
                byte[] encryptedData = fileBytes;
                byte[] plainData = crypto.Decrypt(password, encryptedData);

                try
                {
                    string json = Encoding.UTF8.GetString(plainData);
                    TelegramProfile? profile = JsonSerializer.Deserialize<TelegramProfile>(json, jsonOptions);

                    return ValidateLoadedProfile(profile) ? profile : null;
                }
                finally
                {
                    CryptographicOperations.ZeroMemory(plainData);
                }
            }
        }
        catch (CryptographicException)
        {
            return null; // Неверный пароль
        }
        catch
        {
            return null;
        }
    }

    // =========================================================
    // Чтение заголовка (поддерживает только новый формат)
    // =========================================================
    public TelegramProfileHeader? ReadHeader(string fullPath)
    {
        if (string.IsNullOrWhiteSpace(fullPath) || !File.Exists(fullPath))
            return null;

        try
        {
            byte[] fileBytes = File.ReadAllBytes(fullPath);

            if (fileBytes.Length < 4)
                return null;

            using var ms = new MemoryStream(fileBytes);
            using var reader = new BinaryReader(ms);

            int headerLength = reader.ReadInt32();

            // Проверяем, что это разумный заголовок
            if (headerLength <= 0 || headerLength > 1024 || fileBytes.Length < headerLength + 4)
            {
                // Это старый формат файла — заголовка нет
                return null;
            }

            byte[] headerBytes = reader.ReadBytes(headerLength);
            string headerJson = Encoding.UTF8.GetString(headerBytes);

            return JsonSerializer.Deserialize<TelegramProfileHeader>(headerJson, jsonOptions);
        }
        catch
        {
            return null; // Старый формат файла или поврежден
        }
    }

    private bool ValidateLoadedProfile(TelegramProfile? profile)
    {
        if (profile == null) return false;
        if (profile.FormatVersion != 1) return false;
        if (profile.ProfileId == Guid.Empty) return false;
        if (string.IsNullOrWhiteSpace(profile.Name)) return false;
        if (profile.Bot == null) return false;
        if (profile.Bot.BotId <= 0) return false;
        if (string.IsNullOrWhiteSpace(profile.Bot.Token)) return false;

        return true;
    }

    public bool Exists(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName)) return false;
        try { return File.Exists(GetProfilePath(fileName)); }
        catch { return false; }
    }

    public bool Delete(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName)) return false;
        try
        {
            string filePath = GetProfilePath(fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;
            }
            return false;
        }
        catch { return false; }
    }

    private static void TryDeleteFile(string filePath)
    {
        try { if (File.Exists(filePath)) File.Delete(filePath); }
        catch { }
    }

    // =========================================================
    // Проверка пароля (поддерживает оба формата)
    // =========================================================
    public bool VerifyPasswordByPath(string password, string fullPath)
    {
        // ИСПРАВЛЕНО: вызываем LoadFromFile вместо Load
        return LoadFromFile(password, fullPath) != null;
    }

    public string GetFileHash(string filePath)
    {
        using var sha256 = System.Security.Cryptography.SHA256.Create();
        using var stream = File.OpenRead(filePath);
        byte[] hash = sha256.ComputeHash(stream);
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }

    public string? GetProfileNameFromFile(string password, string fullPath)
    {
        // ИСПРАВЛЕНО: вызываем LoadFromFile вместо Load
        var profile = LoadFromFile(password, fullPath);
        return profile?.Name;
    }
}