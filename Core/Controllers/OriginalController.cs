using Core.Models.Original;
using System.IO;
using System.Xml.Serialization;

namespace Core.Controllers
{
    public static class OriginalController
    {
        public static Data GetDataFromXML(string path)
        {
            var xmlSerializer = new XmlSerializer(typeof(Data));
            
            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                return xmlSerializer.Deserialize(fileStream) as Data;
            }            
        }
    }
}