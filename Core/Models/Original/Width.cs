using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "width")]
	public class Width
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}