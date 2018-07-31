using System;
using System.Linq;

class SumArrays
{
    static void Main(string[] args)
    {
        string firstArrayInput = Console.ReadLine();
        string secondArrayInput = Console.ReadLine();

        int[] firstArray = firstArrayInput
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int[] secondArray = secondArrayInput
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int maxLenght = Math.Max(firstArray.Length, secondArray.Length);

        int[] sumArray = new int[maxLenght];

        for (int i = 0; i < maxLenght; i++)
        {
            sumArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
        }

        string output = string.Join(" ", sumArray);

        Console.WriteLine(output);
    }
}