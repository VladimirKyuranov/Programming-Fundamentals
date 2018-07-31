using System;

class MultiplyEvenByOdds
{
    static void Main(string[] args)
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));

        int multipleEvensByOdds = GetMultipleOfEvensByOdds(number);

        Console.WriteLine(multipleEvensByOdds);
    }

    static int GetMultipleOfEvensByOdds(int number)
    {
        int evenSum = GetEvenSum(number);
        int oddSum = GetOddSum(number);
        return evenSum * oddSum;
    }

    static int GetEvenSum(int number)
    {
        int evenSum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            number /= 10;
        }

        return evenSum;
    }

    static int GetOddSum(int number)
    {
        int oddSum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                oddSum += digit;
            }
            number /= 10;
        }

        return oddSum;
    }
}
