using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class Ride
    {
        [Key]
        [ScaffoldColumn(false)]
        public long RideId { get; set; }

        public long DriverId { get; set; }
        public long VehicleId { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public DateTime DepartureTime { get; set; }
        public int TotalSeats { get; set; }
        public decimal FarePerSeat { get; set; }
        public int NumberOfSeatsBooked { get; set; }
        public DateTime? CreatedAt { get; set; }

        public User Driver { get; set; }
        public Vehicle Vehicle { get; set; }
        public List<RideRoute> RideRoutes { get; set; }
    }
}
