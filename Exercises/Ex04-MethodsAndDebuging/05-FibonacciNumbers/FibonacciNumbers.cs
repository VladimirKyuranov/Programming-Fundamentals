using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int fibonacci = Fibonacci(number);

        Console.WriteLine(fibonacci);
    }

    static int Fibonacci(int number)
    {
        int firstNumber = 1;
        int secondNumber = 1;
        int fibonacciNumber = 1;

        for (int i = 0; i < number - 1; i++)
        {
            fibonacciNumber = firstNumber + secondNumber;
            secondNumber = firstNumber;
            firstNumber = fibonacciNumber;
        }

        return fibonacciNumber;
    }
}
