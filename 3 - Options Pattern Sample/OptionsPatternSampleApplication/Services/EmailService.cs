using Microsoft.Extensions.Options;
using OptionsPatternSampleApplication.Interfaces;
using OptionsPatternSampleApplication.Options;
using System.Net.Mail;

namespace OptionsPatternSampleApplication.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailServiceOptions emailServiceOptions;

        public EmailService(IOptions<EmailServiceOptions> options)
        {
            emailServiceOptions = options.Value;
        }

        public void SendEmail(MailMessage message)
        {
            // TODO: Implement this;
            return;
        }
    }
}
