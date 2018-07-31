using System;

class HornetWings
{
    static void Main(string[] args)
    {
        int flapsCount = int.Parse(Console.ReadLine());
        double distancePerThousandFlaps = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());

        double distance = distancePerThousandFlaps * flapsCount / 1000;
        int time = flapsCount / 100 + flapsCount / endurance * 5;

        Console.WriteLine($"{distance:F2} m.");
        Console.WriteLine($"{time} s.");
    }
}