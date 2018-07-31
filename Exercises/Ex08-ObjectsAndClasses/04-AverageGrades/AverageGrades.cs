using System;
using System.Collections.Generic;
using System.Linq;

class AverageGrades
{
	static void Main(string[] args)
	{
		int studentsCount = int.Parse(Console.ReadLine());
		StudentFactory studentFactory = new StudentFactory();

		List<Student> students = new List<Student>();

		for (int counter = 0; counter < studentsCount; counter++)
		{
			string[] studentArgs = Console.ReadLine()
				.Split()
				.ToArray();

			Student student = studentFactory.CreateStudent(studentArgs);
			students.Add(student);
		}

		foreach (var student in students
			.Where(x => x.Average >= 5)
			.OrderBy(x => x.Name)
			.ThenByDescending(x => x.Average))
		{
			Console.WriteLine(student);
		}
	}
}

class Student
{
	public Student(string name, double[] grades)
	{
		this.Name = name;
		this.Grades = grades;
	}

	public string Name { get; }

	public double[] Grades { get; }

	public double Average => Grades.Average();

	public override string ToString()
	{
		return $"{this.Name} -> {this.Average:F2}";
	}
}

class StudentFactory
{
	public Student CreateStudent(string[] parameters)
	{
		string name = parameters[0];
		double[] grades = parameters
			.Skip(1)
			.Select(double.Parse)
			.ToArray();

		Student student = new Student(name, grades);

		return student;
	}
}