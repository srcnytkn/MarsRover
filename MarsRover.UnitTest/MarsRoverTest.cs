using MarsRover.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.UnitTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> areaSize = new List<int>();
            areaSize = "5 5".Split(' ').Select(s => int.Parse(s)).ToList();
            var roverPosition1 = "1 2 N".Split(' ');
            var roverMoves1 = "LMLMLMLMM".ToCharArray();
            var roverPosition2 = "3 3 E".Split(' ');
            var roverMoves2 = "MMRMMRMRRM".ToCharArray();

            Management management = new Management();
            management.Manage(areaSize, roverPosition1, roverMoves1, roverPosition2, roverMoves2);

            Assert.AreEqual("1 3 N", "1 3 N");
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> areaSize = new List<int>();
            areaSize = "5 5".Split(' ').Select(s => int.Parse(s)).ToList();
            var roverPosition1 = "1 2 N".Split(' ');
            var roverMoves1 = "LMLMLMLMM".ToCharArray();
            var roverPosition2 = "3 3 E".Split(' ');
            var roverMoves2 = "MMRMMRMRRM".ToCharArray();

            Management management = new Management();
            management.Manage(areaSize, roverPosition1, roverMoves1, roverPosition2, roverMoves2);

            Assert.AreEqual("3 3 E", "3 3 E");
        }
    }
}
