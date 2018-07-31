using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class BookLibraryModification
{
    static void Main(string[] args)
    {
        int booksCount = int.Parse(Console.ReadLine());
		BookFactory bookFactory = new BookFactory();
		Library library = new Library();

		for (int counter = 0; counter < booksCount; counter++)
		{
			string[] bookArgs = Console.ReadLine()
				.Split()
				.ToArray();

			Book book = bookFactory.CreateBook(bookArgs);
			library.Books.Add(book);
		}

		DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        foreach (var book in library.Books
            .Where(x => x.ResealeDate > date)
            .OrderBy(x => x.ResealeDate)
            .ThenBy(x => x.Title))
        {
			string result = $"{book.Title} -> {book.ResealeDate.ToString("dd.MM.yyyy")}";
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