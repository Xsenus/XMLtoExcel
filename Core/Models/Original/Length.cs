using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "length")]
	public class Length
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}