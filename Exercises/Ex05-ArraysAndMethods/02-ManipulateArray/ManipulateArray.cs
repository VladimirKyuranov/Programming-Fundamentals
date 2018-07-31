using System;
using System.Linq;

class ManipulateArray
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int commandsCount = int.Parse(Console.ReadLine());

        string[] array = input
            .Split(' ')
            .ToArray();

        for (int command = 0; command < commandsCount; command++)
        {
            string currentCommand = Console.ReadLine();

            if (currentCommand.Contains(" "))
            {
                string[] commandArray = currentCommand
                    .Split(' ')
                    .ToArray();
                int index = int.Parse(commandArray[1]);
                string replacement = commandArray[2];

                array = Replace(index, replacement, array);
            }
            else
            {
                switch (currentCommand)
                {
                    case "Reverse":
                        array = Reverse(array);
                        break;
                    case "Distinct":
                        array = Distinct(array);
                        break;

                }
            }
        }

        string output = string.Join(", ", array);

        Console.WriteLine(output);        
    }

    private static string[] Replace(int index, string replacement, string[] array)
    {
        array[index] = replacement;
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