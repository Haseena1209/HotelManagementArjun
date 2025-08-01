using HotelManagement.Controllers.Model;
using Hotel_Managment.DTO;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;



namespace HotelManagement.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class Locationcontroller : ControllerBase

    {

      [HttpGet]

        public List<Location> GetLocations()

        {

            return LocationRepository.locations;

        }
        [HttpGet("{id:int}")]
        public IEnumerable<Location> GetByLocationId(string id)
        {
            return LocationRepository.locations.Where(x => x.locationid == id);
        }


        [HttpGet("{name:alpha}")]
        public IEnumerable<Location> GetLocationByName(string name)
        {
            return LocationRepository.locations.Where(x => x.Name == name);
        }

        [HttpPost]

        public locationDTO Addlocation(locationDTO locationDTO)

        {

            Location location = new Location

            {

                //  Locationid = locationDTO.Locationid,

                Name = locationDTO.Name,

                State = locationDTO.State,

                Pincode = locationDTO.Pincode

            };

            LocationRepository.locations.Add(location);

            // locationDTO.Locationid = location.Locationid;

            locationDTO.Name = location.Name;

            locationDTO.State = locationDTO.State;

            locationDTO.Pincode = location.Pincode;

            return locationDTO;



        }

        [HttpDelete("{id}")]

        public ActionResult DeleteLocation(string id)

        {

            var location = LocationRepository.locations.FirstOrDefault(l => l.Name == id);

            if (location == null)

            {

                return NotFound($"Location with ID {id} not found.");

            }



            LocationRepository.locations.Remove(location);

            return Ok($"Location with ID {id} has been deleted.");

        }



        [HttpPut]

        public ActionResult locationmodifications(string id,[FromBody] Location updatedlocation)

        {

            var existinglocation = LocationRepository.locations.FirstOrDefault(l => l.locationid == id);

            if (existinglocation == null)

            {

                return NotFound($"Location with ID {id} not found.");

            }

            existinglocation.Name = updatedlocation.Name;

            existinglocation.State = updatedlocation.State;

            existinglocation.Pincode = updatedlocation.Pincode;

            return Ok(existinglocation);

        }



    }



}

//DTO->Model->DB

//DB->Model->DTO