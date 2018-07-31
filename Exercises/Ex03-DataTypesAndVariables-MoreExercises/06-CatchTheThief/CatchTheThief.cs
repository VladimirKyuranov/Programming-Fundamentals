using System;

class CatchTheThief
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine().ToLower();
        int count = int.Parse(Console.ReadLine());

        long typeMaxValue = long.MaxValue;
        long thiefId = long.MinValue;

        switch (type)
        {
            case "sbyte":
                typeMaxValue = sbyte.MaxValue;
                thiefId = sbyte.MinValue;
                break;
            case "int":
                typeMaxValue = int.MaxValue;
                thiefId = int.MinValue;
                break;
        }

        for (int i = 0; i < count; i++)
        {
            long number = long.Parse(Console.ReadLine());

            if (number > thiefId && number <= typeMaxValue)
            {
                thiefId = number;
            }
        }

        Console.WriteLine(thiefId);
    }
}
