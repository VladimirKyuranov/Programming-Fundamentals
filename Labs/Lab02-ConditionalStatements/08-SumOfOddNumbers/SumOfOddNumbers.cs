using System;

class SumOfOddNumbers
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int number = 1; number <= 2 * count; number++)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
                sum += number;
            }
        }
        Console.WriteLine($"Sum: {sum}");
    }
}
