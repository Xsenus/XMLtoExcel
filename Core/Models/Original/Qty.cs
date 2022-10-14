using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "qty")]
	public class Qty
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}