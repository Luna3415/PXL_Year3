using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegate_temperature
{
    class Program
    {

        static void Main(string[] args)
        {
            AverageTemperature av = new AverageTemperature();
            MinimumTemperature mt = new MinimumTemperature();
            MaxTemperature mat = new MaxTemperature();
            ThresholdTemperature tt = new ThresholdTemperature();
            Console.Read();
        }
    }
}
