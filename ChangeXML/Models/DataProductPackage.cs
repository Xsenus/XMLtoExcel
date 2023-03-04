using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class DataProductPackage
    {

        private string nameField;

        private DataProductPackageQty qtyField;

        private DataProductPackageLength lengthField;

        private DataProductPackageWidth widthField;

        private DataProductPackageHeight heightField;

        private dataProductPackageWeight weightField;

        private DataProductPackageWeightNetto weight_nettoField;

        private DataProductPackageVolume volumeField;

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
        public DataProductPackageQty qty
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
        public DataProductPackageLength length
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
        public DataProductPackageWidth width
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
        public DataProductPackageHeight height
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
        public dataProductPackageWeight weight
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
        public DataProductPackageWeightNetto weight_netto
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
        public DataProductPackageVolume volume
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
