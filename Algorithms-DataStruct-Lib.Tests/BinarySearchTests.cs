using NUnit.Framework;

namespace Algorithms_DataStruct_Lib.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearch_SortedInput_ReturnsCorrectIndex()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.AreEqual(2, Seraching.BinarySearchClassic(input, 3));
            Assert.AreEqual(4, Seraching.BinarySearchClassic(input, 5));
            Assert.AreEqual(5, Seraching.BinarySearchClassic(input, 6));
            Assert.AreEqual(8, Seraching.BinarySearchClassic(input, 9));

            Assert.AreEqual(2, Seraching.RecursiveBinarySearch(input, 3));
            Assert.AreEqual(4, Seraching.RecursiveBinarySearch(input, 5));
            Assert.AreEqual(5, Seraching.RecursiveBinarySearch(input, 6));
            Assert.AreEqual(8, Seraching.RecursiveBinarySearch(input, 9));
        }
    }
}
