using Ganzenbord.Business.Dice;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using GanzenBord.Business;
using GanzenBord.Business.Factories;
using GanzenBord.Business.Spaces;
using Moq;

namespace Ganzenbord.Business.Tests
{
    public class GameTests
    {
        [TestCase(4, 5)]
        [TestCase(5, 4)]
        public void WhenPlayerRollesFoorPlusFiveOrFivePlusFoorWhenOnSpaceZero_ThenPlayerMovesTo26(int diceroll1, int diceroll2)
        {
            //Arrange
            int expectedSpace = 26;

            Mock<ILogger> mockLogger = new Mock<ILogger>();
            Mock<IPlayerFactory> mockPlayerFactory = new Mock<IPlayerFactory>();
            Mock<IDice> mockDice = new Mock<IDice>();
            Mock<ISpaceFactory> mockSpaceFactory = new Mock<ISpaceFactory>();

            ISpaceFactory testSpaceFactory = new SpaceFactory(mockLogger.Object);
            IBoard testBoard = new Board(testSpaceFactory);
            IGame testGame = new Game(mockLogger.Object, mockPlayerFactory.Object, mockDice.Object, testBoard);
            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.CurrentSpace = 0;
            testPlayer.lastRoll = [diceroll1, diceroll2];

            //Act
            testGame.FirstTurn9Roll(testPlayer);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }

        [TestCase(6, 3)]
        [TestCase(3, 6)]
        public void WhenPlayerRollesSixPlusThreeOrThreePlusSixWhenOnStart_ThenPlayerMovesTo53(int diceroll1, int diceroll2)
        {
            //Arrange
            int expectedSpace = 53;

            Mock<ILogger> mockLogger = new Mock<ILogger>();
            Mock<IPlayerFactory> mockPlayerFactory = new Mock<IPlayerFactory>();
            Mock<IDice> mockDice = new Mock<IDice>();
            Mock<ISpaceFactory> mockSpaceFactory = new Mock<ISpaceFactory>();

            ISpaceFactory testSpaceFactory = new SpaceFactory(mockLogger.Object);
            IBoard testBoard = new Board(testSpaceFactory);
            IGame testGame = new Game(mockLogger.Object, mockPlayerFactory.Object, mockDice.Object, testBoard);
            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.CurrentSpace = 0;
            testPlayer.lastRoll = [diceroll1, diceroll2];

            //Act
            testGame.FirstTurn9Roll(testPlayer);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }

        [Test]
        public void WhenPlayerWins_ThenPlayerWonShouldBeTrue()
        {
            //Arrange
            bool expectedResult = true;

            Mock<ILogger> mockLogger = new Mock<ILogger>();
            Mock<IPlayerFactory> mockPlayerFactory = new Mock<IPlayerFactory>();
            Mock<IDice> mockDice = new Mock<IDice>();
            Mock<ISpaceFactory> mockSpaceFactory = new Mock<ISpaceFactory>();

            ISpaceFactory testSpaceFactory = new SpaceFactory(mockLogger.Object);
            IBoard testBoard = new Board(testSpaceFactory);
            IGame testGame = new Game(mockLogger.Object, mockPlayerFactory.Object, mockDice.Object, testBoard);
            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.CurrentSpace = 63;

            //Act
            bool result = testGame.PlayerWon(testPlayer);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void WhenPlayerMoves_ThenDidPlayerMoveShouldBeTrue()
        {
            //Arrange
            bool expectedResult = true;

            Mock<ILogger> mockLogger = new Mock<ILogger>();
            Mock<IPlayerFactory> mockPlayerFactory = new Mock<IPlayerFactory>();
            Mock<IDice> mockDice = new Mock<IDice>();
            Mock<ISpaceFactory> mockSpaceFactory = new Mock<ISpaceFactory>();

            ISpaceFactory testSpaceFactory = new SpaceFactory(mockLogger.Object);
            IBoard testBoard = new Board(testSpaceFactory);
            IGame testGame = new Game(mockLogger.Object, mockPlayerFactory.Object, mockDice.Object, testBoard);
            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.PreviousSpace = 20;
            testPlayer.CurrentSpace = 25;
            int previousSpace = testPlayer.PreviousSpace;

            //Act
            bool result = testGame.DidPlayerMove(testPlayer, previousSpace);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}