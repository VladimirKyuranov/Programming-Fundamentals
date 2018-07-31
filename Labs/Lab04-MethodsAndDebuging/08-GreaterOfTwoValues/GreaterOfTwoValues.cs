using System;

class GreaterOfTwoValues
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        string max = "";

        switch (type)
        {
            case "int":
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                max = GetMax(firstInt, secondInt).ToString();
                break;
            case "char":
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                max = GetMax(firstChar, secondChar).ToString();
                break;
            case "string":
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                max = GetMax(firstString, secondString);
                break;
        }

        Console.WriteLine(max);
    }

    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }

        return second;
    }

    static char GetMax(char first, char second)
    {
        if (first >= second)
        {
            return first;
        }

        return second;
    }

    static string GetMax(string first, string second)
    {
        if (first.CompareTo(second) >= 0)
        {
            return first;
        }

        return second;
    }
}
