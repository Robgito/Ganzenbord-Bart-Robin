﻿using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

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
            Logger.PrintMessage($"{player.Name} WINS!! You are The Master of Geese!");
            printMasterOfGeese();
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
            Logger.PrintMessage("     \\'.   .  ; (       \\_|^  ^|_/      ) ;   .  .-'/'");
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