using System;

class StringConcatenation
{
    static void Main(string[] args)
    {
        char delimiter = char.Parse(Console.ReadLine());
        string row = Console.ReadLine().ToLower();
        int stringCount = int.Parse(Console.ReadLine());

        string result = "";

        for (int i = 1; i <= stringCount; i++)
        {
            string word = Console.ReadLine();

            if (row == "odd" && i % 2 != 0)
            {
                result += word + delimiter;
            }
            else if (row == "even" && i % 2 == 0)
            {
                result += word + delimiter;
            }
        }

        result = result.Remove(result.Length - 1);
        Console.WriteLine(result);
    }
}
