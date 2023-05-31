using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JSONStorage
{
    public Dictionary<string, object> Objects { get; set; }

    private string jsonFilePath;

    public JSONStorage(string filePath)
    {
        Objects = new Dictionary<string, object>();
        jsonFilePath = filePath;
    }

    public Dictionary<string, object> All()
    {
        return Objects;
    }

    public void New(object obj)
    {
        var type = obj.GetType();
        var idProperty = type.GetProperty("Id");
        if (idProperty == null)
        {
            throw new ArgumentException("Object must have an 'Id' property.");
        }

        var idValue = idProperty.GetValue(obj)?.ToString();
        if (string.IsNullOrEmpty(idValue))
        {
            throw new ArgumentException("Object 'Id' property cannot be null or empty.");
        }

        var key = $"{type.Name}.{idValue}";
        Objects[key] = obj;
    }

    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var jsonString = JsonSerializer.Serialize(Objects, options);
        File.WriteAllText(jsonFilePath, jsonString);
    }

    public void Load()
    {
        if (File.Exists(jsonFilePath))
        {
            var jsonString = File.ReadAllText(jsonFilePath);
            Objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
        }
    }
}
