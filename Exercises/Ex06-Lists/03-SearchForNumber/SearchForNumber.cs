using System;
using System.Collections.Generic;
using System.Linq;

class SearchForNumber
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
        int[] commands = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

        numbers = numbers.Take(commands[0]).ToList();
        numbers.RemoveRange(0, commands[1]);

        if (numbers.Contains(commands[2]))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}