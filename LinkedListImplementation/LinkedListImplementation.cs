﻿using LinkedListImplementation.Interfaces;

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
            head = new Node<T>(collection.First());
            var current = head;
            tail = current;

            foreach (var item in collection.Skip(1))
            {
                var newCurrent = new Node<T>(item);
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

        public void Add(T value)
        {
            var current = new Node<T>(value);
            tail.Next = current;
            current.Prev = tail;
            tail = current;
        }

        public void AddStart(T value)
        {
            var current = new Node<T>(value);
            head.Prev = current;
            current.Next = head;
            head = current;
        }

        public bool Contains(T value)
        {
            bool result = false;
            var current = head;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    result = true;
                }

                current = current.Next;
            }

            return result;
        }

        public void RemoveByValue(T value)
        {
            var current = head;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    if (current.Prev == null)
                    {
                        head = current.Next;
                        head.Prev = null;
                    }
                    else if (current.Next == null)
                    {
                        tail = current.Prev;
                        tail.Next = null;
                    }
                    else
                    {
                        var newCurrent = current.Prev;
                        newCurrent.Next = current.Next;
                        newCurrent.Next.Prev = current.Prev;
                        current = newCurrent;
                    }

                    break;
                }

                current = current.Next;
            }
        }

        public void RemoveLastByValue(T value)
        {
            var current = tail;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    if (current.Prev == null)
                    {
                        head = current.Next;
                        head.Prev = null;
                    }
                    else if (current.Next == null)
                    {
                        tail = current.Prev;
                        tail.Next = null;
                    }
                    else
                    {
                        var newCurrent = current.Prev;
                        newCurrent.Next = current.Next;
                        newCurrent.Next.Prev = current.Prev;
                        current = newCurrent;
                    }

                    break;
                }

                current = current.Prev;
            }
        }

        public void RemoveFirst()
        {
            head = head.Next;
            head.Prev = null;
        }

        public void RemoveLast()
        {
            tail = tail.Prev;
            tail.Next = null;
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
