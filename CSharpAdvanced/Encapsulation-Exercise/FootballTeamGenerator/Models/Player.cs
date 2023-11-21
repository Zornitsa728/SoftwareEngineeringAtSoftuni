using System.ComponentModel.DataAnnotations;

namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;

        private Dictionary<string, int> stats;

        public Player(string name,int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Stats = new Dictionary<string, int>
            {
                { "Endurance", endurance },
                { "Sprint", sprint },
                { "Dribble", dribble },
                { "Passing", passing },
                { "Shooting", shooting },
            };
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public Dictionary<string, int> Stats
        {
            get => stats;
            private set
            {
                if (value.Any(s => s.Value < 0 || s.Value > 100))
                {
                    string statName = value.First(s => s.Value < 0 || s.Value > 100).Key;

                    throw new ArgumentException($"{statName} should be between 0 and 100.");
                }

                stats = value;
            }
        }

        internal double SkillLevel
        {
            get
            {
                if (!stats.Any())
                {
                    return 0;
                }

                double average = 0;

                foreach (var stat in Stats)
                {
                    average += stat.Value;
                }
                
                return average / stats.Count;
            }
        }
    }
}
