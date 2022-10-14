using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "weight")]
	public class Weight
	{
		[XmlAttribute(AttributeName = "unit")]
		public string Unit { get; set; }
		
		[XmlText]
		public string Text { get; set; }
	}
}