using System.Collections;
using System.Runtime.Versioning;
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
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current.Data;

                current = current.Next;
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

        private void AddNode(T value, Action action)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                Tail = Head;
            }
            else
            {
                action();
            }

            Count++;
        }

        public void Add(T value)
        {
            AddNode(value, () =>
            {
                var current = new Node<T>(value);
                Tail.Next = current;
                current.Prev = Tail;
                Tail = current;
            });
        }

        public void AddStart(T value)
        {
            AddNode(value, () =>
            {
                var current = new Node<T>(value);
                Head.Prev = current;
                current.Next = Head;
                Head = current;
            });
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

        private void RemoveNode(Node<T> current)
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

            Count--;
        }

        public void RemoveByValue(T value)
        {
            var current = Head;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    RemoveNode(current);
                    break;
                }

                current = current.Next;
            }

            Count--;
        }

        public void RemoveLastByValue(T value)
        {
            var current = Tail;

            while (current != null)
            {
                if (value.CompareTo(current.Data) == 0)
                {
                    RemoveNode(current);
                    break;
                }

                current = current.Prev;
            }

            Count--;
        }

        public void RemoveFirst()
        {
            Head = Head.Next;
            Head.Prev = null;
            Count--;
        }

        public void RemoveLast()
        {
            Tail = Tail.Prev;
            Tail.Next = null;
            Count--;
        }

        public void Sort()
        {
            var current = Head;

            while (current.Next != null)
            {
                var newCurrent = current.Next;

                if (current.Data.CompareTo(newCurrent.Data) > 0)
                {
                    if (current.Prev == null)
                    {
                        current.Next = newCurrent.Next;
                        current.Prev = newCurrent;
                        newCurrent.Next.Prev = current;
                        newCurrent.Next = current;
                        newCurrent.Prev = null;
                        Head = newCurrent;
                    }
                    else if (newCurrent.Next == null)
                    {
                        newCurrent.Next = current;
                        newCurrent.Prev = current.Prev;
                        current.Prev.Next = newCurrent;
                        current.Prev = newCurrent;
                        current.Next = null;
                        Tail = current;
                    }
                    else
                    {
                        current.Prev.Next = newCurrent;
                        newCurrent.Prev = current.Prev;
                        current.Next = newCurrent.Next;
                        current.Prev = newCurrent;
                        newCurrent.Next.Prev = current;
                        newCurrent.Next = current;
                    }

                    current = Head;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public void Reverse()
        {
            Node<T> temp = null;
            var current = Head;
            Tail = Head;

            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                current = current.Prev;
            }

            if (temp != null)
            {
                Head = temp.Prev;
            }
        }

        public ILinkedList<T> Copy()
        {
            T[] array = new T[Count];
            var current = Head;

            for (int i = 0; i < Count; i++)
            {
                array[i] = current.Data;
                current = current.Next;
            }

            return new MyLinkedList<T>(array);
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
