using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "statuses")]
	public class Statuses
	{
		[XmlElement(ElementName = "status")]
		public Status Status { get; set; }
	}
}