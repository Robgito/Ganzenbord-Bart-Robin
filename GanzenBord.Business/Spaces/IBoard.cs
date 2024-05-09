using Ganzenbord.Business.Spaces;
using GanzenBord.Business.Factories;

namespace GanzenBord.Business.Spaces
{
    public interface IBoard
    {
        ISpaceFactory SpaceFactory { get; set; }
        List<ISpace> Spaces { get; set; }

        List<ISpace> PrintSpaces();
    }
}