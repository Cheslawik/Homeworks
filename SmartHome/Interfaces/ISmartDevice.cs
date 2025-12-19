using SmartHome.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHome.Interfaces
{
    internal interface ISmartDevice
    {
        string Name { get; }
        void ReactToEvent(HubEvent eventData);
    }
}
