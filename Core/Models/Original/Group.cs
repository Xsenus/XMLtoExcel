using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "group")]
	public class Group
	{
		[XmlAttribute(AttributeName = "order")]
		public string Order { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}