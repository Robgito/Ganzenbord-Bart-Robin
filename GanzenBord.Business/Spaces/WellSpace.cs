using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

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
                printWell();
            }
            player.CanMove = false;
            PlayerStuckInWell = player;

            Logger.PrintMessage($"{player.Name} fell in a well and will be unable to move until rescued!");
            printWell();
        }

        public void printWell()
        {
            Logger.PrintMessage("                 __");
            Logger.PrintMessage("               .'/\\'.");
            Logger.PrintMessage("             .'-/__\\-'.");
            Logger.PrintMessage("           .'--/____\\--'.");
            Logger.PrintMessage("         .'--./______\\.--'.");
            Logger.PrintMessage("       .'--../________\\..--'.");
            Logger.PrintMessage("     .'--.._/__________\\__..--'.");
            Logger.PrintMessage("   .'--..__/____________\\__..--'.");
            Logger.PrintMessage(" .'--..___/______________\\___..--'.");
            Logger.PrintMessage("'========'================'========'");
            Logger.PrintMessage("      [_|__]            [_|__]");
            Logger.PrintMessage("     =[__|_]=====''=====[__|_]==.");
            Logger.PrintMessage("      [__|_]     ||     [__|_]  |");
            Logger.PrintMessage("      [_|__]  .--JL--.  [_|__]  '===O");
            Logger.PrintMessage("      [__|_]   \\====/   [__|_]");
            Logger.PrintMessage("      [_|__]_.-| .; |-._[_|__]");
            Logger.PrintMessage("      [__|_]'._ \\__/(_.'[__|_]");
            Logger.PrintMessage("      [.-._]            [_.-.]");
            Logger.PrintMessage("      [_.-.'--..____..--'.-._]");
            Logger.PrintMessage("      [(_.'   .-.     .-.'._)\\ ");
            Logger.PrintMessage("      [  .-. (_.'.-. (_.' .-.]");
            Logger.PrintMessage("      [ (_.'.-. (_.' .-. (_.'|   ");
            Logger.PrintMessage("      /.-.  (_.'.-.  (_.' .-.]     ");
            Logger.PrintMessage("     ['._).-. (_.'   .-.(_.'] ");
            Logger.PrintMessage("      [   (_.'.-.  .-.'._)   \\   ");
            Logger.PrintMessage("      '-._    '._) '._)   _.-'");
            Logger.PrintMessage("           `---..____..---'      ");
        }
    }
}