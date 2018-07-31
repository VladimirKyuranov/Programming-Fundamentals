using System;
using System.Linq;

class RoundingNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        double[] numbersToRound = input
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        for (int i = 0; i < numbersToRound.Length; i++)
        {
            double roundedNumber = Math.Round(numbersToRound[i], MidpointRounding.AwayFromZero);

            Console.WriteLine($"{numbersToRound[i]} => {roundedNumber}");
        }
    }
}