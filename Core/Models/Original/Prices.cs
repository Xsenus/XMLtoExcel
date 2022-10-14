using System.Xml.Serialization;
using System.Collections.Generic;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "prices")]
	public class Prices
	{
		[XmlElement(ElementName = "price")]
		public List<Price> Price { get; set; }
		
		[XmlAttribute(AttributeName = "currency")]
		public string Currency { get; set; }
	}
}