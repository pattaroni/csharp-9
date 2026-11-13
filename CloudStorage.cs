using System;
using System.Collections.Generic;

public class CloudStorage : IStorage
{
    private Dictionary<string, string> cloud = new Dictionary<string, string>();

    public void SaveData(string key, string value)
    {
        cloud[key] = value;
        Console.WriteLine("Хмара: відправлення об'єкта " + key + " у хмарне сховище");
    }

    public string GetData(string key)
    {
        Console.WriteLine("Хмара: отримання об'єкта " + key + " з хмарного сховища");
        if (cloud.ContainsKey(key))
        {
            return cloud[key];
        }
        return "дані не знайдено";
    }
}
