using CarPoolingSystem.Tables;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarPoolingSystem.ViewModels
{
    public class RideRouteVM
    {
        [Key]
        [ScaffoldColumn(false)]
        public long RideRouteId { get; set; }

        [Required(ErrorMessage = "Unable to detect ride for the routes.")]
        public long RideId { get; set; }

        [Required(ErrorMessage = "Please select route point.")]
        [DisplayName("Route Point")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Sequence is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Sequence must be a positive number")]
        [DisplayName("Sequence order")]
        public int SequenceOrder { get; set; }
    }
}
