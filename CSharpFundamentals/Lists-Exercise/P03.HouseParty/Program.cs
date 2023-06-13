using System.Xml.Linq;

namespace P03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsNum = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commandsNum; i++)
            {
                string command = Console.ReadLine();
                if (command.Contains("is going"))
                {
                    if (!CheckIfGuestIsInTheList(guests, command))
                    {
                        AddGuest(command, guests);
                    }
                }
                else
                {
                    if (!CheckIfGuestIsNotInTheList(guests, command))
                    {
                        RemoveGuest(command, guests);
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }

        static bool CheckIfGuestIsInTheList(List<string> guests, string command)
        {
            string[] commandArray = command.Split();
            string guestName = commandArray[0];
            if (guests.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is already in the list!");
                return true;
            }

            return false;
        }

        static List<string> AddGuest(string command, List<string> guests)
        {
            string[] commandArray = command.Split();
            string guestName = commandArray[0];
            guests.Add(guestName);
            return guests;
        }

        static bool CheckIfGuestIsNotInTheList(List<string> guests, string command)
        {
            string[] commandArray = command.Split();
            string guestName = commandArray[0];
            if (!guests.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is not in the list!");
                return true;
            }

            return false;
        }

        static List<string> RemoveGuest(string command, List<string> guests)
        {
            string[] commandArray = command.Split();
            string guestName = commandArray[0];
            guests.Remove(guestName);
            return guests;
        }
    }
}