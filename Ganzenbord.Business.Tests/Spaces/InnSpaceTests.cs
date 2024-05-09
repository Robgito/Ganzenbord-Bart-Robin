using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using Moq;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class InnSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnInnSpace_ThenPlayerSkips1Turn()
        {
            //Arrange
            int expectedTurnSkips = 1;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testInnSpace = new InnSpace(10, mockLogger.Object);

            //Act
            testInnSpace.SpaceEffect(testPlayer);

            //Assert
            Assert.That(expectedTurnSkips, Is.EqualTo(testPlayer.TurnsToSkip));
        }
    }
}