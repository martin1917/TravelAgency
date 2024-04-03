using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public class RegistrationModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string SecondName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string? Patronymic { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Login { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Password { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
