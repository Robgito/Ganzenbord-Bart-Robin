using Ganzenbord.Business.Dice;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Logger;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Tests
{
    public class PlayerTests
    {
        [Test]
        public void WhenPlayerMoves_ThenCurrentSpaceMustChange()
        {
            //Arrange
            int expectedSpace = 10;

            Mock<ILogger> mockLogger = new Mock<ILogger> ();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);

            //Act
            testPlayer.MoveTo(10);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }

        [Test]
        public void WhenPlayerMovesForward_ThenSpacesMustAddUp()
        {
            //Arrange
            int currentSpace = 10;
            int spacesToMove = 5;
            int expectedSpace = 15;
            int endOfBoard = 63;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.CurrentSpace = currentSpace;

            //Act
            int destination = testPlayer.CalculateDestination(spacesToMove, endOfBoard);

            //Assert
            Assert.That(destination, Is.EqualTo(expectedSpace));
        }

        [Test]
        public void WhenPlayerMovesBackwards_ThenSpacesMustBeSubstracted()
        {
            //Arrange
            int currentSpace = 10;
            int spacesToMove = 5;
            int expectedSpace = 5;
            int endOfBoard = 63;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer.CurrentSpace = currentSpace;
            testPlayer.Direction = Direction.backwards;

            //Act
            int destination = testPlayer.CalculateDestination(spacesToMove, endOfBoard);

            //Assert
            Assert.That(destination, Is.EqualTo(expectedSpace));
        }
    }
}
