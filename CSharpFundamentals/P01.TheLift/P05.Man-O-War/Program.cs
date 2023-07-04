using static System.Net.Mime.MediaTypeNames;

namespace P05.Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShipStatus = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            List<int> warShipStatus = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            int maxHealtCapacity = int.Parse(Console.ReadLine());
            string input;
            bool endGame = false;

            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] cmd = input.Split();
                switch (cmd[0])
                {
                    case "Fire":
                        if (!IsWarShipIndexValid(warShipStatus, cmd))
                        {
                            continue;
                        }
                        else
                        {
                            endGame = Fire(warShipStatus, cmd, endGame);
                        }
                        break;
                    case "Defend":
                        if (!IsPiratShipIndexValid(pirateShipStatus, cmd))
                        {
                            continue;
                        }
                        else
                        {
                            endGame = Defend(pirateShipStatus, cmd, endGame);
                        }
                            break;
                    case "Repair":
                        
                        if(!Healt(pirateShipStatus, cmd, maxHealtCapacity))
                        {
                            continue;
                        }
                        break;
                    case "Status":
                        int count = StatusForRepair(pirateShipStatus, maxHealtCapacity);
                        Console.WriteLine($"{count} sections need repair.");
                        break;
                }

                if (endGame)
                {
                    break;
                }
            }

            if (!endGame)
            {
                Console.WriteLine($"Pirate ship status: {FinalStatus(pirateShipStatus)}");
                Console.WriteLine($"Warship status: {FinalStatus(warShipStatus)}");
            }
        }

        static bool IsWarShipIndexValid(List<int> warShipStatus, string[] cmd)
        {
            int index = int.Parse(cmd[1]);
            if (index >= 0 && index < warShipStatus.Count)
            {
                return true;
            }

            return false;
        }

        static bool IsPiratShipIndexValid(List<int> pirateShipStatus, string[] cmd)
        {
            int startIndex = int.Parse(cmd[1]);
            int endIndex = int.Parse(cmd[2]);

            if (startIndex >= 0 && endIndex < pirateShipStatus.Count)
            {
                return true;
            }

            return false;
        }

        static bool Fire(List<int> warShipStatus, string[] cmd, bool endGame)
        {
            int index = int.Parse(cmd[1]);
            int damage = int.Parse(cmd[2]);
            warShipStatus[index] -= damage;

            if (warShipStatus[index] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                endGame = true;
            }

            return endGame;
        }

        static bool Defend(List<int> pirateShipStatus, string[] cmd, bool endGame)
        {
            int startIndex = int.Parse(cmd[1]);
            int endIndex = int.Parse(cmd[2]);
            int damage = int.Parse(cmd[3]);

            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShipStatus[i] -= damage;
                if (pirateShipStatus[i] <= 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    endGame = true;
                    break;
                }
            }

            return endGame;
        }

        static bool Healt(List<int> pirateShipStatus, string[] cmd, int maxHealtCapacity)
        {
            int index = int.Parse(cmd[1]);
            int healt = int.Parse(cmd[2]);

            if (index >= 0 && index < pirateShipStatus.Count)
            {
                if (pirateShipStatus[index] + healt > maxHealtCapacity)
                {
                    pirateShipStatus[index] = maxHealtCapacity;
                }
                else
                {
                    pirateShipStatus[index] += healt;
                }

                return true;
            }

            return false;
        }

        static int StatusForRepair(List<int> pirateShipStatus, int maxHealtcapacity)
        {
            int count = 0;
            double lowerHealtPercent = maxHealtcapacity * 0.2;
            foreach (int section in pirateShipStatus)
            {
                if (section < lowerHealtPercent)
                {
                    count++;
                }
            }

            return count;
        }

        static int FinalStatus(List<int> shipStatus)
        {
            int sum = 0;

            foreach (int section in shipStatus)
            {
                sum += section;
            }

            return sum;
        } 
    }
}