using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        int[] bomb = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int bombNumber = bomb[0];
        int bombPower = bomb[1];
        int index = numbers.IndexOf(bombNumber);
        int start = 0;
        int end = 0;

        while (index != -1)
        {
            if (index - bombPower >= 0)
            {
                start = index - bombPower;
            }
            else
            {
                start = 0;
            }

            if (index + bombPower < numbers.Count)
            {
                end = index + bombPower;
            }
            else
            {
                end = numbers.Count - 1;
            }

            numbers.RemoveRange(start, end - start + 1);
            index = numbers.IndexOf(bombNumber);
        }

        Console.WriteLine(numbers.Sum());
    }
}