using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        const double eps = 0.000001;
        bool areEqual = false;

        if (Math.Abs(firstNumber - secondNumber) < eps)
        {
            areEqual = true;
        }

        Console.WriteLine(areEqual);
    }
}
