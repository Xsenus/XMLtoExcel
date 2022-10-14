using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "status")]
	public class Status
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}