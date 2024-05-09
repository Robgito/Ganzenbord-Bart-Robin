using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using Moq;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class MazeSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnMaze_ThenPlayerGoesToSpace39()
        {
            //Arrange
            int expectedSpace = 39;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testMazeSpace = new MazeSpace(42, mockLogger.Object);

            //Act
            testMazeSpace.SpaceEffect(testPlayer);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }
    }
}