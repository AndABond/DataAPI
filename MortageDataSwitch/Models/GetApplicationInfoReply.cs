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
    [System.Xml.Serialization.XmlRootAttribute("GetApplicationInfo.Reply", Namespace = "", IsNullable = false)]
    public partial class GetApplicationInfoReply
    {

        private GetApplicationInfoReplyServiceHeader serviceHeaderField;

        private GetApplicationInfoReplyStatusMessages statusMessagesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public GetApplicationInfoReplyServiceHeader ServiceHeader
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status.Messages")]
        public GetApplicationInfoReplyStatusMessages StatusMessages
        {
            get
            {
                return this.statusMessagesField;
            }
            set
            {
                this.statusMessagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GetApplicationInfoReplyServiceHeader
    {

        private uint applicationReferenceField;

        private ulong originatorReferenceField;

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
        public ulong OriginatorReference
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GetApplicationInfoReplyStatusMessages
    {

        private GetApplicationInfoReplyStatusMessagesApplicationStatus[] applicationStatusField;

        private byte countField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Status")]
        public GetApplicationInfoReplyStatusMessagesApplicationStatus[] ApplicationStatus
        {
            get
            {
                return this.applicationStatusField;
            }
            set
            {
                this.applicationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GetApplicationInfoReplyStatusMessagesApplicationStatus
    {

        private uint applicationReferenceField;

        private byte statusIdField;

        private System.DateTime statusDateField;

        private string statusDescriptionField;

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
        [System.Xml.Serialization.XmlElementAttribute("Status.Id")]
        public byte StatusId
        {
            get
            {
                return this.statusIdField;
            }
            set
            {
                this.statusIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status.Date")]
        public System.DateTime StatusDate
        {
            get
            {
                return this.statusDateField;
            }
            set
            {
                this.statusDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status.Description")]
        public string StatusDescription
        {
            get
            {
                return this.statusDescriptionField;
            }
            set
            {
                this.statusDescriptionField = value;
            }
        }
    }


}