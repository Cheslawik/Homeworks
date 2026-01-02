using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace lesson13.MyClasses
{
    internal static class DeserializationFromJson
    {
        public static void DeserializeFromJson()
        {
            string path = "E:\\TMS\\lesson13\\forSerialization\\car.json";
            try
            {
                string carFromJson = File.ReadAllText(path);
                Cars car = JsonSerializer.Deserialize<Cars>(carFromJson);
                if (car != null || path != null)
                {
                    Console.WriteLine("Deserialization was successful!");
                    Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
                }
                else
                {
                    Console.WriteLine("Deserialization failed: car is null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file: {ex.Message}");
            }
        }
    }
}
