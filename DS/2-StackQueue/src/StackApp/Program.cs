// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

REPL.Run();

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Previous { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value, Node<T> next = null, Node<T> previous = null)
    {
        Value = value;
        Next = next;
        Previous = previous;
    }
}

public class Stack<T>
{
    Node<T> Top { get; set; }
    public void Add(T value)
    {
        if (Top == null)
        {
            Top = new Node<T>(value);
            return;
        }

        var currentTop = Top;

        if (currentTop.Previous != null)
        {
            Top = new Node<T>(value, null, currentTop);
            currentTop.Next = Top;
        }
        else
        {
            Top = new Node<T>(value, null, currentTop);
            currentTop.Next = Top;
        }
    }

    public void Remove()
    {
        var currentTop = Top;

        if(currentTop == null)
        {
            Console.Write("Empty");
            return;
        }

        if (currentTop.Previous != null)
        {
            Top = currentTop.Previous;
            Top.Next = null;
        }
        else
        {
            Top = null;
        }
    }

    public void ListAll()
    {
        var currentNode = Top;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Previous;
        }
    }
}