using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingSample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Calculator = new Calculator();
            int result = Calculator.Add(10, 2);
            Assert.AreEqual(12, result);

        }
    }
}
