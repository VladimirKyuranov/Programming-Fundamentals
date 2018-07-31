using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        Console.WriteLine(isPrime);
    }

    static bool IsPrime(long number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}