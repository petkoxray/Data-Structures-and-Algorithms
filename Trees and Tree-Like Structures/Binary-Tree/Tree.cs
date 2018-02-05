using System;
using System.Collections.Generic;

public class Tree<T>
{
    public T Value { get; set; }
    public IList<Tree<T>> Children { get; private set; }

    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = new List<Tree<T>>();

        foreach (var child in children)
        {
            this.Children.Add(child);
        }
    }

    public void Print(int indent = 0)
    {
        Console.WriteLine(new string(' ', 2 * indent) + this.Value);

        foreach(var child in this.Children)
        {
            child.Print(++indent);
        }
    }

    public void Each(Action<T> action)
    {
        action(this.Value);

        foreach(var child in this.Children)
        {
            action(child.Value);
        }
    }
}
