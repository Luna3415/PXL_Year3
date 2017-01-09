using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_temperature
{
    public class ThresholdTemperature
    {
        TemperatureSensor sensor = new TemperatureSensor();

        public delegate void TooHotTemperatureHandler();
        public TooHotTemperatureHandler TooHotDel;

        public event TooHotTemperatureHandler TooHotEvent;

        public ThresholdTemperature()
        {
            TooHotDel = new TooHotTemperatureHandler(Raise_Warning);
            sensor.TempEvent += Sensor_TempEvent;
        }

        private void Sensor_TempEvent(int temp)
        {
            if (temp > 45)
            {
                TooHotDel();
            }
            
        }

        private void Raise_Warning()
        {
            Console.WriteLine("WARNING! IT's TOO HOT!");
        }
    }
}
