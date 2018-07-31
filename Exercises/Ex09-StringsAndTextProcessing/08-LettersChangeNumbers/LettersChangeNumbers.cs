using System;
using System.Linq;

class LettersChangeNumbers
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        double sum = GetSum(input);

        Console.WriteLine("{0:F2}", sum);
    }

    static double GetSum(string[] input)
    {
        double sum = 0;

        for (int index = 0; index < input.Length; index++)
        {
			string word = input[index];
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            string num = string.Join("", word.Skip(1));
            double number = double.Parse(num.Remove(num.Length - 1));

            if (char.IsUpper(firstLetter))
            {
                number /= firstLetter - 64;
            }
            else
            {
                number *= firstLetter - 96;
            }

            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 64;
            }
            else
            {
                number += lastLetter - 96;
            }

            sum += number;
        }

        return sum;
    }
}