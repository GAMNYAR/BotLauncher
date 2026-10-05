using BotLauncher.Models.Telegram;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BotLauncher.Services.Telegram
{
    public class LiteDbSettingsStorage
    {
        private readonly string _connectionString;
        private readonly object _lock = new();

        public LiteDbSettingsStorage()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bot_settings.db");
            _connectionString = $"Filename={dbPath}";
        }

        #region Настройки ручной отправки
        public void SaveManualSettings(ManualSendSettings settings)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<ManualSendSettings>("ManualSettings");
                collection.Upsert(settings);
            }
        }

        public ManualSendSettings? LoadManualSettings(long chatId)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<ManualSendSettings>("ManualSettings");
                return collection.FindById(chatId);
            }
        }
        #endregion

        #region История отправок
        public void SaveSendHistory(SendHistoryRecord record)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<SendHistoryRecord>("SendHistory");
                collection.Insert(record);
            }
        }

        public List<SendHistoryRecord> GetSendHistory(long chatId)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<SendHistoryRecord>("SendHistory");
                return collection.Find(x => x.ChatId == chatId).ToList();
            }
        }

        public void DeleteSendHistory(ObjectId id)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<SendHistoryRecord>("SendHistory");
                collection.Delete(id);
            }
        }
        #endregion

        #region Активные сессии
        public void SaveActiveSession(ActiveSession session)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<ActiveSession>("ActiveSessions");

                var existing = collection.FindById(session.ChatId);
                if (existing != null)
                {
                    session.Id = existing.Id;
                }

                collection.Upsert(session);
            }
        }

        public ActiveSession? LoadActiveSession(long chatId)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<ActiveSession>("ActiveSessions");
                return collection.FindById(chatId);
            }
        }

        public void UpdateActiveSessionRemaining(long chatId, int seconds)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<ActiveSession>("ActiveSessions");

                // Находим сессию и обновляем поле
                var session = collection.FindById(chatId);
                if (session != null)
                {
                    session.RemainingSeconds = seconds;
                    collection.Update(session);
                }
            }
        }

        public void RemoveActiveSession(long chatId)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<ActiveSession>("ActiveSessions");
                collection.Delete(chatId);
            }
        }
        #endregion

        #region Отложенные удаления
        public void SavePendingDeletion(PendingDeletion deletion)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<PendingDeletion>("PendingDeletions");
                collection.Insert(deletion);
            }
        }

        public void RemovePendingDeletions(long chatId)
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<PendingDeletion>("PendingDeletions");
                collection.DeleteMany(x => x.ChatId == chatId);
            }
        }

        public List<PendingDeletion> GetAllPendingDeletions()
        {
            lock (_lock)
            {
                using var db = new LiteDatabase(_connectionString);
                var collection = db.GetCollection<PendingDeletion>("PendingDeletions");
                return collection.FindAll().ToList();
            }
        }
        #endregion
    }
}