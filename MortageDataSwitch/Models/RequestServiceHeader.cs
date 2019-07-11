using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortageDataSwitch.Models
{
    /// <summary>
    /// Default Header for all requests
    /// </summary>
    public class RequestServiceHeader
    {
        [System.Xml.Serialization.XmlElementAttribute("Application.Action")]
        public string ApplicationAction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.ApplicationType")]
        public string ApplicationApplicationType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Mac")]
        public string ApplicationMac { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Reference")]
        public string ApplicationReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Channel.Code")]
        public string ChannelCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Channel.Password")]
        public string ChannelPassword { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Channel.Username")]
        public string ChannelUsername { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Originator.Branch.Id")]
        public string OriginatorBranchId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Originator.Id")]
        public string OriginatorId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Originator.Reference")]
        public string OriginatorReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Request.DateTime")]
        public string RequestDateTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Key")]
        public ServiceHeaderServiceKey ServiceKey { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Version")]
        public string ServiceVersion { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Application.Group.Id")]
        public string ApplicationGroupId { get; set; }
    }

    /// <summary>
    /// Key value
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ServiceHeaderServiceKey
    {
        public ServiceKeyRSAKeyValue RSAKeyValue { get; set; }
    }

    /// <summary>
    /// Key properties
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ServiceKeyRSAKeyValue
    {
        public string Modulus { get; set; }
        
        public string Exponent { get; set; }

    }
}