using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace WebApplication8
{
    public class BuildInfo
    {
        public static string build()
        {

                string gitVersion = String.Empty;
                using (Stream stream = Assembly.GetExecutingAssembly()
                        .GetManifestResourceStream("TryGitDescribe." + "version.txt"))
                using (StreamReader reader = new StreamReader(stream))
                {
                    gitVersion = reader.ReadToEnd();
                }

                Console.WriteLine("Version: {0}", gitVersion);
                Console.WriteLine("Hit any key to continue");
                Console.ReadKey();
            return gitVersion;
        }
    }
    
}
  
