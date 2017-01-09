
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

            lightSwitch.SetOnAction += (l) =>
            {
                lightSwitch.TurnOn(l);
            };

            lightSwitch.SetOffAction += (l) =>
            {
                lightSwitch.TurnOff(l);
            };

            lightSwitch.OnTurnOnAction(lightBulb);
            lightSwitch.OnTurnOffAction(lightBulb);

            /* DELEGATES AND ANONIEM
            lightSwitch.turnOn += delegate (LightBulb lightbulbAn)
            {
                lightSwitch.TurnOn(lightbulbAn);
                Console.WriteLine(lightbulbAn.Colour);
            };

            lightSwitch.turnOff += delegate (LightBulb lightbulb)
            {
                lightSwitch.TurnOff(lightbulb);
            };

            lightSwitch.TurnOnDel(lightBulb);
            lightSwitch.turnOff(lightBulb);*/

            /* EVENTS LAMBDA
            lightSwitch.TurnOnEvent += (l) =>
            {
                lightSwitch.TurnOn(l);
            };

            lightSwitch.TurnOffEvent += (l) =>
            {
                lightSwitch.TurnOff(l);
            };

            lightSwitch.OnTurnOn(lightBulb);
            lightSwitch.OnTurnOff(lightBulb);*/

            Console.ReadLine();
        }
    }
}
