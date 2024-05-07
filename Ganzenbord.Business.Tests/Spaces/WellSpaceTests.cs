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
    public class WellSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnWellSpace_ThenPlayerIsUnableToMove()
        {
            bool expectedMovement = false;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testWellSpace = new WellSpace(10, mockLogger.Object);

            testWellSpace.SpaceEffect(testPlayer);

            Assert.That(testPlayer.CanMove, Is.EqualTo(expectedMovement));
        }

        [Test]
        public void WhenNewPlayerLandsOnAWell_ThenPlayerStuckGetsRescued()
        {
            bool expectedMovementPlayer1 = true;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer1 = new Player.Player("testPlayer", mockLogger.Object);
            testPlayer1.CanMove = false;
            IPlayer testPlayer2 = new Player.Player("testPlayer", mockLogger.Object);
            WellSpace testWellSpace = new WellSpace(10, mockLogger.Object);
            testWellSpace.PlayerStuckInWell = testPlayer1; 

            testWellSpace.SpaceEffect(testPlayer2);

            Assert.That(testPlayer1.CanMove, Is.EqualTo(expectedMovementPlayer1));
        }
    }
}
