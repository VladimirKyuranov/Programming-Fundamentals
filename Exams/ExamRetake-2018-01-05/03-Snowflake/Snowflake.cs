using System;
using System.Text.RegularExpressions;

class Snowflake
{
    static void Main(string[] args)
    {
        string firstSurface = Console.ReadLine();
        string firstMantle = Console.ReadLine();
        string snowflake = Console.ReadLine();
        string lastMantle = Console.ReadLine();
        string lastSurface = Console.ReadLine();

        string surfacePattern = @"^[^a-zA-Z\d]+$";
        string mantlePattern = @"^[\d_]+$";
        string snowflakePattern = @"^[^a-zA-Z\d]+[\d_]+(?<core>[a-zA-Z]+)[\d_]+[^a-zA-Z\d]+$";

        bool valid = (Regex.Match(firstSurface, surfacePattern).Success &&
            Regex.Match(lastSurface, surfacePattern).Success &&
            Regex.Match(firstMantle, mantlePattern).Success &&
            Regex.Match(lastMantle, mantlePattern).Success &&
            Regex.Match(snowflake, snowflakePattern).Success);

        if (valid)
        {
            Console.WriteLine("Valid");
            Console.WriteLine(Regex.Match(snowflake, snowflakePattern).Groups["core"].Value.Length);
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}