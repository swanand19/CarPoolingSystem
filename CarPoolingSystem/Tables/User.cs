using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class User : IdentityUser<long>
    {
        public string? FullName { get; set; }
       
        public bool IsDriver { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
