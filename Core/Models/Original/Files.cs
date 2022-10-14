using System.Xml.Serialization;
using System.Collections.Generic;

namespace Core.Models.Original
{
    [XmlRoot(ElementName = "files")]
	public class Files
	{
		[XmlElement(ElementName = "file")]
		public List<File> File { get; set; }
	}
}