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
    [System.Xml.Serialization.XmlRootAttribute("GetValidationError.Request", Namespace = "", IsNullable = false)]
    public partial class GetValidationErrorRequest
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public RequestServiceHeader ServiceHeader { get; set; }
    }


}