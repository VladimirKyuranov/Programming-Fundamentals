using System;
using System.Linq;

class InventoryMatcher
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine()
            .Split(' ')
            .ToArray();
        long[] quantities = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();
        decimal[] prices = Console.ReadLine()
            .Split(' ')
            .Select(decimal.Parse)
            .ToArray();
        string name = Console.ReadLine();

        while (name != "done")
        {
            int index = Array.IndexOf(names, name);
            Console.WriteLine($"{name} costs: {prices[index]}; Available quantity: {quantities[index]}");
            name = Console.ReadLine();
        }
    }
}