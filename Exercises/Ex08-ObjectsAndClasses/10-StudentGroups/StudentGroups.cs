using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class StudentGroups
{
    static void Main(string[] args)
    {
        var towns = new Dictionary<string, int>();
        List<Student> allStudents = new List<Student>();
        List<Group> allGroups = new List<Group>();
        string town = string.Empty;

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] studentArgs = input
                .Split(" >|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int seats = 0;
            string studentName = "";
            string studentEmail = "";
            DateTime date = new DateTime();

            if (studentArgs.Contains("="))
            {
                if (studentArgs[1] == "=")
                {
                    seats = int.Parse(studentArgs[2]);
                    town = studentArgs[0];
                }
                else
                {
                    seats = int.Parse(studentArgs[3]);
                    town = studentArgs[0] + " " + studentArgs[1];
                }

                if (towns.ContainsKey(town) == false)
                {
                    towns.Add(town, seats);
                    continue;
                }
            }
            else
            {
                studentName = $"{studentArgs[0]} {studentArgs[1]}";
                studentEmail = studentArgs[2];
                date = DateTime.ParseExact(studentArgs[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                Student student = new Student(studentName, studentEmail, date, town);

                allStudents.Add(student);
            }
        }

        foreach (var city in towns.OrderBy(x => x.Key))
        {
            List<Student> studentsInTown = allStudents
                .Where(x => x.Town == city.Key)
                .OrderBy(x => x.Date)
                .ThenBy(x => x.Name)
                .ThenBy(x => x.Email)
                .ToList();
            int remainingStudents = studentsInTown.Count;
            int addedStudents = 0;
			Group group = new Group(city.Key);

            foreach (var student in studentsInTown)
            {
                if (addedStudents < city.Value)
                {
                    group.Students.Add(student);
                    addedStudents++;
                }
                else
                {
                    allGroups.Add(group);
					group = new Group(city.Key);
                    group.Students.Add(student);
                    addedStudents = 1;
                }
            }

            if (group.Students.Count > 0)
            {
                allGroups.Add(group);
            }
        }

        Console.WriteLine($"Created {allGroups.Count} groups in {towns.Count} towns:");

        foreach (var group in allGroups)
        {
            string output = $"{group.Town} => ";

            foreach (var student in group.Students)
            {
                output += student.Email + ", ";
            }

            output = output.Remove(output.Length - 2);

            Console.WriteLine(output);
        }
    }
}

class Student
{
	public Student(string name, string email, DateTime date, string town)
	{
		this.Name = name;
		this.Email = email;
		this.Date = date;
		this.Town = town;
	}

    public string Name { get; }
    public string Email { get; }
    public DateTime Date { get; }
    public string Town { get; }
}

class Group
{
	public Group(string town)
	{
		this.Town = town;
		this.Students = new List<Student>();
	}
    public string Town { get; }
    public List<Student> Students { get; }

	public void AddStudent(Student student)
	{
		this.Students.Add(student);
	}
}