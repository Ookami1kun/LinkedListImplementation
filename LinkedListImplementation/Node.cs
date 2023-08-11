namespace LinkedListImplementation
{
    public class Node<T>
    {
        private T data;
        private Node<T> prev;
        private Node<T> next;

        public T Data { get { return data; } set { data = value; } }
        public Node<T> Prev { get { return prev; } set { prev = value; } }
        public Node<T> Next { get { return next; } set { next = value; } }

        public Node (T value) 
        {
            Data = value;
        }
    }
}
