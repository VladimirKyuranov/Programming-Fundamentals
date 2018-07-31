using System;

class ReverseArrayOfIntegers
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        int[] integerArray = new int[count];

        for (int index = integerArray.Length - 1; index >= 0; index--)
        {
            integerArray[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join(" ", integerArray));
    }
}