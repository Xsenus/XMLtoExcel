using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductInstock
    {

        private DataProductInstockStock stockField;

        private DataProductInstockStatus statusField;

        /// <remarks/>
        public DataProductInstockStock stock
        {
            get
            {
                return stockField;
            }
            set
            {
                stockField = value;
            }
        }

        /// <remarks/>
        public DataProductInstockStatus status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }
    }
}
