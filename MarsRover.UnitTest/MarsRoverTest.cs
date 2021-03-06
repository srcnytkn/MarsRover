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

            string result;
            Management management = new Management();
            result = management.Manage(areaSize, roverPosition1, roverMoves1);

            Assert.AreEqual("1 3 N", result);
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

            string result;
            Management management = new Management();
            result = management.Manage(areaSize, roverPosition2, roverMoves2);

            Assert.AreEqual("5 1 E", result);
        }
    }
}
