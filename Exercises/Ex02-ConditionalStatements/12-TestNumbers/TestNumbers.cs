using System;

class TestNumbers
{
    static void Main(string[] args)
    {
        int firstDigit = int.Parse(Console.ReadLine());
        int secondDigit = int.Parse(Console.ReadLine());
        int maxSum = int.Parse(Console.ReadLine());

        int sum = 0;
        int combinations = 0;

        for (int i = firstDigit; i > 0; i--)
        {
            for (int j = 1; j <= secondDigit; j++)
            {
                if (sum < maxSum)
                {
                    sum += 3 * (i * j);
                    combinations++;
                }
                else
                {
                    break;
                }
            }
        }

        Console.WriteLine($"{combinations} combinations");
        Console.Write($"Sum: {sum}");

        if (sum >= maxSum)
        {
            Console.WriteLine($" >= {maxSum}");
        }
        else
        {
            Console.WriteLine();
        }
    }
}
