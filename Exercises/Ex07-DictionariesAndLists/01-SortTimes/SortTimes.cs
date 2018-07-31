using System;
using System.Linq;

class SortTimes
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split()
            .ToArray();

        string output = string.Join(", ", input.OrderBy(x => x));

        Console.WriteLine(output);
    }
}