using System.ComponentModel.DataAnnotations;

namespace Exam.Features.Identity.Models
{
    public class ForgotPasswordViewModel
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}