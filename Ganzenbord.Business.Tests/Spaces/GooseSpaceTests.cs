using Ganzenbord.Business.Dice;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using GanzenBord.Business.Factories;
using GanzenBord.Business.Spaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Tests.Spaces
{
    public class GooseSpaceTests
    {
        [Test]
        public void IfPlayerLandsOnGoose_ThenPlayerMovesSameAmountOfSpacesAgain()
        {
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

            testGooseSpace.SpaceEffect(testPlayer);

            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedDestination));
        }
    }
}
