using System.Xml.Serialization;
using System.Collections.Generic;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "groups")]
	public class Groups
	{
		[XmlElement(ElementName = "group")]
		public List<Group> Group { get; set; }
	}
}