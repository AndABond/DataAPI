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
    [System.Xml.Serialization.XmlRootAttribute("LookupService.Request", Namespace = "", IsNullable = false)]
    public class LookupServiceRequest
    {

        private List<LookupServiceRequestLookupTables> lookupTablesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Service.Header")]
        public RequestServiceHeader ServiceHeader { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lookup.Tables")]
        public List<LookupServiceRequestLookupTables> LookupTables
        {
            get
            {
                return this.lookupTablesField;
            }
            set
            {
                this.lookupTablesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class LookupServiceRequestLookupTables
    {

        private string lookupTableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lookup.Table")]
        public string LookupTable
        {
            get
            {
                return this.lookupTableField;
            }
            set
            {
                this.lookupTableField = value;
            }
        }
    }


}