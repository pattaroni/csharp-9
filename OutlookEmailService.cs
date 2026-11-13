using System;
using System.Collections.Generic;

public class OutlookEmailService : IEmailService
{
    private List<string> emails = new List<string>();

    public void SendEmail(string to, string subject, string body)
    {
        emails.Add("Кому: " + to + " | Тема: " + subject + " | Текст: " + body);
        Console.WriteLine("Outlook: лист для " + to + " надіслано через smtp-mail.outlook.com");
    }

    public List<string> GetEmails()
    {
        return emails;
    }
}
