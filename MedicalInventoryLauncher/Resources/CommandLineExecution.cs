using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInventoryLauncher.Resources
{
    class CommandLineExecution
    {
        ConfigurationLoader loader;
        public CommandLineExecution()
        {
            loader = ConfigurationLoader.Instance();
        }

        public void StartServer()
        {
            Exec(loader.tomcatCommandStart,
                    loader.tomcatHomePath);
        }
        public void StopServer()
        {
            Exec(loader.tomcatCommandStop,
                    loader.tomcatHomePath);
        }

        public void StartDatabase()
        {
            Exec(loader.pgCommandStart.Replace("${PG_DATA}", "\"" + loader.postgreDataPath + "\""),
                       loader.postgreHomePath);

        }

        private void Exec(string arguments, string workingDirectory)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k " + arguments,
                    WorkingDirectory = @workingDirectory
                }
            };

            proc.Start();
        }

        public void StopDatabase()
        {
            Exec(loader.pgCommandStop.Replace("${PG_DATA}", "\"" + loader.postgreDataPath + "\""), 
                loader.postgreHomePath);
        }
    }
}
