using System.Xml.Serialization;
using System.Collections.Generic;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "texts")]
	public class Texts
	{
		[XmlElement(ElementName = "text")]
		public List<TextObj> Text { get; set; }
	}
}