using System;
using System.Collections.Generic;
using System.Linq;

class LargestThreeNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        Console.WriteLine(string.Join(" ", numbers.OrderByDescending(num => num).Take(3)));
    }
}