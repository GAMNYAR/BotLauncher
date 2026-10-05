using System.Text;

namespace BotLauncher.Services.Profile;

public static class ProfileValidationService
{
    // =========================================================
    // Ограничения
    // =========================================================

    public const int MinProfileNameLength = 3;
    public const int MaxProfileNameLength = 64;

    public const int MinPasswordLength = 5;  // <-- ИЗМЕНЕНО: было 10
    public const int MaxPasswordLength = 128;

    // =========================================================
    // Проверка имени профиля
    // =========================================================

    public static bool ValidateProfileName(
        string? profileName,
        out string errorMessage)
    {
        errorMessage = string.Empty;

        if (string.IsNullOrWhiteSpace(profileName))
        {
            errorMessage =
                "Введите название профиля.";

            return false;
        }

        string value =
            profileName.Trim();

        if (value.Length <
            MinProfileNameLength)
        {
            errorMessage =
                $"Название профиля должно содержать " +
                $"не менее {MinProfileNameLength} символов.";

            return false;
        }

        if (value.Length >
            MaxProfileNameLength)
        {
            errorMessage =
                $"Название профиля не должно содержать " +
                $"более {MaxProfileNameLength} символов.";

            return false;
        }

        foreach (char character in value)
        {
            if (char.IsControl(character))
            {
                errorMessage =
                    "Название профиля содержит недопустимые символы.";

                return false;
            }
        }

        return true;
    }

    // =========================================================
    // Нормализация имени профиля
    // =========================================================

    public static string NormalizeProfileName(
        string profileName)
    {
        if (profileName == null)
            return string.Empty;

        string value =
            profileName.Trim();

        StringBuilder builder =
            new StringBuilder();

        bool previousWasWhitespace = false;

        foreach (char character in value)
        {
            if (char.IsControl(character))
                continue;

            if (char.IsWhiteSpace(character))
            {
                if (previousWasWhitespace)
                    continue;

                builder.Append(' ');

                previousWasWhitespace = true;

                continue;
            }

            builder.Append(character);

            previousWasWhitespace = false;
        }

        return builder
            .ToString()
            .Trim();
    }

    // =========================================================
    // Проверка пароля
    // =========================================================

    public static bool ValidatePassword(
        string? password,
        out string errorMessage)
    {
        errorMessage = string.Empty;

        if (string.IsNullOrEmpty(password))
        {
            errorMessage =
                "Введите пароль.";

            return false;
        }

        if (password.Length <
            MinPasswordLength)
        {
            errorMessage =
                $"Пароль должен содержать " +
                $"не менее {MinPasswordLength} символов.";

            return false;
        }

        if (password.Length >
            MaxPasswordLength)
        {
            errorMessage =
                $"Пароль не должен содержать " +
                $"более {MaxPasswordLength} символов.";

            return false;
        }

        if (char.IsWhiteSpace(password[0]) ||
            char.IsWhiteSpace(
                password[password.Length - 1]))
        {
            errorMessage =
                "Пароль не должен начинаться или заканчиваться пробелом.";

            return false;
        }

        foreach (char character in password)
        {
            if (char.IsControl(character))
            {
                errorMessage =
                    "Пароль содержит недопустимые управляющие символы.";

                return false;
            }
        }

        return true;
    }

    // =========================================================
    // Проверка подтверждения пароля
    // =========================================================

    public static bool ValidatePasswordConfirmation(
        string password,
        string confirmation,
        out string errorMessage)
    {
        errorMessage = string.Empty;

        if (!ValidatePassword(
                password,
                out errorMessage))
        {
            return false;
        }

        if (confirmation != password)
        {
            errorMessage =
                "Пароли не совпадают.";

            return false;
        }

        return true;
    }

    // =========================================================
    // Проверка Bot ID
    // =========================================================

    public static bool ValidateBotId(
        long botId)
    {
        return botId > 0;
    }

    // =========================================================
    // Нормализация username
    // =========================================================

    public static string NormalizeBotUsername(
        string? username)
    {
        if (string.IsNullOrWhiteSpace(username))
            return string.Empty;

        return username
            .Trim()
            .TrimStart('@');
    }

    // =========================================================
    // Нормализация имени бота
    // =========================================================

    public static string NormalizeBotFirstName(
        string? firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            return string.Empty;

        return firstName.Trim();
    }
}