using MarsRover.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Functions
{
    public class Management
    {
        public string Manage(List<int> areaSize, string[] roverPosition, char[] roverMoves)
        {
            Movement movement = new Movement();
            Rotation rotation = new Rotation();
            Facing facing = new Facing();
            string response;

            
            facing = rotation.SetFacing(roverPosition[2]);
            int rover_x = Int32.Parse(roverPosition[0]);
            int rover_y = Int32.Parse(roverPosition[1]);

            foreach (var move in roverMoves)
            {
                if (move == 'M')
                {
                    var result = movement.Move(facing, rover_x, rover_y);
                    rover_x = result.Item1;
                    rover_y = result.Item2;
                }
                else if (move == 'L' || move == 'R')
                {
                    facing = rotation.Rotate(move, facing);
                }

                if (rover_x < 0 || rover_x > areaSize[0] || rover_y < 0 || rover_y > areaSize[1])
                {
                    response = "Rover1 movement is out of area.";
                    Console.WriteLine("Rover1 movement is out of area.");
                    return response;
                }
            }
            response = String.Format("{0} {1} {2}", rover_x, rover_y, rotation.GetFinalRotation(facing));
            return response;

            
        }
    }
}
