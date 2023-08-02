using SimpleEmail.Models;

namespace SimpleEmail.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
