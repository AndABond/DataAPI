using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Tools
{
    /// <summary>
    /// Utils to specific time based function
    /// </summary>
    public static class TimeUtils
    {
        /// <summary>
        /// Forfulle get current RSA time
        /// </summary>
        /// <returns></returns>
        public static DateTime GetRSATime()
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");
            DateTime rsaTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            return rsaTime;
        }
    }
}