using System.Reflection.Metadata.Ecma335;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T>
    {
        public int Count { get; private set; }
        public Node<T> Tail { get; set; }
        public Node<T> Head { get;  set; }
    }
}
