using NUnit.Framework;
using System.Collections;
using UnitTestUdemy;

namespace Business.Tests
{
    [TestFixture]
    public class DegreeConverterTests
    {
        [TestCaseSource(typeof(DegreeSource))]
        public void ToFahrenheit_0Celsius_Returns32(int expectedCelcius, int fahrenheit)
        {
            double result = DegreeConverter.ToFahrenheit(fahrenheit);
            Assert.That(result, Is.EqualTo(expectedCelcius));
        }

        [TestCaseSource(typeof(DegreeSource))]
        public void ToCelsius_1Fahrenheit_Returns0(int fahrenheit, int expectedCelcius )
        {
            double result = DegreeConverter.ToCelsius(fahrenheit);
            Assert.That(result, Is.EqualTo(expectedCelcius));
        }

        public class DegreeSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new int[] { 32, 0 };
                yield return new int[] { 41, 5 };
                yield return new int[] { 50, 10 };
                yield return new int[] { 59, 15 };
                yield return new int[] { 68, 20 };
                yield return new int[] { 77, 25 };
                yield return new int[] { 86, 30 };
                yield return new int[] { 95, 35 };
                yield return new int[] { 104, 40 };
            }
        }
    }
}
