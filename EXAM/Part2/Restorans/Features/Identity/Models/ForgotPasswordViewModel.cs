using System.ComponentModel.DataAnnotations;

namespace Restorans.Features.Identity.Models
{
    public class ForgotPasswordViewModel
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}