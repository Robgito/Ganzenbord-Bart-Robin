using Ganzenbord.Business.Player;

namespace GanzenBord.Business.Factories
{
    public interface IPlayerFactory
    {
        IPlayer Create(string playerName);
    }
}