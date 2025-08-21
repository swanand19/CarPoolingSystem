using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.ViewModels
{
    public class LoginUserVM
    {
        [Required(ErrorMessage = "Please enter username.")]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool Remember { get; set; } = false;
    }
}
