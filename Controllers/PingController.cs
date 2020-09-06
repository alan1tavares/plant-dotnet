using Microsoft.AspNetCore.Mvc;

namespace plants_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Pong";
        }
    }
}