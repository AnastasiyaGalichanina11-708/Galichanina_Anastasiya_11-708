using System;
using System.Collections.Generic;
using ExamPart2.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using ExamPart2.Features.Identity.Models;

using Microsoft.AspNetCore.Identity;
using ExamPart2.DatabaseManager;

namespace ExamPart2.Managers.AuthManager 
{
    public class AuthManager : IAuthManager
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IDatabaseManager _databaseManager;
 
        public AuthManager(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager, IDatabaseManager databaseManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _databaseManager = databaseManager;
        }

        public IdentityResult Register(RegisterViewModel model)
        {
            var user = new ApplicationUser {Email = model.Email, UserName = model.Email, Balance = 1000};
            var result = _userManager.CreateAsync(user, model.Password);
            return result.Result;
        }

        public void AddToDefault(RegisterViewModel model)
        {
            var user = _databaseManager.GetUser(model.Email);
            _databaseManager.AddCuisineToUser(user.Id, _databaseManager.GetDefaultCuisine());
            _userManager.AddToRoleAsync(user, "User");
            _signInManager.SignInAsync(user, false);
        }

        public SignInResult SignIn(LoginViewModel model)
        {
            return _signInManager.PasswordSignInAsync(
                model.Email, 
                model.Password, 
                model.RememberMe, 
                false).Result;
        }

        public IdentityResult ChangePassword(ChangePasswordViewModel model, ApplicationUser user)
        {
            var result = _userManager
                    .ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            return result.Result;
        }

        public IdentityResult ResetPassword(ResetPasswordViewModel model, ApplicationUser user)
        {
            var code = _userManager.GeneratePasswordResetTokenAsync(user).Result;
            var result = _userManager.ResetPasswordAsync(user, code, model.Password);
            return result.Result;
        }

        public string GetUserId(string email)
        {
            return _databaseManager.GetUser(email).Id;
            
        }

        public void SignOut()
        {
            _signInManager.SignOutAsync();
        }

        public async Task UpdateClaim(ClaimsPrincipal claimsPrincipal)
        {
            var user = await _userManager.GetUserAsync(claimsPrincipal);
            await _signInManager.RefreshSignInAsync(user);
        }
    }
}