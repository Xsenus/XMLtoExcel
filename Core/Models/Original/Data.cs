using System.Xml.Serialization;
using System.Collections.Generic;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "data")]
	public class Data
	{
		[XmlElement(ElementName = "product")]
		public List<Product> Product { get; set; }
		
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
		
		[XmlAttribute(AttributeName = "created")]
		public string Created { get; set; }
	}
}