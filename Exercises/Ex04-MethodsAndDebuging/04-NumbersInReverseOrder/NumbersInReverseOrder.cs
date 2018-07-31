using System;

class NumbersInReverseOrder
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());

        double reversed = ReverseWholeNumber(number);

        Console.WriteLine(reversed);
    }

    static double ReverseWholeNumber(double number)
    {
        double reversedNumber = ReverseFloatPart(number) + ReverseIntPart(number);

        return reversedNumber;
    }

    static double ReverseIntPart(double number)
    {
        int intNumber = Convert.ToInt32(number);

        double reversedNumber = ReverseLogic(intNumber);

        if (number % 1 != 0)
        {
            reversedNumber /= Math.Pow(10, reversedNumber.ToString().Length);
        }

        return reversedNumber;
    }

    static double ReverseFloatPart(double number)
    {
        double floatNumber = number % 1;
        int intNumber = Convert.ToInt32(floatNumber * Math.Pow(10, floatNumber.ToString().Length - 2));
        return ReverseLogic(intNumber);
    }

    private static double ReverseLogic(int intNumber)
    {
        double reversedNumber = 0;

        while (intNumber > 0)
        {
            reversedNumber *= 10;
            reversedNumber += intNumber % 10;
            intNumber /= 10;
        }

        return reversedNumber;
    }
}
