using System;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    [Serializable()]
    public partial class DataProduct
    {
        [XmlElement("article")]
        public string Article { get; set; }

        [XmlElement("ean13")]
        public string Ean13 { get; set; }

        [XmlElement("groups")]
        //[XmlArrayItem("group", IsNullable = false)]
        public DataProductGroup[] Groups { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("brand")]
        public ushort Brand { get; set; }

        [XmlElement("warranty")]
        public string Warranty { get; set; }

        [XmlElement("tnved")]
        public string Tnved { get; set; }

        [XmlElement("tnvedtext")]
        public string Tnvedtext { get; set; }

        [XmlElement("texts")]
        //[XmlArrayItem("text", IsNullable = false)]
        public DataProductText[] Texts { get; set; }

        [XmlElement("obsolete")]
        public sbyte Obsolete { get; set; }

        [XmlElement("assembledproduct")]
        public byte Assembledproduct { get; set; }

        [XmlElement("statuses")]
        public DataProductStatuses Statuses { get; set; }

        [XmlElement("unit")]
        public ushort Unit { get; set; }

        [XmlElement("package")]
        public DataProductPackage Package { get; set; }

        [XmlElement("container")]
        public DataProductContainer Container { get; set; }

        [XmlElement("prices")]
        public DataProductPrices Prices { get; set; }

        [XmlElement("instock")]
        public DataProductInstock Instock { get; set; }

        [XmlElement("arrival")]
        public DataProductArrival Arrival { get; set; }

        [XmlElement("files")]
        //[XmlArrayItem("file", IsNullable = false)]
        public DataProductFile[] Files { get; set; }
    }
}
