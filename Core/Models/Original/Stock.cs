using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "stock")]
	public class Stock
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}