using System;
using System.Numerics;

class Snowballs
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        BigInteger bestValue = int.MinValue;
        int bestSnow = 0;
        int bestTime = 0;
        int bestQuality = 0;

        for (int currentSnowball = 0; currentSnowball < count; currentSnowball++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 1;

            for (int i = 0; i < snowballQuality; i++)
            {
                snowballValue *= (snowballSnow / snowballTime);
            }

            if (snowballValue > bestValue)
            {
                bestValue = snowballValue;
                bestSnow = snowballSnow;
                bestTime = snowballTime;
                bestQuality = snowballQuality;
            }
        }

        Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
    }
}