using System;
using System.Numerics;

class FactorialTrailingZeroes
{
    static void Main(string[] args)
    {
        int lastNumber = int.Parse(Console.ReadLine());

        BigInteger factorial = FactorialResult(lastNumber);
        int trailingZeroes = TrailingZeroes(factorial);
        Console.WriteLine(trailingZeroes);
    }

    static BigInteger FactorialResult(int lastNumber)
    {
        BigInteger factorial = 1;

        for (int currentNumber = 1; currentNumber <= lastNumber; currentNumber++)
        {
            factorial *= currentNumber;
        }

        return factorial;
    }

    static int TrailingZeroes(BigInteger number)
    {
        int zerosCount = 0;

        while (number % 10 == 0)
        {
            zerosCount++;
            number /= 10;
        }

        return zerosCount;
    }
}
