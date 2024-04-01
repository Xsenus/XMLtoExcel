using System.IO;
using System.Xml.Serialization;

namespace EditingXML.Controllers
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
    }
}
