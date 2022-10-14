using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "package")]
	public class Package
	{
		[XmlElement(ElementName = "name")]
		public string Name { get; set; }
		
		[XmlElement(ElementName = "qty")]
		public Qty Qty { get; set; }
		
		[XmlElement(ElementName = "length")]
		public Length Length { get; set; }
		
		[XmlElement(ElementName = "width")]
		public Width Width { get; set; }
		
		[XmlElement(ElementName = "height")]
		public Height Height { get; set; }
		
		[XmlElement(ElementName = "weight")]
		public Weight Weight { get; set; }
		
		[XmlElement(ElementName = "weight_netto")]
		public WeightNetto Weight_netto { get; set; }
		
		[XmlElement(ElementName = "volume")]
		public Volume Volume { get; set; }
	}
}