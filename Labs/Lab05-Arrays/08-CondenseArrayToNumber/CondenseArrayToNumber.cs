using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] arrayToCondense = input
            .Split(' ')
            .Select(int.Parse)
            .ToArray();


        while (arrayToCondense.Length > 1)
        {
            int[] condensedArray = new int[arrayToCondense.Length - 1];

            for (int i = 0; i < condensedArray.Length; i++)
            {
                condensedArray[i] = arrayToCondense[i] + arrayToCondense[i + 1];
            }

            arrayToCondense = condensedArray;
        }

        Console.WriteLine(arrayToCondense[0]);
    }
}