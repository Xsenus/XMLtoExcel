using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class DataProductTexts
    {

        private DataProductTextsTextDescript textdescriptField;

        private DataProductTextsText textField;

        /// <remarks/>
        public DataProductTextsTextDescript textdescript
        {
            get
            {
                return this.textdescriptField;
            }
            set
            {
                this.textdescriptField = value;
            }
        }

        /// <remarks/>
        public DataProductTextsText text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
}
