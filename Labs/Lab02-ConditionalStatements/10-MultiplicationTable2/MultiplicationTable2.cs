using System;

class MultiplicationTable2
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        if (multiplier > 10)
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
        }
        for (int currentMultiplier = multiplier; currentMultiplier <= 10; currentMultiplier++)
        {
            Console.WriteLine($"{number} X {currentMultiplier} = {number * currentMultiplier}");
        }
    }
}
