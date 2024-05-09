using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using Moq;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class BridgeSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnBridge_ThenPlayerGoesToSpace12()
        {
            //Arrange
            int expectedSpace = 12;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testBridgeSpace = new BridgeSpace(10, mockLogger.Object);

            //Act
            testBridgeSpace.SpaceEffect(testPlayer);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }
    }
}