using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    public class DescendingIterator<T> : IIterator<T> where T : IComparable<T>
    {
        private MyLinkedList<T> _list;
        private MyLinkedList<T>.Node<T> _position;
        private int index;

        public DescendingIterator(MyLinkedList<T> list)
        {
            _list = list;
            _position = _list.Head;

            while (_position.Next != null)
            {
                index++;
                _position = _position.Next;
            }
        }

        public T Current()
        {
            return _position.Data;
        }

        public bool HasNext()
        {
            return index >= 0;
        }

        public void MoveNext()
        {
            int index1 = index;
            _position = _list.Head;

            while (index1 > 1)
            {
                _position = _position.Next;
                index1--;
            }

            index--;
        }

        public void Reset()
        {
            index = 0;

            while (_position.Next != null)
            {
                index++;
                _position = _position.Next;
            }
        }
    }
}
