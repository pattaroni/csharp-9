using System;
using System.Collections.Generic;

public class GmailEmailService : IEmailService
{
    private List<string> emails = new List<string>();

    public void SendEmail(string to, string subject, string body)
    {
        emails.Add("Кому: " + to + " | Тема: " + subject + " | Текст: " + body);
        Console.WriteLine("Gmail: лист для " + to + " надіслано через smtp.gmail.com");
    }

    public List<string> GetEmails()
    {
        return emails;
    }
}
