using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class BookLibrary
{
	static void Main(string[] args)
	{
		int booksCount = int.Parse(Console.ReadLine());
		BookFactory bookFactory = new BookFactory();

		Library library = new Library();

		var authors = new Dictionary<string, double>();

		for (int counter = 0; counter < booksCount; counter++)
		{
			string[] bookArgs = Console.ReadLine()
			.Split()
			.ToArray();

			Book book = bookFactory.CreateBook(bookArgs);
			library.AddBook(book);
		}

		foreach (var book in library.Books)
		{
			if (authors.ContainsKey(book.Author) == false)
			{
				authors.Add(book.Author, 0);
			}

			authors[book.Author] += book.Price;
		}

		foreach (var author in authors
			.OrderByDescending(x => x.Value)
			.ThenBy(x => x.Key))
		{
			string result = $"{author.Key} -> {author.Value:F2}";
			Console.WriteLine(result);
		}
	}
}

class Library
{
	public Library()
	{
		this.Name = "Library";
		this.Books = new List<Book>();
	}

	public string Name { get; }

	public List<Book> Books { get; }

	public void AddBook(Book book)
	{
		this.Books.Add(book);
	}
}

class Book
{
	public Book(string title, string author, string publisher, DateTime releaseDate, long ISBN, double price)
	{
		this.Title = title;
		this.Author = author;
		this.Publisher = publisher;
		this.ResealeDate = releaseDate;
		this.ISBN = ISBN;
		this.Price = price;
	}

	public string Title { get; set; }
	public string Author { get; set; }
	public string Publisher { get; set; }
	public DateTime ResealeDate { get; set; }
	public long ISBN { get; set; }
	public double Price { get; set; }
}

class BookFactory
{
	public Book CreateBook(string[] parameters)
	{
		string title = parameters[0];
		string author = parameters[1];
		string publisher = parameters[2];
		DateTime releaseDate = DateTime.ParseExact(parameters[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
		long ISBN = long.Parse(parameters[4]);
		double price = double.Parse(parameters[5]);

		Book book = new Book(title, author, publisher, releaseDate, ISBN, price);
		return book;
	}
}