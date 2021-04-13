using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MedicalInventoryLauncher.Resources
{
    class ConfigurationLoader
    {
        private static ConfigurationLoader instance = null;
        private Properties properties;
        public string postgreHomePath
        {
            get { return properties.get("postgres_home"); } 
            set {
                properties.set("postgres_home", value);
            }
        }


        public string tomcatHomePath
        {
            get { return properties.get("tomcat_home"); }
            set
            {
                properties.set("tomcat_home", value);
            }
        }
        public string postgreDataPath
        {
            get { return properties.get("postgres_data"); }
            set
            {
                properties.set("postgres_data", value);
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
    }
}
