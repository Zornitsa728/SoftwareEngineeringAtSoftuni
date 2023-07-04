namespace P07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalog catalog = new Catalog();
            
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split("/");
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];


                if (type == "Car")
                {
                    int horsePower = int.Parse(tokens[3]);
                    catalog.Cars.Add(new Car(brand, model, horsePower));
                }
                else
                {
                    int weight = int.Parse(tokens[3]);
                    catalog.Trucks.Add(new Truck(brand, model, weight));
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            
            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}