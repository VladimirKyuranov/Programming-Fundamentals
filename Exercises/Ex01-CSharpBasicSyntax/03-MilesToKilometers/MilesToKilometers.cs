using System;

class MilesToKilometers
{
    static void Main(string[] args)
    {
        const double kmToMilesRatio = 1.60934;
        double miles = double.Parse(Console.ReadLine());

        double km = miles * kmToMilesRatio;
        Console.WriteLine($"{km:F2}");
    }
}