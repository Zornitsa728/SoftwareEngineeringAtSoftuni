using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(125, 200);
            vehicle.Drive(15);
            Console.WriteLine(vehicle.Fuel);

            Motorcycle motor = new Motorcycle(125,200);
            motor.Drive(15);
            Console.WriteLine(motor.Fuel);

            Car car = new Car(125, 200);
            car.Drive(15);
            Console.WriteLine(car.Fuel);

            RaceMotorcycle raceMotorcycle = new(125,200);   
            raceMotorcycle.Drive(15);
            Console.WriteLine(raceMotorcycle.Fuel);
        }
    }
}
