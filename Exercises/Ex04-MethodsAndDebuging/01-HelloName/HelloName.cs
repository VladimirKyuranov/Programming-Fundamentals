using System;

class HelloName
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();

        HelloByName(name);
    }

    static void HelloByName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
