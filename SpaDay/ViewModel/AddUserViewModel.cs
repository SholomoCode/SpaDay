using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6)]

        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match! Try again")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
