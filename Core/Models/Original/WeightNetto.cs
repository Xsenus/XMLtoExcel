using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "weight_netto")]
	public class WeightNetto
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}