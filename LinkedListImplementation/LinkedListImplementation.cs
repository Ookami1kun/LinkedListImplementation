namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T>
    {
        public int Count { get;}
        public Node<T> tail { get; set; }
        public Node<T> head { get;  set; }
    }
}
