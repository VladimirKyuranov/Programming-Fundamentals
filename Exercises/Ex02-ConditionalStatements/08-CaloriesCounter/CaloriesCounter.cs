using System;

class CaloriesCounter
{
    static void Main(string[] args)
    {
        int ingreadientsCount = int.Parse(Console.ReadLine());

        int calories = 0;

        for (int counter = 0; counter < ingreadientsCount; counter++)
        {
            string ingreadient = Console.ReadLine().ToLower();

            switch (ingreadient)
            {
                case "cheese":
                    calories += 500;
                    break;
                case "tomato sauce":
                    calories += 150;
                    break;
                case "salami":
                    calories += 600;
                    break;
                case "pepper":
                    calories += 50;
                    break;
            }
        }

        Console.WriteLine($"Total calories: {calories}");
    }
}
