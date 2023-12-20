using Algorithms_DataStruct_Lib.Queue;

namespace Algorithms_DataStruct_Lib.SymbolTables
{
    public class BinarySearchSt<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        private readonly IComparer<TKey> _comparer;

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public int Capacity => _keys.Length;
        private const int DefautCapacity = 4;

        public BinarySearchSt(int capacity, IComparer<TKey> comparer)
        {
            _keys = new TKey[capacity];
            _values = new TValue[capacity];
            _comparer = comparer ?? throw new ArgumentNullException("Comparer can't be null.");
        }

        public BinarySearchSt(int capacity) : this(capacity, Comparer<TKey>.Default)
        {

        }

        public BinarySearchSt() : this(DefautCapacity)
        {

        }

        public int Rank(TKey key)
        {
            int low = 0;
            int high = Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                int cmp = _comparer.Compare(key, _keys[mid]);

                if (cmp < 0)
                    high = mid - 1;
                else if (cmp > 0)
                    low = mid + 1;
                else
                    return mid;
            }

            return low;
        }

        public TValue GetValueOrDefault(TKey key)
        {
            if (IsEmpty)
                return default(TValue);

            int rank = Rank(key);

            if (rank < Count && _comparer.Compare(_keys[rank], key) == 0)
                return _values[rank];

            return default(TValue);
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
                throw new ArgumentNullException("Key can't be null");

            int rank = Rank(key);

            if (rank < Count && _comparer.Compare(_keys[rank], key) == 0)
            {
                _values[rank] = value;
                return;
            }

            if (Count == Capacity)
                Resize(Capacity * 2);

            for (int j = Count; j > rank; j--)
            {
                _keys[j] = _keys[j - 1];
                _values[j] = _values[j - 1];
            }

            _keys[rank] = key;
            _values[rank] = value;

            Count++;
        }

        public void Remove(TKey key)
        {
            if (key == null)
                throw new ArgumentNullException("Key can't be null");

            if (IsEmpty)
                return;

            int rank = Rank(key);

            if (rank == Count || _comparer.Compare(_keys[rank], key) != 0)
                return;

            for (int j = rank; j < Count; j++)
            {
                _keys[j] = _keys[j + 1];
                _values[j] = _values[j + 1];
            }

            Count--;
            _keys[Count] = default(TKey);
            _values[Count] = default(TValue);
        }

        public bool Contains(TKey key)
        {
            int rank = Rank(key);

            if (rank < Count && _comparer.Compare(_keys[rank], key) == 0)
                return true;

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            foreach (var key in _keys)
            {
                yield return key;
            }
        }


        private void Resize(int v)
        {
            TKey[] keysTmp = new TKey[Capacity];
            TValue[] valuesTmp = new TValue[Capacity];

            for (int i = 0; i < Count; i++)
            {
                keysTmp[i] = _keys[i];
                valuesTmp[i] = _values[i];
            }

            _values = valuesTmp;
            _keys = keysTmp;
        }

        public TKey Min()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            return _keys[0];
        }

        public TKey Max()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            return _keys[Count - 1];
        }

        public void RemoveMin()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            Remove(Min());
        }

        public void RemoveMax()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Table is empty.");

            Remove(Max());
        }

        public TKey Select(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentException("Index out of range.");

            return _keys[index];
        }

        public TKey Ceiling(TKey key)
        {
            if (key == null)
                throw new ArgumentNullException("key is null.");

            int rank = Rank(key);
            if (rank == Count)
                return default(TKey);
            else
                return _keys[rank];
        }

        public TKey Floor(TKey key)
        {
            if (key == null)
                throw new ArgumentNullException("key is null.");

            int rank = Rank(key);

            if (rank < Count && _comparer.Compare(_keys[rank], key) == 0)
                return _keys[rank];
            if (rank == 0)
                return default(TKey);
            else
                return _keys[rank - 1];
        }

        public IEnumerable<TKey> Range(TKey left, TKey right)
        {
            var q = new LinkedQueue<TKey>();

            int low = Rank(left);
            int high = Rank(right);

            for (int i = low; i < high; i++)
            {
                q.Enqueue(_keys[i]);
            }

            if (Contains(right))
                q.Enqueue(_keys[Rank(right)]);

            return q;
        }
    }
}
