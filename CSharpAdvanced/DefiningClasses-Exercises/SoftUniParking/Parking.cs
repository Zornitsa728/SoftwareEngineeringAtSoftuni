using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;

        private int capacity;

        private int count;
        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }
        public int Count { get { return cars.Count; } }
        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";

            }

            if (capacity <= cars.Count)
            {
                return "Parking is full!";
            }

            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string RegistrationNumber)
        {
            if (cars.Any(c => c.RegistrationNumber == RegistrationNumber))
            {
                cars.Remove(cars.Find(c => c.RegistrationNumber == RegistrationNumber));
                return $"Successfully removed {RegistrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string RegistrationNumber)
        {
            return cars.Find(c => c.RegistrationNumber == RegistrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            for (int i = 0; i < RegistrationNumbers.Count; i++)
            {
                if (cars.Any(c => c.RegistrationNumber == RegistrationNumbers[i]))
                {
                    cars.Remove(cars.Find(c => c.RegistrationNumber == RegistrationNumbers[i]));
                }
            }
        }
    }
}
