using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.ViewModels
{
    public class RoleVM
    {
        [Required(ErrorMessage ="Please enter role")]
        [DisplayName("Role name")]
        public string Name { get; set; }
    }
}
