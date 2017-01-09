using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightBulb_ex1
{
    public class LightBulb
    {
        private bool isOn;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public string Colour { get; set; }


    }
}
