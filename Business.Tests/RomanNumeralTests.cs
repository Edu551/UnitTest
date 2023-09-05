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
    public class RomanNumeralTests
    {
        [TestCase(1, "I")]
        [TestCase(3, "III")]
        [TestCase(10, "X")]
        [TestCase(9, "IX")]
        [TestCase(44, "XLIV")]
        [TestCase(48, "XLVIII")]
        [TestCase(49, "XLIX")]
        [TestCase(99, "XCIX")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumeral.Parse(roman));
        }
    }
}
