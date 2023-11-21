using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.IO;
using Vehicles.Factories.Interfaces;
using Vehicles.Factories;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory vehicleFactory = new VehicleFactory();

            IEngine engine = new Engine(reader, writer, vehicleFactory);

            engine.Run();
        }
    }
}