using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class WellSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }
        public IPlayer PlayerStuckInWell { get; set; }

        public WellSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
            if (PlayerStuckInWell != null)
            {
                PlayerStuckInWell.CanMove = true;
                Logger.PrintMessage($"{player.Name} rescued {PlayerStuckInWell.Name}!");
            }
            player.CanMove = false;
            PlayerStuckInWell = player;
            Logger.PrintMessage($"{player.Name} fell in a well and will be unable to move until rescued!");
        }
    }
}
