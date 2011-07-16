using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace aphLogView.Shared.Data
{
    public class LogEntry
    {
        public DateTime Date { get; internal set; }
        public string Thread { get; internal set; }
        public LogLevel Level { get; internal set; }
        public string Logger { get; internal set; }
        public string Message { get; internal set; }
        public string Exception { get; internal set; }

        public LogEntry()
        {
            Date = DateTime.MinValue;
            Thread = "";
            Level = LogLevel.Unknown;
            Logger = "";
            Message = "";
            Exception = "";
        }
    }
}
