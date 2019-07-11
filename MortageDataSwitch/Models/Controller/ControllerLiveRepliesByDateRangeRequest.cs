using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models.Controller
{
    /// <summary>
    /// Controller request to get live replies
    /// </summary>
    public class ControllerLiveRepliesByDateRangeRequest
    {
        /// <summary>
        /// yyyy-MM-ddTHH:mm:ss
        /// </summary>
        public string DateFrom { get; set; }

        /// <summary>
        /// yyyy-MM-ddTHH:mm:ss
        /// </summary>
        public string DateTo { get; set; }

        /// <summary>
        /// Application ref returned by submit application
        /// </summary>
        public string ApplicationReference { get; set; }
    }
}