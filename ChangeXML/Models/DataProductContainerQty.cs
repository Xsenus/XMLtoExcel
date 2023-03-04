using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductContainerQty
    {

        private ushort unitField;

        private ushort valueField;

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
        public ushort Value
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
