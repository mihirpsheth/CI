using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            
            System.Reflection.Assembly asbly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo projInfo = FileVersionInfo.GetVersionInfo(asbly.Location);
            string version = projInfo.FileVersion;
            string appName = projInfo.FileDescription;
            string commitSHA = String.Empty;
            using (Stream stream = Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("WebApplication8." + "version.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                commitSHA = reader.ReadLine();
            }

            return new string[] { "Version: " + version + ", Application Description: " + appName + ", lastcommitsha: " + commitSHA};
            //return new string[] { "value1", "value2", fviName + ": " + version1.ToString() };
        }
    }
}
