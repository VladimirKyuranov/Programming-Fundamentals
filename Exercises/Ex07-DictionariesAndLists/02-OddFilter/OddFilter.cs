using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .ToList();
        int sum = numbers.Sum();

        for (int index = 0; index < numbers.Count; index++)
        {
            if (numbers[index] > sum / numbers.Count)
            {
                numbers[index]++;
            }
            else
            {
                numbers[index]--;
            }
        }

        string output = string.Join(" ", numbers);

        Console.WriteLine(output);
    }
}