using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsASquare()
        {
            var a = 9;
            var result = LampSolver.ReturnStatus(a);
            Assert.AreEqual(1, result);
        }
    }
}
