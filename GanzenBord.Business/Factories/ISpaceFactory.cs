using Ganzenbord.Business.Spaces;
using GanzenBord.Business.Spaces;

namespace GanzenBord.Business.Factories
{
    public interface ISpaceFactory
    {
        ISpace Create(SpaceType spaceType, int spaceID, IBoard board);
    }
}