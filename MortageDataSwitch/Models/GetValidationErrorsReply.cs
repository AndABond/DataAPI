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
    [System.Xml.Serialization.XmlRootAttribute("GetValidationErrors.Reply", Namespace = "", IsNullable = false)]
    public partial class GetValidationErrorsReply
    {

        private GetValidationErrorsReplyServiceHeader serviceHeaderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public GetValidationErrorsReplyServiceHeader ServiceHeader
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
    public partial class GetValidationErrorsReplyServiceHeader
    {

        private uint applicationReferenceField;

        private string originatorReferenceField;

        private System.DateTime replyDateTimeField;

        private byte serviceResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Reference")]
        public uint ApplicationReference
        {
            get
            {
                return this.applicationReferenceField;
            }
            set
            {
                this.applicationReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Originator.Reference")]
        public string OriginatorReference
        {
            get
            {
                return this.originatorReferenceField;
            }
            set
            {
                this.originatorReferenceField = value;
            }
        }

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