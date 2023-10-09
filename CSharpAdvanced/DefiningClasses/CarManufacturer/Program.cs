namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            string input = string.Empty;
            var tires = new List<List<Tire>>();
            int counter = 0;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                tires.Add(new List<Tire>());
                
                for (int i = 0; i < tokens.Length - 1; i += 2)
                {
                    int year = int.Parse(tokens[i]);
                    double pressure = double.Parse(tokens[i + 1]);
                    Tire tire = new Tire ( year, pressure );

                    tires[counter].Add(tire);
                }

                counter++;
            }

            List<Engine> engines = new List<Engine>();

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }

            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                Engine engineIndex = engines[int.Parse(tokens[5])];
                Tire[] tireIndex = tires[int.Parse((tokens[6]))].ToArray();

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineIndex, tireIndex);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Sum(x => x.Pressure) > 9 && car.Tires.Sum(x => x.Pressure) < 10)
                {
                    car.Drive(20);

                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");

                }
            }
        }
    }
}

