using Microsoft.AspNetCore.Mvc;

namespace plants_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PopulateDatabaseController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            City city = new City()
            {
                CityId = 1,
                Name = "Alabama",
                ShortName = "ab"
            };

            CityContext cc = new CityContext();
            cc.City.add(city);
            cc.SaveChanges;
        }
    }
}

