using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Restorans.Features.Identity.Models;
using Restorans.Models;
using Microsoft.AspNetCore.Identity;

namespace Restorans.Managers.AuthManager
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