using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lesson13.MyClasses
{
    internal static class DeserializationFromXml
    {
        public static void DeserializeFromXml()
        {
            XmlSerializer carFromXml = new XmlSerializer(typeof(Cars));
            string path = "E:\\TMS\\lesson13\\forSerialization\\car.xml";
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    Cars car = (Cars)carFromXml.Deserialize(stream);
                    if (car != null)
                    {
                        Console.WriteLine("Deserialization from XML was successful!");
                        Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
                    }
                    else
                    {
                        Console.WriteLine("Deserialization failed: car is null.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }
    }
}
