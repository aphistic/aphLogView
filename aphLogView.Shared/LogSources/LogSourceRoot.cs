using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace aphLogView.Shared.LogSources
{
    public class LogSourceRoot : LogSourceGroup
    {
        public override string Name
        {
            get { return "Log Sources"; }
            set { }
        }
        public override XElement SaveToXml()
        {
            var root = new XElement("logSources");
            foreach (var source in Items)
            {
                root.Add(source.SaveToXml());
            }
            return root;
        }
    }
}
