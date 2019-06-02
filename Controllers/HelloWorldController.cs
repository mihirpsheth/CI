using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // GET: api/HelloWorld
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

    }
}
