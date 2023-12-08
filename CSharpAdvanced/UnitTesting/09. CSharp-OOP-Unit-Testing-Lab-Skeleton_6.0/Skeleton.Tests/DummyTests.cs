using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Dummy dummy;

        [SetUp]
        public void TestInitialize()
        {
            Axe axe = new Axe(10, 10);
            dummy = new(10, 10);
        }

        [Test]
        public void When_DummyIsAttacked_ShouldLooseHealth()
        {
            dummy.TakeAttack(10);
            Assert.AreEqual(0, dummy.Health);
        }

        [Test]
        public void When_DeadDummyIsAttacked_ShouldThrowsAnException()
        {
            dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(10));
        }

        [Test]
        public void When_DummyIsDead_ShouldGiveXP()
        {
            dummy = new Dummy(0, 10);

            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [Test]
        public void When_DummyIsAlive_ShouldCannotGiveXP()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}