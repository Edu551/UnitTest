namespace Algorithms_DataStruct_Lib.SymbolTables
{
    public class SequentialSearchSt<TKey, TValue>
    {
        private class Node
        {
            public TKey Key { get; }
            public TValue Value { get; set; }
            public Node Next { get; set; }

            public Node(TKey key, TValue value, Node next)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }

        private Node _first;
        private readonly IEqualityComparer<TKey> _comparer;
        public int Count { get; private set; }

        public SequentialSearchSt()
        {
            _comparer = EqualityComparer<TKey>.Default;
        }

        public SequentialSearchSt(IEqualityComparer<TKey> comparer)
        {
            _comparer = comparer ?? throw new ArgumentNullException("Comparer can't be null.");
        }

        public bool TryGet(TKey key, out TValue value)
        {
            for (Node x = _first; x != null; x = x.Next)
            {
                if (_comparer.Equals(key, x.Key))
                {
                    value = x.Value;
                    return true;
                }
            }

            value = default(TValue);
            return false;
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
                throw new ArgumentNullException("Key can't be null.");

            for (Node x = _first; x != null; x = x.Next)
            {
                if (_comparer.Equals(key, x.Key))
                {
                    x.Value = value;
                    return;
                }
            }

            _first = new Node(key, value, _first);
            Count++;
        }

        public bool Contains(TKey key)
        {
            for (Node x = _first; x != null; x = x.Next)
            {
                if (_comparer.Equals(key, x.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            for (Node x = _first; x != null; x = x.Next)
            {
                yield return x.Key;
            }
        }

        public bool Remove(TKey key)
        {
            if (key == null)
                throw new ArgumentNullException("Key can't be null.");

            if(Count == 1 && _comparer.Equals(key, _first.Key))
            {
                _first = null;
                Count--;
                return true;
            }

            Node prev = null;
            Node current = _first;

            while (current != null)
            {
                if(_comparer.Equals(key, current.Key))
                {
                    if(prev == null)
                    {
                        _first = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    Count--;
                    return true;
                }

                prev = current;
                current = current.Next;
            }

            return false;
        }
    }
}
