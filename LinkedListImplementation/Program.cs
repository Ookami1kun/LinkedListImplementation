using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> array = new int[] { 0, 1, 2, 8, 4 };

            ILinkedList<int> list = new MyLinkedList<int>(array);
        }
    }
}
