using System;
using System.Linq;
using System.Numerics;
using System.Text;

class ConvertFromBase10ToBaseN
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split()
            .ToArray();

        int baseN = int.Parse(input[0]);
        BigInteger number = BigInteger.Parse(input[1]);
        string convertedNumber = ConvertToBaseN(number, baseN);

        Console.WriteLine(convertedNumber);
    }

    private static string ConvertToBaseN(BigInteger number, int baseN)
    {
        StringBuilder result = new StringBuilder();
        BigInteger remainder = 0;

        while(number > 0)
        {
            remainder = number % baseN;
            number /= baseN;
            result.Insert(0, remainder);
        }

        return result.ToString();
    }
}
