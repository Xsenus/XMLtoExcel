using System.Xml.Serialization;

namespace Core.Models.Original
{
    public class Arrival
    {
        [XmlElement(ElementName = "date")]
        public DateArrival Date { get; set; }
        
        [XmlElement(ElementName = "status")]
        public Status Status { get; set; }
        
        [XmlElement(ElementName = "qty")]
        public Qty Qty { get; set; }
    }
}