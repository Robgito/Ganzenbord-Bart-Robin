using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class BridgeSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public BridgeSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
            player.CurrentSpace = 12;
            Logger.PrintMessage($"{player.Name} landed on a bridge! Go to space nr. {player.CurrentSpace}!");
        }
    }
}
