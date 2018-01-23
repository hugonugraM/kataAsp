using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace kataAsp2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMatrix()
        {
            var kataAsp = new kataAsp2._Default();
            var matrixResult = kataAsp.Matrix();

            var matrix = new List<String>();

            matrix.Add("50/50");
            matrix.Add("20/40");
            matrix.Add("40/20");
            matrix.Add("27/27");

            Assert.IsTrue(Enumerable.SequenceEqual(matrix, matrixResult));
        }
        [TestMethod]
        public void testNashValue()
        {
            var kataAsp = new kataAsp2._Default();
            var nashValueResult = kataAsp.NashValue();

            bool[] nashValue = new bool[2] { true, true };

            Assert.IsTrue(Enumerable.SequenceEqual(nashValue, nashValueResult));
        }
    }
}
