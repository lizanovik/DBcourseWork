using MailKit.Net.Smtp;
using System.Threading.Tasks;
using BLL_core.Interfaces;
using DAL_core.Entities;
using Microsoft.AspNetCore.Identity;
using MimeKit;
using BLL_core.DTO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using MailKit.Security;

namespace BLL_core.Services
{
    public class EmailService : IEmailService
    {
        private UserManager<User> UserManager { get; set; }

        public EmailService(UserManager<User> userManager)
        {
            UserManager = userManager;
        }

        public async Task<string> GenerateEmailConfirmationTokenAsync(User user)
        {
            return await UserManager.GenerateEmailConfirmationTokenAsync(user);
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Anton Apanovich", "apanovich.0000@mail.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 25, SecureSocketOptions.Auto);
                await client.AuthenticateAsync("apanovich.0000@mail.ru", "liran1212");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }

        public async Task SendConfirmationMessage(UserModel model, string url)
        {
            await SendEmailAsync(model.Email, "Confirm your account",
                $"Finish registration following the link : <a href='{url}'>Click here to finish registration</a>");
        }

        public async Task SendOrderConfirmationMessage(string email)
        {
            await SendEmailAsync(email, "Order details",
                "Your order has been confirmed.Thank you for choosing our shop");
        }

        public async Task SendOrderRejectionMessage(string email)
        {
            await SendEmailAsync(email, "Order details", "Sorry, your order has been rejected due to lack of money");
        }

        public async Task<string> GeneratePasswordResetTokenAsync(User user)
        {
            return await UserManager.GeneratePasswordResetTokenAsync(user);
        }
    }
}
