using System;
using System.Numerics;

class Factorial
{
	static void Main(string[] args)
	{
		int lastNumber = int.Parse(Console.ReadLine());
		BigInteger factorial = FactorialResult(lastNumber);

		Console.WriteLine(factorial);
	}

	private static BigInteger FactorialResult(int lastNumber)
	{
		BigInteger factorial = 1;

		for (int currentNumber = 1; currentNumber <= lastNumber; currentNumber++)
		{
			factorial *= currentNumber;
		}

		return factorial;
	}
}