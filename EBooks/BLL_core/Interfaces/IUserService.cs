using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BLL_core.DTO;
using DAL_core.Entities;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace BLL_core.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUser(UserModel model);
        Task<User> FindByEmailAsync(string email);
        Task<bool> IsEmailConfirmed(User user);
        Task<User> FindByIdAsync(string id);
        Task<SignInResult> PasswordSignInAsync(string email, string password, bool rememberMe, bool b);
        Task SignOutAsync();
        Task SignInAsync(User user, bool isPersistent);
        Task<IdentityResult> ConfirmEmail(User user, string code);
        Task<User> GetUserAsync(ClaimsPrincipal user);
        Task<IdentityResult> UpdateAsync(User user);
        string GetUserId(ClaimsPrincipal user);
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);
        Task<IdentityResult> ResetPasswordAsync(User user, string code, string password);
        Task<IdentityResult> AddToRoleAsync(User uer, string role);
        void AddCustomer(string id);
        bool IsAuthentificated(ClaimsPrincipal principal);
    }
}
