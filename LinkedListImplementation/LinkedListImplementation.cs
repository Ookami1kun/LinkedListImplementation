using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T> where T : IComparable<T>
    {
        public class Node<T>
        {
            public T Data { get; }
            public Node<T> Prev { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Data = value;
            }
        }

        public int Count { get; private set; }

        public Node<T> Tail { get; private set; }
        public Node<T> Head { get; private set; }

        public MyLinkedList()
        {

        }

        public MyLinkedList(IEnumerable<T> collection)
        {
            Head = new Node<T> (collection.First());
            var current = Head;
            Tail = current;

            foreach (var item in collection.Skip(1))
            {
                var newCurrent = new Node<T> (item);
                current.Next = newCurrent;
                newCurrent.Prev = current;
                current = newCurrent;
                Tail = current;
            }
        }

        public T GetMin()
        {
            T min = Head.Data;
            var current = Head;

            while (current.Next != null)
            {
                if (current.Data.CompareTo(current.Next.Data) > 0)
                {
                    min = current.Next.Data;
                }
                current = current.Next;
            }
           
            return min;
        }

        public T GetMax()
        {
            T max = Head.Data;
            var current = Head;

            while (current.Next != null)
            {
                if (current.Data.CompareTo(current.Next.Data) < 0)
                {
                    max = current.Next.Data;
                }
                current = current.Next;
            }

            return max;
        }

        public void PrintList()
        {
            var current = Head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            current = Tail;
            Console.WriteLine();

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Prev;
            }
        }
        
    }
}
