using JsonAndXML;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Serialization;

//XmlSerializer serializer = new XmlSerializer(typeof(XMLClass));

//using (MemoryStream teszt = new MemoryStream())
//{
//    XMLClass kiirando = new XMLClass
//    {
//        Egesz = 42,
//        Tort = 3.1415
//    };
//    Console.WriteLine("Írás előtt:");
//    Console.WriteLine(kiirando);

//    serializer.Serialize(teszt, kiirando);

//    //visszaállunk a stream elejére
//    //az írás után a végén vagyunk
//    teszt.Seek(0, SeekOrigin.Begin);

//    Console.WriteLine("XML adat:\n");
//    using (var reader = new StreamReader(teszt, Encoding.UTF8, false, 1024, true))
//    {
//        Console.WriteLine(reader.ReadToEnd());
//    }

//    //visszaállunk ismét a stream elejére
//    teszt.Seek(0, SeekOrigin.Begin);

//    Console.WriteLine("\nOlvasás után: ");
//    XMLClass beolvasott = (XMLClass)serializer.Deserialize(teszt);
//    Console.WriteLine(beolvasott);
//}


JsonClass kiirando = new JsonClass
{
    Egesz = 42,
    Tort = 3.1415
};
string json = JsonConvert.SerializeObject(kiirando, Formatting.Indented);

Console.WriteLine("Json:");
Console.WriteLine(json);

JsonClass vissza = JsonConvert.DeserializeObject<JsonClass>(json);

Console.WriteLine(vissza);