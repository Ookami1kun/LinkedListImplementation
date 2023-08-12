using System.Reflection.Metadata.Ecma335;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T>
    {
        public class Node<T>
        {
            public T data;
            public Node<T> prev;
            public Node<T> next;

            public Node(T value)
            {
                data = value;
            }
        }

        public int Count { get; private set; }

        public Node<T> Tail { get; private set; }
        public Node<T> Head { get; private set; }
    }
}
