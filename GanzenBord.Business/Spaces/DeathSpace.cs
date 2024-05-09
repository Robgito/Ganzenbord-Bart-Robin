﻿using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Spaces
{
    public class DeathSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public DeathSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
            player.CurrentSpace = 0;
            printDeath();
            Logger.PrintMessage($"{player.Name} landed on Death! Go back to start!");
        }

        public void printDeath()
        {
            Logger.PrintMessage("                                           .\"\"--.._");
            Logger.PrintMessage("                                           []      `'--.._");
            Logger.PrintMessage("                                           ||__           `'-,");
            Logger.PrintMessage("                                         `)||_ ```'--..       \\");
            Logger.PrintMessage("                     _                    /|//}        ``--._  |");
            Logger.PrintMessage("                  .'` `'.                /////}              `\\/");
            Logger.PrintMessage("                 /  .\"\"\".\\              //{///    ");
            Logger.PrintMessage("                /  /_  _`\\\\            // `||");
            Logger.PrintMessage("                | |(_)(_)||          _//   ||");
            Logger.PrintMessage("                | |  /\\  )|        _///\\   ||");
            Logger.PrintMessage("                | |L====J |       / |/ |   ||");
            Logger.PrintMessage("               /  /'-..-' /    .'`  \\  |   ||");
            Logger.PrintMessage("              /   |  :: | |_.-`      |  \\  ||");
            Logger.PrintMessage("             /|   `\\-::.| |          \\   | ||");
            Logger.PrintMessage("           /` `|   /    | |          |   / ||");
            Logger.PrintMessage("         |`    \\   |    / /          \\  |  ||");
            Logger.PrintMessage("        |       `\\_|    |/      ,.__. \\ |  ||");
            Logger.PrintMessage("        /                     /`    `\\ ||  ||");
            Logger.PrintMessage("       |           .         /        \\||  ||");
            Logger.PrintMessage("       |                     |         |/  ||");
            Logger.PrintMessage("       /         /           |         (   ||");
            Logger.PrintMessage("      /          .           /          )  ||");
            Logger.PrintMessage("     |            \\          |             ||");
            Logger.PrintMessage("    /             |          /             ||");
            Logger.PrintMessage("   |\\            /          |              ||");
            Logger.PrintMessage("   \\ `-._       |           /              ||");
            Logger.PrintMessage("    \\ ,//`\\    /`           |              ||");
            Logger.PrintMessage("     ///\\  \\  |             \\              ||");
            Logger.PrintMessage("    |||| ) |__/             |              ||");
            Logger.PrintMessage("    |||| `.(                |              ||");
            Logger.PrintMessage("    `\\\\` /`                 /              ||");
            Logger.PrintMessage("       /`                   /              ||");
            Logger.PrintMessage("      /                     |              ||");
            Logger.PrintMessage("     |                      \\              ||");
            Logger.PrintMessage("    /                        |             ||");
            Logger.PrintMessage("  /`                          \\            ||");
            Logger.PrintMessage("/`                            |            ||");
            Logger.PrintMessage("`-.___,-.      .-.        ___,'            ||");
        }
    }
}
