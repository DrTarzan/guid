class Program
{
    static void Main(string[] args)
    {
        if (args != null && args.Length > 0)
        {
            if (args[0] == "?" || args[0] == "-?" || args[0] == "/?")
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Usage:");
                System.Console.WriteLine("\t> guid -[count(int)]");
                System.Console.WriteLine();
                System.Console.WriteLine("Examples:");
                System.Console.WriteLine("\t> guid \t ...Gives one GUID");
                System.Console.WriteLine("\t> guid -2 \t ...Gives two GUIDs and so on");
                System.Console.WriteLine("\t> guid /2 \t ...Gives two GUIDs and so on");
            }
            else
            {
                System.Console.WriteLine();
                try
                {
                    string arg = args[0].TrimStart('/').TrimStart('-');
                    int loop = System.Convert.ToInt32(arg);
                    if (loop > 1)
                    { 
                        System.Console.WriteLine("New GUID's");
                    }
                    else
                    {
                        System.Console.WriteLine("New GUID");
                    }
                    System.Console.WriteLine("====================================");
                    if (loop > 0)
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            DoPrint();
                        }
                    }
                }
                catch
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("New GUID");
                    System.Console.WriteLine("====================================");
                    DoPrint();
                }
            }
        }
        else
        {
            System.Console.WriteLine("New GUID");
            System.Console.WriteLine("====================================");
            DoPrint();
        }
    }

    static void DoPrint()
    {
        string guid = System.Guid.NewGuid().ToString().ToUpper();
        System.Console.WriteLine(guid);
    }
}
