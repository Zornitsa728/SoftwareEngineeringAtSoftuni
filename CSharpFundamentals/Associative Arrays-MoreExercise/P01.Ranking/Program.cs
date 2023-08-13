namespace P01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contest> contests = new List<Contest>();
            List<User> users = new List<User>();

            RegisterContests(contests);
            RegisterUsers(contests, users);

            Dictionary<string, int> results = new Dictionary<string, int>();

            SumResults(users, results);
            PrintsBestResult(results);
            PrintContestantsAndTheirResults(users);
        }

        private static void PrintContestantsAndTheirResults(List<User> users)
        {
            Console.WriteLine("Ranking: ");

            string currUsername = "";
            foreach (var user in users.OrderByDescending(x => x.Points).OrderBy(x => x.Username))
            {
                if (currUsername != user.Username)
                {
                    Console.WriteLine(user.Username);
                    Console.WriteLine($"#  {user.ContestName} -> {user.Points}");
                    currUsername = user.Username;
                }
                else
                {
                    Console.WriteLine($"#  {user.ContestName} -> {user.Points}");
                }
            }

        }

        private static void PrintsBestResult(Dictionary<string, int> results)
        {
            foreach (var result in results.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {result.Key} with total {result.Value} points.");
                break;
            }
        }

        private static void SumResults(List<User> users, Dictionary<string, int> results)
        {
            string currUsername = "";

            foreach (var currUser in users.OrderBy(x => x.Username))
            {
                if (currUsername != currUser.Username)
                {
                    currUsername = currUser.Username;
                    results.Add(currUsername, currUser.Points);
                }
                else
                {
                    results[currUsername] += currUser.Points;
                }
            }
        }

        private static string RegisterUsers(List<Contest> contests, List<User> users)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArgs = input.Split("=>");
                string contestName = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int newPoints = int.Parse(cmdArgs[3]);
                User user = new User(username, contestName, newPoints);

                if (IsContestAndPasswordValid(contests, password, contestName))
                {
                    User currContest = users.Find(x => x.ContestName == contestName && x.Username == username);

                    if (currContest != null)
                    {
                        if (currContest.Username == username)
                        {
                            if (currContest.Points < newPoints)
                            {
                                currContest.Points = newPoints;
                            }

                            continue;
                        }
                    }

                    users.Add(user);
                }
            }

            return input;
        }

        private static string RegisterContests(List<Contest> contests)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArgs = input.Split(":");
                string contestName = cmdArgs[0];
                string password = cmdArgs[1];

                Contest contest = new Contest(contestName, password);
                contests.Add(contest);
            }

            return input;
        }

        static bool IsContestAndPasswordValid(List<Contest> contests, string password, string contestName)
        {
            if (contests.Any(x => x.ContestName == contestName && x.Password == password))
            {
                return true;
            }
            return false;
        }
    }

    public class User
    {
        public User(string username, string contestName, int points)
        {
            this.Username = username;
            ContestName = contestName;
            Points = points;
        }

        public string Username { get; set; }
        public string ContestName { get; set; }
        public int Points { get; set; }
    }
    public class Contest
    {
        public Contest(string contestName, string password)
        {
            ContestName = contestName;
            Password = password;
        }

        public string ContestName { get; set; }
        public string Password { get; set; }
    }
}