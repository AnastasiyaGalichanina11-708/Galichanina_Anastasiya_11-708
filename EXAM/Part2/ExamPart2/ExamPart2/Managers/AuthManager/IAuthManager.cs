using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ExamPart2.Features.Identity.Models;
using ExamPart2.Models;
using Microsoft.AspNetCore.Identity;

namespace ExamPart2.Managers.AuthManager
{
    public interface IAuthManager
    {
        IdentityResult Register(RegisterViewModel model);
        //void AddToDefault(RegisterViewModel model);

        SignInResult SignIn(LoginViewModel model);

        IdentityResult ChangePassword(ChangePasswordViewModel model, ApplicationUser user);
        
        IdentityResult ResetPassword(ResetPasswordViewModel model, ApplicationUser user);

        void SignOut();

        string GetUserId(string email);

        Task UpdateClaim(ClaimsPrincipal claimsPrincipal);
    }
}