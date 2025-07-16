using CarPoolingSystem.Tables;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.ViewModels
{
    public class RideVM
    {
        [ScaffoldColumn(false)]
        public long RideId { get; set; }

        [Required(ErrorMessage = "Unable to create ride as driver not detected.")]
        public long DriverId { get; set; }

        [Required(ErrorMessage = "Please select the vehicle for the ride.")]
        [DisplayName("Vehicle")]
        public long VehicleId { get; set; }

        [Required(ErrorMessage = "Please select start location")]
        [DisplayName("Start Location")]
        public string StartLocation { get; set; }

        [Required(ErrorMessage = "Please select end location.")]
        [DisplayName("End Location")]
        public string EndLocation { get; set; }

        [Required(ErrorMessage = "Please select departure time.")]
        [DisplayName("Departure Time")]
        public DateTime? DepartureTime { get; set; }

        [Required(ErrorMessage = "Select the number of seats available.")]
        [DisplayName("Total Seats")]
        public int TotalSeats { get; set; }

        [Required(ErrorMessage = "Enter expected fare from Start to End location.")]
        [DisplayName("Fare per seat")]
        public decimal FarePerSeat { get; set; }

        [DisplayName("Number of seats booked")]
        public int NumberOfSeatsBooked { get; set; }

        public List<RideRouteVM>? RideRoutes { get; set; }
    }
}
