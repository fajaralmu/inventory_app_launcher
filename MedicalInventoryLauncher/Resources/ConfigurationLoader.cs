

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;

namespace MedicalInventoryLauncher.Resources
{
    class ConfigurationLoader
    {
        private static ConfigurationLoader instance = null;
        private Properties properties;
        public string postgreHomePath
        {
            get { return properties.get("postgres_home"); } 
            set {properties.set("postgres_home", value);}
        }

        public string tomcatCommandStart
        {
            get { return properties.get("tomcat_command_start"); }
        }
        public string tomcatCommandStop
        {
            get { return properties.get("tomcat_command_stop"); }
        }
        public string pgCommandStart
        {
            get { return properties.get("postgres_command_start"); }
        }
        public string pgCommandStop
        {
            get { return properties.get("postgres_command_stop"); }
        }

        public string tomcatHomePath
        {
            get { return properties.get("tomcat_home"); }
            set{properties.set("tomcat_home", value);}
        }
        public string postgreDataPath
        {
            get { return properties.get("postgres_data"); }
            set{ properties.set("postgres_data", value); }
        }
        public string localAddress
        {
            get
            {
                IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

                foreach (IPAddress a in localIPs)
                {
                    string address = (a.ToString());
                    if (address.StartsWith("192.168.") && IPAddress.Parse(address).AddressFamily == AddressFamily.InterNetwork)
                    {
                        return address;
                    }
                }
                return null;
            }
        }

        public static ConfigurationLoader Instance()
        {
            if (null == instance)
            {
                instance = new ConfigurationLoader();
            }
            return instance;
        }
        private ConfigurationLoader()
        {
            load();
        }

        public void load()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources/config.properties");
            properties = new Properties(path);
        }
        public void Save()
        {
            properties.Save();
        }
    }
}
