using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.ViewModels
{
    public class RegisterUserVM
    {
        [Required(ErrorMessage = "Please enter full name.")]
        [DisplayName("Full Name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Please enter email address in valid format.")]
        [DisplayName("Email")]
        [Remote(action: "IsEmailAlreadyUsed", controller:"Users", ErrorMessage = "Email already registered.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter phone number.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone number should contain numbers only.")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter username.")]
        [DisplayName("UserName")]
        [RegularExpression(@"^[a-zA-Z0-9@]+$", ErrorMessage = "Username can only contain letters, numbers, and the @ symbol. No spaces or other special characters allowed.")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z@_\d]{5,}$", ErrorMessage = "Password must have 5+ characters with uppercase, lowercase, digit, and only @ _ special characters allowed")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password values should match.")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Is Driver")]
        public bool IsDriver { get; set; } = false;

        [DisplayName("User Type")]
        [Required]
        public string UserType { get; set; } = Enums.UserTypeOptions.User.ToString();
    }
}
