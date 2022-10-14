using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "height")]
	public class Height
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}