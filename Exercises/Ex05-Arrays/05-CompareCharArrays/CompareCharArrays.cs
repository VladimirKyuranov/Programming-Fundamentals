using System;
using System.Linq;

class CompareCharArrays
{
	static void Main(string[] args)
	{
		char[] firstArray = Console.ReadLine()
			.Split()
			.Select(char.Parse)
			.ToArray();
		char[] secondArray = Console.ReadLine()
			.Split()
			.Select(char.Parse)
			.ToArray();

		int minLength = Math.Min(firstArray.Length, secondArray.Length);
		bool areEqual = true;

		areEqual = CompareChars(firstArray, secondArray, minLength, areEqual);
		CompareLengths(firstArray, secondArray, areEqual);
	}

	private static bool CompareChars(char[] firstArray, char[] secondArray, int minLength, bool areEqual)
	{
		for (int index = 0; index < minLength; index++)
		{
			if (firstArray[index] < secondArray[index])
			{
				PrintArrays(firstArray, secondArray);
				areEqual = false;
				break;
			}
			else if (firstArray[index] > secondArray[index])
			{
				PrintArrays(secondArray, firstArray);
				areEqual = false;
				break;
			}
		}

		return areEqual;
	}

	private static void CompareLengths(char[] firstArray, char[] secondArray, bool areEqual)
	{
		if (areEqual)
		{
			if (firstArray.Length <= secondArray.Length)
			{
				PrintArrays(firstArray, secondArray);
			}
			else
			{
				PrintArrays(secondArray, firstArray);
			}
		}
	}

	private static void PrintArrays(char[] firstArray, char[] secondArray)
	{
		Console.WriteLine(string.Join("", firstArray));
		Console.WriteLine(string.Join("", secondArray));
	}
}