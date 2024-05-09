using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganzenbord.Business.Spaces
{
    public class EndSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public EndSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public override void SpaceEffect(IPlayer player)
        {
<<<<<<< HEAD
            printMasterOfGeese();
            Logger.PrintMessage($"{player.Name} wins!");
=======
            Logger.PrintMessage($"{player.Name} WINS!! You are The Master of Geese!");
>>>>>>> 79b5d9b3e0439b92fe3d1d0ffece549aee71aac4
        }

        public void printMasterOfGeese()
        {
            Logger.PrintMessage("         ,                                      ,");
            Logger.PrintMessage("        |\\                                      /|");
            Logger.PrintMessage("     ,   \\'._ ,                           ,  _.'/   ,");
            Logger.PrintMessage("     |\\  {'. '-`\\,      ,-._**_.-,      ,/'-' .'}  /|");
            Logger.PrintMessage("      \\`'-'-.  '.`\\      \\*____*/      /`.'  .-'-'`/");
            Logger.PrintMessage("    ,'-'-._  '.  ) )     /`    `\\     ( (  .'  _.-'-,");
            Logger.PrintMessage("    |\\'- _ '.   , /     /  /\"\"\\  \\     \\ ,  .'  _ -'/|");
            Logger.PrintMessage("     \\'.   .  ; (      \\_|^  ^|_/      ) ;   .  .-'/'");
            Logger.PrintMessage("      `'--, . ;  {`-.      \\__/      .-'}  ; . ,--'`");
            Logger.PrintMessage("      '--`_. ;  { ^  \\    _|  |_    /  ^ }  ; ._`--'");
            Logger.PrintMessage("      `,_.--  ;  { ^  `-'`      `'-`  ^ }  ;  --._,`");
            Logger.PrintMessage("        ,_.-    ; {^    /        \\    ^} ;    -._,");
            Logger.PrintMessage("         ,_.-`), /\\{^,/\\\\_'_/\\_'_//\\,^}/\\ ,(`-._,");
            Logger.PrintMessage("           _.'.-` /.'   \\        /   `.\\ `-.'._");
            Logger.PrintMessage("          `  _.' `       \\      /       ` '._   `");
            Logger.PrintMessage("                        .-'.  .'-.");
            Logger.PrintMessage("                      .'    `` ^  '.");
            Logger.PrintMessage("                     /  ^ ^   ^  ^  \\");
            Logger.PrintMessage("                     | ^    ^   ^   |");
            Logger.PrintMessage("                    /^   ^/    \\  ^  \\");
            Logger.PrintMessage("                    \\,_^_/    ^ \\_,^./");
            Logger.PrintMessage("                     /=/  \\^   /  \\=\\");
            Logger.PrintMessage("                 __ /=/_   | ^|   _\\=\\ __");
            Logger.PrintMessage("               <(=,'=(==,) |  | (,==)=',=)>");
            Logger.PrintMessage("                 /_/|_\\    /  \\    /_|\\_\\");
            Logger.PrintMessage("                 `V (=|  .'    '.  |=) V`");
            Logger.PrintMessage("                     V  / _/  \\_ \\  V");
            Logger.PrintMessage("                       `\"` \\  / `\"`");
            Logger.PrintMessage("                            \\(");
        }
    }
}
