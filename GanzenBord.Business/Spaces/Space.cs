using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Spaces
{
    public class Space : ISpace
    {
        public int SpaceID { get; set; }
        public ILogger Logger { get; set; }

        public Space(int spaceID, ILogger logger)
        {
            SpaceID = spaceID;
            Logger = logger;
        }
        public virtual void SpaceEffect(IPlayer player)
        {
            Logger.PrintMessage($"{player.Name} lands on space nr. {this.SpaceID}!");
        }
    }
}
