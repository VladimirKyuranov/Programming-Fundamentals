using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        numbers = numbers.OrderByDescending(num => num).ToList();

        List<int> selected = numbers.Where(num => Math.Sqrt(num) == (int)Math.Sqrt(num)).ToList();

        Console.WriteLine(string.Join(" ", selected));
    }
}