namespace LinkedListImplementation
{
    public class Node<T>
    {
        public T data;
        public Node<T> prev;
        public Node<T> next;

        public Node (T value) 
        {
            data = value;
            prev = null;
            next = null;
        }
    }
}
