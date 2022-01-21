Console.WriteLine("----------Linked List App----------");

var n1 = new LinkedList<int>();

Console.WriteLine($"Adding");
n1.AddToHead(1);
n1.AddToHead(2);
n1.AddToTail(3);
n1.AddToTail(4);

Console.WriteLine($"List all...");
foreach(var obj in n1.ListAll())
{
    Console.WriteLine(obj.Value);
}

Console.WriteLine($"Remove");
n1.Remove(3);

Console.WriteLine($"List all remove...");
foreach(var obj in n1.ListAll())
{
    Console.WriteLine(obj.Value);
}

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Previous { get; set; }

    public Node(T value, Node<T> next = null, Node<T> previous = null)
    {
        Value = value;
        Next = next;
        Previous = previous;
    }
}

public class LinkedList<T>
{
    public int Count { get; private set; }
    private  Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }

    public void AddToHead(T value)
    {
        if (Count == 0)
        {
            this.Head = new Node<T>(value);
            this.Tail = new Node<T>(value);
        }
        else
        {
            var newHead = new Node<T>(value, this.Head);
            this.Head.Previous = newHead;

            this.Tail = Head;
            this.Head = newHead;
        }
        Count++;
    }

    public void AddToTail(T value)
    {
        if (Count == 0)
        {
            this.Head = new Node<T>(value);
            this.Tail = new Node<T>(value);
        }
        else
        {
            var newTail = new Node<T>(value, null, this.Tail);
            this.Tail.Next = newTail;

            this.Tail = newTail;
        }
        Count++;
    }

    public void ShowListDetails()
    {
        Console.WriteLine($"Head: {this.Head.Value}");
        Console.WriteLine($"Tail: {this.Tail.Value}");
        Console.WriteLine($"Count: {this.Count}");
    }

    public Node<T> Find(T value)
    {
        foreach(var obj in this.ListAll())
        {
            if(obj.Value != null && obj.Value.Equals(value))
                return obj;
        }
        return null;
    }

    public void Remove(T value)
    {
        var obj = Find(value);

        if(obj != null)
        {
            var previousNode = obj.Previous;
            var nextNode = obj.Next;

            if(previousNode == null)
            {
                Head = nextNode;
                Head.Previous = null;
            }
            else 
            {
                previousNode.Next = nextNode;
            }

            if(nextNode == null)
            {
                Tail = previousNode;
                Tail.Next = null;
            }
            else
            {
                nextNode.Previous = previousNode;
            }

            Count--;
        }
    }
    
    public IEnumerable<Node<T>> ListAll()
    {
        var currentNode = Head;
        while(currentNode != null)
        {   
            yield return currentNode;
            currentNode = currentNode.Next;
        }
    }
}
