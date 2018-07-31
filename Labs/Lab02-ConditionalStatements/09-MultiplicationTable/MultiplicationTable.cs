using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
        }
    }
}
