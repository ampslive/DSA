public static class REPL
{
    public static void Run()
    {
        var n1 = new Stack<int>();
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
                        Console.WriteLine("Pushed");
                        break;
                    }
                case "list":
                    {
                        n1.ListAll();
                        break;
                    }
                case "remove":
                    {
                        n1.Remove();
                        Console.WriteLine("Pop");
                        break;
                    }
                case "exit": input = "exit"; break;
                default: break;

            }
        }
    }
}
