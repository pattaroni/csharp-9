using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    // завдання 1
    static void Task1()
    {
        Console.WriteLine("Завдання 1");

        Player player = new Player();
        IPlayable playable = player;
        IRecodable recodable = player;

        playable.Play();
        recodable.Record();
        player.ShowState();

        playable.Pause();
        player.ShowState();

        recodable.Stop();
        player.ShowState();

        playable.Stop();
        player.ShowState();
        Console.WriteLine();
    }

    // завдання 2
    static void Task2()
    {
        Console.WriteLine("Завдання 2");

        IStorage[] storages = new IStorage[3];
        storages[0] = new DatabaseStorage();
        storages[1] = new FileSystemStorage();
        storages[2] = new CloudStorage();

        foreach (IStorage storage in storages)
        {
            storage.SaveData("student", "Кирик Олексій, 585-КБ");
            string value = storage.GetData("student");
            Console.WriteLine("Отримано: " + value);
            Console.WriteLine();
        }
    }

    // завдання 3
    static void Task3()
    {
        Console.WriteLine("Завдання 3");

        IEmailService[] services = new IEmailService[3];
        services[0] = new GmailEmailService();
        services[1] = new OutlookEmailService();
        services[2] = new YahooEmailService();

        foreach (IEmailService service in services)
        {
            service.SendEmail("teacher@example.com", "Практична 9", "Звіт додано");
            service.SendEmail("group585@example.com", "Нагадування", "Пара о 10:00");

            List<string> emails = service.GetEmails();
            Console.WriteLine("Надіслані листи (" + emails.Count + "):");
            foreach (string email in emails)
            {
                Console.WriteLine("  " + email);
            }
            Console.WriteLine();
        }
    }

    // завдання 4
    static void Task4()
    {
        Console.WriteLine("Завдання 4");

        ILogger[] loggers = new ILogger[3];
        loggers[0] = new FileLogger();
        loggers[1] = new DatabaseLogger();
        loggers[2] = new EmailLogger();

        foreach (ILogger logger in loggers)
        {
            logger.Debug("Програму запущено");
            logger.Info("Користувач увійшов у систему");
            logger.Warning("Мало вільного місця на диску");
            logger.Error("Не вдалося підключитися до сервера");
            Console.WriteLine();
        }
    }
}
