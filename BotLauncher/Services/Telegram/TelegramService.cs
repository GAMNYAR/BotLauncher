using BotLauncher.Models;
using BotLauncher.Models.BotLauncher.Models;
using Telegram.Bot;

namespace BotLauncher.Services.Telegram
{
    internal class TelegramService
    {
        private readonly TelegramBotClient bot;

        public TelegramService(BotSettings settings)
        {
            bot = new TelegramBotClient(settings.BotToken);
        }
        public async Task<bool> CheckBotAsync()
        {
            try
            {
                var me = await bot.GetMe();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task SendMessageAsync(string chatId, string message)
        {
            await bot.SendMessage(
                chatId: chatId,
                text: message);
        }
    }
}
