namespace LinkedListImplementation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 0, -1};

            MyLinkedList<int> list = new MyLinkedList<int>(array);
        }
    }
}
