using System;

class CountTheIntegers
{
    static void Main(string[] args)
    {
        int count = 0;

        try
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                count++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(count);
        }
    }
}
