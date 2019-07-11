using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://servicerequest.nedbank.co.za")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://servicerequest.nedbank.co.za", IsNullable = false)]
    public partial class createServiceRequest
    {

        private string originatorChannelIdField;

        private uint applicationBankReferenceField;

        private byte requestTypeField;

        private string requestMessageField;

        private System.DateTime createdDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string originatorChannelId
        {
            get
            {
                return this.originatorChannelIdField;
            }
            set
            {
                this.originatorChannelIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public uint applicationBankReference
        {
            get
            {
                return this.applicationBankReferenceField;
            }
            set
            {
                this.applicationBankReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public byte requestType
        {
            get
            {
                return this.requestTypeField;
            }
            set
            {
                this.requestTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public string requestMessage
        {
            get
            {
                return this.requestMessageField;
            }
            set
            {
                this.requestMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public System.DateTime createdDate
        {
            get
            {
                return this.createdDateField;
            }
            set
            {
                this.createdDateField = value;
            }
        }
    }


}