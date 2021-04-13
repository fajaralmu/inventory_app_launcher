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
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k "+loader.tomcatCommandStart,
                    WorkingDirectory = @loader.tomcatHomePath
                }
            };

            proc.Start();
            //proc.WaitForExit();
        }
        public void StopServer()
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k " + loader.tomcatCommandStop,
                    WorkingDirectory = @loader.tomcatHomePath
                }
            };

            proc.Start();
            //proc.WaitForExit();
        }
    }
}
