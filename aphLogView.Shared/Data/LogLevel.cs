using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aphLogView.Shared.Data
{
    public enum LogLevel
    {
        Unknown =   0,
        All     =   10,
        Debug   =   20,
        Info    =   30,
        Warn    =   40,
        Error   =   50,
        Fatal   =   60,
        Off     =   70
    }
}
