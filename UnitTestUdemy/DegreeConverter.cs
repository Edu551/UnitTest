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
            return (celsius * 1.8) + 32;
        }

        public static double ToCelsius(double fahrenheit) 
        {
            return (fahrenheit - 32) / ( 9.0 / 5 );
        }
    }
}
