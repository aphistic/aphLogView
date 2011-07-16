using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace aphLogView.Shared.Data
{
    public static class LogLevelHelper
    {
        public static LogLevel GetLogLevel(string level)
        {
            var checkLevel = level.Trim().ToLower();
            switch (checkLevel)
            {
                case "debug":
                    return LogLevel.Debug;
                case "info":
                    return LogLevel.Info;
                case "warn":
                    return LogLevel.Warn;
                case "error":
                    return LogLevel.Error;
                case "fatal":
                    return LogLevel.Fatal;
                default:
                    return LogLevel.Unknown;
            }
        }

        public static Color GetLogLevelColor(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    return Color.Green;
                case LogLevel.Info:
                    return Color.LightGreen;
                case LogLevel.Warn:
                    return Color.Yellow;
                case LogLevel.Error:
                    return Color.Orange;
                case LogLevel.Fatal:
                    return Color.Red;
                default:
                    return Color.White;
            }
        }
    }
}
