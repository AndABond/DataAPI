using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("GetTableValuesZipped.Reply", Namespace = "", IsNullable = false)]
    public class GetTableValuesZippedReply
    {

        private GetTableValuesZippedReplyServiceHeader serviceHeaderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public GetTableValuesZippedReplyServiceHeader ServiceHeader
        {
            get
            {
                return this.serviceHeaderField;
            }
            set
            {
                this.serviceHeaderField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class GetTableValuesZippedReplyServiceHeader
    {

        private System.DateTime replyDateTimeField;

        private byte serviceResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reply.DateTime")]
        public System.DateTime ReplyDateTime
        {
            get
            {
                return this.replyDateTimeField;
            }
            set
            {
                this.replyDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Result")]
        public byte ServiceResult
        {
            get
            {
                return this.serviceResultField;
            }
            set
            {
                this.serviceResultField = value;
            }
        }
    }


}