using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using GanzenBord.Business.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class GooseSpace : Space
    {
        public int SpaceID { get ; set; }
        public ILogger Logger { get ; set ; }
        public IBoard Board { get ; set ; }

        public GooseSpace(int spaceID, ILogger logger, IBoard board) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
            Board = board;
        }
        public override void SpaceEffect(IPlayer player)
        {
            PrintGoose();
            Logger.PrintMessage($"{player.Name} landed on a goose! Move the same amount of spaces again!");
            player.MoveTo(player.CalculateDestination(player.lastRoll.Sum(), Board.Spaces.Count - 1));
        }
        public void PrintGoose()
        {
            Logger.PrintMessage("      _.-.");
            Logger.PrintMessage(" __.-' ,  \\");
            Logger.PrintMessage("'--'-'._   \\");
            Logger.PrintMessage("        '.  \\");
            Logger.PrintMessage("         )-- \\ __.--._");
            Logger.PrintMessage("        /   .'        '--.");
            Logger.PrintMessage("       .               _/-._");
            Logger.PrintMessage("       :       ____._/   _-'");
            Logger.PrintMessage("        '._          _.'-'");
            Logger.PrintMessage("           '-._    _.'");
            Logger.PrintMessage("               \\_|/");
            Logger.PrintMessage("              __|||");
            Logger.PrintMessage("              >__/'");
        }
    }
}
