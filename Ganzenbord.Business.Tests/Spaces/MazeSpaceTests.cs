using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class MazeSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnMaze_ThenPlayerGoesToSpace39()
        {
            int expectedSpace = 39;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testMazeSpace = new MazeSpace(42, mockLogger.Object);

            testMazeSpace.SpaceEffect(testPlayer);

            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }
    }
}
