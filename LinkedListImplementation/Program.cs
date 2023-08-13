using System.Data.SqlTypes;
using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    class Program 
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> array = new int[] { 1, 2, 3, 4, 5};

            MyLinkedList<int> list= new MyLinkedList<int>(array);
        }
    }
}
