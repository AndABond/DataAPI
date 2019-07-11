using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    public class SubmitDocumentsRequest
    {
        public List<ApplicationDocument> Documents { get; set; } = new List<ApplicationDocument>();
    }

    public class ApplicationDocument
    {
        public string DocumentName { get; set; }
        public string MimeType { get; set; }
        public string Base64File { get; set; }
        public long ApplicationId { get; set; }
    }
}