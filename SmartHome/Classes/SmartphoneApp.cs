using SmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Classes
{
    internal class SmartphoneApp : ISmartDevice
    {
        public string Name { get; }
        private bool isOn;

        public SmartphoneApp(string name, SmartHomeHub hub)
        {
            Name = name;
            isOn = false;
            hub.OnEvent += HandleHubEvent;
        }

        private void HandleHubEvent(object sender, HubEvent e)
        {
            ReactToEvent(e);
        }

        public void ReactToEvent(HubEvent eventData)
        {
            if (eventData.Priority >= 3)
            {
                switch (eventData.EventType)
                {
                    case HubEventType.FireAlarm:
                        isOn = true;
                        Console.WriteLine($"Send massege to {Name} due to fire alarm.");
                        break;
                    case HubEventType.TemperaureChanged:
                        isOn = true;
                        Console.WriteLine($"Send massege to {Name} due to temperature change.");
                        break;
                }
            }
        }
    }
}
