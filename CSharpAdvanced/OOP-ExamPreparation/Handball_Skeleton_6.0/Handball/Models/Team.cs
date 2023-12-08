using Handball.Models.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Handball.Models
{
    public class Team : ITeam
    {
        private string name;

        private int pointsEarned;

        private List<IPlayer> players;

        public Team(string name)
        {
            Name = name;
            players = new List<IPlayer>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }

                name = value;
            }
        }


        public int PointsEarned
        {
            get { return pointsEarned; }
            private set { pointsEarned = value; }
        }

        public double OverallRating
        {
            get
            {
                if (players.Count == 0)
                {
                    return 0;
                }

                return Math.Round(players.Average(p => p.Rating), 2);
            }
        }
        public IReadOnlyCollection<IPlayer> Players => players.AsReadOnly();

        public void Draw()
        {
            PointsEarned += 1;
            IPlayer goalKeeper = players.FirstOrDefault(p => p is Goalkeeper);

            if (goalKeeper != null)
            {
                goalKeeper.IncreaseRating();
            }
        }

        public void Lose()
        {
            foreach (var player in players)
            {
                player.DecreaseRating();
            }
        }

        public void SignContract(IPlayer player)
        {
            players.Add(player);
        }

        public void Win()
        {
            PointsEarned += 3;

            foreach (IPlayer player in players)
            {
                player.IncreaseRating();
            }
        }

        public override string ToString()
        {
            string playersToString = "none";

            if (players.Count > 0)
            {
                playersToString = String.Join(", ", players.Select(p => p.Name));
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Team: {Name} Points: {PointsEarned}");
            sb.AppendLine($"--Overall rating: {OverallRating}");
            sb.AppendLine($"--Players: {playersToString}");

            return sb.ToString().Trim();
        }
    }
}
