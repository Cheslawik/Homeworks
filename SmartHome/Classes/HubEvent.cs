using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Classes
{
    enum HubEventType
    {
        DoorOpened,
        MotionDetected,
        FireAlarm,
        TemperaureChanged
    }
    internal class HubEvent
    {
        public HubEventType EventType { get; }
        public DateTime Time { get; }
        public int Priority { get; }

        public HubEvent(HubEventType eventType, int  priority)
        {
            EventType = eventType;
            Priority = priority;
            Time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Time}] Event's type: {EventType}, Priotity: {Priority}";
        }

    }
}
