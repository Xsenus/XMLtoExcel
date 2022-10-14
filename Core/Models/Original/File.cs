using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "file")]
	public class File
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		
		[XmlAttribute(AttributeName = "mime")]
		public string Mime { get; set; }
		
		[XmlAttribute(AttributeName = "modified")]
		public string Modified { get; set; }
		
		[XmlAttribute(AttributeName = "md5")]
		public string Md5 { get; set; }
		
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}