using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class UserDocument
    {
        [Key]
        [ScaffoldColumn(false)]
        public long UserDocumentId { get; set; }

        public long UserId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentPath { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? UploadedAt { get; set; }

        public User User { get; set; }
    }
}
