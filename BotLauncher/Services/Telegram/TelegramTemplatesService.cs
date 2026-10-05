using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using BotLauncher.Models.Telegram;

namespace BotLauncher.Services.Telegram;

public class TelegramTemplatesService
{
    private readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "templates.json");
    private List<TelegramTemplate> _templates = new();

    // ✅ СОБЫТИЯ для уведомления об изменениях
    public event Action? TemplatesChanged;

    public TelegramTemplatesService()
    {
        LoadTemplates();
    }

    public List<TelegramTemplate> GetAll()
    {
        LoadTemplates();
        return _templates;
    }

    public TelegramTemplate? GetByName(string name)
    {
        return _templates.FirstOrDefault(t => t.Name == name);
    }

    public TelegramTemplate? GetById(string id)
    {
        return _templates.FirstOrDefault(t => t.Id == id);
    }

    public void Save(TelegramTemplate template)
    {
        if (string.IsNullOrEmpty(template.Id))
        {
            template.Id = Guid.NewGuid().ToString("N")[..12];
        }

        var existing = _templates.FirstOrDefault(t => t.Id == template.Id);
        if (existing != null)
        {
            template.CreatedAt = existing.CreatedAt;
            template.ModifiedAt = DateTime.Now;
            _templates.Remove(existing);
        }
        else
        {
            template.CreatedAt = DateTime.Now;
            template.ModifiedAt = DateTime.Now;
        }

        _templates.Add(template);
        SaveToFile();

        // ✅ Уведомляем об изменении
        TemplatesChanged?.Invoke();
    }

    public void Delete(string id)
    {
        _templates.RemoveAll(t => t.Id == id);
        SaveToFile();

        // ✅ Уведомляем об изменении
        TemplatesChanged?.Invoke();
    }

    private void LoadTemplates()
    {
        if (File.Exists(_filePath))
        {
            try
            {
                var json = File.ReadAllText(_filePath);
                _templates = JsonSerializer.Deserialize<List<TelegramTemplate>>(json) ?? new List<TelegramTemplate>();
            }
            catch
            {
                _templates = new List<TelegramTemplate>();
            }
        }
        else
        {
            _templates = new List<TelegramTemplate>();
        }
    }

    private void SaveToFile()
    {
        var directory = Path.GetDirectoryName(_filePath);
        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }

        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(_filePath, JsonSerializer.Serialize(_templates, options));
    }
}