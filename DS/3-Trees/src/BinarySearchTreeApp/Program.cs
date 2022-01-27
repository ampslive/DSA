Console.WriteLine("-----------Binary Search Tree------------");

REPL.Run();

public class BST<T>
{
    public T Data { get; set; }
    public BST<T> Left { get; set; }
    public BST<T> Right { get; set; }

    public BST(T value)
    {
        Data = value;
    }

    public void Add(T value)
    {
        if (Comparer<T>.Default.Compare(value, Data) < 0)
        {
            if (Left != null)
            {
                Left.Add(value);
            }
            else
            {
                Left = new BST<T>(value);
            }
        }
        else
        {
            if (Right != null)
            {
                Right.Add(value);
            }
            else
            {
                Right = new BST<T>(value);
            }
        }
    }

    public void Find(T value)
    {
        if(Data != null)
        {
            if(Comparer<T>.Default.Compare(value,Data) < 0)
            {
                if(Left != null)
                {
                    Left.Find(value);
                }
                else
                {
                    Console.WriteLine($"{value} Not Found");
                }
            }
            else if(Comparer<T>.Default.Compare(value, Data) > 0)
            {
                if (Right != null)
                {
                    Right.Find(value);
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
    }

    public void ListAll()
    {

    }
}


