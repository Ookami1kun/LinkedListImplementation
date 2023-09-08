using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> array = new int[] { 1, 3, 2, 4, 5, 6, 2, 3, 1 };

            ILinkedList<int> list = new MyLinkedList<int>(array);

            list.PrintList();
            list.Sort();
            Console.WriteLine();
            list.PrintList();
        }
    }
}
