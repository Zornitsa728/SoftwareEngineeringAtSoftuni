namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        Warrior warrior;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Stiven", 12, 8);
        }

        [Test]
        public void When_CreatingWarrior_ShouldWorkCorrectly()
        {
            Assert.AreEqual("Stiven", warrior.Name);
            Assert.AreEqual(12, warrior.Damage);
            Assert.AreEqual(8, warrior.HP);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("     ")]
        public void When_NameIsNullOrWhiteSpace_ShouldThrowException(string name)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => warrior = new Warrior(name, 12, 8));

            Assert.AreEqual("Name should not be empty or whitespace!", ex.Message);
        }

        [TestCase(0)]
        [TestCase(-125)]
        public void When_DamageIsZeroOrNegative_ShouldThrowException(int damage)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => warrior = new Warrior("Steven", damage, 8));

            Assert.AreEqual("Damage value should be positive!", ex.Message);
        }

        [TestCase(-8888)]
        [TestCase(-125)]
        public void When_HPIsZeroOrNegative_ShouldThrowException(int hp)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => warrior = new Warrior("Steven", 12, hp));

            Assert.AreEqual("HP should not be negative!", ex.Message);
        }

        [TestCase(15)]
        [TestCase(10)]
        [TestCase(30)]
        public void When_TheAttackingWarriorHpIsLessThanMinAttack_ShouldThrowException(int hp)
        {
            //const minAttack = 30;
            warrior = new Warrior("Steven", 12, hp);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Ivan", 15, 40)));

            Assert.AreEqual("Your HP is too low in order to attack other warriors!", ex.Message);
        }


        [TestCase(15)]
        [TestCase(10)]
        [TestCase(30)]
        public void When_TheAttackedWarriorHpIsLessThanMinAttack_ShouldThrowException(int hp)
        {
            const int minAttack = 30;

            warrior = new Warrior("Steven", 12, 50);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Ivan", 15, hp)));

            Assert.AreEqual($"Enemy HP must be greater than {minAttack} in order to attack him!", ex.Message);
        }

        [TestCase(60)]
        [TestCase(100)]
        [TestCase(350)]
        public void When_AttackingWarriorHpIsLessThanTheAttackedWarrior_ShouldThrowException(int damage)
        {
            warrior = new Warrior("Steven", 12, 50);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => warrior.Attack(new Warrior("Ivan", damage, 50)));

            Assert.AreEqual($"You are trying to attack too strong enemy", ex.Message);
        }

        [TestCase(60)]
        [TestCase(100)]
        [TestCase(350)]
        public void When_Attacking_ShouldWorkCorrectly(int damage)
        {
            warrior = new Warrior("Steven", damage, 400);
            Warrior defender = new Warrior("Ivan", damage, 500);
            int expectedDefenderHp = 500 - damage;

            warrior.Attack(defender);

            Assert.AreEqual(400 - damage, warrior.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }

        [TestCase(60)]
        [TestCase(100)]
        [TestCase(350)]
        public void When_AttackingWithBiggerDamageThanAttackedHp_ShouldMakeAttackedHpZero(int damage)
        {
            warrior = new Warrior("Steven", damage, 400);
            Warrior secondWarroir = new Warrior("Ivan", 40, 40);
            warrior.Attack(secondWarroir);

            Assert.AreEqual(0, secondWarroir.HP);
        }

        [TestCase(60)]
        [TestCase(100)]
        [TestCase(350)]
        public void When_AttackingWithLowerDamageThanAttackedHp_ShouldSubtractFromAttackedHpTheDamage(int damage)
        {
            warrior = new Warrior("Steven", damage, 400);
            Warrior secondWarroir = new Warrior("Ivan", 40, 400);
            warrior.Attack(secondWarroir);

            Assert.AreEqual(400 - damage, secondWarroir.HP);
        }
    }
}