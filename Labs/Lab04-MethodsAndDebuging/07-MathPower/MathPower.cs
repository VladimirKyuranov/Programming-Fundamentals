using System;

class MathPower
{
    static void Main(string[] args)
    {
        double numberToPower = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        double poweredNumber = PowerNumber(numberToPower, power);

        Console.WriteLine(poweredNumber);
    }

    static double PowerNumber(double numberToPower, double power)
    {
        double poweredNumber = numberToPower;

        for (double i = 1; i < power; i++)
        {
            poweredNumber *= numberToPower;
        }

        return poweredNumber;
    }
}
