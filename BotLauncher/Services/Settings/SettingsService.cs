using BotLauncher.Models;
using BotLauncher.Models.BotLauncher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace BotLauncher.Services.Settings
{
    public class SettingsService
    {
        private const string FileName = "settings.json";
        public void Save(BotSettings settings)
        {
            string json = JsonSerializer.Serialize(settings);

            File.WriteAllText(FileName, json);
        }
        public BotSettings Load()
        {
            if (!File.Exists(FileName))
            {
                return new BotSettings();
            }
            string json = File.ReadAllText(FileName);
            BotSettings settings = JsonSerializer.Deserialize<BotSettings>(json)!;
            return settings;
        }
    }
}
