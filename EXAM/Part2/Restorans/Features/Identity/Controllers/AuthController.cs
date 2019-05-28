using System.Security.Claims;
using System.Threading.Tasks;
using Restorans.Features.Identity.Models;
using Restorans.Models;
using Restorans.Managers.AuthManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Restorans.Features.Identity.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAuthManager _authManager;
 
        public AuthController(UserManager<ApplicationUser> userManager, IAuthManager authManager)
        {
            _userManager = userManager;
            _authManager = authManager;
        }
        [HttpGet]
        public IActionResult Register() => View("~/Features/Identity/Views/Auth/Register.cshtml");

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _authManager.Register(model);
                
                if (result.Succeeded)
                {
                    _authManager.AddToDefault(model);
                    
                    return RedirectToAction("Home", "Main");
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            return View("~/Features/Identity/Views/Auth/Register.cshtml", model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null) => View("~/Features/Identity/Views/Auth/Login.cshtml", new LoginViewModel { ReturnUrl = returnUrl });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _authManager.SignIn(model);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    return RedirectToAction("Home", "Main");
                }

                ModelState.AddModelError("", "Неправильный логин и (или) пароль");
            }
            return View("~/Features/Identity/Views/Auth/Login.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            _authManager.SignOut();
            return RedirectToAction("Home", "Main");
        }
        
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    var result = _authManager.ChangePassword(model, user);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Home", "Main");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Пользователь не найден");
                }
            }
            return RedirectToPage("ChangePassword", model);
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword() => View("~/Features/Identity/Views/Auth/ForgotPassword.cshtml");
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // пользователь с данным email может отсутствовать в бд
                    // тем не менее мы выводим стандартное сообщение, чтобы скрыть 
                    // наличие или отсутствие пользователя в бд
                    return RedirectToPage("ForgotPasswordConfirmation");
                }

                return RedirectToPage("ResetPassword");
                
            }
            return View("~/Features/Identity/Views/Auth/ForgotPassword.cshtml", model);
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string code = null)
        {
            return View("~/Features/Identity/Views/Auth/ResetPassword.cshtml");
        }
 
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Features/Identity/Views/Auth/ResetPassword.cshtml", model);
            }
            var user = await _userManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                return RedirectToPage("ResetPasswordConfirmation");
            }

            var result = _authManager.ResetPassword(model, user);
            if (result.Succeeded)
            {
                return RedirectToPage("ResetPasswordConfirmation");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View("~/Features/Identity/Views/Auth/ResetPassword.cshtml", model);
        }
    }
    
}