namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ArenaTests
    {
        Arena arena;
        Warrior warrior;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            warrior = new Warrior("Sam", 50, 125);
        }

        [Test]
        public void When_EnrollWarrior_ShouldAddHimToTheList()
        {
            arena.Enroll(warrior);

            warrior = new Warrior("Dean", 68, 200);
            arena.Enroll(warrior);

            Assert.AreEqual(2, arena.Count);
        }

        [Test]
        public void When_EnrollWarriorWIthExistingName_ShouldThrowException()
        {
            arena.Enroll(warrior);

            warrior = new Warrior("Sam", 68, 200);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));

            Assert.AreEqual("Warrior is already enrolled for the fights!", ex.Message);
        }

        [TestCase(null)]
        [TestCase("Eli")]
        public void When_FightWithNonExistingOrNullAttackingWarriors_ShouldThrowException(string name)
        {
            arena.Enroll(warrior);

            Warrior secondWarrior = new Warrior("Dean", 68, 200);

            arena.Enroll(secondWarrior);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => arena.Fight(name, "Sam"));

            Assert.AreEqual($"There is no fighter with name {name} enrolled for the fights!", ex.Message);
        }

        [TestCase(null)]
        [TestCase("Eli")]
        public void When_FightWithNonExistingOrNullAttackedWarriors_ShouldThrowException(string name)
        {
            arena.Enroll(warrior);

            Warrior secondWarrior = new Warrior("Dean", 68, 200);

            arena.Enroll(secondWarrior);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => arena.Fight("Sam", name));

            Assert.AreEqual($"There is no fighter with name {name} enrolled for the fights!", ex.Message);
        }

        [TestCase]
        public void When_Fight_ShouldWorkCorrectly()
        {
            arena.Enroll(warrior);

            Warrior secondWarrior = new Warrior("Dean", 68, 200);
            int secondWarriorHP = secondWarrior.HP;

            arena.Enroll(secondWarrior);

            arena.Fight("Sam", "Dean");

            Assert.AreEqual(secondWarriorHP - warrior.Damage, secondWarrior.HP);
        }
    }
}
