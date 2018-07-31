using System;
using System.Linq;
using System.Text.RegularExpressions;

class WinningTicket
{
    static void Main(string[] args)
    {
        string[] tickets = Console.ReadLine()
            .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";

        foreach (string ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            string firstHalf = ticket.Substring(0, 10);
            string secondHalf = ticket.Substring(10, 10);
            Match first = Regex.Match(firstHalf, pattern);
            Match second = Regex.Match(secondHalf, pattern);

            if (first.Success && second.Success && first.Value[0] == second.Value[0])
            {
                string firstMatch = first.Value;
                string secondMatch = second.Value;

                if (firstMatch.Length == 10 && secondMatch.Length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{firstMatch[0]} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(firstMatch.Length, secondMatch.Length)}{firstMatch[0]}");
                }
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}