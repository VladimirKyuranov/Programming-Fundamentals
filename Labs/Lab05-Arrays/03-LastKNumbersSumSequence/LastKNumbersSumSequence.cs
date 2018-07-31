using System;

class LastKNumbersSumSequence
{
    static void Main(string[] args)
    {
        int elements = int.Parse(Console.ReadLine());
        int elementsToSum = int.Parse(Console.ReadLine());

        long[] arr = new long[elements];

        arr[0] = 1;

        for (long index = 1; index < arr.Length; index++)
        {
            long sum = 0;

            for (long currentElement = 0; currentElement < elementsToSum; currentElement++)
            {
                if (currentElement < index)
                {
                    sum += arr[index - currentElement - 1];
                }
            }

            arr[index] = sum;
        }

        Console.WriteLine(string.Join(" ", arr));
    }
}