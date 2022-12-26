class Program
{
    static void Main(string[] args)
    {
        switch (args[0])
        {
            case "--license":
                Console.WriteLine("Please visit https://github.com/TheClashFruit/packer/blob/main/LICENSE for the full license.\n");
                
                Console.WriteLine("  packer  Copyright (C) 2022  TheClashFruit");
                Console.WriteLine("  This program comes with ABSOLUTELY NO WARRANTY; for details type `packer --license'.");
                Console.WriteLine("  This is free software, and you are welcome to redistribute it");
                Console.WriteLine("  under certain conditions; type `packer --license' for details.");
                break;
            case "--new":
                if (args[1] != "")
                {
                    Console.WriteLine("Creating " + args[1] + ".");
                }
                
                break;
            default:
                Console.WriteLine("help");
                break;
        }
    }
}