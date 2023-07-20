using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;

namespace SangDT_DotNetCore5._0.Services
{
    public class SmtpHandling
    {
        private readonly EmailSettings _emailSettings;

        public SmtpHandling(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public void SendEmail(int Id, string Name, string Email, string Phone, string Note)
        {
            //send email using gmail smtp
            using (var client = new SmtpClient())
            {
                client.Connect(_emailSettings.SmtpServer, _emailSettings.SmtpPort, SecureSocketOptions.StartTls);
                client.Authenticate(_emailSettings.Username, _emailSettings.Password);

                //client.Connect("smtp.gmail.com");
                //client.Authenticate("sangdothanh95@gmail.com", "Sungdt@123");

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = $"<p>{Id}</p> <p>{Name}</p> <p>{ Phone}</p> <p>{ Email}</p> <p>{ Note}</p>",
                    TextBody = "{formData.Id} \r\n formData.Name} \r\n formData.Phone} \r\n formData.Email} \r\n formData.Note} "
                };

                var message = new MimeMessage
                {
                    Body = bodyBuilder.ToMessageBody()
                };
                message.From.Add(new MailboxAddress("Noreply my site", _emailSettings.Username));
                message.To.Add(new MailboxAddress("Testing Send Email", Email));
                message.Subject = "New context submit data";
                client.Send(message);

                client.Disconnect(true);
            }
        }
    }
}
