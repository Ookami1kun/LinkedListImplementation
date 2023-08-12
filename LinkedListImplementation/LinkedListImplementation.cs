using System.Reflection.Metadata.Ecma335;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T>
    {
        public class Node<T>
        {
            private T data;
            private Node<T> prev;
            private Node<T> next;

            public Node(T value)
            {
                data = value;
            }
        }

        public int Count { get; private set; }
        private Node<T> tail;
        private Node<T> head;

        public Node<T> Tail { get { return tail; } private set { tail = value; } }
        public Node<T> Head { get { return head; } private set { head = value; } }
    }
}
