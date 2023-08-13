using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using LinkedListImplementation.Interfaces;

namespace LinkedListImplementation
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            ILinkedList<int> list =  new MyLinkedList<int>(array);
        }
    }
}
