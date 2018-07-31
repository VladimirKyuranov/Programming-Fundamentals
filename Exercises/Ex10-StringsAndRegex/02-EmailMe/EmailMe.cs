using System;
using System.Linq;

class EmailMe
{
    static void Main(string[] args)
    {
        string email = Console.ReadLine();

        string[] emailParts = email
            .Split('@')
            .ToArray();

        int sum = emailParts[0].ToCharArray().Sum(x => (int)x) - emailParts[1].ToCharArray().Sum(x => (int)x);

        if (sum >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}