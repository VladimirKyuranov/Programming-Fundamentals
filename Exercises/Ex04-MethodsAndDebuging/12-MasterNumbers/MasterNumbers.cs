using System;

class MasterNumbers
{
    static void Main(string[] args)
    {
        int lastNumber = int.Parse(Console.ReadLine());

        for (int number = 1; number <= lastNumber; number++)
        {
            if (IsPalindrome(number) && IsSumOfDigitsDivisibleBySeven(number) && ContainsEvenDigit(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    private static bool ContainsEvenDigit(int number)
    {
        while(number > 0)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 == 0)
            {
                return true;
            }

            number /= 10;
        }

        return false;
    }

    private static bool IsSumOfDigitsDivisibleBySeven(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        if (sum % 7 == 0)
        {
            return true;
        }

        return false;

    }

    private static bool IsPalindrome(int number)
    {
        int reversedNumber = 0;
        int oldNumber = number;

        while (number > 0)
        {
            reversedNumber *= 10;
            reversedNumber += number % 10;
            number /= 10;
        }

        if (reversedNumber == oldNumber)
        {
            return true;
        }

        return false;
    }
}
