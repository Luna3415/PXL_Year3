using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBulb_ex1
{
    public class Switch
    {
        public delegate void TurnOnHandler(LightBulb l1);
        public delegate void TurnOffHandler(LightBulb l1);

        public TurnOnHandler turnOn;
        public TurnOffHandler turnOff;

        public event TurnOnHandler TurnOnEvent;
        public event TurnOffHandler TurnOffEvent;

        public Switch()
        {
            turnOn = new TurnOnHandler(TurnOn);
            turnOff = new TurnOffHandler(TurnOff);
          
            TurnOnEvent += OnTurnOn;
            TurnOffEvent += OnTurnOff;
            TurnOnEvent(new LightBulb());
        }

        public void OnTurnOff(LightBulb l1)
        {
            turnOff?.Invoke(l1);
        }

        public void OnTurnOn(LightBulb l1)
        {
            
            turnOn?.Invoke(l1);
        }

        public void TurnOn(LightBulb lightBulb)
        {
            lightBulb.IsOn = true;
            Console.WriteLine("De lightbulb is aan");
        }

        public void TurnOff(LightBulb ligtBulb)
        {
            ligtBulb.IsOn = false;
            Console.WriteLine("De lightbulb is uit");
        }
    }
}
