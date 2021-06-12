using System;
using System.Net;
using System.Net.Mail;

namespace MailSender.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using var message = new MailMessage("zamanoff.renat@yandex.ru", "zamanov.renat@inbox.ru");

            using var client = new SmtpClient("smtp.yandex.ru", 465);

            client.EnableSsl = true;
            client.Credentials = new NetworkCredential
            {
                UserName = "zamanoff.renat",
                Password = "123"
            };

            client.Send(message);
        }
    }
}
