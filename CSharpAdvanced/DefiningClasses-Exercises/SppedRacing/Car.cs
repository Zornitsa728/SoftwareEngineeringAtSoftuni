using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DefiningClasses
{
    public class Car
    {
        private string model;

        private double fuelAmount;

        private double fuelConsumtion;

        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumtion)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumtionPerKilometer = fuelConsumtion;
        }
        public string Model { get { return this.model; } set { this.model = value; } }

        public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }

        public double FuelConsumtionPerKilometer { get { return this.fuelConsumtion; } set { this.fuelConsumtion = value; } }

        public double TravelledDistance { get { return this.travelledDistance; } set { this.travelledDistance = value; } }

        public bool IsFuelEnough(Car car, int km)
        {
            if (car.fuelAmount >= (car.fuelConsumtion * km))
            {
                car.fuelAmount -= (car.fuelConsumtion * km);
                car.travelledDistance += km;
                return true;
            }

            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }

    }
}
