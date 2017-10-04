using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Methods;

namespace MyTestProject
{
    [TestClass]
    public class AverageTest
    {
        [TestMethod]
        public void TestAverageMethod()
        {
            double r = Program.average(10, 11);
            Assert.AreEqual<double>(10.5, r);

        }

        [TestMethod]
        public void TestGCDMethod()
        {
            int r = Program.GCD(462, 1071);
            Assert.AreEqual<int>(21, r);
            r = Program.GCD(1071, 462);
            Assert.AreEqual<int>(21, r);

        }
    }
}
