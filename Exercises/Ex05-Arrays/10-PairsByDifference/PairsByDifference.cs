using System;
using System.Linq;

class PairsByDifference
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int difference = int.Parse(Console.ReadLine());

        int[] numbers = input
            .Split()
            .Select(int.Parse)
            .ToArray();
        int count = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            for (int next = index + 1; next < numbers.Length; next++)
            {
                if (numbers[index] - numbers[next] == difference
					|| numbers[next] - numbers[index] == difference)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}