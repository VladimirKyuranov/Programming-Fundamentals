using System;
using System.Collections.Generic;
using System.Linq;

class SortNumbers
{
    static void Main(string[] args)
    {
        List<double> numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        numbers.Sort();

        Console.WriteLine(string.Join(" <= ", numbers));
    }
}