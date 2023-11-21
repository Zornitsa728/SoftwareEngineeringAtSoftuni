using FootballTeamGenerator.Models;
using System.Numerics;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] tokens = input
                .Split(";");
                    string cmd = tokens[0];

                    switch (cmd)
                    {
                        case "Team":
                            Team team = new Team(tokens[1]);
                            teams.Add(team);
                            break;
                        case "Add":

                            if (!teams.Any(t => t.TeamName == tokens[1]))
                            {
                                Console.WriteLine($"Team {tokens[1]} does not exist.");
                                continue;
                            }

                            Player playerToAdd = new Player
                                (tokens[2],
                                int.Parse(tokens[3]),
                                int.Parse(tokens[4]),
                                int.Parse(tokens[5]),
                                int.Parse(tokens[6]),
                                int.Parse(tokens[7]));

                            Team currTeam = teams.FirstOrDefault(t => t.TeamName == tokens[1]);

                            currTeam.AddPlayer(playerToAdd);

                            break;
                        case "Remove":
                            Team teamToRemoveFrom = teams.FirstOrDefault(t => t.TeamName == tokens[1]);


                            teamToRemoveFrom.RemovePlayer(tokens[1], tokens[2]);

                            break;
                        case "Rating":
                            if (!teams.Any(t => t.TeamName == tokens[1]))
                            {
                                Console.WriteLine($"Team {tokens[1]} does not exist.");
                                continue;
                            }

                            Team teamForRating = teams.FirstOrDefault(t => t.TeamName == tokens[1]);

                            Console.WriteLine($"{teamForRating.TeamName} - {Math.Round(teamForRating.Rating)}");
                            break;


                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }




        }
    }
}