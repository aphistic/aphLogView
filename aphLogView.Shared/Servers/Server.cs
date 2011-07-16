using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace aphLogView.Shared.Servers
{
    public class Server : IComparable<Server>
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public XElement SaveToXml()
        {
            return new XElement("server",
                                new XElement("name", Name),
                                new XElement("host", Host),
                                new XElement("username", Username),
                                new XElement("password", Password));
        }
        public void LoadFromXml(XElement element)
        {
            var name = element.Element("name");
            Name = name != null ? name.Value : "";

            var host = element.Element("host");
            Host = host != null ? host.Value : "";

            var username = element.Element("username");
            Username = username != null ? username.Value : "";

            var password = element.Element("password");
            Password = password != null ? password.Value : "";
        }

        public int CompareTo(Server other)
        {
            if (other == null) return 0;
            return Name.CompareTo(other.Name);
        }
    }
}
