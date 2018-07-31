using System;
using System.Collections.Generic;
using System.Linq;

class TeamworkProjects
{
    static void Main(string[] args)
    {
        int creatorsCount = int.Parse(Console.ReadLine());

        var teams = new Dictionary<string, Team>();

        for (int counter = 0; counter < creatorsCount; counter++)
        {
            string[] creatorArgs = Console.ReadLine()
                .Split('-')
                .ToArray();
            string creatorName = creatorArgs[0];
            string teamName = creatorArgs[1];

			Team team = new Team(teamName, creatorName);

            if (teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (teams.Any(x => x.Value.Creator == creatorName))
            {
                Console.WriteLine($"{creatorName} cannot create another team!");
            }
            else
            {
                teams.Add(teamName, team);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
        }

        string input;

        while ((input = Console.ReadLine()) != "end of assignment")
        {
            string[] memberArgs = input
                .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string memberName = memberArgs[0];
            string teamName = memberArgs[1];

            if (teams.ContainsKey(teamName) == false)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (teams.Any(x => x.Value.Creator == memberName ||
                     x.Value.Members.Contains(memberName)))
            {
                Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
            }
            else
            {
                teams[teamName].AddMember(memberName);
            }
        }

        List<Team> validTeams = teams.Values.Where(x => x.Members.Count > 0).ToList();
        List<Team> teamsToDisband = teams.Values.Where(x => x.Members.Count == 0).ToList();

        foreach (var team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");

            foreach (var member in team.Members.OrderBy(x => x))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        Console.WriteLine("Teams to disband:");

        foreach (var team in teamsToDisband.OrderBy(x => x.Name))
        {
            Console.WriteLine(team.Name);
        }
    }
}

class Team
{
	public Team(string name, string creator)
	{
		this.Name = name;
		this.Creator = creator;
		this.Members = new List<string>();
	}

    public string Name { get; }
    public string Creator { get; }
    public List<string> Members { get; }

	public void AddMember(string memberName)
	{
		Members.Add(memberName);
	}
}