using LiteDB;

namespace BotLauncher.Models.Telegram
{
    /// <summary>
    /// Модель настроек ручной отправки для группы.
    /// Хранится в базе данных LiteDB.
    /// </summary>
    public class ManualSendSettings
    {
        [BsonId]
        public long ChatId { get; set; }

        public string SelectedTemplateName { get; set; } = "";
        public string CustomText { get; set; } = "";

        public int DelaySeconds { get; set; } = 0;
        public int AutoDeleteSeconds { get; set; } = 0;

        public bool SendTemplateFirst { get; set; } = false;
        public bool SilentSend { get; set; } = false;
        public bool DisablePreview { get; set; } = false;
        public bool ProtectContent { get; set; } = false;
        public bool DeletePrevious { get; set; } = false;
        public bool HideSpoiler { get; set; } = false;
        public bool NoAuthorMention { get; set; } = false;

        public bool PinEnabled { get; set; } = false;
        public string PinTarget { get; set; } = "";

        public string AnimatedEmoji { get; set; } = "";
        public string EmojiApplyTo { get; set; } = "";

        public string AnimatedEffect { get; set; } = "";
        public string EffectApplyTo { get; set; } = "";

        public bool NotifySuccess { get; set; } = false;
        public string NotifySuccessTarget1 { get; set; } = "";
        public string NotifySuccessTarget2 { get; set; } = "";

        public bool NotifyComplete { get; set; } = false;
        public string NotifyCompleteTarget1 { get; set; } = "";
        public string NotifyCompleteTarget2 { get; set; } = "";

        public bool NotifyError { get; set; } = false;
        public string NotifyErrorTarget1 { get; set; } = "";
        public string NotifyErrorTarget2 { get; set; } = "";
        public bool RequestConfirm { get; set; } = false;
        public bool ReplyToLast { get; set; }
        public bool AnimatedEmojiEnabled { get; set; } = false;
        public bool AnimatedEffectEnabled { get; set; } = false;
    }
}