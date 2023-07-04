namespace P06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            double[] countCars = new double[2];
            double[] countTrucks = new double[2];

            AddVehiclesToList(vehicles, countCars, countTrucks);
            PrintVehicles(vehicles);

            AverageHp(countCars, countTrucks);
        }

        static void AverageHp(double[] countCars, double[] countTrucks)
        {
            if (countCars[1] > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(countCars[0] / countCars[1]):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (countTrucks[1] > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(countTrucks[0] / countTrucks[1]):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
        static void PrintVehicles(List<Vehicle> vehicles)
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (cmd == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {vehicle.Type[0].ToString().ToUpper() + vehicle.Type.Substring(1)}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
            }
        }
        static void AddVehiclesToList(List<Vehicle> vehicles, double[] countCars, double[] countTrucks)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArgs[0];
                string model = cmdArgs[1];
                string color = cmdArgs[2];
                int horsepower = int.Parse(cmdArgs[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);

                if (type == "car")
                {
                    countCars[0] += vehicle.SumHorsepowersCars(horsepower);
                    countCars[1]++;
                }
                else
                {
                    countTrucks[0] += vehicle.SumHorsepowersTrucks(horsepower);
                    countTrucks[1]++;
                }

            }
        }
    }

    public class Vehicle
    {
        private int horsepowerCars;
        private int horsepowerTrucks;
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }
        public string Type { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Horsepower { get; private set; }

        public int SumHorsepowersCars(int horsepower)
        {
            return horsepowerCars += horsepower;
        }
        public int SumHorsepowersTrucks(int horsepower)
        {
            return horsepowerTrucks += horsepower;
        }
    }
}