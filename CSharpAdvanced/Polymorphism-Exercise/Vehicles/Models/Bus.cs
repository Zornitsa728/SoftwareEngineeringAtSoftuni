using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    internal class Bus : Vehicle
    {
        private const double IncreasedConsumption = 1.4;
        public Bus(double fuelQuantity, double consumtionPerKm, double tankCapacity) 
            : base(fuelQuantity, consumtionPerKm, tankCapacity, IncreasedConsumption)
        {
        }
    }
}
