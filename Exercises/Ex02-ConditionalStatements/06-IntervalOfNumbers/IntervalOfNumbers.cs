using System;

class IntervalOfNumbers
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int biggerNumber = Math.Max(firstNumber, secondNumber);
        int smallerNumber = Math.Min(firstNumber, secondNumber);

        for (int number = smallerNumber; number <= biggerNumber; number++)
        {
            Console.WriteLine(number);
        }
    }
}
