using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductContainer
    {

        private string nameField;

        private DataProductContainerQty qtyField;

        private DataProductContainerLength lengthField;

        private DataProductContainerWidth widthField;

        private DataProductContainerHeight heightField;

        private DataProductContainerWeight weightField;

        private DataProductContainerWeightNetto weight_nettoField;

        private DataProductContainerVolume volumeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        public DataProductContainerQty qty
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

        /// <remarks/>
        public DataProductContainerLength length
        {
            get
            {
                return lengthField;
            }
            set
            {
                lengthField = value;
            }
        }

        /// <remarks/>
        public DataProductContainerWidth width
        {
            get
            {
                return widthField;
            }
            set
            {
                widthField = value;
            }
        }

        /// <remarks/>
        public DataProductContainerHeight height
        {
            get
            {
                return heightField;
            }
            set
            {
                heightField = value;
            }
        }

        /// <remarks/>
        public DataProductContainerWeight weight
        {
            get
            {
                return weightField;
            }
            set
            {
                weightField = value;
            }
        }

        /// <remarks/>
        public DataProductContainerWeightNetto weight_netto
        {
            get
            {
                return weight_nettoField;
            }
            set
            {
                weight_nettoField = value;
            }
        }

        /// <remarks/>
        public DataProductContainerVolume volume
        {
            get
            {
                return volumeField;
            }
            set
            {
                volumeField = value;
            }
        }
    }
}
