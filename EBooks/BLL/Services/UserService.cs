using System.Security.Claims;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        UserManager<User> UserManager { get; set; }
        SignInManager<User> SignInManager { get; set; }
        RoleManager<IdentityRole> RoleManager { get; set; }
        private IUnitOfWork Database { get; set; }
        public UserService(UserManager<User> userManager, SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager, IUnitOfWork database)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            RoleManager = roleManager;
            Database = database;
        }

        public async Task<IdentityResult> CreateUser(UserModel model)
        {
            var user = new User
            {
                Email = model.Email,
                UserName = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                City = model.City,
                Country = model.Country,
                PhoneNumber = model.PhoneNumber
            };
            return await UserManager.CreateAsync(user, model.Password);

        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await UserManager.FindByEmailAsync(email);
        }

        public async Task<bool> IsEmailConfirmed(User user)
        {
            return await UserManager.IsEmailConfirmedAsync(user);
        }

        public async Task<User> FindByIdAsync(string id)
        {
            return await UserManager.FindByIdAsync(id);
        }

        public async Task<Microsoft.AspNetCore.Identity.SignInResult> PasswordSignInAsync(string email, string password,
            bool rememberMe, bool lockoutOnFailure)
        {
            return await SignInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure);
        }

        public async Task SignOutAsync()
        {
            await SignInManager.SignOutAsync();
        }

        public async Task SignInAsync(User user, bool isPersistent)
        {
            await SignInManager.SignInAsync(user, isPersistent);
        }

        public async Task<IdentityResult> ConfirmEmail(User user, string code)
        {
            return await UserManager.ConfirmEmailAsync(user, code);
        }

        public async Task<User> GetUserAsync(ClaimsPrincipal user)
        {
            return await UserManager.GetUserAsync(user);
        }

        public async Task<IdentityResult> UpdateAsync(User user)
        {
            return await UserManager.UpdateAsync(user);
        }

        public string GetUserId(ClaimsPrincipal user)
        {
            return UserManager.GetUserId(user);
        }

        public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
        {
            return await UserManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public async Task<IdentityResult> ResetPasswordAsync(User user, string code, string password)
        {
            return await UserManager.ResetPasswordAsync(user, code, password);
        }

        public async Task<IdentityResult> AddToRoleAsync(User user, string role)
        {
            return await UserManager.AddToRoleAsync(user, role);
        }

        public void AddCustomer(string id)
        {
            var cust = new Customer() { Id = id };
            Database.Customers.Create(cust);
            Database.Save();
        }

        public bool IsAuthentificated(ClaimsPrincipal principal)
        {
            if (SignInManager.IsSignedIn(principal)) return true;
            return false;
        }
    }
}

