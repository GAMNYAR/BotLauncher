using BotLauncher.Services;
using BotLauncher.Services.Settings;
using BotLauncher.Services.Telegram;

namespace BotLauncher.Shared.Services
{
    public static class AppServices
    {
        public static SettingsService Settings { get; }
            = new SettingsService();

        public static TelegramStorageService TelegramStorage { get; }
            = new TelegramStorageService();

        public static TelegramGroupsService TelegramGroups { get; }
            = new TelegramGroupsService();

        public static TelegramBotService TelegramBot { get; }
            = new TelegramBotService();

        public static TelegramProfileStorageService TelegramProfileStorage { get; }
            = new TelegramProfileStorageService();

        public static TelegramProfileManager TelegramProfileManager { get; }
            = new TelegramProfileManager();
    }
}