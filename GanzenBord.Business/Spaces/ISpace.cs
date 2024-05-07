using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace Ganzenbord.Business.Spaces
{
    public interface ISpace
    {
        ILogger Logger { get; set; }
        int SpaceID { get; set; }
        void SpaceEffect(IPlayer player);
    }
}