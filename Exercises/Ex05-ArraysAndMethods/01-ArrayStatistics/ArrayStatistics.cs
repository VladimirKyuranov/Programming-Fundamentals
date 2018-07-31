using System;
using System.Linq;

class ArrayStatistics
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] numbers = input
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average = 0;

        for (int index = 0; index < numbers.Length; index++)
        {
            sum += numbers[index];

            if (numbers[index] > max)
            {
                max = numbers[index];
            }

            if (numbers[index] < min)
            {
                min = numbers[index];
            }
        }

        average = 1.0 * sum / numbers.Length;

        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }
}