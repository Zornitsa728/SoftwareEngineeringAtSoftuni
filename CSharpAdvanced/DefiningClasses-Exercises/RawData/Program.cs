using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int currCar = 0; currCar < carsCount; currCar++)
            {
                string[] carData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                Engine engine = new Engine(int.Parse(carData[1]), int.Parse(carData[2]));
                Cargo cargo = new Cargo(int.Parse(carData[3]), carData[4]);
                Car car = new Car(model, engine, cargo, new List<Tire>());

                for (int tireData = 5; tireData < carData.Length; tireData+=2)
                {
                    Tire tire = new Tire(double.Parse(carData[tireData]), int.Parse(carData[tireData+1]));
                    car.AddTires(tire);
                }

                cars.Add(car);
            }

            string cmd = Console.ReadLine();
            List<Car> result = new List<Car>();

            if (cmd == "fragile")
            {
                result = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(x => x.Pressure < 1)).ToList();

            }
            else
            {
                result = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).ToList();
            }

            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}