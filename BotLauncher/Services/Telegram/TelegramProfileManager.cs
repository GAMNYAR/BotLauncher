using BotLauncher.Models.Telegram;
using BotLauncher.Services.Profile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace BotLauncher.Services.Telegram;

public class TelegramProfileManager
{
    private readonly TelegramProfileStorageService storage;

    // =========================================================
    // Текущий профиль
    // =========================================================

    public TelegramProfile? CurrentProfile
    {
        get;
        private set;
    }

    // =========================================================
    // Текущий файл
    // =========================================================

    public string? CurrentFileName
    {
        get;
        private set;
    }

    // =========================================================
    // Пароль
    // =========================================================

    private string? currentPassword;

    // =========================================================
    // Состояние
    // =========================================================

    public bool IsProfileOpen =>
        CurrentProfile != null &&
        !string.IsNullOrWhiteSpace(CurrentFileName) &&
        !string.IsNullOrEmpty(currentPassword);

    // =========================================================
    // Constructor
    // =========================================================

    public TelegramProfileManager()
    {
        storage = new TelegramProfileStorageService();
    }

    // =========================================================
    // Создание
    // =========================================================

    public TelegramProfile CreateProfile(string name)
    {
        if (!ProfileValidationService.ValidateProfileName(name, out string errorMessage))
        {
            throw new ArgumentException(errorMessage, nameof(name));
        }

        TelegramProfile profile = new TelegramProfile
        {
            ProfileId = Guid.NewGuid(),
            Name = ProfileValidationService.NormalizeProfileName(name),
            FormatVersion = 1,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Bot = new TelegramProfileBot()
        };

        CurrentProfile = profile;
        CurrentFileName = null;
        currentPassword = null;

        return profile;
    }

    // =========================================================
    // Первичное сохранение
    // =========================================================

    public bool CreateAndSaveProfile(string fileName, string password)
    {
        // Проверка 1: CurrentProfile
        if (CurrentProfile == null)
        {
            return false;
        }

        // Проверка 2: Пароль
        if (!ValidatePassword(password))
        {
            return false;
        }

        // Проверка 3: Имя файла
        if (!ValidateFileName(fileName))
        {
            return false;
        }

        // Проверка 4: Bot
        if (CurrentProfile.Bot == null)
        {
            return false;
        }

        // Проверка 5: BotId
        if (CurrentProfile.Bot.BotId <= 0)
        {
            return false;
        }

        // Проверка 6: Token
        if (string.IsNullOrWhiteSpace(CurrentProfile.Bot.Token))
        {
            return false;
        }

        // Попытка сохранения
        try
        {
            bool saved = storage.Save(CurrentProfile, password, fileName);

            if (!saved)
            {
                return false;
            }

            CurrentFileName = fileName.Trim();

            if (!CurrentFileName.EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
            {
                CurrentFileName += ".blp";
            }

            currentPassword = password;

            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }

    // =========================================================
    // Открытие
    // =========================================================

    public bool OpenProfile(string fileName, string password)
    {
        if (!ValidatePassword(password))
            return false;

        if (!ValidateFileName(fileName))
            return false;

        TelegramProfile? profile = storage.Load(password, fileName);

        if (profile == null)
            return false;

        if (profile.Bot == null)
        {
            profile.Bot = new TelegramProfileBot();
        }

        CurrentProfile = profile;
        CurrentFileName = fileName.Trim();

        if (!CurrentFileName.EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
        {
            CurrentFileName += ".blp";
        }

        currentPassword = password;

        return true;
    }

    // =========================================================
    // Сохранение
    // =========================================================

    public bool Save()
    {
        if (!IsProfileOpen)
            return false;

        return storage.Save(CurrentProfile!, currentPassword!, CurrentFileName!);
    }

    // =========================================================
    // Save As
    // =========================================================

    public bool SaveAs(string fileName)
    {
        if (CurrentProfile == null)
            return false;

        if (string.IsNullOrEmpty(currentPassword))
        {
            return false;
        }

        if (!ValidateFileName(fileName))
            return false;

        bool saved = storage.Save(CurrentProfile, currentPassword, fileName);

        if (!saved)
            return false;

        CurrentFileName = fileName.Trim();

        if (!CurrentFileName.EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
        {
            CurrentFileName += ".blp";
        }

        return true;
    }

    // =========================================================
    // Переименование профиля
    // =========================================================

    public bool RenameProfile(string name)
    {
        if (CurrentProfile == null)
            return false;

        if (!ProfileValidationService.ValidateProfileName(name, out _))
        {
            return false;
        }

        CurrentProfile.Name = ProfileValidationService.NormalizeProfileName(name);

        return Save();
    }

    // =========================================================
    // Привязка Telegram-бота
    // =========================================================

    public bool BindBot(long botId, string username, string firstName, string token)
    {
        if (CurrentProfile == null)
        {
            return false;
        }

        if (!ProfileValidationService.ValidateBotId(botId))
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(token))
        {
            return false;
        }

        if (CurrentProfile.Bot == null)
        {
            CurrentProfile.Bot = new TelegramProfileBot();
        }

        CurrentProfile.Bot.BotId = botId;
        CurrentProfile.Bot.Username = ProfileValidationService.NormalizeBotUsername(username);
        CurrentProfile.Bot.FirstName = ProfileValidationService.NormalizeBotFirstName(firstName);
        CurrentProfile.Bot.Token = token.Trim();
        CurrentProfile.UpdatedAt = DateTime.UtcNow;

        return true;
    }

    // =========================================================
    // Проверка привязки
    // =========================================================

    public bool IsBoundToBot(long botId)
    {
        if (CurrentProfile == null)
            return false;

        if (CurrentProfile.Bot == null)
            return false;

        if (botId <= 0)
            return false;

        return CurrentProfile.Bot.BotId == botId;
    }

    // =========================================================
    // Получить Bot ID
    // =========================================================

    public long GetBoundBotId()
    {
        if (CurrentProfile == null)
            return 0;

        if (CurrentProfile.Bot == null)
            return 0;

        return CurrentProfile.Bot.BotId;
    }

    // =========================================================
    // Получить Bot Token
    // =========================================================

    public string GetBoundBotToken()
    {
        if (CurrentProfile == null)
            return string.Empty;

        if (CurrentProfile.Bot == null)
            return string.Empty;

        return CurrentProfile.Bot.Token;
    }

    // =========================================================
    // Закрытие
    // =========================================================

    public void CloseProfile()
    {
        CurrentProfile = null;
        CurrentFileName = null;
        currentPassword = null;
    }

    // =========================================================
    // Получение списка профилей
    // =========================================================

    public List<string> GetProfileFileNames()
    {
        return storage.GetProfileFileNames();
    }

    // =========================================================
    // Проверка существования
    // =========================================================

    public bool ProfileExists(string fileName)
    {
        if (!ValidateFileName(fileName))
            return false;

        return storage.Exists(fileName);
    }

    // =========================================================
    // Удаление
    // =========================================================

    public bool DeleteCurrentProfile()
    {
        if (string.IsNullOrWhiteSpace(CurrentFileName))
        {
            return false;
        }

        string fileName = CurrentFileName;

        bool deleted = storage.Delete(fileName);

        if (deleted)
        {
            CloseProfile();
        }

        return deleted;
    }

    // =========================================================
    // Проверка пароля (для импорта)
    // =========================================================

    public bool VerifyPassword(string filePath, string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            return false;

        if (string.IsNullOrWhiteSpace(filePath))
            return false;

        return storage.VerifyPasswordByPath(password, filePath);
    }

    // =========================================================
    // Получить имя профиля из файла (для импорта)
    // =========================================================
    public string? GetProfileNameFromFile(string filePath, string password)
    {
        if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(filePath))
            return null;

        return storage.GetProfileNameFromFile(password, filePath);
    }

    // =========================================================
    // НОВЫЙ МЕТОД: Получить Username бота БЕЗ пароля (из заголовка)
    // =========================================================
    public string GetBotUsernameFromFile(string filePath)
    {
        try
        {
            var header = storage.ReadHeader(filePath);
            if (header != null && !string.IsNullOrWhiteSpace(header.BotUsername))
            {
                return $"@{header.BotUsername}";
            }
        }
        catch
        {
            // Игнорируем ошибки чтения
        }

        return "@unknown"; // Заглушка, если файл старый или поврежден
    }

    // =========================================================
    // Получить хеш файла
    // =========================================================
    public string GetFileHash(string filePath)
    {
        return storage.GetFileHash(filePath);
    }

    // =========================================================
    // Проверка пароля
    // =========================================================

    private static bool ValidatePassword(string? password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            return false;
        }

        return ProfileValidationService.ValidatePassword(password, out _);
    }

    // =========================================================
    // Валидация имени файла
    // =========================================================

    private static bool ValidateFileName(string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return false;
        }

        string name = Path.GetFileName(fileName.Trim());

        if (string.IsNullOrWhiteSpace(name))
        {
            return false;
        }

        if (!name.EndsWith(".blp", StringComparison.OrdinalIgnoreCase))
        {
            name += ".blp";
        }

        string withoutExtension = Path.GetFileNameWithoutExtension(name);

        if (string.IsNullOrWhiteSpace(withoutExtension))
        {
            return false;
        }

        if (withoutExtension.Length > 64)
        {
            return false;
        }

        return true;
    }
}