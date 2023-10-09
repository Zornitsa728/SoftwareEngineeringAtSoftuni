using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            AddEngine(enginesCount, engines);

            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            AddCar(engines, carsCount, cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            //PrintResult(cars);

        }

        private static void AddEngine(int enginesCount, List<Engine> engines)
        {
            for (int currEngine = 0; currEngine < enginesCount; currEngine++)
            {
                string[] engineData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                Engine engine = new Engine(model, power);

                if (engineData.Length == 3)
                {
                    int.TryParse(engineData[2], out int result);

                    if (result == 0)
                    {
                        engine.Efficiency = engineData[2];
                    }
                    else
                    {
                        engine.Displacement = int.Parse(engineData[2]);
                    }

                }
                else if (engineData.Length == 4)
                {
                    engine.Displacement = int.Parse(engineData[2]);
                    engine.Efficiency = engineData[3];
                }

                engines.Add(engine);
            }
        }

        private static void AddCar(List<Engine> engines, int carsCount, List<Car> cars)
        {
            for (int currCar = 0; currCar < carsCount; currCar++)
            {
                string[] carData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                string engineName = carData[1];

                Engine engineObj = engines.First(e => e.Model == engineName);

                Car car = new Car(model, engineObj);

                if (carData.Length == 3)
                {
                    int.TryParse(carData[2], out int result);

                    if (result == 0)
                    {
                        car.Color = carData[2];
                    }
                    else
                    {
                        car.Weight = int.Parse(carData[2]);
                    }

                }
                else if (carData.Length == 4)
                {
                    car.Weight = int.Parse(carData[2]);
                    car.Color = carData[3];
                }

                cars.Add(car);
            }
        }

        private static void PrintResult(List<Car> cars)
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model + ":");
                Console.WriteLine(car.Engine.Model + ":");
                Console.WriteLine($"Power: {car.Engine.Power}");

                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine($"Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine($"Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"Efficiency: {car.Engine.Efficiency}");
                }


                if (car.Weight == 0)
                {
                    Console.WriteLine($"Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"Weight: {car.Weight}");
                }


                if (car.Color == null)
                {
                    Console.WriteLine($"Color: n/a");
                }
                else
                {
                    Console.WriteLine($"Color: {car.Color}");
                }
            }
        }
    }
}