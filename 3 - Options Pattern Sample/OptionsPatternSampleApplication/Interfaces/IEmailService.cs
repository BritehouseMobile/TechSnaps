using System.Net.Mail;

namespace OptionsPatternSampleApplication.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(MailMessage message);
    }
}
