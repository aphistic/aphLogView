using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using aphLogView.Shared.LogSources;
using aphLogView.Shared.Servers;

namespace aphLogView.Shared.Configuration
{
    public sealed class Config
    {
        #region Global Constants
        public const string ApplicationName = "aphLogView";
        private const string ConfigFileName = "aphLogView.Settings.xml";
        #endregion

        #region Class Data
        private static LogSourceRoot _logSources = null;
        private static List<Server> _servers = new List<Server>();
        #endregion

        #region Class State
        private static bool IsLoaded { get; set; }
        private static string ConfigFilePath { get; set; }
        #endregion

        public static int LogHistory { get; set; }
        public static int RefreshTime { get; set; }
        public static LogSourceRoot LogSources
        {
            get { return _logSources; }
            protected set { _logSources = value; }
        }
        public static IEnumerable<Server> Servers
        {
            get { return _servers; }
        }

        static Config()
        {
            IsLoaded = false;
        }

        private Config()
        {
            // This class shouldn't be instantiated.
        }

        public static Server GetServerDetails(string name)
        {
            return _servers.FirstOrDefault(details => details.Name.Equals(name));
        }

        public static void SortServers()
        {
            _servers.Sort();
        }
        public static void AddServer(Server server)
        {
            if (!_servers.Contains(server))
            {
                _servers.Add(server);
            }
        }

        private static string GetConfigFilename()
        {
            return GetAppDataDir() + ConfigFileName;
        }
        private static string GetAppDataDir()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appDataPath, ApplicationName + "\\");
        }

        private static void InitializeNewConfig()
        {
            _logSources = new LogSourceRoot();
            _servers = new List<Server>();
        }

        public static void Load()
        {
            Load(!string.IsNullOrEmpty(ConfigFilePath) ? ConfigFilePath : GetConfigFilename());
        }
        public static void Load(string filePath)
        {
            ConfigFilePath = filePath;

            if (File.Exists(filePath))
            {
                var configFile = File.ReadAllText(filePath);

                XElement xe = XElement.Parse(configFile);
                LoadFromXml(xe);
            }
            else
            {
                InitializeNewConfig();
            }

            IsLoaded = true;
        }
        private static void LoadFromXml(XElement element)
        {
            if (element.Name == "configuration")
            {
                LogHistory = LoadElementValue(element.Element("logHistory"), 100);
                LogHistory = LogHistory > 0 ? LogHistory : 1;

                RefreshTime = LoadElementValue(element.Element("refreshTime"), 30);
                RefreshTime = RefreshTime > 0 ? RefreshTime : 1;

                // Load Servers first so log sources can find them when loading
                _servers = new List<Server>();
                var servers = element.Element("servers");
                if (servers != null)
                {
                    foreach (var cfgServer in servers.Elements("server"))
                    {
                        var server = new Server();
                        server.LoadFromXml(cfgServer);
                        _servers.Add(server);
                    }
                }

                _logSources = new LogSourceRoot();
                _logSources.LoadFromXml(element.Element("logSources"));
            }
        }
        private static int LoadElementValue(XElement element, int defaultValue)
        {
            if (element != null)
            {
                int val;
                return !int.TryParse(element.Value, out val) ? defaultValue : val;
            }
            return defaultValue;
        }

        public static void Save()
        {
            Save(!string.IsNullOrEmpty(ConfigFilePath) ? ConfigFilePath : GetConfigFilename());
        }
        public static void Save(string filePath)
        {
            var configDir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(configDir) && !Directory.Exists(configDir))
            {
                Directory.CreateDirectory(configDir);
            }

            File.WriteAllText(filePath, SaveToXml().ToString());
        }
        private static XElement SaveToXml()
        {
            var cfgRoot = new XElement("configuration");

            cfgRoot.Add(new XElement("logHistory", LogHistory));
            cfgRoot.Add(new XElement("refreshTime", RefreshTime));

            cfgRoot.Add(_logSources.SaveToXml());

            var servers = new XElement("servers");
            cfgRoot.Add(servers);
            foreach (var server in _servers)
            {
                servers.Add(server.SaveToXml());
            }

            return cfgRoot;
        }
    }
}
