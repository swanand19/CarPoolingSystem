using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.ViewModels
{
    public class LoginUserVM
    {
        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Please enter email address in valid format.")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool Remember { get; set; } = false;
    }
}
