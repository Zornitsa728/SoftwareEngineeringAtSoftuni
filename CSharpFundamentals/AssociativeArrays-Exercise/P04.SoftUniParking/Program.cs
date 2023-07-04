using System.Security.Cryptography.X509Certificates;

namespace P04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carData = new Dictionary<string, string>();
            ParkingValidation(carData);

            PrintParkedCars(carData);
        }
        static void PrintParkedCars(Dictionary<string, string> carData)
        {
            foreach (var kvp in carData)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
        static void Unregister(string[] cmd, Dictionary<string, string> carData)
        {
            string username = cmd[1];

            if (!IsCarRegistered(username, carData))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                carData.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
        }
        static void Register(string[] cmd, Dictionary<string, string> carData)
        {
            string username = cmd[1];
            string licensePlateNumber = cmd[2];

            if (!IsCarRegistered(username, carData))
            {
                carData.Add(username, licensePlateNumber);
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
            }
            else
            {
                string registeredNum = carData[username];
                Console.WriteLine($"ERROR: already registered with plate number {registeredNum}");
            }
        }
        static bool IsCarRegistered (string name, Dictionary<string, string> carData)
        {
            if (carData.ContainsKey(name))
            {
                return true;
            }

            return false;
        }
        private static void ParkingValidation(Dictionary<string, string> carData)
        {
            int cmdsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < cmdsCount; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split();

                if (cmd[0] == "register")
                {
                    Register(cmd, carData);
                }
                else if (cmd[0] == "unregister")
                {
                    Unregister(cmd, carData);
                }
            }
        }
    }
}