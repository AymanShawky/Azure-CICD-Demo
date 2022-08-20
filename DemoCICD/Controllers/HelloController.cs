using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
