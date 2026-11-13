using System;
using System.Collections.Generic;

public class YahooEmailService : IEmailService
{
    private List<string> emails = new List<string>();

    public void SendEmail(string to, string subject, string body)
    {
        emails.Add("Кому: " + to + " | Тема: " + subject + " | Текст: " + body);
        Console.WriteLine("Yahoo: лист для " + to + " надіслано через smtp.mail.yahoo.com");
    }

    public List<string> GetEmails()
    {
        return emails;
    }
}
