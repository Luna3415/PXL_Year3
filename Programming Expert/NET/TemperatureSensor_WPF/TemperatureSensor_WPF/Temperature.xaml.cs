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
    /// Interaction logic for Temperature.xaml
    /// </summary>
    public partial class Temperature : UserControl
    {
        public Temperature()
        {
            InitializeComponent();
            Mediator.GetInstance().TemperatureChanged += (s, e) =>
            {
                temperatureTextBlock.Text = e.Temperature.ToString() + " C°";
                if (e.Temperature < 10)
                {
                    myCanvas.Background = Brushes.LightBlue;
                }
                else if (e.Temperature <= 25) {
                    myCanvas.Background = Brushes.Orange;
                } else
                {
                    myCanvas.Background = Brushes.Red;
                }
            };
        }
    }
}
