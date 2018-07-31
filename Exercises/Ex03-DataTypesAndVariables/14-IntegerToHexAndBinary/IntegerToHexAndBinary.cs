using System;

class IntegerToHexAndBinary
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        string numberHex = Convert.ToString(number, 16).ToUpper();
        string numberBin = Convert.ToString(number, 2);

        Console.WriteLine(numberHex);
        Console.WriteLine(numberBin);
    }
}
