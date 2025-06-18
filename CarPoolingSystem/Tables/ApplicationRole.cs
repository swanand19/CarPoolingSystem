using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class ApplicationRole : IdentityRole<long>
    {
        [Key]
        [ScaffoldColumn(false)]
        public long IdentityRoleId { get; set; }
    }
}
