using System.IO;
using System.Xml.Serialization;

namespace JpkGeneratorFromXsd
{
    static class NamespacePrefixer
    {
        // Taken from https://stackoverflow.com/questions/2339782/xml-serialization-and-namespace-prefixes/2339796#2339796
        public static void Serialize<T>(T value, string path)
        {
            using (var streamWriter = new StreamWriter(path))
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("tns", "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(streamWriter, value, ns);
            }
        }
    }
}