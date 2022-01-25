public static class REPL
{
    public static void Run()
    {
        var n1 = new Queue<int>();
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
                        Console.WriteLine("Enqueued");
                        break;
                    }
                case "list":
                    {
                        Console.WriteLine(String.Join(" < ", n1.ListAll().Select(x=>x.Value)));
                        break;
                    }
                case "remove":
                    {
                        n1.Remove();
                        Console.WriteLine("Dequeued");
                        break;
                    }
                case "exit": input = "exit"; break;
                default: break;

            }
        }
    }
}