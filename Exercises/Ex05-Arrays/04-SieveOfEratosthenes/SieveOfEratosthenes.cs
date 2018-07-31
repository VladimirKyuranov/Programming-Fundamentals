using System;
using System.Text;

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
		StringBuilder builder = new StringBuilder();

        int endNumber = int.Parse(Console.ReadLine());

        if (endNumber > 1)
        {
            GetPrimes(endNumber + 1, builder);
        }

		string result = builder.ToString().TrimEnd();
		Console.WriteLine(result);
    }

    private static void GetPrimes(int endNumber, StringBuilder builder)
    {
        bool[] arePrimes = new bool[endNumber];
        int min = 0;

        arePrimes[0] = false;
        arePrimes[1] = false;

        for (int index = 2; index < arePrimes.Length; index++)
        {
            arePrimes[index] = true;
        }

        while (min <= endNumber)
        {
            for (int index = min; index < arePrimes.Length; index++)
            {
                if (arePrimes[index])
                {
                    min = index;
                    builder.Append($"{min} ");
                    break;
                }
            }

            for (int index = min + 1; index < arePrimes.Length; index++)
            {
                if (index % min == 0)
                {
                    arePrimes[index] = false;
                }
            }

            min++;
        }
    }
}
