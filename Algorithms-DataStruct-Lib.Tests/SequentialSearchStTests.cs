using Algorithms_DataStruct_Lib.SymbolTables;
using NUnit.Framework;

namespace Algorithms_DataStruct_Lib.Tests
{
    [TestFixture]
    public class SequentialSearchStTests
    {
        [Test]
        public void Add_AddThreeItems_CountReturnsThree()
        {
            var St = new SequentialSearchSt<int, string>();
            St.Add(1, "one");
            St.Add(2, "Two");
            St.Add(3, "Three");

            Assert.AreEqual(3, St.Count);
        }

        [Test]
        public void Remove_AddThreeItemsRemoveOne_CountReturnsTwo()
        {
            var St = new SequentialSearchSt<int, string>();
            St.Add(1, "one");
            St.Add(2, "Two");
            St.Add(3, "Three");

            St.Remove(2);

            Assert.AreEqual(2, St.Count);

            Assert.IsTrue(St.Contains(1));
            Assert.IsTrue(St.Contains(3));
            
            Assert.IsFalse(St.Contains(2));
        }
    }
}
