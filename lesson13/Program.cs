using System.Text.Json;
using lesson13.MyClasses;

namespace lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new MyClasses.Cars("235iojf34241mr2p3oj")
            { Make = "Mercedes", 
                Model = "E220", 
                Year = 2022,
            };
            MyClasses.SerializationToJson.SerializeToJson(car);
            Console.WriteLine("--------------------------------");
            MyClasses.DeserializationFromJson.DeserializeFromJson();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            MyClasses.SerializationToXml.SerializeToXml(car);
            Console.WriteLine("--------------------------------");
            MyClasses.DeserializationFromXml.DeserializeFromXml();
        }


    }
}
