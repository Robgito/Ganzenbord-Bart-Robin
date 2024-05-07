using Ganzenbord.Business.Dice;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Spaces;

namespace Ganzenbord.Business.Player
{
    public interface IPlayer
    {
        int CurrentSpace { get; set; }
        Direction Direction { get; set; }
        ILogger Logger { get; set; }
        string Name { get; set; }
        int PreviousSpace { get; set; }
        bool CanMove { get; set; }
        int TurnsToSkip { get; set; }
        int[] lastRoll { get; set; }

        int CalculateDestination(int spacesToMove, int endOfBoard);
        void MoveTo(int spaceId);
    }
}