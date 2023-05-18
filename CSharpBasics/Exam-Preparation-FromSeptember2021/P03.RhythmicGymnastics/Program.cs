using System;

namespace P03.RhythmicGymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – държава – текст ("Russia", "Bulgaria" или "Italy")
            string country = Console.ReadLine();
            //•	Втори ред – уред - текст("ribbon", "hoop" или "rope")
            string apparatus = Console.ReadLine();
            //каква е оценката на дадена държава за опр. уред и колко процента не им достигат,zа да имат макс. оценка,която е 20.
            double difficulty = 0;
            double routine = 0;

            if (country == "Russia")
            {
                if (apparatus == "ribbon")
                {
                    difficulty = 9.100;
                    routine = 9.400;
                }
                else if (apparatus == "hoop")
                {
                    difficulty = 9.300;
                    routine = 9.800;
                }
                else
                {
                    difficulty = 9.600;
                    routine = 9.000;
                }
            }
            else if (country == "Bulgaria")
            {
                if (apparatus == "ribbon")
                {
                    difficulty = 9.600;
                    routine = 9.400;
                }
                else if (apparatus == "hoop")
                {
                    difficulty = 9.550;
                    routine = 9.750;
                }
                else
                {
                    difficulty = 9.500;
                    routine = 9.400;
                }
            }
            else
            {
                if (apparatus == "ribbon")
                {
                    difficulty = 9.200;
                    routine = 9.500;
                }
                else if (apparatus == "hoop")
                {
                    difficulty = 9.450;
                    routine = 9.350;
                }
                else
                {
                    difficulty = 9.700;
                    routine = 9.150;
                }
            }

            double grade = difficulty + routine;
            double percent = 20 - grade;

            Console.WriteLine($"The team of {country} get {grade:f3} on {apparatus}.");
            Console.WriteLine($"{percent/20*100:f2}%");
        }
    }
}
