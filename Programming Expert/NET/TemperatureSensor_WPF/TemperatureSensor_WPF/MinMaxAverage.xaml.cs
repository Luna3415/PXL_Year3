using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TemperatureSensor_WPF
{
    /// <summary>
    /// Interaction logic for MinMaxAverage.xaml
    /// </summary>
    public partial class MinMaxAverage : UserControl
    {
        List<int> temperatures = new List<int>();

        public MinMaxAverage()
        {
            InitializeComponent();
            Mediator.GetInstance().TemperatureChanged += (s, e) =>
            {
                temperatures.Add(e.Temperature);
                averageProgressBar.Value = temperatures.Average();
                minTextBlock.Text = temperatures.Min().ToString();
                maxTextBlock.Text = temperatures.Max().ToString();
            };
        }
    }
}
