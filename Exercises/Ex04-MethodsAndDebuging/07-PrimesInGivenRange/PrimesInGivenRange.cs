using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        string output = string.Join(", ", PrimesInRange(startNumber, endNumber));

        Console.WriteLine(output);
    }

    static List<int> PrimesInRange(int startNumber, int endNumber)
    {
        List<int> result = new List<int>();

        for (int number = startNumber; number <= endNumber; number++)
        {
            if (IsPrime(number))
            {
                result.Add(number);
            }
        }

        return result;
    }

    static bool IsPrime(int number)
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
