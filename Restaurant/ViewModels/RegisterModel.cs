using System.ComponentModel.DataAnnotations;

namespace Restaurant.ViewModels
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Not Match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
