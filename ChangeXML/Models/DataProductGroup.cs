using System;
using System.Xml.Serialization;

namespace ChangeXML.Models
{
    [Serializable()]
    [XmlRoot(ElementName = "group")]
    public partial class DataProductGroup
    {
        [XmlAttribute("order")]
        public long Order { get; set; }

        [XmlText()]
        public ushort Value { get; set; }
    }
}
