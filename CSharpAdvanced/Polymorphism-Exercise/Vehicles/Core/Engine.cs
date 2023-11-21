using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models.Interfaces;
using Vehicles.Models;
using System.Diagnostics;
using Vehicles.Factories.Interfaces;
using Vehicles.Factories;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;
        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;

            vehicles = new List<IVehicle>();
        }
        public void Run()
        {
            vehicles.Add(CreateVehicle());
            vehicles.Add(CreateVehicle()); 
            vehicles.Add(CreateVehicle()); 

            int count = int.Parse(reader.ReadLine());

            for (int i = 0; i < count; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }
        }

        private IVehicle CreateVehicle()
        {
            string[] tokens = reader.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string type = tokens[0];
            double fuelQuantity = double.Parse(tokens[1]);
            double litersPerKm = double.Parse(tokens[2]);
            double tankCapacity = double.Parse(tokens[3]);

            IVehicle vehicle = vehicleFactory.Create(type, fuelQuantity, litersPerKm, tankCapacity);

            return vehicle;
        }
        private void ProcessCommand()
        {
            string[] cmdArgs = reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = cmdArgs[0];
            string vehicleType = cmdArgs[1];

            IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            if (command == "Drive")
            {
                double distance = double.Parse(cmdArgs[2]);
                writer.WriteLine(vehicle.Drive(distance));
            }
            else if (command == "DriveEmpty")
            {
                double distance = double.Parse(cmdArgs[2]);
                writer.WriteLine(vehicle.Drive(distance, false));
            }
            else if (command == "Refuel")
            {
                double liters = double.Parse(cmdArgs[2]);
                vehicle.Refuel(liters);
            }
        }
    }
}
