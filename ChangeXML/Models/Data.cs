using System;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    [Serializable()]
    [XmlRoot(ElementName = "data")]
    public partial class Data
    {
        [XmlElement("product")]
        public DataProduct[] Product { get; set; }

        [XmlAttribute("version")]
        public decimal Version { get; set; }

        [XmlAttribute("created")]
        public DateTime Created { get; set; }
    }
}
