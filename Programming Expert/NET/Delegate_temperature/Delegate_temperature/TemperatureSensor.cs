using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegate_temperature
{
    public class TemperatureSensor
    {
        public delegate void TemperatureHandler(int temp);

        public TemperatureHandler handleTemperature;

        public event TemperatureHandler TempEvent;

        private Timer timer = new Timer();

        public TemperatureSensor()
        {
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            timer.Start();
        }

        private void TemperatureSensor_TempEvent(int temp)
        {
            //handleTemperature = TempEvent as TemperatureHandler;
            //handleTemperature?.Invoke(temp); 
            TempEvent(temp);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var random = new Random();
            int temperature = random.Next(50);
            TemperatureSensor_TempEvent(temperature);
        }
    }
}
