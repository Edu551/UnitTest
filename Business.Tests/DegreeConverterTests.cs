using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestUdemy;

namespace Business.Tests
{
    [TestFixture]
    public class DegreeConverterTests
    {
        [Test]
        public void ToFahrenheit_0Celsius_Returns32()
        {
            double result = DegreeConverter.ToFahrenheit(0);
            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void ToCelsius_1Fahrenheit_Returns0()
        {
            double result = DegreeConverter.ToCelsius(1);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
