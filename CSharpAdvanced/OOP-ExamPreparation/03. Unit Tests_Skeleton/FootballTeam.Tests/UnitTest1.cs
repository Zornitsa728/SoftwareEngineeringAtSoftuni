using NUnit.Framework;
using System;
using System.Linq;

namespace FootballTeam.Tests
{
    public class Tests
    {
        FootballTeam team;
        string teamName;
        int capacity;
        FootballPlayer footballPlayer;

        [SetUp]
        public void Setup()
        {
            teamName = "Levski";
            capacity = 21;
            team = new FootballTeam(teamName, capacity);

            for (int i = 1; i <= 16; i++)
            {
                footballPlayer = new FootballPlayer("Joro" + i, i, "Midfielder");
                team.AddNewPlayer(footballPlayer);
            }

        }

        [Test]
        public void When_CreatingTeam_ShouldWorkCorrectly()
        {
            Assert.AreEqual(teamName, team.Name);
            Assert.AreEqual(capacity, team.Capacity);
            Assert.AreEqual(16, team.Players.Count);
        }

        [TestCase(null)]
        [TestCase("")]
        public void When_CreatingTeamWithNullOrEmptyName_ShouldThrowException(string name)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new FootballTeam(name, capacity));

            Assert.AreEqual("Name cannot be null or empty!", ex.Message);
        }


        [TestCase(14)]
        [TestCase(10)]
        [TestCase(1)]
        [TestCase(-5)]
        public void When_CreatingTeamWithCapacityUnder15_ShouldThrowException(int testCapacity)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => new FootballTeam(teamName, testCapacity));

            Assert.AreEqual("Capacity min value = 15", ex.Message);
        }

        [Test]
        public void When_AddingNewPlayersAboveTheCapacity_ShouldReturnMessage()
        {
            for (int i = 16; i <= 21; i++)
            {
                FootballPlayer footballPlayer = new FootballPlayer("Joro" + i, i, "Midfielder");
                team.AddNewPlayer(footballPlayer);
            }

            FootballPlayer lastFootballPlayer = new FootballPlayer("Joro22", 12, "Goalkeeper");

            Assert.AreEqual("No more positions available!", team.AddNewPlayer(lastFootballPlayer));
        }

        [Test]
        public void When_AddingNewPlayer_ShouldWorkCorrectly()
        {
            FootballPlayer currPlayer = new FootballPlayer("Joro17", 17, "Goalkeeper");

            Assert.AreEqual($"Added player {currPlayer.Name} in position {currPlayer.Position} with number {currPlayer.PlayerNumber}", team.AddNewPlayer(currPlayer));

            Assert.AreEqual(17, team.Players.Count);
        }

        [Test]
        public void When_PickPlayer_ShouldWorkCorrectly()
        {
            FootballPlayer currPlayer = team.Players.FirstOrDefault(p => p.Name == "Joro5");

            Assert.IsNotNull(currPlayer);
            Assert.AreEqual(currPlayer, team.PickPlayer("Joro5"));
        }

        [TestCase(14)]
        [TestCase(10)]
        [TestCase(1)]
        public void PlayerScore_ShouldWorkCorrectly(int playerNumber)
        {
            FootballPlayer currPlayer = new FootballPlayer("Joro" + playerNumber, playerNumber, "Goalkeeper");
            currPlayer.Score();

            Assert.AreEqual($"{currPlayer.Name} scored and now has {currPlayer.ScoredGoals} for this season!", team.PlayerScore(playerNumber));
            Assert.AreEqual(1, currPlayer.ScoredGoals);

        }
    }
}