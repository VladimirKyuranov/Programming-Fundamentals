using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {first}");
        Console.WriteLine($"b = {second}");

        int temp = first;
        first = second;
        second = temp;

        Console.WriteLine("After:");
        Console.WriteLine($"a = {first}");
        Console.WriteLine($"b = {second}");
    }
}
