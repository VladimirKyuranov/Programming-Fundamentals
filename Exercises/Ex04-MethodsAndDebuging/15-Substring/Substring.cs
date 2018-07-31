using System;

public class Substring
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            char temp = text[i];

            if (text[i] == search)
            {
                int endIndex = jump + 1;

                hasMatch = true;

                if (endIndex + i > text.Length - 1)
                {
                    endIndex = text.Length - i;
                }

                string matchedString = text.Substring(i, endIndex);

                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
