namespace SmartDevice.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tests
    {
        Device device = null;

        [SetUp]
        public void Setup()
        {
            device = new Device(128);
        }

        [Test]
        public void CheckIfConstructorWorksCorrectly()
        {
            Assert.IsNotNull(device);

            Assert.AreEqual(128, device.MemoryCapacity);
            Assert.AreEqual(128, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(new List<string>(), device.Applications);

        }

        [TestCase(0)]
        [TestCase(40)]
        [TestCase(97)]
        [TestCase(128)]
        public void When_UsingTakePhotoMethodWithSmallerSizePhotos_ShouldReturnTrue(int photoSize)
        {
            Assert.IsTrue(device.TakePhoto(photoSize));
            Assert.AreEqual(1, device.Photos);
            Assert.AreEqual(128 - photoSize, device.AvailableMemory);
        }

        [TestCase(129)]
        [TestCase(400)]
        [TestCase(907)]
        [TestCase(1028)]
        public void When_UsingTakePhotoMethodWithBiggerSizePhotos_ShouldReturnFalse(int photoSize)
        {
            Assert.IsFalse(device.TakePhoto(photoSize));
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(128, device.AvailableMemory);
        }

        [TestCase(0)]
        [TestCase(40)]
        [TestCase(97)]
        [TestCase(128)]
        public void When_UsingInstallAppWithSmallerApps_ShouldReturnCorrectMessage(int appSize)
        {
            string appName = "CoolApp";
            string result = device.InstallApp(appName, appSize);

            Assert.AreEqual(128 - appSize, device.AvailableMemory);
            Assert.AreEqual(1, device.Applications.Count);
            Assert.AreEqual($"{appName} is installed successfully. Run application?", result);
        }

        [TestCase(200)]
        [TestCase(409)]
        [TestCase(967)]
        [TestCase(1208)]
        public void When_UsingInstallAppWithBiggerApps_ShouldThrowException(int appSize)
        {
            string appName = "CoolApp";

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => device.InstallApp(appName, appSize));

            Assert.AreEqual("Not enough available memory to install the app.", ex.Message);
        }

        [Test]
        public void FormatDeviceShouldWorkCorrectly()
        {
            device.TakePhoto(22);
            device.InstallApp("CoolApp", 58);

            device.FormatDevice();

            Assert.AreEqual(128, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(new List<string>(), device.Applications);
        }

        [Test]
        public void When_UsingGetDeviceStatus_ShouldWorkCorrectly()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Memory Capacity: {device.MemoryCapacity} MB, Available Memory: {device.AvailableMemory} MB");
            stringBuilder.AppendLine($"Photos Count: {device.Photos}");
            stringBuilder.AppendLine($"Applications Installed: {string.Join(", ", device.Applications)}");

            Assert.AreEqual(stringBuilder.ToString().TrimEnd(), device.GetDeviceStatus());
        }
    }
}