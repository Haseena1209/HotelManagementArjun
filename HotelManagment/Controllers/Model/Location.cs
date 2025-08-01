using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Controllers.Model
{
    public class Location
    {
        public string locationid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Pincode { get; set; }
    }
}
