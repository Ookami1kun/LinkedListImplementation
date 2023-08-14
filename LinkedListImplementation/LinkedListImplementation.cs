﻿using LinkedListImplementation.Interfaces;

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
            foreach (var item in collection)
            {
                Add(item);
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

        public void Add(T value)
        {
            if (Tail == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
            }
            else
            {
                var current = new Node<T>(value);
                Tail.Next = current;
                current.Prev = Tail;
                Tail = current;
            }
        }

        public void AddStart(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
            }
            else
            {
                var current = new Node<T>(value);
                Head.Prev = current;
                current.Next = Head;
                Head = current;
            }
        }

        public bool Contains(T value)
        {
            bool result = false;
            var current = Head;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    result = true;
                    break;
                }

                current = current.Next;
            }

            return result;
        }

        public void Method(Node<T> current)
        {
            if (current.Prev == null)
            {
                Head = current.Next;
                Head.Prev = null;
            }
            else if (current.Next == null)
            {
                Tail = current.Prev;
                Tail.Next = null;
            }
            else
            {
                current.Next.Prev = current.Prev;
                current.Prev.Next = current.Next;
            }
        }

        public void RemoveByValue(T value)
        {
            var current = Head;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    Method(current);

                    break;
                }

                current = current.Next;
            }
        }

        public void RemoveLastByValue(T value)
        {
            var current = Tail;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    Method(current);

                    break;
                }

                current = current.Prev;
            }
        }

        public void RemoveFirst()
        {
            Head = Head.Next;
            Head.Prev = null;
        }

        public void RemoveLast()
        {
            Tail = Tail.Prev;
            Tail.Next = null;
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
