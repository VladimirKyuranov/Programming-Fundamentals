using System;

class OddNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        while (number % 2 == 0)
        {
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write an odd number.");
        }

        Console.WriteLine($"The number is: {Math.Abs(number)}");
    }
}
