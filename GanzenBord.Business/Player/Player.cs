using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Spaces;
using System.Numerics;

namespace Ganzenbord.Business.Player
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        public int CurrentSpace { get; set; }
        public int PreviousSpace { get; set; }
        public Direction Direction { get; set; }
        public ILogger Logger { get; set; }
        public bool CanMove { get; set; }
        public int TurnsToSkip { get; set; }
        public int[] lastRoll { get; set; }

        public Player(string playerName, ILogger logger)
        {
            Name = playerName;
            CurrentSpace = 0;
            Direction = Direction.forwards;
            Logger = logger;
            CanMove = true;
            TurnsToSkip = 0;
        }

        public void MoveTo(int spaceId)
        {
            CurrentSpace = spaceId;
        }

        public int CalculateDestination(int spacesToMove, int endOfBoard)
        {
            int destination = CurrentSpace;

            for (int i = 0; i < spacesToMove; i++)
            {
                if (this.Direction == Direction.forwards)
                {
                    destination++;
                    if (destination == endOfBoard)
                    {
                        this.ChangeDirection();
                    }
                }
                else
                {
                    destination--;
                }
            }
            return destination;
        }

        public void ChangeDirection()
        {
            if (Direction == Direction.forwards)
            {
                Direction = Direction.backwards;
            }
            else
            {
                Direction = Direction.forwards;
            }
        }
    }
}
