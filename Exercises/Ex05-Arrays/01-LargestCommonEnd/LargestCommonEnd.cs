using System;
using System.Linq;

class LargestCommonEnd
{
	static void Main(string[] args)
	{
		string firstWordInput = Console.ReadLine();
		string secondWordInput = Console.ReadLine();

		string[] firstWord = firstWordInput.Split().ToArray();
		string[] secondWord = secondWordInput.Split().ToArray();
		int leftCount = GetCommonEndCount(firstWord, secondWord);

		firstWord = firstWord.Reverse().ToArray();
		secondWord = secondWord.Reverse().ToArray();

		int rightCount = GetCommonEndCount(firstWord, secondWord);
		int largestCommonEnd = Math.Max(leftCount, rightCount);

		Console.WriteLine(largestCommonEnd);
	}

	static int GetCommonEndCount(string[] firstWord, string[] secondWord)
	{
		int minLenght = Math.Min(firstWord.Length, secondWord.Length);
		int counter = 0;

		for (int index = 0; index < minLenght; index++)
		{
			if (firstWord[index] != secondWord[index])
			{
				break;
			}

			counter++;
		}

		return counter;
	}
}