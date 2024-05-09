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
            printPrison();
            Logger.PrintMessage($"{player.Name} landed on the prison! Skip 3 turns!"); 
        }

        public void printPrison()
        {
            Logger.PrintMessage("                             -|             |-");
            Logger.PrintMessage("         -|                  [-_-_-_-_-_-_-_-]                  |-");
            Logger.PrintMessage("         [-_-_-_-_-]          |             |          [-_-_-_-_-]");
            Logger.PrintMessage("          | o   o |           [  0   0   0  ]           | o   o |");
            Logger.PrintMessage("           |     |    -|       |           |       |-    |     |");
            Logger.PrintMessage("           |     |_-___-___-___-|         |-___-___-___-_|     |");
            Logger.PrintMessage("           |  o  ]              [    0    ]              [  o  |");
            Logger.PrintMessage("           |     ]   o   o   o  [ _______ ]  o   o   o   [     | ----__________");
            Logger.PrintMessage(" _____----- |     ]              [ ||||||| ]              [     |");
            Logger.PrintMessage("           |     ]              [ ||||||| ]              [     |");
            Logger.PrintMessage("       _-_-|_____]--------------[_|||||||_]--------------[_____|-_-_");
            Logger.PrintMessage("      ( (__________------------_____________-------------_________) )");
        }
    }
}
