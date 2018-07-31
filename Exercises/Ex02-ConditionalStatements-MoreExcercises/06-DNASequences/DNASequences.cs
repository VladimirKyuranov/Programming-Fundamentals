using System;

class DNASequences
{
    static void Main(string[] args)
    {
        int matchSum = int.Parse(Console.ReadLine());

        int counter = 0;
        char firstLast = 'X';

        for (char symbolOne = 'A'; symbolOne <= 'T'; symbolOne++)
        {
            for (char symbolTwo = 'A'; symbolTwo <= 'T'; symbolTwo++)
            {
                for (char symbolThree = 'A'; symbolThree <= 'T'; symbolThree++)
                {
                    if ((symbolOne == 'A' || symbolOne == 'C' || symbolOne == 'G' || symbolOne == 'T') &&
                        (symbolTwo == 'A' || symbolTwo == 'C' || symbolTwo == 'G' || symbolTwo == 'T') &&
                        (symbolThree == 'A' || symbolThree == 'C' || symbolThree == 'G' || symbolThree == 'T'))
                    {
                        int sum = Value(symbolOne) + Value(symbolTwo) + Value(symbolThree);

                        if (sum >= matchSum)
                        {
                            firstLast = 'O';
                        }
                        else
                        {
                            firstLast = 'X';
                        }

                        counter++;
                        Console.Write($"{firstLast}{symbolOne}{symbolTwo}{symbolThree}{firstLast} ");

                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }

    static int  Value (char a)
    {
        int value = 0;

        switch (a)
        {
            case 'A':
                value = 1;
                break;
            case 'C':
                value = 2;
                break;
            case 'G':
                value = 3;
                break;
            case 'T':
                value = 4;
                break;
        }


        return value;
    }
}
