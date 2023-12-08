namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        Person person;
        Database database;
        Person[] people;

        [SetUp]
        public void SetUp()
        {
            people = new Person[2];

            person = new Person(1234, "Ivan");
            people[0] = person;

            person = new Person(5678, "Martin");
            people[1] = person;

            database = new Database(people);
        }

        [Test]
        public void When_CreatingInstance_ShouldAddingRangeCorrectly()
        {
            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void When_AddingRangeAbove16Elements_ShouldThrowException()
        {
            people = new Person[17];

            for (int i = 0; i < people.Length; i++)
            {
                person = new(1234 + i, $"Ivan{i}");
                people[i] = person;
            }

            Exception ex = Assert.Throws<ArgumentException>(() => database = new Database(people));

            Assert.AreEqual("Provided data length should be in range [0..16]!", ex.Message);
        }

        [Test]
        public void When_AddingPerson_ShouldWorkCorrectly()
        {
            person = new Person(22525, "Silvia");

            database.Add(person);
            Assert.AreEqual(3, database.Count);
        }

        [Test]
        public void When_HaveFullArrayAndAddPerson_ShouldThrowException()
        {
            people = new Person[16];

            for (int i = 0; i < people.Length; i++)
            {
                person = new(1234 + i, $"Ivan{i}");
                people[i] = person;
            }

            database = new Database(people);

            person = new Person(22525, "Silvia");

            Exception ex = Assert.Throws<InvalidOperationException>(() => database.Add(person));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);
        }

        [Test]
        public void When_AddPersonWithExistingUsername_ShouldThrowException()
        {
            person = new Person(0000, "Ivan");

            Exception ex = Assert.Throws<InvalidOperationException>(() => database.Add(person));

            Assert.AreEqual("There is already user with this username!", ex.Message);
        }

        [Test]
        public void When_AddPersonWithExistingId_ShouldThrowException()
        {
            person = new Person(1234, "Mila");

            Exception ex = Assert.Throws<InvalidOperationException>(() => database.Add(person));

            Assert.AreEqual("There is already user with this Id!", ex.Message);
        }

        [Test]
        public void When_RemovingFromEmptyArray_ShouldThrowException()
        {
            database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void When_RemovingPerson_ShouldWorkCorrectly()
        {
            database.Remove();

            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void When_SearchByUsername_ShouldFindThePerson()
        {
            Assert.AreEqual(person, database.FindByUsername("Martin"));
        }

        [Test]
        public void When_SearchByUsernameNonExistingPerson_ShouldThrowException()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Artin"));

            Assert.AreEqual("No user is present by this username!", ex.Message);
        }

        [Test]
        public void When_SearchByUsernameWithEmptyStringOrNull_ShouldThrowException()
        {
            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));

            Assert.AreEqual("Username parameter is null!", ex.ParamName);
        }

        [Test]
        public void When_SearchByIdWithNegativeNumber_ShouldThrowException()
        {
            ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-2));

            Assert.AreEqual("Id should be a positive number!", ex.ParamName);
        }

        [Test]
        public void When_SearchByIdWithNonExistingPerson_ShouldThrowException()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => database.FindById(0000));

            Assert.AreEqual("No user is present by this ID!", ex.Message);
        }

        [Test]
        public void When_SearchPersonById_ShouldReturnTheCorrectOne()
        {
            Assert.AreEqual(person, database.FindById(5678));
        }
    }
}