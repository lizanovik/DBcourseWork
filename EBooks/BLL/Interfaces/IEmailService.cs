﻿using BLL.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmailService
    {
        Task<string> GenerateEmailConfirmationTokenAsync(User user);
        Task<string> GeneratePasswordResetTokenAsync(User user);
        Task SendEmailAsync(string email, string subject, string message);
        Task SendConfirmationMessage(UserModel model, string url);
        Task SendOrderConfirmationMessage(string email);
        Task SendOrderRejectionMessage(string email);
    }
}