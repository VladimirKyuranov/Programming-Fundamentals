using System;

class CharityMarathon
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int runners = int.Parse(Console.ReadLine());
        int laps = int.Parse(Console.ReadLine());
        double lapLength = double.Parse(Console.ReadLine()) / 1000;
        int capacity = int.Parse(Console.ReadLine());
        double moneyPerKilometer = double.Parse(Console.ReadLine());
        
        if (runners > capacity * days)
        {
            runners = capacity * days;
        }

        double kilometers = lapLength * runners * laps;
        double money = kilometers * moneyPerKilometer;

        Console.WriteLine($"Money raised: {money:F2}");
    }
}