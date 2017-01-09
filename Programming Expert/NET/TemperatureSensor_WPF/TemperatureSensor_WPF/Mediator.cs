using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor_WPF
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<TemperatureArgs> TemperatureChanged;

        public void OnTemperatureChanged(Object sender, int temperature)
        {
            var temperatureChangeDelegate = TemperatureChanged as EventHandler<TemperatureArgs>;
            if (temperatureChangeDelegate != null)
            {
                temperatureChangeDelegate(sender, new TemperatureArgs { Temperature = temperature});
            }
        }

    }
}
