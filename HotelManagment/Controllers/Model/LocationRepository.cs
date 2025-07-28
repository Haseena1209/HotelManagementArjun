namespace HotelManagement.Controllers.Model
{
    public class LocationRepository
    {
        public static List<Location> locations = new List<Location>()
        {
            new Location
            {
                locationid = "1",
                Name = "Guntur",
                State = "AP",
                Pincode = 12345
            },
            new Location
            {
                locationid ="2",
                Name = "Tenali",
                State = "AP",
                Pincode = 67890
            },
            new Location
            {
                locationid = "3",
                Name = "Kammam",
                State = "AP",
                Pincode = 14702
            },
            new Location
            {
                locationid = "4",
                Name = "Vizag",
                State = "AP",
                Pincode = 25803
            },

        };
    }
}

