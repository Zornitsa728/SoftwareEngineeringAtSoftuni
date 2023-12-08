namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void Setup()
        {
            database = new Database(1, 2, 3, 4, 5);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void When_ArrayIsNot16IntegersLong_ShouldThrownException(int[] testNumbers)
        {
            Database database = new Database(testNumbers);

            Assert.Throws<InvalidOperationException>(() => { database.Add(17); });
        }

        [Test]
        public void When_AddingElement_ShouldBeAddAtTheNextFreeCell()
        {
            database.Add(6);
            int[] result = database.Fetch();

            Assert.AreEqual(6, result[5]);
        }

        [Test]
        public void When_RemoveElement_ShouldRemovingAtTheLastIndex()
        {
            database.Remove();
            int[] result = { 1, 2, 3, 4 };

            Assert.AreEqual(result, database.Fetch());
        }

        [Test]
        public void When_TryToRemoveFromAnEMptyDatabase_ShouldReturnAnException()
        {
            Database database = new Database();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void When_CreatingAnInstance_Constructor_ShouldTakeOnlyIntegersAsAnArray()
        {
            Assert.AreEqual(5, database.Count);

        }

        [Test]
        public void When_Fetch_ShouldReturnAnArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(numbers, database.Fetch());
        }
    }
}
