using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductArrival
    {

        private DataProductArrivalDate dateField;

        private DataProductArrivalStatus statusField;

        private DataProductArrivalQty qtyField;

        /// <remarks/>
        public DataProductArrivalDate date
        {
            get
            {
                return dateField;
            }
            set
            {
                dateField = value;
            }
        }

        /// <remarks/>
        public DataProductArrivalStatus status
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

        /// <remarks/>
        public DataProductArrivalQty qty
        {
            get
            {
                return qtyField;
            }
            set
            {
                qtyField = value;
            }
        }
    }
}
