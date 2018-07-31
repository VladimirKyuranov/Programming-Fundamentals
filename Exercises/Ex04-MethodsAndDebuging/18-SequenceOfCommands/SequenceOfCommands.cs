using System;
using System.Linq;

class SequenceOfCommands
{

    public static void Main()
    {
        const char ArgumentsDelimiter = ' ';

        int sizeOfArray = int.Parse(Console.ReadLine());
        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();
        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string action = command.Split(ArgumentsDelimiter)[0];
            int[] args = new int[2];

            switch (action)
            {
                case "add":
                case "subtract":
                case "multiply":
                    args[0] = int.Parse(command.Split(ArgumentsDelimiter)[1]);
                    args[1] = int.Parse(command.Split(ArgumentsDelimiter)[2]);

                    array = PerformAction(array, action, args);
                    break;
                case "rshift":
                    array = ArrayShiftRight(array);
                    break;
                case "lshift":
                    array = ArrayShiftLeft(array);
                    break;
            }

            PrintArray(array);

            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }

        return array;
    }

    static long[] ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];

        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = temp;

        return array;
    }

    static long[] ArrayShiftLeft(long[] array)
    {
        long temp = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = temp;

        return array;
    }

    static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}