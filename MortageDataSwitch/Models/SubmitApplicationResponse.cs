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
    [System.Xml.Serialization.XmlRootAttribute("SubmitService.Reply", Namespace = "", IsNullable = false)]
    public partial class SubmitServiceReply : ReplyMessage
    {

        private SubmitServiceReplyServiceHeader serviceHeaderField;
        private SubmitServiceReplyParseErrors parseErrorsField;
        

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public SubmitServiceReplyServiceHeader ServiceHeader
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

        [System.Xml.Serialization.XmlElementAttribute("Parse.Errors")]
        public SubmitServiceReplyParseErrors ParseErrors
        {
            get
            {
                return this.parseErrorsField;
            }
            set
            {
                this.parseErrorsField = value;
            }
        }
        
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SubmitServiceReplyServiceHeader
    {

        private int applicationReferenceField;

        private string originatorReferenceField;

        private System.DateTime replyDateTimeField;

        private int serviceResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Reference")]
        public int ApplicationReference
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
        public int ServiceResult
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
    public partial class SubmitServiceReplyParseErrors
    {

        private SubmitServiceReplyParseErrorsParseError[] parseErrorField;

        private byte countField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parse.Error")]
        public SubmitServiceReplyParseErrorsParseError[] ParseError
        {
            get
            {
                return this.parseErrorField;
            }
            set
            {
                this.parseErrorField = value;
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
    public partial class SubmitServiceReplyParseErrorsParseError
    {

        private string severityField;

        private string fieldField;

        private string descriptionField;

        private string fullDescriptionField;

        /// <remarks/>
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public string Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string FullDescription
        {
            get
            {
                return this.fullDescriptionField;
            }
            set
            {
                this.fullDescriptionField = value;
            }
        }
    }


}