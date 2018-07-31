using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main(string[] args)
    {
        double[] input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        var numbers = new SortedDictionary<double, int>();

        foreach (double num in input)
        {
            if (numbers.ContainsKey(num) == false)
            {
                numbers.Add(num, 0);
            }

            numbers[num]++;
        }

        foreach (var number in numbers)
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}