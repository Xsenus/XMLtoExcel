using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "product")]
	public partial class Product
	{
		[XmlElement(ElementName = "article")]
		public string Article { get; set; }

        [XmlElement(ElementName = "ean13")]
        public string Ean13 { get; set; }

        [XmlElement(ElementName = "groups")]
        public Groups Groups { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "brand")]
        public string Brand { get; set; }

        [XmlElement(ElementName = "warranty")]
        public string Warranty { get; set; }

        [XmlElement(ElementName = "tnved")]
        public string Tnved { get; set; }

        [XmlElement(ElementName = "tnvedtext")]
        public string Tnvedtext { get; set; }

        [XmlElement(ElementName = "texts")]
        public Texts Texts { get; set; }

        [XmlElement(ElementName = "obsolete")]
        public string Obsolete { get; set; }

        [XmlElement(ElementName = "unit")]
        public string Unit { get; set; }

        [XmlElement(ElementName = "package")]
        public Package Package { get; set; }

        [XmlElement(ElementName = "container")]
        public Container Container { get; set; }

        [XmlElement(ElementName = "prices")]
        public Prices Prices { get; set; }

        [XmlElement(ElementName = "instock")]
        public Instock Instock { get; set; }
        
        [XmlElement(ElementName = "arrival")]
        public Arrival Arrival { get; set; }

        [XmlElement(ElementName = "files")]
        public Files Files { get; set; }

        [XmlElement(ElementName = "statuses")]
        public Statuses Statuses { get; set; }
    }
}