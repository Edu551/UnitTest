using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePort_COM1_Returns1() //UniUnderTest_Scenario_ExpectedOutcome
        {
            // result = actual result
            int result = SerialPortParser.ParsePort("COM1");
            // Is.EqualTo() = expected result (behavior of the system) 
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ParsePort_InvalidFormat_ThrowsInvalidFormatException()
        {
            TestDelegate action = () => SerialPortParser.ParsePort("1");
            Assert.Throws<FormatException>(action);
        }
    }
}

/* Namining Conventions
 * 1 - ShouldAddTwoNumbers()
 * 2 - Sum_ShouldAddTwoNumbers
 * 3 - UniUnderTest_Scenario_ExpectedOutcome    
 *      ExpectedOutcome { 1 - ReturnsValue => ReturnsZero or ReturnsFalse
 *                        2 - ChangesState or SetState => SetNumberToZero
 *                        3 - CallsDependency => CallsProcessingGateway } 
 */
