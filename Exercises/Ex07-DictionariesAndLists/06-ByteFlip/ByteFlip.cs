using System;
using System.Linq;

class ByteFlip
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split()
            .Where(x => x.Length == 2)
            .Reverse()
            .ToArray();

        for (int index = 0; index < input.Length; index++)
        {
            char[] temp = input[index].ToCharArray().Reverse().ToArray();
            string reversed = string.Join("", temp);
            char letter = (char)(Convert.ToUInt32(reversed, 16));
            Console.Write(letter);
        }

        Console.WriteLine();
    }
}
