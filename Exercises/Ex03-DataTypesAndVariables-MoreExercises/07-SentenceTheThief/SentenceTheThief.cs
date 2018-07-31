using System;

class SentenceTheThief
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine().ToLower();
        int count = int.Parse(Console.ReadLine());

        long typeMaxValue = long.MaxValue;
        long thiefId = long.MinValue;
        double sentence = 0;

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

        if (thiefId > 0)
        {
            sentence = Math.Ceiling(1.0 * thiefId / 127);
        }
        else if (thiefId < 0)
        {
            sentence = Math.Ceiling(1.0 * thiefId / -128);
        }
        if (sentence > 1)
        {
            Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {sentence} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {sentence} year");
        }
    }
}
