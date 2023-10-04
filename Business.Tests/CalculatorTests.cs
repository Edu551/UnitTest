using NUnit.Framework;
using UnitTestUdemy;

namespace Business.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumbers_ValidValues_ReturnsCorrectResult()
        {
            var cal = new Calculator();
            int result = cal.AddNumbers(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }    
}
