using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using Ganzenbord.Business.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
