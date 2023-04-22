using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using XSD_Document.Dto;

namespace XSD_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xsdPath = @"D:\\user\\example.xsd";
             

            // XSD belgesi için örnek bir nesne oluşturuluyor
            Person person = new Person()
            {
                ID = "1",
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com",
                Address = "123 Main St"
            };

            // Nesne, XSD belgesine serileştiriliyor
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (TextWriter writer = new StreamWriter(xsdPath))
            {
                serializer.Serialize(writer, person);
            }

            Console.WriteLine("XSD belgesi oluşturuldu!");

        }
    }
}