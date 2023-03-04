using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductStatuses
    {

        private DataProductStatusesStatus statusField;

        /// <remarks/>
        public DataProductStatusesStatus status
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
