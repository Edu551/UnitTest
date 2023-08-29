using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestUdemy
{
    public class DegreeConverter
    {
        public static double ToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ToCelsius(double fahrenheit) 
        {
            return (32 * fahrenheit - 32) * 5 / 9;
        }
    }
}
