using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Classes
{

    /*
     Реализуйте класс SmartHomeHub - центральный контроллер (издатель): ·
   Объявите в нём событие (например, public event EventHandler<HubEvent> OnEvent). ·
   Добавьте защищённый метод RaiseEvent, который безопасно вызывает это событие. · 
   Создайте несколько публичных методов-триггеров для генерации конкретных событий (например, TriggerMotion, TriggerFireAlarm), 
    которые создают объект HubEvent и вызывают RaiseEvent. ·
    В каждом триггере выводите в консоль сообщение о том, что хаб сгенерировал событие.
     */
    internal class SmartHomeHub
    {

        public event EventHandler<HubEvent> OnEvent;
        protected void RaiseEvent(HubEvent hubEvent)
        {
            OnEvent?.Invoke(this, hubEvent);
        }

        public void TriggerMotion()
        {
            var hubEvent = new HubEvent(HubEventType.MotionDetected, 2);
            Console.WriteLine("\nSmartHomeHub: Motion event triggered.");
            RaiseEvent(hubEvent);
        }

        public void TriggerFireAlarm()
        {
            var hubEvent = new HubEvent(HubEventType.FireAlarm, 5);
            Console.WriteLine("\nSmartHomeHub: Fire alarm event triggered.");
            RaiseEvent(hubEvent);
        }

        public void TriggerTemperatureChange()
        {
            var hubEvent = new HubEvent(HubEventType.TemperaureChanged, 3);
            Console.WriteLine("\nSmartHomeHub: Temperature change event triggered.");
            RaiseEvent(hubEvent);
        }

        public void TriggerDoorOpened()
        {
            var hubEvent = new HubEvent(HubEventType.DoorOpened, 1);
            Console.WriteLine("\nSmartHomeHub: Door opened event triggered.");
            RaiseEvent(hubEvent);
        }
    }
}
