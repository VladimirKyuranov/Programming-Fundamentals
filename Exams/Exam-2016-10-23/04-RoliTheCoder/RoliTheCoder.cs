using System;
using System.Collections.Generic;
using System.Linq;

class RoliTheCoder
{
    static void Main(string[] args)
    {
        string request;

        var events = new Dictionary<int, Event>();

        while ((request = Console.ReadLine()) != "Time for Code")
        {
            if (request.Contains("#") == false)
            {
                continue;
            }

            List<string> tokens = request
                .Split(" #".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int id = int.Parse(tokens[0]);
            string name = tokens[1];
			List<string> participants = tokens.Skip(2).ToList();

            Event currentEvent = new Event(name, participants);

            if (events.ContainsKey(id) == false)
            {
                events.Add(id, currentEvent);
            }
            else if(events[id].Name == name)
            {
                events[id].Participants.AddRange(currentEvent.Participants);
            }

            events[id].Participants = events[id].Participants.Distinct().ToList();
        }

        foreach (Event currentEvent in events.Values.OrderByDescending(e => e.Participants.Count).ThenBy(e => e.Name))
        {
            Console.WriteLine($"{currentEvent.Name} - {currentEvent.Participants.Count}");

            foreach (string participant in currentEvent.Participants.OrderBy(p => p))
            {
                Console.WriteLine(participant);
            }
        }
    }
}

class Event
{
	public Event(string name, List<string> participants)
	{
		this.Name = name;
		this.Participants = participants;
	}

    public string Name { get; set; }

    public List<string> Participants { get; set; }
}