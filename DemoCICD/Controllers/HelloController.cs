using Microsoft.AspNetCore.Mvc;


namespace DemoCICD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get(string name = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Hello World!";
            }
             
            return "Hello " + name;
        }

    }
}
