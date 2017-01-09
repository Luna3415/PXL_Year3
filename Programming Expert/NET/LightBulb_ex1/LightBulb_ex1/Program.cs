using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBulb_ex1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Switch lightSwitch = new Switch();
            Switch lightSwitch2 = new Switch();

            LightBulb lightBulb = new LightBulb() { Colour = "Yellow", IsOn = false };

            /* DELEGATES
            lightSwitch.turnOn(lightBulb);
            lightSwitch.turnOff(lightBulb);
            lightSwitch2.turnOn(lightBulb);*/

            //lightSwitch.OnTurnOn(lightBulb);
            //lightSwitch.OnTurnOff(lightBulb);
        }
    }
}
