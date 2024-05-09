﻿using Ganzenbord.Business.Logger;
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
    public class DeathSpaceTests
    {
        [Test]
        public void WhenPlayerLandsOnDeath_ThenPlayerGoesToStart()
        {
            //Arrange
            int expectedSpace = 0;

            Mock<ILogger> mockLogger = new Mock<ILogger>();

            IPlayer testPlayer = new Player.Player("testPlayer", mockLogger.Object);
            ISpace testDeathSpace = new DeathSpace(10, mockLogger.Object);

            //Act
            testDeathSpace.SpaceEffect(testPlayer);

            //Assert
            Assert.That(testPlayer.CurrentSpace, Is.EqualTo(expectedSpace));
        }
    }
}
