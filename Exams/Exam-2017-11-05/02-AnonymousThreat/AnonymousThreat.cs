using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AnonymousThreat
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine()
            .Split()
            .ToList();

        string line;

        while ((line = Console.ReadLine()) != "3:1")
        {
            string[] commands = line
                .Split()
                .ToArray();
            string command = commands[0];
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            int partitions = endIndex;

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
            }

            switch (command)
            {
                case "merge":
                    List<string> mergeTemp = new List<string>();
                    StringBuilder mergeBuilder = new StringBuilder();

                    for (int index = 0; index < input.Count; index++)
                    {
                        if (startIndex <= index && index <= endIndex)
                        {
                            mergeBuilder.Append(input[index]);

                            if (index == endIndex)
                            {
                                mergeTemp.Add(mergeBuilder.ToString());
                            }
                        }
                        else
                        {
                            mergeTemp.Add(input[index]);
                        }
                    }

                    input = mergeTemp;
                    break;
                case "divide":
                    List<string> divideTemp = new List<string>();

                    for (int index = 0; index < input.Count; index++)
                    {
                        if (index == startIndex)
                        {
                            string current = input[index];

                            if (current.Length % partitions == 0)
                            {
                                while (current.Length > 0)
                                {
                                    StringBuilder divideBuilder = new StringBuilder();
                                    for (int i = 0; i < input[index].Length / partitions; i++)
                                    {
                                        divideBuilder.Append(current[i]);
                                    }

                                    divideTemp.Add(divideBuilder.ToString());
                                    current = current.Remove(0, input[index].Length / partitions);
                                }
                            }
                            else
                            {
                                while (current.Length > 2 * input[index].Length / partitions)
                                {
                                    StringBuilder divideBuilder = new StringBuilder();
                                    for (int i = 0; i < input[index].Length / partitions; i++)
                                    {
                                        divideBuilder.Append(current[i]);
                                    }

                                    divideTemp.Add(divideBuilder.ToString());
                                    current = current.Remove(0, input[index].Length / partitions);
                                }

                                divideTemp.Add(current);
                            }
                        }
                        else
                        {
                            divideTemp.Add(input[index]);
                        }
                    }

                    input = divideTemp;
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", input));
    }
}