using System;

class HouseBuilder
{
    static void Main(string[] args)
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        long totalPrice = 0;

        try
        {
            int intPrice = int.Parse(firstNumber);
            sbyte sbytePrice = sbyte.Parse(secondNumber);

            totalPrice = (long)intPrice * 10 + (long)sbytePrice * 4;
        }
        catch (Exception)
        {
            int intPrice = int.Parse(secondNumber);
            sbyte sbytePrice = sbyte.Parse(firstNumber);

            totalPrice = (long)intPrice * 10 + (long)sbytePrice * 4;
        }

        Console.WriteLine(totalPrice);
    }
}
