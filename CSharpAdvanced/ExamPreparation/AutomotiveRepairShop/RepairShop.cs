using System.Text;
using System.Threading.Channels;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }
        public int Capacity { get; set; }

        public List<Vehicle> Vehicles { get; private set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            if (Vehicles.Any(v => v.VIN == vin))
            {
                Vehicles.Remove(Vehicles.FirstOrDefault(v => v.VIN == vin));
                return true;
            }

            return false;
        }

        public int GetCount() => Vehicles.Count;

        public Vehicle GetLowestMileage() => Vehicles.MinBy(v => v.Mileage);
        
        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Vehicles in the preparatory:");
            foreach (var vehicle in Vehicles)
            {
                stringBuilder.AppendLine(vehicle.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
