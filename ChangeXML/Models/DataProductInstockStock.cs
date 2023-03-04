using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductInstockStock
    {

        private string typeField;

        private ushort unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ushort unit
        {
            get
            {
                return unitField;
            }
            set
            {
                unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }
}
