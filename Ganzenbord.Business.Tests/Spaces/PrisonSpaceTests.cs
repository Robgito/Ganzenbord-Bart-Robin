using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using Moq;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class PrisonSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnPrisonSpace_ThenPlayerSkips3Turn()
        {
            //Arrange
            int expectedTurnSkips = 3;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testPrisonSpace = new PrisonSpace(10, mockLogger.Object);

            //Act
            testPrisonSpace.SpaceEffect(testPlayer);

            //Assert
            Assert.That(expectedTurnSkips, Is.EqualTo(testPlayer.TurnsToSkip));
        }
    }
}