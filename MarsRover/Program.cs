using MarsRover.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> areaSize = new List<int>();
            areaSize = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

            var roverPosition1 = Console.ReadLine().Split(' ');
            var roverMoves1 = Console.ReadLine().ToCharArray();
            var roverPosition2 = Console.ReadLine().Split(' ');
            var roverMoves2 = Console.ReadLine().ToCharArray();

            Management management = new Management();
            string result;
            result = management.Manage(areaSize, roverPosition1, roverMoves1);
            Console.WriteLine(result);

            result = management.Manage(areaSize, roverPosition2, roverMoves2);
            Console.WriteLine(result);

            return;
        }
    }
}
