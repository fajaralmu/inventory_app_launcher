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
            Exec(loader.tomcatCommandStart, loader.tomcatHomePath, "/c");
        }
        public void StopServer()
        {
            Exec(loader.tomcatCommandStop,  loader.tomcatHomePath, "/c");
        }

        public void StartDatabase()
        {
            string startCommand = loader.pgCommandStart.Replace("${PG_DATA}", "\"" + loader.postgreDataPath + "\"");
            Exec(startCommand, loader.postgreHomePath,   "/c");

        }

        private void Exec(string arguments, string workingDirectory, string prefix = "/k")
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = prefix + arguments,
                    WorkingDirectory = @workingDirectory
                }
            };

            proc.Start();
        }

        public void StopDatabase()
        {
            string stopCommand = loader.pgCommandStop.Replace("${PG_DATA}", "\"" + loader.postgreDataPath + "\"");
            Exec(stopCommand, loader.postgreHomePath);
        }
    }
}
