using System.Collections.Generic;
using System.Xml.Serialization;

namespace EditingXML.Models
{
    [XmlRoot(ElementName = "related")]
    public class Related
    {

        [XmlElement(ElementName = "article")]
        public List<string> Article { get; set; }
    }

    [XmlRoot(ElementName = "product")]
    public class Product
    {

        [XmlElement(ElementName = "article")]
        public string Article { get; set; }

        [XmlElement(ElementName = "related")]
        public Related Related { get; set; }
    }

    [XmlRoot(ElementName = "products")]
    public class Products
    {

        [XmlElement(ElementName = "product")]
        public List<Product> Product { get; set; }
    }

    [XmlRoot(ElementName = "relation")]
    public class Relation
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "marking")]
        public string Marking { get; set; }

        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }
    }

    [XmlRoot(ElementName = "relations")]
    public class Relations
    {

        [XmlElement(ElementName = "relation")]
        public List<Relation> Relation { get; set; }
    }

    [XmlRoot(ElementName = "data")]
    public class RootRelation
    {

        [XmlElement(ElementName = "relations")]
        public Relations Relations { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public double Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
