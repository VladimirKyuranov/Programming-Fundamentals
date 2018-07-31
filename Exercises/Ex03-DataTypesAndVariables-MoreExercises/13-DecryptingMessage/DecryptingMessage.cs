using System;

class DecryptingMessage
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        string message = "";

        for (int i = 0; i < lines; i++)
        {
            char symbol = char.Parse(Console.ReadLine());

            symbol += (char)key;
            message += symbol;           
        }

        Console.WriteLine(message);
    }
}
