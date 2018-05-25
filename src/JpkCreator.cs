using System;
using AutoFixture;

namespace JpkGeneratorFromXsd
{
    public class JpkCreator
    {
        public static void CreateWithAutoFixture()
        {
            Fixture fixture = new Fixture();

            JPK jpk = fixture.Create<JPK>();

            NamespacePrefixer.Serialize(jpk, "JPK_VAT_output_from_AutoFixture.xml");
        }
    }
}