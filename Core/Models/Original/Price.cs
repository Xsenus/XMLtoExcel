using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "price")]
	public class Price
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}