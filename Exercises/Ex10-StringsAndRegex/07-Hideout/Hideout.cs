using System;
using System.Linq;
using System.Text.RegularExpressions;

class Hideout
{
    static void Main(string[] args)
    {
        string map = Console.ReadLine();

        while (true)
        {
            string[] clues = Console.ReadLine()
                .Split()
                .ToArray();

            string hideout = new string(char.Parse(clues[0]), int.Parse(clues[1]));

            Match found = Regex.Match(map, Regex.Escape(hideout));

            if (found.Success)
            {
                int index = map.IndexOf(hideout);
                int length = 1;

                for (int i = index; i < map.Length - 1; i++)
                {
                    if (map[i] == map[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
                Environment.Exit(0);
            }
        }
    }
}
