using System.IO;
using System.Xml.Serialization;

namespace JpkGeneratorFromXsd
{
    public class XmlSerializerHelper
    {
        public static T FromFile<T>(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                return (T)serializer.Deserialize(reader);
            }
        }
    }
}