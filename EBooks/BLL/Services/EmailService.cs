using MailKit.Net.Smtp;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using MimeKit;
using BLL.DTO;

namespace BLL.Services
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

            emailMessage.From.Add(new MailboxAddress("Lizaveta Novik", "lizanovik9873@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 25, false);
                await client.AuthenticateAsync("lizanovik9873@gmail.com", "liran1212");
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

