using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    public class Iterator<T> : IIterator<T> where T : IComparable<T>
    {
        private MyLinkedList<T> _list;
        private MyLinkedList<T>.Node<T> _position;

        public Iterator(MyLinkedList<T> list)
        {
            _list = list;
            _position = _list.Head;
        }

        public T Current()
        {
            return _position.Data;
        }

        public bool HasNext()
        {
            return _position != null;
        }

        public void MoveNext()
        {
            if (_position != null)
            {
                _position = _position.Next;
            }
        }

        public void Reset()
        {
            _position = _list.Head;
        }
    }
}
