using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers
{
    static void Main(string[] args)
    {
        List<double> numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        for (int index = 0; index < numbers.Count - 1; index++)
        {
            if (numbers[index] == numbers[index + 1])
            {
                numbers[index] += numbers[index + 1];
                numbers.RemoveAt(index + 1);
                index = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}