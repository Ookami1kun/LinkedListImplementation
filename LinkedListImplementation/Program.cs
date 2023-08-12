namespace LinkedListImplementation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 2, 5};

            MyLinkedList<int> list = new MyLinkedList<int>(array);
            list.PrintList();
            Console.WriteLine();
            list.RemoveLast();
            Console.WriteLine();
            list.PrintList();
        }
    }
}
