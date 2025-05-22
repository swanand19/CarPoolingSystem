using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class Vehicle
    {
        [Key]
        [ScaffoldColumn(false)]
        public long VehicleId { get; set; }
    
        public string VehicleNumber { get; set; }
        public string Color { get; set; }
        public int SeatsAvailable { get; set; }
        public DateTime? CreatedAt { get; set; }
        public long OwnerUserId { get; set; }
        public string Model { get; set; }

        public User Owner { get; set; }
    }
}
