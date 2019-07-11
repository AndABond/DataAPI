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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class createServiceRequestResponse
    {

        private string serviceRequestReferenceField;

        private uint applicationBankReferenceField;

        private bool containsErrorsField;

        private createServiceRequestResponseResponses responsesField;

        /// <remarks/>
        public string serviceRequestReference
        {
            get
            {
                return this.serviceRequestReferenceField;
            }
            set
            {
                this.serviceRequestReferenceField = value;
            }
        }

        /// <remarks/>
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
        public bool containsErrors
        {
            get
            {
                return this.containsErrorsField;
            }
            set
            {
                this.containsErrorsField = value;
            }
        }

        /// <remarks/>
        public createServiceRequestResponseResponses responses
        {
            get
            {
                return this.responsesField;
            }
            set
            {
                this.responsesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class createServiceRequestResponseResponses
    {

        private createServiceRequestResponseResponsesResponse responseField;

        /// <remarks/>
        public createServiceRequestResponseResponsesResponse response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class createServiceRequestResponseResponsesResponse
    {

        private byte codeField;

        private string descriptionField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string description
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
    }


}