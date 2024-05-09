using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

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
            printMaze();
        }

        public void printMaze()
        {
            Logger.PrintMessage("___________________________________");
            Logger.PrintMessage("| _____ |   | ___ | ___ ___ | |   | |");
            Logger.PrintMessage("| |   | |_| |__ | |_| __|____ | | | |");
            Logger.PrintMessage("| | | |_________|__ |______ |___|_| |");
            Logger.PrintMessage("| |_|   | _______ |______ |   | ____|");
            Logger.PrintMessage("| ___ | |____ | |______ | |_| |____ |");
            Logger.PrintMessage("|___|_|____ | |   ___ | |________ | |");
            Logger.PrintMessage("|   ________| | |__ | |______ | | | |");
            Logger.PrintMessage("| | | ________| | __|____ | | | __| |");
            Logger.PrintMessage("|_| |__ |   | __|__ | ____| | |_| __|");
            Logger.PrintMessage("|   ____| | |____ | |__ |   |__ |__ |");
            Logger.PrintMessage("| |_______|_______|___|___|___|_____|");
        }
    }
}