﻿using System;

class VariablesInHexFormat
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int output = Convert.ToInt32(input, 16);

        Console.WriteLine(output);
    }
}
