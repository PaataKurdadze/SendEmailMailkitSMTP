namespace SendEmailMailkitSMTP.Services.EmailService;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}