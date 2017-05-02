using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class BackyardLightSwitcher
    {
        private readonly static BackyardLightSwitcher FInstance = new BackyardLightSwitcher();

        public static BackyardLightSwitcher Instance { get { return FInstance; } }

        public void TurnOn()
        {
            // Do something to turn on the light
        }

        public void TurnOff()
        {
            // Do something to turn off the light
        }
    }
}
