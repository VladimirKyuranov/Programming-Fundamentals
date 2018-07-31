using System;
using System.Numerics;

class BigFactorial
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int num = 1; num <= number; num++)
        {
            factorial *= num;
        }

        Console.WriteLine(factorial);
    }
}