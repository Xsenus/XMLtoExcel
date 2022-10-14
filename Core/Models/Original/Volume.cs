using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "volume")]
	public class Volume
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}