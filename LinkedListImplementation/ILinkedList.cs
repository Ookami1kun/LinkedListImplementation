namespace LinkedListImplementation
{
    interface ILinkedList<T>
    {
        int Count { get;  set; }

        Node<T> Head { get; set; }

        Node<T> Tail { get; set; }
    } 
}
