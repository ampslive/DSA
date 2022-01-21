// See https://aka.ms/new-console-template for more information
Console.WriteLine("Linked List App");




public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }
    public Node(int value, Node next = null, Node previous = null)
    {
        this.Value = value;
        this.Next = next;
        this.Previous = previous;
    }
}

]public class LinkedList
{
    private Node Nodes { get; set; }

    public Node Head { get => GetHead(); }
    public void AddToHead(int value)
    {
        var currentHead = this.Head;

        currentHead.
    }

    private Node GetHead()
    {
        var currentNode = Nodes;
        while (currentNode.Previous != null)
        {
            currentNode = currentNode.Next;
        }
        return currentNode;
    }

    public Node Tail { get; }
}
