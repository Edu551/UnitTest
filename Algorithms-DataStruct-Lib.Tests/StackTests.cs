using NUnit.Framework;

namespace Algorithms_DataStruct_Lib.Tests
{
    [TestFixture]
    public class StackTests
    {
        #region ArrayStack tests
        [Test]
        public void ArrayStackIsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new ArrayStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void CountArrayStack_pushOneItem_ReturnsOne()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void PopArrayStack_EmptyStack_ThrowsException()
        {
            var stack = new ArrayStack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void PeekArrayStack_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void PeekArrayStack_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
        #endregion

        #region LinkedStack tests
        [Test]
        public void LinkedStackIsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new LinkedStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void CountLinkedStack_pushOneItem_ReturnsOne()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void PopLinkedStack_EmptyStack_ThrowsException()
        {
            var stack = new LinkedStack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void PeekLinkedStack_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void PeekLinkedStack_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
        #endregion
    }
}
