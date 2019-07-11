using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("GetLiveRepliesByDateRange.Request", Namespace = "", IsNullable = false)]
    public partial class GetLiveRepliesByDateRangeRequest
    {

        private GetLiveRepliesByDateRangeRequestLiveReplyRequestInfo liveReplyRequestInfoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public RequestServiceHeader ServiceHeader { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LiveReply.RequestInfo")]
        public GetLiveRepliesByDateRangeRequestLiveReplyRequestInfo LiveReplyRequestInfo
        {
            get
            {
                return this.liveReplyRequestInfoField;
            }
            set
            {
                this.liveReplyRequestInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GetLiveRepliesByDateRangeRequestLiveReplyRequestInfo
    {

        private string liveReplyDateFromField;

        private string liveReplyDateToField;

        private string originatorIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LiveReply.DateFrom", DataType = "date")]
        public string LiveReplyDateFrom
        {
            get
            {
                return this.liveReplyDateFromField;
            }
            set
            {
                this.liveReplyDateFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LiveReply.DateTo", DataType = "date")]
        public string LiveReplyDateTo
        {
            get
            {
                return this.liveReplyDateToField;
            }
            set
            {
                this.liveReplyDateToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Originator.Id")]
        public string OriginatorId
        {
            get
            {
                return this.originatorIdField;
            }
            set
            {
                this.originatorIdField = value;
            }
        }
    }


}