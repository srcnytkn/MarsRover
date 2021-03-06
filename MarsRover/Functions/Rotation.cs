using MarsRover.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Functions
{
    public class Rotation
    {
        public Facing Rotate(char rotate, Facing facing)
        {
            if(rotate == 'L')
            {
                if (facing == Facing.East)
                    return Facing.North;
                else if (facing == Facing.North)
                    return Facing.West;
                else if (facing == Facing.West)
                    return Facing.South;
                else if (facing == Facing.South)
                    return Facing.East;
                else
                {
                    Console.WriteLine("Rotation can not be done.");
                    return facing;
                }
            }
            else if (rotate == 'R')
            {
                if (facing == Facing.East)
                    return Facing.South;
                else if (facing == Facing.North)
                    return Facing.East;
                else if (facing == Facing.West)
                    return Facing.North;
                else if (facing == Facing.South)
                    return Facing.West;
                else
                {
                    Console.WriteLine("Rotation can not be done.");
                    return facing;
                }
            }
            else
            {
                Console.WriteLine("Rotation can not be done.");
                return facing;
            }
        }
        public string GetFinalRotation(Facing facing)
        {
            string finalRotation;
            if (facing == Facing.East)
                finalRotation = "E";
            else if (facing == Facing.West)
                finalRotation = "W";
            else if (facing == Facing.South)
                finalRotation = "S";
            else if (facing == Facing.North)
                finalRotation = "N";
            else
                finalRotation = "";
            
            return finalRotation;
        }
        public Facing SetFacing(string face)
        {
            if (face == "N")
                return Facing.North;
            else if (face == "E")
                return Facing.East;
            else if (face == "S")
                return Facing.South;
            else
                return Facing.West;
        }
    }
}
