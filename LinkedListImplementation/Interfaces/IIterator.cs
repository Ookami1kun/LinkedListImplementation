namespace LinkedListImplementation.Interfaces
{
    public interface IIterator<T>
    {
        bool HasNext();
        void Reset();
        T Current();
        void MoveNext();
    }
}
