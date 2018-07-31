using System;

class WaterOverflow
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        const int capacity = 255;
        int waterInTank = 0;

        for (int i = 0; i < count; i++)
        {
            int littersToPour = int.Parse(Console.ReadLine());

            if (waterInTank + littersToPour <= capacity)
            {
                waterInTank += littersToPour;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }

        Console.WriteLine(waterInTank);
    }
}
