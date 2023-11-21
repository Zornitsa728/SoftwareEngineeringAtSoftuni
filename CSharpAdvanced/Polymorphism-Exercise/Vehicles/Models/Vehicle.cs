using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Vehicle : IVehicle
    {
        private double increasedConsumption;
        private double fuelQuantity;
        public Vehicle(double fuelQuantity, double consumtionPerKm, double tankCapacity, double increasedConsumption)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            ConsumtionPerKm = consumtionPerKm;
            this.increasedConsumption = increasedConsumption;
        }

        public double FuelQuantity 
        {
            get => fuelQuantity;
            private set
            {
                if(TankCapacity < value)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double ConsumtionPerKm { get; private set; }

        public double TankCapacity { get; private set; }

    public virtual string Drive(double distance, bool isIncreasedConsumption = true)
        {
            double consumption = isIncreasedConsumption
           ? ConsumtionPerKm + increasedConsumption
           : ConsumtionPerKm;

            if (FuelQuantity < distance * consumption)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }

            FuelQuantity -= distance * consumption;

            return $"{GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (TankCapacity < FuelQuantity + liters)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            FuelQuantity += liters;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
