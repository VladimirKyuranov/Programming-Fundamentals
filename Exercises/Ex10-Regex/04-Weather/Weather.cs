using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Weather
{
    static void Main(string[] args)
    {
        string pattern = @"(?<town>[A-Z]{2})(?<degrees>\d+.\d+)(?<weather>[a-zA-z]+)(?=\|)";
        List<Match> matches = new List<Match>();
        Dictionary<string, List<string>> forecasts = new Dictionary<string, List<string>>();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            if (Regex.IsMatch(input, pattern))
            {
                matches.Add(Regex.Match(input, pattern));
            }
        }

        foreach (Match forecast in matches)
        {
            string town = forecast.Groups["town"].Value;
            string degrees = forecast.Groups["degrees"].Value;
            string weather = forecast.Groups["weather"].Value;

            if (forecasts.ContainsKey(town) == false)
            {
                forecasts.Add(town, new List<string> {degrees, weather });
            }
            else
            {
                forecasts[town][0] = degrees;
                forecasts[town][1] = weather;
            }
        }

        foreach (var forecast in forecasts.OrderBy(x => double.Parse(x.Value[0])))
        {
			string result = $"{forecast.Key} => {double.Parse(forecast.Value[0]):F2} => {forecast.Value[1]}";
			Console.WriteLine(result);
        }
    }
}