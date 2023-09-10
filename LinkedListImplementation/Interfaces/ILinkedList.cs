namespace LinkedListImplementation.Interfaces
{
    public interface ILinkedList<T> : IEnumerable<T>
    {
        int Count { get; }
        void Add(T value);
        void AddStart(T value);
        void PrintList();
        T GetMin();
        T GetMax();
        bool Contains(T value);
        void RemoveFirst();
        void RemoveLast();
        void RemoveByValue(T value);
        void RemoveLastByValue(T value);
        void Sort();
        void Reverse();
        ILinkedList<T> Copy();
        IEnumerator<T> GetEnumerator();
    }
}
