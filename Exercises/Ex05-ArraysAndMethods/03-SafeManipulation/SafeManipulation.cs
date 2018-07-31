using System;
using System.Linq;

class SafeManipulation
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string currentCommand = Console.ReadLine();

        string[] array = input
            .Split(' ')
            .ToArray();
        int index = 0;
        string replacement = "";

        while (currentCommand != "END")
        {
            if (currentCommand.Contains(" "))
            {
                string[] commandArray = currentCommand
                    .Split(' ')
                    .ToArray();

                try
                {
                    currentCommand = commandArray[0];
                    index = int.Parse(commandArray[1]);
                    replacement = commandArray[2];
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            switch (currentCommand)
            {
                case "Reverse":
                    array = Reverse(array);
                    break;
                case "Distinct":
                    array = Distinct(array);
                    break;
                case "Replace":
                    array = Replace(index, replacement, array);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            currentCommand = Console.ReadLine();
        }

        string output = string.Join(", ", array);

        Console.WriteLine(output);
    }

    private static string[] Replace(int index, string replacement, string[] array)
    {
        try
        {
            array[index] = replacement;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }

        return array;
    }

    private static string[] Reverse(string[] array)
    {
        Array.Reverse(array);
        return array;
    }

    private static string[] Distinct(string[] array)
    {
        int newLength = 0;

        for (int index = 0; index < array.Length - 1; index++)
        {
            for (int next = index + 1; next < array.Length; next++)
            {
                if (array[index] == array[next])
                {
                    array[next] = "";
                }
            }
        }

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] != "")
            {
                newLength++;
            }
        }

        string[] newArray = new string[newLength];
        int position = 0;


        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] != "")
            {
                newArray[position] = array[index];
                position++;
            }
        }

        return newArray;
    }
}