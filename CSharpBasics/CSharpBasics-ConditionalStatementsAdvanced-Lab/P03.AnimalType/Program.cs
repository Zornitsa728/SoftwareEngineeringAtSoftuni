using System;
using System.Xml.Linq;

namespace P03.AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine();
             switch(animalType)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }


        }
    }
}
