using System.Xml.Serialization;

namespace Core.Models.Original
{
    public class DateArrival
	{
		[XmlRoot(ElementName = "date")]
		public class Date
		{
			[XmlAttribute(AttributeName = "type")]
			public string Type { get; set; }
			[XmlText]
			public string Text { get; set; }
		}
	}
}