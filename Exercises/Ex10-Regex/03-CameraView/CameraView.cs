using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class CameraView
{
    static void Main(string[] args)
    {
        int[] tokens = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

		int skipCount = tokens[0];
		int takeCount = tokens[1];
        string input = Console.ReadLine();

        List<string> cameras = new List<string>();
        string pattern = $@"\|<(\w{{{skipCount}}})(?<camera>\w{{1,{takeCount}}})";
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match camera in matches)
        {
            cameras.Add(camera.Groups["camera"].Value);
        }

        Console.WriteLine(string.Join(", ", cameras));
    }
}