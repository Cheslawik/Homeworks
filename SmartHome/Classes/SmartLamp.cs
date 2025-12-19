using SmartHome.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Classes
{

    //SmartLamp - подписывается на события хаба в конструкторе
    //В обработчике события анализирует тип события и его параметры, чтобы решить, включаться или выключаться.
    internal class SmartLamp : ISmartDevice
    {
        public string Name { get; }
        private bool isOn;

        public SmartLamp(string name, SmartHomeHub hub)
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
            switch (eventData.EventType)
            {
                case HubEventType.MotionDetected:
                    isOn = true;
                    Console.WriteLine($"{Name} turned ON due to motion detected.");
                    break;
                case HubEventType.FireAlarm:
                    isOn = true;
                    Console.WriteLine($"{Name} turned ON due to fire alarm.");
                    break;
            }
        }
    }
}
