using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double IncreasedConsumption = 0.9;

        public Car(double fuelQuantity, double consumtionPerKm, double tankCapacity)
            : base(fuelQuantity, consumtionPerKm, tankCapacity, IncreasedConsumption)
        {
        }
    }
}
