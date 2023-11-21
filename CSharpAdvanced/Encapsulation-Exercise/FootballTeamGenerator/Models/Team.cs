using System.Numerics;
using System.Xml.Linq;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private string teamName;

        private List<Player> players;

        public Team(string teamName)
        {
            TeamName = teamName;
            players = new List<Player>();
        }

        public string TeamName 
        {
            get {  return teamName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                teamName = value;
            }
        }

        public double Rating
        {
            get
            {
                if (!players.Any())
                {
                    return 0;
                }

                double averageRating = 0;

                foreach (var player in players)
                {
                    averageRating += player.SkillLevel;
                }

                return averageRating / players.Count;
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string team, string playerName)
        {
            if (!players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {team} team.");
            }

            players.Remove(players.First(p => p.Name == playerName));
        }
    }
}
