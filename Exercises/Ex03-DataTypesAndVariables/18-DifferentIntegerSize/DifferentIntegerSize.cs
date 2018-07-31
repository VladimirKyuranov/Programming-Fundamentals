using System;

class DifferentIntegerSize
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();

        bool canFit = false;
        string output = $"{number} can fit in:";

        try
        {
            sbyte num = sbyte.Parse(number);
            output += "\r\n* sbyte";
            canFit = true;
        }
        catch (Exception) { }

        try
        {
            byte num = byte.Parse(number);
            output += "\r\n* byte";
            canFit = true;
        }
        catch (Exception) { }

        try
        {
            short num = short.Parse(number);
            output += "\r\n* short";
            canFit = true;
        }
        catch (Exception) { }

        try
        {
            ushort num = ushort.Parse(number);
            output += "\r\n* ushort";
            canFit = true;
        }
        catch (Exception) { }

        try
        {
            int num = int.Parse(number);
            output += "\r\n* int";
            canFit = true;
        }
        catch (Exception) { }

        try
        {
            uint num = uint.Parse(number);
            output += "\r\n* uint";
            canFit = true;
        }
        catch (Exception) { }

        try
        {
            long num = long.Parse(number);
            output += "\r\n* long";
            canFit = true;
        }
        catch (Exception) { }


        if (canFit)
        {
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine($"{number} can't fit in any type");
        }
    }
}
