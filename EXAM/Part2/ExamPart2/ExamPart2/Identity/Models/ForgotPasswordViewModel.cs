using System.ComponentModel.DataAnnotations;

namespace ExamPart2.Features.Identity.Models
{
    public class ForgotPasswordViewModel
    {
        [Required] [EmailAddress] public string Email { get; set; }
    }
}