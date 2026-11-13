using System;
using System.Collections.Generic;

public class DatabaseStorage : IStorage
{
    private Dictionary<string, string> table = new Dictionary<string, string>();

    public void SaveData(string key, string value)
    {
        table[key] = value;
        Console.WriteLine("База даних: INSERT у таблицю Data, ключ " + key);
    }

    public string GetData(string key)
    {
        Console.WriteLine("База даних: SELECT з таблиці Data, ключ " + key);
        if (table.ContainsKey(key))
        {
            return table[key];
        }
        return "дані не знайдено";
    }
}
