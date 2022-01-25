Console.WriteLine("-------QUEUE APP-------");

REPL.Run();

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Previous { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value, Node<T> previous = null, Node<T> next = null)
    {
        Value = value;
        Previous = previous;
        Next = next;
    }
}

public class Queue<T>
{
    public int Count { get; private set; }
    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }

    public void Add(T value)
    {
        if (Count == 0)
        {
            Head = new Node<T>(value);
            Count++;
            return;
        }

        if (Tail != null)
        {
            var currentTail = Tail;
            Tail = new Node<T>(value, null, currentTail);
            currentTail.Previous = Tail;
        }
        else
        {
            Tail = new Node<T>(value, null, Head);
            Head.Previous = Tail;
        }
        Count++;
    }

    public void Remove()
    {
        if (Count > 0)
        {
            if (Head.Previous != null)
            {
                var secondNode = Head.Previous;
                Head = secondNode;
                Head.Next = null;
                Head.Previous = secondNode.Previous;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            Count--;
        }
        else
        {
            Console.WriteLine("List is empty");
        }
    }

    public IEnumerable<Node<T>> ListAll()
    {
        var currentNode = Head;

        while (currentNode != null)
        {
            yield return currentNode;
            currentNode = currentNode.Previous;
        }
    }
}