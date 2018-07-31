using System;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            string pattern1 = @"<a\s?href";
            string pattern2 = "\">";
            string pattern3 = @"</a>";

            input = Regex.Replace(input, pattern1, "[URL href");
            input = Regex.Replace(input, pattern2, "\"]");
            input = Regex.Replace(input, pattern3, "[/URL]");

            Console.WriteLine(input);

            input = Console.ReadLine();
        }
    }
}