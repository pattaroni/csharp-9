using System;
using System.Collections.Generic;

public class FileSystemStorage : IStorage
{
    private Dictionary<string, string> files = new Dictionary<string, string>();

    public void SaveData(string key, string value)
    {
        files[key] = value;
        Console.WriteLine("Файлова система: запис у файл data/" + key + ".txt");
    }

    public string GetData(string key)
    {
        Console.WriteLine("Файлова система: читання файлу data/" + key + ".txt");
        if (files.ContainsKey(key))
        {
            return files[key];
        }
        return "дані не знайдено";
    }
}
