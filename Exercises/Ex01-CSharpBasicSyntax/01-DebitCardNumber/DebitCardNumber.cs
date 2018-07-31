using System;

class DebitCardNumber
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());

        string result = $"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}";
        Console.WriteLine(result);
    }
}