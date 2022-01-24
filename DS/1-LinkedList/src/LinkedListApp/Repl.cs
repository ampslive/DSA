public static class REPL
{
    public static void Run()
    {
        var n1 = new LinkedList<int>();
        string? input = "";

        while (input != "exit")
        {
            Console.WriteLine("Operations : addhead | addtail | list | remove | show | exit");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "addhead":
                    {
                        var num = Console.ReadLine();
                        n1.AddToHead(Convert.ToInt32(num));
                        Console.WriteLine("Added");
                        break;
                    }
                case "addtail":
                    {
                        var num = Console.ReadLine();
                        n1.AddToTail(Convert.ToInt32(num));
                        Console.WriteLine("Added");
                        break;
                    }
                case "list":
                    {
                        foreach (var obj in n1.ListAll())
                        {
                            Console.WriteLine(obj.Value);
                        }
                        break;
                    }
                case "remove":
                    {
                        var num = Console.ReadLine();
                        n1.Remove(Convert.ToInt32(num));
                        Console.WriteLine("Removed");
                        break;
                    }
                case "show": n1.ShowListDetails(); break;
                case "exit": input = "exit"; break;
                default: break;

            }
        }
    }
}