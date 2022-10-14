using System.Xml.Serialization;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "instock")]
	public class Instock
	{
		[XmlElement(ElementName = "stock")]
		public Stock Stock { get; set; }
		
		[XmlElement(ElementName = "status")]
		public Status Status { get; set; }
	}
}