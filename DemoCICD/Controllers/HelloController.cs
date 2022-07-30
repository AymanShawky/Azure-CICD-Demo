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
        public string Get()
        {
            return "Hello World!";
        }

        [HttpGet("id")]
        public string Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return "Error";
            }
            return "Hello " + id;
        }
    }
}
