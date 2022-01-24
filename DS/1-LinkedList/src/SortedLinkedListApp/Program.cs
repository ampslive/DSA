Console.WriteLine("----------Sorted Linked List App----------");

REPL.Run();

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

public class SortedList<T>
{
    public int Count { get; private set; }
    public Node<T> Head { get; set; }

    public void Add(T value)
    {
        Node<T> newNode;

        if (Count == 0)
        {
            this.Head = new Node<T>(value, null, null);
            Count++;
            return;
        }

        var currentNode = Head;

        while (currentNode != null)
        {
            //If CurrentNode > Value && CurrentNode.Next > Value : Go to next node
            if (Comparer<T>.Default.Compare(currentNode.Value, value) <= 0)
            {
                if (currentNode.Next == null)
                {
                    newNode = new Node<T>(value, currentNode.Next, currentNode);
                    currentNode.Next = newNode;
                    break;
                }
                else if (currentNode.Next != null && (Comparer<T>.Default.Compare(currentNode.Next.Value, value) > 0))
                {
                    newNode = new Node<T>(value, currentNode.Next, currentNode);
                    currentNode.Next = newNode;
                    currentNode.Next.Previous = newNode;
                    break;
                }
                else
                    currentNode = currentNode.Next;

            }
            else 
            {
                if (currentNode.Previous == null)
                {
                    Head = new Node<T>(value, currentNode, null);
                    currentNode.Previous = Head;
                    break;
                }
            }
        }
        Count++;
    }

    public void Remove(T value)
    {
        var node = Find(value);

        if (node != null)
        {
            var prev = node.Previous;
            var next = node.Next;

            prev.Next = next;
        }
        else
            Console.WriteLine("Not Found");
    }

    public Node<T> Find(T value)
    {
        var currentNode = Head;
        
        while (currentNode != null)
        {
            if (currentNode.Value.Equals(value))
            {
                return currentNode;
            }
            currentNode = currentNode.Next;
        }
        return null;
    }

    public IEnumerable<Node<T>> ListAll()
    {
        var currentNode = Head;
        while (currentNode != null)
        {
            yield return currentNode;
            currentNode = currentNode.Next;
        }
    }
}