# Реконструкция кода BotLauncher

Аудит и план рефакторинга репозитория **BotLauncher** (C#, .NET 8, WinForms, `net8.0-windows`).
Дата аудита: 2026-11-03. Основа: ветка `qwen-code-*` (идентична `main`, 1 коммит в истории).

---

## 1. Что представляет собой проект

Мощный десктопный инструмент для автоматизации Telegram-ботов: подключение бота по токену,
управление группами/каналами, шаблонами сообщений, авто/ручная/отложенная/периодическая/по
расписанию отправка, профильная система с шифрованием (PBKDF2+AES), визуальный редактор
сценариев на WebView2 (JS-канвас), парсинг YouTube.

### Структура и объёмы

| Область | Содержимое | Объём |
|---|---|---|
| `BotLauncher/Services/Telegram` | 21 файл: API, поллинг, бот-сервис, группы, шаблоны, профили, отправители, хранилища | ~7 000 строк |
| `BotLauncher/Controls` | ~60 файлов: вкладки отправки, события групп, настройки, шаблоны (много Designer.cs > 1000 строк) | UI-слой |
| `BotLauncher/Pages`, `Forms` | mainForm, SplashScreen-страницы авторизации профиля | UI-слой |
| `BotLauncher/Models` | DTO/модели (Telegram, Profile, Bot) | модели |
| `BotLauncher/Resources/ScenarioEditor` | веб-редактор сценариев (js/css/html) | ~4 000 строк JS |
| `_backup/ScenarioEditor_backup_2026` | дубликат редактора в корне репозитория | мёртвый код |

Точка входа одна: `Program.Main` → `mainForm`. DI-контейнер (`Microsoft.Extensions.Hosting`)
заявлен в зависимостях, но **не используется** — всё построено через статический локатор
`AppServices`.

---

## 2. Выявленные проблемы (подтверждены поиском по коду)

### 2.1 Критично — безопасность

1. **Хардкодный AES-ключ токена бота** — `Services/Storage/TokenStorageService.cs`:
   ```csharp
   string key = "BotLauncherSecretKey2024!"; // Можно усложнить
   aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
   aes.IV = new byte[16];   // IV = нули, детерминированное шифрование
   ```
   Токен, зашифрованный нулевым IV и извлечённым из строки ключом, фактически лежит в
   `%APPDATA%\BotLauncher\bot_token.enc` в открытом виде для любого, кто соберёт тот же XOR/AES.
   **Замена:** `ProtectedData` (DPAPI, CurrentUser) или AES-GCM с случайным IV + ключ из
   DPAPI/Windows Credential Manager.

2. **Токен пишется в лог**: `TelegramApi.Initialize` логирует `token.Substring(0, 10)` в
   `bot_debug.log`. Логируются и внутренние детали профилей. **Замена:** маскировать секреты.

3. **Токен хранится открытым JSON** в `Data/telegram_settings.json` (`TelegramSettings.BotToken`),
   параллельно с «зашифрованным» хранилищем — два конкурирующих механизма хранения одних данных.

### 2.2 Критично — состояние и архитектура

4. **Статический локатор + дублирование синглтонов.** `AppServices` создаёт общие экземпляры
   (`TelegramBotService`, `TelegramProfileManager`), но они же создаются заново через `new`:
   - `TelegramBotService` сам делает `new TelegramProfileManager()` (поле `profileManager`), игнорируя `AppServices.TelegramProfileManager`;
   - `TelegramProfileTestService`, `SuccessPage`, `PasswordPage`, `ImportProfilePage`,
     `ProfileListPage` — каждый создаёт свой `TelegramProfileManager`;
   - `BotConnectPage` создаёт отдельный `new TelegramBotService()`.
   Следствие: несколько экземпляров с независимым состоянием подключения/профиля; события
   подписаны только на одном из них; рассинхрон состояния между страницами.
   **Замена:** единый DI-контейнер (`Host.CreateDefaultBuilder` уже в зависимостях) либо
   гарантированно один экземпляр через `AppServices`.

5. **Глобальное mutable-состояние запуска**: `public static bool Program.BotConnectedAtStartup`
   читается в `MainForm_Load`. Заменить на результат сервиса подключения.

6. **Самоподключение синглтонов**: `TelegramBotService` в инициализаторе поля ссылается на
   `AppServices.TelegramGroups` — скрытая циклическая зависимость от порядка статической инициализации.

### 2.3 Высокий приоритет — надёжность

7. **~37 «глухих» catch** (`catch { }`, `catch` без логирования), в т.ч. пустой catch вокруг
   всего автоподключения в `Program.Main` — ошибки проглатываются молча.

8. **Самодельное логирование дублируется в 6+ местах**: идентичные приватные `static Log(...)`
   в `TelegramApi`, `TelegramBotService`, `TelegramManualSender`, `TelegramAutoSender`,
   `ManualTabControl`, `TelegramGroupsControl` пишут в один файл `bot_debug.log` без блокировки —
   гонка при конкурентной записи. **NLog 6.2.1 подключён как пакет, но не используется ни в одном файле.**
   **Замена:** единый `ILogger`/NLog, конфигурация rolling-file, удалить все самописные Log().

9. **Блокирующий wait в UI-потоке при старте**: `connectTask.Wait(TimeSpan.FromSeconds(5))` в
   `Program.Main` — потенциальные deadlock/зависание splash.

### 2.4 Средний приоритет — чистота

10. **Мёртвые классы**:
    - `Services/Telegram/TelegramService.cs` — не инстанцируется нигде (все используют `TelegramBotService`); содержит подозрительный using `BotLauncher.Models.BotLauncher.Models` (артефакт неверного namespace у `BotSettings`).
    - `Services/YouTube/YouTubeService.cs` — пустая заглушка `{ }`.

11. **Неиспользуемые NuGet-пакеты** (проверено grep'ом по `.cs`/`.resx` — 0 употреблений):
    MediatR, AutoMapper, FluentValidation, MailKit, QuestPDF, ClosedXML, Cronos, Polly,
    DesktopNotifications, Humanizer, TimeZoneConverter, SixLabors.ImageSharp, SkiaSharp,
    SunnyUI, Krypton.Toolkit, System.IdentityModel.Tokens.Jwt, DotNetEnv, CommunityToolkit.Mvvm,
    Bunifu.UI.WinForms. Также Microsoft.Extensions.* (Hosting/DI) — не используются.
    Это раздувает установщик (Costura вшивает все DLL в exe). **Удалить непроверяемые пакеты после контрольной сборки.**

12. **Дубликаты ресурсов**: `Resources/xmark-solid.png` vs `xmark_solid.png` vs `xmark-solid-red.png`
    vs `xmark_solid_red.png` vs `xmark-solid -red.png` vs `xmark_solid_dark_red.png`; аналогично
    `circle_green/green/red`, `plus-solid (1)/(2)`, `icons8-*` и т.д. Имена с пробелами/скобками/кириллицей.

13. **csproj ссылается на несуществующую папку `WebEditor/**`** (13 записей CopyToOutputDirectory) —
    реальная папка: `Resources/ScenarioEditor`. Мусор в проекте.

14. **`_backup/ScenarioEditor_backup_2026/`** — полная копия редактора в git; перенести в history/releases, удалить из рабочего дерева.

15. **Нарушения стиля/соглашений**: класс формы `mainForm` (строчная буква, файл `MainForm.cs`);
    публичные поля вместо свойств (`Program.BotConnectedAtStartup`); смешение file-scoped и
    block-scoped namespace; часть сервисов `internal`, часть `public` без причины;
    `SixLaborsLicenseKey=FREE_NON_COMMERCIAL` — лицензионное ограничение ImageSharp (и его можно просто удалить, см. п. 11).

16. **TODO в боевом коде**: `TemplateTagService.cs:69-70` подставляет hardcoded `"GAMNYAR"` /
    `"123456789"` вместо данных профиля — пользователи получат некорректную персонализацию.

17. **Двойное хранение настроек**: JSON-файлы (`TelegramStorageService`, `TelegramSettingsService`)
    и LiteDB (`LiteDbSettingsStorage`) без единого абстрактного слоя `ISettingsStorage`.

---

## 3. План рефакторинга (порядок шагов)

### Фаза 0 — страховка
- Завести базовый зелёный коммит; далее — маленькие PR-шаги, поведение не менять без тестов.
- Собрать проект на Windows (`net8.0-windows` вне Windows не собирается) и зафиксировать снимок поведения.

### Фаза 1 — безопасность (самая высокая ценность, малые диффы)
1. `TokenStorageService` → DPAPI (`ProtectedData.Protect(..., DataProtectionScope.CurrentUser)`)
   или AES-GCM + случайный IV; миграция существующего `bot_token.enc` (попробовать прочитать старым способом → переписать новым).
2. Убрать токены/секреты из логов (`TelegramApi.Initialize`).
3. Единообразие: `telegram_settings.json` не хранит токен — только ссылка на защищённое хранилище.

### Фаза 2 — composition root и состояние
4. Внедрить DI: `Host.CreateDefaultBuilder()` в `Program.cs`, регистрации singleton'ов
   (`TelegramApi`, `TelegramBotService`, `TelegramProfileManager`, сервисы, формы/страницы).
   Удалить `AppServices` (или оставить тонким фасадом на время перехода).
5. Устранить все `new TelegramProfileManager()` / `new TelegramBotService()` в страницах — только инъекция.
6. Убрать `Program.BotConnectedAtStartup` — состояние подключения читается из `ITelegramBotService`.

### Фаза 3 — наблюдаемость и обработка ошибок
7. Единый NLog (rolling file, уровни); удалить 6 копий `Log()`; запретить пустые catch
   (анализатор or grep-ворота CI): каждый `catch` — лог + осмысленное поведение.
8. Автоподключение в `Program.Main` — async-запуск без `.Wait()` (например, подключение
   инициирует MainForm асинхронно, splash показывает прогресс).

### Фаза 4 — удаление мёртвого кода и чистка проекта
9. Удалить `TelegramService.cs`, `YouTubeService.cs` (заглушку), `_backup/`, ссылки csproj на `WebEditor/*`.
10. Ревизия NuGet: удалить неподтверждённые пакеты (список п. 11), пересобрать, проверить рантайм.
11. Дедупликация ресурсов PNG, переименование без пробелов/кириллицы; обновить ссылки.
12. Реализовать TODO в `TemplateTagService` (данные пользователя из активного профиля)
    либо явно убрать теги из UI, пока не реализовано.

### Фаза 5 — структурные улучшения (по желанию)
13. Разделить God-контролы: `ManualTabControl.cs` (1243 стр.) и Designer-файлы >1000 строк —
    вынести блоки UI в дочерние композитные контролы.
14. Абстракция хранилища: `ISettingsStorage` c реализациями Json/LiteDB за одним интерфейсом;
    выбрать одну основную (LiteDB) и мигрировать.
15. Соглашения: `mainForm` → `MainForm`, `internal/public` единообразно, file-scoped namespaces,
    `record`/`init` для DTO.
16. Тесты: unit-тесты на `TemplateTagService`, `TelegramProfileCryptoService` (round-trip),
    `LiteDbSettingsStorage`; интеграционные — c моком `TelegramApi`.

---

## 4. Ожидаемый эффект

- Секреты пользователей перестают быть легко читаемыми; исчезает детерминированное шифрование.
- Одно источник истины о подключении/профиле → уходит рассинхрон состояния между страницами.
- Установщик легче (Costura: минус до 19 неиспользуемых библиотек).
- Наблюдаемость: единый структурированный лог вместо 6Writer'ов в один файл с гонкой.
- Кодовая база сокращается на мёртвые классы, бэкап-дубликат и дубли ресурсов без изменения поведения.

## 5. Ограничения текущего окружения

Сборка/прогон невозможны здесь: целевой фреймворк `net8.0-windows` требует Windows, SDK в контейнере отсутствует. Все выводы получены статическим анализом исходников; перед удалением пакетов обязателен контрольный `dotnet build` + smoke-test на Windows.
