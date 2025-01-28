using Geent.Application.Interface.Service;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        try
        {
            using (var smtpClient = new SmtpClient(_configuration["EmailSettings:SmtpServer"]))
            {
                smtpClient.Port = int.Parse(_configuration["EmailSettings:Port"]);
                smtpClient.Credentials = new NetworkCredential(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]);
                smtpClient.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_configuration["EmailSettings:From"]),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(to);

                // Envia o email
                await smtpClient.SendMailAsync(mailMessage);
            }
        }
        catch (SmtpException ex)
        {
            // Log detalhado para erro SMTP
            Console.WriteLine($"Erro ao enviar email: {ex.Message}");
            throw;
        }
        catch (Exception ex)
        {
            // Log de erro genérico
            Console.WriteLine($"Erro genérico: {ex.Message}");
            throw;
        }
    }

}
