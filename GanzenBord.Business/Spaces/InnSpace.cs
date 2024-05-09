using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class InnSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public InnSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
            player.TurnsToSkip = 1;
            printInn();
            Logger.PrintMessage($"{player.Name} landed on an inn! Skip 1 turn!");
        }

        public void printInn()
        {
            Logger.PrintMessage("         (");
            Logger.PrintMessage("           )");
            Logger.PrintMessage("         ( _   _._");
            Logger.PrintMessage("          |_|-'_~_`-._");
            Logger.PrintMessage("       _.-'-_~_-~_-~-_`-._");
            Logger.PrintMessage("   _.-'_~-_~-_-~-_~_~-_~-_`-._");
            Logger.PrintMessage("  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Logger.PrintMessage("    |  []  []   []   []  [] |");
            Logger.PrintMessage("    |           __    ___   |");
            Logger.PrintMessage("  ._|  []  []  | .|  [___]  |_._.");
            Logger.PrintMessage("  |=|________()|__|()_______|=|=");
            Logger.PrintMessage("^^^^^^^^^^^^^^^ === ^^^^^^^^^^^^^^^");
            Logger.PrintMessage("    _______      ===");
            Logger.PrintMessage("   <__INN__>       ===");
            Logger.PrintMessage("      ^|^             ===");
            Logger.PrintMessage("       |                 ===");
        }
    }
}
