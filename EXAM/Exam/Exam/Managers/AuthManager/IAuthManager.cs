using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Exam.Features.Identity.Models;
using Exam.Models;
using Microsoft.AspNetCore.Identity;

namespace Exam.Managers.AuthManager
{
    public interface IAuthManager
    {
        IdentityResult Register(RegisterViewModel model);
        void AddToDefault(RegisterViewModel model);

        SignInResult SignIn(LoginViewModel model);

        IdentityResult ChangePassword(ChangePasswordViewModel model, ApplicationUser user);
        
        IdentityResult ResetPassword(ResetPasswordViewModel model, ApplicationUser user);

        void SignOut();

        string GetUserId(string email);

        Task UpdateClaim(ClaimsPrincipal claimsPrincipal);
    }
}