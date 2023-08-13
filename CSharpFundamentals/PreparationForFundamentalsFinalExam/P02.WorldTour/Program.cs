using System;
using System.Reflection;

namespace P02.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string cmd = string.Empty;

            while ((cmd = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = cmd
                    .Split(':');
                string operation = cmdArgs[0];

                if (operation == "Add Stop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string text = cmdArgs[2];
                    if (IsIndexValid(stops, index))
                    {
                        stops = stops.Insert(index, text);
                    }
                }
                else if (operation == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int count = endIndex - startIndex;

                    if (IsIndexValid(stops, startIndex) && IsIndexValid(stops, endIndex))
                    {
                        stops = stops.Remove(startIndex, count + 1);
                    }
                }
                else if (operation == "Switch")
                {
                    string oldText = cmdArgs[1];
                    string newText = cmdArgs[2];
                    if (stops.Contains(oldText))
                    {
                        stops = stops.Replace(oldText, newText);
                    }
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        static bool IsIndexValid(string stops, int index)
        {
            if (index >= 0 && index < stops.Length)
            {
                return true;
            }

            return false;
        }
    }
}