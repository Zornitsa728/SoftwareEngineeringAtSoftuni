using System;
using System.Net.NetworkInformation;

namespace P04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int stepsRecorder = 0;

            while ( 10000 > stepsRecorder )
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    stepsRecorder += int.Parse(Console.ReadLine());
                    break;
                }

                stepsRecorder += int.Parse(input);

            }

            if (stepsRecorder >10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsRecorder - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepsRecorder} more steps to reach goal.");
            }
        }
    }
}
