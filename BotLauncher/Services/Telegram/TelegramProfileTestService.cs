using BotLauncher.Models.Telegram;

namespace BotLauncher.Services.Telegram;

public class TelegramProfileTestService
{
    private readonly TelegramProfileManager profileManager;

    public TelegramProfileTestService()
    {
        profileManager =
            new TelegramProfileManager();
    }

    /// <summary>
    /// Выполнить полный тест системы профилей.
    /// </summary>
    public bool RunFullTest()
    {
        Console.WriteLine(
            "========================================");

        Console.WriteLine(
            "НАЧАЛО ПОЛНОГО ТЕСТА TELEGRAM-ПРОФИЛЯ");

        Console.WriteLine(
            "========================================");

        const string profileName =
            "Тестовый Telegram-бот";

        const string password =
            "TestPassword_12345!";

        const string fileName =
            "TestProfile.blp";

        const long botId =
            123456789;

        bool success =
            true;

        Guid originalProfileId =
            Guid.Empty;

        try
        {
            // =================================================
            // 1. Создание профиля
            // =================================================

            Console.WriteLine(
                "\n[1/11] Создание профиля...");

            TelegramProfile profile =
                profileManager.CreateProfile(
                    profileName);

            if (profile == null)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль не создан.");

                return false;
            }

            originalProfileId =
                profile.ProfileId;

            Console.WriteLine(
                $"Профиль создан: {profile.Name}");

            Console.WriteLine(
                $"ProfileId: {profile.ProfileId}");

            // =================================================
            // 2. Проверка базовых данных
            // =================================================

            Console.WriteLine(
                "\n[2/11] Проверка базовых данных...");

            if (profile.ProfileId == Guid.Empty)
            {
                Console.WriteLine(
                    "ОШИБКА: ProfileId пустой.");

                success = false;
            }

            if (profile.Name != profileName)
            {
                Console.WriteLine(
                    "ОШИБКА: имя профиля не совпадает.");

                success = false;
            }

            if (profile.FormatVersion != 1)
            {
                Console.WriteLine(
                    "ОШИБКА: неправильная версия профиля.");

                success = false;
            }

            // =================================================
            // 3. Подготовка текущего профиля
            // =================================================

            Console.WriteLine(
                "\n[3/11] Подготовка профиля...");

            // Создаваемый профиль пока не открыт
            // менеджером автоматически.
            //
            // Поэтому сохраняем его через StorageService
            // отдельно для теста.

            TelegramProfileStorageService storage =
                new TelegramProfileStorageService();

            bool saved =
                storage.Save(
                    profile,
                    password,
                    fileName);

            if (!saved)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль не удалось сохранить.");

                success = false;

                return false;
            }

            Console.WriteLine(
                "Профиль успешно сохранён.");

            // =================================================
            // 4. Проверка существования файла
            // =================================================

            Console.WriteLine(
                "\n[4/11] Проверка файла...");

            if (!storage.Exists(fileName))
            {
                Console.WriteLine(
                    "ОШИБКА: .blp-файл не найден.");

                success = false;
            }
            else
            {
                Console.WriteLine(
                    ".blp-файл существует.");
            }

            // =================================================
            // 5. Открытие профиля
            // =================================================

            Console.WriteLine(
                "\n[5/11] Открытие профиля...");

            bool opened =
                profileManager.OpenProfile(
                    fileName,
                    password);

            if (!opened)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль не удалось открыть.");

                success = false;

                return false;
            }

            Console.WriteLine(
                $"Профиль открыт: " +
                $"{profileManager.CurrentProfile?.Name}");

            // =================================================
            // 6. Проверка ProfileId
            // =================================================

            Console.WriteLine(
                "\n[6/11] Проверка ProfileId...");

            if (profileManager.CurrentProfile ==
                null)
            {
                Console.WriteLine(
                    "ОШИБКА: CurrentProfile равен null.");

                success = false;
            }
            else if (
                profileManager.CurrentProfile.ProfileId
                != originalProfileId)
            {
                Console.WriteLine(
                    "ОШИБКА: ProfileId изменился.");

                success = false;
            }
            else
            {
                Console.WriteLine(
                    "ProfileId сохранён корректно.");
            }

            // =================================================
            // 7. Привязка Telegram-бота
            // =================================================

            Console.WriteLine(
                "\n[7/11] Привязка Telegram-бота...");

            bool bound =
    profileManager.BindBot(
        botId,
        "test_bot",
        "Test Bot",
        "123456789:TEST_TOKEN_FOR_PROFILE_TEST");

            if (!bound)
            {
                Console.WriteLine(
                    "ОШИБКА: бот не привязан.");

                success = false;
            }
            else
            {
                Console.WriteLine(
                    $"Бот привязан. BotId: {botId}");
            }

            // =================================================
            // 8. Проверка правильного BotId
            // =================================================

            Console.WriteLine(
                "\n[8/11] Проверка правильного BotId...");

            bool correctBot =
                profileManager.IsBoundToBot(
                    botId);

            if (!correctBot)
            {
                Console.WriteLine(
                    "ОШИБКА: правильный BotId не распознан.");

                success = false;
            }
            else
            {
                Console.WriteLine(
                    "Правильный BotId успешно подтверждён.");
            }

            // =================================================
            // 9. Проверка неправильного BotId
            // =================================================

            Console.WriteLine(
                "\n[9/11] Проверка чужого BotId...");

            const long anotherBotId =
                987654321;

            bool wrongBot =
                profileManager.IsBoundToBot(
                    anotherBotId);

            if (wrongBot)
            {
                Console.WriteLine(
                    "ОШИБКА: чужой BotId был принят.");

                success = false;
            }
            else
            {
                Console.WriteLine(
                    "Чужой BotId корректно отклонён.");
            }

            // =================================================
            // 10. Проверка неправильного пароля
            // =================================================

            Console.WriteLine(
                "\n[10/11] Проверка неправильного пароля...");

            profileManager.CloseProfile();

            bool wrongPassword =
                profileManager.OpenProfile(
                    fileName,
                    "WrongPassword_123!");

            if (wrongPassword)
            {
                Console.WriteLine(
                    "ОШИБКА: неправильный пароль принят.");

                success = false;
            }
            else
            {
                Console.WriteLine(
                    "Неправильный пароль корректно отклонён.");
            }

            // =================================================
            // 11. Повторное открытие правильным паролем
            // =================================================

            Console.WriteLine(
                "\n[11/11] Повторное открытие профиля...");

            bool reopened =
                profileManager.OpenProfile(
                    fileName,
                    password);

            if (!reopened)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль не открылся " +
                    "после закрытия.");

                success = false;
            }
            else
            {
                TelegramProfile? loadedProfile =
                    profileManager.CurrentProfile;

                if (loadedProfile == null)
                {
                    Console.WriteLine(
                        "ОШИБКА: профиль после загрузки null.");

                    success = false;
                }
                else
                {
                    if (loadedProfile.ProfileId
                        != originalProfileId)
                    {
                        Console.WriteLine(
                            "ОШИБКА: ProfileId после загрузки " +
                            "изменился.");

                        success = false;
                    }

                    if (loadedProfile.Bot.BotId
                        != botId)
                    {
                        Console.WriteLine(
                            "ОШИБКА: BotId после загрузки " +
                            "изменился.");

                        success = false;
                    }

                    if (loadedProfile.Bot.Username
                        != "test_bot")
                    {
                        Console.WriteLine(
                            "ОШИБКА: Username бота " +
                            "после загрузки изменился.");

                        success = false;
                    }

                    if (loadedProfile.Name
                        != profileName)
                    {
                        Console.WriteLine(
                            "ОШИБКА: имя профиля " +
                            "после загрузки изменилось.");

                        success = false;
                    }

                    Console.WriteLine(
                        "Профиль успешно восстановлен.");

                    Console.WriteLine(
                        $"Name: {loadedProfile.Name}");

                    Console.WriteLine(
                        $"ProfileId: " +
                        $"{loadedProfile.ProfileId}");

                    Console.WriteLine(
                        $"BotId: " +
                        $"{loadedProfile.Bot.BotId}");

                    Console.WriteLine(
                        $"Username: " +
                        $"{loadedProfile.Bot.Username}");
                }
            }

            // =================================================
            // Результат
            // =================================================

            Console.WriteLine(
                "\n========================================");

            if (success)
            {
                Console.WriteLine(
                    "ПОЛНЫЙ ТЕСТ УСПЕШНО ПРОЙДЕН");

                Console.WriteLine(
                    "Все проверки завершены без ошибок.");
            }
            else
            {
                Console.WriteLine(
                    "ПОЛНЫЙ ТЕСТ ЗАВЕРШЁН С ОШИБКАМИ");
            }

            Console.WriteLine(
                "========================================");

            return success;
        }
        finally
        {
            // =================================================
            // Очистка тестового профиля
            // =================================================

            profileManager.CloseProfile();

            try
            {
                TelegramProfileStorageService storage =
                    new TelegramProfileStorageService();

                storage.Delete(
                    fileName);

                Console.WriteLine(
                    $"Тестовый файл {fileName} удалён.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Не удалось удалить тестовый файл: " +
                    $"{exception.Message}");
            }
        }
    }
    public bool RunPersistenceTest()
    {
        const string fileName = "PersistenceTest.blp";
        const string password = "PersistencePassword_123!";
        const long botId = 123456789;

        try
        {
            Console.WriteLine("========================================");
            Console.WriteLine("ТЕСТ СОХРАНЕНИЯ И ВОССТАНОВЛЕНИЯ");
            Console.WriteLine("========================================");

            TelegramProfileStorageService storage =
                new TelegramProfileStorageService();

            // =================================================
            // 1. Создаём профиль
            // =================================================

            Console.WriteLine("\n[1] Создание профиля...");

            TelegramProfile profile =
                new TelegramProfile
                {
                    Name = "Мой основной бот"
                };

            profile.Bot.BotId =
                botId;

            profile.Bot.Username =
                "my_test_bot";

            profile.Bot.FirstName =
                "My Test Bot";

            Guid profileId =
                profile.ProfileId;

            // =================================================
            // 2. Сохраняем
            // =================================================

            Console.WriteLine(
                "\n[2] Сохранение профиля...");

            bool saved =
                storage.Save(
                    profile,
                    password,
                    fileName);

            if (!saved)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль не сохранился.");

                return false;
            }

            Console.WriteLine(
                "Профиль сохранён.");

            // =================================================
            // 3. Имитируем закрытие программы
            // =================================================

            Console.WriteLine(
                "\n[3] Имитируем завершение программы...");

            profile = null!;

            storage = null!;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine(
                "Старые объекты профиля уничтожены.");

            // =================================================
            // 4. Создаём новый StorageService
            //
            // Это уже фактически новая сессия приложения.
            // =================================================

            Console.WriteLine(
                "\n[4] Создаём новое хранилище...");

            TelegramProfileStorageService newStorage =
                new TelegramProfileStorageService();

            // =================================================
            // 5. Загружаем профиль
            // =================================================

            Console.WriteLine(
                "\n[5] Загружаем профиль...");

            TelegramProfile? restoredProfile =
                newStorage.Load(
                    password,
                    fileName);

            if (restoredProfile == null)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль не удалось восстановить.");

                return false;
            }

            Console.WriteLine(
                "Профиль успешно восстановлен.");

            // =================================================
            // 6. Проверяем ProfileId
            // =================================================

            Console.WriteLine(
                "\n[6] Проверяем ProfileId...");

            if (restoredProfile.ProfileId != profileId)
            {
                Console.WriteLine(
                    "ОШИБКА: ProfileId изменился.");

                return false;
            }

            Console.WriteLine(
                "ProfileId совпадает.");

            // =================================================
            // 7. Проверяем BotId
            // =================================================

            Console.WriteLine(
                "\n[7] Проверяем BotId...");

            if (restoredProfile.Bot.BotId != botId)
            {
                Console.WriteLine(
                    "ОШИБКА: BotId изменился.");

                return false;
            }

            Console.WriteLine(
                $"BotId восстановлен: " +
                $"{restoredProfile.Bot.BotId}");

            // =================================================
            // 8. Проверяем Username
            // =================================================

            Console.WriteLine(
                "\n[8] Проверяем Username...");

            if (restoredProfile.Bot.Username !=
                "my_test_bot")
            {
                Console.WriteLine(
                    "ОШИБКА: Username изменился.");

                return false;
            }

            Console.WriteLine(
                $"Username восстановлен: " +
                $"@{restoredProfile.Bot.Username}");

            // =================================================
            // 9. Проверяем имя профиля
            // =================================================

            Console.WriteLine(
                "\n[9] Проверяем имя профиля...");

            if (restoredProfile.Name !=
                "Мой основной бот")
            {
                Console.WriteLine(
                    "ОШИБКА: имя профиля изменилось.");

                return false;
            }

            Console.WriteLine(
                $"Имя восстановлено: " +
                $"{restoredProfile.Name}");

            // =================================================
            // 10. Проверяем неправильный пароль
            // =================================================

            Console.WriteLine(
                "\n[10] Проверяем неправильный пароль...");

            TelegramProfile? wrongPasswordProfile =
                newStorage.Load(
                    "CompletelyWrongPassword!",
                    fileName);

            if (wrongPasswordProfile != null)
            {
                Console.WriteLine(
                    "ОШИБКА: неправильный пароль принят.");

                return false;
            }

            Console.WriteLine(
                "Неправильный пароль отклонён.");

            // =================================================
            // 11. Проверяем чужой BotId
            // =================================================

            Console.WriteLine(
                "\n[11] Проверяем чужой BotId...");

            const long anotherBotId =
                987654321;

            bool belongsToAnotherBot =
                restoredProfile.Bot.BotId ==
                anotherBotId;

            if (belongsToAnotherBot)
            {
                Console.WriteLine(
                    "ОШИБКА: профиль принадлежит другому боту.");

                return false;
            }

            Console.WriteLine(
                "Профиль не принадлежит чужому BotId.");

            // =================================================
            // Результат
            // =================================================

            Console.WriteLine(
                "\n========================================");

            Console.WriteLine(
                "ТЕСТ СОХРАНЕНИЯ И ВОССТАНОВЛЕНИЯ ПРОЙДЕН");

            Console.WriteLine(
                "========================================");

            return true;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                "\nОШИБКА ТЕСТА:");

            Console.WriteLine(
                exception.Message);

            return false;
        }
        finally
        {
            try
            {
                TelegramProfileStorageService cleanupStorage =
                    new TelegramProfileStorageService();

                cleanupStorage.Delete(
                    fileName);
            }
            catch
            {
                // Тестовая очистка не должна ломать приложение.
            }
        }
    }
}