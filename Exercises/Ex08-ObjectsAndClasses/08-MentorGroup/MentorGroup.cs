using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class MentorGroup
{
    static void Main(string[] args)
    {
        var group = new SortedDictionary<string, Student>();

		string input;

        while ((input = Console.ReadLine()) != "end of dates")
        {
            string[] studentArgs = input
                .Split()
                .ToArray();
            string name = studentArgs[0];
            List<DateTime> dates = new List<DateTime>();

            if (studentArgs.Length > 1)
            {
                dates = studentArgs[1]
                    .Split(',')
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();
            }

            if (group.ContainsKey(name) == false)
            {
				Student student = new Student(name);
                group.Add(name, student);
            }

            group[name].AddDates(dates);
        }

        while ((input = Console.ReadLine()) != "end of comments")
        {
            string[] userArgs = input
                .Split('-')
                .ToArray();
            string name = userArgs[0];
            string comment = userArgs[1];

            if (group.ContainsKey(name))
            {
                group[name].AddComment(comment);
            }
        }

        foreach (var student in group)
        {
            Console.WriteLine(student.Key);
            Console.WriteLine("Comments:");

            foreach (var comment in student.Value.Comments)
            {
                Console.WriteLine($"- {comment}");
            }

            Console.WriteLine("Dates attended:");

            foreach (var date in student.Value.DatesAttended.OrderBy(x => x))
            {
                Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
            }
        }
    }
}

class Student
{
	public Student(string name)
	{
		this.Name = name;
		this.DatesAttended = new List<DateTime>();
		this.Comments = new List<string>();
	}

    public string Name { get; }

    public List<DateTime> DatesAttended { get; }

    public List<string> Comments { get;  }

	public void AddDates(List<DateTime> dates)
	{
		DatesAttended.AddRange(dates);
	}
	public void AddComment(string comment)
	{
		Comments.Add(comment);
	}
}