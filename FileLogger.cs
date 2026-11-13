using System;

public class FileLogger : ILogger
{
    public void Debug(string message)
    {
        Write("DEBUG", message);
    }

    public void Info(string message)
    {
        Write("INFO", message);
    }

    public void Warning(string message)
    {
        Write("WARNING", message);
    }

    public void Error(string message)
    {
        Write("ERROR", message);
    }

    private void Write(string level, string message)
    {
        string time = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine("Файл app.log -> [" + time + "] [" + level + "] " + message);
    }
}
