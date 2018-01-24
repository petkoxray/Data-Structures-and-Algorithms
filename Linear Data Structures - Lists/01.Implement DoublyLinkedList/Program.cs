using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    public int Count { get; private set; }

    private class ListNode<T>
    {
        public T Value { get; private set; }
        public ListNode<T> Previous { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T Value)
        {
            this.Value = Value;
        }
    }

    private ListNode<T> head;
    private ListNode<T> tail;

    public void AddFirst(T element)
    {
        var node = new ListNode<T>(element);

        if (this.Count == 0)
        {
            this.head = this.tail = node;
        }
        else
        {
            node.Next = this.head;
            this.head.Previous = node;
            this.head = node;
        }

        this.Count++;
    }

    public void AddLast(T element)
    {
        var node = new ListNode<T>(element);

        if (this.Count == 0)
        {
            this.head = this.tail = node;
        }
        else
        {
            node.Previous = this.tail;
            this.tail.Next = node;
            this.tail = node;
        }

        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("List is empty");
        }

        var firstElementValue = this.head.Value;
        this.head = this.head.Next;

        if (this.head != null)
        {
            this.head.Previous = null;
        }
        else
        {
            this.tail = null;
        }

        this.Count--;

        return firstElementValue;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("List is empty");
        }

        var lastElementValue = this.tail.Value;
        this.tail = this.tail.Previous;
        if (this.tail != null)
        {
            this.tail.Next = null;
        }
        else
        {
            this.head = null;
        }

        this.Count--;

        return lastElementValue;
    }

    public void ForEach(Action<T> action)
    {
        var currentNode = this.head;
        while (currentNode != null)
        {
            action(currentNode.Value);
            currentNode = currentNode.Next;
        }
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
    static void Main()
    {
        var list = new DoublyLinkedList<int>();
        list.AddFirst(10);
        list.AddFirst(30);
        list.AddLast(50);
        list.AddLast(70);
        list.RemoveFirst();

        foreach (var el in list)
        {
            Console.WriteLine(el);
        }

        list.RemoveFirst();
    }
}
