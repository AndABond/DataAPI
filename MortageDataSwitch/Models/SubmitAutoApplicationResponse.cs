using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    public class SubmitAutoApplicationResponse
    {
        public SubmitServiceReply Absa { get; set; }
        public SubmitServiceReply Fnb { get; set; }
        public SubmitServiceReply Nedbank { get; set; }
        public SubmitServiceReply Sbsa { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string StatusMessage { get; set; }
    }
}