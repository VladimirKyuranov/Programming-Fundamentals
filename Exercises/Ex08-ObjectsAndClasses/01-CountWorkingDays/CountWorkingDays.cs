using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class CountWorkingDays
{
    static void Main(string[] args)
	{
		DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
		DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
		List<DateTime> holidays = GetHolidays();
		int workingDays = GetWorkingDays(start, end, holidays);
		Console.WriteLine(workingDays);
	}

	private static List<DateTime> GetHolidays()
	{
		return new List<DateTime>
		{
			DateTime.ParseExact("01-01-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("03-03-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("01-05-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("06-05-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("24-05-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("06-09-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("22-09-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("01-11-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("24-12-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("25-12-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture),
			DateTime.ParseExact("26-12-1985", "dd-MM-yyyy", CultureInfo.InvariantCulture)
		};
	}

	private static int GetWorkingDays(DateTime start, DateTime end, List<DateTime> holidays)
	{
		int workingDays = 0;

		for (DateTime date = start; date <= end; date = date.AddDays(1))
		{
			if (date.DayOfWeek.ToString() != "Saturday" && date.DayOfWeek.ToString() != "Sunday" &&
				holidays.Any(x => x.Day == date.Day && x.Month == date.Month) == false)
			{
				workingDays++;
			}
		}

		return workingDays;
	}
}
