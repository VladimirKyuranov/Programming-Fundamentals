using System;

class GameOfNumbers
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int combinations = 0;
        string lastCombination = "";

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {
                combinations++;
                if (i + j == magicNumber)
                {
                    lastCombination = $"Number found! {i} + {j} = {magicNumber}";
                }
            }
        }

        if (lastCombination == "")
        {
            lastCombination = $"{combinations} combinations - neither equals {magicNumber}";
        }

        Console.WriteLine(lastCombination);
    }
}
