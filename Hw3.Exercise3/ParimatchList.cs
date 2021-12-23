namespace Hw3.Exercise3
{
    public class ParimatchList<T>
    {
        public int Count { get; }

        public ParimatchList(int capacity = 1)
        {
        }

        public T GetByIndex(int index)
        {
            throw new NotImplementedException("Should be implemented by executor");
        }

        public void DeleteByIndex(int index)
        {
            throw new NotImplementedException("Should be implemented by executor");
        }

        public bool DeleteAllElements()
        {
            throw new NotImplementedException("Should be implemented by executor");
        }

        public void Add(T element)
        {
            throw new NotImplementedException("Should be implemented by executor");
        }

        public void InsertAt(T element, int index)
        {
            throw new NotImplementedException("Should be implemented by executor");
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException("Should be implemented by executor");
        }
    }
}
