using System;

namespace PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int index = firstIndex; index <= lastIndex; index++)
            {
                Console.Write($"{Convert.ToChar(index)} ");
            }
        }
    }
}
