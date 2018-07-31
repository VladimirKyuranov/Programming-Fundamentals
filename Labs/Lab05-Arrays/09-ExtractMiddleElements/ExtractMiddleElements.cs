using System;
using System.Linq;

class ExtractMiddleElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] arr = input
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        string output = GetArrayMiddles(arr);

        Console.WriteLine(output);
    }

    static string GetArrayMiddles(int[] arr)
    {
        string result = "";

        if (arr.Length == 1)
        {
            result = $"{{ {arr[0]} }}";
        }
        else if (arr.Length % 2 == 0)
        {
            result = $"{{ {arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]} }}";
        }
        else
        {
            result = $"{{ {arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]} }}";
        }

        return result;
    }
}