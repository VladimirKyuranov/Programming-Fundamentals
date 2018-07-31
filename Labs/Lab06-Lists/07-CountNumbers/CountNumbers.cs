using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

        int[] counts = new int[1001];

        foreach (int number in numbers)
        {
            counts[number]++;
        }

        for (int index = 0; index < counts.Length; index++)
        {
            if (counts[index] != 0)
            {
                Console.WriteLine($"{index} -> {counts[index]}");
            }
        }
    }
}