namespace P02.FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = Console.ReadLine()
                .Split(", ");
            string input;
            int blackListedNames = 0;
            int lostNamesCount = 0;

            while ((input = Console.ReadLine()) != "Report")
            {
                string[] cmd = input.Split();

                if (cmd[0] == "Blacklist")
                {
                    Blacklisted(friends, cmd, ref blackListedNames);
                }
                else if (cmd[0] == "Error")
                {
                    if (IsIndexValid(friends, cmd))
                    {
                        Error(friends, cmd, ref lostNamesCount);
                    }
                }
                else if (cmd[0] == "Change")
                {
                    if (IsIndexValid(friends, cmd))
                    {
                        ChangeName(friends, cmd);
                    }
                }
            }

            Console.WriteLine($"Blacklisted names: {blackListedNames}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(" ", friends));
        }

        static void Blacklisted(string[] friends, string[] cmd,ref int blackListedNames)
        {
            string name = cmd[1];
            if (friends.Contains(name))
            {
                for (int i = 0; i < friends.Length; i++)
                {
                    if (friends[i] == name)
                    {
                        friends[i] = "Blacklisted";
                        break;
                    }
                }
                blackListedNames++;
                Console.WriteLine($"{name} was blacklisted.");
            }
            else
            {
                Console.WriteLine($"{name} was not found.");
            }
        }

        static bool IsIndexValid(string[] friends, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            if (index >= 0 && index < friends.Length)
            {
                return true;
            }

            return false;
        }

        static void Error(string[] friends, string[] cmd,ref int lostNamesCount)
        {
            int index = int.Parse(cmd[1]);
            if (friends[index] != "Blacklisted" && friends[index] != "Lost")
            {
                string name = friends[index];
                friends[index] = "Lost";
                lostNamesCount++;
                Console.WriteLine($"{name} was lost due to an error.");
            }
        }

        static void ChangeName(string[] friends, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            string currName = friends[index];
            string newName = cmd[2];
            friends[index] = newName;
            Console.WriteLine($"{currName} changed his username to {newName}."); 
        }

    }
}