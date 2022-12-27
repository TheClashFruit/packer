class Program
{
    static void Main(string[] args)
    {
        for (var i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--license":
                    Console.WriteLine("packer Copyright (C) 2022 TheClashFruit");
                    Console.WriteLine("This program comes with ABSOLUTELY NO WARRANTY; for details type `packer --fl'.");
                    Console.WriteLine("This is free software, and you are welcome to redistribute it");
                    Console.WriteLine("Under certain conditions; type `packer --fl' for details.");
                    break;
                case "--new":
                    if (!String.IsNullOrEmpty(args[i + 1]))
                    {
                        Console.WriteLine("Creating...");
                        Console.WriteLine("Created " + args[i + 1]);   
                    }
                    break;
            }
        }
    }
}