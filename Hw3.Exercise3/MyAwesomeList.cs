using System.Collections;
using System.Globalization;

namespace Hw3.Exercise3
{
    // better to seal our list
    public sealed class MyAwesomeList<T> : IEnumerator<T>, IEnumerable<T>
    {
        public int Count => Size;
        private T[] _items;
        private int _capacity;
        // Don't expose the Size property from the outside
        private int Size { get; set; }

        // Can be removed, since it's not used anywhere
        public bool IsEmpty => Size == 0;

        public T Current => _items[_position];

        object IEnumerator.Current => _items[_position]!;

        private int _position = -1;
        private bool _disposedValue;

        public MyAwesomeList(int capacity = 1)
        {
            // Better to throw an exception here. Like:
            // throw new ArgumentException("Invalid capacity value");
            if (capacity < 1)
            {
                capacity = 1;
            }
            _capacity = capacity;
            _items = new T[_capacity];
        }

        public T this[int index]
        {
            get
            {
                ThrowIfArgumentOutOfRange(index);
                return _items[index];
            }
            set
            {
                ThrowIfArgumentNull(value);
                _items[index] = value;
            }
        }

        public T GetByIndex(int index)
        {
            ThrowIfArgumentOutOfRange(index);
            return _items[index];
        }

        public void DeleteByIndex(int index)
        {
            ThrowIfArgumentOutOfRange(index);

            for (var i = index; i < Size - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[Size - 1] = default!;

            Size--;
        }

        public bool DeleteAllElements()
        {
            _items = new T[_capacity];
            Size = 0;
            return true;
        }

        public void Add(T element)
        {
            ThrowIfArgumentNull(element);
            if (Size == _capacity)
            {
                Resize();
            }

            _items[Size] = element;
            Size++;
        }

        public void InsertAt(T element, int index)
        {
            ThrowIfArgumentOutOfRange(index);
            ThrowIfArgumentNull(element);

            if (Size == _capacity)
            {
                Resize();
            }

            for (var i = Size; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }

            _items[index] = element;
            Size++;
        }

        public bool Contains(T value)
        {
            for (var i = 0; i < Size; i++)
            {
                // we can use _items[i]!.Equals((value)) instead of creating a new variable
                var currentValue = _items[i];
                if (currentValue!.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        private void Resize()
        {
            var resized = new T[_capacity * 2];

            for (var i = 0; i < _capacity; i++)
            {
                resized[i] = _items[i];
            }
            _items = resized;
            _capacity *= 2;
        }

        private void ThrowIfArgumentOutOfRange(int index)
        {
            if (index > Size - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException(index.ToString(CultureInfo.InvariantCulture));
            }
        }

        // can be static
        private static void ThrowIfArgumentNull(T element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < Size;
        }

        public void Reset()
        {
            _position = -1;
        }

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                // Fow what this if?
                if (disposing)
                {
                }
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
