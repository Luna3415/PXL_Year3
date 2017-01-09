using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TemperatureSensor_WPF
{
    public class TemperatureSensor
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public TemperatureSensor()
        {
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            int temperature = random.Next(50);
            TemperatureSensor_TempEvent(temperature);
        }

        private void TemperatureSensor_TempEvent(int temp)
        {
            //handleTemperature = TempEvent as TemperatureHandler;
            //handleTemperature?.Invoke(temp); 
            Mediator.GetInstance().OnTemperatureChanged(this, temp);
        }
    }
}
