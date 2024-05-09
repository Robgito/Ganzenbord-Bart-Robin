using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;

namespace GanzenBord.Business.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        private ILogger logger;

        public PlayerFactory(ILogger Logger)
        {
            this.logger = Logger;
        }

        public IPlayer Create(string playerName)
        {
            return new Player(playerName, logger);
        }
    }
}