using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();


            for (int i = 0; i < n; i++)
            {

                string[] newTeam = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
                string creator = newTeam[0];
                string teamName = newTeam[1];

                Team existingTeam = teams.Find(t => t.TeamName == teamName);

                Team existingCreator = teams.Find(t => t.Creator == creator);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (existingCreator != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");


            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] join = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string member = join[0];
                string teamName = join[1];

                Team existingTeam = teams.Find(t => t.TeamName == teamName);
                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                Team existingMemeber = teams.Find(t => t.Members.Contains(member) || t.Creator == member);
                if (existingMemeber != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                existingTeam.Members.Add(member);

            }

            List<string> allDisbandedTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).Select(a => a.TeamName).ToList();

            teams.RemoveAll(t => t.Members.Count == 0);
            List<Team> sortedTeams = teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();

            foreach (Team item in sortedTeams)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in allDisbandedTeams)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string teamName, string creator)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }

        public override string ToString()
        {
            List<string> sortedMembers = this.Members.OrderBy(a => a).ToList();

            string output = $"{TeamName}\n";
            output += $"- {Creator}\n";

            for (int i = 0; i < sortedMembers.Count; i++)
            {
                output += $"-- {sortedMembers[i]}\n";

            }

            return output.Trim();
        }
    }
}