using System;
using System.Threading.Tasks;
using BLL_core.Interfaces;
using DAL_core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EBooks.ViewModels.ManageViewModels;


namespace EBooks.Controllers
{
    public class ManageController : Controller
    {
        private IEmailService _emailService;
        private IUserService _userService;

        public ManageController(IEmailService emailService, IUserService userService)
        {
            _emailService = emailService;
            _userService = userService;
        }
        public async Task<IActionResult> EditPersonalData()
        {
            var user = await _userService.GetUserAsync(User);
            var model = new EditViewModel()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                City = user.City,
                Country = user.Country,
                PhoneNumber = user.PhoneNumber,
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditPersonalData(EditViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userService.GetUserAsync(User);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.UserName = model.Email;
                    user.PhoneNumber = model.PhoneNumber;
                    user.City = model.City;
                    user.Country = model.Country;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    var result = await _userService.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("HomePage", "Home");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> ChangePassword()
        {
            var user = await _userService.GetUserAsync(User);
            var model = new ChangePasswordViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userService.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userService.GetUserId(User)}'.");
            }

            var changePasswordResult = await _userService.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            return RedirectToAction("EditPersonalData");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.FindByEmailAsync(model.Email);
                if (user == null || !(await _userService.IsEmailConfirmed(user)))
                {

                    return View("ForgotPasswordConfirmation");
                }

                var _code = await _emailService.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ResetPassword", "Manage", new { userId = user.Id, code = _code }, protocol: HttpContext.Request.Scheme);
                await _emailService.SendEmailAsync(model.Email, "Reset Password",
                    $"Follow the link to reset password: <a href='{callbackUrl}'>click here to reset password</a>");
                return View("ForgotPasswordConfirmation");
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            return code == null ? View("Error") : View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userService.FindByEmailAsync(model.Email);
            if (user == null)
            {
                //return View("ResetPasswordConfirmation");
                ModelState.AddModelError(string.Empty, "Not valid Email");
            }
            else
            {
                var result = await _userService.ResetPasswordAsync(user, model.Code, model.Password);
                if (result.Succeeded)
                {
                    return View("ResetPasswordConfirmation");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }
    }

}