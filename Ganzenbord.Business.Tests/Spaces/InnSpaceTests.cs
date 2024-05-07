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
    public class InnSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnInnSpace_ThenPlayerSkips1Turn()
        {
            int expectedTurnSkips = 1;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testInnSpace = new InnSpace(10, mockLogger.Object);

            testInnSpace.SpaceEffect(testPlayer);

            Assert.That(expectedTurnSkips, Is.EqualTo(testPlayer.TurnsToSkip));
        }
    }
}
