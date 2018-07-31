using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        Console.WriteLine(ReverseText(text));
    }

    static string ReverseText(string text)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            builder.Append(text[i]);
        }

        return builder.ToString();
    }
}
