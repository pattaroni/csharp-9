public interface IStorage
{
    void SaveData(string key, string value);
    string GetData(string key);
}
