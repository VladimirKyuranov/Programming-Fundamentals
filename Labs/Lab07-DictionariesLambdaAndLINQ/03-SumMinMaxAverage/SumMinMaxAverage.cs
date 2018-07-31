using System;
using System.Linq;

class SumMinMaxAverage
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");
    }
}