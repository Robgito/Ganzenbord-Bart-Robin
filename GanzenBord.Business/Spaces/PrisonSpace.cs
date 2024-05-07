using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class PrisonSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public PrisonSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
            player.TurnsToSkip = 3;
            Logger.PrintMessage($"{player.Name} landed on an inn! Skip 3 turns!"); 
        }
    }
}
