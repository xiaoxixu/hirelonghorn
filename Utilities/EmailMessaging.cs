using System;
using MimeKit;
namespace sp19team18finalproject.Utilities
{
    public static class EmailMessaging
    {
        public static void SendEmail(String subject, String name, String receiverEmail, String sendMessage)
        {

            var message = new MimeKit.MimeMessage();
            message.From.Add(new MailboxAddress("Team18ams", "Team18ams@gmail.com"));
            message.To.Add(new MailboxAddress(name, receiverEmail));
            message.Subject = subject;
            message.Body = new TextPart("plain")
            {
                Text = sendMessage
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("Team18ams@gmail.com", "sp19team18finalproject!");

                client.Send(message);
                client.Disconnect(true);
            }

        }

    }
}
