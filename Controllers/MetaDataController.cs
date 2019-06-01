using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaDataController : ControllerBase
    {
        // GET: api/MetaData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //Version version = Assembly.GetEntryAssembly().GetName().Version;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(@"C:\Users\mshet\source\repos\Demo\Demo\bin\Demo.dll");
            FileVersionInfo fviName = FileVersionInfo.GetVersionInfo(@"C:\Users\mshet\source\repos\Demo\Demo\bin\Demo.dll");
            string version = fvi.FileVersion;
            //var i = version.Major;


            return new string[] { "value1", "value2", fviName + ": " + version.ToString() };

        }

    }
}
