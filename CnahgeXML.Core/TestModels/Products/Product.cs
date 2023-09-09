using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CnahgeXML.Core.TestModels.Products
{
    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class data
    {
        /// <remarks/>
        [XmlElement("product")]
        public dataProduct[] product { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public decimal version { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime created { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductTextsTextdescript
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductTextsText
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductTexts
    {
        /// <remarks/>
        public dataProductTextsTextdescript textdescript { get; set; }

        /// <remarks/>
        public dataProductTextsText text { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProduct
    {
        /// <remarks/>
        public string article { get; set; }

        /// <remarks/>
        public string ean13 { get; set; }

        /// <remarks/>
        [XmlArrayItem("group", IsNullable = false)]
        public dataProductGroup[] groups { get; set; }

        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public ushort brand { get; set; }

        /// <remarks/>
        public string warranty { get; set; }

        /// <remarks/>
        public string tnved { get; set; }

        /// <remarks/>
        public string tnvedtext { get; set; }

        /// <remarks/>
        //[XmlArrayItem("text", IsNullable = false)]
        //public dataProductText[] texts { get; set; }

        /// <remarks/>
        public string modified { get; set; }

        /// <remarks/>        
        public dataProductTexts texts { get; set; }

        /// <remarks/>
        public sbyte obsolete { get; set; }

        /// <remarks/>
        public byte assembledproduct { get; set; }

        /// <remarks/>
        public dataProductStatuses statuses { get; set; }

        /// <remarks/>
        public ushort unit { get; set; }

        /// <remarks/>
        public dataProductPackage package { get; set; }

        /// <remarks/>
        public dataProductContainer container { get; set; }

        /// <remarks/>
        public dataProductPrices prices { get; set; }

        /// <remarks/>
        public dataProductInstock instock { get; set; }

        /// <remarks/>
        public dataProductArrival arrival { get; set; }

        /// <remarks/>
        //[XmlArrayItem("file", IsNullable = false)]
        //public dataProductFile[] files { get; set; }
        public dataProductFiles files { get; set; }

        [XmlElement("techdata")]
        public string techdata { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFile
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }


    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFileimage
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFilemain
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFileman
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFilepapp
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFilepdf
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFilephoto
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFilesFileppack
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string mime { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string md5 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string id { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFiles
    {
        /// <remarks/>
        [XmlElement("file", typeof(dataProductFilesFile))]
        [XmlElement("fileimage", typeof(dataProductFilesFileimage))]
        [XmlElement("filemain", typeof(dataProductFilesFilemain))]
        [XmlElement("fileman", typeof(dataProductFilesFileman))]
        [XmlElement("filepapp", typeof(dataProductFilesFilepapp))]
        [XmlElement("filepdf", typeof(dataProductFilesFilepdf))]
        [XmlElement("filephoto", typeof(dataProductFilesFilephoto))]
        [XmlElement("fileppack", typeof(dataProductFilesFileppack))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductGroup
    {
        /// <remarks/>
        [XmlAttribute()]
        public string order { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductText
    {

        private string typeField;

        private string mimeField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string mime
        {
            get
            {
                return this.mimeField;
            }
            set
            {
                this.mimeField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductStatuses
    {

        private dataProductStatusesStatus statusField;

        /// <remarks/>
        public dataProductStatusesStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductStatusesStatus
    {

        private string typeField;

        private sbyte valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public sbyte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackage
    {

        private string nameField;

        private dataProductPackageQty qtyField;

        private dataProductPackageLength lengthField;

        private dataProductPackageWidth widthField;

        private dataProductPackageHeight heightField;

        private dataProductPackageWeight weightField;

        private dataProductPackageWeight_netto weight_nettoField;

        private dataProductPackageVolume volumeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageQty qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageLength length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageWidth width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageHeight height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageWeight weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageWeight_netto weight_netto
        {
            get
            {
                return this.weight_nettoField;
            }
            set
            {
                this.weight_nettoField = value;
            }
        }

        /// <remarks/>
        public dataProductPackageVolume volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageQty
    {

        private ushort unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public ushort unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageLength
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageWidth
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageHeight
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageWeight
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageWeight_netto
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPackageVolume
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainer
    {

        private string nameField;

        private dataProductContainerQty qtyField;

        private dataProductContainerLength lengthField;

        private dataProductContainerWidth widthField;

        private dataProductContainerHeight heightField;

        private dataProductContainerWeight weightField;

        private dataProductContainerWeight_netto weight_nettoField;

        private dataProductContainerVolume volumeField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerQty qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerLength length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerWidth width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerHeight height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerWeight weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerWeight_netto weight_netto
        {
            get
            {
                return this.weight_nettoField;
            }
            set
            {
                this.weight_nettoField = value;
            }
        }

        /// <remarks/>
        public dataProductContainerVolume volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerQty
    {

        private ushort unitField;

        private ushort valueField;

        /// <remarks/>
        [XmlAttribute()]
        public ushort unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerLength
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerWidth
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerHeight
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerWeight
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerWeight_netto
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductContainerVolume
    {

        private byte unitField;

        private decimal valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPricesPricer
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPrices
    {
        /// <remarks/>
        public dataProductPricesPricer pricer { get; set; }

        /// <remarks/>
        [XmlElement("price")]
        public dataProductPricesPrice[] price { get; set; }

        /// <remarks/>
        public dataProductPricesPrice1 price1 { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string currency { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPricesPrice
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductPricesPrice1
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductInstock
    {

        private dataProductInstockStock stockField;

        private dataProductInstockStatus statusField;

        /// <remarks/>
        public dataProductInstockStock stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }

        /// <remarks/>
        public dataProductInstockStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductInstockStock
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
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public ushort unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductInstockStatus
    {

        private string typeField;

        private sbyte valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public sbyte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductArrival
    {

        private dataProductArrivalDate dateField;

        private dataProductArrivalStatus statusField;

        private dataProductArrivalQty qtyField;

        /// <remarks/>
        public dataProductArrivalDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public dataProductArrivalStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public dataProductArrivalQty qty
        {
            get
            {
                return this.qtyField;
            }
            set
            {
                this.qtyField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductArrivalDate
    {

        private string typeField;

        private DateTime valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductArrivalStatus
    {
        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlText()]
        public sbyte Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductArrivalQty
    {

        /// <remarks/>
        [XmlAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [XmlText()]
        public decimal Value { get; set; }
    }

    /// <remarks/>
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class dataProductFile
    {

        private string typeField;

        private string mimeField;

        private DateTime modifiedField;

        private string md5Field;

        private string nameField;

        private string idField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string mime
        {
            get
            {
                return this.mimeField;
            }
            set
            {
                this.mimeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public DateTime modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                this.modifiedField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string md5
        {
            get
            {
                return this.md5Field;
            }
            set
            {
                this.md5Field = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
