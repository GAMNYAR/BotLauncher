using LiteDB;
using System;
using System.Collections.Generic;

namespace BotLauncher.Models.Telegram
{
    public class SendHistoryRecord
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public long ChatId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Icon { get; set; } = "";
        public string Message { get; set; } = "";
        public string? TemplateText { get; set; }
        public string? CustomText { get; set; }
    }

    public class ActiveSession
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public long ChatId { get; set; }
        public string State { get; set; } = "";
        public int RemainingSeconds { get; set; }
        public int? SentMessage1Id { get; set; }
        public int? SentMessage2Id { get; set; }
        public List<int> DiceMessageIds { get; set; } = new List<int>();
        public bool HasTemplate { get; set; }
        public bool HasCustomText { get; set; }
        public string? TemplateText { get; set; }
        public string? CustomText { get; set; }
    }

    public class PendingDeletion
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public long ChatId { get; set; }
        public int MessageId { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}