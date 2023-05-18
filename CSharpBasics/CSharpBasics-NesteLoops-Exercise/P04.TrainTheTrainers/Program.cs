using System;
using System.Security.Cryptography;

namespace P04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNum = int.Parse(Console.ReadLine()); //броят на хората в журито n - цяло число в интервала [1…20]
            string presentationName; //След това на отделен ред се прочита името на презентацията - текст
            //За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
            int count = 0;
            double averageSum = 0;
            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                double markSum = 0;

                for (int i = 1; i <= juryNum; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    markSum+= mark;
                }

                double average = markSum/juryNum;
                count++;
                averageSum+= average;
                Console.WriteLine($"{presentationName} - {average:f2}.");
            }

            if (presentationName == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {averageSum/count:f2}.");
            }
        }
    }
}
