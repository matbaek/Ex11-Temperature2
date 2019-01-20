using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Temperature
{
    public class Temperature
    {
        public double input;
        public enum TemperatureScale
        {
            Celsius,
            Fahrenheit
        }


        public double Celsius {
            get
            {
                return input;
            }
            set
            {
                input = value;
            }
        }
        public double Fahrenheit {
            get
            {
                return ((9.0 * input) / 5.0) + 32;
            }
            set
            {
                input = 5 * (value - 32) / 9;
            }
        }

        public void SetTemperature(double v, TemperatureScale temp)
        {

            switch (temp)
            {
                case TemperatureScale.Celsius:
                    Celsius = v;
                    break;
                case TemperatureScale.Fahrenheit:
                    Fahrenheit = v;
                    break;
            }
        }
    }
}
