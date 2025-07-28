using System.ComponentModel.DataAnnotations;

namespace hotel_managment.Controllers.Model
{
    public class location
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
