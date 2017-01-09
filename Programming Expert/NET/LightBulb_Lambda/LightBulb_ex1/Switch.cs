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

        public Action<LightBulb> SetOnAction;
        public Action<LightBulb> SetOffAction;

        public Switch()
        {

        }

        public void OnTurnOff(LightBulb l1)
        {
            if (TurnOnEvent != null)
            {
                TurnOffEvent(l1);
            }
            //turnOff?.Invoke(l1);
        }

        public void OnTurnOn(LightBulb l1)
        {
            if (TurnOffEvent != null)
            {
                TurnOnEvent(l1);
            }
            //turnOn?.Invoke(l1);
        }

        public void TurnOnDel(LightBulb l)
        {
            if (turnOn != null)
            {
                turnOn(l);
            } 
        }

        public void TurnOffDel(LightBulb l)
        {
            if (turnOff != null)
            {
                turnOff(l);
            }
        }

        public void OnTurnOnAction(LightBulb l)
        {
            if (SetOnAction != null)
            {
                SetOnAction(l);
            }
        }

        public void OnTurnOffAction(LightBulb l)
        {
            if (SetOffAction != null)
            {
                SetOffAction(l);
            }
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
