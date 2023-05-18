using System;

namespace P06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            
            for (int i =1; i<=jury; i++)
            {
                string juryName = Console.ReadLine(); 
                double juryPoints = double.Parse(Console.ReadLine()); 
                academyPoints += (juryName.Length * juryPoints) /2;
                if (academyPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }
             if (1250.5 > academyPoints)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - academyPoints:f1} more!");
            }

        }
    }
}
