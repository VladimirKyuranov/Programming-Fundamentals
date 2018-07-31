using System;

class MaxMethod
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int max = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);

        Console.WriteLine(max);
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }

        return secondNumber;
    }
}
