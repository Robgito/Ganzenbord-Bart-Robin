﻿using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class MazeSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public MazeSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
            player.CurrentSpace = 39;
            Logger.PrintMessage($"{player.Name} landed on a Maze! Go to space nr. {player.CurrentSpace}!");
        }
    }
}
