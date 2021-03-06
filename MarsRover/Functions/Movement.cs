using MarsRover.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Functions
{

    public class Movement
    {
        public Tuple<int,int> Move(Facing facing, int x, int y)
        {
            if(facing == Facing.East)
                return Tuple.Create(x + 1, y);
            else if (facing == Facing.West)
                return Tuple.Create(x - 1, y);
            else if (facing == Facing.North)
                return Tuple.Create(x, y+1);
            else if (facing == Facing.South)
                return Tuple.Create(x, y-1);
            else
            {
                Console.WriteLine("Facing is not recognized.");
                return Tuple.Create(x, y);
            }
        }
    }
}
