using System.Net;
using System.Net.Mail;

namespace OnlineConsultationManagementSystem.Util.Email
{
    public class EmailService : IEmailService
    {

        private readonly EmailConfiguration _emailConfig;

        public EmailService(IConfiguration config)
        {
            _emailConfig = config.GetSection("EmailConfiguration").Get<EmailConfiguration>();
        }

        public async Task SendAsync(Message message)
        {
            using (var client = new SmtpClient(_emailConfig.SmtpServer, _emailConfig.Port)
            {
                Credentials = new NetworkCredential(_emailConfig.UserName, _emailConfig.Password),
                EnableSsl = true,
            })
            {
                // hardcoded recipient mail id as we are using smtp sandbox
                await client.SendMailAsync(_emailConfig.From, "to@example.com", message.Subject, message.Content);
                // await client.SendMailAsync(_emailConfig.From, string.Join(";", message.To), message.Subject, message.Content);
            }
        }
    }
}
