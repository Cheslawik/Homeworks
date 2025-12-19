using SmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Classes
{
    internal class SecuritySiren : ISmartDevice
    {
        public string Name { get; }
        private bool isOn;

        public SecuritySiren(string name, SmartHomeHub hub)
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
            if (eventData.Priority > 4)
            {
                switch (eventData.EventType)
                {
                    case HubEventType.FireAlarm:
                        isOn = true;
                        Console.WriteLine($"{Name} turned ON due to fire alarm.");
                        break;
                }
            }
        }
    }
}




