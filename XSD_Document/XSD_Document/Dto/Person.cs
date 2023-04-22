using System;
using System.Xml.Serialization;
using System.IO;

// Örnek bir XSD belgesi tanımı
[XmlRoot("Person")]
public class Person
{
    [XmlAttribute("ID")]
    public string ID { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("Email")]
    public string Email { get; set; }

    [XmlElement("Address")]
    public string Address { get; set; }
}

 
