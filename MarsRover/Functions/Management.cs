using MarsRover.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Functions
{
    public class Management
    {
        public void Manage(List<int> areaSize, string[] roverPosition1, char[] roverMoves1, string[] roverPosition2, char[] roverMoves2)
        {
            Movement movement = new Movement();
            Rotation rotation = new Rotation();
            Facing facing = new Facing();

            // First rover
            facing = rotation.SetFacing(roverPosition1[2]);
            int rover1_x = Int32.Parse(roverPosition1[0]);
            int rover1_y = Int32.Parse(roverPosition1[1]);

            foreach (var move in roverMoves1)
            {
                if (move == 'M')
                {
                    var result = movement.Move(facing, rover1_x, rover1_y);
                    rover1_x = result.Item1;
                    rover1_y = result.Item2;
                }
                else if (move == 'L' || move == 'R')
                {
                    facing = rotation.Rotate(move, facing);
                }

                if (rover1_x < 0 || rover1_x > areaSize[0] || rover1_y < 0 || rover1_y > areaSize[1])
                {
                    Console.WriteLine("Rover1 movenment is out of area.");
                    return;
                }
            }

            Console.WriteLine(String.Format("{0} {1} {2}", rover1_x, rover1_y, rotation.GetFinalRotation(facing)));


            // Second rover
            facing = rotation.SetFacing(roverPosition2[2]);
            int rover2_x = Int32.Parse(roverPosition2[0]);
            int rover2_y = Int32.Parse(roverPosition2[1]);

            foreach (var move in roverMoves2)
            {
                if (move == 'M')
                {
                    var result = movement.Move(facing, rover2_x, rover2_y);
                    rover2_x = result.Item1;
                    rover2_y = result.Item2;
                }
                else if (move == 'L' || move == 'R')
                {
                    facing = rotation.Rotate(move, facing);
                }

                if (rover2_x < 0 || rover2_x > areaSize[0] || rover2_y < 0 || rover2_y > areaSize[1])
                {
                    Console.WriteLine("Rover2 movenment is out of area.");
                    return;
                }
                if (rover2_x == rover1_x && rover2_y == rover1_y)
                {
                    Console.WriteLine("There is rover1 in the coordinates.");
                    return;
                }
            }

            Console.WriteLine(String.Format("{0} {1} {2}", rover2_x, rover2_y, rotation.GetFinalRotation(facing)));
        }
    }
}
