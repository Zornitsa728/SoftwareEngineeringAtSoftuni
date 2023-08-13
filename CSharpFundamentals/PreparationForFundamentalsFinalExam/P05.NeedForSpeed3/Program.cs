namespace P05.NeedForSpeed3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carNum = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carNum; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split("|");
                string name = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);
                Car car = new Car(name, mileage, fuel);
                cars.Add(car);
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input
                    .Split(" : ");
                string operation = cmdArgs[0];
                string carName = cmdArgs[1];
                Car currCar = cars.First(x => x.Name == carName);

                if (operation == "Drive")
                {
                    int distance = int.Parse(cmdArgs[2]);
                    int fuel = int.Parse(cmdArgs[3]);
                    
                    if (currCar.Fuel - fuel >= 0)
                    {
                        currCar.Fuel -= fuel;
                        currCar.Mileage += distance;
                        Console.WriteLine($"{currCar.Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (currCar.Mileage >= 100000)
                        {
                            cars.Remove(currCar);
                            Console.WriteLine($"Time to sell the {carName}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (operation == "Refuel")
                {
                    int fuel = int.Parse(cmdArgs[2]);

                    if (currCar.Fuel + fuel > 75)
                    {
                        fuel = 75 - currCar.Fuel;
                        currCar.Fuel = 75;
                    }
                    else
                    {
                        currCar.Fuel += fuel;
                    }

                    Console.WriteLine($"{carName} refueled with {fuel} liters");
                }
                else if (operation == "Revert")
                {
                    int km = int.Parse(cmdArgs[2]);

                    if (currCar.Mileage - km < 10000)
                    {
                        currCar.Mileage = 10000;
                    }
                    else
                    {
                        currCar.Mileage -= km;
                        Console.WriteLine($"{carName} mileage decreased by {km} kilometers");
                    }
                }
            }

            foreach ( Car car in cars )
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }

    public class Car 
    {
        public Car(string name, int mileage, int fuel) 
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Name { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }

}