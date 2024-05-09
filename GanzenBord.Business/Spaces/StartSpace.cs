using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;

namespace GanzenBord.Business.Spaces
{
    internal class StartSpace : Space
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public StartSpace(int spaceID, ILogger logger) : base(spaceID, logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }

        public override void SpaceEffect(IPlayer player)
        {
            Logger.PrintMessage($"{player.Name} is went back to Start!");
        }
    }
}