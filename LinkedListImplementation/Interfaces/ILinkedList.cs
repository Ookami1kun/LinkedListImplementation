namespace LinkedListImplementation.Interfaces
{
    interface ILinkedList<T>
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
        IIterator<T> CreateIterator();
    }
}
