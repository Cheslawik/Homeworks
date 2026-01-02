using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace lesson13.MyClasses
{
    internal static class SerializationToXml
    {
        public static void SerializeToXml(Cars car)
        {
            XmlSerializer carToXml = new XmlSerializer(typeof(Cars));
            string path = "E:\\TMS\\lesson13\\forSerialization\\car.xml";

            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    carToXml.Serialize(stream, car);
                }
                Console.WriteLine($"Serialization to XML was successful! File path - {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error to record: {ex.Message}");
            }


        }
    }
}
