using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace kataAsp.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void testMatrix()
        {
            var kataAsp = new kataAsp._Default();
            var matrixResult = kataAsp.Matrix();

            var matrix = new List<String>();

            matrix.Add("1/1");
            matrix.Add("10/0");
            matrix.Add("0/10");
            matrix.Add("5/5");
           
            Assert.IsTrue(Enumerable.SequenceEqual(matrix, matrixResult));
        }
        [TestMethod]
        public void testNashValue()
        {
            var kataAsp = new kataAsp._Default();
            var nashValueResult= kataAsp.NashValue();

            bool[] nashValue = new bool[2] { true, true };

            Assert.IsTrue(Enumerable.SequenceEqual(nashValue, nashValueResult));
        }
    }
}
