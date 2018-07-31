using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SoftUniCoursePlanning
{
    static void Main(string[] args)
    {
        List<string> lessons = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input;

        while ((input = Console.ReadLine()) != "course start")
        {
            string[] commandArgs = input
                .Split(':');

            string command = commandArgs[0];
            string lessonTitle = commandArgs[1];

            switch (command)
            {
                case "Add":
                    Add(lessons, lessonTitle);
                    break;
                case "Insert":
                    int index = int.Parse(commandArgs[2]);
                    Insert(lessons, lessonTitle, index);
                    break;
                case "Remove":
                    Remove(lessons, lessonTitle);
                    break;
                case "Swap":
                    string secondLessonTitle = commandArgs[2];
                    Swap(lessons, lessonTitle, secondLessonTitle);
                    break;
                case "Exercise":
                    AddExercise(lessons, lessonTitle);
                    break;
            }
        }

        string output = Print(lessons);
        Console.WriteLine(output);
    }

    private static string Print(List<string> lessons)
    {
        StringBuilder builder = new StringBuilder();

        for (int index = 0; index < lessons.Count; index++)
        {
            builder.AppendLine($"{index + 1}.{lessons[index]}");
        }

        string result = builder.ToString().TrimEnd();

        return result;
    }

    private static void Add(List<string> lessons, string lessonTitle)
    {
        if (lessons.Contains(lessonTitle) == false)
        {
            lessons.Add(lessonTitle);
        }
    }

    private static void Insert(List<string> lessons, string lessonTitle, int index)
    {
        if (lessons.Contains(lessonTitle) == false && index >= 0 && index <= lessons.Count)
        {
            lessons.Insert(index, lessonTitle);
        }
    }

    private static void Remove(List<string> lessons, string lessonTitle)
    {
        string exercise = $"{lessonTitle}-Exercise";

        if (lessons.Contains(lessonTitle))
        {
            lessons.Remove(lessonTitle);
        }

        if (lessons.Contains(exercise))
        {
            lessons.Remove(exercise);
        }
    }

    private static void Swap(List<string> lessons, string lessonTitle, string secondLessonTitle)
    {
        string exerciseOne = $"{lessonTitle}-Exercise";
        string exerciseTwo = $"{secondLessonTitle}-Exercise";

        if (lessons.Contains(lessonTitle) == false || lessons.Contains(secondLessonTitle) == false)
        {
            return;
        }

        int firstIndex = lessons.IndexOf(lessonTitle);
        int secondIndex = lessons.IndexOf(secondLessonTitle);

        lessons[firstIndex] = secondLessonTitle;
        lessons[secondIndex] = lessonTitle;


        if (lessons.Contains(exerciseOne) && lessons.Contains(exerciseTwo) == false)
        {
            lessons.Remove(exerciseOne);
            int index = lessons.IndexOf(lessonTitle) + 1;
            lessons.Insert(index, exerciseOne);
        }

        if (lessons.Contains(exerciseOne) == false && lessons.Contains(exerciseTwo))
        {
            lessons.Remove(exerciseTwo);
            int index = lessons.IndexOf(secondLessonTitle) + 1;
            lessons.Insert(index, exerciseTwo);
        }

        if (lessons.Contains(exerciseOne) && lessons.Contains(exerciseTwo))
        {
            int exOneIndex = lessons.IndexOf(exerciseOne);
            int exTwoIndex = lessons.IndexOf(exerciseTwo);
            lessons[exOneIndex] = exerciseTwo;
            lessons[exTwoIndex] = exerciseOne;
        }
    }

    private static void AddExercise(List<string> lessons, string lessonTitle)
    {
        string exercise = $"{lessonTitle}-Exercise";

        if (lessons.Contains(lessonTitle) == false)
        {
            lessons.Add(lessonTitle);
            lessons.Add(exercise);
        }
        else if (lessons.Contains(exercise) == false)
        {
            int index = lessons.IndexOf(lessonTitle) + 1;
            lessons.Insert(index, exercise);
        }
    }
}