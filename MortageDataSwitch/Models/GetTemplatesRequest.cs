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
    [System.Xml.Serialization.XmlRootAttribute("GetTemplates.Request", Namespace = "", IsNullable = false)]
    public partial class GetTemplatesRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public RequestServiceHeader ServiceHeader { get; set; }
    }
}