using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "text")]
	public class TextObj
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
				
		[XmlAttribute(AttributeName = "mime")]
		public string Mime { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}