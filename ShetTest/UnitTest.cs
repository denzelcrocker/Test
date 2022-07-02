using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shet;

namespace ShetTest
{
    [TestClass]
    public class UnitTest
    {
        Plus plus = new Plus();
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 2;
            int except = 3;
            int actual = plus.sum(a, b);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 11;
            int b = 2;
            int except = 3;
            int actual = plus.sum(a, b);
            Assert.AreEqual(except, actual);
        }
    }
}
