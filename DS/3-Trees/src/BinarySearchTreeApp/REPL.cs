public static class REPL
{
    public static void Run()
    {
        var n1 = new BST<int>();
        n1.Add(5);
        n1.Add(3);
        n1.Add(7);  
        n1.Add(2);
        n1.Add(4);
        n1.Add(1);
        n1.Add(6);
        n1.Add(8);

        string? input = "";

        while (input != "exit")
        {
            Console.WriteLine("Operations : add | find | list | remove | exit");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "add":
                    {
                        var num = Console.ReadLine();
                        n1.Add(Convert.ToInt32(num));
                        Console.WriteLine("Pushed");
                        break;
                    }
                case "find":
                    {
                        var num = Console.ReadLine();
                        n1.Find(Convert.ToInt32(num));
                        break;
                    }
                case "list":
                    {
                        n1.ListAll();
                        break;
                    }
                case "remove":
                    {
                        //n1.Remove();
                        Console.WriteLine("Pop");
                        break;
                    }
                case "exit": input = "exit"; break;
                default: break;

            }
        }
    }
}
