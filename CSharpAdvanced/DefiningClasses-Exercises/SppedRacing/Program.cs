using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));

                cars.Add(car);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = cars.First(c =>c.Model == tokens[1]);

               car.IsFuelEnough(car, int.Parse(tokens[2]));

            }

            foreach (Car currCar in cars)
            {
                Console.WriteLine($"{currCar.Model} {currCar.FuelAmount:f2} {currCar.TravelledDistance}");
            }
        }
    }
}