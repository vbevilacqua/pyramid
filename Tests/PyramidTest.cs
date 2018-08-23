using System;
using Pyramid;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{

    [TestClass]
    public class PyramidTest
    {
        private const string pyramid1 = @"
            1
            8 9
            1 5 9
            4 5 2 3";

        private const string pyramid2 = @"
            2
            9 8
            2 6 9
            3 4 1 2
            1 2 4 6 8";

        [TestMethod]
        public void Pyramid1EqualsTo16()
        {
            int expected = 16;
            int output = Pyramid.Program.GetSum(pyramid1);
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void Pyramid2EqualsTo24()
        {
            int expected = 24;
            int output = Pyramid.Program.GetSum(pyramid2);
            Assert.AreEqual(expected, output);
        }
    }
}