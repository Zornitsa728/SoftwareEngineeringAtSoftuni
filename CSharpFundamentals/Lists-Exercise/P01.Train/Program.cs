using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input.Contains("Add"))
                {
                    AddWagon(input, wagons);
                }
                else
                {
                    AddPassengers(input, wagons, wagonCapacity);
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        static List<int> AddPassengers(string input, List<int> wagons, int wagonCapacity)
        {
            int passengers = int.Parse(input);
            for (int currWagon = 0; currWagon < wagons.Count; currWagon++)
            {
                if (wagons[currWagon] + passengers <= wagonCapacity)
                {
                    wagons[currWagon] += passengers;
                    break;
                }
            }

            return wagons;
        }

        static List<int> AddWagon(string input, List<int> wagons)
        {
            string[] passenegersToAdd = input.Split();
            int newWagon = int.Parse(passenegersToAdd[1]);

            wagons.Add(newWagon);
            return wagons;
        }
    }
}