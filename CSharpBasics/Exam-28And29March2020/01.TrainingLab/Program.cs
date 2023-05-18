using System;

namespace _01.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 2 числа, по едно на ред: w (дължина в метри) и h (широчина в метри)
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            h *= 100;
            w *= 100;
            double coridor = 100;
            h -= coridor;
            double seatsH = Math.Floor(h / 70);
            double seatsW = Math.Floor(w / 120);
            double allSeats = seatsH * seatsW - 3;
            Console.WriteLine(allSeats);
        }
    }
}
