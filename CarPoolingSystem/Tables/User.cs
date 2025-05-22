using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        public long UserId { get; set; }
    
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public bool IsDriver { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
