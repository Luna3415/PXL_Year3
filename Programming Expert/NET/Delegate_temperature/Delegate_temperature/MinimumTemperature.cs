using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_temperature
{
    public class MinimumTemperature
    {
        TemperatureSensor tempSensor = new TemperatureSensor();
        List<int> temperatures = new List<int>();

        public MinimumTemperature()
        {
            tempSensor.TempEvent += TempSensor_TempEvent;
        }

        private void TempSensor_TempEvent(int temp)
        {
            temperatures.Add(temp);
            Console.WriteLine("Min temperature: " + temperatures.Min());
        }
    }
}
