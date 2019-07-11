using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Enums
{
    /// <summary>
    /// Enum to define which lookup Facade to be used
    /// </summary>
    public enum LookupEnum
    {
        TableValues = 1,
        TableValuesZipped = 2,
        TableVersionInfo = 3
    }
}