using System.Threading.Tasks;
using AutoMapper;
using BLL_core.DTO;
using BLL_core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EBooks.ViewModels;
using EBooks.ViewModels.AccountViewModels;


namespace EBooks.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private IUserService _userService;
        private IEmailService _emailService;
        public AccountController(IMapper mapper, IUserService userService, IEmailService emailService)
        {
            _mapper = mapper;
            _userService = userService;
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dtoModel = _mapper.Map<UserModel>(model);
                var res = await _userService.CreateUser(dtoModel);
                if (res.Succeeded)
                {
                    var currentUser = await _userService.FindByEmailAsync(model.Email);
                    await _userService.AddToRoleAsync(currentUser, "user");
                    var code = await _emailService.GenerateEmailConfirmationTokenAsync(currentUser);
                    var callbackUrl = Url.Action(
                        "ConfirmEmail",
                        "Account",
                        new { userId = currentUser.Id, code },
                        protocol: HttpContext.Request.Scheme);

                    await _emailService.SendConfirmationMessage(dtoModel, callbackUrl);
                    return View("EmailConfirmation");
                }
                else
                {
                    foreach (var error in res.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = await _userService.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    if (!await _userService.IsEmailConfirmed(user))
                    {
                        ModelState.AddModelError(string.Empty, "You haven't confirmed your email");
                        return View(model);
                    }
                }

                var result = await _userService.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("HomePage", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Wrong Login or Password");
                }
            }
            return View(model);
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _userService.SignOutAsync();
            return RedirectToAction("HomePage", "Home");
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userService.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userService.ConfirmEmail(user, code);
            if (result.Succeeded)
            {
                await _userService.SignInAsync(user, false);
                _userService.AddCustomer(user.Id);
                return RedirectToAction("HomePage", "Home");
            }
            else
                return View("Error");
        }
    }
}