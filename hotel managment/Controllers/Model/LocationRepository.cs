namespace hotel_managment.Controllers.Model
{
    public class LocationRepository
    {
        public static List<location> locations = new List<location>()
        {
            new location
            {
                locationid = "1",
                Name = "Guntur",
                State = "AP",
                Pincode = 12345
            },
            new location
            {
                locationid ="2",
                Name = "Tenali",
                State = "AP",
                Pincode = 67890
            },
            new location
            {
                locationid = "3",
                Name = "Kammam",
                State = "AP",
                Pincode = 14702
            },
            new location
            {
                locationid = "4",
                Name = "Vizag",
                State = "AP",
                Pincode = 25803
            },

        };
    }
}

