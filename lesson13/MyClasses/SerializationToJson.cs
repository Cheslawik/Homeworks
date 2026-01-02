using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace lesson13.MyClasses
{
    internal static class SerializationToJson
    {
        public static void SerializeToJson(Cars car)
        {
            string carToJson = JsonSerializer.Serialize(car,
            new JsonSerializerOptions { WriteIndented = true });

            string path = "E:\\TMS\\lesson13\\forSerialization\\car.json";

            try
            {
                File.WriteAllText(path, carToJson);
                Console.WriteLine($"Serialization was successful! File path - {path}");
                Console.WriteLine(carToJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error to record: {ex.Message}");
            }
        }
    }
}
