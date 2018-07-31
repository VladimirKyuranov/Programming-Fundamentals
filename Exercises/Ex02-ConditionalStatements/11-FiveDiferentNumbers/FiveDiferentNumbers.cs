using System;

class FiveDiferentNumbers
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int count = 0;

        for (int firstDigit = firstNumber; firstDigit <= secondNumber - 4; firstDigit++)
        {
            for (int secondDigid = firstNumber + 1; secondDigid <= secondNumber - 3; secondDigid++)
            {
                for (int thirthDigit = firstNumber + 2; thirthDigit <= secondNumber - 2; thirthDigit++)
                {
                    for (int fourthDigit = firstNumber + 3; fourthDigit <= secondNumber - 1; fourthDigit++)
                    {
                        for (int fifthDigit = firstNumber + 4; fifthDigit <= secondNumber; fifthDigit++)
                        {
                            if (firstDigit < secondDigid && secondDigid < thirthDigit && thirthDigit < fourthDigit && fourthDigit < fifthDigit)
                            {
                                Console.WriteLine($"{firstDigit} {secondDigid} {thirthDigit} {fourthDigit} {fifthDigit}");
                                count++;
                            }
                        }
                    }
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
