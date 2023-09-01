using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestUdemy;

namespace Business.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(17, "")]
        public void Ask_Numbers_ReturnCorrectValue(int number, string expectedString)
        {
            /*string result = FizzBuzz.Ask(number);
            Assert.That(result, Is.EqualTo(expectedString));*/

            Assert.AreEqual(expectedString, FizzBuzz.Ask(number));
        }
    }

}
