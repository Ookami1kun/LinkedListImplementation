using System.Reflection.Metadata.Ecma335;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T>
    {
        public class Node<T>
        {
            public T Data { get; private set; }
            public Node<T> Prev { get; private set; }
            public Node<T> Next { get; private set; }
            public Node(T value)
            {
                Data = value;
            }
        }

        public int Count { get; private set; }

        public Node<T> Tail { get; private set; }
        public Node<T> Head { get; private set; }
    }
}
