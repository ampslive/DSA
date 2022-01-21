Console.WriteLine("----------Linked List App----------");

var n1 = new LinkedList<int>(1);
var n2 = new LinkedList<int>(2, null, n1);
n1.Next = n2;


n1.ShowListDetails();

Console.WriteLine($"Adding to Head");
n1.AddToHead(3);

n1.ShowListDetails();

Console.WriteLine($"Adding to Tail");
n1.AddToTail(4);

n1.ShowListDetails();

public class LinkedList<T>
{
    public T Value { get; set; }
    public LinkedList<T> Next { get; set; }
    public LinkedList<T> Previous { get; set; }
    public LinkedList(T value, LinkedList<T> next = null, LinkedList<T> previous = null)
    {
        this.Value = value;
        this.Next = next;
        this.Previous = previous;
    }

    public LinkedList<T> Head { get => GetHead(this); }
    public LinkedList<T> Tail { get => GetTail(this); }

    public void AddToHead(T value)
    {
        var currentHead = this.Head;

        var newHead = new LinkedList<T>(value, currentHead);
        currentHead.Previous = newHead;
    }

    public void AddToTail(T value)
    {
        var currentTail = this.Tail;

        var newTail = new LinkedList<T>(value, null, currentTail);
        currentTail.Next = newTail;
    }

    public void ShowListDetails()
    {
        Console.WriteLine($"Head: {this.Head.Value}");
        Console.WriteLine($"Tail: {this.Tail.Value}");
    }

    private LinkedList<T> GetHead(LinkedList<T> list)
    {
        var currentNode = list;
        while (currentNode.Previous != null)
        {
            currentNode = currentNode.Previous;
        }
        return currentNode;
    }

    private LinkedList<T> GetTail(LinkedList<T> list)
    {
        var currentNode = list;
        while (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
        }
        return currentNode;
    }
}
