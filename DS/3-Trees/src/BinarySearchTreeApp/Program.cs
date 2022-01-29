Console.WriteLine("-----------Binary Search Tree------------");

REPL.Run();

public class Node<T>
{
    public T Data { get; set; }

    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public Node(T value)
    {
        Data = value;
    }
}

public class BST<T>
{
    Node<T> Root;

    public void Add(T value, Node<T> currentNode = null)
    {
        if (this.Root == null)
        {
            Root = new Node<T>(value);
            return;
        }

        if (currentNode == null)
            currentNode = this.Root;

        if (Comparer<T>.Default.Compare(value, currentNode.Data) < 0)
        {
            if (currentNode.Left != null)
            {
                Add(value, currentNode.Left);
            }
            else
            {
                currentNode.Left = new Node<T>(value);
            }
        }
        else
        {
            if (currentNode.Right != null)
            {
                Add(value, currentNode.Right);
            }
            else
            {
                currentNode.Right = new Node<T>(value);
            }
        }
    }

    public void Find(T value, Node<T> currentNode = null)
    {
        if (Root == null)
        {
            Console.WriteLine($"{value} Not Found. Tree is empty");
            return;
        }

        if (currentNode == null)
            currentNode = Root;


        if (Comparer<T>.Default.Compare(value, currentNode.Data) < 0)
        {
            if (currentNode.Left != null)
            {
                Find(value, currentNode.Left);
            }
            else
            {
                Console.WriteLine($"{value} Not Found");
            }
        }
        else if (Comparer<T>.Default.Compare(value, currentNode.Data) > 0)
        {
            if (currentNode.Right != null)
            {
                Find(value, currentNode.Right);
            }
            else
            {
                Console.WriteLine($"{value} Not Found");
            }
        }
        else
        {
            Console.WriteLine($"{value} exists in BST");
        }
    }

    public void ListAll()
    {
        Console.WriteLine("InOrder Traversal");
        PrintInOrder(this.Root);

        Console.WriteLine("PreOrder Traversal");
        PrintPreOrder(this.Root);

        Console.WriteLine("PostOrder Traversal");
        PrintPostOrder(this.Root);
    }

    private void PrintInOrder(Node<T> node)
    {
        if (node == null)
            return;

        PrintInOrder(node.Left);

        Console.WriteLine(node.Data + " ");

        PrintInOrder(node.Right);
    }

    private void PrintPreOrder(Node<T> node)
    {
        if (node == null)
            return;

        Console.WriteLine(node.Data);

        PrintPreOrder(node.Left);

        PrintPreOrder(node.Right);
    }

    private void PrintPostOrder(Node<T> node)
    {
        if (node == null)
            return;

        PrintPreOrder(node.Left);

        PrintPreOrder(node.Right);
        
        Console.WriteLine(node.Data);
    }

}


