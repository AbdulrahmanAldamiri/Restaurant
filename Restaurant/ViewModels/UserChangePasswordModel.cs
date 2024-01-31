using System.ComponentModel.DataAnnotations;

namespace Restaurant.ViewModels
{
    public class UserChangePasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}
