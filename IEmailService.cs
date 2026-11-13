using System.Collections.Generic;

public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
    List<string> GetEmails();
}
