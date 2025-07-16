using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.Tables
{
    public class RideBooking
    {
        [Key]
        [ScaffoldColumn(false)]
        public long RideBookingId { get; set; }
    
        public long RideId { get; set; }  //From Ride table
        public long PassengerId { get; set; }  //From user table
        public int SeatsBooked { get; set; }
        public string BookingStatus { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Ride Ride { get; set; }
        public User Passenger { get; set; }
    }
}
