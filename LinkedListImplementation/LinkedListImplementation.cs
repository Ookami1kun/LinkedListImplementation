using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    public class MyLinkedList<T> : ILinkedList<T> where T : IComparable<T>
    {
        public int Count { get; private set; }

        private Node<T> tail;

        private Node<T> head;

        public MyLinkedList()
        {

        }

        public MyLinkedList(IEnumerable<T> collection)
        {
            head = new Node<T> (collection.First());
            var current = head;
            tail = current;

            foreach (var item in collection.Skip(1))
            {
                var newCurrent = new Node<T> (item);
                current.Next = newCurrent;
                newCurrent.Prev = current;
                current = newCurrent;
                tail = current;
            }
        }

        public T GetMin()
        {
            T min = head.Data;

            var current = head;

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
            T max = head.Data;

            var current = head;

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
            var current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            current = tail;
            Console.WriteLine();

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Prev;
            }
        }
    }
}
