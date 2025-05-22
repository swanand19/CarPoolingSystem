using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class RideRoute
    {
        [Key]
        [ScaffoldColumn(false)]
        public long RideRouteId { get; set; }
    
        public long RideId { get; set; }
        public string Location { get; set; }
        public int SequenceOrder { get; set; }

        public Ride Ride { get; set; }
    }
}
