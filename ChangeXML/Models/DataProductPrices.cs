using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductPrices
    {

        private DataProductPricesPrice[] priceField;

        private string currencyField;

        /// <remarks/>
        [XmlElement("price")]
        public DataProductPricesPrice[] price
        {
            get
            {
                return priceField;
            }
            set
            {
                priceField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string currency
        {
            get
            {
                return currencyField;
            }
            set
            {
                currencyField = value;
            }
        }
    }
}
