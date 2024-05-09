using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using GanzenBord.Business.Factories;
using GanzenBord.Business.Spaces;
using Moq;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class GooseSpaceTests
    {
        [Test]
        public void IfPlayerLandsOnGoose_ThenPlayerMovesSameAmountOfSpacesAgain()
        {
            //Arrange
            int[] diceRoll = [5, 5];
            int currentSpace = 10;
            int expectedDestination = 20;

            Mock<ILogger> mockLogger = new Mock<ILogger>();
            Mock<ISpaceFactory> mockSpaceFactory = new Mock<ISpaceFactory>();

            IBoard testBoard = new Board(mockSpaceFactory.Object);
            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.lastRoll = diceRoll;
            testPlayer.CurrentSpace = currentSpace;
            ISpace testGooseSpace = new GooseSpace(10, mockLogger.Object, testBoard);

            //Act
            testGooseSpace.SpaceEffect(testPlayer);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedDestination));
        }
    }
}