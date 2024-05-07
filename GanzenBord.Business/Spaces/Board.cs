using Ganzenbord.Business.Spaces;
using GanzenBord.Business.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord.Business.Spaces
{
    public class Board : IBoard
    {
        public List<ISpace> Spaces { get; set; }
        public ISpaceFactory SpaceFactory { get; set; }
        public Board(ISpaceFactory spaceFactory)
        {
            SpaceFactory = spaceFactory;
            Spaces = PrintSpaces();
        }

        public List<ISpace> PrintSpaces()
        {
            List<ISpace> spaces = new List<ISpace>();

            for (int i = 0; i <= 63; i++)
            {
                if (i == 5 || i == 9 || i == 14 || i == 18 || i == 23 || i == 27 || i == 32 || i == 36 || i == 41 || i == 45 || i == 50 || i == 54 || i == 59)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.goose, i, this));
                }
                else if (i == 0)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.start, i, this));
                }
                else if (i == 6)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.bridge, i, this));
                }
                else if (i == 19)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.inn, i, this));
                }
                else if (i == 31)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.well, i, this));
                }
                else if (i == 42)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.maze, i, this));
                }
                else if (i == 52)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.prison, i, this));
                }
                else if (i == 58)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.death, i, this));
                }
                else if (i == 63)
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.end, i, this));
                }
                else
                {
                    spaces.Add(SpaceFactory.Create(SpaceType.normal, i, this));
                }
            }
            return spaces;
        }
    }
}
