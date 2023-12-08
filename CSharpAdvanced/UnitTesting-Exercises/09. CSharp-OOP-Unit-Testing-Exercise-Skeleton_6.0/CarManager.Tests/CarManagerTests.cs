namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("BMW", "525", 8.9, 60);
        }

        [Test]
        public void CreatingCorrectlyNewInstanceOfACar()
        {
            Assert.AreEqual("BMW", car.Make);
            Assert.AreEqual("525", car.Model);
            Assert.AreEqual(8.9, car.FuelConsumption);
            Assert.AreEqual(60, car.FuelCapacity);
        }

        [Test]
        public void When_MakeIsNullOrEmpty_ShouldThrowException()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => car = new Car(null, "525", 8.9, 60));

            Assert.AreEqual("Make cannot be null or empty!", ex.Message);
        }

        [Test]
        public void When_ModelIsNullOrEmpty_ShouldThrowException()
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => car = new Car("BMW", null, 8.9, 60));

            Assert.AreEqual("Model cannot be null or empty!", ex.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-251)]
        public void When_FuelConsumptionIsZeroOrNegative_ShouldThrowException(double fuelConsumption)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => car = new Car("BMW", "525", fuelConsumption, 60));

            Assert.AreEqual("Fuel consumption cannot be zero or negative!", ex.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-251)]
        public void When_FuelCapacityIsZeroOrNegative_ShouldThrowException(double fuelCapacity)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => car = new Car("BMW", "525", 8.9, fuelCapacity));

            Assert.AreEqual("Fuel capacity cannot be zero or negative!", ex.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-251)]
        public void When_RefuelTheAmountCannotBeZeroOrNegative_ShouldThrowException(double fuelToRefuel)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));

            Assert.AreEqual("Fuel amount cannot be zero or negative!", ex.Message);
        }

        [TestCase(60)]
        [TestCase(151)]
        [TestCase(255)]
        public void When_RefuelIfTheAmountIsBiggerThanCapacity_ShouldMakeFuelAMountEqualToCapacity(double fuelToRefuel)
        {
            car.Refuel(fuelToRefuel);

            Assert.AreEqual(60, car.FuelAmount);
        }

        [TestCase(25)]
        public void RefuelingCorrectly(double fuelToRefuel)
        {
            car.Refuel(fuelToRefuel);

            Assert.AreEqual(25, car.FuelAmount);
        }

        [TestCase(1, 100)]
        [TestCase(10, 151)]
        [TestCase(10, 255)]
        public void When_DoNotHaveEnoughFuelToDriveTheDistance_ShouldThrowException(double fuel, double distance)
        {
            car.Refuel(fuel);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => car.Drive(distance));

            Assert.AreEqual("You don't have enough fuel to drive!", ex.Message);
        }

        [TestCase(60, 100)]
        [TestCase(60, 151)]
        public void When_DriveTheDistance_ShouldSubtractTheUsedFuel(double fuel, double distance)
        {
            double fuelNeeded = (distance / 100) * car.FuelConsumption;

            car.Refuel(fuel);

            car.Drive(distance);

            double result = fuel - fuelNeeded;

            Assert.AreEqual(result, car.FuelAmount);
        }
    }
}