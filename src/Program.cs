using System;
using System.IO;

namespace JpkGeneratorFromXsd
{
    class Program
    {
        static void Main(string[] args)
        {
            JpkCreator.CreateWithAutoFixture();

            var path = @"JPK_VAT_example.xml";

            if (File.Exists(path))
            {
                JPK jpk = XmlSerializerHelper.FromFile<JPK>(path);
                NamespacePrefixer.Serialize(jpk, "JPK_VAT_output.xml");
            }

            Console.WriteLine("Done");
        }
    }
}
