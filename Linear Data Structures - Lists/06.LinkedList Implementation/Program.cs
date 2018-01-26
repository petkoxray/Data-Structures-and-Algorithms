using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.LinkedList_Implementation
{
    class LinkedList<T> : IEnumerable<T>
    {
        public int Count { get; set; }

        private class ListNode<T>
        {
            public T Value { get; set; }
            public ListNode<T> Next { get; set; }
            public ListNode(T Value)
            {
                this.Value = Value;
            }
        }

        private ListNode<T> head;

        public void Add(T element)
        {
            if (this.head == null)
            {
                this.head = new ListNode<T>(element);
            }
            else
            {
                var currentNode = this.head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = new ListNode<T>(element);
            }

            this.Count++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var currendNode = this.head;

            while (currendNode != null)
            {
                yield return currendNode.Value;
                currendNode = currendNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            var index = 0;
            var currentNode = this.head;

            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return arr;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(10);
            list.Add(30);
            list.Add(40);
            list.Add(1);
            Console.WriteLine(string.Join(" ", list.ToArray()));
        }
    }
}
