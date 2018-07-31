using System;
using System.Linq;

class FoldAndSum
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] numbers = input
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] upperArr = FillUpperArray(numbers);
        int[] bottomArr = FillBottomArray(numbers);
        int[] sumArr = SumArrays(upperArr, bottomArr);
        string result = string.Join(" ", sumArr);

        Console.WriteLine(result);
    }

    static int[] FillUpperArray(int[] numbers)
    {
		int length = numbers.Length;
		int quarterLength = length / 4;
        int[] result = new int[length / 2];
        int arrayIndex = 0;

        for (int index = quarterLength - 1; index >= 0; index--)
        {
            result[arrayIndex] = numbers[index];
			arrayIndex++;
        }

        for (int index = length - 1; index >= length - quarterLength; index--)
        {
            result[arrayIndex++] = numbers[index];
        }

        return result;
    }

	static int[] FillBottomArray(int[] numbers)
	{
		int[] result = new int[numbers.Length / 2];

		for (int index = 0; index < result.Length; index++)
		{
			result[index] = numbers[numbers.Length / 4 + index];
		}

		return result;
	}

	static int[] SumArrays(int[] upperArray, int[] bottomArray)
    {
		int length = upperArray.Length;
        int[] sumArr = new int[length];

        for (int index = 0; index < length; index++)
        {
            sumArr[index] = upperArray[index] + bottomArray[index];
        }

        return sumArr;
    }
}