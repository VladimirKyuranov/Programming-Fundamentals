﻿using System;
using System.Linq;

class MagicExchangeableWords
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

        char[] firstText = input[0].ToCharArray().Distinct().ToArray();
        char[] secondText = input[1].ToCharArray().Distinct().ToArray();

        if (firstText.Length == secondText.Length)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}