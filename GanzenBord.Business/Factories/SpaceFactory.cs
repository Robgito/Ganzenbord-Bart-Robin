using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Spaces;
using GanzenBord.Business.Spaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord.Business.Factories
{
    public class SpaceFactory : ISpaceFactory
    {
        private ILogger logger;

        public SpaceFactory(ILogger Logger)
        {
            this.logger = Logger;
        }

        public ISpace Create(SpaceType spaceType, int spaceID, IBoard board)
        {
            switch (spaceType)
            {
                case SpaceType.normal:
                    return new Space(spaceID, logger);
                case SpaceType.goose:
                    return new GooseSpace(spaceID, logger, board);
                case SpaceType.bridge:
                    return new BridgeSpace(spaceID, logger);
                case SpaceType.inn:
                    return new InnSpace(spaceID, logger);
                case SpaceType.well:
                    return new WellSpace(spaceID, logger);
                case SpaceType.maze:
                    return new MazeSpace(spaceID, logger);
                case SpaceType.prison:
                    return new PrisonSpace(spaceID, logger);
                case SpaceType.death:
                    return new DeathSpace(spaceID, logger);
                case SpaceType.end:
                    return new EndSpace(spaceID, logger);
                case SpaceType.start:
                    return new StartSpace(spaceID, logger);
                default:
                    throw new ArgumentException(nameof(spaceType));
            }
        }
    }
}
