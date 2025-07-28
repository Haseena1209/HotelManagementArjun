using System.ComponentModel.DataAnnotations;

namespace Hotel_Managment.DTO
{
    public class locationDTO
    {
        //[Required(ErrorMessage ="Automatically generated")]
        //public string locationid {  get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "state name is mandatory")]
        public string State { get; set; }

        [Required]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "PinCode Must be a Number")]
         public int Pincode { get; set; }

    }
}
