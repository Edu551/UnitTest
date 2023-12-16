using System.Collections;
using Algorithms_DataStruct_Lib.List;

namespace Algorithms_DataStruct_Lib.Queue
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public int Count => _list.Count;
        public bool IsEmpty => Count == 0;

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public void Dequeue()
        {
            _list.RemoveFirst();
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            return _list.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
