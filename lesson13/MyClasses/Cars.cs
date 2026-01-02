using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lesson13.MyClasses
{
    public class Cars
    {
        [XmlAttribute("Car_producer_xml")]
        [JsonPropertyName("car_producer_json")]
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        [NonSerialized]
        private string Identifier = "11111111";
        public Cars(string identifier)
        {
            Identifier = identifier;
        }
        public Cars() { }
    }
}
