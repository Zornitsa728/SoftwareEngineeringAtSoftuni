using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasedConsumption = 1.6;

        public Truck(double fuelQuantity, double consumtionPerKm,double tankCapacity)
            : base(fuelQuantity, consumtionPerKm, tankCapacity, IncreasedConsumption)
        {
        }

        public override void Refuel(double liters)
        {
            if (TankCapacity < FuelQuantity + liters)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            base.Refuel(liters * 0.95);
        }
    }
}
