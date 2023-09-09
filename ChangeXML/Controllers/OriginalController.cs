using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ChangeXML.Controllers
{
    public static class OriginalController
    {
        public static T GetObjFromXML<T>(string path)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                return (T)xmlSerializer.Deserialize(fileStream);
            }            
        }

        public static void Save<T>(T obj, string path)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            using (StreamWriter writer = new StreamWriter(path))
            {
                xmlSerializer.Serialize(writer, obj);
            }
        }

        public static CnahgeXML.Core.TestModels.Templates.TechnicalInformation GetTechnicalInformation(string path)
        {
            var result = new CnahgeXML.Core.TestModels.Templates.TechnicalInformation();

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            var root = xmlDocument.DocumentElement;
            if (root != null)
            {
                foreach (XmlElement xnode in root)
                {
                    var parameter = new CnahgeXML.Core.TestModels.Templates.Parameter();

                    var order = xnode.Attributes.GetNamedItem("order");
                    var id = xnode.Attributes.GetNamedItem("id");

                    parameter.NameXmlElement = xnode.Name;
                    parameter.Order = long.Parse(order.Value);
                    parameter.Id = long.Parse(id.Value);

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "name")
                        {
                            parameter.Name = childnode.InnerText;
                        }

                        if (childnode.Name == "unit")
                        {
                            parameter.Unit = childnode.InnerText;
                        }
                    }

                    result.Parameters.Add(parameter);
                }
            }

            return result;
        }
    }
}