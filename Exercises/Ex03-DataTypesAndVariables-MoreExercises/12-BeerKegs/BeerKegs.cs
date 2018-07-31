using System;

class BeerKegs
{
    static void Main(string[] args)
    {
        int kegsCount = int.Parse(Console.ReadLine());

        string biggestKegType = "";
        double biggestKegVolume = double.MinValue;

        for (int kegNumber = 1; kegNumber <= kegsCount; kegNumber++)
        {
            string kegType = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double volume = Math.PI * Math.Pow(radius, 2) * height;

            if (volume > biggestKegVolume)
            {
                biggestKegVolume = volume;
                biggestKegType = kegType;
            }
        }

        Console.WriteLine($"{biggestKegType}");
    }
}
