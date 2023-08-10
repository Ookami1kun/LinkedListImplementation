namespace LinkedListImplementation
{
    interface ILinkedList<T>
    {
        int Count { get; }

        Node<T> head { get; set; }

        Node<T> tail { get; set; }
    } 
}
