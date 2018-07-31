using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class HornetComm
{
    static void Main(string[] args)
    {
        string[] delimiter = new[] { " <-> " };
        string input = string.Empty;
        List<PrivateMessage> messages = new List<PrivateMessage>();
        List<Broadcast> broadcasts = new List<Broadcast>();
        string digitsPattern = @"^[\d]+$";
        string nonDigitsPattern = @"^[\D]+$";
        string digitsLettersPattern = @"^[\da-zA-Z]+$";

        while ((input = Console.ReadLine()) != "Hornet is Green")
        {
            string[] data = input
                .Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (data.Length != 2)
            {
                continue;
            }

            string firstPart = data[0];
            string secondPart = data[1];

            bool firstPartDigits = Regex.Match(firstPart, digitsPattern).Success;
            bool firstPartNotDigits = Regex.Match(firstPart, nonDigitsPattern).Success;
            bool secondPartDigitsLetters = Regex.Match(secondPart, digitsLettersPattern).Success;

            if (secondPartDigitsLetters == false)
            {
                continue;
            }

            if (firstPartDigits)
            {
                StringBuilder builder = new StringBuilder();

                for (int index = firstPart.Length - 1; index >= 0; index--)
                {
                    builder.Append(firstPart[index]);
                }

                firstPart = builder.ToString();

                PrivateMessage message = new PrivateMessage
                {
                    Message = secondPart,
                    Code = firstPart
                };

                messages.Add(message);
            }
            else if (firstPartNotDigits)
            {
                StringBuilder builder = new StringBuilder();

                for (int index = 0; index < secondPart.Length; index++)
                {
                    if (char.IsUpper(secondPart[index]))
                    {
                        builder.Append(secondPart[index].ToString().ToLower());
                    }
                    else if (char.IsLower(secondPart[index]))
                    {
                        builder.Append(secondPart[index].ToString().ToUpper());
                    }
                    else
                    {
                        builder.Append(secondPart[index]);
                    }
                }

                secondPart = builder.ToString();

                Broadcast broadcast = new Broadcast
                {
                    Message = firstPart,
                    Frequency = secondPart
                };

                broadcasts.Add(broadcast);
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine("Broadcasts:");

        if (broadcasts.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (Broadcast broadcast in broadcasts)
            {
                Console.WriteLine($"{broadcast.Frequency} -> {broadcast.Message}");
            }
        }

        Console.WriteLine("Messages:");

        if (messages.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (PrivateMessage message in messages)
            {
                Console.WriteLine($"{message.Code} -> {message.Message}");
            }
        }
    }
}

class PrivateMessage
{
    public string Code { get; set; }
    public string Message { get; set; }
}

class Broadcast
{
    public string Message { get; set; }
    public string Frequency { get; set; }
}