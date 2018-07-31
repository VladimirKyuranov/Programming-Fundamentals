using System;
using System.Linq;

class RotateAndSum
{
    static void Main(string[] args)
	{
		string input = Console.ReadLine();
		int count = int.Parse(Console.ReadLine());

		int[] numbers = input
			.Split()
			.Select(int.Parse)
			.ToArray();

		int[] sum = GetSum(count, numbers);
		string output = string.Join(" ", sum);
		Console.WriteLine(output);
	}

	static int[] GetSum(int count, int[] numbers)
	{
		int[] sum = new int[numbers.Length];
		int length = numbers.Length;

		for (int rotation = 0; rotation < count; rotation++)
		{
			int temp = numbers[length - 1];

			for (int index = length - 1; index > 0; index--)
			{
				numbers[index] = numbers[index - 1];
			}

			numbers[0] = temp;

			for (int index = 0; index < length; index++)
			{
				sum[index] += numbers[index];
			}
		}

		return sum;
	}
}