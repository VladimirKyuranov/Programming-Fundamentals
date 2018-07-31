using System;
using System.Linq;

class SumReversedNumbers
{
    static void Main(string[] args)
    {
       string[] numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        int sum = 0;

        foreach (string number in numbers)
        {
            char[] num = number
				.ToCharArray()
				.Reverse()
				.ToArray();
            sum += int.Parse(new string(num));
        }

        Console.WriteLine(sum);
    }
}