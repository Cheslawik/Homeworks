using SmartHome.Classes;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartHomeHub = new SmartHomeHub();
            var smartLamp = new SmartLamp("Living Room Lamp", smartHomeHub);
            var securitySiren = new SecuritySiren("Home Siren", smartHomeHub);
            var smartphoneApp = new SmartphoneApp("User's Smartphone", smartHomeHub);
            smartHomeHub.OnEvent += (sender, eventArgs) =>
            {
                Console.WriteLine($"Event received: {eventArgs}");
            };
            smartHomeHub.TriggerMotion();
            smartHomeHub.TriggerFireAlarm();
            smartHomeHub.TriggerTemperatureChange();
            smartHomeHub.TriggerDoorOpened();
        }
    }
}
