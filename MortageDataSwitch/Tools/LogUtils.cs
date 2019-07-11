using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Tools
{
    public class LogUtils
    {
        public static void Init()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller = new RollingFileAppender();
            roller.AppendToFile = true;

            //roller.File = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\MortageDataSwitch\\data-switch-log.txt";
            roller.File = $".\\MortageDataSwitchLogs\\data-switch-log.txt";
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 0;
            roller.MaximumFileSize = "5MB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.LockingModel = new FileAppender.MinimalLock();
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            MemoryAppender memory = new MemoryAppender();
            memory.ActivateOptions();
            hierarchy.Root.AddAppender(memory);

#if DEBUG
            hierarchy.Root.Level = Level.Debug;
#else
            hierarchy.Root.Level = Level.Error;
#endif
            hierarchy.Configured = true;
        }
    }
}