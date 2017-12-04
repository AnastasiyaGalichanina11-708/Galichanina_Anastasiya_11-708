using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solver;

namespace TestOfMethodRight
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodRight()
        {
            int n = 1000;
            var result = ClassSolutions.SumMethodOfTheRight(n);
            Assert.AreEqual(0.697, result);
        }
        [TestMethod]
        public void TestMethodLeft()
        {
            int n = 1000;
            var result = ClassSolutions.SumMethodOfTheLeft(n);
            Assert.AreEqual(0.697, result);
        }
        [TestMethod]
        public void TestMethodMonteKarlo()
        {
            int n = 1000;
            var result = ClassSolutions.MethodMonteKarlo(n);
            Assert.AreEqual(0.697, result);
        }
        [TestMethod]
        public void TestMethodSimpson()
        {
            int n = 1000;
            var result = ClassSolutions.SimpsonsMethod(0,1.2,n);
            Assert.AreEqual(0.697, result);
        }
        [TestMethod]
        public void TestMethodTrapezium()
        {
            int n = 1000;
            var result = ClassSolutions.SumMethodTrapezium(n);
            Assert.AreEqual(0.697, result);
        }
    }
}
