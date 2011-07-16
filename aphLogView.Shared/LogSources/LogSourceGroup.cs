using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace aphLogView.Shared.LogSources
{
    public class LogSourceGroup : ILogSourceItem
    {
        public virtual string Name { get; set; }
        public List<ILogSourceItem> Items { get; protected set; }

        public LogSourceGroup()
        {
            Items = new List<ILogSourceItem>();
        }

        public virtual void LoadFromXml(XElement element)
        {
            var nameAttr = element.Attribute("name");
            Name = nameAttr != null ? nameAttr.Value : "";

            var items = from itm in element.Elements()
                        where itm.Name == "logSourceGroup" ||
                              itm.Name == "logSource"
                        select itm;
            foreach (var item in items)
            {
                if (item.Name == "logSourceGroup")
                {
                    var logGroup = new LogSourceGroup();
                    logGroup.LoadFromXml(item);
                    Items.Add(logGroup);
                }
                else if (item.Name == "logSource")
                {
                    var logSource = new LogSource();
                    logSource.LoadFromXml(item);
                    Items.Add(logSource);
                }
            }
        }

        public virtual XElement SaveToXml()
        {
            var element = new XElement("logSourceGroup",
                                       new XAttribute("name", Name));
            foreach (ILogSourceItem item in Items)
            {
                element.Add(item.SaveToXml());
            }
            return element;
        }
    }
}
