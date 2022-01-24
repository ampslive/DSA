public static class REPL
{
    public static void Run()
    {
        var n1 = new SortedList<int>();
        string? input = "";

        while (input != "exit")
        {
            Console.WriteLine("Operations : add | list | remove | exit");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "add":
                    {
                        var num = Console.ReadLine();
                        n1.Add(Convert.ToInt32(num));
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
                case "exit": input = "exit"; break;
                default: break;

            }
        }
    }
}