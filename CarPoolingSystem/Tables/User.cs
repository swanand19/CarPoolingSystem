using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class User : IdentityUser<long>
    {
        [Key]
        [ScaffoldColumn(false)]
        public long UserId { get; set; }
    
        public string? FullName { get; set; }
       
        public bool IsDriver { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
