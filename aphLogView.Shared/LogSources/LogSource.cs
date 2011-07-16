using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;
using aphLogView.Shared.Configuration;
using aphLogView.Shared.Servers;

namespace aphLogView.Shared.LogSources
{
    public class LogSource : ILogSourceItem
    {
        public string Name { get; set; }
        public Server Server { get; set; }
        public string Database { get; set; }
        public string Table { get; set; }

        public void Update(LogSource source)
        {
            Name = source.Name;
            Server = source.Server;
            Database = source.Database;
            Table = source.Table;
        }

        public XElement SaveToXml()
        {
            var xe = new XElement("logSource",
                                  new XElement("name", Name),
                                  new XElement("server")
                                      {
                                          Value = Server != null ? Server.Name : ""
                                      },
                                  new XElement("database", Database),
                                  new XElement("table", Table));

            return xe;
        }
        public void LoadFromXml(XElement element)
        {
            var name = element.Element("name");
            Name = name != null ? name.Value : "";

            var server = element.Element("server");
            if (server != null && !string.IsNullOrEmpty(server.Value))
            {
                Server = Config.GetServerDetails(server.Value);
            }

            var database = element.Element("database");
            Database = database != null ? database.Value : "";

            var table = element.Element("table");
            Table = table != null ? table.Value : "";
        }
    }
}
