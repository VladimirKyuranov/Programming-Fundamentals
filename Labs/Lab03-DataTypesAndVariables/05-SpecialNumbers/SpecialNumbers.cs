using System;

class SpecialNumbers
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int number = 1; number <= count; number++)
        {
            bool isSpecial = false;
            int sum = 0;
            int num = number;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum == 5 || sum == 7 || sum == 11)
            {
                isSpecial = true;
            }

            Console.WriteLine($"{number} -> {isSpecial}");
        }
    }
}
