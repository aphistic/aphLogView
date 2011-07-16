using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace aphLogView.Shared.LogSources
{
    public interface ILogSourceItem
    {
        string Name { get; set; }
        XElement SaveToXml();
        void LoadFromXml(XElement element);
    }
}
