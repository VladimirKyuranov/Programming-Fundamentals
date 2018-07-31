using System;

class ConvertSpeedUnits
{
    static void Main(string[] args)
    {
        float distanceInMeters = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());
        

        float metersPerSecond = (float)Math.Round(distanceInMeters / (hours * 3600 + minutes * 60 + seconds), 6);
        float kmPerHour = (float)Math.Round(distanceInMeters / 1000 / (hours + minutes / 60 + seconds / 3600), 6);
        float mpPerHour = (float)Math.Round(distanceInMeters / 1609 / (hours + minutes / 60 + seconds / 3600), 6);

        Console.WriteLine(metersPerSecond);
        Console.WriteLine(kmPerHour);
        Console.WriteLine(mpPerHour);
    }
}