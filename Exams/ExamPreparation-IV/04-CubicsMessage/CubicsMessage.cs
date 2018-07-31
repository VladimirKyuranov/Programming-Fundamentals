using System;
using System.Text;
using System.Text.RegularExpressions;

class CubicsMessage
{
    static void Main(string[] args)
    {
        while (true)
        {
            string text = Console.ReadLine();

            if (text == "Over!")
            {
                break;
            }

            int length = int.Parse(Console.ReadLine());

            string pattern = @"^(\d+)([a-zA-Z]{" + length + @"})([^a-zA-Z]*)$";
            Match messageMatch = Regex.Match(text, pattern);

            if (messageMatch.Success == false)
            {
                continue;
            }

            string message = messageMatch.Groups[2].Value;
            StringBuilder builder = new StringBuilder();
            builder.Append(message);
            builder.Append(" == ");

            foreach (char symbol in messageMatch.Groups[1].Value)
            {
                int digit = int.Parse(symbol.ToString());
                if (0 <= digit && digit < message.Length)
                {
                    builder.Append(message[digit]);
                }
                else
                {
                    builder.Append(" ");
                }
            }

            foreach (char symbol in messageMatch.Groups[3].Value)
            {
                if (char.IsDigit(symbol) == false)
                {
                    continue;
                }

                int digit = int.Parse(symbol.ToString());
                if (0 <= digit && digit < message.Length)
                {
                    builder.Append(message[digit]);
                }
                else
                {
                    builder.Append(" ");
                }
            }

            Console.WriteLine(builder);
        }
    }
}