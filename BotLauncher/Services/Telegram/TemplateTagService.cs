using System;
using System.Collections.Generic;
using System.Linq;
using BotLauncher.Models.Telegram;
using BotLauncher.Services.Telegram;

namespace BotLauncher.Services.Telegram
{
    public class TemplateTagService
    {
        private readonly TelegramBotService _botService;
        private readonly TelegramGroupsService _groupsService;

        public TemplateTagService(TelegramBotService botService, TelegramGroupsService groupsService)
        {
            _botService = botService;
            _groupsService = groupsService;
        }

        /// <summary>
        /// Заменить все теги в тексте на реальные значения
        /// </summary>
        public string ReplaceTags(string text, TelegramTemplate? template = null)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var result = text;

            // Теги бота
            if (_botService.IsConnected && _botService.BotInfo != null)
            {
                result = result.Replace("{bot_name}", _botService.BotInfo.FirstName);
                result = result.Replace("{bot_username}", $"@{_botService.BotInfo.Username}");
                result = result.Replace("{bot_id}", _botService.BotInfo.Id.ToString());
            }
            else
            {
                result = result.Replace("{bot_name}", "Bot Name");
                result = result.Replace("{bot_username}", "@username");
                result = result.Replace("{bot_id}", "0");
            }

            // Теги канала/группы
            var activeGroup = _groupsService.GetGroups().FirstOrDefault(g => g.Selected);
            if (activeGroup != null)
            {
                result = result.Replace("{channel_name}", activeGroup.Title);
                result = result.Replace("{channel_username}", string.IsNullOrEmpty(activeGroup.Username)
                    ? "@"
                    : $"@{activeGroup.Username}");
                result = result.Replace("{channel_id}", activeGroup.ChatId.ToString());
            }
            else
            {
                result = result.Replace("{channel_name}", "Название канала");
                result = result.Replace("{channel_username}", "@channel");
                result = result.Replace("{channel_id}", "0");
            }

            // Дата и время
            var now = DateTime.Now;
            result = result.Replace("{date}", now.ToString("dd.MM.yyyy"));
            result = result.Replace("{time}", now.ToString("HH:mm"));
            result = result.Replace("{datetime}", now.ToString("dd.MM.yyyy HH:mm"));
            result = result.Replace("{day_name}", GetDayName(now.DayOfWeek));

            // Пользователь
            result = result.Replace("{user_name}", "GAMNYAR"); // TODO: взять из профиля
            result = result.Replace("{user_id}", "123456789"); // TODO: взять из профиля

            // Шаблон
            if (template != null)
            {
                result = result.Replace("{template_name}", template.Name);
            }
            else
            {
                result = result.Replace("{template_name}", "Название шаблона");
            }

            return result;
        }

        /// <summary>
        /// Получить список всех доступных тегов
        /// </summary>
        public List<TemplateTagInfo> GetAvailableTags()
        {
            return new List<TemplateTagInfo>
            {
                new TemplateTagInfo { Tag = "{bot_name}", Description = "Имя бота", Example = "My Bot" },
                new TemplateTagInfo { Tag = "{bot_username}", Description = "Юзернейм бота", Example = "@mybot" },
                new TemplateTagInfo { Tag = "{bot_id}", Description = "ID бота", Example = "123456789" },

                new TemplateTagInfo { Tag = "{channel_name}", Description = "Название канала", Example = "Мой канал" },
                new TemplateTagInfo { Tag = "{channel_username}", Description = "Юзернейм канала", Example = "@mychannel" },
                new TemplateTagInfo { Tag = "{channel_id}", Description = "ID канала", Example = "-1001234567890" },

                new TemplateTagInfo { Tag = "{date}", Description = "Текущая дата", Example = "10.09.2024" },
                new TemplateTagInfo { Tag = "{time}", Description = "Текущее время", Example = "15:30" },
                new TemplateTagInfo { Tag = "{datetime}", Description = "Дата и время", Example = "10.09.2024 15:30" },
                new TemplateTagInfo { Tag = "{day_name}", Description = "День недели", Example = "Понедельник" },

                new TemplateTagInfo { Tag = "{user_name}", Description = "Имя пользователя", Example = "GAMNYAR" },
                new TemplateTagInfo { Tag = "{user_id}", Description = "ID пользователя", Example = "123456789" },

                new TemplateTagInfo { Tag = "{template_name}", Description = "Название шаблона", Example = "Приветствие" }
            };
        }

        private string GetDayName(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => "Понедельник",
                DayOfWeek.Tuesday => "Вторник",
                DayOfWeek.Wednesday => "Среда",
                DayOfWeek.Thursday => "Четверг",
                DayOfWeek.Friday => "Пятница",
                DayOfWeek.Saturday => "Суббота",
                DayOfWeek.Sunday => "Воскресенье",
                _ => "Неизвестно"
            };
        }
    }

    public class TemplateTagInfo
    {
        public string Tag { get; set; } = "";
        public string Description { get; set; } = "";
        public string Example { get; set; } = "";
    }
}